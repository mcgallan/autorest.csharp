// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtKeyvault.Models
{
    /// <summary> Parameters for updating the access policy in a vault. </summary>
    public partial class VaultAccessPolicyParameters : Azure.ResourceManager.Models.Resource
    {
        /// <summary> Initializes a new instance of VaultAccessPolicyParameters. </summary>
        /// <param name="properties"> Properties of the access policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public VaultAccessPolicyParameters(VaultAccessPolicyProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of VaultAccessPolicyParameters. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The resource type of the access policy. </param>
        /// <param name="properties"> Properties of the access policy. </param>
        internal VaultAccessPolicyParameters(ResourceIdentifier id, string name, ResourceType type, string location, VaultAccessPolicyProperties properties) : base(id, name, type)
        {
            Location = location;
            Properties = properties;
        }

        /// <summary> The resource type of the access policy. </summary>
        public string Location { get; }
        /// <summary> Properties of the access policy. </summary>
        public VaultAccessPolicyProperties Properties { get; set; }
    }
}
