using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Events
{
    public interface PeerStatusEventInterface
    {
        AsteriskChannelProtocol Protocol { get; }

        string Peer { get; }

        PeerStatusEnum PeerStatus { get; }

        DateTime DateReceived { get; }

        string Address { get; }

        PeerStatusCauseEnum Cause { get; }

        int Time { get; }
    }
}
