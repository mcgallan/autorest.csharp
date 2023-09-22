// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using custom_baseUrl_more_options_LowLevel;

namespace custom_baseUrl_more_options_LowLevel.Samples
{
    public class Samples_PathsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathsClient client = new PathsClient("host", "<SubscriptionId>", credential);

            Response response = client.GetEmpty("<vault>", "<secret>", "<keyName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathsClient client = new PathsClient("host", "<SubscriptionId>", credential);

            Response response = await client.GetEmptyAsync("<vault>", "<secret>", "<keyName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathsClient client = new PathsClient("host", "<SubscriptionId>", credential);

            Response response = client.GetEmpty("<vault>", "<secret>", "<keyName>", keyVersion: "<keyVersion>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathsClient client = new PathsClient("host", "<SubscriptionId>", credential);

            Response response = await client.GetEmptyAsync("<vault>", "<secret>", "<keyName>", keyVersion: "<keyVersion>");
            Console.WriteLine(response.Status);
        }
    }
}