using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A QueueMemberEvent is triggered in response to a QueueStatusAction and contains information about a member of a queue.<br/>
	/// It is implemented in apps/app_queue.c
	/// </summary>
	/// <seealso cref="Manager.Action.QueueStatusAction" />
	public class QueueMemberEvent : QueueEvent, IResponseEvent
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
		/// Get/Set the name of the queue member.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Get/Set the name of the queue member.
		/// </summary>
		//public string MemberName { get; set; }

		/// <summary>
		/// Get/Set the name of the member's interface.<br/>
		/// E.g. the channel name or agent group.
		/// </summary>
		public string Location { get; set; }
		/// <summary>
		/// Get/Set value if this member has been dynamically added by the QueueAdd command
		/// (in the dialplan or via the Manager API) or if this member is has been
		/// statically defined in queues.conf.
		/// "dynamic" if the added member is a dynamic queue member, "static" if the added member is a static queue member.
		/// </summary>
		public string Membership { get; set; }
		/// <summary>
		/// Get/Set the penalty for the added member. When calls are distributed members with higher penalties are considered last.
		/// </summary>
		public int Penalty { get; set; }
		/// <summary>
		/// Get/Set the number of calls answered by the member.
		/// </summary>
		public int CallsTaken { get; set; }
		/// <summary>
		/// Get/Set the time (in seconds since 01/01/1970) the last successful call answered by the added member was hungup.
		/// </summary>
		public long LastCall { get; set; }
		/// <summary>
		/// Get/Set the status of this queue member.<br/>
		/// Available since Asterisk 1.2<br/>
		/// Valid status codes are:
		/// <dl>
		/// <dt>AST_DEVICE_UNKNOWN (0)</dt>
		/// <dd>Queue member is available</dd>
		/// <dt>AST_DEVICE_NOT_INUSE (1)</dt>
		/// <dd>?</dd>
		/// <dt>AST_DEVICE_INUSE (2)</dt>
		/// <dd>?</dd>
		/// <dt>AST_DEVICE_BUSY (3)</dt>
		/// <dd>?</dd>
		/// <dt>AST_DEVICE_INVALID (4)</dt>
		/// <dd>?</dd>
		/// <dt>AST_DEVICE_UNAVAILABLE (5)</dt>
		/// <dd>?</dd>
		/// </dl>
		/// </summary>
		public int Status { get; set; }
		/// <summary>
		/// Is this queue member paused (not accepting calls)?<br/>
		/// Available since Asterisk 1.2.<br/>
		/// true if this member has been paused,
		/// false if not
		/// </summary>
		public bool Paused { get; set; }
		/// <summary>
		/// Is this queue member in call??<br/>
		/// Available since Asterisk 12.<br/>
		/// true if this member is in call,
		/// false if not
		/// </summary>
		public bool InCall { get; set; }

		/// <summary>
		/// Paused reason if the queue member is paused
		/// </summary>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? PausedReason { get; set; }

		public string StateInterface { get; set; }

		public uint LastPause { get; set; }

		public uint WrapUpTime { get; set; }
	}
}