using System;
using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class OriginateResponseEvent : ResponseEvent, IChannelEvent
	{
		public string Response { get; set; } = string.Empty;
		public string Context { get; set; } = string.Empty;
		public string Exten { get; set; } = string.Empty;
		public int Reason { get; set; }
		public string CallerId { get; set; } = string.Empty;
		public string CallerIdNum { get; set; } = string.Empty;
		public string CallerIdName { get; set; } = string.Empty;
		public string Channel { get; set; } = string.Empty;
		public string UniqueId { get; set; } = string.Empty;
		public string LinkedId { get; set; } = string.Empty;
		public string Application { get; set; } = string.Empty;
		public string Data { get; set; } = string.Empty;
	}
}
