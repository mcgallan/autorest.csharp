using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using _Specs_.Azure.ClientGenerator.Core.FlattenProperty;
using _Specs_.Azure.ClientGenerator.Core.FlattenProperty.Models;
using AutoRest.TestServer.Tests.Infrastructure;
using NUnit.Framework;

namespace CadlRanchProjects.Tests
{
    public class azure_tcgc_flatten_property : CadlRanchTestBase
    {
        [Test]
        public Task Azure_ClientGenerator_Core_Flatten_Property_putFlattenModel() => Test(async (host) =>
        {
            var input = new FlattenModel("foo", "bar", 10);
            var response = await new FlattenPropertyClient(host, null).PutFlattenModelAsync(input);
            Assert.AreEqual(200, response.GetRawResponse().Status);
            Assert.AreEqual("test", response.Value.Name);
            Assert.AreEqual("test", response.Value.Description);
            Assert.AreEqual(1, response.Value.Age);
        });

        [Test]
        public Task Azure_ClientGenerator_Core_Flatten_Property_putNestedFlattenModel() => Test(async (host) =>
        {
            var input = new NestedFlattenModel("foo", "bar","test", 10);
            var response = await new FlattenPropertyClient(host, null).PutNestedFlattenModelAsync(input);
            Assert.AreEqual(200, response.GetRawResponse().Status);
            Assert.AreEqual("test", response.Value.Name);
            Assert.AreEqual("test", response.Value.Summary);
            Assert.AreEqual("foo", response.Value.Description);
            Assert.AreEqual(1, response.Value.Age);
        });
    }
}
