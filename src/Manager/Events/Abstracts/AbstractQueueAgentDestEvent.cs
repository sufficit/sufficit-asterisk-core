using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    public abstract class AbstractQueueAgentDestEvent : AbstractDestChannelEvent, IQueueEvent, IQueueMemberDestEvent
    {
        /// <summary>
        ///     Get/Set the name of the queue.
        /// </summary>
        public string Queue { get; set; } = default!;

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Added in Asterisk 12
        /// </summary>
        public string Interface { get; set; } = default!;

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [Obsolete("Removed in asterisk 12, use MemberName instead")]
        public string? Member { get; set; }

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        public string MemberName { get; set; } = default!;
    }
}
