// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Payload.MultiPart.Models
{
    public partial class FileOptionalContentType : IJsonModel<FileOptionalContentType>
    {
        void IJsonModel<FileOptionalContentType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileOptionalContentType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileOptionalContentType)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType);
            }
            if (Optional.IsDefined(Filename))
            {
                writer.WritePropertyName("filename"u8);
                writer.WriteStringValue(Filename);
            }
            writer.WritePropertyName("contents"u8);
            writer.WriteBase64StringValue(Contents.ToArray(), "D");
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

        FileOptionalContentType IJsonModel<FileOptionalContentType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileOptionalContentType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileOptionalContentType)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileOptionalContentType(document.RootElement, options);
        }

        internal static FileOptionalContentType DeserializeFileOptionalContentType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contentType = default;
            string filename = default;
            BinaryData contents = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentType"u8))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filename"u8))
                {
                    filename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contents"u8))
                {
                    contents = BinaryData.FromBytes(property.Value.GetBytesFromBase64("D"));
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FileOptionalContentType(contentType, filename, contents, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FileOptionalContentType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileOptionalContentType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileOptionalContentType)} does not support writing '{options.Format}' format.");
            }
        }

        FileOptionalContentType IPersistableModel<FileOptionalContentType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileOptionalContentType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileOptionalContentType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileOptionalContentType)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileOptionalContentType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static new FileOptionalContentType FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFileOptionalContentType(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
