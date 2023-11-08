using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An AgentCallbackLogoffEvent is triggered when an agent that previously logged in using AgentLogin is logged of.
    ///     It is implemented in channels/chan_agent.c
    /// </summary>
    /// <seealso cref="Manager.Event.AgentLoginEvent" />
    public class AgentLogoffEvent : ManagerEvent
    {
        /// <summary>
        ///     Get/Set the name of the agent that logged off.
        /// </summary>
        public string Agent { get; set; }

        public string LoginTime { get; set; }
    }
}