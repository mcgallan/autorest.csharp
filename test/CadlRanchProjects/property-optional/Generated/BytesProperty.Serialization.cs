// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Models.Property.Optional
{
    public partial class BytesProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Azure.Core.Optional.IsDefined(Property))
            {
                writer.WritePropertyName("property");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Property);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Property.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static BytesProperty DeserializeBytesProperty(JsonElement element)
        {
            Optional<BinaryData> property = default;
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"))
                {
                    if (property0.Value.ValueKind == JsonValueKind.Null)
                    {
                        property0.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    property = BinaryData.FromString(property0.Value.GetRawText());
                    continue;
                }
            }
            return new BytesProperty(property);
        }

        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal static BytesProperty FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBytesProperty(document.RootElement);
        }
    }
}