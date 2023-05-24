using Sufficit.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A QueueEntryEvent is triggered in response to a QueueStatusAction and contains information about an entry in a queue.<br/>
    /// It is implemented in apps/app_queue.c
    /// </summary>
    /// <seealso cref="Manager.Action.QueueStatusAction" />
    public class QueueEntryEvent : ResponseEvent
	{
		/// <summary>
		/// Get/Set the name of the queue that contains this entry.
		/// </summary>
		public string Queue { get; set; }

		/// <summary>
		/// Get/Set the position of this entry in the queue.
		/// </summary>
		public int Position { get; set; }

		/// <summary>
		/// Get/Set the the Caller*ID number of this entry.
		/// </summary>
		public string CallerId { get; set; }

		/// <summary>
		/// Get/Set the Caller*ID name of this entry.
		/// </summary>
		public string CallerIdName { get; set; }

		/// <summary>
		/// Get/Set the number of seconds this entry has spent in the queue.
		/// </summary>
		public long Wait { get; set; }
	}
}