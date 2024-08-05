// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace _Specs_.Azure.ClientGenerator.Core.Usage
{
    // Data plane generated client.
    /// <summary> Test for internal decorator. </summary>
    public partial class UsageClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of UsageClient. </summary>
        public UsageClient() : this(new Uri("http://localhost:3000"), new UsageClientOptions())
        {
        }

        /// <summary> Initializes a new instance of UsageClient. </summary>
        /// <param name="endpoint"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public UsageClient(Uri endpoint, UsageClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new UsageClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        private ModelInOperation _cachedModelInOperation;

        /// <summary> Initializes a new instance of ModelInOperation. </summary>
        public virtual ModelInOperation GetModelInOperationClient()
        {
            return Volatile.Read(ref _cachedModelInOperation) ?? Interlocked.CompareExchange(ref _cachedModelInOperation, new ModelInOperation(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedModelInOperation;
        }
    }
}
