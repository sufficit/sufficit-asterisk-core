using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public class CoreShowChannelEvent : ResponseEvent, IChannelInfoEvent
    {
        /// <inheritdoc cref="IChannelEvent.Channel"/>
		public string Channel { get; set; } = default!;

        /// <inheritdoc cref="IChannelEvent.UniqueId"/>
        public string UniqueId { get; set; } = default!;

        /// <inheritdoc cref="IChannelEvent.LinkedId"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? LinkedId { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.CallerIdNum"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? CallerIdNum { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.CallerIdName"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? CallerIdName { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.ConnectedLineNum"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ConnectedLineNum { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.ConnectedLineName"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ConnectedLineName { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.Language"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Language { get; set; } = default!;

        /// <inheritdoc cref="IChannelInfoEvent.Context"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Context { get; set; } = default!;

        /// <inheritdoc cref="IChannelInfoEvent.Exten"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Exten { get; set; } = default!;

        /// <inheritdoc cref="IChannelInfoEvent.Priority"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Priority { get; set; } = default!;

        /// <inheritdoc cref="IChannelInfoEvent.AccountCode"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? AccountCode { get; set; }

        /// <inheritdoc cref="IChannelStateEvent.ChannelState"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public AsteriskChannelState ChannelState { get; set; }

        /// <inheritdoc cref="IChannelStateEvent.ChannelStateDesc"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ChannelStateDesc { get; set; }



        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? BridgeId { get; set; }

        public string? Application { get; set; }
        public string? ApplicationData { get; set; }

        public TimeSpan? Duration { get; set; }
    }
}
