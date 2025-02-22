// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Individual resource operation information. </summary>
    public partial class ResourceOperation
    {
        /// <summary> Initializes a new instance of ResourceOperation. </summary>
        internal ResourceOperation()
        {
        }

        /// <summary> Initializes a new instance of ResourceOperation. </summary>
        /// <param name="resourceName"> Name of the resource as specified in the artifacts. For ARM resources, this is the name of the resource specified in the template. </param>
        /// <param name="operationId"> Unique identifier of the operation. For ARM resources, this is the operationId obtained from ARM service. </param>
        /// <param name="resourceType"> Type of the resource as specified in the artifacts. For ARM resources, this is the type of the resource specified in the template. </param>
        /// <param name="provisioningState"> State of the resource deployment. For ARM resources, this is the current provisioning state of the resource. </param>
        /// <param name="statusMessage"> Descriptive information of the resource operation. </param>
        /// <param name="statusCode"> Http status code of the operation. </param>
        internal ResourceOperation(string resourceName, string operationId, string resourceType, string provisioningState, string statusMessage, string statusCode)
        {
            ResourceName = resourceName;
            OperationId = operationId;
            ResourceType = resourceType;
            ProvisioningState = provisioningState;
            StatusMessage = statusMessage;
            StatusCode = statusCode;
        }

        /// <summary> Name of the resource as specified in the artifacts. For ARM resources, this is the name of the resource specified in the template. </summary>
        public string ResourceName { get; }
        /// <summary> Unique identifier of the operation. For ARM resources, this is the operationId obtained from ARM service. </summary>
        public string OperationId { get; }
        /// <summary> Type of the resource as specified in the artifacts. For ARM resources, this is the type of the resource specified in the template. </summary>
        public string ResourceType { get; }
        /// <summary> State of the resource deployment. For ARM resources, this is the current provisioning state of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> Descriptive information of the resource operation. </summary>
        public string StatusMessage { get; }
        /// <summary> Http status code of the operation. </summary>
        public string StatusCode { get; }
    }
}
