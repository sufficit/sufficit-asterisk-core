using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Abstract base class providing common properties for HangupEvent, NewChannelEvent and NewStateEvent.
	/// </summary>
	public abstract class AbstractChannelEvent : ManagerEventFromAsterisk, IChannelEvent
    {
        /// <inheritdoc cref="IChannelEvent.Channel"/>
        public string Channel { get; set; }
    }
}
