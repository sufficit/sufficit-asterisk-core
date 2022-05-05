namespace Sufficit.Asterisk.Manager.Events
{
    public class ModuleLoadReportEvent : ManagerEvent
    {
        public string ModuleLoadStatus { get; set; }

        public string ModuleSelection { get; set; }

        public int ModuleCount { get; set; }
    }
}