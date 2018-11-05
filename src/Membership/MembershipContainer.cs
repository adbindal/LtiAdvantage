﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace LtiAdvantageLibrary.NetCore.Membership
{
    /// <summary>
    /// Represents the results returned by the Membership service.
    /// See https://www.imsglobal.org/spec/lti-nrps/v2p0#membership-container-media-type.
    /// </summary>
    public class MembershipContainer
    {
        /// <summary>
        /// The ID of these results. Typically the request URL to Membership service.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The list of members in the specified context.
        /// </summary>
        [JsonProperty("members")]
        public ICollection<Member> Members { get; set; }
    }
}
