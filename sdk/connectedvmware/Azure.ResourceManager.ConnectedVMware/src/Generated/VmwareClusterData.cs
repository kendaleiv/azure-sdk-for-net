// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMware.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMware
{
    /// <summary> A class representing the VmwareCluster data model. </summary>
    public partial class VmwareClusterData : TrackedResource
    {
        /// <summary> Initializes a new instance of VmwareClusterData. </summary>
        /// <param name="location"> The location. </param>
        public VmwareClusterData(Location location) : base(location)
        {
            Statuses = new ChangeTrackingList<ResourceStatus>();
            DatastoreIds = new ChangeTrackingList<string>();
            NetworkIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VmwareClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="systemData"> The system data. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this cluster resides. </param>
        /// <param name="moRefId"> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the cluster. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the cluster. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the cluster. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="datastoreIds"> Gets or sets the datastore ARM ids. </param>
        /// <param name="networkIds"> Gets or sets the network ARM ids. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal VmwareClusterData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, CheckNameAvailabilityRequest extendedLocation, SystemData systemData, string kind, string uuid, string vCenterId, string moRefId, string inventoryItemId, string moName, IReadOnlyList<ResourceStatus> statuses, string customResourceName, IReadOnlyList<string> datastoreIds, IReadOnlyList<string> networkIds, string provisioningState) : base(id, name, type, tags, location)
        {
            ExtendedLocation = extendedLocation;
            SystemData = systemData;
            Kind = kind;
            Uuid = uuid;
            VCenterId = vCenterId;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            Statuses = statuses;
            CustomResourceName = customResourceName;
            DatastoreIds = datastoreIds;
            NetworkIds = networkIds;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the extended location. </summary>
        public CheckNameAvailabilityRequest ExtendedLocation { get; set; }
        /// <summary> The system data. </summary>
        public SystemData SystemData { get; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this cluster resides. </summary>
        public string VCenterId { get; set; }
        /// <summary> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the cluster. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the cluster. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the cluster. </summary>
        public string MoName { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Gets or sets the datastore ARM ids. </summary>
        public IReadOnlyList<string> DatastoreIds { get; }
        /// <summary> Gets or sets the network ARM ids. </summary>
        public IReadOnlyList<string> NetworkIds { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
