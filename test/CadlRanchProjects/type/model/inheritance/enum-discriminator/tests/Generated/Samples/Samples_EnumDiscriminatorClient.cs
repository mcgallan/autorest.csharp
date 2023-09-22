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
using _Type.Model.Inheritance.EnumDiscriminator;
using _Type.Model.Inheritance.EnumDiscriminator.Models;

namespace _Type.Model.Inheritance.EnumDiscriminator.Samples
{
    public class Samples_EnumDiscriminatorClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModel()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetExtensibleModel(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModel_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetExtensibleModelAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModel_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = client.GetExtensibleModel();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModel_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = await client.GetExtensibleModelAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModel_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetExtensibleModel(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModel_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetExtensibleModelAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModel_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = client.GetExtensibleModel();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModel_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = await client.GetExtensibleModelAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutExtensibleModel()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "golden",
                weight = 1234,
            });
            Response response = client.PutExtensibleModel(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutExtensibleModel_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "golden",
                weight = 1234,
            });
            Response response = await client.PutExtensibleModelAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutExtensibleModel_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Dog input = new Golden(1234);
            Response response = client.PutExtensibleModel(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutExtensibleModel_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Dog input = new Golden(1234);
            Response response = await client.PutExtensibleModelAsync(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutExtensibleModel_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "golden",
                weight = 1234,
            });
            Response response = client.PutExtensibleModel(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutExtensibleModel_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "golden",
                weight = 1234,
            });
            Response response = await client.PutExtensibleModelAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutExtensibleModel_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Dog input = new Golden(1234);
            Response response = client.PutExtensibleModel(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutExtensibleModel_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Dog input = new Golden(1234);
            Response response = await client.PutExtensibleModelAsync(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelMissingDiscriminator()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetExtensibleModelMissingDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelMissingDiscriminator_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetExtensibleModelMissingDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelMissingDiscriminator_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = client.GetExtensibleModelMissingDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelMissingDiscriminator_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = await client.GetExtensibleModelMissingDiscriminatorAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelMissingDiscriminator_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetExtensibleModelMissingDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelMissingDiscriminator_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetExtensibleModelMissingDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelMissingDiscriminator_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = client.GetExtensibleModelMissingDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelMissingDiscriminator_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = await client.GetExtensibleModelMissingDiscriminatorAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelWrongDiscriminator()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetExtensibleModelWrongDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelWrongDiscriminator_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetExtensibleModelWrongDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelWrongDiscriminator_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = client.GetExtensibleModelWrongDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelWrongDiscriminator_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = await client.GetExtensibleModelWrongDiscriminatorAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelWrongDiscriminator_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetExtensibleModelWrongDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelWrongDiscriminator_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetExtensibleModelWrongDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("weight").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetExtensibleModelWrongDiscriminator_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = client.GetExtensibleModelWrongDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetExtensibleModelWrongDiscriminator_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Dog> response = await client.GetExtensibleModelWrongDiscriminatorAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModel()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetFixedModel(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModel_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetFixedModelAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModel_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = client.GetFixedModel();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModel_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = await client.GetFixedModelAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModel_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetFixedModel(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModel_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetFixedModelAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModel_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = client.GetFixedModel();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModel_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = await client.GetFixedModelAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutFixedModel()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "cobra",
                length = 1234,
            });
            Response response = client.PutFixedModel(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutFixedModel_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "cobra",
                length = 1234,
            });
            Response response = await client.PutFixedModelAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutFixedModel_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Snake input = new Cobra(1234);
            Response response = client.PutFixedModel(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutFixedModel_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Snake input = new Cobra(1234);
            Response response = await client.PutFixedModelAsync(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutFixedModel_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "cobra",
                length = 1234,
            });
            Response response = client.PutFixedModel(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutFixedModel_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            RequestContent content = RequestContent.Create(new
            {
                kind = "cobra",
                length = 1234,
            });
            Response response = await client.PutFixedModelAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutFixedModel_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Snake input = new Cobra(1234);
            Response response = client.PutFixedModel(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutFixedModel_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Snake input = new Cobra(1234);
            Response response = await client.PutFixedModelAsync(input);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelMissingDiscriminator()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetFixedModelMissingDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelMissingDiscriminator_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetFixedModelMissingDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelMissingDiscriminator_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = client.GetFixedModelMissingDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelMissingDiscriminator_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = await client.GetFixedModelMissingDiscriminatorAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelMissingDiscriminator_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetFixedModelMissingDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelMissingDiscriminator_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetFixedModelMissingDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelMissingDiscriminator_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = client.GetFixedModelMissingDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelMissingDiscriminator_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = await client.GetFixedModelMissingDiscriminatorAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelWrongDiscriminator()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetFixedModelWrongDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelWrongDiscriminator_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetFixedModelWrongDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelWrongDiscriminator_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = client.GetFixedModelWrongDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelWrongDiscriminator_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = await client.GetFixedModelWrongDiscriminatorAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelWrongDiscriminator_AllParameters()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = client.GetFixedModelWrongDiscriminator(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelWrongDiscriminator_AllParameters_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response response = await client.GetFixedModelWrongDiscriminatorAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFixedModelWrongDiscriminator_AllParameters_Convenience()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = client.GetFixedModelWrongDiscriminator();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFixedModelWrongDiscriminator_AllParameters_Convenience_Async()
        {
            EnumDiscriminatorClient client = new EnumDiscriminatorClient();

            Response<Snake> response = await client.GetFixedModelWrongDiscriminatorAsync();
        }
    }
}