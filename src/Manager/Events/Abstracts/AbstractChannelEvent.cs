using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
	/// <summary>
	/// Abstract base class providing common properties for HangupEvent, NewChannelEvent and NewStateEvent.
	/// </summary>
	public abstract class AbstractChannelEvent : ManagerEventFromAsterisk, IChannelEvent
    {
        /// <inheritdoc cref="IChannelEvent.Channel"/>
		[JsonPropertyName("channel")]
        public string Channel { get; set; } = default!;

        /// <inheritdoc cref="IChannelEvent.UniqueId"/>
        [JsonPropertyName("uniqueid")]
        public string UniqueId { get; set; } = default!;

		/// <inheritdoc cref="IChannelEvent.LinkedId"/>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("linkedid")]
        public string? LinkedId { get; set; }
	}
}
