using Sufficit.Asterisk.Manager.Events;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A QueueStatusCompleteEvent is triggered after the state of all queues has been reported in response to a QueueStatusAction.<br/>
	/// Since Asterisk 1.2
	/// </summary>
	/// <seealso cref="QueueStatusAction" />
	public class QueueStatusCompleteEvent : ResponseEvent, IActionListComplete
	{
		public string EventList { get; set; }

		public uint ListItems { get; set; }
	}
}