using Sufficit.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A StatusCompleteEvent is triggered after the state of all channels has been reported in response
    /// to a StatusAction.
    /// </summary>
    /// <seealso cref="Manager.Action.StatusAction"/>
    /// <seealso cref="Manager.Event.StatusEvent"/>
    public class StatusCompleteEvent : ResponseEvent, IManagerEvent
	{
		public uint Items { get; set; }
        public string? EventList { get; set; }
        public uint ListItems { get; set; }
	}
}