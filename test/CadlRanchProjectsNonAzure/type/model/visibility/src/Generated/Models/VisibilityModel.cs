// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Scm._Type.Model.Visibility.Models
{
    /// <summary> Output model with visibility properties. </summary>
    public partial class VisibilityModel
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

        /// <summary> Initializes a new instance of <see cref="VisibilityModel"/>. </summary>
        /// <param name="createProp"> Required string[], illustrating a create property. </param>
        /// <param name="updateProp"> Required int32[], illustrating a update property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createProp"/> or <paramref name="updateProp"/> is null. </exception>
        public VisibilityModel(IEnumerable<string> createProp, IEnumerable<int> updateProp)
        {
            Argument.AssertNotNull(createProp, nameof(createProp));
            Argument.AssertNotNull(updateProp, nameof(updateProp));

            CreateProp = createProp.ToList();
            UpdateProp = updateProp.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VisibilityModel"/>. </summary>
        /// <param name="createProp"> Required string[], illustrating a create property. </param>
        /// <param name="updateProp"> Required int32[], illustrating a update property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VisibilityModel(IList<string> createProp, IList<int> updateProp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CreateProp = createProp;
            UpdateProp = updateProp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VisibilityModel"/> for deserialization. </summary>
        internal VisibilityModel()
        {
        }

        /// <summary> Required string[], illustrating a create property. </summary>
        public IList<string> CreateProp { get; }
        /// <summary> Required int32[], illustrating a update property. </summary>
        public IList<int> UpdateProp { get; }
    }
}