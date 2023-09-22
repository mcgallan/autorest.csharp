// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ConfidentLevelsInTsp.Models
{
    /// <summary> This is a model with a property of literal type of numbers. </summary>
    internal partial class ModelWithIntegerLiteralTypeProperty
    {
        /// <summary> Initializes a new instance of ModelWithIntegerLiteralTypeProperty. </summary>
        /// <param name="name"> The name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ModelWithIntegerLiteralTypeProperty(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of ModelWithIntegerLiteralTypeProperty. </summary>
        /// <param name="name"> The name. </param>
        /// <param name="id"> The id. </param>
        internal ModelWithIntegerLiteralTypeProperty(string name, ModelWithIntegerLiteralTypePropertyId id)
        {
            Name = name;
            Id = id;
        }

        /// <summary> The name. </summary>
        public string Name { get; }
        /// <summary> The id. </summary>
        public ModelWithIntegerLiteralTypePropertyId Id { get; } = ModelWithIntegerLiteralTypePropertyId._1;
    }
}