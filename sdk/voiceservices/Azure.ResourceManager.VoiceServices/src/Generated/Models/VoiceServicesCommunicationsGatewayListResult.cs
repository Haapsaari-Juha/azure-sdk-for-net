// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.VoiceServices;

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> The response of a CommunicationsGateway list operation. </summary>
    internal partial class VoiceServicesCommunicationsGatewayListResult
    {
        /// <summary> Initializes a new instance of <see cref="VoiceServicesCommunicationsGatewayListResult"/>. </summary>
        /// <param name="value"> The CommunicationsGateway items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VoiceServicesCommunicationsGatewayListResult(IEnumerable<VoiceServicesCommunicationsGatewayData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VoiceServicesCommunicationsGatewayListResult"/>. </summary>
        /// <param name="value"> The CommunicationsGateway items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal VoiceServicesCommunicationsGatewayListResult(IReadOnlyList<VoiceServicesCommunicationsGatewayData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The CommunicationsGateway items on this page. </summary>
        public IReadOnlyList<VoiceServicesCommunicationsGatewayData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
