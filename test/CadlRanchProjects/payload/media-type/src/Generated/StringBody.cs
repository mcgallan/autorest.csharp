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

namespace Payload.MediaType
{
    // Data plane generated sub-client.
    /// <summary> The StringBody sub-client. </summary>
    public partial class StringBody
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of StringBody for mocking. </summary>
        protected StringBody()
        {
        }

        /// <summary> Initializes a new instance of StringBody. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The <see cref="string"/> to use. </param>
        internal StringBody(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> Send as text. </summary>
        /// <param name="text"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="text"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsTextAsync(string,CancellationToken)']/*" />
        public virtual async Task<Response> SendAsTextAsync(string text, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(text, nameof(text));

            using RequestContent content = text;
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await SendAsTextAsync(content, context).ConfigureAwait(false);
            return response;
        }

        /// <summary> Send as text. </summary>
        /// <param name="text"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="text"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsText(string,CancellationToken)']/*" />
        public virtual Response SendAsText(string text, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(text, nameof(text));

            using RequestContent content = text;
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = SendAsText(content, context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] Send as text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="SendAsTextAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsTextAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> SendAsTextAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("StringBody.SendAsText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSendAsTextRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Send as text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="SendAsText(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsText(RequestContent,RequestContext)']/*" />
        public virtual Response SendAsText(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("StringBody.SendAsText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSendAsTextRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get as text. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsTextAsync(CancellationToken)']/*" />
        public virtual async Task<Response<string>> GetAsTextAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetAsTextAsync(context).ConfigureAwait(false);
            return Response.FromValue(response.Content.ToString(), response);
        }

        /// <summary> Get as text. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsText(CancellationToken)']/*" />
        public virtual Response<string> GetAsText(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetAsText(context);
            return Response.FromValue(response.Content.ToString(), response);
        }

        /// <summary>
        /// [Protocol Method] Get as text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAsTextAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsTextAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetAsTextAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("StringBody.GetAsText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAsTextRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get as text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAsText(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsText(RequestContext)']/*" />
        public virtual Response GetAsText(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("StringBody.GetAsText");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAsTextRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Send as json. </summary>
        /// <param name="text"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="text"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsJsonAsync(string,CancellationToken)']/*" />
        public virtual async Task<Response> SendAsJsonAsync(string text, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(text, nameof(text));

            using RequestContent content = RequestContentHelper.FromObject(text);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await SendAsJsonAsync(content, context).ConfigureAwait(false);
            return response;
        }

        /// <summary> Send as json. </summary>
        /// <param name="text"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="text"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsJson(string,CancellationToken)']/*" />
        public virtual Response SendAsJson(string text, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(text, nameof(text));

            using RequestContent content = RequestContentHelper.FromObject(text);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = SendAsJson(content, context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] Send as json.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="SendAsJsonAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsJsonAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> SendAsJsonAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("StringBody.SendAsJson");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSendAsJsonRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Send as json.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="SendAsJson(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='SendAsJson(RequestContent,RequestContext)']/*" />
        public virtual Response SendAsJson(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("StringBody.SendAsJson");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSendAsJsonRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get as json. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsJsonAsync(CancellationToken)']/*" />
        public virtual async Task<Response<string>> GetAsJsonAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetAsJsonAsync(context).ConfigureAwait(false);
            return Response.FromValue(response.Content.ToObjectFromJson<string>(), response);
        }

        /// <summary> Get as json. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsJson(CancellationToken)']/*" />
        public virtual Response<string> GetAsJson(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetAsJson(context);
            return Response.FromValue(response.Content.ToObjectFromJson<string>(), response);
        }

        /// <summary>
        /// [Protocol Method] Get as json.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAsJsonAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsJsonAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetAsJsonAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("StringBody.GetAsJson");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAsJsonRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get as json.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAsJson(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/StringBody.xml" path="doc/members/member[@name='GetAsJson(RequestContext)']/*" />
        public virtual Response GetAsJson(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("StringBody.GetAsJson");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAsJsonRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateSendAsTextRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/payload/media-type/string-body/sendAsText", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "text/plain");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetAsTextRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/payload/media-type/string-body/getAsText", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "text/plain");
            return message;
        }

        internal HttpMessage CreateSendAsJsonRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/payload/media-type/string-body/sendAsJson", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetAsJsonRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/payload/media-type/string-body/getAsJson", false);
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
