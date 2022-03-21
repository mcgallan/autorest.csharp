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

namespace MgmtListMethods
{
    /// <summary> A class representing collection of FakeParentWithNonResCh and their operations over its parent. </summary>
    public partial class FakeParentWithNonResChCollection : ArmCollection, IEnumerable<FakeParentWithNonResCh>, IAsyncEnumerable<FakeParentWithNonResCh>
    {
        private readonly ClientDiagnostics _fakeParentWithNonResChClientDiagnostics;
        private readonly FakeParentWithNonResChesRestOperations _fakeParentWithNonResChRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithNonResChCollection"/> class for mocking. </summary>
        protected FakeParentWithNonResChCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithNonResChCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FakeParentWithNonResChCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakeParentWithNonResChClientDiagnostics = new ClientDiagnostics("MgmtListMethods", FakeParentWithNonResCh.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(FakeParentWithNonResCh.ResourceType, out string fakeParentWithNonResChApiVersion);
            _fakeParentWithNonResChRestClient = new FakeParentWithNonResChesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, fakeParentWithNonResChApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Fake.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Fake.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<FakeParentWithNonResCh>> CreateOrUpdateAsync(WaitUntil waitUntil, string fakeParentWithNonResChName, FakeParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakeParentWithNonResChRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, fakeParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<FakeParentWithNonResCh>(Response.FromValue(new FakeParentWithNonResCh(Client, response), response.GetRawResponse()));
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
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<FakeParentWithNonResCh> CreateOrUpdate(WaitUntil waitUntil, string fakeParentWithNonResChName, FakeParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakeParentWithNonResChRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, fakeParentWithNonResChName, parameters, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<FakeParentWithNonResCh>(Response.FromValue(new FakeParentWithNonResCh(Client, response), response.GetRawResponse()));
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
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_Get
        /// </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithNonResCh>> GetAsync(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = await _fakeParentWithNonResChRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithNonResChName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_Get
        /// </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> is null. </exception>
        public virtual Response<FakeParentWithNonResCh> Get(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = _fakeParentWithNonResChRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithNonResChName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes
        /// Operation Id: FakeParentWithNonResChes_ListTest
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithNonResCh> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FakeParentWithNonResCh>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithNonResChRestClient.ListTestAsync(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FakeParentWithNonResCh>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithNonResChRestClient.ListTestNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes
        /// Operation Id: FakeParentWithNonResChes_ListTest
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithNonResCh> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FakeParentWithNonResCh> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithNonResChRestClient.ListTest(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FakeParentWithNonResCh> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithNonResChRestClient.ListTestNextPage(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_Get
        /// </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(fakeParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_Get
        /// </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> is null. </exception>
        public virtual Response<bool> Exists(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(fakeParentWithNonResChName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_Get
        /// </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithNonResCh>> GetIfExistsAsync(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fakeParentWithNonResChRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FakeParentWithNonResCh>(null, response.GetRawResponse());
                return Response.FromValue(new FakeParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithNonResChes/{fakeParentWithNonResChName}
        /// Operation Id: FakeParentWithNonResChes_Get
        /// </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> is null. </exception>
        public virtual Response<FakeParentWithNonResCh> GetIfExists(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithNonResChName, nameof(fakeParentWithNonResChName));

            using var scope = _fakeParentWithNonResChClientDiagnostics.CreateScope("FakeParentWithNonResChCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fakeParentWithNonResChRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithNonResChName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FakeParentWithNonResCh>(null, response.GetRawResponse());
                return Response.FromValue(new FakeParentWithNonResCh(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FakeParentWithNonResCh> IEnumerable<FakeParentWithNonResCh>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FakeParentWithNonResCh> IAsyncEnumerable<FakeParentWithNonResCh>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
