using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IChannelStateEvent : IChannelEvent
    {
        /// <summary>
        ///     Gets or sets the channel state.<br/>
        ///     A numeric code for the channel's current state, related to ChannelStateDesc
        /// </summary> 
        /// <remarks>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </remarks>
        AsteriskChannelState ChannelState { get; }

        /// <summary>
        ///     Gets or sets the channel state description.
        /// </summary>
        string? ChannelStateDesc { get; }
    }
}
