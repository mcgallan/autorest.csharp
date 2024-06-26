using System;
using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using NUnit.Framework;
using _Type._Enum.Fixed;
using _Type._Enum.Fixed.Models;

namespace CadlRanchProjects.Tests
{
    public class TypeEnumFixedTests : CadlRanchTestBase
    {
        [Test]
        public Task Type_Enum_Fixed_String_getKnownValue() => Test(async (host) =>
        {
            var response = await new FixedClient(host, null).GetStringClient().GetKnownValueAsync();
            Assert.AreEqual(DaysOfWeekEnum.Monday, response.Value);
        });

        [Test]
        [Ignore("input error")]
        public Task Type_Enum_Fixed_String_putKnownValue() => Test(async (host) =>
        {
            var response = await new FixedClient(host, null).GetStringClient().PutKnownValueAsync();
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Enum_Fixed_String_putUnknownValue() => Test((host) =>
        {
            var exception = Assert.ThrowsAsync<RequestFailedException>(() => new FixedClient(host, null).GetStringClient().PutUnknownValueAsync());
            Assert.AreEqual(400, exception.Status);
            return Task.CompletedTask;
        });

        [Test]
        public Task Type_Enum_Fixed_String_getReadonlyOptionalProperty() => Test(async (host) =>
        {
            var response = await new FixedClient(host, null).GetStringClient().GetOptionalReadonlyValueAsync();
            Assert.AreEqual(null, response.Value.Day);
        });

        [Test]
        public Task Type_Enum_Fixed_String_getReadonlyRequiredProperty() => Test(async (host) =>
        {
            var response = await new FixedClient(host, null).GetStringClient().GetRequiredReadonlyValueAsync();
            Assert.AreEqual(DaysOfWeekEnum.Monday, response.Value.Day);
        });
    }
}
