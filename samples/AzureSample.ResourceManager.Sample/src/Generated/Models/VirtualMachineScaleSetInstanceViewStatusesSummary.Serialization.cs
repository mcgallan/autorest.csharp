// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace AzureSample.ResourceManager.Sample.Models
{
    internal partial class VirtualMachineScaleSetInstanceViewStatusesSummary : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(StatusesSummary))
            {
                writer.WritePropertyName("statusesSummary"u8);
                writer.WriteStartArray();
                foreach (var item in StatusesSummary)
                {
                    writer.WriteObjectValue<VirtualMachineStatusCodeCount>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VirtualMachineScaleSetInstanceViewStatusesSummary IJsonModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetInstanceViewStatusesSummary DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<VirtualMachineStatusCodeCount> statusesSummary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusesSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineStatusCodeCount> array = new List<VirtualMachineStatusCodeCount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineStatusCodeCount.DeserializeVirtualMachineStatusCodeCount(item, options));
                    }
                    statusesSummary = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetInstanceViewStatusesSummary(statusesSummary ?? new ChangeTrackingList<VirtualMachineStatusCodeCount>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatusesSummary), out propertyOverride);
            if (Optional.IsCollectionDefined(StatusesSummary) || hasPropertyOverride)
            {
                if (StatusesSummary.Any() || hasPropertyOverride)
                {
                    builder.Append("  statusesSummary: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in StatusesSummary)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  statusesSummary: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetInstanceViewStatusesSummary IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetInstanceViewStatusesSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetInstanceViewStatusesSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}