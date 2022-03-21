// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtParamOrdering
{
    /// <summary> A class representing collection of EnvironmentContainerResource and their operations over its parent. </summary>
    public partial class EnvironmentContainerResourceCollection : ArmCollection, IEnumerable<EnvironmentContainerResource>, IAsyncEnumerable<EnvironmentContainerResource>
    {
        private readonly ClientDiagnostics _environmentContainerResourceEnvironmentContainersClientDiagnostics;
        private readonly EnvironmentContainersRestOperations _environmentContainerResourceEnvironmentContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerResourceCollection"/> class for mocking. </summary>
        protected EnvironmentContainerResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EnvironmentContainerResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _environmentContainerResourceEnvironmentContainersClientDiagnostics = new ClientDiagnostics("MgmtParamOrdering", EnvironmentContainerResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(EnvironmentContainerResource.ResourceType, out string environmentContainerResourceEnvironmentContainersApiVersion);
            _environmentContainerResourceEnvironmentContainersRestClient = new EnvironmentContainersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, environmentContainerResourceEnvironmentContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Workspace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Workspace.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="body"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<ArmOperation<EnvironmentContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, EnvironmentContainerResourceData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _environmentContainerResourceEnvironmentContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, body, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation<EnvironmentContainerResource>(Response.FromValue(new EnvironmentContainerResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="body"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="body"/> is null. </exception>
        public virtual ArmOperation<EnvironmentContainerResource> CreateOrUpdate(WaitUntil waitUntil, string name, EnvironmentContainerResourceData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _environmentContainerResourceEnvironmentContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, body, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation<EnvironmentContainerResource>(Response.FromValue(new EnvironmentContainerResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<EnvironmentContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _environmentContainerResourceEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<EnvironmentContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _environmentContainerResourceEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments
        /// Operation Id: EnvironmentContainers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EnvironmentContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EnvironmentContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EnvironmentContainerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _environmentContainerResourceEnvironmentContainersRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments
        /// Operation Id: EnvironmentContainers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EnvironmentContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EnvironmentContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EnvironmentContainerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _environmentContainerResourceEnvironmentContainersRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<EnvironmentContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _environmentContainerResourceEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EnvironmentContainerResource>(null, response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<EnvironmentContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _environmentContainerResourceEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EnvironmentContainerResource>(null, response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EnvironmentContainerResource> IEnumerable<EnvironmentContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EnvironmentContainerResource> IAsyncEnumerable<EnvironmentContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
