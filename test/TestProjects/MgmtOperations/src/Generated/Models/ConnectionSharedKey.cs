// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtOperations.Models
{
    /// <summary> Response for GetConnectionSharedKey API service call. </summary>
    public partial class ConnectionSharedKey : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionSharedKey"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="value"> The virtual network connection shared key value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionSharedKey(AzureLocation location, string value) : base(location)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionSharedKey"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="value"> The virtual network connection shared key value. </param>
        internal ConnectionSharedKey(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string value) : base(id, name, resourceType, systemData, tags, location)
        {
            Value = value;
        }

        /// <summary> The virtual network connection shared key value. </summary>
        public string Value { get; set; }
    }
}