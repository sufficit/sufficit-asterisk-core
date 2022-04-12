using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
    public enum AsteriskChannelState
    {
        Down,
        Rsrvd,
        OffHook,
        Dialing,
        Ring,
        Ringing,
        Up,
        Busy,
        DialingOffhook,
        PreRing,
        Unknown,
    }
}
