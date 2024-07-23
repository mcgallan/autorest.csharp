// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Scm.Parameters.Spread.Models
{
    /// <summary> The SpreadWithMultipleParametersRequest. </summary>
    internal partial class SpreadWithMultipleParametersRequest
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

        /// <summary> Initializes a new instance of <see cref="SpreadWithMultipleParametersRequest"/>. </summary>
        /// <param name="requiredString"> required string. </param>
        /// <param name="requiredIntList"> required int. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/> or <paramref name="requiredIntList"/> is null. </exception>
        public SpreadWithMultipleParametersRequest(string requiredString, IEnumerable<int> requiredIntList)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredIntList, nameof(requiredIntList));

            RequiredString = requiredString;
            RequiredIntList = requiredIntList.ToList();
            OptionalStringList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SpreadWithMultipleParametersRequest"/>. </summary>
        /// <param name="requiredString"> required string. </param>
        /// <param name="optionalInt"> optional int. </param>
        /// <param name="requiredIntList"> required int. </param>
        /// <param name="optionalStringList"> optional string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SpreadWithMultipleParametersRequest(string requiredString, int? optionalInt, IList<int> requiredIntList, IList<string> optionalStringList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RequiredString = requiredString;
            OptionalInt = optionalInt;
            RequiredIntList = requiredIntList;
            OptionalStringList = optionalStringList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SpreadWithMultipleParametersRequest"/> for deserialization. </summary>
        internal SpreadWithMultipleParametersRequest()
        {
        }

        /// <summary> required string. </summary>
        public string RequiredString { get; }
        /// <summary> optional int. </summary>
        public int? OptionalInt { get; set; }
        /// <summary> required int. </summary>
        public IList<int> RequiredIntList { get; }
        /// <summary> optional string. </summary>
        public IList<string> OptionalStringList { get; }
    }
}
