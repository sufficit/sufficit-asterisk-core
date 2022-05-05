using System;
using System.Collections.Generic;
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
        none = 0,

        /// <summary>
        /// General information about the system and ability to run system management commands, such as Shutdown, Restart, and Reload
        /// </summary>
        system = 1 << 1,

        /// <summary>
        /// Information about channels and ability to set information in a running channel
        /// </summary>
        call = 1 << 2,

        /// <summary>
        /// Logging information. Read-only
        /// </summary>
        log = 1 << 3,

        /// <summary>
        /// Verbose information. Read-only
        /// </summary>
        verbose = 1 << 4,

        /// <summary>
        /// Information about queues and agents and the ability to add queue members to a queue
        /// </summary>
        agent = 1 << 5,

        /// <summary>
        /// Permission to send and receive UserEvent
        /// </summary>
        user = 1 << 6,

        /// <summary>
        /// Ability to read and write configuration files
        /// </summary>
        config = 1 << 7,

        /// <summary>
        /// Permission to run CLI commands. Write-only
        /// </summary>
        command = 1 << 8,

        /// <summary>
        /// Receive DTMF events. Read-only
        /// </summary>
        dtmf = 1 << 9,

        /// <summary>
        /// Ability to get information about the system
        /// </summary>
        reporting = 1 << 10,

        /// <summary>
        /// Output of cdr_manager, if loaded. Read-only
        /// </summary>
        cdr = 1 << 11,

        /// <summary>
        /// Receive NewExten and VarSet events. Read-only
        /// </summary>
        dialplan = 1 << 12,

        /// <summary>
        /// Permission to originate new calls.Write-only
        /// </summary>
        originate = 1 << 13,

        /// <summary>
        /// The item is associated with AGI execution
        /// </summary>
        agi = 1 << 14,

        cc = 1 << 15,
        aoc = 1 << 16,
        test = 1 << 17,
        message = 1 << 18,
        security = 1 << 19,

        /// <summary>
        /// Has on all scopes of privileges
        /// </summary>
        all = 1 << 20
    }
}
