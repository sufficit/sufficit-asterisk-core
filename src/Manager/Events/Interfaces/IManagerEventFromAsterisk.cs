using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IManagerEventFromAsterisk : IManagerEvent
    {
        /// <summary>
        /// Timestamp of the event on asterisk server <br />
        /// Use that on prefer to DateReceived <br />
        /// Can be null !, check before use
        /// </summary>
        double? Timestamp { get; }

        /// <summary>
        /// Asterisk system name that raised this event
        /// </summary>
        string? SystemName { get; }
    }
}
