using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
    /// <summary>
    /// Status - Numerical value of the extension status. Extension status is determined by the combined device state of all items contained in the hint.
    /// </summary>
    [Flags]
    public enum ExtensionStatus
    {
        /// <summary>
        /// The extension was removed from the dialplan.
        /// </summary>
        REMOVED = -2,

        /// <summary>
        /// The extension's hint was removed from the dialplan.
        /// </summary>
        HINTREMOVED = -1,

        /// <summary>
        /// Idle - Related device(s) are in an idle state.
        /// </summary>
        IDLE = 0,

        /// <summary>
        /// InUse - Related device(s) are in active calls but may take more calls.
        /// </summary>
        INUSE = 1,

        /// <summary>
        /// Busy - Related device(s) are in active calls and may not take any more calls.
        /// </summary>
        BUSY = 2,

        /// <summary>
        /// Unavailable - Related device(s) are not reachable.
        /// </summary>
        UNAVAILABLE = 4,

        /// <summary>
        /// Ringing - Related device(s) are currently ringing.
        /// </summary>
        RINGING = 8,

        /// <summary>
        /// Hold - Related device(s) are currently on hold.
        /// </summary>
        HOLD = 16,
    }
}
