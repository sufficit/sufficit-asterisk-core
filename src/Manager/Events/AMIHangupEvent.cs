using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// An ExtensionStatusEvent is triggered when the state of an extension changes.<br/>
	/// It is implemented in manager.c
	/// </summary>
	public class AMIHangupEvent : EventBase, IChannelEvent
	{
		[JsonIgnore]
		public override string Key => "Event:Hangup";

		public string Channel { get; set; }

		public int Cause { get; set; }

		/// <summary>
		/// Get/Set the textual representation of the hangup cause.
		/// </summary>
		public string CauseTxt { get; set; }
		
		/// <summary>
		/// Get/Set Channel State
		/// </summary>
		public AsteriskChannelState ChannelState { get; set; }
	}
}