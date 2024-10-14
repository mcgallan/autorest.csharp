// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Payload.Xml.Models
{
    public partial class ModelWithEncodedNames : IUtf8JsonSerializable, IJsonModel<ModelWithEncodedNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelWithEncodedNames>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ModelWithEncodedNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithEncodedNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelWithEncodedNames)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("modelData"u8);
            writer.WriteObjectValue(ModelData, options);
            writer.WritePropertyName("colors"u8);
            writer.WriteStartArray();
            foreach (var item in Colors)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        ModelWithEncodedNames IJsonModel<ModelWithEncodedNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithEncodedNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelWithEncodedNames)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelWithEncodedNames(document.RootElement, options);
        }

        internal static ModelWithEncodedNames DeserializeModelWithEncodedNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SimpleModel modelData = default;
            IList<string> colors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelData"u8))
                {
                    modelData = SimpleModel.DeserializeSimpleModel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("colors"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    colors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ModelWithEncodedNames(modelData, colors, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ModelWithEncodedNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithEncodedNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelWithEncodedNames)} does not support writing '{options.Format}' format.");
            }
        }

        ModelWithEncodedNames IPersistableModel<ModelWithEncodedNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelWithEncodedNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelWithEncodedNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelWithEncodedNames)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelWithEncodedNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ModelWithEncodedNames FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeModelWithEncodedNames(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
