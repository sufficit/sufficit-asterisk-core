﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public abstract class AbstractQueueAgentEvent : AbstractChannelInfoEvent, IQueueEvent, IQueueMemberEvent
    {
        /// <summary>
        ///     Get/Set the name of the queue.
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Added in Asterisk 12
        /// </summary>
        public string Interface { get; set; }

        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Removed in asterisk 12
        /// </summary>
        public string Member { get => MemberName; set => MemberName = value; }

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        public string MemberName { get; set; }
    }
}