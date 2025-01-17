// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace TypeSchemaMapping.Models
{
    public partial class ModelWithListOfInternalModel : IUtf8JsonSerializable, IJsonModel<ModelWithListOfInternalModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelWithListOfInternalModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ModelWithListOfInternalModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithListOfInternalModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelWithListOfInternalModel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(StringProperty))
            {
                writer.WritePropertyName("StringProperty"u8);
                writer.WriteStringValue(StringProperty);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(InternalListProperty))
            {
                writer.WritePropertyName("InternalListProperty"u8);
                writer.WriteStartArray();
                foreach (var item in InternalListProperty)
                {
                    writer.WriteObjectValue(item);
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

        ModelWithListOfInternalModel IJsonModel<ModelWithListOfInternalModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithListOfInternalModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelWithListOfInternalModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelWithListOfInternalModel(document.RootElement, options);
        }

        internal static ModelWithListOfInternalModel DeserializeModelWithListOfInternalModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string stringProperty = default;
            IReadOnlyList<InternalModel> internalListProperty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("StringProperty"u8))
                {
                    stringProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("InternalListProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InternalModel> array = new List<InternalModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InternalModel.DeserializeInternalModel(item, options));
                    }
                    internalListProperty = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ModelWithListOfInternalModel(stringProperty, internalListProperty ?? new ChangeTrackingList<InternalModel>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ModelWithListOfInternalModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithListOfInternalModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelWithListOfInternalModel)} does not support writing '{options.Format}' format.");
            }
        }

        ModelWithListOfInternalModel IPersistableModel<ModelWithListOfInternalModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithListOfInternalModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelWithListOfInternalModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelWithListOfInternalModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelWithListOfInternalModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
