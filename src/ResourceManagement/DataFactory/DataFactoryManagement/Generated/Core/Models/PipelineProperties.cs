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
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Core.Models;

namespace Microsoft.Azure.Management.DataFactories.Core.Models
{
    /// <summary>
    /// Pipeline properties.
    /// </summary>
    public partial class PipelineProperties
    {
        private IList<Activity> _activities;
        
        /// <summary>
        /// Required. Activities that belong to the pipeline.
        /// </summary>
        public IList<Activity> Activities
        {
            get { return this._activities; }
            set { this._activities = value; }
        }
        
        private IList<Dataset> _datasets;
        
        /// <summary>
        /// Optional. List of Datasets to be used by activities defined in the
        /// pipeline. This can be used to define datasets that are specific to
        /// this pipeline and not defined within the datafactory. Datasets
        /// defined within this pipeline can only be used by this Pipeline and
        /// cannot be shared.
        /// </summary>
        public IList<Dataset> Datasets
        {
            get { return this._datasets; }
            set { this._datasets = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Item description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private System.DateTime? _end;
        
        /// <summary>
        /// Optional. The end time of the pipeline. The start and end time can
        /// both be empty to create a pipeline; they must both have values to
        /// set an active period for the pipeline and one cannot have a value
        /// if the other does not.
        /// </summary>
        public System.DateTime? End
        {
            get { return this._end; }
            set { this._end = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error in processing pipeline request.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private System.TimeSpan? _expirationTime;
        
        /// <summary>
        /// Optional. Duration of time after creation for which the pipeline is
        /// valid and should remain provisioned. The pipeline will be deleted
        /// automatically once it reaches the expiration time if it does not
        /// have any active or pending runs.
        /// </summary>
        public System.TimeSpan? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }
        
        private string _hubName;
        
        /// <summary>
        /// Optional. The name of the Hub that this pipeline belongs to.
        /// </summary>
        public string HubName
        {
            get { return this._hubName; }
            set { this._hubName = value; }
        }
        
        private bool? _isPaused;
        
        /// <summary>
        /// Optional. The status of the pipline. Pipeline is paused when
        /// boolean is set to true.
        /// </summary>
        public bool? IsPaused
        {
            get { return this._isPaused; }
            set { this._isPaused = value; }
        }
        
        private string _pipelineMode;
        
        /// <summary>
        /// Optional. The method of scheduling runs for the pipeline. Must be
        /// one of <see
        /// cref="Microsoft.Azure.Management.DataFactories.Models.PipelineMode"/>.
        /// </summary>
        public string PipelineMode
        {
            get { return this._pipelineMode; }
            set { this._pipelineMode = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. The provisioning state of the pipeline.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private PipelineRuntimeInfo _runtimeInfo;
        
        /// <summary>
        /// Optional. Pipeline runtime information.
        /// </summary>
        public PipelineRuntimeInfo RuntimeInfo
        {
            get { return this._runtimeInfo; }
            set { this._runtimeInfo = value; }
        }
        
        private System.DateTime? _start;
        
        /// <summary>
        /// Optional. The start time of the pipeline. The start and end time
        /// can both be empty to create a pipeline; they must both have values
        /// to set an active period for the pipeline and one cannot have a
        /// value if the other does not.
        /// </summary>
        public System.DateTime? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineProperties class.
        /// </summary>
        public PipelineProperties()
        {
            this.Activities = new LazyList<Activity>();
            this.Datasets = new LazyList<Dataset>();
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineProperties class with
        /// required arguments.
        /// </summary>
        public PipelineProperties(IList<Activity> activities)
            : this()
        {
            if (activities == null)
            {
                throw new ArgumentNullException("activities");
            }
            this.Activities = activities;
        }
    }
}
