// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Pagination
{
    /// <summary> A class representing the PageSizeNumericModel data model. </summary>
    public partial class PageSizeNumericModelData
    {
        /// <summary> Initializes a new instance of PageSizeNumericModelData. </summary>
        public PageSizeNumericModelData()
        {
        }

        /// <summary> Initializes a new instance of PageSizeNumericModelData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        internal PageSizeNumericModelData(string id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary> Resource ID. </summary>
        public string Id { get; }
        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
    }
}