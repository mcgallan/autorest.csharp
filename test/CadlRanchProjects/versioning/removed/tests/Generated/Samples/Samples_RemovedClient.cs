// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using Versioning.Removed.Models;

namespace Versioning.Removed.Samples
{
    public partial class Samples_RemovedClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V2_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                prop = "<prop>",
                enumProp = "enumMemberV2",
                unionProp = "<unionProp>",
            });
            Response response = client.V2(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V2_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                prop = "<prop>",
                enumProp = "enumMemberV2",
                unionProp = "<unionProp>",
            });
            Response response = await client.V2Async(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V2_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV2 body = new ModelV2("<prop>", EnumV2.EnumMemberV2, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<ModelV2> response = client.V2(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V2_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV2 body = new ModelV2("<prop>", EnumV2.EnumMemberV2, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<ModelV2> response = await client.V2Async(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V2_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                prop = "<prop>",
                enumProp = "enumMemberV2",
                unionProp = "<unionProp>",
            });
            Response response = client.V2(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V2_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                prop = "<prop>",
                enumProp = "enumMemberV2",
                unionProp = "<unionProp>",
            });
            Response response = await client.V2Async(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V2_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV2 body = new ModelV2("<prop>", EnumV2.EnumMemberV2, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<ModelV2> response = client.V2(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V2_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV2 body = new ModelV2("<prop>", EnumV2.EnumMemberV2, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<ModelV2> response = await client.V2Async(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V3_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                type = "<type>",
            });
            Response response = client.V3(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V3_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                type = "<type>",
            });
            Response response = await client.V3Async(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V3_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV3 body = new ModelV3("<id>", "<type>");
            Response<ModelV3> response = client.V3(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V3_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV3 body = new ModelV3("<id>", "<type>");
            Response<ModelV3> response = await client.V3Async(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V3_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                type = "<type>",
            });
            Response response = client.V3(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V3_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                type = "<type>",
            });
            Response response = await client.V3Async(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Removed_V3_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV3 body = new ModelV3("<id>", "<type>");
            Response<ModelV3> response = client.V3(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Removed_V3_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RemovedClient client = new RemovedClient(endpoint, Versions.V1);

            ModelV3 body = new ModelV3("<id>", "<type>");
            Response<ModelV3> response = await client.V3Async(body);
        }
    }
}
