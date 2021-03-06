// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure VM disk input details.
    /// </summary>
    public partial class A2AVmDiskInputDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AVmDiskInputDetails class.
        /// </summary>
        public A2AVmDiskInputDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AVmDiskInputDetails class.
        /// </summary>
        /// <param name="diskUri">The disk Uri.</param>
        /// <param name="recoveryAzureStorageAccountId">The recovery VHD
        /// storage account Id.</param>
        /// <param name="primaryStagingAzureStorageAccountId">The primary
        /// staging storage account Id.</param>
        public A2AVmDiskInputDetails(string diskUri = default(string), string recoveryAzureStorageAccountId = default(string), string primaryStagingAzureStorageAccountId = default(string))
        {
            DiskUri = diskUri;
            RecoveryAzureStorageAccountId = recoveryAzureStorageAccountId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk Uri.
        /// </summary>
        [JsonProperty(PropertyName = "diskUri")]
        public string DiskUri { get; set; }

        /// <summary>
        /// Gets or sets the recovery VHD storage account Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureStorageAccountId")]
        public string RecoveryAzureStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the primary staging storage account Id.
        /// </summary>
        [JsonProperty(PropertyName = "primaryStagingAzureStorageAccountId")]
        public string PrimaryStagingAzureStorageAccountId { get; set; }

    }
}
