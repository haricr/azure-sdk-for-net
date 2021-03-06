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
    public static partial class TestJobOperationsExtensions
    {
        /// <summary>
        /// Create a test job of the runbook.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create test job operation.
        /// </param>
        /// <returns>
        /// The response model for the create test job operation.
        /// </returns>
        public static TestJobCreateResponse Create(this ITestJobOperations operations, string resourceGroupName, string automationAccount, TestJobCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITestJobOperations)s).CreateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a test job of the runbook.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create test job operation.
        /// </param>
        /// <returns>
        /// The response model for the create test job operation.
        /// </returns>
        public static Task<TestJobCreateResponse> CreateAsync(this ITestJobOperations operations, string resourceGroupName, string automationAccount, TestJobCreateParameters parameters)
        {
            return operations.CreateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the test job for the specified runbook.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get test job operation.
        /// </returns>
        public static TestJobGetResponse Get(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITestJobOperations)s).GetAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the test job for the specified runbook.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get test job operation.
        /// </returns>
        public static Task<TestJobGetResponse> GetAsync(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Resume the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Resume(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITestJobOperations)s).ResumeAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Resume the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> ResumeAsync(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.ResumeAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Stop the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Stop(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITestJobOperations)s).StopAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Stop the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> StopAsync(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.StopAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Suspend the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Suspend(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITestJobOperations)s).SuspendAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Suspend the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ITestJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> SuspendAsync(this ITestJobOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.SuspendAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
    }
}
