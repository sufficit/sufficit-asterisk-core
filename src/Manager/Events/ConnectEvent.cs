using Sufficit.Asterisk.Manager;
using Sufficit.Asterisk.Manager.Events;
using System;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A ConnectEvent is triggered after successful login to the asterisk server.<br />
    ///     It is a pseudo event not directly related to an asterisk generated event.
    /// </summary>
    public class ConnectEvent : ConnectionStateEvent
    {
        /// <summary>
        ///     Get/Set the version of the protocol.
        /// </summary>
        public string ProtocolIdentifier { get; set; }
    }
}