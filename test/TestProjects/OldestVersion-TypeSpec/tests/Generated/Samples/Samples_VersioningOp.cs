// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using TypeSpec.Versioning.Oldest.Models;

namespace TypeSpec.Versioning.Oldest.Samples
{
    public partial class Samples_VersioningOp
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_Create_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
            });
            Response response = client.Create("<name>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_Create_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
            });
            Response response = await client.CreateAsync("<name>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_Create_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Models.Resource resource = new Models.Resource("<type>");
            Response<Models.Resource> response = client.Create("<name>", resource);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_Create_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Models.Resource resource = new Models.Resource("<type>");
            Response<Models.Resource> response = await client.CreateAsync("<name>", resource);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_Create_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
            });
            Response response = client.Create("<name>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_Create_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
            });
            Response response = await client.CreateAsync("<name>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_Create_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Models.Resource resource = new Models.Resource("<type>");
            Response<Models.Resource> response = client.Create("<name>", resource);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_Create_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Models.Resource resource = new Models.Resource("<type>");
            Response<Models.Resource> response = await client.CreateAsync("<name>", resource);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_GetResources_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            foreach (BinaryData item in client.GetResources(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_GetResources_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            await foreach (BinaryData item in client.GetResourcesAsync(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_GetResources_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            foreach (Models.Resource item in client.GetResources())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_GetResources_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            await foreach (Models.Resource item in client.GetResourcesAsync())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_GetResources_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            foreach (BinaryData item in client.GetResources(new string[] { "<select>" }, "<expand>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_GetResources_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            await foreach (BinaryData item in client.GetResourcesAsync(new string[] { "<select>" }, "<expand>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Resource_GetResources_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            foreach (Models.Resource item in client.GetResources(select: new string[] { "<select>" }, expand: "<expand>"))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Resource_GetResources_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            await foreach (Models.Resource item in client.GetResourcesAsync(select: new string[] { "<select>" }, expand: "<expand>"))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_VersioningOp_Export_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<BinaryData> operation = client.Export(WaitUntil.Completed, "<name>", null, null, null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("resourceUri").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_VersioningOp_Export_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<BinaryData> operation = await client.ExportAsync(WaitUntil.Completed, "<name>", null, null, null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("resourceUri").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_VersioningOp_Export_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<ExportedResource> operation = client.Export(WaitUntil.Completed, "<name>");
            ExportedResource responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_VersioningOp_Export_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<ExportedResource> operation = await client.ExportAsync(WaitUntil.Completed, "<name>");
            ExportedResource responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_VersioningOp_Export_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<BinaryData> operation = client.Export(WaitUntil.Completed, "<name>", "<projectFileVersion>", "<removedQueryParam>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("resourceUri").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_VersioningOp_Export_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<BinaryData> operation = await client.ExportAsync(WaitUntil.Completed, "<name>", "<projectFileVersion>", "<removedQueryParam>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("resourceUri").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_VersioningOp_Export_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<ExportedResource> operation = client.Export(WaitUntil.Completed, "<name>", projectFileVersion: "<projectFileVersion>", removedQueryParam: "<removedQueryParam>");
            ExportedResource responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_VersioningOp_Export_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersioningOp client = new OldestClient(endpoint).GetVersioningOpClient(apiVersion: "2022-06-01-preview");

            Operation<ExportedResource> operation = await client.ExportAsync(WaitUntil.Completed, "<name>", projectFileVersion: "<projectFileVersion>", removedQueryParam: "<removedQueryParam>");
            ExportedResource responseData = operation.Value;
        }
    }
}
