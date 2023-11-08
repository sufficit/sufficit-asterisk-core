using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class DTMFEvent : AbstractChannelInfoEvent
    {
        public string Direction { get; set; }

        public string Digit { get; set; }

        public bool Begin { get; set; }

        public bool End { get; set; }
    }
}