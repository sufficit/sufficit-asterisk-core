using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Ends the response to a PJSIPShowRegistrationsOutbound action.
    /// </summary>
    public class OutboundRegistrationDetailCompleteEvent : ResponseEvent, IManagerEvent
    {
        public string? EventList { get; set; }
        public uint ListItems { get; set; }
        public uint Registered { get; set; }
        public uint NotRegistered { get; set; }
    }
}
