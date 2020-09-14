// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class Application : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath");
                writer.WriteStringValue(FilePath);
            }
            writer.WritePropertyName("commandLineSetting");
            writer.WriteStringValue(CommandLineSetting.ToString());
            if (Optional.IsDefined(CommandLineArguments))
            {
                writer.WritePropertyName("commandLineArguments");
                writer.WriteStringValue(CommandLineArguments);
            }
            if (Optional.IsDefined(ShowInPortal))
            {
                writer.WritePropertyName("showInPortal");
                writer.WriteBooleanValue(ShowInPortal.Value);
            }
            if (Optional.IsDefined(IconPath))
            {
                writer.WritePropertyName("iconPath");
                writer.WriteStringValue(IconPath);
            }
            if (Optional.IsDefined(IconIndex))
            {
                writer.WritePropertyName("iconIndex");
                writer.WriteNumberValue(IconIndex.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Application DeserializeApplication(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> description = default;
            Optional<string> friendlyName = default;
            Optional<string> filePath = default;
            CommandLineSetting commandLineSetting = default;
            Optional<string> commandLineArguments = default;
            Optional<bool> showInPortal = default;
            Optional<string> iconPath = default;
            Optional<int> iconIndex = default;
            Optional<string> iconHash = default;
            Optional<byte[]> iconContent = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("filePath"))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("commandLineSetting"))
                        {
                            commandLineSetting = new CommandLineSetting(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("commandLineArguments"))
                        {
                            commandLineArguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("showInPortal"))
                        {
                            showInPortal = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iconPath"))
                        {
                            iconPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconIndex"))
                        {
                            iconIndex = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("iconHash"))
                        {
                            iconHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconContent"))
                        {
                            iconContent = property0.Value.GetBytesFromBase64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Application(id.Value, name.Value, type.Value, description.Value, friendlyName.Value, filePath.Value, commandLineSetting, commandLineArguments.Value, Optional.ToNullable(showInPortal), iconPath.Value, Optional.ToNullable(iconIndex), iconHash.Value, iconContent.Value);
        }
    }
}
