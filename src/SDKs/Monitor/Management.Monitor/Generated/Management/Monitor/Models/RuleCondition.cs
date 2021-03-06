// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The condition that results in the alert rule being activated.
    /// </summary>
    public partial class RuleCondition
    {
        /// <summary>
        /// Initializes a new instance of the RuleCondition class.
        /// </summary>
        public RuleCondition() { }

        /// <summary>
        /// Initializes a new instance of the RuleCondition class.
        /// </summary>
        /// <param name="dataSource">the resource from which the rule collects
        /// its data. For this type dataSource will always be of type
        /// RuleMetricDataSource.</param>
        public RuleCondition(RuleDataSource dataSource = default(RuleDataSource))
        {
            DataSource = dataSource;
        }

        /// <summary>
        /// Gets or sets the resource from which the rule collects its data.
        /// For this type dataSource will always be of type
        /// RuleMetricDataSource.
        /// </summary>
        [JsonProperty(PropertyName = "dataSource")]
        public RuleDataSource DataSource { get; set; }

    }
}
