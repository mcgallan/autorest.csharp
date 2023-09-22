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
    internal class Samples_Boolean
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBoolean()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response response = client.GetBoolean(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBoolean_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response response = await client.GetBooleanAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBoolean_Convenience()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response<BooleanProperty> response = client.GetBoolean();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBoolean_Convenience_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response<BooleanProperty> response = await client.GetBooleanAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBoolean_AllParameters()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response response = client.GetBoolean(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBoolean_AllParameters_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response response = await client.GetBooleanAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBoolean_AllParameters_Convenience()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response<BooleanProperty> response = client.GetBoolean();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBoolean_AllParameters_Convenience_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            Response<BooleanProperty> response = await client.GetBooleanAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = true,
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = true,
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_Convenience()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            BooleanProperty body = new BooleanProperty(true);
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Convenience_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            BooleanProperty body = new BooleanProperty(true);
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = true,
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = true,
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            BooleanProperty body = new BooleanProperty(true);
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            Boolean client = new ValueTypesClient().GetBooleanClient(apiVersion: "1.0.0");

            BooleanProperty body = new BooleanProperty(true);
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }
    }
}