using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An AgentCallbackLoginEvent is triggered when an agent is successfully logged in using AgentCallbackLogin.<br />
    ///     It is implemented in channels/chan_agent.c
    /// </summary>
    /// <seealso cref="Manager.Event.AgentCallbackLogoffEvent" />
    public class AgentCallbackLoginEvent : ManagerEvent
    {
        /// <summary>
        ///     Get/Set the name of the agent that logged in.
        /// </summary>
        public string Agent { get; set; } = string.Empty;

        public string LoginChan { get; set; } = string.Empty;
    }
}