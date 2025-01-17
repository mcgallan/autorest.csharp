// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateEditResponseChoice : IJsonModel<CreateEditResponseChoice>
    {
        void IJsonModel<CreateEditResponseChoice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            writer.WritePropertyName("finish_reason"u8);
            writer.WriteStringValue(FinishReason.ToString());
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

        CreateEditResponseChoice IJsonModel<CreateEditResponseChoice>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateEditResponseChoice(document.RootElement, options);
        }

        internal static CreateEditResponseChoice DeserializeCreateEditResponseChoice(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            long index = default;
            CreateEditResponseChoiceFinishReason finishReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("finish_reason"u8))
                {
                    finishReason = new CreateEditResponseChoiceFinishReason(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateEditResponseChoice(text, index, finishReason, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateEditResponseChoice>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support writing '{options.Format}' format.");
            }
        }

        CreateEditResponseChoice IPersistableModel<CreateEditResponseChoice>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateEditResponseChoice(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateEditResponseChoice>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateEditResponseChoice FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateEditResponseChoice(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
