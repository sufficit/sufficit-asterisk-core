using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    /// <summary>
    /// Request Security Events (read-only events)
    /// </summary>
    public abstract class RequestEvent : SecurityEvent
    {
        /// <summary>
        /// The type of request attempted
        /// </summary>
        [JsonPropertyName("requesttype")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string RequestType { get; set; } = default!;        
    }
}
