// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using NoDocsTypeSpec.Models;

namespace NoDocsTypeSpec.Tests
{
    public partial class EntityTests : NoDocsTypeSpecTestBase
    {
        public EntityTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Entity_DoSomething_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Entity client = CreateNoDocsTypeSpecClient(endpoint, credential).GetEntityClient();

            Response response = await client.DoSomethingAsync("<p2>", null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Entity_DoSomething_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Entity client = CreateNoDocsTypeSpecClient(endpoint, credential).GetEntityClient();

            Response<Thing> response = await client.DoSomethingAsync("<p2>");
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Entity_DoSomething_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Entity client = CreateNoDocsTypeSpecClient(endpoint, credential).GetEntityClient();

            Response response = await client.DoSomethingAsync("<p2>", null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Entity_DoSomething_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Entity client = CreateNoDocsTypeSpecClient(endpoint, credential).GetEntityClient();

            Response<Thing> response = await client.DoSomethingAsync("<p2>");
        }
    }
}