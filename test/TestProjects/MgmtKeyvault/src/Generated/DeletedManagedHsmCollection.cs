// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtKeyvault
{
    /// <summary> A class representing collection of DeletedManagedHsm and their operations over its parent. </summary>
    public partial class DeletedManagedHsmCollection : ArmCollection
    {
        private readonly ClientDiagnostics _deletedManagedHsmManagedHsmsClientDiagnostics;
        private readonly ManagedHsmsRestOperations _deletedManagedHsmManagedHsmsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedManagedHsmCollection"/> class for mocking. </summary>
        protected DeletedManagedHsmCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedManagedHsmCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeletedManagedHsmCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedManagedHsmManagedHsmsClientDiagnostics = new ClientDiagnostics("MgmtKeyvault", DeletedManagedHsm.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DeletedManagedHsm.ResourceType, out string deletedManagedHsmManagedHsmsApiVersion);
            _deletedManagedHsmManagedHsmsRestClient = new ManagedHsmsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deletedManagedHsmManagedHsmsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified deleted managed HSM.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}
        /// Operation Id: ManagedHsms_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted managed HSM. </param>
        /// <param name="name"> The name of the deleted managed HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DeletedManagedHsm>> GetAsync(string location, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedManagedHsmManagedHsmsRestClient.GetDeletedAsync(Id.SubscriptionId, location, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedManagedHsm(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified deleted managed HSM.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}
        /// Operation Id: ManagedHsms_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted managed HSM. </param>
        /// <param name="name"> The name of the deleted managed HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="name"/> is null. </exception>
        public virtual Response<DeletedManagedHsm> Get(string location, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedManagedHsmManagedHsmsRestClient.GetDeleted(Id.SubscriptionId, location, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedManagedHsm(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}
        /// Operation Id: ManagedHsms_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted managed HSM. </param>
        /// <param name="name"> The name of the deleted managed HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string location, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}
        /// Operation Id: ManagedHsms_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted managed HSM. </param>
        /// <param name="name"> The name of the deleted managed HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string location, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, name, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}
        /// Operation Id: ManagedHsms_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted managed HSM. </param>
        /// <param name="name"> The name of the deleted managed HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DeletedManagedHsm>> GetIfExistsAsync(string location, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedManagedHsmManagedHsmsRestClient.GetDeletedAsync(Id.SubscriptionId, location, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeletedManagedHsm>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedManagedHsm(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}
        /// Operation Id: ManagedHsms_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted managed HSM. </param>
        /// <param name="name"> The name of the deleted managed HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="name"/> is null. </exception>
        public virtual Response<DeletedManagedHsm> GetIfExists(string location, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedManagedHsmManagedHsmsRestClient.GetDeleted(Id.SubscriptionId, location, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeletedManagedHsm>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedManagedHsm(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
