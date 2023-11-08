using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised when a soft hangup is requested with a specific cause code
    /// </summary>
    public class SoftHangupRequestEvent : AbstractChannelStateEvent
    {
        [JsonPropertyName("calleridnum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? CallerIdNum { get; set; }

        [JsonPropertyName("calleridname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? CallerIdName { get; set; }

        [JsonPropertyName("connectedlinenum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ConnectedLineNum { get; set; }

        [JsonPropertyName("connectedlinename")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ConnectedLineName { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Language { get; set; }

        [JsonPropertyName("accountcode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? AccountCode { get; set; }

        [JsonPropertyName("context")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Context { get; set; }

        [JsonPropertyName("exten")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Exten { get; set; }

        [JsonPropertyName("priority")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Priority { get; set; }

        /// <summary>
        ///     A numeric cause code for why the channel was hung up
        /// </summary>
        [JsonPropertyName("cause")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public uint Cause { get; set; }
    }
}
