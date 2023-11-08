using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised when a request attempts to use a transport not allowed by the Asterisk service
    /// </summary>
    public class InvalidTransportEvent : SecurityEvent
    {
        /// <summary>
        /// The transport type that the request attempted to use
        /// </summary>
        [JsonPropertyName("attemptedtransport")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string AttemptedTransport { get; set; } = default!;
    }
}