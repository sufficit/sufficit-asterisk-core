using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    /// <summary>
    /// Security Events (read-only events)
    /// </summary>
    public abstract class SecurityEvent : ManagerEventFromAsterisk
    {
        /// <summary>
        /// The time the event was detected 
        /// </summary>
        [JsonPropertyName("eventtv")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime EventTV { get; set; }

        /// <summary>
        /// A relative severity of the security event
        /// </summary>
        [JsonPropertyName("severity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Severity Severity { get; set; }

        /// <summary>
        /// The Asterisk service that raised the security event
        /// </summary>
        [JsonPropertyName("service")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Service { get; set; } = default!;

        /// <summary>
        /// If available, the name of the module that raised the event
        /// </summary>
        [JsonPropertyName("module")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Module { get; set; }

        /// <summary>
        /// The timestamp reported by the session
        /// </summary>
        [JsonPropertyName("sessiontv")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime? SessionTV { get; set; }

        /// <summary>
        /// The version of this event
        /// </summary>
        [JsonPropertyName("eventversion")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string EventVersion { get; set; } = default!;

        /// <summary>
        /// The Service account associated with the security event notification
        /// </summary>
        [JsonPropertyName("accountid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string AccountId { get; set; } = default!;

        /// <summary>
        /// A unique identifier for the session in the service that raised the event
        /// </summary>
        [JsonPropertyName("sessionid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// The address of the Asterisk service that raised the security event
        /// </summary>
        [JsonPropertyName("localaddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string LocalAddress { get; set; } = default!;

        /// <summary>
        /// The remote address of the entity that caused the security event to be raised
        /// </summary>
        [JsonPropertyName("remoteaddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string RemoteAddress { get; set; } = default!;
    }
}
