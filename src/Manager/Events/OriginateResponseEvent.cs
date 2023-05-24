using System;
using Sufficit.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class OriginateResponseEvent : ResponseEvent, IChannelEvent
	{
		public string Response { get; set; }
		public string Context { get; set; }
		public string Exten { get; set; }
		public int Reason { get; set; }
		public string CallerId { get; set; }
		public string CallerIdNum { get; set; }
		public string CallerIdName { get; set; }
		public string Channel { get; set; }
		public string UniqueId { get; set; }
		public string LinkedId { get; set; }
		public string Application { get; set; }
		public string Data { get; set; }
	}
}
