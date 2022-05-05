using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class BridgeLeaveEvent : AbstractBridgeActivityEvent
    {
        public string Channel { get; set; }

        public string ChannelStateDesc { get; set; }

        public string UniqueId { get; set; }
    }
}
