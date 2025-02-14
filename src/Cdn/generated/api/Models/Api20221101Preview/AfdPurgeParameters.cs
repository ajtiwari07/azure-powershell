// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Parameters required for content purge.</summary>
    public partial class AfdPurgeParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdPurgeParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdPurgeParametersInternal
    {

        /// <summary>Backing field for <see cref="ContentPath" /> property.</summary>
        private string[] _contentPath;

        /// <summary>
        /// The path to the content to be purged. Can describe a file path or a wild card directory.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string[] ContentPath { get => this._contentPath; set => this._contentPath = value; }

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string[] _domain;

        /// <summary>List of domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string[] Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Creates an new <see cref="AfdPurgeParameters" /> instance.</summary>
        public AfdPurgeParameters()
        {

        }
    }
    /// Parameters required for content purge.
    public partial interface IAfdPurgeParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The path to the content to be purged. Can describe a file path or a wild card directory.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The path to the content to be purged. Can describe a file path or a wild card directory.",
        SerializedName = @"contentPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] ContentPath { get; set; }
        /// <summary>List of domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of domains.",
        SerializedName = @"domains",
        PossibleTypes = new [] { typeof(string) })]
        string[] Domain { get; set; }

    }
    /// Parameters required for content purge.
    internal partial interface IAfdPurgeParametersInternal

    {
        /// <summary>
        /// The path to the content to be purged. Can describe a file path or a wild card directory.
        /// </summary>
        string[] ContentPath { get; set; }
        /// <summary>List of domains.</summary>
        string[] Domain { get; set; }

    }
}