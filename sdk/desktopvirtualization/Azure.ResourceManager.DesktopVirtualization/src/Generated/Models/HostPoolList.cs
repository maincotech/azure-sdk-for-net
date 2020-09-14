// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of HostPool definitions. </summary>
    public partial class HostPoolList
    {
        /// <summary> Initializes a new instance of HostPoolList. </summary>
        internal HostPoolList()
        {
            Value = new ChangeTrackingList<HostPool>();
        }

        /// <summary> Initializes a new instance of HostPoolList. </summary>
        /// <param name="value"> List of HostPool definitions. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal HostPoolList(IReadOnlyList<HostPool> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of HostPool definitions. </summary>
        public IReadOnlyList<HostPool> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
