// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Type.Model.Visibility;
using _Type.Model.Visibility.Models;
using AutoRest.TestServer.Tests.Infrastructure;
using NUnit.Framework;

namespace CadlRanchProjects.Tests
{
    internal class TypeModelVsibilityTests : CadlRanchTestBase
    {
        [Test]
        public Task Type_Model_Visibility_InputToRoundTripReadOnly() => Test(async (host) =>
        {
            InputModel input = new("test", 2, null, null, new DerivedModel(new CollectionItem[] { null }), new DerivedModel(new CollectionItem[] { null }), new int[] { 1, 2 }, new string[] { "a", null }, new CollectionItem[] { new CollectionItem(new Dictionary<string, RecordItem>()) }, new Dictionary<string, RecordItem>(), Enumerable.Empty<float?>(), Enumerable.Empty<bool?>(), null, null, null);
            RoundTripReadOnlyModel result = await new VisibilityClient(host, null).InputToRoundTripReadOnlyAsync(input);
            Assert.AreEqual("test", result.RequiredReadonlyString);
            Assert.AreEqual(12, result.RequiredReadonlyInt);
            Assert.AreEqual(11, result.OptionalReadonlyInt);
            Assert.IsEmpty(result.RequiredReadonlyModel.RequiredList);
            Assert.AreEqual(FixedStringEnum.One, result.RequiredReadonlyFixedStringEnum);
            Assert.AreEqual("3", result.RequiredReadonlyExtensibleEnum.ToString());
            Assert.AreEqual(FixedStringEnum.Two, result.OptionalReadonlyFixedStringEnum);
            Assert.AreEqual(ExtensibleEnum.One, result.OptionalReadonlyExtensibleEnum);
            Assert.AreEqual(1, result.RequiredReadonlyStringList.Count);
            Assert.AreEqual("abc", result.RequiredReadonlyStringList[0]);
            Assert.IsEmpty(result.RequiredReadonlyIntList);
            Assert.IsEmpty(result.RequiredReadOnlyModelList);
            Assert.AreEqual(1, result.RequiredReadOnlyIntRecord.Count);
            Assert.AreEqual(1, result.RequiredReadOnlyIntRecord["test"]);
            Assert.AreEqual(1, result.RequiredStringRecord.Count);
            Assert.AreEqual("1", result.RequiredStringRecord["test"]);
            Assert.IsEmpty(result.RequiredReadOnlyModelRecord);
            Assert.AreEqual(1, result.OptionalReadonlyStringList.Count);
            Assert.IsNull(result.OptionalReadonlyStringList[0]);
            Assert.IsEmpty(result.OptionalReadOnlyModelList);
            Assert.IsEmpty(result.OptionalReadOnlyStringRecord);
            Assert.AreEqual(1, result.OptionalModelRecord.Count);
            Assert.IsEmpty(result.OptionalModelRecord["test"].RequiredList);
            CollectionAssert.AreEqual(new int?[] { null, 123 }, result.RequiredCollectionWithNullableIntElement);
            CollectionAssert.AreEqual(new bool?[] { null, false, true }, result.OptionalCollectionWithNullableBooleanElement);
        });
    }
}
