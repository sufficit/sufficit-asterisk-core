using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    public abstract class AbstractDestChannelEvent : AbstractChannelInfoEvent, IDestChannelEvent, IChannelEvent
    {
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

        /// <summary>
		/// Get/Set the unique ID of the destination channel.
		/// </summary>
        public string DestUniqueId { get; set; }
        public string DestLinkedId { get; set; }
    }
}
