using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sufficit.Asterisk.Manager
{
    [Flags]
    public enum Privilege
    {
        /// <summary>
        /// Local information about connection, not from asterisk, but from manager.
        /// ConnectionStateEvents
        /// </summary>
        [EnumMember(Value = "none")]
        none = 0,

        /// <summary>
        /// General information about the system and ability to run system management commands, such as Shutdown, Restart, and Reload
        /// </summary>
        [EnumMember(Value = "system")]
        system = 1 << 1,

        /// <summary>
        /// Information about channels and ability to set information in a running channel
        /// </summary>
        [EnumMember(Value = "call")]
        call = 1 << 2,

        /// <summary>
        /// Logging information. Read-only
        /// </summary>
        [EnumMember(Value = "log")]
        log = 1 << 3,

        /// <summary>
        /// Verbose information. Read-only
        /// </summary>
        [EnumMember(Value = "verbose")]
        verbose = 1 << 4,

        /// <summary>
        /// Information about queues and agents and the ability to add queue members to a queue
        /// </summary>
        [EnumMember(Value = "agent")]
        agent = 1 << 5,

        /// <summary>
        /// Permission to send and receive UserEvent
        /// </summary>
        [EnumMember(Value = "user")]
        user = 1 << 6,

        /// <summary>
        /// Ability to read and write configuration files
        /// </summary>
        [EnumMember(Value = "config")]
        config = 1 << 7,

        /// <summary>
        /// Permission to run CLI commands. Write-only
        /// </summary>
        [EnumMember(Value = "command")]
        command = 1 << 8,

        /// <summary>
        /// Receive DTMF events. Read-only
        /// </summary>
        [EnumMember(Value = "dtmf")]
        dtmf = 1 << 9,

        /// <summary>
        /// Ability to get information about the system
        /// </summary>
        [EnumMember(Value = "reporting")]
        reporting = 1 << 10,

        /// <summary>
        /// Output of cdr_manager, if loaded. Read-only
        /// </summary>
        [EnumMember(Value = "cdr")]
        cdr = 1 << 11,

        /// <summary>
        /// Receive NewExten and VarSet events. Read-only
        /// </summary>
        [EnumMember(Value = "dialplan")]
        dialplan = 1 << 12,

        /// <summary>
        /// Permission to originate new calls.Write-only
        /// </summary>
        [EnumMember(Value = "originate")]
        originate = 1 << 13,

        /// <summary>
        /// The item is associated with AGI execution
        /// </summary>
        [EnumMember(Value = "agi")]
        agi = 1 << 14,

        [EnumMember(Value = "cc")]
        cc = 1 << 15,

        [EnumMember(Value = "aoc")]
        aoc = 1 << 16,

        [EnumMember(Value = "test")]
        test = 1 << 17,

        [EnumMember(Value = "message")]
        message = 1 << 18,

        [EnumMember(Value = "security")]
        security = 1 << 19,

        /// <summary>
        /// Has on all scopes of privileges
        /// </summary>
        [EnumMember(Value = "all")]
        all = 1 << 20
    }
}
