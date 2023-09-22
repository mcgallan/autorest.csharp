// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    /// <summary> Derived model with properties. </summary>
    public partial class DerivedModelWithProperties : BaseModelWithProperties
    {
        /// <summary> Initializes a new instance of DerivedModelWithProperties. </summary>
        /// <param name="requiredList"> Required collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredList"/> is null. </exception>
        public DerivedModelWithProperties(IEnumerable<CollectionItem> requiredList)
        {
            Argument.AssertNotNull(requiredList, nameof(requiredList));

            RequiredList = requiredList.ToList();
        }

        /// <summary> Initializes a new instance of DerivedModelWithProperties. </summary>
        /// <param name="optionalPropertyOnBase"> Optional properties on base. </param>
        /// <param name="requiredList"> Required collection. </param>
        internal DerivedModelWithProperties(string optionalPropertyOnBase, IList<CollectionItem> requiredList) : base(optionalPropertyOnBase)
        {
            RequiredList = requiredList;
        }

        /// <summary> Required collection. </summary>
        public IList<CollectionItem> RequiredList { get; }
    }
}