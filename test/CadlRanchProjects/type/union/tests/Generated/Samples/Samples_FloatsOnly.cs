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
using _Type.Union.Models;

namespace _Type.Union.Samples
{
    public partial class Samples_FloatsOnly
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_GetFloatsOnly_ShortVersion()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = client.GetFloatsOnly(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_GetFloatsOnly_ShortVersion_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = await client.GetFloatsOnlyAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_GetFloatsOnly_ShortVersion_Convenience()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response<GetResponse5> response = client.GetFloatsOnly();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_GetFloatsOnly_ShortVersion_Convenience_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response<GetResponse5> response = await client.GetFloatsOnlyAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_GetFloatsOnly_AllParameters()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = client.GetFloatsOnly(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_GetFloatsOnly_AllParameters_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = await client.GetFloatsOnlyAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_GetFloatsOnly_AllParameters_Convenience()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response<GetResponse5> response = client.GetFloatsOnly();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_GetFloatsOnly_AllParameters_Convenience_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response<GetResponse5> response = await client.GetFloatsOnlyAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_Send_ShortVersion()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            using RequestContent content = RequestContent.Create(new
            {
                prop = 1.1F,
            });
            Response response = client.Send(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_Send_ShortVersion_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            using RequestContent content = RequestContent.Create(new
            {
                prop = 1.1F,
            });
            Response response = await client.SendAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_Send_ShortVersion_Convenience()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = client.Send(GetResponseProp1._11);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_Send_ShortVersion_Convenience_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = await client.SendAsync(GetResponseProp1._11);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_Send_AllParameters()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            using RequestContent content = RequestContent.Create(new
            {
                prop = 1.1F,
            });
            Response response = client.Send(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_Send_AllParameters_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            using RequestContent content = RequestContent.Create(new
            {
                prop = 1.1F,
            });
            Response response = await client.SendAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FloatsOnly_Send_AllParameters_Convenience()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = client.Send(GetResponseProp1._11);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FloatsOnly_Send_AllParameters_Convenience_Async()
        {
            FloatsOnly client = new UnionClient().GetFloatsOnlyClient();

            Response response = await client.SendAsync(GetResponseProp1._11);
        }
    }
}
