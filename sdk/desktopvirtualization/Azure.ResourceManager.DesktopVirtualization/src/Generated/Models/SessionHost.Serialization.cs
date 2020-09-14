// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class SessionHost : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LastHeartBeat))
            {
                writer.WritePropertyName("lastHeartBeat");
                writer.WriteStringValue(LastHeartBeat.Value, "O");
            }
            if (Optional.IsDefined(Sessions))
            {
                writer.WritePropertyName("sessions");
                writer.WriteNumberValue(Sessions.Value);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion");
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AllowNewSession))
            {
                writer.WritePropertyName("allowNewSession");
                writer.WriteBooleanValue(AllowNewSession.Value);
            }
            if (Optional.IsDefined(AssignedUser))
            {
                writer.WritePropertyName("assignedUser");
                writer.WriteStringValue(AssignedUser);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(OsVersion))
            {
                writer.WritePropertyName("osVersion");
                writer.WriteStringValue(OsVersion);
            }
            if (Optional.IsDefined(SxSStackVersion))
            {
                writer.WritePropertyName("sxSStackVersion");
                writer.WriteStringValue(SxSStackVersion);
            }
            if (Optional.IsDefined(UpdateState))
            {
                writer.WritePropertyName("updateState");
                writer.WriteStringValue(UpdateState.Value.ToString());
            }
            if (Optional.IsDefined(UpdateErrorMessage))
            {
                writer.WritePropertyName("updateErrorMessage");
                writer.WriteStringValue(UpdateErrorMessage);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SessionHost DeserializeSessionHost(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<DateTimeOffset> lastHeartBeat = default;
            Optional<int> sessions = default;
            Optional<string> agentVersion = default;
            Optional<bool> allowNewSession = default;
            Optional<string> virtualMachineId = default;
            Optional<string> resourceId = default;
            Optional<string> assignedUser = default;
            Optional<Status> status = default;
            Optional<DateTimeOffset> statusTimestamp = default;
            Optional<string> osVersion = default;
            Optional<string> sxSStackVersion = default;
            Optional<UpdateState> updateState = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<string> updateErrorMessage = default;
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
                        if (property0.NameEquals("lastHeartBeat"))
                        {
                            lastHeartBeat = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sessions"))
                        {
                            sessions = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowNewSession"))
                        {
                            allowNewSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineId"))
                        {
                            virtualMachineId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("assignedUser"))
                        {
                            assignedUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = new Status(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statusTimestamp"))
                        {
                            statusTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osVersion"))
                        {
                            osVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sxSStackVersion"))
                        {
                            sxSStackVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateState"))
                        {
                            updateState = new UpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"))
                        {
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateErrorMessage"))
                        {
                            updateErrorMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SessionHost(id.Value, name.Value, type.Value, Optional.ToNullable(lastHeartBeat), Optional.ToNullable(sessions), agentVersion.Value, Optional.ToNullable(allowNewSession), virtualMachineId.Value, resourceId.Value, assignedUser.Value, Optional.ToNullable(status), Optional.ToNullable(statusTimestamp), osVersion.Value, sxSStackVersion.Value, Optional.ToNullable(updateState), Optional.ToNullable(lastUpdateTime), updateErrorMessage.Value);
        }
    }
}
