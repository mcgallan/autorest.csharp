// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CustomizationsInTsp.Models
{
    internal static partial class EnumWithValueToRenameExtensions
    {
        public static string ToSerialString(this EnumWithValueToRename value) => value switch
        {
            EnumWithValueToRename.One => "1",
            EnumWithValueToRename.Two => "2",
            EnumWithValueToRename.Three => "3",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EnumWithValueToRename value.")
        };

        public static EnumWithValueToRename ToEnumWithValueToRename(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "1")) return EnumWithValueToRename.One;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "2")) return EnumWithValueToRename.Two;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "3")) return EnumWithValueToRename.Three;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EnumWithValueToRename value.");
        }
    }
}