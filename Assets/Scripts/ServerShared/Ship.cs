﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MessagePack;
using Unity.Mathematics;
using static Unity.Mathematics.math;

[MessagePackObject]
public class Ship : Entity
{
    
    // [Key("bindings")]   public Dictionary<KeyCode,Guid>    Bindings = new Dictionary<KeyCode,Guid>();
    //[IgnoreMember] public int HullHardpointCount;

    // [IgnoreMember] public Dictionary<Targetable, float> Contacts = new Dictionary<Targetable, float>();
    // [IgnoreMember] public Targetable Target;
    
    public Ship(GameContext context, Guid hull, IEnumerable<Guid> gear, IEnumerable<Guid> cargo, Guid zone, Guid corporation) : base(context, hull, gear, cargo, zone, corporation)
    {
    }

    public override void Update(float delta)
    {
        Position += Velocity * delta;
        base.Update(delta);
    }
}

