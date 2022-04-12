using Sufficit.Asterisk.Events;

namespace Sufficit.Asterisk.Manager.Events
{
    public class AMISuccessfulAuthEvent : SuccessfulAuthEventInterface
    {
        public Severity Severity { get; set; }

        public string AccountId { get; set; }

        public string RemoteAddress { get; set; }

        public bool UsingPassword { get; set; }
    }
}
