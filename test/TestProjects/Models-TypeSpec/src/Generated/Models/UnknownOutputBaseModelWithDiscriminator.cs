// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ModelsTypeSpec.Models
{
    /// <summary> Unknown version of OutputBaseModelWithDiscriminator. </summary>
    internal partial class UnknownOutputBaseModelWithDiscriminator : OutputBaseModelWithDiscriminator
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOutputBaseModelWithDiscriminator"/>. </summary>
        /// <param name="kind"> Discriminator property for OutputBaseModelWithDiscriminator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOutputBaseModelWithDiscriminator(string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOutputBaseModelWithDiscriminator"/> for deserialization. </summary>
        internal UnknownOutputBaseModelWithDiscriminator()
        {
        }
    }
}