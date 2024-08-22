// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace _Type.Model.Visibility.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class TypeModelVisibilityModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.ReadModel"/>. </summary>
        /// <param name="readProp"> Required string, illustrating a readonly property. </param>
        /// <returns> A new <see cref="Models.ReadModel"/> instance for mocking. </returns>
        public static ReadModel ReadModel(string readProp = null)
        {
            return new ReadModel(readProp, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ReadOnlyModel"/>. </summary>
        /// <param name="optionalNullableIntList"> Optional readonly nullable int list. </param>
        /// <param name="optionalStringRecord"> Optional readonly string dictionary. </param>
        /// <returns> A new <see cref="Models.ReadOnlyModel"/> instance for mocking. </returns>
        public static ReadOnlyModel ReadOnlyModel(IEnumerable<int> optionalNullableIntList = null, IReadOnlyDictionary<string, string> optionalStringRecord = null)
        {
            optionalNullableIntList ??= new List<int>();
            optionalStringRecord ??= new Dictionary<string, string>();

            return new ReadOnlyModel(optionalNullableIntList?.ToList(), optionalStringRecord, serializedAdditionalRawData: null);
        }
    }
}
