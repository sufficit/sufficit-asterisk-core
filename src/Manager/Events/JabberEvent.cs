using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class JabberEvent : ManagerEvent
    {
        public string Account { get; set; } = string.Empty;

        public string Packet { get; set; } = string.Empty;
    }
}
