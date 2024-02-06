using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Sufficit.Asterisk.IO
{
    /// <summary>
    ///     Socket ending reason (disconnect, close, script, exception)
    /// </summary>
    [Flags]
    public enum AGISocketReason
    {
        [EnumMember(Value = "unknown")]
        UNKNOWN = 0,

        /// <summary>
        /// Indicates a normal ending execution
        /// </summary>
        [EnumMember(Value = "normal ending")]
        NORMALENDING = 1 << 200,

        /// <summary>
        ///     Not receiving any data, end of socket
        /// </summary>
        [Category("NormalEnding")]
        [EnumMember(Value = "not receiving anymore")]
        NOTRECEIVING = 1 << 201,

        /// <summary>
        ///     Last action for each script, closes the connection     
        /// </summary>
        /// <remarks>AsterNET.FastAGI.AGIConnectionHandler.Run(CancellationToken)</remarks>
        [Category("NormalEnding")]
        [EnumMember(Value = "script end")]
        SCRIPTEND = 1 << 202 | NORMALENDING,
    }
}
