// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;

namespace Server.Path.SingleHeadAsBoolean.Samples
{
    public partial class Samples_SingleClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Single_MyOp_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            SingleClient client = new SingleClient(endpoint);

            Response<bool> response = client.MyOp();

            Console.WriteLine(response.GetRawResponse().Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Single_MyOp_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            SingleClient client = new SingleClient(endpoint);

            Response<bool> response = await client.MyOpAsync();

            Console.WriteLine(response.GetRawResponse().Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Single_MyOp_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            SingleClient client = new SingleClient(endpoint);

            Response<bool> response = client.MyOp();

            Console.WriteLine(response.GetRawResponse().Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Single_MyOp_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            SingleClient client = new SingleClient(endpoint);

            Response<bool> response = await client.MyOpAsync();

            Console.WriteLine(response.GetRawResponse().Status);
        }
    }
}
