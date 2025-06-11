using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a channel is hung up
    /// </summary>
    /// <seealso cref="Privilege.call" />
    /// <seealso cref="https://docs.asterisk.org/Latest_API/API_Documentation/AMI_Events/Hangup"/>
    public class HangupEvent : AbstractChannelInfoEvent
    {
        /// <summary>
        /// Get/Set the cause of the hangup.
        /// </summary>
        [JsonPropertyName("cause")]
        public int Cause { get; set; }

        /// <summary>
        /// Get/Set the textual representation of the hangup cause.
        /// </summary>
        [JsonPropertyName("causetxt")]
        public string CauseTxt { get; set; } = default!;

        #region OBSOLETE - NOT PRESENT ON 12+

        /*
         
        /// <inheritdoc cref="AsteriskChannelProtocol"/>
        [JsonPropertyName("channeltype")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public AsteriskChannelProtocol? ChannelType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("peer")]
        public string? Peer { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("peerstatus")]
        public string? PeerStatus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        */

        #endregion
    }
}