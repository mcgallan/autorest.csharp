// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using _Specs_.Azure.Core.Scalar;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ScalarClient"/> to client builder. </summary>
    public static partial class SpecsAzureCoreScalarClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ScalarClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="string"/> to use. </param>
        public static IAzureClientBuilder<ScalarClient, ScalarClientOptions> AddScalarClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ScalarClient, ScalarClientOptions>((options) => new ScalarClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="ScalarClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ScalarClient, ScalarClientOptions> AddScalarClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ScalarClient, ScalarClientOptions>(configuration);
        }
    }
}
