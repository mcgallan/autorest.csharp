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
using Azure.ResourceManager.Resources;

namespace MgmtMultipleParentResource
{
    /// <summary> A class representing collection of TheParent and their operations over its parent. </summary>
    public partial class TheParentCollection : ArmCollection, IEnumerable<TheParent>, IAsyncEnumerable<TheParent>
    {
        private readonly ClientDiagnostics _theParentClientDiagnostics;
        private readonly TheParentsRestOperations _theParentRestClient;

        /// <summary> Initializes a new instance of the <see cref="TheParentCollection"/> class for mocking. </summary>
        protected TheParentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TheParentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TheParentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _theParentClientDiagnostics = new ClientDiagnostics("MgmtMultipleParentResource", TheParent.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(TheParent.ResourceType, out string theParentApiVersion);
            _theParentRestClient = new TheParentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, theParentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="body"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<ArmOperation<TheParent>> CreateOrUpdateAsync(WaitUntil waitUntil, string theParentName, TheParentData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _theParentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, theParentName, body, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtMultipleParentResourceArmOperation<TheParent>(new TheParentOperationSource(Client), _theParentClientDiagnostics, Pipeline, _theParentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, theParentName, body).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="body"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> or <paramref name="body"/> is null. </exception>
        public virtual ArmOperation<TheParent> CreateOrUpdate(WaitUntil waitUntil, string theParentName, TheParentData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _theParentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, theParentName, body, cancellationToken);
                var operation = new MgmtMultipleParentResourceArmOperation<TheParent>(new TheParentOperationSource(Client), _theParentClientDiagnostics, Pipeline, _theParentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, theParentName, body).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        public virtual async Task<Response<TheParent>> GetAsync(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.Get");
            scope.Start();
            try
            {
                var response = await _theParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, theParentName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TheParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        public virtual Response<TheParent> Get(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.Get");
            scope.Start();
            try
            {
                var response = _theParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, theParentName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TheParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all run commands of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents
        /// Operation Id: TheParents_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TheParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TheParent> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TheParent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _theParentRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TheParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TheParent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _theParentRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TheParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// The operation to get all run commands of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents
        /// Operation Id: TheParents_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TheParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TheParent> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<TheParent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _theParentRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TheParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TheParent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _theParentRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TheParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(theParentName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        public virtual Response<bool> Exists(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(theParentName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        public virtual async Task<Response<TheParent>> GetIfExistsAsync(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _theParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, theParentName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<TheParent>(null, response.GetRawResponse());
                return Response.FromValue(new TheParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        public virtual Response<TheParent> GetIfExists(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(theParentName, nameof(theParentName));

            using var scope = _theParentClientDiagnostics.CreateScope("TheParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _theParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, theParentName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<TheParent>(null, response.GetRawResponse());
                return Response.FromValue(new TheParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TheParent> IEnumerable<TheParent>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TheParent> IAsyncEnumerable<TheParent>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
