﻿using System;
using System.ComponentModel;
using LtiAdvantageLibrary.NetCore.Lti;
using Newtonsoft.Json;

namespace LtiAdvantageLibrary.NetCore.Membership
{
    /// <summary>
    /// Represents a member in the Membership container of the Membership service.
    /// </summary>
    /// <remarks>
    /// Member must not contain more information about the person than would be included
    /// in a basic launch. For example, if PII is not sent in basic launch from the same
    /// context, it should not be included in member.
    /// See https://www.imsglobal.org/spec/lti-nrps/v2p0#membership-container-media-type.
    /// </remarks>
    public class Member
    {
        /// <summary>
        /// The context ID. Repeated for each member.
        /// Corresponds to <code>Id</code> in <see cref="LtiResourceLinkRequest.Context"/>.
        /// </summary>
        [JsonProperty("context_id")]
        public string ContextId { get; set; }

        /// <summary>
        /// The context label. Repeated for each member.
        /// Corresponds to <code>Label</code> in <see cref="LtiResourceLinkRequest.Context"/>.
        /// </summary>
        [JsonProperty("context_label")]
        public string ContextLabel { get; set; }


        /// <summary>
        /// The context title. Repeated for each member.
        /// Corresponds to <code>Title</code> in <see cref="LtiResourceLinkRequest.Context"/>.
        /// </summary>
        [JsonProperty("context_title")]
        public string ContextTitle { get; set; }

        /// <summary>
        /// The primary email address for the person.
        /// Not specified if not included in a basic launch from same context.
        /// Corresponds to <see cref="LtiResourceLinkRequest.Email"/>.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The person's assigned family name.
        /// Not specified  if not included in a basic launch from same context. 
        /// Corresponds to <see cref="LtiResourceLinkRequest.FamilyName"/>.
        /// </summary>
        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// The person's assigned first name.
        /// Not specified  if not included in a basic launch from same context. 
        /// Corresponds to <see cref="LtiResourceLinkRequest.GivenName"/>.
        /// </summary>
        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// Contains context and resource link specific message parameters.
        /// </summary>
        /// <remarks>
        /// Included with <see cref="Member"/> when the membership list is filtered to
        /// users who can access a specific resource link.
        /// See https://www.imsglobal.org/spec/lti-nrps/v2p0#membership-container-media-type.
        /// </remarks>
        [JsonProperty("message")]
        public LtiResourceLinkRequest[] Message { get; set; }

        /// <summary>
        /// The person's assigned full name (typically their first name followed
        /// by their family name separated with a space).
        /// Not specified  if not included in a basic launch from same context. 
        /// Corresponds to <see cref="LtiResourceLinkRequest.Name"/>.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A URL to an image for the person.
        /// Not specified  if not included in a basic launch from same context. 
        /// Corresponds to <see cref="LtiResourceLinkRequest.Picture"/>.
        /// </summary>
        [JsonProperty("picture")]
        public Uri Picture { get; set; }

        /// <summary>
        /// The role/s this member has in the context. Does not include non-context roles.
        /// Corresponds to <see cref="LtiResourceLinkRequest.Roles"/> (without non-context
        /// roles).
        /// </summary>
        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        /// <summary>
        /// A unique identifier for the person as provisioned by an external system such as an SIS.
        /// Corresponds to <code>PersonSourcedId</code> in <see cref="LtiResourceLinkRequest.Lis"/>.
        /// </summary>
        [JsonProperty("sourced_id")]
        public string SourcedId { get; set; }

        /// <summary>
        /// Membership status is either Active or Inactive. Defaults to Active if not specified.
        /// </summary>
        /// <remarks>
        /// Use Deleted when reporting differences if membership no longer exists.
        /// See https://www.imsglobal.org/spec/lti-nrps/v2p0#membership-status.
        /// </remarks>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(MemberStatus.Active)]
        public MemberStatus? Status { get; set; }

        /// <summary>
        /// A unique identifier for the person.
        /// Corresponds to <see cref="LtiResourceLinkRequest.Sub"/>.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
