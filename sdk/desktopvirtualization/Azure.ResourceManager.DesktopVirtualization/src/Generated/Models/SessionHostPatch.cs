// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> SessionHost properties that can be patched. </summary>
    public partial class SessionHostPatch : Resource
    {
        /// <summary> Initializes a new instance of SessionHostPatch. </summary>
        public SessionHostPatch()
        {
        }

        /// <summary> Initializes a new instance of SessionHostPatch. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="allowNewSession"> Allow a new session. </param>
        /// <param name="assignedUser"> User assigned to SessionHost. </param>
        internal SessionHostPatch(string id, string name, string type, bool? allowNewSession, string assignedUser) : base(id, name, type)
        {
            AllowNewSession = allowNewSession;
            AssignedUser = assignedUser;
        }

        /// <summary> Allow a new session. </summary>
        public bool? AllowNewSession { get; set; }
        /// <summary> User assigned to SessionHost. </summary>
        public string AssignedUser { get; set; }
    }
}
