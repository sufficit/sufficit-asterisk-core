using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Channels
{
    public class RegistryStatus
    {
        [JsonPropertyName("channel_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        /// <inheritdoc cref="AsteriskChannelProtocol"/>
		public AsteriskChannelProtocol? ChannelType { get; set; }

        /// <summary>
        /// Get/Set the domain or host name of the SIP or IAX2 server.<br/>
        /// This is the host part used in the register lines in
        /// iax.conf and sip.conf.
        /// </summary>
        [JsonPropertyName("domain")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Domain { get; set; }

        /// <summary>
        /// Get/Set the username used for registration.<br/>
        /// SIP send the username in case of a registration timeout, IAX2 in case of
        /// a registration failure. Otherwise the username is null.
        /// </summary>
        [JsonPropertyName("username")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Username { get; set; }

        /// <summary>
		/// Get/Set the registration state.<br/>
		/// For sip this may be one of (not sure if all of these are exposed via the
		/// manager api, at least "Registered" and "Timeout" are used though)
		/// <ul>
		/// <li>Registered</li>
		/// <li>Unregistered</li>
		/// <li>Request Sent</li>
		/// <li>Auth. Sent</li>
		/// <li>Rejected</li>
		/// <li>Timeout</li>
		/// <li>No Authentication</li>
		/// <li>Unreachable</li>
		/// </ul>
		/// IAX2 only uses
		/// <ul>
		/// <li>Rejected</li>
		/// </ul>
		/// Successful IAX2 registrations do not use the this property at all.
		/// </summary>
        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Status { get; set; }

        /// <summary>
        /// Get/Set the cause of a rejected registration.
        /// The cause of a rejected registration or "&lt;unknown&gt;" if the cause is unknown.
        /// </summary>
        [JsonPropertyName("cause")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Cause { get; set; }

        public override bool Equals(object? obj)
            => obj is RegistryStatus other && 
            other.Cause == Cause && 
            other.ChannelType == ChannelType && 
            other.Domain == Domain &&
            other.Status == Status && 
            other.Username == Username;

        public override int GetHashCode()
            => (Cause, ChannelType, Domain, Status, Username).GetHashCode();
    }
}
