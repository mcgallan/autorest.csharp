// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading.Tasks;
using Scm._Type.Union.Models;

namespace Scm._Type.Union
{
    // Data plane generated sub-client.
    /// <summary> Describe union of integer 1 | 2 | 3. </summary>
    public partial class IntsOnly
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of IntsOnly for mocking. </summary>
        protected IntsOnly()
        {
        }

        /// <summary> Initializes a new instance of IntsOnly. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        internal IntsOnly(ClientPipeline pipeline, Uri endpoint)
        {
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> Get. </summary>
        public virtual async Task<ClientResult<GetResponse6>> GetIntsOnlyAsync()
        {
            ClientResult result = await GetIntsOnlyAsync(null).ConfigureAwait(false);
            return ClientResult.FromValue(GetResponse6.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Get. </summary>
        public virtual ClientResult<GetResponse6> GetIntsOnly()
        {
            ClientResult result = GetIntsOnly(null);
            return ClientResult.FromValue(GetResponse6.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetIntsOnlyAsync()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetIntsOnlyAsync(RequestOptions options)
        {
            using PipelineMessage message = CreateGetIntsOnlyRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetIntsOnly()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetIntsOnly(RequestOptions options)
        {
            using PipelineMessage message = CreateGetIntsOnlyRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Send. </summary>
        /// <param name="prop"></param>
        public virtual async Task<ClientResult> SendAsync(GetResponseProp3 prop)
        {
            SendRequest6 sendRequest6 = new SendRequest6(prop, null);
            ClientResult result = await SendAsync(sendRequest6.ToBinaryContent(), null).ConfigureAwait(false);
            return result;
        }

        /// <summary> Send. </summary>
        /// <param name="prop"></param>
        public virtual ClientResult Send(GetResponseProp3 prop)
        {
            SendRequest6 sendRequest6 = new SendRequest6(prop, null);
            ClientResult result = Send(sendRequest6.ToBinaryContent(), null);
            return result;
        }

        /// <summary>
        /// [Protocol Method] Send.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="SendAsync(GetResponseProp3)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> SendAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateSendRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Send.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Send(GetResponseProp3)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Send(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateSendRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateGetIntsOnlyRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/type/union/ints-only", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateSendRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/type/union/ints-only", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
        private static PipelineMessageClassifier _pipelineMessageClassifier204;
        private static PipelineMessageClassifier PipelineMessageClassifier204 => _pipelineMessageClassifier204 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 204 });
    }
}
