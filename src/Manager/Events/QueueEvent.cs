using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Abstract base class providing common properties for JoinEvent and LeaveEvent.
	/// </summary>
	public abstract class QueueEvent : ManagerEventFromAsterisk, IQueueEvent
	{
		/// <summary>
		/// Get/Set the name of the queue.
		/// </summary>
		public string Queue { get; set; }
	}
}