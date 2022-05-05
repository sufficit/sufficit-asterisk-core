using Sufficit.Asterisk;
using Sufficit.Asterisk.Events;
using Sufficit.Asterisk.Manager;

namespace Sufficit.Asterisk.Manager.Events
{

    /// <summary>
    /// Raised when a request successfully authenticates with a service..<br />
    /// </summary>
    public class SuccessfulAuthEvent : ManagerEvent, SuccessfulAuthEventInterface
    {
        public Severity Severity { get; set; }
        public string AccountId { get; set; }
        public string RemoteAddress { get; set; }
        public bool UsingPassword { get; set; }
        public string Service { get; set; }
    }
}