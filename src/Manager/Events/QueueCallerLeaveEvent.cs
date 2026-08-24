using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A QueueCallerLeaveEvent is triggered when a channel leaves a queue.<br/>
	/// </summary>
	public class QueueCallerLeaveEvent : LeaveEvent, IChannelInfoEvent, IChannelEvent
	{
		public int Position { get; set; }

		#region IMPLEMENT INTERFACE CHANNEL INFO EVENT

		public string Language { get; set; } = string.Empty;
		public string Context { get; set; } = string.Empty;
		public string Exten { get; set; } = string.Empty;
		public string Priority { get; set; } = string.Empty;
		public string LinkedId { get; set; } = string.Empty;

		#endregion

		public AsteriskChannelState ChannelState { get; set; }
		public string ChannelStateDesc { get; set; } = string.Empty;
		public string CallerIdNum { get; set; } = string.Empty;
		public string CallerIdName { get; set; } = string.Empty;
		public string ConnectedLineNum { get; set; } = string.Empty;
		public string ConnectedLineName { get; set; } = string.Empty;

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? AccountCode { get; set; }

		public string Channel { get; set; } = string.Empty;

		public string UniqueId { get; set; } = string.Empty;

		/// <summary>
		/// Get/Set the number of elements in the queue, i.e. the number of calls waiting to be answered by an agent.
		/// </summary>
		public int Count { get; set; }
	}
}
