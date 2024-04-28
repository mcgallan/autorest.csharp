// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace TypeSpec.Versioning.Oldest
{
    /// <summary> Client options for OldestClient. </summary>
    public partial class OldestClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_12_01_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-06-01-preview". </summary>
            V2022_06_01_Preview = 1,
            /// <summary> Service version "2022-09-01". </summary>
            V2022_09_01 = 2,
            /// <summary> Service version "2022-12-01-preview". </summary>
            V2022_12_01_Preview = 3,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of OldestClientOptions. </summary>
        public OldestClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_06_01_Preview => "2022-06-01-preview",
                ServiceVersion.V2022_09_01 => "2022-09-01",
                ServiceVersion.V2022_12_01_Preview => "2022-12-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}