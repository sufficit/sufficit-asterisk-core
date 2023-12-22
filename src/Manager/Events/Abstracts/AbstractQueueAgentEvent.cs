using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    public abstract class AbstractQueueAgentEvent : AbstractDestChannelEvent, IQueueEvent
    {
        /// <summary>
        ///     Get/Set the name of the queue.
        /// </summary>
        public string Queue { get; set; } = default!;

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        public string MemberName { get; set; } = string.Empty;

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Removed in asterisk 12
        /// </summary>
        [JsonIgnore]
        public string Member { get => MemberName; set => MemberName = value; }

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Removed in asterisk 12
        /// </summary>
        [JsonIgnore]
        public string Name { get => MemberName; set => MemberName = value; }

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Added in Asterisk 12
        /// </summary>
        public string Interface { get; set; } = string.Empty;
    }
}
