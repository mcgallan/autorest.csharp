// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Specs_.Azure.ClientGenerator.Core.Usage.Models
{
    /// <summary> The RoundTripModel. </summary>
    public partial class RoundTripModel
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

        /// <summary> Initializes a new instance of <see cref="RoundTripModel"/>. </summary>
        /// <param name="result"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="result"/> is null. </exception>
        public RoundTripModel(ResultModel result)
        {
            Argument.AssertNotNull(result, nameof(result));

            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="RoundTripModel"/>. </summary>
        /// <param name="result"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoundTripModel(ResultModel result, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Result = result;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoundTripModel"/> for deserialization. </summary>
        internal RoundTripModel()
        {
        }

        /// <summary> Gets or sets the result. </summary>
        public ResultModel Result { get; set; }
    }
}
