namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An AgentCalledEvent is triggered when an agent is rung.<br />
    ///     To enable AgentCalledEvents you have to set eventwhencalled = yes in queues.conf.<br />
    ///     This event is implemented in apps/app_queue.c
    /// </summary>
    public class AgentCalledEvent : AbstractQueueAgentDestEvent
    {
        public string AgentName { get; set; }

        public string AgentCalled { get; set; }

        public string ChannelCalling { get; set; }

        public string DestinationChannel { get; set; }

        public string Extension { get; set; }
    }
}