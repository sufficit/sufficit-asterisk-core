using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    /// <summary>
    /// Abstract base class for events triggered in response to a ManagerAction.<br/>
    /// All ResponseEvents contain an additional action id property that links the
    /// event to the action that caused it.
    /// </summary>
    public abstract class ResponseEvent : ManagerEventFromAsterisk, IResponseEvent
    {
        /// <summary>
        /// Get/Set the action id of the ManagerAction that caused this event.
        /// </summary>
        [JsonPropertyName("actionid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string ActionId { get; set; } = default!;

        /// <summary>
        /// Get/Set the internal action id of the ManagerAction that caused this event.
        /// </summary>
        [JsonPropertyName("internalactionid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? InternalActionId { get; set; }
    }
}