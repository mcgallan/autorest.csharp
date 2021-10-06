// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using OmitOperationGroups.Models;

namespace OmitOperationGroups
{
    /// <summary> A class representing the Model2 data model. </summary>
    public partial class Model2Data : Model3
    {
        /// <summary> Initializes a new instance of Model2Data. </summary>
        public Model2Data()
        {
        }

        /// <summary> Initializes a new instance of Model2Data. </summary>
        /// <param name="f"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="modelx"></param>
        internal Model2Data(string f, string g, string b, ModelX modelx) : base(f, g)
        {
            B = b;
            Modelx = modelx;
        }

        /// <summary> Gets or sets the b. </summary>
        public string B { get; set; }
        /// <summary> Gets or sets the modelx. </summary>
        public ModelX Modelx { get; set; }
    }
}