using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A QueueCallerJoinEvent is triggered when a channel joins a queue.<br/>
	/// </summary>
	public class QueueCallerJoinEvent : JoinEvent, IChannelInfoEvent, IChannelEvent
	{
		#region IMPLEMENT INTERFACE CHANNEL INFO EVENT

		public string Language { get; set; }
		public string Context { get; set; }
		public string Exten { get; set; }
		public string Priority { get; set; }
		public string LinkedId { get; set; }

		#endregion

		public AsteriskChannelState ChannelState { get; set; }

		public string ChannelStateDesc { get; set; }
		public string ConnectedLineNum { get; set; }
		public string ConnectedLineName { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? AccountCode { get; set; }

		public string Channel { get; set; }

		public string UniqueId { get; set; }

		/// <summary>
		/// Get/Set the number of elements in the queue, i.e. the number of calls waiting to be answered by an agent.
		/// </summary>
		public int Count { get; set; }
	}
}
