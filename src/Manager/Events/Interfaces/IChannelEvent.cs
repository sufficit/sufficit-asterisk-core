using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IChannelEvent
    {
        string Channel { get; }

        /// <summary>
        /// Unique id of this channel on this system, not multi server safe !
        /// </summary>
        string UniqueId { get; }

        /// <summary>
		///  Uniqueid of the oldest channel associated with this channel.
		/// </summary>
        string? LinkedId { get; }
    }
}
