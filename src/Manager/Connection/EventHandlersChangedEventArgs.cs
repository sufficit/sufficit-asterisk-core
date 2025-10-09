using System;

namespace Sufficit.Asterisk.Manager.Connection
{
    /// <summary>
    /// Event arguments for changes in event handlers in Asterisk Manager connections.
    /// Contains information about the current and previous event handler subscriptions.
    /// </summary>
    public class EventHandlersChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the current event subscriptions after the change.
        /// </summary>
        public IManagerEventSubscriptions Current { get; set; } = default!;

        /// <summary>
        /// Gets or sets the previous event subscriptions before the change.
        /// </summary>
        public IManagerEventSubscriptions? Previous { get; set; }
    }
}