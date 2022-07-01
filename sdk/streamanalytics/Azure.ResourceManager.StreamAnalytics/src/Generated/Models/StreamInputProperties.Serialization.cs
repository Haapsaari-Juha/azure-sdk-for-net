// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamInputProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Datasource))
            {
                writer.WritePropertyName("datasource");
                writer.WriteObjectValue(Datasource);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(InputPropertiesType);
            if (Optional.IsDefined(Serialization))
            {
                writer.WritePropertyName("serialization");
                writer.WriteObjectValue(Serialization);
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression");
                writer.WriteObjectValue(Compression);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey");
                writer.WriteStringValue(PartitionKey);
            }
            if (Optional.IsDefined(WatermarkSettings))
            {
                writer.WritePropertyName("watermarkSettings");
                writer.WriteObjectValue(WatermarkSettings);
            }
            writer.WriteEndObject();
        }

        internal static StreamInputProperties DeserializeStreamInputProperties(JsonElement element)
        {
            Optional<StreamInputDataSource> datasource = default;
            string type = default;
            Optional<Serialization> serialization = default;
            Optional<Diagnostics> diagnostics = default;
            Optional<ETag> etag = default;
            Optional<Compression> compression = default;
            Optional<string> partitionKey = default;
            Optional<InputWatermarkProperties> watermarkSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datasource = StreamInputDataSource.DeserializeStreamInputDataSource(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serialization = Serialization.DeserializeSerialization(property.Value);
                    continue;
                }
                if (property.NameEquals("diagnostics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diagnostics = Diagnostics.DeserializeDiagnostics(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("compression"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    compression = Compression.DeserializeCompression(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionKey"))
                {
                    partitionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("watermarkSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    watermarkSettings = InputWatermarkProperties.DeserializeInputWatermarkProperties(property.Value);
                    continue;
                }
            }
            return new StreamInputProperties(type, serialization.Value, diagnostics.Value, Optional.ToNullable(etag), compression.Value, partitionKey.Value, watermarkSettings.Value, datasource.Value);
        }
    }
}
