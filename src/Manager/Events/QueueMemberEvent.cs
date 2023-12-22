using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Triggered in response to a <see cref="QueueStatusAction"/>
    /// </summary>
    public class QueueMemberEvent : AbstractQueueMemberEvent, IResponseEvent
    {
        /// <summary>
        /// Get/Set the action id of the ManagerAction that caused this event.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string ActionId { get; set; } = default!;

        /// <summary>
        /// Get/Set the internal action id of the ManagerAction that caused this event.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? InternalActionId { get; set; }
    }
}
