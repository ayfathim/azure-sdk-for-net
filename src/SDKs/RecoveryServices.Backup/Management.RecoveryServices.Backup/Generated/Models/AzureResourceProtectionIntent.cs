// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IaaS VM specific backup protection intent item.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureResourceItem")]
    public partial class AzureResourceProtectionIntent : ProtectionIntent
    {
        /// <summary>
        /// Initializes a new instance of the AzureResourceProtectionIntent
        /// class.
        /// </summary>
        public AzureResourceProtectionIntent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureResourceProtectionIntent
        /// class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the backed up item. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="sourceResourceId">ARM ID of the resource to be backed
        /// up.</param>
        /// <param name="itemId">ID of the item which is getting protected, In
        /// case of Azure Vm , it is ProtectedItemId</param>
        /// <param name="policyId">ID of the backup policy with which this item
        /// is backed up.</param>
        /// <param name="protectionState">Backup state of this backup item.
        /// Possible values include: 'Invalid', 'NotProtected', 'Protecting',
        /// 'Protected', 'ProtectionFailed'</param>
        /// <param name="friendlyName">Friendly name of the VM represented by
        /// this backup item.</param>
        public AzureResourceProtectionIntent(string backupManagementType = default(string), string sourceResourceId = default(string), string itemId = default(string), string policyId = default(string), string protectionState = default(string), string friendlyName = default(string))
            : base(backupManagementType, sourceResourceId, itemId, policyId, protectionState)
        {
            FriendlyName = friendlyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the VM represented by this backup
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

    }
}
