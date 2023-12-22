using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    public abstract class AbstractDestChannelEvent : AbstractChannelInfoEvent, IDestChannelEvent, IChannelEvent
    {
        public string DestChannel { get; set; } = string.Empty;
        public string DestChannelState { get; set; } = string.Empty;
        public string DestChannelStateDesc { get; set; } = string.Empty;
        public string DestCallerIdNum { get; set; } = string.Empty;
        public string DestCallerIdName { get; set; } = string.Empty;
        public string DestConnectedLineNum { get; set; } = string.Empty;
        public string DestConnectedLineName { get; set; } = string.Empty;
        public string DestLanguage { get; set; } = string.Empty;
        public string DestContext { get; set; } = string.Empty;
        public string DestExten { get; set; } = string.Empty;
        public string DestPriority { get; set; } = string.Empty;

        /// <summary>
		/// Get/Set the unique ID of the destination channel.
		/// </summary>
        public string DestUniqueId { get; set; } = string.Empty;
        public string DestLinkedId { get; set; } = string.Empty;
    }
}
