using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Description("Dialing Offhook")]
        DialingOffhook,

        [Description("Pre-ring")]
        PreRing,

        Unknown,
    }
}
