using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public abstract class AbstractQueueAgentDestEvent : AbstractChannelInfoEvent, IQueueAgentEvent, IDestChannelEvent
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
        public string Member { get; set; }

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        public string MemberName { get; set; }


        #region IMPLEMENT INTERFACE DESTINATION CHANNEL EVENT

        public string DestChannel { get; set; }
        public string DestChannelState { get; set; }
        public string DestChannelStateDesc { get; set; }
        public string DestCallerIdNum { get; set; }
        public string DestCallerIdName { get; set; }
        public string DestConnectedLineNum { get; set; }
        public string DestConnectedLineName { get; set; }
        public string DestLanguage { get; set; }
        public string DestContext { get; set; }
        public string DestExten { get; set; }
        public string DestPriority { get; set; }
        public string DestUniqueId { get; set; }
        public string DestLinkedId { get; set; }

        #endregion
    }
}
