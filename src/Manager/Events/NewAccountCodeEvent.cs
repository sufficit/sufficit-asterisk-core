using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class NewAccountCodeEvent : ManagerEvent
    {
        public string AccountCode { get; set; }

        public string OldAccountCode { get; set; }
    }
}