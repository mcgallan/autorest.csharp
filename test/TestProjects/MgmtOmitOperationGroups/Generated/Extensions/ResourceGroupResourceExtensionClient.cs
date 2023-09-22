// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtOmitOperationGroups.Models;

namespace MgmtOmitOperationGroups
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _model5sClientDiagnostics;
        private Model5SRestOperations _model5sRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics Model5sClientDiagnostics => _model5sClientDiagnostics ??= new ClientDiagnostics("MgmtOmitOperationGroups", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private Model5SRestOperations Model5sRestClient => _model5sRestClient ??= new Model5SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of Model2Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of Model2Resources and their operations over a Model2Resource. </returns>
        public virtual Model2Collection GetModel2s()
        {
            return GetCachedClient(Client => new Model2Collection(Client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Model5s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Model5" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Model5> GetModel5sAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => Model5sRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, Model5.DeserializeModel5, Model5sClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetModel5s", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Model5s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Model5" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Model5> GetModel5s(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => Model5sRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, Model5.DeserializeModel5, Model5sClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetModel5s", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Model5s_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="model5"> The Model5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Model5>> CreateOrUpdateModel5Async(string model5SName, Model5 model5, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CreateOrUpdateModel5");
            scope.Start();
            try
            {
                var response = await Model5sRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, model5SName, model5, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Model5s_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="model5"> The Model5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model5> CreateOrUpdateModel5(string model5SName, Model5 model5, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CreateOrUpdateModel5");
            scope.Start();
            try
            {
                var response = Model5sRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, model5SName, model5, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Model5s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Model5>> GetModel5Async(string model5SName, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetModel5");
            scope.Start();
            try
            {
                var response = await Model5sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, model5SName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Model5s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model5> GetModel5(string model5SName, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetModel5");
            scope.Start();
            try
            {
                var response = Model5sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, model5SName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}