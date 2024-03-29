using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Abstract base class for several agent related events.
	/// </summary>
	public abstract class ConnectionStateEvent : ManagerEvent
	{
		/// <summary>
		/// Get/Set reconnect status.
		/// </summary>
		public bool Reconnect { get; set; }
	}
}
