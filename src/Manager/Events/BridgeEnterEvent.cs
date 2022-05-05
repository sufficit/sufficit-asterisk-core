using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class BridgeEnterEvent : AbstractBridgeActivityEvent
    {
        public string bridgevideosourcemode { get; set; }
        public string channel { get; set; }
        public string channelstatedesc { get; set; }
        public string uniqueid { get; set; }
        public string swapuniqueid { get; set; }
    }
}
