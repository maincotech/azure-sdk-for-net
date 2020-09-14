// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class UserSession : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(UserPrincipalName))
            {
                writer.WritePropertyName("userPrincipalName");
                writer.WriteStringValue(UserPrincipalName);
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType");
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            if (Optional.IsDefined(SessionState))
            {
                writer.WritePropertyName("sessionState");
                writer.WriteStringValue(SessionState.Value.ToString());
            }
            if (Optional.IsDefined(ActiveDirectoryUserName))
            {
                writer.WritePropertyName("activeDirectoryUserName");
                writer.WriteStringValue(ActiveDirectoryUserName);
            }
            if (Optional.IsDefined(CreateTime))
            {
                writer.WritePropertyName("createTime");
                writer.WriteStringValue(CreateTime.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static UserSession DeserializeUserSession(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> userPrincipalName = default;
            Optional<ApplicationType> applicationType = default;
            Optional<SessionState> sessionState = default;
            Optional<string> activeDirectoryUserName = default;
            Optional<DateTimeOffset> createTime = default;
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
                        if (property0.NameEquals("userPrincipalName"))
                        {
                            userPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationType"))
                        {
                            applicationType = new ApplicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sessionState"))
                        {
                            sessionState = new SessionState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activeDirectoryUserName"))
                        {
                            activeDirectoryUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createTime"))
                        {
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new UserSession(id.Value, name.Value, type.Value, userPrincipalName.Value, Optional.ToNullable(applicationType), Optional.ToNullable(sessionState), activeDirectoryUserName.Value, Optional.ToNullable(createTime));
        }
    }
}
