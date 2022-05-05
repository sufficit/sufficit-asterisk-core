namespace Sufficit.Asterisk.Manager.Events
{
    public class MobileStatusEvent : ManagerEvent
    {
        public string Status { get; set; }

        public string Device { get; set; }
    }
}