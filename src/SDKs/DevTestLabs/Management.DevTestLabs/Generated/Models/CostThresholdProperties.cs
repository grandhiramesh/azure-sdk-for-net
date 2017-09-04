// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties of a cost threshold item.
    /// </summary>
    public partial class CostThresholdProperties
    {
        /// <summary>
        /// Initializes a new instance of the CostThresholdProperties class.
        /// </summary>
        public CostThresholdProperties() { }

        /// <summary>
        /// Initializes a new instance of the CostThresholdProperties class.
        /// </summary>
        public CostThresholdProperties(string thresholdId = default(string), PercentageCostThresholdProperties percentageThreshold = default(PercentageCostThresholdProperties), string displayOnChart = default(string), string sendNotificationWhenExceeded = default(string), string notificationSent = default(string))
        {
            ThresholdId = thresholdId;
            PercentageThreshold = percentageThreshold;
            DisplayOnChart = displayOnChart;
            SendNotificationWhenExceeded = sendNotificationWhenExceeded;
            NotificationSent = notificationSent;
        }

        /// <summary>
        /// The ID of the cost threshold item.
        /// </summary>
        [JsonProperty(PropertyName = "thresholdId")]
        public string ThresholdId { get; set; }

        /// <summary>
        /// The value of the percentage cost threshold.
        /// </summary>
        [JsonProperty(PropertyName = "percentageThreshold")]
        public PercentageCostThresholdProperties PercentageThreshold { get; set; }

        /// <summary>
        /// Indicates whether this threshold will be displayed on cost charts.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "displayOnChart")]
        public string DisplayOnChart { get; set; }

        /// <summary>
        /// Indicates whether notifications will be sent when this threshold
        /// is exceeded. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "sendNotificationWhenExceeded")]
        public string SendNotificationWhenExceeded { get; set; }

        /// <summary>
        /// Indicates the datetime when notifications were last sent for this
        /// threshold.
        /// </summary>
        [JsonProperty(PropertyName = "NotificationSent")]
        public string NotificationSent { get; set; }

    }
}