using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A RegistrationsCompleteEvent is triggered after the state of all sip registrations has been reported in response
    /// to a SIPShowRegistryAction.
    /// </summary>
    public class RegistrationsCompleteEvent : ResponseEvent, IManagerEvent
	{
		public uint Items { get; set; }
        public string? EventList { get; set; }
        public uint ListItems { get; set; }
	}
}