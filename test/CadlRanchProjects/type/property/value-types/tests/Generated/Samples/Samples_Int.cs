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
using _Type.Property.ValueTypes;
using _Type.Property.ValueTypes.Models;

namespace _Type.Property.ValueTypes.Samples
{
    internal class Samples_Int
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response response = client.GetInt(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response response = await client.GetIntAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt_Convenience()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response<IntProperty> response = client.GetInt();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt_Convenience_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response<IntProperty> response = await client.GetIntAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt_AllParameters()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response response = client.GetInt(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt_AllParameters_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response response = await client.GetIntAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt_AllParameters_Convenience()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response<IntProperty> response = client.GetInt();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt_AllParameters_Convenience_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            Response<IntProperty> response = await client.GetIntAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 1234,
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 1234,
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_Convenience()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            IntProperty body = new IntProperty(1234);
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Convenience_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            IntProperty body = new IntProperty(1234);
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 1234,
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 1234,
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            IntProperty body = new IntProperty(1234);
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            Int client = new ValueTypesClient().GetIntClient(apiVersion: "1.0.0");

            IntProperty body = new IntProperty(1234);
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }
    }
}