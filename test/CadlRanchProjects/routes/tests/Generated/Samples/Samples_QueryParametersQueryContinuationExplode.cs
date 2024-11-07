// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;

namespace Routes.Samples
{
    public partial class Samples_QueryParametersQueryContinuationExplode
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Explode_Primitive_ShortVersion()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = client.Primitive("<param>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Explode_Primitive_ShortVersion_Async()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = await client.PrimitiveAsync("<param>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Explode_Primitive_AllParameters()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = client.Primitive("<param>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Explode_Primitive_AllParameters_Async()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = await client.PrimitiveAsync("<param>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Explode_Array_ShortVersion()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = client.Array(new string[] { "<param>" });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Explode_Array_ShortVersion_Async()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = await client.ArrayAsync(new string[] { "<param>" });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Explode_Array_AllParameters()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = client.Array(new string[] { "<param>" });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Explode_Array_AllParameters_Async()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = await client.ArrayAsync(new string[] { "<param>" });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Explode_Record_ShortVersion()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = client.Record(new Dictionary<string, int>
            {
                ["key"] = 1234
            });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Explode_Record_ShortVersion_Async()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = await client.RecordAsync(new Dictionary<string, int>
            {
                ["key"] = 1234
            });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Explode_Record_AllParameters()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = client.Record(new Dictionary<string, int>
            {
                ["key"] = 1234
            });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Explode_Record_AllParameters_Async()
        {
            QueryParametersQueryContinuationExplode client = new RoutesClient().GetQueryParametersClient().GetQueryParametersQueryContinuationClient().GetQueryParametersQueryContinuationExplodeClient();

            Response response = await client.RecordAsync(new Dictionary<string, int>
            {
                ["key"] = 1234
            });

            Console.WriteLine(response.Status);
        }
    }
}
