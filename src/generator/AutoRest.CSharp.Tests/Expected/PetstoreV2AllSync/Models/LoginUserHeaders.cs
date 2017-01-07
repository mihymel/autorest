// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.PetstoreV2AllSync.Models
{
    using Fixtures.PetstoreV2AllSync;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for loginUser operation.
    /// </summary>
    public partial class LoginUserHeaders
    {
        /// <summary>
        /// Initializes a new instance of the LoginUserHeaders class.
        /// </summary>
        public LoginUserHeaders() { }

        /// <summary>
        /// Initializes a new instance of the LoginUserHeaders class.
        /// </summary>
        /// <param name="xRateLimit">calls per hour allowed by the user</param>
        /// <param name="xExpiresAfter">date in UTC when toekn expires</param>
        public LoginUserHeaders(int? xRateLimit = default(int?), System.DateTime? xExpiresAfter = default(System.DateTime?))
        {
            XRateLimit = xRateLimit;
            XExpiresAfter = xExpiresAfter;
        }

        /// <summary>
        /// Gets or sets calls per hour allowed by the user
        /// </summary>
        [JsonProperty(PropertyName = "X-Rate-Limit")]
        public int? XRateLimit { get; set; }

        /// <summary>
        /// Gets or sets date in UTC when toekn expires
        /// </summary>
        [JsonProperty(PropertyName = "X-Expires-After")]
        public System.DateTime? XExpiresAfter { get; set; }

    }
}

