﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : InstantWeaponEffectManager
{
    public Prototype ProjectilePrototype;
    public bool InheritVelocity;

    public override void Fire(InstantWeapon weapon, EquippedItem item, EntityInstance source, EntityInstance target)
    {
        var p = ProjectilePrototype.Instantiate<Projectile>();
        var hp = source.Entity.Hardpoints[item.Position.x, item.Position.y];
        var barrel = source.GetBarrel(hp);
        var angle = weapon.Spread / 2;
        p.SourceEntity = source.Entity;
        p.StartPosition = p.transform.position = barrel.position;
        p.Velocity = Quaternion.Euler(
                         Random.Range(-angle, angle), 
                         Random.Range(-angle, angle), 
                         Random.Range(-angle, angle)) * 
                     barrel.forward * 
                     weapon.Velocity;
        p.Damage = weapon.Damage;
        p.Range = weapon.Range;
        p.Penetration = weapon.Penetration;
        p.Spread = weapon.DamageSpread;
        p.DamageType = weapon.WeaponData.DamageType;
        p.Zone = source.Entity.Zone;
        p.Trail.Clear();
    }
}
