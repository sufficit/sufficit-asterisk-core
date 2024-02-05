using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An AgentCompleteEvent is triggered when at the end of a call if the caller was connected to an agent.
    /// </summary>
    public class AgentCompleteEvent : AbstractQueueAgentDestEvent
    {

        /// <summary>
        ///     Get/Set the amount of time the caller was on hold.
        /// </summary>
        public long HoldTime { get; set; }

        /// <summary>
        ///     Get/Set the amount of time the caller talked to the agent.
        /// </summary>
        public long TalkTime { get; set; }

        /// <summary>
        ///     Get/Set if the agent or the caller terminated the call.
        /// </summary>
        public string Reason { get; set; } = default!;
    }
}