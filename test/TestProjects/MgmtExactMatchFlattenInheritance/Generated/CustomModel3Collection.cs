// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtExactMatchFlattenInheritance
{
    /// <summary>
    /// A class representing a collection of <see cref="CustomModel3Resource" /> and their operations.
    /// Each <see cref="CustomModel3Resource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CustomModel3Collection" /> instance call the GetCustomModel3s method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CustomModel3Collection : ArmCollection, IEnumerable<CustomModel3Resource>, IAsyncEnumerable<CustomModel3Resource>
    {
        private readonly ClientDiagnostics _customModel3ClientDiagnostics;
        private readonly CustomModel3SRestOperations _customModel3RestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomModel3Collection"/> class for mocking. </summary>
        protected CustomModel3Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomModel3Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CustomModel3Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customModel3ClientDiagnostics = new ClientDiagnostics("MgmtExactMatchFlattenInheritance", CustomModel3Resource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CustomModel3Resource.ResourceType, out string customModel3ApiVersion);
            _customModel3RestClient = new CustomModel3SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customModel3ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an CustomModel3.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="data"> The CustomModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CustomModel3Resource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, CustomModel3Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customModel3RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtExactMatchFlattenInheritanceArmOperation<CustomModel3Resource>(Response.FromValue(new CustomModel3Resource(Client, response), response.GetRawResponse()));
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
        /// Create or update an CustomModel3.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="data"> The CustomModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CustomModel3Resource> CreateOrUpdate(WaitUntil waitUntil, string name, CustomModel3Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customModel3RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new MgmtExactMatchFlattenInheritanceArmOperation<CustomModel3Resource>(Response.FromValue(new CustomModel3Resource(Client, response), response.GetRawResponse()));
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
        /// Get an CustomModel3.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<CustomModel3Resource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.Get");
            scope.Start();
            try
            {
                var response = await _customModel3RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel3Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an CustomModel3.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<CustomModel3Resource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.Get");
            scope.Start();
            try
            {
                var response = _customModel3RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel3Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an CustomModel3s.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomModel3Resource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomModel3Resource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customModel3RestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CustomModel3Resource(Client, CustomModel3Data.DeserializeCustomModel3Data(e)), _customModel3ClientDiagnostics, Pipeline, "CustomModel3Collection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get an CustomModel3s.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomModel3Resource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomModel3Resource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customModel3RestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CustomModel3Resource(Client, CustomModel3Data.DeserializeCustomModel3Data(e)), _customModel3ClientDiagnostics, Pipeline, "CustomModel3Collection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.Exists");
            scope.Start();
            try
            {
                var response = await _customModel3RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.Exists");
            scope.Start();
            try
            {
                var response = _customModel3RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<CustomModel3Resource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _customModel3RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CustomModel3Resource>(response.GetRawResponse());
                return Response.FromValue(new CustomModel3Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<CustomModel3Resource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _customModel3RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CustomModel3Resource>(response.GetRawResponse());
                return Response.FromValue(new CustomModel3Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CustomModel3Resource> IEnumerable<CustomModel3Resource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomModel3Resource> IAsyncEnumerable<CustomModel3Resource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}