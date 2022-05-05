using Sufficit.Asterisk.Manager.Events;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A QueueParamsEvent is triggered in response to a QueueStatusAction and contains the parameters of a queue.<br/>
	/// It is implemented in apps/app_queue.c
	/// </summary>
	/// <seealso cref="Manager.Action.QueueStatusAction" />
	public class QueueParamsEvent : QueueEvent, IResponseEvent
	{
		#region IMPLEMENT INTERFACE RESPONSE EVENT
		/// <summary>
		/// Get/Set the action id of the ManagerAction that caused this event.
		/// </summary>
		public string ActionId { get; set; }

		/// <summary>
		/// Get/Set the internal action id of the ManagerAction that caused this event.
		/// </summary>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? InternalActionId { get; set; }

		#endregion 
	
		/// <summary>
		/// Get/Set queue strategy.
		/// </summary>
		public string Strategy { get; set; }

		/// <summary> Returns the maximum number of people waiting in the queue or 0 for unlimited.<br/>
		/// This corresponds to the maxlen setting in queues.conf.
		/// </summary>
		/// <summary> Sets the maximum number of people waiting in the queue.</summary>
		public int Max { get; set; }

		/// <summary> Returns the number of calls currently waiting in the queue.</summary>
		/// <summary> Sets the number of calls currently waiting in the queue.</summary>
		public int Calls { get; set; }

		/// <summary> Returns the current average holdtime for this queue (in seconds).</summary>
		/// <summary> Sets the current average holdtime for this queue.</summary>
		public int Holdtime { get; set; }

		/// <summary> Returns the number of completed calls.</summary>
		/// <summary> Sets the number of completed calls.</summary>
		public int Completed { get; set; }

		/// <summary> Returns the number of abandoned calls.</summary>
		/// <summary> Sets the number of abandoned calls.</summary>
		public int Abandoned { get; set; }

		/// <summary> Returns the service level (in seconds) as defined by the servicelevel setting
		/// in queues.conf.
		/// </summary>
		/// <summary> Sets the service level.</summary>
		public int ServiceLevel { get; set; }

		/// <summary> Returns the ratio of calls answered within the specified service level per total completed
		/// calls (in percent).
		/// </summary>
		/// <summary> Sets the ratio of calls answered within the specified service level per total completed
		/// calls.
		/// </summary>
		public double ServiceLevelPerf { get; set; }

		/// <summary>
		/// Returns the weight of this queue.<br/>
		/// A queues can be assigned a 'weight' to ensure calls waiting in a 
		/// higher priority queue will deliver its calls first. Only delays 
		/// the lower weight queue's call if the member is also in the 
		/// higher weight queue.
		/// </summary>
		public int Weight { get; set; }


		public uint TalkTime { get; set; }

		public double ServiceLevelPerf2 { get; set; }
	}
}