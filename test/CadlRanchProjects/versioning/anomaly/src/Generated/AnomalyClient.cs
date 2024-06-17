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
using Versioning.Anomaly.Models;

namespace Versioning.Anomaly
{
    // Data plane generated client.
    /// <summary> CADL project to test api versions. </summary>
    public partial class AnomalyClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of AnomalyClient for mocking. </summary>
        protected AnomalyClient()
        {
        }

        /// <summary> Initializes a new instance of AnomalyClient. </summary>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public AnomalyClient(Uri endpoint) : this(endpoint, new AnomalyClientOptions())
        {
        }

        /// <summary> Initializes a new instance of AnomalyClient. </summary>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public AnomalyClient(Uri endpoint, AnomalyClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new AnomalyClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get Multivariate Anomaly Detection Result. </summary>
        /// <param name="resultId"> The <see cref="Guid"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// For asynchronous inference, get multivariate anomaly detection result based on
        /// resultId returned by the BatchDetectAnomaly api.
        /// </remarks>
        /// <include file="Docs/AnomalyClient.xml" path="doc/members/member[@name='GetAnomalyDetectionResultAsync(Guid,CancellationToken)']/*" />
        public virtual async Task<Response<DetectionResult>> GetAnomalyDetectionResultAsync(Guid resultId, CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetAnomalyDetectionResultAsync(resultId, context).ConfigureAwait(false);
            return Response.FromValue(DetectionResult.FromResponse(response), response);
        }

        /// <summary> Get Multivariate Anomaly Detection Result. </summary>
        /// <param name="resultId"> The <see cref="Guid"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// For asynchronous inference, get multivariate anomaly detection result based on
        /// resultId returned by the BatchDetectAnomaly api.
        /// </remarks>
        /// <include file="Docs/AnomalyClient.xml" path="doc/members/member[@name='GetAnomalyDetectionResult(Guid,CancellationToken)']/*" />
        public virtual Response<DetectionResult> GetAnomalyDetectionResult(Guid resultId, CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetAnomalyDetectionResult(resultId, context);
            return Response.FromValue(DetectionResult.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Get Multivariate Anomaly Detection Result
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAnomalyDetectionResultAsync(Guid,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resultId"> The <see cref="Guid"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AnomalyClient.xml" path="doc/members/member[@name='GetAnomalyDetectionResultAsync(Guid,RequestContext)']/*" />
        public virtual async Task<Response> GetAnomalyDetectionResultAsync(Guid resultId, RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("AnomalyClient.GetAnomalyDetectionResult");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAnomalyDetectionResultRequest(resultId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get Multivariate Anomaly Detection Result
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAnomalyDetectionResult(Guid,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resultId"> The <see cref="Guid"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AnomalyClient.xml" path="doc/members/member[@name='GetAnomalyDetectionResult(Guid,RequestContext)']/*" />
        public virtual Response GetAnomalyDetectionResult(Guid resultId, RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("AnomalyClient.GetAnomalyDetectionResult");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAnomalyDetectionResultRequest(resultId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAnomalyDetectionResultRequest(Guid resultId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/versioning/anomaly/", false);
            uri.AppendRaw(_apiVersion, true);
            uri.AppendPath("/result/", false);
            uri.AppendPath(resultId, true);
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
