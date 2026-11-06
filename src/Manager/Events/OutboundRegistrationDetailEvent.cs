using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised for each PJSIP outbound registration in response to a PJSIPShowRegistrationsOutbound action.
    /// </summary>
    /// <remarks>
    /// <see cref="ClientUri"/> carries the registered user, for example "sip:552125429488@187.60.60.161:5060".
    /// <see cref="Status"/> is the runtime state ("Registered", "Unregistered", "Rejected", ...).
    /// </remarks>
    public class OutboundRegistrationDetailEvent : ResponseEvent, IManagerEvent
    {
        public string? ObjectType { get; set; }
        public string? ObjectName { get; set; }
        public string? Status { get; set; }
        public long? NextReg { get; set; }
        public string? ServerUri { get; set; }
        public string? ClientUri { get; set; }
        public string? ContactUser { get; set; }
        public string? Transport { get; set; }
        public string? OutboundProxy { get; set; }
        public string? OutboundAuth { get; set; }
        public string? Endpoint { get; set; }
        public string? Line { get; set; }
        public int? Expiration { get; set; }
        public int? RetryInterval { get; set; }
        public int? MaxRetries { get; set; }
    }
}
