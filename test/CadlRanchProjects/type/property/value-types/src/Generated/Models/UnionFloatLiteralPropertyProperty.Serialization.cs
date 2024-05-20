// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace _Type.Property.ValueTypes.Models
{
    internal static partial class UnionFloatLiteralPropertyPropertyExtensions
    {
        public static float ToSerialSingle(this UnionFloatLiteralPropertyProperty value) => value switch
        {
            UnionFloatLiteralPropertyProperty._43125 => 43.125F,
            UnionFloatLiteralPropertyProperty._46875 => 46.875F,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown UnionFloatLiteralPropertyProperty value.")
        };

        public static UnionFloatLiteralPropertyProperty ToUnionFloatLiteralPropertyProperty(this float value)
        {
            if (value == 43.125F) return UnionFloatLiteralPropertyProperty._43125;
            if (value == 46.875F) return UnionFloatLiteralPropertyProperty._46875;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown UnionFloatLiteralPropertyProperty value.");
        }
    }
}