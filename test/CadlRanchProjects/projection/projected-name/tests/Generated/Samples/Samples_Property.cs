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
using Projection.ProjectedName;
using Projection.ProjectedName.Models;

namespace Projection.ProjectedName.Samples
{
    internal class Samples_Property
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Json()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = client.Json(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Json_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = await client.JsonAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Json_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonProjectedNameModel jsonProjectedNameModel = new JsonProjectedNameModel(true);
            Response response = client.Json(jsonProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Json_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonProjectedNameModel jsonProjectedNameModel = new JsonProjectedNameModel(true);
            Response response = await client.JsonAsync(jsonProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Json_AllParameters()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = client.Json(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Json_AllParameters_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = await client.JsonAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Json_AllParameters_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonProjectedNameModel jsonProjectedNameModel = new JsonProjectedNameModel(true);
            Response response = client.Json(jsonProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Json_AllParameters_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonProjectedNameModel jsonProjectedNameModel = new JsonProjectedNameModel(true);
            Response response = await client.JsonAsync(jsonProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Client()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Client(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Client_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.ClientAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Client_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            ClientProjectedNameModel clientProjectedNameModel = new ClientProjectedNameModel(true);
            Response response = client.Client(clientProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Client_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            ClientProjectedNameModel clientProjectedNameModel = new ClientProjectedNameModel(true);
            Response response = await client.ClientAsync(clientProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Client_AllParameters()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Client(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Client_AllParameters_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.ClientAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Client_AllParameters_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            ClientProjectedNameModel clientProjectedNameModel = new ClientProjectedNameModel(true);
            Response response = client.Client(clientProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Client_AllParameters_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            ClientProjectedNameModel clientProjectedNameModel = new ClientProjectedNameModel(true);
            Response response = await client.ClientAsync(clientProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Language()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Language(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Language_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.LanguageAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Language_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            LanguageProjectedNameModel languageProjectedNameModel = new LanguageProjectedNameModel(true);
            Response response = client.Language(languageProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Language_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            LanguageProjectedNameModel languageProjectedNameModel = new LanguageProjectedNameModel(true);
            Response response = await client.LanguageAsync(languageProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Language_AllParameters()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Language(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Language_AllParameters_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.LanguageAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Language_AllParameters_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            LanguageProjectedNameModel languageProjectedNameModel = new LanguageProjectedNameModel(true);
            Response response = client.Language(languageProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Language_AllParameters_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            LanguageProjectedNameModel languageProjectedNameModel = new LanguageProjectedNameModel(true);
            Response response = await client.LanguageAsync(languageProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_JsonAndClient()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = client.JsonAndClient(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_JsonAndClient_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = await client.JsonAndClientAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_JsonAndClient_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonAndClientProjectedNameModel jsonAndClientProjectedNameModel = new JsonAndClientProjectedNameModel(true);
            Response response = client.JsonAndClient(jsonAndClientProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_JsonAndClient_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonAndClientProjectedNameModel jsonAndClientProjectedNameModel = new JsonAndClientProjectedNameModel(true);
            Response response = await client.JsonAndClientAsync(jsonAndClientProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_JsonAndClient_AllParameters()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = client.JsonAndClient(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_JsonAndClient_AllParameters_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = await client.JsonAndClientAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_JsonAndClient_AllParameters_Convenience()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonAndClientProjectedNameModel jsonAndClientProjectedNameModel = new JsonAndClientProjectedNameModel(true);
            Response response = client.JsonAndClient(jsonAndClientProjectedNameModel);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_JsonAndClient_AllParameters_Convenience_Async()
        {
            Property client = new ProjectedNameClient().GetPropertyClient();

            JsonAndClientProjectedNameModel jsonAndClientProjectedNameModel = new JsonAndClientProjectedNameModel(true);
            Response response = await client.JsonAndClientAsync(jsonAndClientProjectedNameModel);
            Console.WriteLine(response.Status);
        }
    }
}