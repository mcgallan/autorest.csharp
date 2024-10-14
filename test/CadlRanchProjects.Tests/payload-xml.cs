using System.Collections.Generic;
using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using NUnit.Framework;
using Payload.Xml;
using Payload.Xml.Models;

namespace CadlRanchProjects.Tests
{
    public class PayloadXmlTest : CadlRanchTestBase
    {
        [Test]
        public Task ModelWithArrayOfModelValue_Put() => Test(async (host) =>
        {
            var list  = new List<SimpleModel> { new SimpleModel("foo", 123), new SimpleModel("bar", 456) };
            var input = new ModelWithArrayOfModel(list);
            var response = await new XmlClient(host, null).GetModelWithArrayOfModelValueClient().PutAsync(input);
        });

        [Test]
        public Task ModelWithArrayOfModelValue_Get() => Test(async (host) =>
        {
            var response = await new XmlClient(host, null).GetModelWithArrayOfModelValueClient().GetModelWithArrayOfModelValueAsync();
            Assert.AreEqual(2, response.Value.Items.Count);
            Assert.AreEqual("foo", response.Value.Items[0].Name);
            Assert.AreEqual(123, response.Value.Items[0].Age);
            Assert.AreEqual("bar", response.Value.Items[1].Name);
            Assert.AreEqual(456, response.Value.Items[1].Age);
        });

        [Test]
        public Task SimpleModel_Get() => Test(async (host) =>
        {
            var response = await new XmlClient(host, null).GetSimpleModelValueClient().GetSimpleModelValueAsync();
            Assert.AreEqual("foo", response.Value.Name);
            Assert.AreEqual(123, response.Value.Age);
        });

        [Test]
        public Task SimpleModel_Put() => Test(async (host) =>
        {
            var input = new SimpleModel("foo", 123);
            var response = await new XmlClient(host, null).GetSimpleModelValueClient().PutAsync(input);
        });
    }
}
