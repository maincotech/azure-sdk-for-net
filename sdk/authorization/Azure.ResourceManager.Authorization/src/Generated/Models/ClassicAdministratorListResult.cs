// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> ClassicAdministrator list result information. </summary>
    public partial class ClassicAdministratorListResult
    {
        /// <summary> Initializes a new instance of ClassicAdministratorListResult. </summary>
        internal ClassicAdministratorListResult()
        {
            Value = new ChangeTrackingList<ClassicAdministrator>();
        }

        /// <summary> Initializes a new instance of ClassicAdministratorListResult. </summary>
        /// <param name="value"> An array of administrators. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ClassicAdministratorListResult(IReadOnlyList<ClassicAdministrator> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of administrators. </summary>
        public IReadOnlyList<ClassicAdministrator> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
