// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role assignment create parameters. </summary>
    public partial class RoleAssignmentCreateParameters
    {
        /// <summary> Initializes a new instance of RoleAssignmentCreateParameters. </summary>
        /// <param name="properties"> Role assignment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RoleAssignmentCreateParameters(RoleAssignmentProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Role assignment properties. </summary>
        public RoleAssignmentProperties Properties { get; }
    }
}
