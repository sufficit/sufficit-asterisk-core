using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An AgentCalledEvent is triggered when an agent is rung.<br />
    ///     To enable AgentCalledEvents you have to set eventwhencalled = yes in queues.conf.<br />
    ///     This event is implemented in apps/app_queue.c
    /// </summary>
    public class AgentCalledEvent : AbstractQueueAgentDestEvent
    {
        public string AgentName { get; set; } = string.Empty;

        public string AgentCalled { get; set; } = string.Empty;

        public string ChannelCalling { get; set; } = string.Empty;

        public string DestinationChannel { get; set; } = string.Empty;

        public string Extension { get; set; } = string.Empty;
    }
}