using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Events
{
    public enum PeerStatusEnum
    {
        Unknown,
        Unregistered,
        Lagged,
        Reachable,
        Unreachable,
        Rejected, // (IAX only)
        Registered
    }
}
