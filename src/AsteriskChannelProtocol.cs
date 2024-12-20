using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sufficit.Asterisk
{
    /// <summary>
    /// Communications Protocols <br />
    /// Channel Techs and Voice Protocols
    /// </summary>
    public enum AsteriskChannelProtocol
    {
        [EnumMember(Value = "")]
        UNKNOWN,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "SIP")]
        SIP,

        [EnumMember(Value = "PJSIP")]
        PJSIP,

        [EnumMember(Value = "IAX")]
        IAX,

        [EnumMember(Value = "IAX2")]
        IAX2,
    }
}
