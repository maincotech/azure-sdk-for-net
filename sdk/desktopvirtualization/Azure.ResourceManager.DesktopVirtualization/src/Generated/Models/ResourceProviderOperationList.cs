// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Result of the request to list operations. </summary>
    public partial class ResourceProviderOperationList
    {
        /// <summary> Initializes a new instance of ResourceProviderOperationList. </summary>
        internal ResourceProviderOperationList()
        {
            Value = new ChangeTrackingList<ResourceProviderOperation>();
        }

        /// <summary> Initializes a new instance of ResourceProviderOperationList. </summary>
        /// <param name="value"> List of operations supported by this resource provider. </param>
        internal ResourceProviderOperationList(IReadOnlyList<ResourceProviderOperation> value)
        {
            Value = value;
        }

        /// <summary> List of operations supported by this resource provider. </summary>
        public IReadOnlyList<ResourceProviderOperation> Value { get; }
    }
}
