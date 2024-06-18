// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using NUnit.Framework;
using Versioning.Added;
using Versioning.Added.Models;
using System;
using System.Linq;
using System.Reflection;
using Versioning.Anomaly;

namespace CadlRanchProjects.Tests
{
    public class VersioningAnomalyTest : CadlRanchTestBase
    {
        [Test]
        public Task Versioning_Anomaly_GetAnomalyDetectionResult() => Test(async (host) =>
        {
            var response = await new AnomalyClient(host, new AnomalyClientOptions(AnomalyClientOptions.ServiceVersion.V1)).GetAnomalyDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
            Assert.AreEqual(200, response.GetRawResponse().Status);
            Assert.AreEqual(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), response.Value.ResultId);
        });
    }
}
