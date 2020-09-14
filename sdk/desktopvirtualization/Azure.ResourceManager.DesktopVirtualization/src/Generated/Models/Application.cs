// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Schema for Application properties. </summary>
    public partial class Application : Resource
    {
        /// <summary> Initializes a new instance of Application. </summary>
        /// <param name="commandLineSetting"> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </param>
        public Application(CommandLineSetting commandLineSetting)
        {
            CommandLineSetting = commandLineSetting;
        }

        /// <summary> Initializes a new instance of Application. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="description"> Description of Application. </param>
        /// <param name="friendlyName"> Friendly name of Application. </param>
        /// <param name="filePath"> Specifies a path for the executable file for the application. </param>
        /// <param name="commandLineSetting"> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </param>
        /// <param name="commandLineArguments"> Command Line Arguments for Application. </param>
        /// <param name="showInPortal"> Specifies whether to show the RemoteApp program in the RD Web Access server. </param>
        /// <param name="iconPath"> Path to icon. </param>
        /// <param name="iconIndex"> Index of the icon. </param>
        /// <param name="iconHash"> Hash of the icon. </param>
        /// <param name="iconContent"> the icon a 64 bit string as a byte array. </param>
        internal Application(string id, string name, string type, string description, string friendlyName, string filePath, CommandLineSetting commandLineSetting, string commandLineArguments, bool? showInPortal, string iconPath, int? iconIndex, string iconHash, byte[] iconContent) : base(id, name, type)
        {
            Description = description;
            FriendlyName = friendlyName;
            FilePath = filePath;
            CommandLineSetting = commandLineSetting;
            CommandLineArguments = commandLineArguments;
            ShowInPortal = showInPortal;
            IconPath = iconPath;
            IconIndex = iconIndex;
            IconHash = iconHash;
            IconContent = iconContent;
        }

        /// <summary> Description of Application. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Application. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Specifies a path for the executable file for the application. </summary>
        public string FilePath { get; set; }
        /// <summary> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </summary>
        public CommandLineSetting CommandLineSetting { get; set; }
        /// <summary> Command Line Arguments for Application. </summary>
        public string CommandLineArguments { get; set; }
        /// <summary> Specifies whether to show the RemoteApp program in the RD Web Access server. </summary>
        public bool? ShowInPortal { get; set; }
        /// <summary> Path to icon. </summary>
        public string IconPath { get; set; }
        /// <summary> Index of the icon. </summary>
        public int? IconIndex { get; set; }
        /// <summary> Hash of the icon. </summary>
        public string IconHash { get; }
        /// <summary> the icon a 64 bit string as a byte array. </summary>
        public byte[] IconContent { get; }
    }
}
