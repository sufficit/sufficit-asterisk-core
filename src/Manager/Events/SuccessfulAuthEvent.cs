using Sufficit.Asterisk;
using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised when a request successfully authenticates with a service..<br />
    /// </summary>
    public class SuccessfulAuthEvent : SecurityEvent
    {
        /// <summary>
        /// Whether or not the authentication attempt included a password
        /// </summary>
        [JsonPropertyName("usingpassword")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public bool UsingPassword { get; set; }
    }
}