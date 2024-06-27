// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using _Type._Array.Models;

namespace _Type._Array
{
    // Data plane generated sub-client.
    /// <summary> The ReadOnlyStringValue sub-client. </summary>
    public partial class ReadOnlyStringValue
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ReadOnlyStringValue for mocking. </summary>
        protected ReadOnlyStringValue()
        {
        }

        /// <summary> Initializes a new instance of ReadOnlyStringValue. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        internal ReadOnlyStringValue(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ReadOnlyStringValue.xml" path="doc/members/member[@name='GetReadOnlyStringValueAsync(CancellationToken)']/*" />
        public virtual async Task<Response<IReadOnlyList<RequiredReadOnlyStringProperty>>> GetReadOnlyStringValueAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetReadOnlyStringValueAsync(context).ConfigureAwait(false);
            IReadOnlyList<RequiredReadOnlyStringProperty> value = default;
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            List<RequiredReadOnlyStringProperty> array = new List<RequiredReadOnlyStringProperty>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(RequiredReadOnlyStringProperty.DeserializeRequiredReadOnlyStringProperty(item));
            }
            value = array;
            return Response.FromValue(value, response);
        }

        /// <summary> Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ReadOnlyStringValue.xml" path="doc/members/member[@name='GetReadOnlyStringValue(CancellationToken)']/*" />
        public virtual Response<IReadOnlyList<RequiredReadOnlyStringProperty>> GetReadOnlyStringValue(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetReadOnlyStringValue(context);
            IReadOnlyList<RequiredReadOnlyStringProperty> value = default;
            using var document = JsonDocument.Parse(response.ContentStream);
            List<RequiredReadOnlyStringProperty> array = new List<RequiredReadOnlyStringProperty>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(RequiredReadOnlyStringProperty.DeserializeRequiredReadOnlyStringProperty(item));
            }
            value = array;
            return Response.FromValue(value, response);
        }

        /// <summary>
        /// [Protocol Method] Get.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetReadOnlyStringValueAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ReadOnlyStringValue.xml" path="doc/members/member[@name='GetReadOnlyStringValueAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetReadOnlyStringValueAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ReadOnlyStringValue.GetReadOnlyStringValue");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetReadOnlyStringValueRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetReadOnlyStringValue(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ReadOnlyStringValue.xml" path="doc/members/member[@name='GetReadOnlyStringValue(RequestContext)']/*" />
        public virtual Response GetReadOnlyStringValue(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ReadOnlyStringValue.GetReadOnlyStringValue");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetReadOnlyStringValueRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetReadOnlyStringValueRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/type/array/readonly-string", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
