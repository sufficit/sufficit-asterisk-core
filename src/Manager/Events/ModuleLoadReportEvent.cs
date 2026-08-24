using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class ModuleLoadReportEvent : ManagerEvent
    {
        public string ModuleLoadStatus { get; set; } = string.Empty;

        public string ModuleSelection { get; set; } = string.Empty;

        public int ModuleCount { get; set; }
    }
}
