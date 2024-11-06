// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Payload.Xml.Models;

namespace Payload.Xml
{
    // Data plane generated sub-client.
    /// <summary> Operations for the ModelWithSimpleArrays type. </summary>
    public partial class ModelWithSimpleArraysValue
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ModelWithSimpleArraysValue for mocking. </summary>
        protected ModelWithSimpleArraysValue()
        {
        }

        /// <summary> Initializes a new instance of ModelWithSimpleArraysValue. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Service host. </param>
        internal ModelWithSimpleArraysValue(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='GetModelWithSimpleArraysValueAsync(CancellationToken)']/*" />
        public virtual async Task<Response<ModelWithSimpleArrays>> GetModelWithSimpleArraysValueAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetModelWithSimpleArraysValueAsync(context).ConfigureAwait(false);
            return Response.FromValue(ModelWithSimpleArrays.FromResponse(response), response);
        }

        /// <summary> Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='GetModelWithSimpleArraysValue(CancellationToken)']/*" />
        public virtual Response<ModelWithSimpleArrays> GetModelWithSimpleArraysValue(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetModelWithSimpleArraysValue(context);
            return Response.FromValue(ModelWithSimpleArrays.FromResponse(response), response);
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
        /// Please try the simpler <see cref="GetModelWithSimpleArraysValueAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='GetModelWithSimpleArraysValueAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetModelWithSimpleArraysValueAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ModelWithSimpleArraysValue.GetModelWithSimpleArraysValue");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelWithSimpleArraysValueRequest(context);
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
        /// Please try the simpler <see cref="GetModelWithSimpleArraysValue(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='GetModelWithSimpleArraysValue(RequestContext)']/*" />
        public virtual Response GetModelWithSimpleArraysValue(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ModelWithSimpleArraysValue.GetModelWithSimpleArraysValue");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelWithSimpleArraysValueRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put. </summary>
        /// <param name="input"> The <see cref="ModelWithSimpleArrays"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='PutAsync(ModelWithSimpleArrays,CancellationToken)']/*" />
        public virtual async Task<Response> PutAsync(ModelWithSimpleArrays input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using RequestContent content = input.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await PutAsync(content, context).ConfigureAwait(false);
            return response;
        }

        /// <summary> Put. </summary>
        /// <param name="input"> The <see cref="ModelWithSimpleArrays"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='Put(ModelWithSimpleArrays,CancellationToken)']/*" />
        public virtual Response Put(ModelWithSimpleArrays input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using RequestContent content = input.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Put(content, context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] Put.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="PutAsync(ModelWithSimpleArrays,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='PutAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> PutAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ModelWithSimpleArraysValue.Put");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Put.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Put(ModelWithSimpleArrays,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ModelWithSimpleArraysValue.xml" path="doc/members/member[@name='Put(RequestContent,RequestContext)']/*" />
        public virtual Response Put(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ModelWithSimpleArraysValue.Put");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetModelWithSimpleArraysValueRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/payload/xml/modelWithSimpleArrays", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        internal HttpMessage CreatePutRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/payload/xml/modelWithSimpleArrays", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/xml");
            request.Content = content;
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
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
