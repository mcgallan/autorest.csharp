// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace _Type.Union.Models
{
    internal static partial class GetResponseProp3Extensions
    {
        public static GetResponseProp3 ToGetResponseProp3(this int value)
        {
            if (value == 1) return GetResponseProp3._1;
            if (value == 2) return GetResponseProp3._2;
            if (value == 3) return GetResponseProp3._3;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GetResponseProp3 value.");
        }
    }
}