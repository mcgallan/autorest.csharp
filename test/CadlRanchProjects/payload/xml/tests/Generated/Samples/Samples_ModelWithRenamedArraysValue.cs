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
using Payload.Xml.Models;

namespace Payload.Xml.Samples
{
    public partial class Samples_ModelWithRenamedArraysValue
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_ShortVersion()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response response = client.GetModelWithRenamedArraysValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("colors")[0].ToString());
            Console.WriteLine(result.GetProperty("counts")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_ShortVersion_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response response = await client.GetModelWithRenamedArraysValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("colors")[0].ToString());
            Console.WriteLine(result.GetProperty("counts")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_ShortVersion_Convenience()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response<ModelWithRenamedArrays> response = client.GetModelWithRenamedArraysValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_ShortVersion_Convenience_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response<ModelWithRenamedArrays> response = await client.GetModelWithRenamedArraysValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_AllParameters()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response response = client.GetModelWithRenamedArraysValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("colors")[0].ToString());
            Console.WriteLine(result.GetProperty("counts")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_AllParameters_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response response = await client.GetModelWithRenamedArraysValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("colors")[0].ToString());
            Console.WriteLine(result.GetProperty("counts")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_AllParameters_Convenience()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response<ModelWithRenamedArrays> response = client.GetModelWithRenamedArraysValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_GetModelWithRenamedArraysValue_AllParameters_Convenience_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            Response<ModelWithRenamedArrays> response = await client.GetModelWithRenamedArraysValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_Put_ShortVersion()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                colors = new object[]
            {
"<colors>"
            },
                counts = new object[]
            {
1234
            },
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_Put_ShortVersion_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                colors = new object[]
            {
"<colors>"
            },
                counts = new object[]
            {
1234
            },
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_Put_ShortVersion_Convenience()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            ModelWithRenamedArrays input = new ModelWithRenamedArrays(new string[] { "<colors>" }, new int[] { 1234 });
            Response response = client.Put(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_Put_ShortVersion_Convenience_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            ModelWithRenamedArrays input = new ModelWithRenamedArrays(new string[] { "<colors>" }, new int[] { 1234 });
            Response response = await client.PutAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_Put_AllParameters()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                colors = new object[]
            {
"<colors>"
            },
                counts = new object[]
            {
1234
            },
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_Put_AllParameters_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                colors = new object[]
            {
"<colors>"
            },
                counts = new object[]
            {
1234
            },
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelWithRenamedArraysValue_Put_AllParameters_Convenience()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            ModelWithRenamedArrays input = new ModelWithRenamedArrays(new string[] { "<colors>" }, new int[] { 1234 });
            Response response = client.Put(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelWithRenamedArraysValue_Put_AllParameters_Convenience_Async()
        {
            ModelWithRenamedArraysValue client = new XmlClient().GetModelWithRenamedArraysValueClient();

            ModelWithRenamedArrays input = new ModelWithRenamedArrays(new string[] { "<colors>" }, new int[] { 1234 });
            Response response = await client.PutAsync(input);
        }
    }
}
