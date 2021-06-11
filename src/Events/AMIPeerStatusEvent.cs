using AsterNET.Manager.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.AsteriskManager.Events
{
    public class AMIPeerStatusEvent : PeerStatusEventInterface
    {
        public ChannelTypeEnum ChannelType { get; set; }

        public string Peer { get; set; }

        public PeerStatusEnum PeerStatus { get; set; }

        public DateTime DateReceived { get; set; }

        public string Address { get; set; }

        public PeerStatusCauseEnum Cause { get; set; }

        public int Time { get; set; }
    }
}
