using System;
using System.Linq;
using JsonKnownTypes;
using MessagePack;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionBarSlot : MonoBehaviour
{
    public TextMeshProUGUI Label;
    public RawImage Icon;
    public TextMeshProUGUI InputLabel;
    public Image InputIcon;
    public TextMeshProUGUI QuantityRemaining;
    public Image Fill;
    private ActionBarBinding binding;

    public Entity Entity { get; set; }

    public ActionBarBinding Binding
    {
        get => binding;
        set
        {
            binding = value;
            if (binding == null)
            {
                QuantityRemaining.gameObject.SetActive(false);
                Icon.gameObject.SetActive(false);
            }
        }
    }

    private void Update()
    {
        Binding?.Update();
    }

    public SavedActionBarBinding Save()
    {
        return Binding switch
        {
            ActionBarConsumableBinding actionBarConsumableBinding => new SavedActionBarConsumableBinding
            {
                Target = new DatabaseLink<ConsumableItemData>{LinkID = actionBarConsumableBinding.Target.ID}
            },
            ActionBarGearBinding actionBarGearBinding => new SavedActionBarGearBinding
            {
                EquipmentIndex = Entity.Equipment.IndexOf(actionBarGearBinding.Item),
                BehaviorIndex = Array.IndexOf(actionBarGearBinding.Item.Behaviors, actionBarGearBinding.Behavior)
            },
            ActionBarWeaponGroupBinding actionBarWeaponGroupBinding => new SavedActionBarWeaponGroupBinding
            {
                Group = actionBarWeaponGroupBinding.Group
            },
            _ => null
        };
    }

    public void Restore(SavedActionBarBinding binding)
    {
        Binding = binding switch
        {
            SavedActionBarConsumableBinding savedActionBarConsumableBinding =>
                new ActionBarConsumableBinding(
                    Entity,
                    this,
                    savedActionBarConsumableBinding.Target.Value),
            SavedActionBarGearBinding savedActionBarGearBinding =>
                new ActionBarGearBinding(
                    Entity,
                    this,
                    Entity.Equipment[savedActionBarGearBinding.EquipmentIndex],
                    Entity.Equipment[savedActionBarGearBinding.EquipmentIndex]
                        .Behaviors[savedActionBarGearBinding.BehaviorIndex] as IActivatedBehavior),
            SavedActionBarWeaponGroupBinding savedActionBarWeaponGroupBinding =>
                new ActionBarWeaponGroupBinding(Entity, this, savedActionBarWeaponGroupBinding.Group),
            _ => null
        };
    }
}

public abstract class ActionBarBinding
{
    protected Entity Entity { get; }
    protected ActionBarSlot Slot { get; }
    public abstract void Activate();
    public abstract void Deactivate();
    public abstract void Update();
    public ActionBarBinding(Entity entity, ActionBarSlot slot)
    {
        Entity = entity;
        Slot = slot;
    }
}

public class ActionBarConsumableBinding : ActionBarBinding
{
    public ConsumableItemData Target;

    public ActionBarConsumableBinding(Entity entity, ActionBarSlot slot, ConsumableItemData target) : base(entity, slot)
    {
        Target = target;
        Slot.QuantityRemaining.gameObject.SetActive(true);
        var data = Target;
        if(!string.IsNullOrEmpty(data.Icon))
        {
            Slot.Label.gameObject.SetActive(false);
            Slot.Icon.gameObject.SetActive(true);
            Slot.Icon.texture = Resources.Load<Texture2D>(data.Icon.Substring("Assets/Resources/".Length).Split('.').First());
        }
        else Slot.Icon.gameObject.SetActive(false);
    }

    public override void Activate()
    {
        Entity.TryActivateConsumable(Target);
    }

    public override void Deactivate()
    {
    }

    public override void Update()
    {
        Slot.QuantityRemaining.text = $"{Entity.CountItemsInCargo(Target.ID)}";
        var instance = Entity.FindActiveConsumable(Target);
        if (instance == null) Slot.Fill.fillAmount = 0;
        else Slot.Fill.fillAmount = instance.RemainingDuration / instance.Data.Duration;
    }
}

public class ActionBarGearBinding : ActionBarBinding
{
    public EquippedItem Item { get; }
    public IActivatedBehavior Behavior { get; }

    public bool Active;

    public ActionBarGearBinding(Entity entity, ActionBarSlot slot, EquippedItem item, IActivatedBehavior behavior) : base(entity, slot)
    {
        Item = item;
        Behavior = behavior;
        Slot.QuantityRemaining.gameObject.SetActive(false);
        if(!string.IsNullOrEmpty(Item.Data.ActionBarIcon))
        {
            Slot.Label.gameObject.SetActive(false);
            Slot.Icon.gameObject.SetActive(true);
            Slot.Icon.texture = Resources.Load<Texture2D>(Item.Data.ActionBarIcon.Substring("Assets/Resources/".Length).Split('.').First());
        }
        else Slot.Icon.gameObject.SetActive(false);
    }

    public override void Activate()
    {
        Active = true;
        Behavior.Activate();
    }

    public override void Deactivate()
    {
        Active = false;
        Behavior.Deactivate();
    }

    public override void Update()
    {
        Slot.Fill.fillAmount = Active ? 1 : 0;
    }
}

[MessagePackObject]
public class ActionBarWeaponGroupBinding : ActionBarBinding
{
    [Key(0)] public int Group;

    public ActionBarWeaponGroupBinding(Entity entity, ActionBarSlot slot, int group) : base(entity, slot)
    {
        Group = group;
        slot.Label.text = $"G{Group}";
        Slot.Icon.gameObject.SetActive(false);
    }

    public override void Activate()
    {
        foreach (var weapon in Entity.TriggerGroups[Group].weapons)
        {
            weapon.Activate();
        }
    }

    public override void Deactivate()
    {
        foreach (var weapon in Entity.TriggerGroups[Group].weapons)
        {
            weapon.Deactivate();
        }
    }

    public override void Update()
    {
        
    }
}