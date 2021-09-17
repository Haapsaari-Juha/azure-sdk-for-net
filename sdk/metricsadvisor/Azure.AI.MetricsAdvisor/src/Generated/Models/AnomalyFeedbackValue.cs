// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyFeedbackValue. </summary>
    internal partial class AnomalyFeedbackValue
    {
        /// <summary> Initializes a new instance of AnomalyFeedbackValue. </summary>
        /// <param name="anomalyValue"></param>
        public AnomalyFeedbackValue(AnomalyValue anomalyValue)
        {
            AnomalyValue = anomalyValue;
        }

        /// <summary> Gets or sets the anomaly value. </summary>
        public AnomalyValue AnomalyValue { get; set; }
    }
}
