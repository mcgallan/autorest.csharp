// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CommonProperties.Models
{
    internal partial class ManagedIdentityTrackedResourceProperties : IUtf8JsonSerializable, IJsonModel<ManagedIdentityTrackedResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedIdentityTrackedResourceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedIdentityTrackedResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityTrackedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIdentityTrackedResourceProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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
        }

        ManagedIdentityTrackedResourceProperties IJsonModel<ManagedIdentityTrackedResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityTrackedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIdentityTrackedResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedIdentityTrackedResourceProperties(document.RootElement, options);
        }

        internal static ManagedIdentityTrackedResourceProperties DeserializeManagedIdentityTrackedResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedIdentityTrackedResourceProperties(provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedIdentityTrackedResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityTrackedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedIdentityTrackedResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedIdentityTrackedResourceProperties IPersistableModel<ManagedIdentityTrackedResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityTrackedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedIdentityTrackedResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedIdentityTrackedResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedIdentityTrackedResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
