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
using _Type.Property.AdditionalProperties.Models;

namespace _Type.Property.AdditionalProperties.Samples
{
    public partial class Samples_SpreadModel
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_GetSpreadModel_ShortVersion()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = client.GetSpreadModel(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_GetSpreadModel_ShortVersion_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = await client.GetSpreadModelAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_GetSpreadModel_ShortVersion_Convenience()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response<IReadOnlyDictionary<string, ModelForRecord>> response = client.GetSpreadModel();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_GetSpreadModel_ShortVersion_Convenience_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response<IReadOnlyDictionary<string, ModelForRecord>> response = await client.GetSpreadModelAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_GetSpreadModel_AllParameters()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = client.GetSpreadModel(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_GetSpreadModel_AllParameters_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = await client.GetSpreadModelAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_GetSpreadModel_AllParameters_Convenience()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response<IReadOnlyDictionary<string, ModelForRecord>> response = client.GetSpreadModel();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_GetSpreadModel_AllParameters_Convenience_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response<IReadOnlyDictionary<string, ModelForRecord>> response = await client.GetSpreadModelAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_Put_ShortVersion()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = new
                {
                    state = "<state>",
                },
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_Put_ShortVersion_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = new
                {
                    state = "<state>",
                },
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_Put_ShortVersion_Convenience()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = client.Put(new Dictionary<string, ModelForRecord>
            {
                ["key"] = new ModelForRecord("<state>")
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_Put_ShortVersion_Convenience_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = await client.PutAsync(new Dictionary<string, ModelForRecord>
            {
                ["key"] = new ModelForRecord("<state>")
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_Put_AllParameters()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = new
                {
                    state = "<state>",
                },
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_Put_AllParameters_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = new
                {
                    state = "<state>",
                },
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModel_Put_AllParameters_Convenience()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = client.Put(new Dictionary<string, ModelForRecord>
            {
                ["key"] = new ModelForRecord("<state>")
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModel_Put_AllParameters_Convenience_Async()
        {
            SpreadModel client = new AdditionalPropertiesClient().GetSpreadModelClient();

            Response response = await client.PutAsync(new Dictionary<string, ModelForRecord>
            {
                ["key"] = new ModelForRecord("<state>")
            });
        }
    }
}
