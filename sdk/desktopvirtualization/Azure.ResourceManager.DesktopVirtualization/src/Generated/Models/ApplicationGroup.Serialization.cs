// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ApplicationGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            writer.WritePropertyName("hostPoolArmPath");
            writer.WriteStringValue(HostPoolArmPath);
            writer.WritePropertyName("applicationGroupType");
            writer.WriteStringValue(ApplicationGroupType.ToString());
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGroup DeserializeApplicationGroup(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            string location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> description = default;
            Optional<string> friendlyName = default;
            string hostPoolArmPath = default;
            Optional<string> workspaceArmPath = default;
            ApplicationGroupType applicationGroupType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostPoolArmPath"))
                        {
                            hostPoolArmPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("workspaceArmPath"))
                        {
                            workspaceArmPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationGroupType"))
                        {
                            applicationGroupType = new ApplicationGroupType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGroup(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), location, description.Value, friendlyName.Value, hostPoolArmPath, workspaceArmPath.Value, applicationGroupType);
        }
    }
}
