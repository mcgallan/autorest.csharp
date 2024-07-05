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
using _Type.Property.Optionality.Models;

namespace _Type.Property.Optionality.Samples
{
    public partial class Samples_Plaindate
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetAll_ShortVersion()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetAll_ShortVersion_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetAll_ShortVersion_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetAll_ShortVersion_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetAll_AllParameters()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetAll_AllParameters_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetAll_AllParameters_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetAll_AllParameters_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetDefault_ShortVersion()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetDefault_ShortVersion_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetDefault_ShortVersion_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetDefault_ShortVersion_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetDefault_AllParameters()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetDefault_AllParameters_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_GetDefault_AllParameters_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_GetDefault_AllParameters_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            Response<PlaindateProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutAll_ShortVersion()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutAll(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutAll_ShortVersion_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutAllAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutAll_ShortVersion_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty();
            Response response = client.PutAll(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutAll_ShortVersion_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty();
            Response response = await client.PutAllAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutAll_AllParameters()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new
            {
                property = "2022-05-10",
            });
            Response response = client.PutAll(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutAll_AllParameters_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new
            {
                property = "2022-05-10",
            });
            Response response = await client.PutAllAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutAll_AllParameters_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty
            {
                Property = DateTimeOffset.Parse("2022-05-10"),
            };
            Response response = client.PutAll(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutAll_AllParameters_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty
            {
                Property = DateTimeOffset.Parse("2022-05-10"),
            };
            Response response = await client.PutAllAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutDefault_ShortVersion()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutDefault(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutDefault_ShortVersion_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutDefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutDefault_ShortVersion_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty();
            Response response = client.PutDefault(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutDefault_ShortVersion_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty();
            Response response = await client.PutDefaultAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutDefault_AllParameters()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new
            {
                property = "2022-05-10",
            });
            Response response = client.PutDefault(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutDefault_AllParameters_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            using RequestContent content = RequestContent.Create(new
            {
                property = "2022-05-10",
            });
            Response response = await client.PutDefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Plaindate_PutDefault_AllParameters_Convenience()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty
            {
                Property = DateTimeOffset.Parse("2022-05-10"),
            };
            Response response = client.PutDefault(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Plaindate_PutDefault_AllParameters_Convenience_Async()
        {
            Plaindate client = new OptionalClient().GetPlaindateClient();

            PlaindateProperty body = new PlaindateProperty
            {
                Property = DateTimeOffset.Parse("2022-05-10"),
            };
            Response response = await client.PutDefaultAsync(body);
        }
    }
}
