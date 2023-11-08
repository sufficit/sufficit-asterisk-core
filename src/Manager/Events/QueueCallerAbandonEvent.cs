using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	public class QueueCallerAbandonEvent : QueueEvent, IChannelInfoEvent, IChannelEvent
    {
        #region CHANNEL INTERFACE

        public string Channel { get; set; } = default!;

        public string UniqueId { get; set; } = default!;

        public string? LinkedId { get; set; }

        #endregion
        #region IMPLEMENT INTERFACE CHANNEL INFO EVENT

        public string Language { get; set; } = default!;
        public string Context { get; set; } = default!;
        public string Exten { get; set; } = default!;
        public string Priority { get; set; } = default!;

        public string? CallerIdNum { get; set; }
        public string? CallerIdName { get; set; }
        public string? ConnectedLineNum { get; set; }
        public string? ConnectedLineName { get; set; }

        #endregion

        public int HoldTime { get; set; }
		public int Position { get; set; }
		public int OriginalPosition { get; set; }
        
        public AsteriskChannelState ChannelState { get; set; }
        public string ChannelStateDesc { get; set; } = string.Empty;

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? AccountCode { get; set; }
    }
}
