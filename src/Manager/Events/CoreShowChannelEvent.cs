using Sufficit.Asterisk;
using Sufficit.Asterisk.Manager.Events;
using Sufficit.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Manager.Events
{
    public class CoreShowChannelEvent : ResponseEvent, IChannelEvent
    {
        /// <inheritdoc cref="IChannelEvent.Channel"/>
		public string Channel { get; set; } = default!;

        /// <inheritdoc cref="IChannelEvent.UniqueId"/>
        public string UniqueId { get; set; } = default!;

        /// <inheritdoc cref="IChannelEvent.LinkedId"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? LinkedId { get; set; }

        public string? BridgeId { get; set; }
    }
}
