// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Type.Model.Inheritance.NestedDiscriminator.Models
{
    /// <summary> Unknown version of Fish. </summary>
    internal partial class UnknownFish : Fish
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFish"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="age"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownFish(string kind, int age, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, age, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFish"/> for deserialization. </summary>
        internal UnknownFish()
        {
        }
    }
}