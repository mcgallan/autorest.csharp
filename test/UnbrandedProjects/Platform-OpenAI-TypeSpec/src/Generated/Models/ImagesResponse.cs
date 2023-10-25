// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The ImagesResponse. </summary>
    public partial class ImagesResponse
    {
        /// <summary> Initializes a new instance of ImagesResponse. </summary>
        /// <param name="created"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal ImagesResponse(DateTimeOffset created, IEnumerable<Image> data)
        {
            ClientUtilities.AssertNotNull(data, nameof(data));

            Created = created;
            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of ImagesResponse. </summary>
        /// <param name="created"></param>
        /// <param name="data"></param>
        internal ImagesResponse(DateTimeOffset created, IReadOnlyList<Image> data)
        {
            Created = created;
            Data = data;
        }

        /// <summary> Gets the created. </summary>
        public DateTimeOffset Created { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<Image> Data { get; }
    }
}