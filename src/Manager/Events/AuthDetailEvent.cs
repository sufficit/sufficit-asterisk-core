using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised for each PJSIP auth object listed by PJSIP show actions (for example PJSIPShowRegistrationsOutbound).
    /// </summary>
    /// <remarks>
    /// Asterisk sends the auth secrets in this event. They are deliberately not mapped to properties, and having a
    /// known event class keeps them out of the unknown event diagnostics, which log raw attributes at debug level.
    /// </remarks>
    public class AuthDetailEvent : ResponseEvent, IManagerEvent
    {
        public string? ObjectType { get; set; }
        public string? ObjectName { get; set; }
        public string? Username { get; set; }
        public string? AuthType { get; set; }
        public string? Realm { get; set; }
        public string? EndpointName { get; set; }
    }
}
