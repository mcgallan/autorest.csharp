// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Payload.MultiPart.Models
{
    /// <summary> The FileSpecificContentType. </summary>
    public partial class FileSpecificContentType : File
    {
        /// <summary> Initializes a new instance of <see cref="FileSpecificContentType"/>. </summary>
        /// <param name="contents"></param>
        /// <param name="filename"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="contents"/> or <paramref name="filename"/> is null. </exception>
        public FileSpecificContentType(BinaryData contents, string filename) : base(contents)
        {
            Argument.AssertNotNull(contents, nameof(contents));
            Argument.AssertNotNull(filename, nameof(filename));
        }

        /// <summary> Initializes a new instance of <see cref="FileSpecificContentType"/>. </summary>
        /// <param name="contentType"></param>
        /// <param name="filename"></param>
        /// <param name="contents"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileSpecificContentType(string contentType, string filename, BinaryData contents, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(contentType, filename, contents, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="FileSpecificContentType"/> for deserialization. </summary>
        internal FileSpecificContentType()
        {
        }
    }
}