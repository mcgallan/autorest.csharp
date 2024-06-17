// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Versioning.Anomaly.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class VersioningAnomalyModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.DetectionResult"/>. </summary>
        /// <param name="resultId"> Result identifier, which is used to fetch the results of an inference call. </param>
        /// <returns> A new <see cref="Models.DetectionResult"/> instance for mocking. </returns>
        public static DetectionResult DetectionResult(Guid resultId = default)
        {
            return new DetectionResult(resultId, serializedAdditionalRawData: null);
        }
    }
}
