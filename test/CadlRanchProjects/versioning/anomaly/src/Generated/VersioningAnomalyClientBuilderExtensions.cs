// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Versioning.Anomaly;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="AnomalyClient"/> to client builder. </summary>
    public static partial class VersioningAnomalyClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="AnomalyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        public static IAzureClientBuilder<AnomalyClient, AnomalyClientOptions> AddAnomalyClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<AnomalyClient, AnomalyClientOptions>((options) => new AnomalyClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="AnomalyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<AnomalyClient, AnomalyClientOptions> AddAnomalyClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<AnomalyClient, AnomalyClientOptions>(configuration);
        }
    }
}