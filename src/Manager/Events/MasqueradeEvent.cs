using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    internal class MasqueradeEvent : ManagerEvent
    {
        public string Clone { get; set; } = string.Empty;

        public string CloneState { get; set; } = string.Empty;

        public string Original { get; set; } = string.Empty;

        public string OriginalState { get; set; } = string.Empty;
    }
}
