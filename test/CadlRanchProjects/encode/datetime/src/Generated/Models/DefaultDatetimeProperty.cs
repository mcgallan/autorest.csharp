// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Encode.Datetime.Models
{
    /// <summary> The DefaultDatetimeProperty. </summary>
    public partial class DefaultDatetimeProperty
    {
        /// <summary> Initializes a new instance of DefaultDatetimeProperty. </summary>
        /// <param name="value"></param>
        public DefaultDatetimeProperty(DateTimeOffset value)
        {
            Value = value;
        }

        /// <summary> Gets or sets the value. </summary>
        public DateTimeOffset Value { get; set; }
    }
}