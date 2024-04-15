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

namespace MgmtDiscriminator.Models
{
    public partial class UrlSigningActionParameters : IUtf8JsonSerializable, IJsonModel<UrlSigningActionParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UrlSigningActionParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UrlSigningActionParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlSigningActionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UrlSigningActionParameters)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(TypeName.ToString());
            if (Optional.IsDefined(Algorithm))
            {
                writer.WritePropertyName("algorithm"u8);
                writer.WriteStringValue(Algorithm.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ParameterNameOverride))
            {
                writer.WritePropertyName("parameterNameOverride"u8);
                writer.WriteStartArray();
                foreach (var item in ParameterNameOverride)
                {
                    writer.WriteObjectValue(item, options);
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

        UrlSigningActionParameters IJsonModel<UrlSigningActionParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlSigningActionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UrlSigningActionParameters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUrlSigningActionParameters(document.RootElement, options);
        }

        internal static UrlSigningActionParameters DeserializeUrlSigningActionParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UrlSigningActionParametersTypeName typeName = default;
            Algorithm? algorithm = default;
            IList<UrlSigningParamIdentifier> parameterNameOverride = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new UrlSigningActionParametersTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("algorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    algorithm = new Algorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameterNameOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UrlSigningParamIdentifier> array = new List<UrlSigningParamIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UrlSigningParamIdentifier.DeserializeUrlSigningParamIdentifier(item, options));
                    }
                    parameterNameOverride = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UrlSigningActionParameters(typeName, algorithm, parameterNameOverride ?? new ChangeTrackingList<UrlSigningParamIdentifier>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TypeName), out propertyOverride);
            builder.Append("  typeName: ");
            if (hasPropertyOverride)
            {
                builder.AppendLine($"{propertyOverride}");
            }
            else
            {
                builder.AppendLine($"'{TypeName.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Algorithm), out propertyOverride);
            if (Optional.IsDefined(Algorithm) || hasPropertyOverride)
            {
                builder.Append("  algorithm: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Algorithm.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ParameterNameOverride), out propertyOverride);
            if (Optional.IsCollectionDefined(ParameterNameOverride) || hasPropertyOverride)
            {
                if (ParameterNameOverride.Any() || hasPropertyOverride)
                {
                    builder.Append("  parameterNameOverride: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in ParameterNameOverride)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  parameterNameOverride: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<UrlSigningActionParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlSigningActionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UrlSigningActionParameters)} does not support writing '{options.Format}' format.");
            }
        }

        UrlSigningActionParameters IPersistableModel<UrlSigningActionParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UrlSigningActionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUrlSigningActionParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UrlSigningActionParameters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UrlSigningActionParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
