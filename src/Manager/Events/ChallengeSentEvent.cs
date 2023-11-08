using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when an Asterisk service sends an authentication challenge to a request
    /// </summary>
    public class ChallengeSentEvent : SecurityEvent
    {
        /// <summary>
        /// The challenge that was sent
        /// </summary>
        [JsonPropertyName("challenge")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Challenge { get; set; } = default!;

        [Obsolete]
        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Status { get; set; }
    }
}