using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sufficit.Asterisk.IO
{
    public enum AGIDisconnectReason
    {
        [EnumMember(Value = "unknown")]
        UNKNOWN = 0,

        /// <summary>
        ///     Normal ending, not receiving any data, end of socket
        /// </summary>
        [EnumMember(Value = "not receiving anymore")]
        NOTRECEIVING = 1,
    }
}
