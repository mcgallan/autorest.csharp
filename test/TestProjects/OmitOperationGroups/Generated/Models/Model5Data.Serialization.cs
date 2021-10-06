// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using OmitOperationGroups.Models;

namespace OmitOperationGroups
{
    public partial class Model5Data : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Modelqs))
            {
                writer.WritePropertyName("modelqs");
                writer.WriteStartArray();
                foreach (var item in Modelqs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Model5Data DeserializeModel5Data(JsonElement element)
        {
            Optional<string> k = default;
            Optional<IList<ModelQ>> modelqs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("k"))
                {
                    k = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelqs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ModelQ> array = new List<ModelQ>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelQ.DeserializeModelQ(item));
                    }
                    modelqs = array;
                    continue;
                }
            }
            return new Model5Data(k.Value, Optional.ToList(modelqs));
        }
    }
}