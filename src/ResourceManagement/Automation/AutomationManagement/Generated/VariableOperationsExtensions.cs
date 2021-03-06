// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class VariableOperationsExtensions
    {
        /// <summary>
        /// Create a variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update variable
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update variable operation.
        /// </returns>
        public static VariableCreateOrUpdateResponse CreateOrUpdate(this IVariableOperations operations, string resourceGroupName, string automationAccount, VariableCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVariableOperations)s).CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update variable
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update variable operation.
        /// </returns>
        public static Task<VariableCreateOrUpdateResponse> CreateOrUpdateAsync(this IVariableOperations operations, string resourceGroupName, string automationAccount, VariableCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='variableName'>
        /// Required. The name of variable.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IVariableOperations operations, string resourceGroupName, string automationAccount, string variableName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVariableOperations)s).DeleteAsync(resourceGroupName, automationAccount, variableName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='variableName'>
        /// Required. The name of variable.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IVariableOperations operations, string resourceGroupName, string automationAccount, string variableName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccount, variableName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the variable identified by variable name.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='variableName'>
        /// Required. The name of variable.
        /// </param>
        /// <returns>
        /// The response model for the get variable operation.
        /// </returns>
        public static VariableGetResponse Get(this IVariableOperations operations, string resourceGroupName, string automationAccount, string variableName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVariableOperations)s).GetAsync(resourceGroupName, automationAccount, variableName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the variable identified by variable name.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='variableName'>
        /// Required. The name of variable.
        /// </param>
        /// <returns>
        /// The response model for the get variable operation.
        /// </returns>
        public static Task<VariableGetResponse> GetAsync(this IVariableOperations operations, string resourceGroupName, string automationAccount, string variableName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, variableName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list variables operation.
        /// </returns>
        public static VariableListResponse List(this IVariableOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVariableOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list variables operation.
        /// </returns>
        public static Task<VariableListResponse> ListAsync(this IVariableOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list variables operation.
        /// </returns>
        public static VariableListResponse ListNext(this IVariableOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVariableOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list variables operation.
        /// </returns>
        public static Task<VariableListResponse> ListNextAsync(this IVariableOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Update a variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the patch variable operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Patch(this IVariableOperations operations, string resourceGroupName, string automationAccount, VariablePatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVariableOperations)s).PatchAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update a variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IVariableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the patch variable operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> PatchAsync(this IVariableOperations operations, string resourceGroupName, string automationAccount, VariablePatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
    }
}
