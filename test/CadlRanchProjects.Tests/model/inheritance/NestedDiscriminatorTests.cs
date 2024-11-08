// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http;
using System.Threading.Tasks;
using _Type.Model.Inheritance.NestedDiscriminator;
using _Type.Model.Inheritance.NestedDiscriminator.Models;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;

namespace CadlRanchProjects.Tests.model.inheritance
{
    public class NestedDiscriminatorTests : CadlRanchTestBase
    {
        [Test]
        public Task GetNestedModel() => Test(async (host) =>
        {
            var response = await new NestedDiscriminatorClient(host, null).GetModelAsync();
            Assert.AreEqual(200, response.GetRawResponse().Status);
            Assert.AreEqual(1, response.Value.Age);
            Assert.AreEqual("shark", response.Value.Kind);
            Assert.IsInstanceOf<Shark>(response.Value);
        });

        [Test]
        public Task PutNestedModel() => Test(async (host) =>
        {
            var input = new GoblinShark(1);
            var response = await new NestedDiscriminatorClient(host, null).PutModelAsync(input);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task PutNestedRecursiveModel() => Test(async (host) =>
        {
            var input = new Salmon(1)
            {
                Partner = new SawShark(2),
                Friends =
                {
                    new Salmon(2)
                    {
                        Partner = new Salmon(3),
                        Hate =
                        {
                            ["key1"] = new Salmon(4),
                            ["key2"] = new GoblinShark(2)
                        }
                    },
                    new GoblinShark(3)
                },
                Hate =
                {
                    ["key3"] = new SawShark(3),
                    ["key4"] = new Salmon(2)
                    {
                        Friends =
                        {
                            new Salmon(1),
                            new GoblinShark(4)
                        }
                    }
                }
            };
            var response = await new NestedDiscriminatorClient(host, null).PutRecursiveModelAsync(input);
            Assert.AreEqual(204, response.Status);
        });
    }
}
