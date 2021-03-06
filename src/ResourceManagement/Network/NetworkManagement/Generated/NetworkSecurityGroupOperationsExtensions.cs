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
    public static partial class NetworkSecurityGroupOperationsExtensions
    {
        /// <summary>
        /// The Put NetworkSecurityGroup operation creates/updates a network
        /// security groupin the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Network Security
        /// Group operation
        /// </param>
        /// <returns>
        /// Response for PUT NetworkSecurityGroups Api servive call
        /// </returns>
        public static NetworkSecurityGroupPutResponse BeginCreateOrUpdating(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkSecurityGroupOperations)s).BeginCreateOrUpdatingAsync(resourceGroupName, networkSecurityGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put NetworkSecurityGroup operation creates/updates a network
        /// security groupin the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Network Security
        /// Group operation
        /// </param>
        /// <returns>
        /// Response for PUT NetworkSecurityGroups Api servive call
        /// </returns>
        public static Task<NetworkSecurityGroupPutResponse> BeginCreateOrUpdatingAsync(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters)
        {
            return operations.BeginCreateOrUpdatingAsync(resourceGroupName, networkSecurityGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete NetworkSecurityGroup operation deletes the specifed
        /// network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static UpdateOperationResponse BeginDeleting(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkSecurityGroupOperations)s).BeginDeletingAsync(resourceGroupName, networkSecurityGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete NetworkSecurityGroup operation deletes the specifed
        /// network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static Task<UpdateOperationResponse> BeginDeletingAsync(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, networkSecurityGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Put NetworkSecurityGroup operation creates/updates a network
        /// security groupin the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Network Security
        /// Group operation
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
        public static AzureAsyncOperationResponse CreateOrUpdate(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkSecurityGroupOperations)s).CreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put NetworkSecurityGroup operation creates/updates a network
        /// security groupin the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update Network Security
        /// Group operation
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
        public static Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete NetworkSecurityGroup operation deletes the specifed
        /// network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkSecurityGroupOperations)s).DeleteAsync(resourceGroupName, networkSecurityGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete NetworkSecurityGroup operation deletes the specifed
        /// network security group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return operations.DeleteAsync(resourceGroupName, networkSecurityGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get NetworkSecurityGroups operation retrieves information about
        /// the specified network security group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// Response for GetNetworkSecurityGroup Api service call
        /// </returns>
        public static NetworkSecurityGroupGetResponse Get(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkSecurityGroupOperations)s).GetAsync(resourceGroupName, networkSecurityGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get NetworkSecurityGroups operation retrieves information about
        /// the specified network security group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// Required. The name of the network security group.
        /// </param>
        /// <returns>
        /// Response for GetNetworkSecurityGroup Api service call
        /// </returns>
        public static Task<NetworkSecurityGroupGetResponse> GetAsync(this INetworkSecurityGroupOperations operations, string resourceGroupName, string networkSecurityGroupName)
        {
            return operations.GetAsync(resourceGroupName, networkSecurityGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The list NetworkSecurityGroups returns all network security groups
        /// in a resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListNetworkSecurityGroups Api servive call
        /// </returns>
        public static NetworkSecurityGroupListResponse List(this INetworkSecurityGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkSecurityGroupOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The list NetworkSecurityGroups returns all network security groups
        /// in a resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListNetworkSecurityGroups Api servive call
        /// </returns>
        public static Task<NetworkSecurityGroupListResponse> ListAsync(this INetworkSecurityGroupOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The list NetworkSecurityGroups returns all network security groups
        /// in a subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <returns>
        /// Response for ListNetworkSecurityGroups Api servive call
        /// </returns>
        public static NetworkSecurityGroupListResponse ListAll(this INetworkSecurityGroupOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkSecurityGroupOperations)s).ListAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The list NetworkSecurityGroups returns all network security groups
        /// in a subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkSecurityGroupOperations.
        /// </param>
        /// <returns>
        /// Response for ListNetworkSecurityGroups Api servive call
        /// </returns>
        public static Task<NetworkSecurityGroupListResponse> ListAllAsync(this INetworkSecurityGroupOperations operations)
        {
            return operations.ListAllAsync(CancellationToken.None);
        }
    }
}
