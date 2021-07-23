// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing the SubscriptionLevelResource data model. </summary>
    public partial class SubscriptionLevelResourceData : TrackedResource<SubscriptionResourceIdentifier>
    {
        /// <summary> Initializes a new instance of SubscriptionLevelResourceData. </summary>
        /// <param name="location"> The location. </param>
        public SubscriptionLevelResourceData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SubscriptionLevelResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="new"></param>
        internal SubscriptionLevelResourceData(SubscriptionResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, string @new) : base(id, name, type, location, tags)
        {
            New = @new;
        }

        public string New { get; set; }
    }
}
