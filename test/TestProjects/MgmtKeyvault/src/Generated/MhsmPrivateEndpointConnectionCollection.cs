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

namespace MgmtKeyvault
{
    /// <summary> A class representing collection of MhsmPrivateEndpointConnection and their operations over its parent. </summary>
    public partial class MhsmPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<MhsmPrivateEndpointConnection>, IAsyncEnumerable<MhsmPrivateEndpointConnection>
    {
        private readonly ClientDiagnostics _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics;
        private readonly MhsmPrivateEndpointConnectionsRestOperations _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MhsmPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected MhsmPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MhsmPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MhsmPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("MgmtKeyvault", MhsmPrivateEndpointConnection.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(MhsmPrivateEndpointConnection.ResourceType, out string mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsApiVersion);
            _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient = new MhsmPrivateEndpointConnectionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedHsm.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedHsm.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates the specified private endpoint connection associated with the managed hsm pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Put
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public virtual async Task<ArmOperation<MhsmPrivateEndpointConnection>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, MhsmPrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(properties, nameof(properties));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtKeyvaultArmOperation<MhsmPrivateEndpointConnection>(Response.FromValue(new MhsmPrivateEndpointConnection(Client, response), response.GetRawResponse()));
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
        /// Updates the specified private endpoint connection associated with the managed hsm pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Put
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public virtual ArmOperation<MhsmPrivateEndpointConnection> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, MhsmPrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(properties, nameof(properties));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken);
                var operation = new MgmtKeyvaultArmOperation<MhsmPrivateEndpointConnection>(Response.FromValue(new MhsmPrivateEndpointConnection(Client, response), response.GetRawResponse()));
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
        /// Gets the specified private endpoint connection associated with the managed HSM Pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<MhsmPrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MhsmPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection associated with the managed HSM Pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<MhsmPrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MhsmPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the managed HSM Pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections
        /// Operation Id: MHSMPrivateEndpointConnections_ListByResource
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MhsmPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MhsmPrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MhsmPrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.ListByResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MhsmPrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.ListByResourceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the managed HSM Pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections
        /// Operation Id: MHSMPrivateEndpointConnections_ListByResource
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MhsmPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MhsmPrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MhsmPrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.ListByResource(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MhsmPrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.ListByResourceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<MhsmPrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<MhsmPrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new MhsmPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: MHSMPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<MhsmPrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsClientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mhsmPrivateEndpointConnectionMHSMPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<MhsmPrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new MhsmPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MhsmPrivateEndpointConnection> IEnumerable<MhsmPrivateEndpointConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MhsmPrivateEndpointConnection> IAsyncEnumerable<MhsmPrivateEndpointConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
