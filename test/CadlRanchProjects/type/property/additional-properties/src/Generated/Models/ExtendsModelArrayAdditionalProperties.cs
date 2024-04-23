// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> The model extends from Record&lt;ModelForRecord[]&gt; type. </summary>
    public partial class ExtendsModelArrayAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="ExtendsModelArrayAdditionalProperties"/>. </summary>
        /// <param name="knownProp"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="knownProp"/> is null. </exception>
        public ExtendsModelArrayAdditionalProperties(IEnumerable<ModelForRecord> knownProp)
        {
            Argument.AssertNotNull(knownProp, nameof(knownProp));

            KnownProp = knownProp.ToList();
            AdditionalProperties = new ChangeTrackingDictionary<string, IList<ModelForRecord>>();
        }

        /// <summary> Initializes a new instance of <see cref="ExtendsModelArrayAdditionalProperties"/>. </summary>
        /// <param name="knownProp"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ExtendsModelArrayAdditionalProperties(IList<ModelForRecord> knownProp, IDictionary<string, IList<ModelForRecord>> additionalProperties)
        {
            KnownProp = knownProp;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendsModelArrayAdditionalProperties"/> for deserialization. </summary>
        internal ExtendsModelArrayAdditionalProperties()
        {
        }

        /// <summary> Gets the known prop. </summary>
        public IList<ModelForRecord> KnownProp { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, IList<ModelForRecord>> AdditionalProperties { get; }
    }
}
