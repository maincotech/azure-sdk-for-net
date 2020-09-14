// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents a Workspace definition. </summary>
    public partial class Workspace : TrackedResource
    {
        /// <summary> Initializes a new instance of Workspace. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Workspace(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            ApplicationGroupReferences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of Workspace. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="description"> Description of Workspace. </param>
        /// <param name="friendlyName"> Friendly name of Workspace. </param>
        /// <param name="applicationGroupReferences"> List of applicationGroup resource Ids. </param>
        internal Workspace(string id, string name, string type, IDictionary<string, string> tags, string location, string description, string friendlyName, IList<string> applicationGroupReferences) : base(id, name, type, tags, location)
        {
            Description = description;
            FriendlyName = friendlyName;
            ApplicationGroupReferences = applicationGroupReferences;
        }

        /// <summary> Description of Workspace. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Workspace. </summary>
        public string FriendlyName { get; set; }
        /// <summary> List of applicationGroup resource Ids. </summary>
        public IList<string> ApplicationGroupReferences { get; }
    }
}
