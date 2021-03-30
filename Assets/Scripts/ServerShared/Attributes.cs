﻿/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;

public class NameAttribute : Attribute
{
    public string Name;

    public NameAttribute(string name)
    {
        Name = name;
    }
}

public class OrderAttribute : Attribute
{
    public int Order;

    public OrderAttribute(int order)
    {
        Order = order;
    }
}

[AttributeUsage(AttributeTargets.Class)]
public class EntityTypeRestrictionAttribute : Attribute
{
    public readonly HullType Type;

    public EntityTypeRestrictionAttribute(HullType type)
    {
        Type = type;
    }
}

public class RuntimeInspectable : Attribute { }
// public class CategoryAttribute : Attribute
// {
//     public readonly Type Type;
//
//     public CategoryAttribute(Type type)
//     {
//         Type = type;
//     }
// }