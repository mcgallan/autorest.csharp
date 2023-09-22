// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using Projection.ProjectedName;

namespace Projection.ProjectedName.Samples
{
    public class Samples_ProjectedNameClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Operation()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = client.Operation();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Operation_Async()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = await client.OperationAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Operation_AllParameters()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = client.Operation();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Operation_AllParameters_Async()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = await client.OperationAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Parameter()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = client.Parameter("<default-name>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Parameter_Async()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = await client.ParameterAsync("<default-name>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Parameter_AllParameters()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = client.Parameter("<default-name>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Parameter_AllParameters_Async()
        {
            ProjectedNameClient client = new ProjectedNameClient();

            Response response = await client.ParameterAsync("<default-name>");
            Console.WriteLine(response.Status);
        }
    }
}