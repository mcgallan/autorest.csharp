// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;

namespace Payload.ContentNegotiation
{
    // Data plane generated sub-client.
    /// <summary> The SameBody sub-client. </summary>
    public partial class SameBody
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SameBody for mocking. </summary>
        protected SameBody()
        {
        }

        /// <summary> Initializes a new instance of SameBody. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        internal SameBody(ClientPipeline pipeline, Uri endpoint)
        {
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> Get avatar as png. </summary>
        public virtual async Task<ClientResult<BinaryData>> GetAvatarAsPngAsync()
        {
            ClientResult result = await GetAvatarAsPngAsync(null).ConfigureAwait(false);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary> Get avatar as png. </summary>
        public virtual ClientResult<BinaryData> GetAvatarAsPng()
        {
            ClientResult result = GetAvatarAsPng(null);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get avatar as png.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAvatarAsPngAsync()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetAvatarAsPngAsync(RequestOptions options)
        {
            using PipelineMessage message = CreateGetAvatarAsPngRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get avatar as png.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAvatarAsPng()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetAvatarAsPng(RequestOptions options)
        {
            using PipelineMessage message = CreateGetAvatarAsPngRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Get avatar as jpeg. </summary>
        public virtual async Task<ClientResult<BinaryData>> GetAvatarAsJpegAsync()
        {
            ClientResult result = await GetAvatarAsJpegAsync(null).ConfigureAwait(false);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary> Get avatar as jpeg. </summary>
        public virtual ClientResult<BinaryData> GetAvatarAsJpeg()
        {
            ClientResult result = GetAvatarAsJpeg(null);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get avatar as jpeg.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAvatarAsJpegAsync()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetAvatarAsJpegAsync(RequestOptions options)
        {
            using PipelineMessage message = CreateGetAvatarAsJpegRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get avatar as jpeg.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAvatarAsJpeg()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetAvatarAsJpeg(RequestOptions options)
        {
            using PipelineMessage message = CreateGetAvatarAsJpegRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateGetAvatarAsPngRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/content-negotiation/same-body", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "image/png");
            if (options != null)
            {
                message.Apply(options);
            }
            return message;
        }

        internal PipelineMessage CreateGetAvatarAsJpegRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/content-negotiation/same-body", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "image/jpeg");
            if (options != null)
            {
                message.Apply(options);
            }
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
