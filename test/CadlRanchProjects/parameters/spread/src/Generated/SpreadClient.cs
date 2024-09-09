// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Parameters.Spread
{
    // Data plane generated client.
    /// <summary> Test for the spread operator. </summary>
    public partial class SpreadClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SpreadClient. </summary>
        public SpreadClient() : this(new Uri("http://localhost:3000"), new SpreadClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SpreadClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SpreadClient(Uri endpoint, SpreadClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new SpreadClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        private Model _cachedModel;
        private Alias _cachedAlias;

        /// <summary> Initializes a new instance of Model. </summary>
        public virtual Model GetModelClient()
        {
            return Volatile.Read(ref _cachedModel) ?? Interlocked.CompareExchange(ref _cachedModel, new Model(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedModel;
        }

        /// <summary> Initializes a new instance of Alias. </summary>
        public virtual Alias GetAliasClient()
        {
            return Volatile.Read(ref _cachedAlias) ?? Interlocked.CompareExchange(ref _cachedAlias, new Alias(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedAlias;
        }
    }
}
