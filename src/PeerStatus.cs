using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
    public enum PeerStatus
    {
        Unknown,
        Unregistered,
        Lagged,
        Reachable,
        Unreachable,
        Rejected, // (IAX only)
        Registered,
        Unmonitored,
        Ok
    }
}
