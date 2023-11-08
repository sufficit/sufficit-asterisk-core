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
        public string Reason { get; set; }


        public string channelstate { get; set; }
        public string channelstatedesc { get; set; }
        public string calleridnum { get; set; }
        public string calleridname { get; set; }
        public string connectedlinenum { get; set; }
        public string connectedlinename { get; set; }
        public string language { get; set; }
        public string context { get; set; }

        public string exten { get; set; }

        public string priority { get; set; }

        public string linkedid { get; set; }
    }
}