using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised when a request is not allowed by the service
    /// </summary>
	public class RequestNotAllowedEvent : RequestEvent
    {
        /// <summary>
        /// Parameters provided to the rejected request
        /// </summary>
        [JsonPropertyName("requestparams")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? RequestParams { get; set; }
    }
}