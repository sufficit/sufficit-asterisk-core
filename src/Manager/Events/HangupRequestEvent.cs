using Sufficit.Asterisk.Manager.Events;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A HangupRequestEvent is raised when a channel is hang up.<br/>
	/// </summary>
	public class HangupRequestEvent : AbstractChannelInfoEvent
	{		
		/// <summary>
		/// Get/Set the cause of the hangup.
		/// </summary>
		public int Cause { get; set; }
	}
}