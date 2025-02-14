// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the domain to create.</summary>
    public partial class RouteUpdatePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteUpdatePropertiesParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteUpdatePropertiesParametersInternal
    {

        /// <summary>Backing field for <see cref="CacheConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfiguration _cacheConfiguration;

        /// <summary>
        /// The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfiguration CacheConfiguration { get => (this._cacheConfiguration = this._cacheConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.AfdRouteCacheConfiguration()); set => this._cacheConfiguration = value; }

        /// <summary>query parameters to include or exclude (comma separated).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string CacheConfigurationQueryParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).QueryParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).QueryParameter = value ?? null; }

        /// <summary>
        /// Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore
        /// specific query strings, cache every request with a unique URL, or cache specific query strings.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdQueryStringCachingBehavior? CacheConfigurationQueryStringCachingBehavior { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).QueryStringCachingBehavior; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).QueryStringCachingBehavior = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdQueryStringCachingBehavior)""); }

        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string[] CompressionSettingContentTypesToCompress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).CompressionSettingContentTypesToCompress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).CompressionSettingContentTypesToCompress = value ?? null /* arrayOf */; }

        /// <summary>
        /// Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled,
        /// content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor
        /// when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public bool? CompressionSettingIsCompressionEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).CompressionSettingIsCompressionEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).CompressionSettingIsCompressionEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="CustomDomain" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IActivatedResourceReference[] _customDomain;

        /// <summary>Domains referenced by this endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IActivatedResourceReference[] CustomDomain { get => this._customDomain; set => this._customDomain = value; }

        /// <summary>Backing field for <see cref="EnabledState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? _enabledState;

        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? EnabledState { get => this._enabledState; set => this._enabledState = value; }

        /// <summary>Backing field for <see cref="EndpointName" /> property.</summary>
        private string _endpointName;

        /// <summary>The name of the endpoint which holds the route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string EndpointName { get => this._endpointName; }

        /// <summary>Backing field for <see cref="ForwardingProtocol" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol? _forwardingProtocol;

        /// <summary>Protocol this rule will use when forwarding traffic to backends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol? ForwardingProtocol { get => this._forwardingProtocol; set => this._forwardingProtocol = value; }

        /// <summary>Backing field for <see cref="HttpsRedirect" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HttpsRedirect? _httpsRedirect;

        /// <summary>
        /// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and
        /// it will be the first rule that gets executed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HttpsRedirect? HttpsRedirect { get => this._httpsRedirect; set => this._httpsRedirect = value; }

        /// <summary>Backing field for <see cref="LinkToDefaultDomain" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LinkToDefaultDomain? _linkToDefaultDomain;

        /// <summary>whether this route will be linked to the default endpoint domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LinkToDefaultDomain? LinkToDefaultDomain { get => this._linkToDefaultDomain; set => this._linkToDefaultDomain = value; }

        /// <summary>Internal Acessors for CacheConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfiguration Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteUpdatePropertiesParametersInternal.CacheConfiguration { get => (this._cacheConfiguration = this._cacheConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.AfdRouteCacheConfiguration()); set { {_cacheConfiguration = value;} } }

        /// <summary>Internal Acessors for CacheConfigurationCompressionSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICompressionSettings Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteUpdatePropertiesParametersInternal.CacheConfigurationCompressionSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).CompressionSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfigurationInternal)CacheConfiguration).CompressionSetting = value; }

        /// <summary>Internal Acessors for EndpointName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteUpdatePropertiesParametersInternal.EndpointName { get => this._endpointName; set { {_endpointName = value;} } }

        /// <summary>Internal Acessors for OriginGroup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteUpdatePropertiesParametersInternal.OriginGroup { get => (this._originGroup = this._originGroup ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ResourceReference()); set { {_originGroup = value;} } }

        /// <summary>Backing field for <see cref="OriginGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference _originGroup;

        /// <summary>A reference to the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference OriginGroup { get => (this._originGroup = this._originGroup ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ResourceReference()); set => this._originGroup = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string OriginGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReferenceInternal)OriginGroup).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReferenceInternal)OriginGroup).Id = value ?? null; }

        /// <summary>Backing field for <see cref="OriginPath" /> property.</summary>
        private string _originPath;

        /// <summary>
        /// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string OriginPath { get => this._originPath; set => this._originPath = value; }

        /// <summary>Backing field for <see cref="PatternsToMatch" /> property.</summary>
        private string[] _patternsToMatch;

        /// <summary>The route patterns of the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string[] PatternsToMatch { get => this._patternsToMatch; set => this._patternsToMatch = value; }

        /// <summary>Backing field for <see cref="RuleSet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference[] _ruleSet;

        /// <summary>rule sets referenced by this endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference[] RuleSet { get => this._ruleSet; set => this._ruleSet = value; }

        /// <summary>Backing field for <see cref="SupportedProtocol" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdEndpointProtocols[] _supportedProtocol;

        /// <summary>List of supported protocols for this route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdEndpointProtocols[] SupportedProtocol { get => this._supportedProtocol; set => this._supportedProtocol = value; }

        /// <summary>Creates an new <see cref="RouteUpdatePropertiesParameters" /> instance.</summary>
        public RouteUpdatePropertiesParameters()
        {

        }
    }
    /// The JSON object that contains the properties of the domain to create.
    public partial interface IRouteUpdatePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>query parameters to include or exclude (comma separated).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"query parameters to include or exclude (comma separated).",
        SerializedName = @"queryParameters",
        PossibleTypes = new [] { typeof(string) })]
        string CacheConfigurationQueryParameter { get; set; }
        /// <summary>
        /// Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore
        /// specific query strings, cache every request with a unique URL, or cache specific query strings.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings.",
        SerializedName = @"queryStringCachingBehavior",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdQueryStringCachingBehavior) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdQueryStringCachingBehavior? CacheConfigurationQueryStringCachingBehavior { get; set; }
        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of content types on which compression applies. The value should be a valid MIME type.",
        SerializedName = @"contentTypesToCompress",
        PossibleTypes = new [] { typeof(string) })]
        string[] CompressionSettingContentTypesToCompress { get; set; }
        /// <summary>
        /// Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled,
        /// content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor
        /// when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB.",
        SerializedName = @"isCompressionEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CompressionSettingIsCompressionEnabled { get; set; }
        /// <summary>Domains referenced by this endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Domains referenced by this endpoint.",
        SerializedName = @"customDomains",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IActivatedResourceReference) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IActivatedResourceReference[] CustomDomain { get; set; }
        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'",
        SerializedName = @"enabledState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? EnabledState { get; set; }
        /// <summary>The name of the endpoint which holds the route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the endpoint which holds the route.",
        SerializedName = @"endpointName",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointName { get;  }
        /// <summary>Protocol this rule will use when forwarding traffic to backends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Protocol this rule will use when forwarding traffic to backends.",
        SerializedName = @"forwardingProtocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol? ForwardingProtocol { get; set; }
        /// <summary>
        /// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and
        /// it will be the first rule that gets executed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed.",
        SerializedName = @"httpsRedirect",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HttpsRedirect) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HttpsRedirect? HttpsRedirect { get; set; }
        /// <summary>whether this route will be linked to the default endpoint domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"whether this route will be linked to the default endpoint domain.",
        SerializedName = @"linkToDefaultDomain",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LinkToDefaultDomain) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LinkToDefaultDomain? LinkToDefaultDomain { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string OriginGroupId { get; set; }
        /// <summary>
        /// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.",
        SerializedName = @"originPath",
        PossibleTypes = new [] { typeof(string) })]
        string OriginPath { get; set; }
        /// <summary>The route patterns of the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The route patterns of the rule.",
        SerializedName = @"patternsToMatch",
        PossibleTypes = new [] { typeof(string) })]
        string[] PatternsToMatch { get; set; }
        /// <summary>rule sets referenced by this endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"rule sets referenced by this endpoint.",
        SerializedName = @"ruleSets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference[] RuleSet { get; set; }
        /// <summary>List of supported protocols for this route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of supported protocols for this route.",
        SerializedName = @"supportedProtocols",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdEndpointProtocols) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdEndpointProtocols[] SupportedProtocol { get; set; }

    }
    /// The JSON object that contains the properties of the domain to create.
    internal partial interface IRouteUpdatePropertiesParametersInternal

    {
        /// <summary>
        /// The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IAfdRouteCacheConfiguration CacheConfiguration { get; set; }
        /// <summary>compression settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICompressionSettings CacheConfigurationCompressionSetting { get; set; }
        /// <summary>query parameters to include or exclude (comma separated).</summary>
        string CacheConfigurationQueryParameter { get; set; }
        /// <summary>
        /// Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore
        /// specific query strings, cache every request with a unique URL, or cache specific query strings.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdQueryStringCachingBehavior? CacheConfigurationQueryStringCachingBehavior { get; set; }
        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        string[] CompressionSettingContentTypesToCompress { get; set; }
        /// <summary>
        /// Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled,
        /// content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor
        /// when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        bool? CompressionSettingIsCompressionEnabled { get; set; }
        /// <summary>Domains referenced by this endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IActivatedResourceReference[] CustomDomain { get; set; }
        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? EnabledState { get; set; }
        /// <summary>The name of the endpoint which holds the route.</summary>
        string EndpointName { get; set; }
        /// <summary>Protocol this rule will use when forwarding traffic to backends.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol? ForwardingProtocol { get; set; }
        /// <summary>
        /// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and
        /// it will be the first rule that gets executed.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HttpsRedirect? HttpsRedirect { get; set; }
        /// <summary>whether this route will be linked to the default endpoint domain.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LinkToDefaultDomain? LinkToDefaultDomain { get; set; }
        /// <summary>A reference to the origin group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference OriginGroup { get; set; }
        /// <summary>Resource ID.</summary>
        string OriginGroupId { get; set; }
        /// <summary>
        /// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        string OriginPath { get; set; }
        /// <summary>The route patterns of the rule.</summary>
        string[] PatternsToMatch { get; set; }
        /// <summary>rule sets referenced by this endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IResourceReference[] RuleSet { get; set; }
        /// <summary>List of supported protocols for this route.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdEndpointProtocols[] SupportedProtocol { get; set; }

    }
}