// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureCosmosDBDataFeedPatch. </summary>
    internal partial class AzureCosmosDBDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureCosmosDBDataFeedPatch. </summary>
        public AzureCosmosDBDataFeedPatch()
        {
            DataSourceType = DataFeedSourceKind.AzureCosmosDb;
        }

        /// <summary> Gets or sets the data source parameter. </summary>
        public AzureCosmosDBParameterPatch DataSourceParameter { get; set; }
    }
}
