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
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Windows Azure Network management API provides a RESTful set of web
    /// services that interact with Windows Azure Networks service to manage
    /// your network resrources. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Networks
    /// service.
    /// </summary>
    public static partial class SecurityRuleOperationsExtensions
    {
        /// <summary>
        /// The Put network security rule operation creates/updates a security
        /// rule in the specified network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <param name='securityRuleParameters'>
        /// Required. Parameters supplied to the create/update network security
        /// rule operation
        /// </param>
        /// <returns>
        /// Response for PUT SecurityRule Api service call
        /// </returns>
        public static SecurityRulePutResponse BeginCreateOrUpdating(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityRuleOperations)s).BeginCreateOrUpdatingAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put network security rule operation creates/updates a security
        /// rule in the specified network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <param name='securityRuleParameters'>
        /// Required. Parameters supplied to the create/update network security
        /// rule operation
        /// </param>
        /// <returns>
        /// Response for PUT SecurityRule Api service call
        /// </returns>
        public static Task<SecurityRulePutResponse> BeginCreateOrUpdatingAsync(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
        {
            return operations.BeginCreateOrUpdatingAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The delete network security rule operation deletes the specified
        /// network security rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static UpdateOperationResponse BeginDeleting(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityRuleOperations)s).BeginDeletingAsync(resourceGroupName, networkSecurityGroupName, securityRuleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The delete network security rule operation deletes the specified
        /// network security rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static Task<UpdateOperationResponse> BeginDeletingAsync(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Put network security rule operation creates/updates a security
        /// rule in the specified network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <param name='securityRuleParameters'>
        /// Required. Parameters supplied to the create/update network security
        /// rule operation
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static AzureAsyncOperationResponse CreateOrUpdate(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityRuleOperations)s).CreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put network security rule operation creates/updates a security
        /// rule in the specified network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <param name='securityRuleParameters'>
        /// Required. Parameters supplied to the create/update network security
        /// rule operation
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The delete network security rule operation deletes the specified
        /// network security rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityRuleOperations)s).DeleteAsync(resourceGroupName, networkSecurityGroupName, securityRuleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The delete network security rule operation deletes the specified
        /// network security rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
        {
            return operations.DeleteAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get NetworkSecurityRule operation retreives information about
        /// the specified network security rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <returns>
        /// Response for GetSecurityRule Api service call
        /// </returns>
        public static SecurityRuleGetResponse Get(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityRuleOperations)s).GetAsync(resourceGroupName, networkSecurityGroupName, securityRuleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get NetworkSecurityRule operation retreives information about
        /// the specified network security rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// Required. The name of the security rule.
        /// </param>
        /// <returns>
        /// Response for GetSecurityRule Api service call
        /// </returns>
        public static Task<SecurityRuleGetResponse> GetAsync(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
        {
            return operations.GetAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List network security rule opertion retrieves all the security
        /// rules in a network security group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// Response for ListSecurityRule Api service callRetrieves all
        /// security rules that belongs to a network security group
        /// </returns>
        public static SecurityRuleListResponse List(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityRuleOperations)s).ListAsync(resourceGroupName, networkSecurityGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List network security rule opertion retrieves all the security
        /// rules in a network security group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.ISecurityRuleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// Response for ListSecurityRule Api service callRetrieves all
        /// security rules that belongs to a network security group
        /// </returns>
        public static Task<SecurityRuleListResponse> ListAsync(this ISecurityRuleOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return operations.ListAsync(resourceGroupName, networkSecurityGroupName, CancellationToken.None);
        }
    }
}
