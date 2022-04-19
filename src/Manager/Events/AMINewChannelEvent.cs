using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// An NewChannelEvent is triggered when.<br/>
	/// It is implemented in manager.c
	/// </summary>
	public class AMINewChannelEvent : EventBase, IChannelEvent
	{
		[JsonIgnore]
		public override string Key => "Event:NewChannel";

		public string Channel { get; set; }

		/// <summary>
		/// Get/Set Channel State
		/// </summary>
		public AsteriskChannelState ChannelState { get; set; }

		/// <summary>
		/// Get/Set Channel State Description
		/// </summary>
		public string ChannelStateDesc { get; set; }

		/// <summary>
		/// Get/Set the Caller*ID of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		public string CallerId { get; set; } 

		/// <summary>
		/// Get/Set the Caller*ID of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		public string CallerIdNum { get; set; }

		/// <summary>
		/// Get/Set the Caller*ID Name of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		public string CallerIdName { get; set; }

		/// <summary>
		/// Get/Set channel AccountCode
		/// </summary>
		public string AccountCode { get; set; }

		public string Connectedlinenum { get; set; }

		public string ConnectedLineName { get; set; }

		public string Exten { get; set; }
	}
}