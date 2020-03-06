// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class Operation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Display != null)
            {
                writer.WritePropertyName("display");
                writer.WriteObjectValue(Display);
            }
            if (Origin != null)
            {
                writer.WritePropertyName("origin");
                writer.WriteStringValue(Origin);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ServiceSpecification != null)
            {
                writer.WritePropertyName("serviceSpecification");
                writer.WriteObjectValue(ServiceSpecification);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static Operation DeserializeOperation(JsonElement element)
        {
            Operation result = new Operation();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Display = OperationDisplay.DeserializeOperationDisplay(property.Value);
                    continue;
                }
                if (property.NameEquals("origin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceSpecification"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ServiceSpecification = ServiceSpecification.DeserializeServiceSpecification(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return result;
        }
    }
}