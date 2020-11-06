// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Extra Operation properties. </summary>
    public partial class OperationProperties
    {
        /// <summary> Initializes a new instance of OperationProperties. </summary>
        internal OperationProperties()
        {
        }

        /// <summary> Initializes a new instance of OperationProperties. </summary>
        /// <param name="serviceSpecification"> The service specifications. </param>
        internal OperationProperties(ServiceSpecification serviceSpecification)
        {
            ServiceSpecification = serviceSpecification;
        }

        /// <summary> The service specifications. </summary>
        public ServiceSpecification ServiceSpecification { get; }
    }
}
