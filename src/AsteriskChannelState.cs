using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
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

        [EnumMember(Value = "Dialing Offhook")]
        DialingOffhook,

        [EnumMember(Value = "Pre-ring")]
        PreRing,

        Unknown,
    }
}
