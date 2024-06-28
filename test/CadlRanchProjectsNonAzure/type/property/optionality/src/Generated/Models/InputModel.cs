// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Scm._Type.Property.Optionality.Models
{
    /// <summary> The InputModel. </summary>
    public partial class InputModel
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

        /// <summary> Initializes a new instance of <see cref="InputModel"/>. </summary>
        /// <param name="requiredString"> Required string. </param>
        /// <param name="requiredInt"> Required int. </param>
        /// <param name="requiredNullableInt"> Required nullable int. </param>
        /// <param name="requiredNullableString"> Required nullable string. </param>
        /// <param name="requiredModel"> Required model. </param>
        /// <param name="requiredModel2"> Required model. </param>
        /// <param name="requiredIntList"> Required primitive value type collection. </param>
        /// <param name="requiredStringList"> Required primitive reference type collection. </param>
        /// <param name="requiredModelList"> Required model collection. </param>
        /// <param name="requiredModelRecord"> Required model record. </param>
        /// <param name="requiredCollectionWithNullableFloatElement"> Required collection of which the element is a nullable float. </param>
        /// <param name="requiredCollectionWithNullableBooleanElement"> Required collection of which the element is a nullable boolean. </param>
        /// <param name="requiredNullableModelList"> Required model nullable collection. </param>
        /// <param name="requiredNullableStringList"> Required string nullable collection. </param>
        /// <param name="requiredNullableIntList"> Required int nullable collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredModel"/>, <paramref name="requiredModel2"/>, <paramref name="requiredIntList"/>, <paramref name="requiredStringList"/>, <paramref name="requiredModelList"/>, <paramref name="requiredModelRecord"/>, <paramref name="requiredCollectionWithNullableFloatElement"/> or <paramref name="requiredCollectionWithNullableBooleanElement"/> is null. </exception>
        public InputModel(string requiredString, int requiredInt, int? requiredNullableInt, string requiredNullableString, BaseModel requiredModel, BaseModel requiredModel2, IEnumerable<int> requiredIntList, IEnumerable<string> requiredStringList, IEnumerable<CollectionItem> requiredModelList, IDictionary<string, RecordItem> requiredModelRecord, IEnumerable<float?> requiredCollectionWithNullableFloatElement, IEnumerable<bool?> requiredCollectionWithNullableBooleanElement, IEnumerable<CollectionItem> requiredNullableModelList, IEnumerable<string> requiredNullableStringList, IEnumerable<int> requiredNullableIntList)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredModel, nameof(requiredModel));
            Argument.AssertNotNull(requiredModel2, nameof(requiredModel2));
            Argument.AssertNotNull(requiredIntList, nameof(requiredIntList));
            Argument.AssertNotNull(requiredStringList, nameof(requiredStringList));
            Argument.AssertNotNull(requiredModelList, nameof(requiredModelList));
            Argument.AssertNotNull(requiredModelRecord, nameof(requiredModelRecord));
            Argument.AssertNotNull(requiredCollectionWithNullableFloatElement, nameof(requiredCollectionWithNullableFloatElement));
            Argument.AssertNotNull(requiredCollectionWithNullableBooleanElement, nameof(requiredCollectionWithNullableBooleanElement));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredNullableInt = requiredNullableInt;
            RequiredNullableString = requiredNullableString;
            RequiredModel = requiredModel;
            RequiredModel2 = requiredModel2;
            RequiredIntList = requiredIntList.ToList();
            RequiredStringList = requiredStringList.ToList();
            RequiredModelList = requiredModelList.ToList();
            RequiredModelRecord = requiredModelRecord;
            RequiredCollectionWithNullableFloatElement = requiredCollectionWithNullableFloatElement.ToList();
            RequiredCollectionWithNullableBooleanElement = requiredCollectionWithNullableBooleanElement.ToList();
            RequiredNullableModelList = requiredNullableModelList?.ToList();
            RequiredNullableStringList = requiredNullableStringList?.ToList();
            RequiredNullableIntList = requiredNullableIntList?.ToList();
            NonRequiredModelList = new ChangeTrackingList<CollectionItem>();
            NonRequiredStringList = new ChangeTrackingList<string>();
            NonRequiredIntList = new ChangeTrackingList<int>();
            NonRequiredNullableModelList = new ChangeTrackingList<CollectionItem>();
            NonRequiredNullableStringList = new ChangeTrackingList<string>();
            NonRequiredNullableIntList = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of <see cref="InputModel"/>. </summary>
        /// <param name="requiredString"> Required string. </param>
        /// <param name="requiredInt"> Required int. </param>
        /// <param name="requiredNullableInt"> Required nullable int. </param>
        /// <param name="requiredNullableString"> Required nullable string. </param>
        /// <param name="nonRequiredNullableInt"> Optional nullable int. </param>
        /// <param name="nonRequiredNullableString"> Optional nullable string. </param>
        /// <param name="requiredModel"> Required model. </param>
        /// <param name="requiredModel2"> Required model. </param>
        /// <param name="requiredIntList"> Required primitive value type collection. </param>
        /// <param name="requiredStringList"> Required primitive reference type collection. </param>
        /// <param name="requiredModelList"> Required model collection. </param>
        /// <param name="requiredModelRecord"> Required model record. </param>
        /// <param name="requiredCollectionWithNullableFloatElement"> Required collection of which the element is a nullable float. </param>
        /// <param name="requiredCollectionWithNullableBooleanElement"> Required collection of which the element is a nullable boolean. </param>
        /// <param name="requiredNullableModelList"> Required model nullable collection. </param>
        /// <param name="requiredNullableStringList"> Required string nullable collection. </param>
        /// <param name="requiredNullableIntList"> Required int nullable collection. </param>
        /// <param name="nonRequiredModelList"> Optional model collection. </param>
        /// <param name="nonRequiredStringList"> Optional string collection. </param>
        /// <param name="nonRequiredIntList"> Optional int collection. </param>
        /// <param name="nonRequiredNullableModelList"> Optional model nullable collection. </param>
        /// <param name="nonRequiredNullableStringList"> Optional string nullable collection. </param>
        /// <param name="nonRequiredNullableIntList"> Optional int nullable collection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InputModel(string requiredString, int requiredInt, int? requiredNullableInt, string requiredNullableString, int? nonRequiredNullableInt, string nonRequiredNullableString, BaseModel requiredModel, BaseModel requiredModel2, IList<int> requiredIntList, IList<string> requiredStringList, IList<CollectionItem> requiredModelList, IDictionary<string, RecordItem> requiredModelRecord, IList<float?> requiredCollectionWithNullableFloatElement, IList<bool?> requiredCollectionWithNullableBooleanElement, IList<CollectionItem> requiredNullableModelList, IList<string> requiredNullableStringList, IList<int> requiredNullableIntList, IList<CollectionItem> nonRequiredModelList, IList<string> nonRequiredStringList, IList<int> nonRequiredIntList, IList<CollectionItem> nonRequiredNullableModelList, IList<string> nonRequiredNullableStringList, IList<int> nonRequiredNullableIntList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredNullableInt = requiredNullableInt;
            RequiredNullableString = requiredNullableString;
            NonRequiredNullableInt = nonRequiredNullableInt;
            NonRequiredNullableString = nonRequiredNullableString;
            RequiredModel = requiredModel;
            RequiredModel2 = requiredModel2;
            RequiredIntList = requiredIntList;
            RequiredStringList = requiredStringList;
            RequiredModelList = requiredModelList;
            RequiredModelRecord = requiredModelRecord;
            RequiredCollectionWithNullableFloatElement = requiredCollectionWithNullableFloatElement;
            RequiredCollectionWithNullableBooleanElement = requiredCollectionWithNullableBooleanElement;
            RequiredNullableModelList = requiredNullableModelList;
            RequiredNullableStringList = requiredNullableStringList;
            RequiredNullableIntList = requiredNullableIntList;
            NonRequiredModelList = nonRequiredModelList;
            NonRequiredStringList = nonRequiredStringList;
            NonRequiredIntList = nonRequiredIntList;
            NonRequiredNullableModelList = nonRequiredNullableModelList;
            NonRequiredNullableStringList = nonRequiredNullableStringList;
            NonRequiredNullableIntList = nonRequiredNullableIntList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InputModel"/> for deserialization. </summary>
        internal InputModel()
        {
        }

        /// <summary> Required string. </summary>
        public string RequiredString { get; }
        /// <summary> Required int. </summary>
        public int RequiredInt { get; }
        /// <summary> Required nullable int. </summary>
        public int? RequiredNullableInt { get; }
        /// <summary> Required nullable string. </summary>
        public string RequiredNullableString { get; }
        /// <summary> Optional nullable int. </summary>
        public int? NonRequiredNullableInt { get; set; }
        /// <summary> Optional nullable string. </summary>
        public string NonRequiredNullableString { get; set; }
        /// <summary> Required model. </summary>
        public BaseModel RequiredModel { get; }
        /// <summary> Required model. </summary>
        public BaseModel RequiredModel2 { get; }
        /// <summary> Required primitive value type collection. </summary>
        public IList<int> RequiredIntList { get; }
        /// <summary> Required primitive reference type collection. </summary>
        public IList<string> RequiredStringList { get; }
        /// <summary> Required model collection. </summary>
        public IList<CollectionItem> RequiredModelList { get; }
        /// <summary> Required model record. </summary>
        public IDictionary<string, RecordItem> RequiredModelRecord { get; }
        /// <summary> Required collection of which the element is a nullable float. </summary>
        public IList<float?> RequiredCollectionWithNullableFloatElement { get; }
        /// <summary> Required collection of which the element is a nullable boolean. </summary>
        public IList<bool?> RequiredCollectionWithNullableBooleanElement { get; }
        /// <summary> Required model nullable collection. </summary>
        public IList<CollectionItem> RequiredNullableModelList { get; set; }
        /// <summary> Required string nullable collection. </summary>
        public IList<string> RequiredNullableStringList { get; set; }
        /// <summary> Required int nullable collection. </summary>
        public IList<int> RequiredNullableIntList { get; set; }
        /// <summary> Optional model collection. </summary>
        public IList<CollectionItem> NonRequiredModelList { get; }
        /// <summary> Optional string collection. </summary>
        public IList<string> NonRequiredStringList { get; }
        /// <summary> Optional int collection. </summary>
        public IList<int> NonRequiredIntList { get; }
        /// <summary> Optional model nullable collection. </summary>
        public IList<CollectionItem> NonRequiredNullableModelList { get; set; }
        /// <summary> Optional string nullable collection. </summary>
        public IList<string> NonRequiredNullableStringList { get; set; }
        /// <summary> Optional int nullable collection. </summary>
        public IList<int> NonRequiredNullableIntList { get; set; }
    }
}
