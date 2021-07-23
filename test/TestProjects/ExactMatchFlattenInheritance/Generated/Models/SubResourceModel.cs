// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> SubResource type has the following read-only properties. </summary>
    internal partial class SubResourceModel : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of SubResourceModel. </summary>
        internal SubResourceModel()
        {
        }

        public string Name { get; }
        public string Type { get; }
    }
}
