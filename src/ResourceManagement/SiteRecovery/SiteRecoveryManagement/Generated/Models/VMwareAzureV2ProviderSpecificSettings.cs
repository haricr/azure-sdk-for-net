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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// VMware Azure Provider specific entity details.
    /// </summary>
    public partial class VMwareAzureV2ProviderSpecificSettings : ReplicationProviderSpecificSettings
    {
        private string _agentVersion;
        
        /// <summary>
        /// Optional. Agent version.
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }
        
        private double _compressedDataRateInMB;
        
        /// <summary>
        /// Optional. Compressed data change rate in MB.
        /// </summary>
        public double CompressedDataRateInMB
        {
            get { return this._compressedDataRateInMB; }
            set { this._compressedDataRateInMB = value; }
        }
        
        private string _healthErrorCode;
        
        /// <summary>
        /// Optional. Health error code.
        /// </summary>
        public string HealthErrorCode
        {
            get { return this._healthErrorCode; }
            set { this._healthErrorCode = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. Source IP address.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private bool _isAgentUpdateRequired;
        
        /// <summary>
        /// Optional. Value indicating whether installed agent needs to be
        /// updated.
        /// </summary>
        public bool IsAgentUpdateRequired
        {
            get { return this._isAgentUpdateRequired; }
            set { this._isAgentUpdateRequired = value; }
        }
        
        private bool _isRebootAfterUpdateRequired;
        
        /// <summary>
        /// Optional. Value indicating whether the source server requires a
        /// restart after update.
        /// </summary>
        public bool IsRebootAfterUpdateRequired
        {
            get { return this._isRebootAfterUpdateRequired; }
            set { this._isRebootAfterUpdateRequired = value; }
        }
        
        private System.DateTime? _lastHeartbeat;
        
        /// <summary>
        /// Optional. Last heartbeat received from the source server.
        /// </summary>
        public System.DateTime? LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
        }
        
        private string _latestUpdateVersion;
        
        /// <summary>
        /// Optional. Latest update version.
        /// </summary>
        public string LatestUpdateVersion
        {
            get { return this._latestUpdateVersion; }
            set { this._latestUpdateVersion = value; }
        }
        
        private string _masterTargetId;
        
        /// <summary>
        /// Optional. Master target Id.
        /// </summary>
        public string MasterTargetId
        {
            get { return this._masterTargetId; }
            set { this._masterTargetId = value; }
        }
        
        private string _multiVmGroupId;
        
        /// <summary>
        /// Optional. Multi vm group Id.
        /// </summary>
        public string MultiVmGroupId
        {
            get { return this._multiVmGroupId; }
            set { this._multiVmGroupId = value; }
        }
        
        private string _multiVmGroupName;
        
        /// <summary>
        /// Optional. Multi vm group name.
        /// </summary>
        public string MultiVmGroupName
        {
            get { return this._multiVmGroupName; }
            set { this._multiVmGroupName = value; }
        }
        
        private string _oSDiskId;
        
        /// <summary>
        /// Optional. Id of the disk containing the OS.
        /// </summary>
        public string OSDiskId
        {
            get { return this._oSDiskId; }
            set { this._oSDiskId = value; }
        }
        
        private string _oSType;
        
        /// <summary>
        /// Optional. Type of the OS on the VM.
        /// </summary>
        public string OSType
        {
            get { return this._oSType; }
            set { this._oSType = value; }
        }
        
        private string _processServerId;
        
        /// <summary>
        /// Optional. Process server Id.
        /// </summary>
        public string ProcessServerId
        {
            get { return this._processServerId; }
            set { this._processServerId = value; }
        }
        
        private IList<VMwareAzureV2ProtectedVolumeDetails> _protectedVolumes;
        
        /// <summary>
        /// Optional. List of protected volumes.
        /// </summary>
        public IList<VMwareAzureV2ProtectedVolumeDetails> ProtectedVolumes
        {
            get { return this._protectedVolumes; }
            set { this._protectedVolumes = value; }
        }
        
        private string _protectionStage;
        
        /// <summary>
        /// Optional. Protection stage.
        /// </summary>
        public string ProtectionStage
        {
            get { return this._protectionStage; }
            set { this._protectionStage = value; }
        }
        
        private int _resyncProgressPercentage;
        
        /// <summary>
        /// Optional. Resync progress percentage.
        /// </summary>
        public int ResyncProgressPercentage
        {
            get { return this._resyncProgressPercentage; }
            set { this._resyncProgressPercentage = value; }
        }
        
        private bool _resyncRequired;
        
        /// <summary>
        /// Optional. Value indicating whether resync is required for this VM.
        /// </summary>
        public bool ResyncRequired
        {
            get { return this._resyncRequired; }
            set { this._resyncRequired = value; }
        }
        
        private long? _rpoInSeconds;
        
        /// <summary>
        /// Optional. RPO in seconds.
        /// </summary>
        public long? RpoInSeconds
        {
            get { return this._rpoInSeconds; }
            set { this._rpoInSeconds = value; }
        }
        
        private int _sourceVmCPUCount;
        
        /// <summary>
        /// Optional. CPU count of the VM on the primary side.
        /// </summary>
        public int SourceVmCPUCount
        {
            get { return this._sourceVmCPUCount; }
            set { this._sourceVmCPUCount = value; }
        }
        
        private int _sourceVmRAMSizeInMB;
        
        /// <summary>
        /// Optional. RAM size of the VM on the primary side.
        /// </summary>
        public int SourceVmRAMSizeInMB
        {
            get { return this._sourceVmRAMSizeInMB; }
            set { this._sourceVmRAMSizeInMB = value; }
        }
        
        private double _uncompressedDataRateInMB;
        
        /// <summary>
        /// Optional. Uncompressed data change rate in MB.
        /// </summary>
        public double UncompressedDataRateInMB
        {
            get { return this._uncompressedDataRateInMB; }
            set { this._uncompressedDataRateInMB = value; }
        }
        
        private string _vHDName;
        
        /// <summary>
        /// Optional. OS disk VHD name.
        /// </summary>
        public string VHDName
        {
            get { return this._vHDName; }
            set { this._vHDName = value; }
        }
        
        private bool _volumeResized;
        
        /// <summary>
        /// Optional. Value indicating whether any volume is resized for this
        /// VM.
        /// </summary>
        public bool VolumeResized
        {
            get { return this._volumeResized; }
            set { this._volumeResized = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VMwareAzureV2ProviderSpecificSettings class.
        /// </summary>
        public VMwareAzureV2ProviderSpecificSettings()
        {
            this.ProtectedVolumes = new LazyList<VMwareAzureV2ProtectedVolumeDetails>();
        }
    }
}
