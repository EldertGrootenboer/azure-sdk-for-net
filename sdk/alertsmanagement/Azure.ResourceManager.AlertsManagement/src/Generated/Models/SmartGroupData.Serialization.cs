// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement
{
    public partial class SmartGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AlertsCount))
            {
                writer.WritePropertyName("alertsCount"u8);
                writer.WriteNumberValue(AlertsCount.Value);
            }
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceGroups))
            {
                writer.WritePropertyName("resourceGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonitorServices))
            {
                writer.WritePropertyName("monitorServices"u8);
                writer.WriteStartArray();
                foreach (var item in MonitorServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonitorConditions))
            {
                writer.WritePropertyName("monitorConditions"u8);
                writer.WriteStartArray();
                foreach (var item in MonitorConditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlertStates))
            {
                writer.WritePropertyName("alertStates"u8);
                writer.WriteStartArray();
                foreach (var item in AlertStates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlertSeverities))
            {
                writer.WritePropertyName("alertSeverities"u8);
                writer.WriteStartArray();
                foreach (var item in AlertSeverities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SmartGroupData DeserializeSmartGroupData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<long> alertsCount = default;
            Optional<SmartGroupState> smartGroupState = default;
            Optional<ServiceAlertSeverity> severity = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> lastModifiedDateTime = default;
            Optional<string> lastModifiedUserName = default;
            Optional<IList<SmartGroupAggregatedProperty>> resources = default;
            Optional<IList<SmartGroupAggregatedProperty>> resourceTypes = default;
            Optional<IList<SmartGroupAggregatedProperty>> resourceGroups = default;
            Optional<IList<SmartGroupAggregatedProperty>> monitorServices = default;
            Optional<IList<SmartGroupAggregatedProperty>> monitorConditions = default;
            Optional<IList<SmartGroupAggregatedProperty>> alertStates = default;
            Optional<IList<SmartGroupAggregatedProperty>> alertSeverities = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("alertsCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertsCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("smartGroupState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            smartGroupState = new SmartGroupState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new ServiceAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedUserName"u8))
                        {
                            lastModifiedUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SmartGroupAggregatedProperty> array = new List<SmartGroupAggregatedProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupAggregatedProperty.DeserializeSmartGroupAggregatedProperty(item));
                            }
                            resources = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SmartGroupAggregatedProperty> array = new List<SmartGroupAggregatedProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupAggregatedProperty.DeserializeSmartGroupAggregatedProperty(item));
                            }
                            resourceTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SmartGroupAggregatedProperty> array = new List<SmartGroupAggregatedProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupAggregatedProperty.DeserializeSmartGroupAggregatedProperty(item));
                            }
                            resourceGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("monitorServices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SmartGroupAggregatedProperty> array = new List<SmartGroupAggregatedProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupAggregatedProperty.DeserializeSmartGroupAggregatedProperty(item));
                            }
                            monitorServices = array;
                            continue;
                        }
                        if (property0.NameEquals("monitorConditions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SmartGroupAggregatedProperty> array = new List<SmartGroupAggregatedProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupAggregatedProperty.DeserializeSmartGroupAggregatedProperty(item));
                            }
                            monitorConditions = array;
                            continue;
                        }
                        if (property0.NameEquals("alertStates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SmartGroupAggregatedProperty> array = new List<SmartGroupAggregatedProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupAggregatedProperty.DeserializeSmartGroupAggregatedProperty(item));
                            }
                            alertStates = array;
                            continue;
                        }
                        if (property0.NameEquals("alertSeverities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SmartGroupAggregatedProperty> array = new List<SmartGroupAggregatedProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupAggregatedProperty.DeserializeSmartGroupAggregatedProperty(item));
                            }
                            alertSeverities = array;
                            continue;
                        }
                        if (property0.NameEquals("nextLink"u8))
                        {
                            nextLink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SmartGroupData(id, name, type, systemData.Value, Optional.ToNullable(alertsCount), Optional.ToNullable(smartGroupState), Optional.ToNullable(severity), Optional.ToNullable(startDateTime), Optional.ToNullable(lastModifiedDateTime), lastModifiedUserName.Value, Optional.ToList(resources), Optional.ToList(resourceTypes), Optional.ToList(resourceGroups), Optional.ToList(monitorServices), Optional.ToList(monitorConditions), Optional.ToList(alertStates), Optional.ToList(alertSeverities), nextLink.Value);
        }
    }
}
