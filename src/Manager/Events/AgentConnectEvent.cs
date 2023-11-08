using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An AgentConnectEvent is triggered when a caller is connected to an agent.
    /// </summary>
    public class AgentConnectEvent : AbstractQueueAgentDestEvent
    {
        /// <summary>
        ///     Get/Set the amount of time the caller was on hold.
        /// </summary>
        public long HoldTime { get; set; }

        /// <summary>
        ///     Get/Set bridged channel. <br />
        ///     Removed from Asterisk 12
        /// </summary>
        public string BridgedChannel { get; set; }

        /// <summary>
        ///     Get/Set the amount of time the caller was on ring.
        /// </summary>
        public long RingTime { get; set; }
    }
}