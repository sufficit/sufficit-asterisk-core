using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a queue member is notified of a caller in the queue and fails to answer.<br/>
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_AgentRingNoAnswer">https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_AgentRingNoAnswer</see>
    /// </summary>
    public class AgentRingNoAnswerEvent : AbstractQueueAgentDestEvent
    {
        /// <summary>
        ///     Get/Set the amount of time the caller was on ring.
        /// </summary>
        public long RingTime { get; set; }

        #region [Obsolete("Removed in asterisk 12")]

        /// <summary>
        ///     Gets or sets the name of the agent.
        /// </summary>
        [Obsolete("Removed in asterisk 12")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? AgentName { get; set; }

        /// <summary>
        ///     Gets or sets the agent called.
        /// </summary>
        [Obsolete("Removed in asterisk 12")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? AgentCalled { get; set; }

        /// <summary>
        ///     Gets or sets the channel calling.
        /// </summary>
        [Obsolete("Removed in asterisk 12")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? ChannelCalling { get; set; }

        /// <summary>
        ///     Gets or sets the destination channel.
        /// </summary>]
        [Obsolete("Removed in asterisk 12")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? DestinationChannel { get; set; }

        /// <summary>
        ///     Gets or sets the extension.
        /// </summary>
        [Obsolete("Removed in asterisk 12")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Extension { get; set; }

        #endregion
    }
}
