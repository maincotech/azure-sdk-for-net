// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents a HostPool definition. </summary>
    public partial class HostPool : TrackedResource
    {
        /// <summary> Initializes a new instance of HostPool. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="hostPoolType"> HostPool type for desktop. </param>
        /// <param name="loadBalancerType"> The type of the load balancer. </param>
        /// <param name="preferredAppGroupType"> The type of preferred application group type, default to Desktop Application Group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public HostPool(string location, HostPoolType hostPoolType, LoadBalancerType loadBalancerType, PreferredAppGroupType preferredAppGroupType) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            HostPoolType = hostPoolType;
            LoadBalancerType = loadBalancerType;
            ApplicationGroupReferences = new ChangeTrackingList<string>();
            PreferredAppGroupType = preferredAppGroupType;
        }

        /// <summary> Initializes a new instance of HostPool. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="friendlyName"> Friendly name of HostPool. </param>
        /// <param name="description"> Description of HostPool. </param>
        /// <param name="hostPoolType"> HostPool type for desktop. </param>
        /// <param name="personalDesktopAssignmentType"> PersonalDesktopAssignment type for HostPool. </param>
        /// <param name="customRdpProperty"> Custom rdp property of HostPool. </param>
        /// <param name="maxSessionLimit"> The max session limit of HostPool. </param>
        /// <param name="loadBalancerType"> The type of the load balancer. </param>
        /// <param name="ring"> The ring number of HostPool. </param>
        /// <param name="validationEnvironment"> Is validation environment. </param>
        /// <param name="registrationInfo"> The registration info of HostPool. </param>
        /// <param name="vmTemplate"> VM template for sessionhosts configuration within hostpool. </param>
        /// <param name="applicationGroupReferences"> List of applicationGroup links. </param>
        /// <param name="ssoContext"> Path to keyvault containing ssoContext secret. </param>
        /// <param name="preferredAppGroupType"> The type of preferred application group type, default to Desktop Application Group. </param>
        internal HostPool(string id, string name, string type, IDictionary<string, string> tags, string location, string friendlyName, string description, HostPoolType hostPoolType, PersonalDesktopAssignmentType? personalDesktopAssignmentType, string customRdpProperty, int? maxSessionLimit, LoadBalancerType loadBalancerType, int? ring, bool? validationEnvironment, RegistrationInfo registrationInfo, string vmTemplate, IReadOnlyList<string> applicationGroupReferences, string ssoContext, PreferredAppGroupType preferredAppGroupType) : base(id, name, type, tags, location)
        {
            FriendlyName = friendlyName;
            Description = description;
            HostPoolType = hostPoolType;
            PersonalDesktopAssignmentType = personalDesktopAssignmentType;
            CustomRdpProperty = customRdpProperty;
            MaxSessionLimit = maxSessionLimit;
            LoadBalancerType = loadBalancerType;
            Ring = ring;
            ValidationEnvironment = validationEnvironment;
            RegistrationInfo = registrationInfo;
            VmTemplate = vmTemplate;
            ApplicationGroupReferences = applicationGroupReferences;
            SsoContext = ssoContext;
            PreferredAppGroupType = preferredAppGroupType;
        }

        /// <summary> Friendly name of HostPool. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Description of HostPool. </summary>
        public string Description { get; set; }
        /// <summary> HostPool type for desktop. </summary>
        public HostPoolType HostPoolType { get; set; }
        /// <summary> PersonalDesktopAssignment type for HostPool. </summary>
        public PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get; set; }
        /// <summary> Custom rdp property of HostPool. </summary>
        public string CustomRdpProperty { get; set; }
        /// <summary> The max session limit of HostPool. </summary>
        public int? MaxSessionLimit { get; set; }
        /// <summary> The type of the load balancer. </summary>
        public LoadBalancerType LoadBalancerType { get; set; }
        /// <summary> The ring number of HostPool. </summary>
        public int? Ring { get; set; }
        /// <summary> Is validation environment. </summary>
        public bool? ValidationEnvironment { get; set; }
        /// <summary> The registration info of HostPool. </summary>
        public RegistrationInfo RegistrationInfo { get; set; }
        /// <summary> VM template for sessionhosts configuration within hostpool. </summary>
        public string VmTemplate { get; set; }
        /// <summary> List of applicationGroup links. </summary>
        public IReadOnlyList<string> ApplicationGroupReferences { get; }
        /// <summary> Path to keyvault containing ssoContext secret. </summary>
        public string SsoContext { get; set; }
        /// <summary> The type of preferred application group type, default to Desktop Application Group. </summary>
        public PreferredAppGroupType PreferredAppGroupType { get; set; }
    }
}
