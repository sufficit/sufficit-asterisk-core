using AsterNET.Manager;
using AsterNET.Manager.Event;

namespace Sufficit.AsteriskManager.Events
{
    public class AMISuccessfulAuthEvent : SuccessfulAuthEventInterface
    {
        public SeverityEnum Severity { get; set; }

        public string AccountId { get; set; }

        public string RemoteAddress { get; set; }

        public bool UsingPassword { get; set; }
    }
}
