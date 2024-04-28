// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Pipeline;

namespace TypeSpec.Versioning.Latest
{
    // Data plane generated sub-client.
    /// <summary> The Resource sub-client. </summary>
    public partial class Resource
    {
        private readonly HttpPipeline _pipeline;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Resource for mocking. </summary>
        protected Resource()
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        internal Resource(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }
    }
}