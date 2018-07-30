// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IP configuration of an Azure Firewall.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AzureFirewallIPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewallIPConfiguration
        /// class.
        /// </summary>
        public AzureFirewallIPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewallIPConfiguration
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="privateIPAddress">The Firewall Internal Load Balancer
        /// IP to be used as the next hop in User Defined Routes.</param>
        /// <param name="subnet">Reference of the subnet resource. This
        /// resource must be named 'AzureFirewallSubnet'.</param>
        /// <param name="internalPublicIpAddress">Reference of the PublicIP
        /// resource. This field is a mandatory input.</param>
        /// <param name="publicIPAddress">Reference of the PublicIP resource.
        /// This field is populated in the output.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public AzureFirewallIPConfiguration(string id = default(string), string privateIPAddress = default(string), SubResource subnet = default(SubResource), SubResource internalPublicIpAddress = default(SubResource), SubResource publicIPAddress = default(SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PrivateIPAddress = privateIPAddress;
            Subnet = subnet;
            InternalPublicIpAddress = internalPublicIpAddress;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Firewall Internal Load Balancer IP to be used as
        /// the next hop in User Defined Routes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets reference of the subnet resource. This resource must
        /// be named 'AzureFirewallSubnet'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets reference of the PublicIP resource. This field is a
        /// mandatory input.
        /// </summary>
        [JsonProperty(PropertyName = "properties.internalPublicIpAddress")]
        public SubResource InternalPublicIpAddress { get; set; }

        /// <summary>
        /// Gets or sets reference of the PublicIP resource. This field is
        /// populated in the output.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
