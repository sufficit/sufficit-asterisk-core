using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Abstract base class providing common properties for HangupEvent, NewChannelEvent and NewStateEvent.
	/// </summary>
	public abstract class AbstractChannelStateEvent : ManagerEventFromAsterisk, IChannelEvent, IChannelStateEvent
    {
        /// <inheritdoc cref="IChannelEvent.Channel"/>
        public string Channel { get; set; }

        /// <inheritdoc cref="IChannelEvent.ChannelState"/>
        public AsteriskChannelState ChannelState { get; set; }

        /// <inheritdoc cref="IChannelEvent.ChannelStatedDesc"/>        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ChannelStateDesc { get; set; }
    }
}
