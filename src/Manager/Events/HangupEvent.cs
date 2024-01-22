using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A HangupEvent is triggered when a channel is hung up.<br/>
	/// It is implemented in channel.c
	/// </summary>
	/// <seealso cref="Privilege.call" />
	public class HangupEvent : AbstractChannelInfoEvent
    {
		/// <summary>
		/// Get/Set the cause of the hangup.
		/// </summary>
		public int Cause { get; set; }

		/// <summary>
		/// Get/Set the textual representation of the hangup cause.
		/// </summary>
		public string CauseTxt { get; set; } = default!;
    }
}