using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
	/// <summary>
	///     Abstract base class providing common properties for HangupEvent, NewChannelEvent and NewStateEvent.
	/// </summary>
	public abstract class AbstractChannelStateEvent : AbstractChannelEvent, IChannelEvent, IChannelStateEvent
	{
        /// <inheritdoc cref="IChannelStateEvent.ChannelState"/>
        [JsonPropertyName("channelstate")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AsteriskChannelState ChannelState { get; set; }

        /// <inheritdoc cref="IChannelStateEvent.ChannelStatedDesc"/>        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("channelstatedesc")]
        public string? ChannelStateDesc { get; set; }
    }
}
