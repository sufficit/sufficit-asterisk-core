using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    public abstract class AbstractQueueAgentDestEvent : AbstractDestChannelEvent, IQueueEvent, IQueueMemberDestEvent
    {
        /// <summary>
        ///     Get/Set the name of the queue.
        /// </summary>
        public string Queue { get; set; } = string.Empty;

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Added in Asterisk 12
        /// </summary>
        public string Interface { get; set; } = string.Empty;

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Removed in asterisk 12
        /// </summary>
        public string Member { get; set; } = string.Empty;

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        public string MemberName { get; set; } = string.Empty;
    }
}
