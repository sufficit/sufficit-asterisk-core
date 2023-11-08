using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Interface for generic events
    /// </summary>
    public interface IManagerEvent 
    {
        /// <summary>
        /// Get/Set the AMI authorization class of this event.<br/>
        /// This is one or more of system, call, log, verbose, command, agent or user.
        /// Multiple privileges are separated by comma.<br/>
        /// Note: This property is not available from Asterisk 1.0 servers.
        /// </summary>
        Privilege Privilege { get; }

        /// <summary>
        /// Get/Set the point in time this event was received from the Asterisk server.<br/>
        /// Pseudo events that are not directly received from the asterisk server
        /// (for example ConnectEvent and DisconnectEvent) may return when they created.
        /// </summary>
        DateTime DateReceived { get; }
    }
}
