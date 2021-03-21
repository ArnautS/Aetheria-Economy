using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using static Unity.Mathematics.math;
using Random = Unity.Mathematics.Random;

public class LoadoutGenerator
{
    public Random Random;
    public ItemManager ItemManager { get; }
    public Sector Sector { get; }
    public SectorZone Zone { get; }
    public Faction Faction { get; }
    public float PriceExponent { get; }

    public LoadoutGenerator(
        ref Random random, 
        ItemManager itemManager, 
        Sector sector, 
        SectorZone zone, 
        Faction faction, 
        float priceExponent)
    {
        Random = random;
        ItemManager = itemManager;
        Sector = sector;
        Zone = zone;
        Faction = faction;
        PriceExponent = priceExponent;
    }
    
    public EntityPack GenerateShipLoadout()
    {
        var hull = ItemManager.CreateInstance(RandomHull(HullType.Ship)) as EquippableItem;
        var entity = new Ship(ItemManager, null, hull, ItemManager.GameplaySettings.DefaultEntitySettings);
        entity.Faction = Faction;
        OutfitEntity(entity);
        return EntitySerializer.Pack(entity);
    }

    public EntityPack GenerateTurretLoadout()
    {
        var hull = ItemManager.CreateInstance(RandomHull(HullType.Turret)) as EquippableItem;
        var entity = new OrbitalEntity(ItemManager, null, hull, Guid.Empty, ItemManager.GameplaySettings.DefaultEntitySettings);
        entity.Faction = Faction;
        OutfitEntity(entity);
        return EntitySerializer.Pack(entity);
    }

    public EntityPack GenerateStationLoadout()
    {
        var hullData = RandomHull(HullType.Station);
        var hull = ItemManager.CreateInstance(hullData) as EquippableItem;
        var entity = new OrbitalEntity(ItemManager, null, hull, Guid.Empty, ItemManager.GameplaySettings.DefaultEntitySettings);
        entity.Faction = Faction;
        OutfitEntity(entity);
        
        var emptyShape = entity.UnoccupiedSpace;
        
        var dockingBayData = RandomItem<DockingBayData>(2, item => item.Shape.FitsWithin(emptyShape, out _, out _));
        if (dockingBayData == null) throw new InvalidLoadoutException("No compatible docking bay found for station!");

        dockingBayData.Shape.FitsWithin(emptyShape, out var cargoRotation, out var cargoPosition);
        var dockingBay = ItemManager.CreateInstance(dockingBayData) as EquippableItem;
        dockingBay.Rotation = cargoRotation;
        if (!entity.TryEquip(dockingBay, cargoPosition))
        {
            throw new InvalidLoadoutException("Failed to equip selected docking bay!");
        }

        var cargo = entity.CargoBays.First();
        var inventory = RandomItems<EquippableItemData>(16, 1, 
            data => !(data is HullData hull && hull.HullType != HullType.Ship) && !(data is CargoBayData))
            .OrderByDescending(item=>item.Shape.Coordinates.Length);
        foreach (var item in inventory)
        {
            var instance = ItemManager.CreateInstance(item);
            cargo.TryStore(instance);
        }
        
        return EntitySerializer.Pack(entity);
    }

    public HullData RandomHull(HullType type)
    {
        return ItemManager.ItemData.GetAll<HullData>()
            .Where(item => item.HullType == type && (Faction == null || item.Manufacturer == Faction.ID || Faction.Allegiance.ContainsKey(item.Manufacturer)))
            .WeightedRandomElements(ref Random,
                item =>
                    (Faction == null || item.Manufacturer == Faction.ID ? 1 : Faction.Allegiance[item.Manufacturer]) / // Prioritize items from allied manufacturers
                    Zone.Distance[Sector.HomeZones[ItemManager.ItemData.Get<Faction>(item.Manufacturer)]] / // Penalize distance to manufacturer headquarters
                    pow(item.Price, PriceExponent), // Penalize item price to a controllable degree
                1
            ).FirstOrDefault();
    }
    
    public T[] RandomItems<T>(int count, float sizeExponent, Predicate<T> filter = null) where T : EquippableItemData
    {
        return ItemManager.ItemData.GetAll<T>()
            .Where(item => Sector.ContainsFaction(item.Manufacturer) &&
                           (Faction == null || item.Manufacturer == Faction.ID || Faction.Allegiance.ContainsKey(item.Manufacturer)) &&
                           (filter?.Invoke(item) ?? true))
            .WeightedRandomElements(ref Random, item =>
                    (Faction == null || item.Manufacturer == Faction.ID ? 1 : Faction.Allegiance[item.Manufacturer]) * // Prioritize items from allied manufacturers
                    pow(item.Shape.Coordinates.Length, sizeExponent) / // Prioritize larger items
                    Zone.Distance[Sector.HomeZones[ItemManager.ItemData.Get<Faction>(item.Manufacturer)]] / // Penalize distance to manufacturer headquarters
                    pow(item.Price, PriceExponent), // Penalize item price to a controllable degree
                count
            );
    }

    public T RandomItem<T>(float sizeExponent, Predicate<T> filter = null) where T : EquippableItemData
    {
        return RandomItems(1, sizeExponent, filter).FirstOrDefault();
    }
    
    public T RandomItem<T>(HardpointData hardpoint, float sizeExponent, Predicate<T> filter = null) where T : EquippableItemData
    {
        return RandomItem<T>(sizeExponent, item => item.HardpointType == hardpoint.Type &&
                                  (filter?.Invoke(item) ?? true) && 
                                  item.Shape.FitsWithin(hardpoint.Shape, hardpoint.Rotation, out _));
    }

    private void OutfitEntity(Entity entity)
    {
        var hullData = ItemManager.GetData(entity.Hull) as HullData;
        foreach (var v in hullData.Shape.Coordinates) entity.HullConductivity[v.x, v.y] = true;
        var previousItems = new List<EquippableItemData>();
        foreach (var hardpoint in hullData.Hardpoints.OrderByDescending(h=>h.Shape.Coordinates.Length))
        {
            if (hardpoint.Type == HardpointType.ControlModule)
            {
                var controllerData = RandomItem<GearData>(hardpoint, 2,
                    item => item.Behaviors.Any(b => entity is Ship && b is CockpitData || entity is OrbitalEntity && b is TurretControllerData));
                if (controllerData == null) throw new InvalidLoadoutException("No compatible controller found for entity!");
                var controller = ItemManager.CreateInstance(controllerData) as EquippableItem;
                if (!entity.TryEquip(controller))
                {
                    throw new InvalidLoadoutException($"Failed to equip selected {Enum.GetName(typeof(HardpointType), hardpoint.Type)}!");
                }
            }
            else
            {
                // If a previously selected item fits, use that one (this is why we must process larger hardpoints first)
                var itemData = previousItems
                    .FirstOrDefault(i => i.HardpointType == hardpoint.Type && i.Shape.FitsWithin(hardpoint.Shape, hardpoint.Rotation, out _));
                itemData ??= RandomItem<GearData>(hardpoint, 2);
                if (itemData == null) ItemManager.Log($"No compatible item found for entity {Enum.GetName(typeof(HardpointType), hardpoint.Type)} hardpoint!");
                else
                {
                    //throw new InvalidLoadoutException($"No compatible item found for entity {Enum.GetName(typeof(HardpointType), hardpoint.Type)} hardpoint!");
                    var item = ItemManager.CreateInstance(itemData) as EquippableItem;
                    if (!entity.TryEquip(item))
                    {
                        throw new InvalidLoadoutException($"Failed to equip selected {Enum.GetName(typeof(HardpointType), hardpoint.Type)}!");
                    }
                    previousItems.Add(itemData);
                }
            }
        }

        var emptyShape = entity.UnoccupiedSpace;
        
        var cargoData = RandomItem<CargoBayData>(3, item =>
            !(item is DockingBayData) &&
            item.Shape.FitsWithin(emptyShape, out _, out _));
        if (cargoData == null) throw new InvalidLoadoutException("No compatible cargo bay found for entity!");

        cargoData.Shape.FitsWithin(emptyShape, out var cargoRotation, out var cargoPosition);
        var cargo = ItemManager.CreateInstance(cargoData) as EquippableItem;
        cargo.Rotation = cargoRotation;
        if (!entity.TryEquip(cargo, cargoPosition))
            throw new InvalidLoadoutException("Failed to equip selected cargo bay!");

        emptyShape = entity.UnoccupiedSpace;

        var capacitorData = RandomItem<GearData>(2, item =>
            item.Behaviors.Any(b => b is CapacitorData) &&
            item.Shape.FitsWithin(emptyShape, out _, out _));
        if (capacitorData == null) throw new InvalidLoadoutException("No compatible capacitor found for entity!");

        capacitorData.Shape.FitsWithin(emptyShape, out var capacitorRotation, out var capacitorPosition);
        var capacitor = ItemManager.CreateInstance(capacitorData) as EquippableItem;
        capacitor.Rotation = capacitorRotation;
        if (!entity.TryEquip(capacitor, capacitorPosition))
            throw new InvalidLoadoutException("Failed to equip selected capacitor!");
    }
}

public class InvalidLoadoutException : Exception
{
    public InvalidLoadoutException()
    {
    }

    public InvalidLoadoutException(string message)
        : base(message)
    {
    }

    public InvalidLoadoutException(string message, Exception inner)
        : base(message, inner)
    {
    }
}