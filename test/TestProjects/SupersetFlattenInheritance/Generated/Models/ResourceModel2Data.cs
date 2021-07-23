// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the ResourceModel2 data model. </summary>
    public partial class ResourceModel2Data : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of ResourceModel2Data. </summary>
        public ResourceModel2Data()
        {
        }

        /// <summary> Initializes a new instance of ResourceModel2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="foo"></param>
        internal ResourceModel2Data(ResourceGroupResourceIdentifier id, string name, ResourceType type, string foo) : base(id, name, type)
        {
            Foo = foo;
        }

        public string Foo { get; set; }
    }
}
