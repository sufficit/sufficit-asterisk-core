using System;

namespace Sufficit.Asterisk.Manager.Events
{
	public class ShowDialPlanCompleteEvent : ManagerEvent
	{
        public string? EventList { get; set; }
		public int ListItems { get; set; }
        public int ListExtensions { get; set; }
        public int ListPriorities { get; set; }
        public int ListContexts { get; set; }
    }
}