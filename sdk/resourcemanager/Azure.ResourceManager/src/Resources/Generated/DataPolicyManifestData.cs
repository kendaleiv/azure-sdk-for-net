// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the DataPolicyManifest data model. </summary>
    public partial class DataPolicyManifestData : Resource
    {
        /// <summary> Initializes a new instance of DataPolicyManifestData. </summary>
        internal DataPolicyManifestData()
        {
            Namespaces = new ChangeTrackingList<string>();
            ResourceTypeAliases = new ChangeTrackingList<ResourceTypeAliases>();
            Effects = new ChangeTrackingList<DataEffect>();
            FieldValues = new ChangeTrackingList<string>();
            Standard = new ChangeTrackingList<string>();
            Custom = new ChangeTrackingList<DataManifestCustomResourceFunctionDefinition>();
        }

        /// <summary> Initializes a new instance of DataPolicyManifestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="namespaces"> The list of namespaces for the data policy manifest. </param>
        /// <param name="policyMode"> The policy mode of the data policy manifest. </param>
        /// <param name="isBuiltInOnly"> A value indicating whether policy mode is allowed only in built-in definitions. </param>
        /// <param name="resourceTypeAliases"> An array of resource type aliases. </param>
        /// <param name="effects"> The effect definition. </param>
        /// <param name="fieldValues"> The non-alias field accessor values that can be used in the policy rule. </param>
        /// <param name="standard"> The standard resource functions (subscription and/or resourceGroup). </param>
        /// <param name="custom"> An array of data manifest custom resource definition. </param>
        internal DataPolicyManifestData(ResourceIdentifier id, string name, ResourceType type, IReadOnlyList<string> namespaces, string policyMode, bool? isBuiltInOnly, IReadOnlyList<ResourceTypeAliases> resourceTypeAliases, IReadOnlyList<DataEffect> effects, IReadOnlyList<string> fieldValues, IReadOnlyList<string> standard, IReadOnlyList<DataManifestCustomResourceFunctionDefinition> custom) : base(id, name, type)
        {
            Namespaces = namespaces;
            PolicyMode = policyMode;
            IsBuiltInOnly = isBuiltInOnly;
            ResourceTypeAliases = resourceTypeAliases;
            Effects = effects;
            FieldValues = fieldValues;
            Standard = standard;
            Custom = custom;
        }

        /// <summary> The list of namespaces for the data policy manifest. </summary>
        public IReadOnlyList<string> Namespaces { get; }
        /// <summary> The policy mode of the data policy manifest. </summary>
        public string PolicyMode { get; }
        /// <summary> A value indicating whether policy mode is allowed only in built-in definitions. </summary>
        public bool? IsBuiltInOnly { get; }
        /// <summary> An array of resource type aliases. </summary>
        public IReadOnlyList<ResourceTypeAliases> ResourceTypeAliases { get; }
        /// <summary> The effect definition. </summary>
        public IReadOnlyList<DataEffect> Effects { get; }
        /// <summary> The non-alias field accessor values that can be used in the policy rule. </summary>
        public IReadOnlyList<string> FieldValues { get; }
        /// <summary> The standard resource functions (subscription and/or resourceGroup). </summary>
        public IReadOnlyList<string> Standard { get; }
        /// <summary> An array of data manifest custom resource definition. </summary>
        public IReadOnlyList<DataManifestCustomResourceFunctionDefinition> Custom { get; }
    }
}
