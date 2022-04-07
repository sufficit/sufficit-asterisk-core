using AsterNET.Manager.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class AMIQueueCallerAbandonEvent : QueueCallerAbandonEventInterface
    {
        public string Queue { get; set; }

        public int Position { get; set; }

        public int HoldTime { get; set; }

        public string CallerIdNum { get; set; }

        public string Channel { get; set; }
    }
}
