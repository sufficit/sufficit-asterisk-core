namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An AgentLoginEvent is triggered when an agent is successfully logged in using AgentLogin.<br />
    ///     It is implemented in channels/chan_agent.c
    /// </summary>
    /// <seealso cref="Manager.Event.AgentLogoffEvent" />
    public class AgentLoginEvent : ManagerEvent
    {
        /// <summary>
        ///     Get/Set the name of the agent that logged in.
        /// </summary>
        public string Agent { get; set; }

        public string LoginChan { get; set; }
    }
}