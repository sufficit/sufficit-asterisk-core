using System;
using System.ComponentModel;
using System.Runtime.Serialization;

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
        NOTRECEIVING = 1 << 201 | NORMALENDING,

        /// <summary>
        /// Represents a state where the script has ended beacuse the socket resources have been disposed.
        /// </summary>
        /// <remarks>This enumeration value is categorized under "NormalEnding" and is serialized as
        /// "disposed". It combines the <see cref="NORMALENDING"/> flag with a unique bit-shifted value.</remarks>
        [Category("NormalEnding")]
        [EnumMember(Value = "disposed")]
        DISPOSED = 1 << 202 | NORMALENDING,

        /// <summary>
        ///     Underlaying socket was aborted, probably by a timeout or an exception
        /// </summary>
        [Category("NormalEnding")]
        [EnumMember(Value = "operation cancelled")]
        ABORTED = 1 << 203 | NORMALENDING,

        /// <summary>
        ///     A new connection was made, probably a timeout without any data
        /// </summary>
        [Category("NormalEnding")]
        [EnumMember(Value = "connection reseted")]
        RESETED = 1 << 204 | NORMALENDING,

        /// <summary>
        /// Represents a normal ending state where the operation was cancelled due to a token cancellation.
        /// </summary>
        /// <remarks>This value indicates that the operation was intentionally stopped as a result of a
        /// cancellation token being triggered. It combines the <see cref="NORMALENDING"/> flag with a unique identifier
        /// for the cancellation state.</remarks>
        [Category("NormalEnding")]
        [EnumMember(Value = "token cancelled")]
        CANCELLED = 1 << 205 | NORMALENDING
    }
}
