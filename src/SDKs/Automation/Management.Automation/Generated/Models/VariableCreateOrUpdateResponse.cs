// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the create or update variable operation.
    /// </summary>
    public partial class VariableCreateOrUpdateResponse : AzureOperationResponse
    {
        private Variable _variable;
        
        /// <summary>
        /// Optional. Gets or sets a variable.
        /// </summary>
        public Variable Variable
        {
            get { return this._variable; }
            set { this._variable = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VariableCreateOrUpdateResponse
        /// class.
        /// </summary>
        public VariableCreateOrUpdateResponse()
        {
        }
    }
}