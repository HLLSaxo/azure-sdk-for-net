// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Azure;
    using Management;
    using EventHub;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single item in List or Get Event Hub operation
    /// </summary>
    [JsonTransformation]
    public partial class EventHubResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the EventHubResource class.
        /// </summary>
        public EventHubResource() { }

        /// <summary>
        /// Initializes a new instance of the EventHubResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="createdAt">Exact time the Event Hub was
        /// created.</param>
        /// <param name="messageRetentionInDays">Number of days to retain the
        /// events for this Event Hub.</param>
        /// <param name="partitionCount">Number of partitions created for the
        /// Event Hub.</param>
        /// <param name="partitionIds">Current number of shards on the Event
        /// Hub.</param>
        /// <param name="status">Enumerates the possible values for the status
        /// of the Event Hub. Possible values include: 'Active', 'Disabled',
        /// 'Restoring', 'SendDisabled', 'ReceiveDisabled', 'Creating',
        /// 'Deleting', 'Renaming', 'Unknown'</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        public EventHubResource(string id = default(string), string name = default(string), string type = default(string), System.DateTime? createdAt = default(System.DateTime?), long? messageRetentionInDays = default(long?), long? partitionCount = default(long?), IList<string> partitionIds = default(IList<string>), EntityStatus? status = default(EntityStatus?), System.DateTime? updatedAt = default(System.DateTime?))
            : base(id, name, type)
        {
            CreatedAt = createdAt;
            MessageRetentionInDays = messageRetentionInDays;
            PartitionCount = partitionCount;
            PartitionIds = partitionIds;
            Status = status;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets exact time the Event Hub was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; protected set; }

        /// <summary>
        /// Gets or sets number of days to retain the events for this Event
        /// Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageRetentionInDays")]
        public long? MessageRetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets number of partitions created for the Event Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionCount")]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// Gets current number of shards on the Event Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionIds")]
        public IList<string> PartitionIds { get; protected set; }

        /// <summary>
        /// Gets or sets enumerates the possible values for the status of the
        /// Event Hub. Possible values include: 'Active', 'Disabled',
        /// 'Restoring', 'SendDisabled', 'ReceiveDisabled', 'Creating',
        /// 'Deleting', 'Renaming', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; protected set; }

    }
}

