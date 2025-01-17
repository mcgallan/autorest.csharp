// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    [PersistableModelProxy(typeof(UnknownFish))]
    public partial class Fish : IUtf8JsonSerializable, IJsonModel<Fish>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Fish>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Fish>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Fish)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fishtype"u8);
            writer.WriteStringValue(Fishtype);
            if (Optional.IsDefined(Species))
            {
                writer.WritePropertyName("species"u8);
                writer.WriteStringValue(Species);
            }
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
            if (Optional.IsCollectionDefined(Siblings))
            {
                writer.WritePropertyName("siblings"u8);
                writer.WriteStartArray();
                foreach (var item in Siblings)
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

        Fish IJsonModel<Fish>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Fish)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFish(document.RootElement, options);
        }

        internal static Fish DeserializeFish(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("fishtype", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "cookiecuttershark": return Cookiecuttershark.DeserializeCookiecuttershark(element, options);
                    case "goblin": return Goblinshark.DeserializeGoblinshark(element, options);
                    case "salmon": return Salmon.DeserializeSalmon(element, options);
                    case "sawshark": return Sawshark.DeserializeSawshark(element, options);
                    case "shark": return Shark.DeserializeShark(element, options);
                    case "smart_salmon": return SmartSalmon.DeserializeSmartSalmon(element, options);
                }
            }
            return UnknownFish.DeserializeUnknownFish(element, options);
        }

        BinaryData IPersistableModel<Fish>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Fish)} does not support writing '{options.Format}' format.");
            }
        }

        Fish IPersistableModel<Fish>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFish(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Fish)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Fish>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
