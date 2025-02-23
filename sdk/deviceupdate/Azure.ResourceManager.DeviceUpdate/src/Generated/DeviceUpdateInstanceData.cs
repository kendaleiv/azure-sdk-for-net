// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing the DeviceUpdateInstance data model. </summary>
    public partial class DeviceUpdateInstanceData : Models.TrackedResource
    {
        /// <summary> Initializes a new instance of DeviceUpdateInstanceData. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public DeviceUpdateInstanceData(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            IotHubs = new ChangeTrackingList<IotHubSettings>();
        }

        /// <summary> Initializes a new instance of DeviceUpdateInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="accountName"> Parent Device Update Account name which Instance belongs to. </param>
        /// <param name="iotHubs"> List of IoT Hubs associated with the account. </param>
        /// <param name="enableDiagnostics"> Enables or Disables the diagnostic logs collection. </param>
        /// <param name="diagnosticStorageProperties"> Customer-initiated diagnostic log collection storage properties. </param>
        internal DeviceUpdateInstanceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, string location, ProvisioningState? provisioningState, string accountName, IList<IotHubSettings> iotHubs, bool? enableDiagnostics, DiagnosticStorageProperties diagnosticStorageProperties) : base(id, name, type, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AccountName = accountName;
            IotHubs = iotHubs;
            EnableDiagnostics = enableDiagnostics;
            DiagnosticStorageProperties = diagnosticStorageProperties;
        }

        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Parent Device Update Account name which Instance belongs to. </summary>
        public string AccountName { get; }
        /// <summary> List of IoT Hubs associated with the account. </summary>
        public IList<IotHubSettings> IotHubs { get; }
        /// <summary> Enables or Disables the diagnostic logs collection. </summary>
        public bool? EnableDiagnostics { get; set; }
        /// <summary> Customer-initiated diagnostic log collection storage properties. </summary>
        public DiagnosticStorageProperties DiagnosticStorageProperties { get; set; }
    }
}
