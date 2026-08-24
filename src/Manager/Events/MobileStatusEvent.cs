using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class MobileStatusEvent : ManagerEvent
    {
        public string Status { get; set; } = string.Empty;

        public string Device { get; set; } = string.Empty;
    }
}
