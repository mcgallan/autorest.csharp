﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using _Type.Property.Nullable;
using _Type.Property.Nullable.Models;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure.Core;
using NUnit.Framework;

namespace CadlRanchProjects.Tests
{
    public class TypePropertyNullableTests : CadlRanchTestBase
    {
        [Test]
        public Task Type_Property_Nullable_String_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetStringClient().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual("hello", response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_String_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetStringClient().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual(null, response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_String_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = "hello"
            };
            var response = await new NullableClient(host, null).GetStringClient().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_String_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetStringClient().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_Bytes_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetBytesClient().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            BinaryDataAssert.AreEqual(BinaryData.FromString("hello, world!"), response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_Bytes_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetBytesClient().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual(null, response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_Bytes_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = "aGVsbG8sIHdvcmxkIQ=="
            };
            var response = await new NullableClient(host, null).GetBytesClient().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_Bytes_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetBytesClient().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_Datetime_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetDatetimeClient().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual(DateTimeOffset.Parse("2022-08-26T18:38:00Z"), response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_Datetime_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetDatetimeClient().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual(null, response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_Datetime_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = DateTimeOffset.Parse("2022-08-26T18:38:00Z")
            };
            var response = await new NullableClient(host, null).GetDatetimeClient().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_Datetime_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetDatetimeClient().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_Duration_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetDurationClient().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual(XmlConvert.ToTimeSpan("P123DT22H14M12.011S"), response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_Duration_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetDurationClient().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual(null, response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_Duration_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = "P123DT22H14M12.011S"
            };
            var response = await new NullableClient(host, null).GetDurationClient().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_Duration_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetDurationClient().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsByte_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsByteClient().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            BinaryDataAssert.AreEqual(BinaryData.FromString("hello, world!"), response.Value.NullableProperty.First());
            BinaryDataAssert.AreEqual(BinaryData.FromString("hello, world!"), response.Value.NullableProperty.Last());
            Assert.AreEqual(2, response.Value.NullableProperty.Count);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsByte_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsByteClient().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            // we will never construct a null collection therefore this property is actually undefined here.
            Assert.IsFalse(Optional.IsCollectionDefined(response.Value.NullableProperty));
            Assert.IsNotNull(response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsByte_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = new[] { "aGVsbG8sIHdvcmxkIQ==", "aGVsbG8sIHdvcmxkIQ==" }
            };
            var response = await new NullableClient(host, null).GetCollectionsByteClient().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsByte_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetCollectionsByteClient().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsModel_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsModelClient().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual("hello", response.Value.NullableProperty.First().Property);
            Assert.AreEqual("world", response.Value.NullableProperty.Last().Property);
            Assert.AreEqual(2, response.Value.NullableProperty.Count);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsModel_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsModelClient().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            // we will never construct a null collection therefore this property is actually undefined here.
            Assert.IsFalse(Optional.IsCollectionDefined(response.Value.NullableProperty));
            Assert.IsNotNull(response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsModel_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = new[]
                {
                    new
                    {
                        property = "hello"
                    },
                    new
                    {
                        property = "world"
                    }
                }
            };
            var response = await new NullableClient(host, null).GetCollectionsModelClient().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsModel_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetCollectionsModelClient().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsInt32_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsInt32Client().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual(123, response.Value.NullableProperty.First());
            Assert.AreEqual(456, response.Value.NullableProperty.Last());
            Assert.AreEqual(2, response.Value.NullableProperty.Count);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsInt32_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsInt32Client().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            // we will never construct a null collection therefore this property is actually undefined here.
            Assert.IsFalse(Optional.IsCollectionDefined(response.Value.NullableProperty));
            Assert.IsNotNull(response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsInt32_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = new[] { 123, 456 }
            };
            var response = await new NullableClient(host, null).GetCollectionsInt32Client().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsInt32_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetCollectionsInt32Client().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsString_getNonNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsStringClient().GetNonNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            Assert.AreEqual("hello", response.Value.NullableProperty.First());
            Assert.AreEqual("world", response.Value.NullableProperty.Last());
            Assert.AreEqual(2, response.Value.NullableProperty.Count);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsString_getNull() => Test(async (host) =>
        {
            var response = await new NullableClient(host, null).GetCollectionsByteClient().GetNullAsync();
            Assert.AreEqual("foo", response.Value.RequiredProperty);
            // we will never construct a null collection therefore this property is actually undefined here.
            Assert.IsFalse(Optional.IsCollectionDefined(response.Value.NullableProperty));
            Assert.IsNotNull(response.Value.NullableProperty);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsString_patchNonNull() => Test(async (host) =>
        {
            var value = new
            {
                requiredProperty = "foo",
                nullableProperty = new[] { "hello", "world" }
            };
            var response = await new NullableClient(host, null).GetCollectionsByteClient().PatchNonNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Nullable_CollectionsString_patchNull() => Test(async (host) =>
        {
            string value = "{ \"requiredProperty\": \"foo\", \"nullableProperty\": null }";
            var response = await new NullableClient(host, null).GetCollectionsByteClient().PatchNullAsync(RequestContent.Create(value));
            Assert.AreEqual(204, response.Status);
        });
    }
}
