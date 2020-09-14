// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ApplicationPatch : IUtf8JsonSerializable
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
            if (Optional.IsDefined(CommandLineSetting))
            {
                writer.WritePropertyName("commandLineSetting");
                writer.WriteStringValue(CommandLineSetting.Value.ToString());
            }
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
    }
}
