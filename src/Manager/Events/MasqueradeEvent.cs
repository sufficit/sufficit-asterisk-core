using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    internal class MasqueradeEvent : ManagerEvent
    {
        public string Clone { get; set; }

        public string CloneState { get; set; }

        public string Original { get; set; }

        public string OriginalState { get; set; }
    }
}