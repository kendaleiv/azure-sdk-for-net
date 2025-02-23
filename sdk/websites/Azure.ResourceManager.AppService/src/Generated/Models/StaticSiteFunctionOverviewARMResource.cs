// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static Site Function Overview ARM resource. </summary>
    public partial class StaticSiteFunctionOverviewARMResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StaticSiteFunctionOverviewARMResource. </summary>
        public StaticSiteFunctionOverviewARMResource()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteFunctionOverviewARMResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="functionName"> The name for the function. </param>
        /// <param name="triggerType"> The trigger type of the function. </param>
        internal StaticSiteFunctionOverviewARMResource(ResourceIdentifier id, string name, ResourceType type, string kind, string functionName, TriggerTypes? triggerType) : base(id, name, type, kind)
        {
            FunctionName = functionName;
            TriggerType = triggerType;
        }

        /// <summary> The name for the function. </summary>
        public string FunctionName { get; }
        /// <summary> The trigger type of the function. </summary>
        public TriggerTypes? TriggerType { get; }
    }
}
