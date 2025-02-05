// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the properties of an existing Private Endpoint connection to
    /// the Azure Cognitive Search service.
    /// </summary>
    public partial class PrivateEndpointConnectionProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionProperties class.
        /// </summary>
        public PrivateEndpointConnectionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionProperties class.
        /// </summary>
        /// <param name="privateEndpoint">The private endpoint resource from
        /// Microsoft.Network provider.</param>
        /// <param name="privateLinkServiceConnectionState">Describes the
        /// current state of an existing Private Link Service connection to the
        /// Azure Private Endpoint.</param>
        /// <param name="groupId">The group id from the provider of resource
        /// the private link service connection is for.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// private link service connection. Can be Updating, Deleting, Failed,
        /// Succeeded, or Incomplete. Possible values include: 'Updating',
        /// 'Deleting', 'Failed', 'Succeeded', 'Incomplete', 'Canceled'</param>
        public PrivateEndpointConnectionProperties(PrivateEndpointConnectionPropertiesPrivateEndpoint privateEndpoint = default(PrivateEndpointConnectionPropertiesPrivateEndpoint), PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionState), string groupId = default(string), string provisioningState = default(string))
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            GroupId = groupId;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the private endpoint resource from Microsoft.Network
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "privateEndpoint")]
        public PrivateEndpointConnectionPropertiesPrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Gets or sets describes the current state of an existing Private
        /// Link Service connection to the Azure Private Endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkServiceConnectionState")]
        public PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Gets or sets the group id from the provider of resource the private
        /// link service connection is for.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the private link service
        /// connection. Can be Updating, Deleting, Failed, Succeeded, or
        /// Incomplete. Possible values include: 'Updating', 'Deleting',
        /// 'Failed', 'Succeeded', 'Incomplete', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
