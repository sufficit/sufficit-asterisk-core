using Sufficit.Asterisk;
using Sufficit.Asterisk.Manager;
using System;

namespace Sufficit.Asterisk.Manager.Events
{

    /// <summary>
    /// Raised when a request successfully authenticates with a service..<br />
    /// </summary>
    public class InvalidPasswordEvent : ManagerEvent
    {
        public Severity Severity { get; set; }
        public string AccountId { get; set; }
        public string RemoteAddress { get; set; }
        public string Challenge { get; set; }
        public string Service { get; set; }
    }
}