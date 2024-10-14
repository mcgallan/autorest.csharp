// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Payload.Xml.Models
{
    /// <summary> Contains fields that are XML attributes. </summary>
    public partial class ModelWithAttributes
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ModelWithAttributes"/>. </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="enabled"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id2"/> is null. </exception>
        public ModelWithAttributes(int id1, string id2, bool enabled)
        {
            Argument.AssertNotNull(id2, nameof(id2));

            Id1 = id1;
            Id2 = id2;
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of <see cref="ModelWithAttributes"/>. </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="enabled"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelWithAttributes(int id1, string id2, bool enabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id1 = id1;
            Id2 = id2;
            Enabled = enabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ModelWithAttributes"/> for deserialization. </summary>
        internal ModelWithAttributes()
        {
        }

        /// <summary> Gets or sets the id 1. </summary>
        public int Id1 { get; set; }
        /// <summary> Gets or sets the id 2. </summary>
        public string Id2 { get; set; }
        /// <summary> Gets or sets the enabled. </summary>
        public bool Enabled { get; set; }
    }
}
