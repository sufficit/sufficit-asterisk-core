using Sufficit.Asterisk.Events;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public class AMIPeerStatusEvent : EventBase, PeerStatusEventInterface
    {
        [JsonIgnore]
        public override string Key => "Event:PeerStatus";

        public AsteriskChannelProtocol Protocol { get; set; }

        public string Peer { get; set; }

        public PeerStatusEnum PeerStatus { get; set; }

        public string Address { get; set; }

        public PeerStatusCauseEnum Cause { get; set; }

        public int Time { get; set; }
    }
}
