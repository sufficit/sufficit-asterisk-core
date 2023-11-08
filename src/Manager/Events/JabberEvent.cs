using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class JabberEvent : ManagerEvent
    {
        public string Account { get; set; }

        public string Packet { get; set; }
    }
}