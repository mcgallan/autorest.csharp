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

namespace MgmtRenameRules
{
    /// <summary> A class representing collection of Image and their operations over its parent. </summary>
    public partial class ImageCollection : ArmCollection, IEnumerable<Image>, IAsyncEnumerable<Image>
    {
        private readonly ClientDiagnostics _imageClientDiagnostics;
        private readonly ImagesRestOperations _imageRestClient;

        /// <summary> Initializes a new instance of the <see cref="ImageCollection"/> class for mocking. </summary>
        protected ImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _imageClientDiagnostics = new ClientDiagnostics("MgmtRenameRules", Image.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(Image.ResourceType, out string imageApiVersion);
            _imageRestClient = new ImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, imageApiVersion);
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
        /// Create or update an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="parameters"> Parameters supplied to the Create Image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<Image>> CreateOrUpdateAsync(WaitUntil waitUntil, string imageName, ImageData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _imageRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, imageName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtRenameRulesArmOperation<Image>(new ImageOperationSource(Client), _imageClientDiagnostics, Pipeline, _imageRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, imageName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="parameters"> Parameters supplied to the Create Image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<Image> CreateOrUpdate(WaitUntil waitUntil, string imageName, ImageData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _imageRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, imageName, parameters, cancellationToken);
                var operation = new MgmtRenameRulesArmOperation<Image>(new ImageOperationSource(Client), _imageClientDiagnostics, Pipeline, _imageRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, imageName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<Image>> GetAsync(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _imageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Image(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<Image> Get(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.Get");
            scope.Start();
            try
            {
                var response = _imageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Image(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of images under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images
        /// Operation Id: Images_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Image" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Image> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Image>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _imageRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Image(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Image>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _imageRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Image(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the list of images under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images
        /// Operation Id: Images_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Image" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Image> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Image> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _imageRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Image(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Image> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _imageRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Image(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(imageName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<bool> Exists(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(imageName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<Image>> GetIfExistsAsync(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _imageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Image>(null, response.GetRawResponse());
                return Response.FromValue(new Image(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<Image> GetIfExists(string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _imageClientDiagnostics.CreateScope("ImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _imageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, imageName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Image>(null, response.GetRawResponse());
                return Response.FromValue(new Image(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Image> IEnumerable<Image>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Image> IAsyncEnumerable<Image>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}