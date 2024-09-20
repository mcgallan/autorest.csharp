// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace _Azure.ResourceManager.Models.Resources.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class Mockable_AzureResourceManagerModelsResourcesArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="Mockable_AzureResourceManagerModelsResourcesArmClient"/> class for mocking. </summary>
        protected Mockable_AzureResourceManagerModelsResourcesArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="Mockable_AzureResourceManagerModelsResourcesArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Mockable_AzureResourceManagerModelsResourcesArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal Mockable_AzureResourceManagerModelsResourcesArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="TopLevelTrackedResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TopLevelTrackedResource.CreateResourceIdentifier" /> to create a <see cref="TopLevelTrackedResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TopLevelTrackedResource"/> object. </returns>
        public virtual TopLevelTrackedResource GetTopLevelTrackedResource(ResourceIdentifier id)
        {
            TopLevelTrackedResource.ValidateResourceId(id);
            return new TopLevelTrackedResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NestedProxyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NestedProxyResource.CreateResourceIdentifier" /> to create a <see cref="NestedProxyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NestedProxyResource"/> object. </returns>
        public virtual NestedProxyResource GetNestedProxyResource(ResourceIdentifier id)
        {
            NestedProxyResource.ValidateResourceId(id);
            return new NestedProxyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SingletonTrackedResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SingletonTrackedResource.CreateResourceIdentifier" /> to create a <see cref="SingletonTrackedResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SingletonTrackedResource"/> object. </returns>
        public virtual SingletonTrackedResource GetSingletonTrackedResource(ResourceIdentifier id)
        {
            SingletonTrackedResource.ValidateResourceId(id);
            return new SingletonTrackedResource(Client, id);
        }
    }
}
