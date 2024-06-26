// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using Parameters.BodyOptionality.Models;

namespace Parameters.BodyOptionality.Samples
{
    public partial class Samples_BodyOptionalityClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredExplicit_ShortVersion()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.RequiredExplicit(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredExplicit_ShortVersion_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.RequiredExplicitAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredExplicit_ShortVersion_Convenience()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = client.RequiredExplicit(bodyModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredExplicit_ShortVersion_Convenience_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = await client.RequiredExplicitAsync(bodyModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredExplicit_AllParameters()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.RequiredExplicit(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredExplicit_AllParameters_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.RequiredExplicitAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredExplicit_AllParameters_Convenience()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = client.RequiredExplicit(bodyModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredExplicit_AllParameters_Convenience_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = await client.RequiredExplicitAsync(bodyModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredImplicit_ShortVersion()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.RequiredImplicit(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredImplicit_ShortVersion_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.RequiredImplicitAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredImplicit_ShortVersion_Convenience()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = client.RequiredImplicit(bodyModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredImplicit_ShortVersion_Convenience_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = await client.RequiredImplicitAsync(bodyModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredImplicit_AllParameters()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.RequiredImplicit(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredImplicit_AllParameters_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.RequiredImplicitAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BodyOptionality_RequiredImplicit_AllParameters_Convenience()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = client.RequiredImplicit(bodyModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BodyOptionality_RequiredImplicit_AllParameters_Convenience_Async()
        {
            BodyOptionalityClient client = new BodyOptionalityClient();

            BodyModel bodyModel = new BodyModel("<name>");
            Response response = await client.RequiredImplicitAsync(bodyModel);
        }
    }
}
