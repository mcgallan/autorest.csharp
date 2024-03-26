// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace MgmtSupersetInheritance.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    internal partial class SupersetModel4ListResult
    {
        /// <summary> Initializes a new instance of <see cref="SupersetModel4ListResult"/>. </summary>
        internal SupersetModel4ListResult()
        {
            Value = new ChangeTrackingList<SupersetModel4Data>();
        }

        /// <summary> Initializes a new instance of <see cref="SupersetModel4ListResult"/>. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal SupersetModel4ListResult(IReadOnlyList<SupersetModel4Data> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<SupersetModel4Data> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}