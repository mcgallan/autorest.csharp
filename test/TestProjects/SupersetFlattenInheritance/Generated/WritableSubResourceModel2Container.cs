// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing collection of WritableSubResourceModel2 and their operations over a ResourceGroup. </summary>
    public partial class WritableSubResourceModel2Container : ResourceContainerBase<ResourceGroupResourceIdentifier, WritableSubResourceModel2, WritableSubResourceModel2Data>
    {
        /// <summary> Initializes a new instance of the <see cref="WritableSubResourceModel2Container"/> class for mocking. </summary>
        protected WritableSubResourceModel2Container()
        {
        }

        /// <summary> Initializes a new instance of WritableSubResourceModel2Container class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WritableSubResourceModel2Container(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private WritableSubResourceModel2SRestOperations _restClient => new WritableSubResourceModel2SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="writableSubResourceModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<WritableSubResourceModel2> CreateOrUpdate(string writableSubResourceModel2SName, WritableSubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            if (writableSubResourceModel2SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(writableSubResourceModel2SName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="writableSubResourceModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<WritableSubResourceModel2>> CreateOrUpdateAsync(string writableSubResourceModel2SName, WritableSubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            if (writableSubResourceModel2SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(writableSubResourceModel2SName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="writableSubResourceModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WritableSubResourceModel2SPutOperation StartCreateOrUpdate(string writableSubResourceModel2SName, WritableSubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            if (writableSubResourceModel2SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Put(Id.ResourceGroupName, writableSubResourceModel2SName, parameters, cancellationToken);
                return new WritableSubResourceModel2SPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="writableSubResourceModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WritableSubResourceModel2SPutOperation> StartCreateOrUpdateAsync(string writableSubResourceModel2SName, WritableSubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            if (writableSubResourceModel2SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.PutAsync(Id.ResourceGroupName, writableSubResourceModel2SName, parameters, cancellationToken).ConfigureAwait(false);
                return new WritableSubResourceModel2SPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<WritableSubResourceModel2> Get(string writableSubResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.Get");
            scope.Start();
            try
            {
                if (writableSubResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, writableSubResourceModel2SName, cancellationToken: cancellationToken);
                return Response.FromValue(new WritableSubResourceModel2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<WritableSubResourceModel2>> GetAsync(string writableSubResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.Get");
            scope.Start();
            try
            {
                if (writableSubResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, writableSubResourceModel2SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WritableSubResourceModel2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual WritableSubResourceModel2 TryGet(string writableSubResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.TryGet");
            scope.Start();
            try
            {
                if (writableSubResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
                }

                return Get(writableSubResourceModel2SName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<WritableSubResourceModel2> TryGetAsync(string writableSubResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.TryGet");
            scope.Start();
            try
            {
                if (writableSubResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
                }

                return await GetAsync(writableSubResourceModel2SName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string writableSubResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.DoesExist");
            scope.Start();
            try
            {
                if (writableSubResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
                }

                return TryGet(writableSubResourceModel2SName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="writableSubResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string writableSubResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.DoesExist");
            scope.Start();
            try
            {
                if (writableSubResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel2SName));
                }

                return await TryGetAsync(writableSubResourceModel2SName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="WritableSubResourceModel2" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WritableSubResourceModel2Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="WritableSubResourceModel2" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel2Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WritableSubResourceModel2Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, WritableSubResourceModel2, WritableSubResourceModel2Data> Construct() { }
    }
}
