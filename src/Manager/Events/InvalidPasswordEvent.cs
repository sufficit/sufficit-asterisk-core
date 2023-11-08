using Sufficit.Asterisk;
using Sufficit.Asterisk.Manager;
using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised when a request provides an invalid password during an authentication attempt
    /// </summary>
    public class InvalidPasswordEvent : SecurityEvent
    {
        /// <summary>
        /// The challenge that was sent
        /// </summary>
        [JsonPropertyName("challenge")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Challenge { get; set; }

        /// <summary>
        /// The challenge that was received
        /// </summary>
        [JsonPropertyName("receivedchallenge")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ReceivedChallenge { get; set; }

        /// <summary>
        /// The hash that was received
        /// </summary>
        [JsonPropertyName("receivedhash")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ReceivedHash { get; set; }
    }
}