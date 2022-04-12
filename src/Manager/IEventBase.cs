using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager
{
    public interface IEventBase
    {
        string Key { get; }

        /// <summary>
        /// Get/Set the point in time this event was received from the Asterisk server.<br/>
        /// Pseudo events that are not directly received from the asterisk server
        /// (for example ConnectEvent and DisconnectEvent) may return null.
        /// </summary>
        DateTime DateReceived { get; }
    }
}
