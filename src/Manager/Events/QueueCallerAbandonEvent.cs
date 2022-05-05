using Sufficit.Asterisk.Events;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	public class QueueCallerAbandonEvent : QueueEvent, IChannelInfoEvent, IChannelEvent
	{
		public int HoldTime { get; set; }
		public int Position { get; set; }
		public int OriginalPosition { get; set; }

        #region IMPLEMENT INTERFACE CHANNEL INFO EVENT

        public string Language { get; set; }
		public string Context { get; set; }
		public string Exten { get; set; }
		public string Priority { get; set; }
		public string LinkedId { get; set; }

        #endregion

        public AsteriskChannelState ChannelState { get; set; }
		public string ChannelStateDesc { get; set; }
		public string CallerIdNum { get; set; }
		public string CallerIdName { get; set; }
		public string ConnectedLineNum { get; set; }
		public string ConnectedLineName { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? AccountCode { get; set; }

		public string Channel { get; set; }

		public string UniqueId { get; set; }
	}
}
