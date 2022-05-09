using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IQueueMemberStatusEvent
    {
        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Added in Asterisk 12
        /// </summary>
        string Interface { get; }

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        string MemberName { get; }

        string Membership { get; }

        uint Penalty { get; }

        uint CallsTaken { get; }

        /// <summary>
        /// The time this member last took a call, expressed in seconds since 00:00, Jan 1, 1970 UTC.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        int LastCall { get; }

        /// <summary>
        /// The numeric device state status of the queue member.<br/>
        /// <para>
        /// Valid status codes are:<br/>
        /// <list type="number" start="0">
        /// <item>AST_DEVICE_UNKNOWN</item>
        /// <item>AST_DEVICE_NOT_INUSE</item>
        /// <item>AST_DEVICE_INUSE</item>
        /// <item>AST_DEVICE_BUSY</item>
        /// <item>AST_DEVICE_INVALID</item>
        /// <item>AST_DEVICE_UNAVAILABLE</item>
        /// <item>AST_DEVICE_RINGING</item>
        /// <item>AST_DEVICE_RINGINUSE</item>
        /// <item>AST_DEVICE_ONHOLD</item>
        /// </list>
        /// </para>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        AsteriskDeviceStatus Status { get; }

        bool Paused { get; }
        bool InCall { get; }

        string PausedReason { get; }
    }
}
