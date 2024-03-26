// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes a virtual machine scale set storage profile.
    /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile
    /// </summary>
    public partial class VirtualMachineScaleSetUpdateStorageProfile
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateStorageProfile"/>. </summary>
        public VirtualMachineScaleSetUpdateStorageProfile()
        {
            DataDisks = new ChangeTrackingList<VirtualMachineScaleSetDataDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateStorageProfile"/>. </summary>
        /// <param name="imageReference">
        /// The image reference.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.imageReference
        /// </param>
        /// <param name="osDisk">
        /// The OS disk.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.osDisk
        /// </param>
        /// <param name="dataDisks">
        /// The data disks.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.dataDisks
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateStorageProfile(ImageReference imageReference, VirtualMachineScaleSetUpdateOSDisk osDisk, IList<VirtualMachineScaleSetDataDisk> dataDisks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ImageReference = imageReference;
            OSDisk = osDisk;
            DataDisks = dataDisks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The image reference.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.imageReference
        /// </summary>
        [WirePath("imageReference")]
        public ImageReference ImageReference { get; set; }
        /// <summary>
        /// The OS disk.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.osDisk
        /// </summary>
        [WirePath("osDisk")]
        public VirtualMachineScaleSetUpdateOSDisk OSDisk { get; set; }
        /// <summary>
        /// The data disks.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.dataDisks
        /// </summary>
        [WirePath("dataDisks")]
        public IList<VirtualMachineScaleSetDataDisk> DataDisks { get; }
    }
}