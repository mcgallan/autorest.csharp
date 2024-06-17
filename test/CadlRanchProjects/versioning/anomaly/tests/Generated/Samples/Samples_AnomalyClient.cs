// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using Versioning.Anomaly.Models;

namespace Versioning.Anomaly.Samples
{
    public partial class Samples_AnomalyClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Anomaly_GetAnomalyDetectionResult_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response response = client.GetAnomalyDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Anomaly_GetAnomalyDetectionResult_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response response = await client.GetAnomalyDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Anomaly_GetAnomalyDetectionResult_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response<DetectionResult> response = client.GetAnomalyDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Anomaly_GetAnomalyDetectionResult_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response<DetectionResult> response = await client.GetAnomalyDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Anomaly_GetAnomalyDetectionResult_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response response = client.GetAnomalyDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Anomaly_GetAnomalyDetectionResult_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response response = await client.GetAnomalyDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Anomaly_GetAnomalyDetectionResult_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response<DetectionResult> response = client.GetAnomalyDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Anomaly_GetAnomalyDetectionResult_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AnomalyClient client = new AnomalyClient(endpoint);

            Response<DetectionResult> response = await client.GetAnomalyDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }
    }
}