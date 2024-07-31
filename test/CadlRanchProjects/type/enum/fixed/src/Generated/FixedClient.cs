// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace _Type._Enum.Fixed
{
    // Data plane generated client.
    /// <summary> The Fixed service client. </summary>
    public partial class FixedClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FixedClient. </summary>
        public FixedClient() : this(new Uri("http://localhost:3000"), new FixedClientOptions())
        {
        }

        /// <summary> Initializes a new instance of FixedClient. </summary>
        /// <param name="endpoint"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public FixedClient(Uri endpoint, FixedClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new FixedClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        private String _cachedString;

        /// <summary> Initializes a new instance of String. </summary>
        public virtual String GetStringClient()
        {
            return Volatile.Read(ref _cachedString) ?? Interlocked.CompareExchange(ref _cachedString, new String(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedString;
        }
    }
}
