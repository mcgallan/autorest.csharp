// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Scm.Client.Naming.Models;

namespace Scm.Client.Naming
{
    // Data plane generated client.
    /// <summary> Describe changing names of types in a client with `@clientName`. </summary>
    public partial class NamingClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of NamingClient. </summary>
        public NamingClient() : this(new Uri("http://localhost:3000"), new NamingClientOptions())
        {
        }

        /// <summary> Initializes a new instance of NamingClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public NamingClient(Uri endpoint, NamingClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new NamingClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Client name.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> ClientNameAsync(RequestOptions options = null)
        {
            using PipelineMessage message = CreateClientNameRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Client name.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult ClientName(RequestOptions options = null)
        {
            using PipelineMessage message = CreateClientNameRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Parameter.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> ParameterAsync(string clientName, RequestOptions options = null)
        {
            Argument.AssertNotNull(clientName, nameof(clientName));

            using PipelineMessage message = CreateParameterRequest(clientName, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Parameter.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Parameter(string clientName, RequestOptions options = null)
        {
            Argument.AssertNotNull(clientName, nameof(clientName));

            using PipelineMessage message = CreateParameterRequest(clientName, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Client. </summary>
        /// <param name="clientNameModel"> The <see cref="ClientNameModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientNameModel"/> is null. </exception>
        public virtual async Task<ClientResult> ClientAsync(ClientNameModel clientNameModel)
        {
            Argument.AssertNotNull(clientNameModel, nameof(clientNameModel));

            using BinaryContent content = clientNameModel.ToBinaryContent();
            ClientResult result = await ClientAsync(content, null).ConfigureAwait(false);
            return result;
        }

        /// <summary> Client. </summary>
        /// <param name="clientNameModel"> The <see cref="ClientNameModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientNameModel"/> is null. </exception>
        public virtual ClientResult Client(ClientNameModel clientNameModel)
        {
            Argument.AssertNotNull(clientNameModel, nameof(clientNameModel));

            using BinaryContent content = clientNameModel.ToBinaryContent();
            ClientResult result = Client(content, null);
            return result;
        }

        /// <summary>
        /// [Protocol Method] Client.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="ClientAsync(ClientNameModel)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> ClientAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateClientRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Client.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Client(ClientNameModel)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Client(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateClientRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Language. </summary>
        /// <param name="languageClientNameModel"> The <see cref="LanguageClientNameModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="languageClientNameModel"/> is null. </exception>
        public virtual async Task<ClientResult> LanguageAsync(LanguageClientNameModel languageClientNameModel)
        {
            Argument.AssertNotNull(languageClientNameModel, nameof(languageClientNameModel));

            using BinaryContent content = languageClientNameModel.ToBinaryContent();
            ClientResult result = await LanguageAsync(content, null).ConfigureAwait(false);
            return result;
        }

        /// <summary> Language. </summary>
        /// <param name="languageClientNameModel"> The <see cref="LanguageClientNameModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="languageClientNameModel"/> is null. </exception>
        public virtual ClientResult Language(LanguageClientNameModel languageClientNameModel)
        {
            Argument.AssertNotNull(languageClientNameModel, nameof(languageClientNameModel));

            using BinaryContent content = languageClientNameModel.ToBinaryContent();
            ClientResult result = Language(content, null);
            return result;
        }

        /// <summary>
        /// [Protocol Method] Language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="LanguageAsync(LanguageClientNameModel)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> LanguageAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateLanguageRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Language(LanguageClientNameModel)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Language(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateLanguageRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Compatible with encoded name. </summary>
        /// <param name="clientNameAndJsonEncodedNameModel"> The <see cref="ClientNameAndJsonEncodedNameModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientNameAndJsonEncodedNameModel"/> is null. </exception>
        public virtual async Task<ClientResult> CompatibleWithEncodedNameAsync(ClientNameAndJsonEncodedNameModel clientNameAndJsonEncodedNameModel)
        {
            Argument.AssertNotNull(clientNameAndJsonEncodedNameModel, nameof(clientNameAndJsonEncodedNameModel));

            using BinaryContent content = clientNameAndJsonEncodedNameModel.ToBinaryContent();
            ClientResult result = await CompatibleWithEncodedNameAsync(content, null).ConfigureAwait(false);
            return result;
        }

        /// <summary> Compatible with encoded name. </summary>
        /// <param name="clientNameAndJsonEncodedNameModel"> The <see cref="ClientNameAndJsonEncodedNameModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientNameAndJsonEncodedNameModel"/> is null. </exception>
        public virtual ClientResult CompatibleWithEncodedName(ClientNameAndJsonEncodedNameModel clientNameAndJsonEncodedNameModel)
        {
            Argument.AssertNotNull(clientNameAndJsonEncodedNameModel, nameof(clientNameAndJsonEncodedNameModel));

            using BinaryContent content = clientNameAndJsonEncodedNameModel.ToBinaryContent();
            ClientResult result = CompatibleWithEncodedName(content, null);
            return result;
        }

        /// <summary>
        /// [Protocol Method] Compatible with encoded name.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CompatibleWithEncodedNameAsync(ClientNameAndJsonEncodedNameModel)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CompatibleWithEncodedNameAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCompatibleWithEncodedNameRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Compatible with encoded name.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CompatibleWithEncodedName(ClientNameAndJsonEncodedNameModel)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CompatibleWithEncodedName(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCompatibleWithEncodedNameRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Request.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> RequestAsync(string clientName, RequestOptions options = null)
        {
            Argument.AssertNotNull(clientName, nameof(clientName));

            using PipelineMessage message = CreateRequestRequest(clientName, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Request.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Request(string clientName, RequestOptions options = null)
        {
            Argument.AssertNotNull(clientName, nameof(clientName));

            using PipelineMessage message = CreateRequestRequest(clientName, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Response.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> ResponseAsync(RequestOptions options = null)
        {
            using PipelineMessage message = CreateResponseRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Response.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Response(RequestOptions options = null)
        {
            using PipelineMessage message = CreateResponseRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        private ClientModel _cachedClientModel;
        private UnionEnum _cachedUnionEnum;

        /// <summary> Initializes a new instance of ClientModel. </summary>
        public virtual ClientModel GetClientModelClient()
        {
            return Volatile.Read(ref _cachedClientModel) ?? Interlocked.CompareExchange(ref _cachedClientModel, new ClientModel(_pipeline, _endpoint), null) ?? _cachedClientModel;
        }

        /// <summary> Initializes a new instance of UnionEnum. </summary>
        public virtual UnionEnum GetUnionEnumClient()
        {
            return Volatile.Read(ref _cachedUnionEnum) ?? Interlocked.CompareExchange(ref _cachedUnionEnum, new UnionEnum(_pipeline, _endpoint), null) ?? _cachedUnionEnum;
        }

        internal PipelineMessage CreateClientNameRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client/naming/operation", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateParameterRequest(string clientName, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client/naming/parameter", false);
            uri.AppendQuery("defaultName", clientName, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateClientRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client/naming/property/client", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateLanguageRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client/naming/property/language", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateCompatibleWithEncodedNameRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client/naming/property/compatible-with-encoded-name", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateRequestRequest(string clientName, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client/naming/header", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("default-name", clientName);
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateResponseRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client/naming/header", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier204;
        private static PipelineMessageClassifier PipelineMessageClassifier204 => _pipelineMessageClassifier204 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 204 });
    }
}
