// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Scm._Type.Model.Visibility.Models
{
    /// <summary> Input model with visibility properties. </summary>
    public partial class HeadVisibilityModel
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

        /// <summary> Initializes a new instance of <see cref="HeadVisibilityModel"/>. </summary>
        /// <param name="queryProp"> Required int32, illustrating a query property. </param>
        /// <param name="createProp"> Required string[], illustrating a create property. </param>
        /// <param name="updateProp"> Required int32[], illustrating a update property. </param>
        /// <param name="deleteProp"> Required boolean, illustrating a delete property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createProp"/> or <paramref name="updateProp"/> is null. </exception>
        public HeadVisibilityModel(int queryProp, IEnumerable<string> createProp, IEnumerable<int> updateProp, bool deleteProp)
        {
            Argument.AssertNotNull(createProp, nameof(createProp));
            Argument.AssertNotNull(updateProp, nameof(updateProp));

            QueryProp = queryProp;
            CreateProp = createProp.ToList();
            UpdateProp = updateProp.ToList();
            DeleteProp = deleteProp;
        }

        /// <summary> Initializes a new instance of <see cref="HeadVisibilityModel"/>. </summary>
        /// <param name="queryProp"> Required int32, illustrating a query property. </param>
        /// <param name="createProp"> Required string[], illustrating a create property. </param>
        /// <param name="updateProp"> Required int32[], illustrating a update property. </param>
        /// <param name="deleteProp"> Required boolean, illustrating a delete property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HeadVisibilityModel(int queryProp, IList<string> createProp, IList<int> updateProp, bool deleteProp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueryProp = queryProp;
            CreateProp = createProp;
            UpdateProp = updateProp;
            DeleteProp = deleteProp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HeadVisibilityModel"/> for deserialization. </summary>
        internal HeadVisibilityModel()
        {
        }

        /// <summary> Required int32, illustrating a query property. </summary>
        public int QueryProp { get; }
        /// <summary> Required string[], illustrating a create property. </summary>
        public IList<string> CreateProp { get; }
        /// <summary> Required int32[], illustrating a update property. </summary>
        public IList<int> UpdateProp { get; }
        /// <summary> Required boolean, illustrating a delete property. </summary>
        public bool DeleteProp { get; }
    }
}
