// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace MgmtRenameRules.Models
{
    /// <summary> Virtual Machine Scale Set OS Upgrade History operation response. </summary>
    public partial class UpgradeOperationHistoricalStatusInfo
    {
        /// <summary> Initializes a new instance of UpgradeOperationHistoricalStatusInfo. </summary>
        internal UpgradeOperationHistoricalStatusInfo()
        {
        }

        /// <summary> Initializes a new instance of UpgradeOperationHistoricalStatusInfo. </summary>
        /// <param name="properties"> Information about the properties of the upgrade operation. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        internal UpgradeOperationHistoricalStatusInfo(UpgradeOperationHistoricalStatusInfoProperties properties, ResourceType? resourceType, string location)
        {
            Properties = properties;
            ResourceType = resourceType;
            Location = location;
        }

        /// <summary> Information about the properties of the upgrade operation. </summary>
        public UpgradeOperationHistoricalStatusInfoProperties Properties { get; }
        /// <summary> Resource type. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; }
    }
}