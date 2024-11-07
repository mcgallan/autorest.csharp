using System;
using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using NUnit.Framework;
using Payload.JsonMergePatch;
using Payload.JsonMergePatch.Models;

namespace CadlRanchProjects.Tests
{
    public class payload_json_merge_patch : CadlRanchTestBase
    {
        [Test]
        public Task Payload_JsonMergePatch_StringBody_sendAsJsonMergePatch() => Test(async (host) =>
        {
            var resource = new Resource("Madge")
            {
                Description = "desc",
                Map =
                {
                    ["key"] = new InnerModel()
                    {
                        Name = "InnerMadge",
                        Description = "innerDesc"
                    }
                },
                Array =
                {
                    new InnerModel()
                    {
                        Name = "InnerMadge",
                        Description = "innerDesc"
                    }
                },
                IntValue = 1,
                FloatValue = 1.1f,
                InnerModel = new InnerModel()
                {
                    Name = "InnerMadge",
                    Description = "innerDesc"
                },
                IntArray = { 1, 2, 3 },
            };
            var response = await new JsonMergePatchClient(host, null).CreateResourceAsync(resource);
            Assert.AreEqual(200, response.GetRawResponse().Status);
            Assert.AreEqual("Madge", response.Value.Name);
            Assert.AreEqual("desc", response.Value.Description);
            Assert.AreEqual(1, response.Value.IntValue);
            Assert.AreEqual(1.1f, response.Value.FloatValue);
            Assert.AreEqual(1, response.Value.IntArray[0]);
            Assert.AreEqual(2, response.Value.IntArray[1]);
            Assert.AreEqual(3, response.Value.IntArray[2]);
            Assert.AreEqual("InnerMadge", response.Value.InnerModel.Name);
            Assert.AreEqual("innerDesc", response.Value.InnerModel.Description);
            Assert.AreEqual("InnerMadge", response.Value.Map["key"].Name);
            Assert.AreEqual("innerDesc", response.Value.Map["key"].Description);
            Assert.AreEqual("InnerMadge", response.Value.Array[0].Name);
            Assert.AreEqual("innerDesc", response.Value.Array[0].Description);
        });
    }
}
