// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace OmitOperationGroups
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region Model2
        /// <summary> Gets an object representing a Model2Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="Model2Container" /> object. </returns>
        public static Model2Container GetModel2s(this ResourceGroup resourceGroup)
        {
            return new Model2Container(resourceGroup);
        }
        #endregion

        #region Model5
        /// <summary> Gets an object representing a Model5Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="Model5Container" /> object. </returns>
        public static Model5Container GetModel5s(this ResourceGroup resourceGroup)
        {
            return new Model5Container(resourceGroup);
        }
        #endregion
    }
}