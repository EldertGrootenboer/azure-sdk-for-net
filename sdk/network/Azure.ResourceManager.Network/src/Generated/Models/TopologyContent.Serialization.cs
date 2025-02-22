// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TopologyContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
            }
            if (Optional.IsDefined(TargetVirtualNetwork))
            {
                writer.WritePropertyName("targetVirtualNetwork"u8);
                JsonSerializer.Serialize(writer, TargetVirtualNetwork);
            }
            if (Optional.IsDefined(TargetSubnet))
            {
                writer.WritePropertyName("targetSubnet"u8);
                JsonSerializer.Serialize(writer, TargetSubnet);
            }
            writer.WriteEndObject();
        }
    }
}
