using System;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A HangupEvent is triggered when a channel is hung up.<br/>
	/// It is implemented in channel.c
	/// </summary>
	public class FullyBootedEvent : ManagerEvent
	{
		public uint Uptime { get; set; }

		public uint LastReload { get; set; }

		public string Status { get; set; }
	}
}