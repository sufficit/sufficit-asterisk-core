namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    /// <summary>
    /// Raised when a DTMF digit on a channel.
    /// </summary>
    public abstract class DTMFEvent : AbstractChannelInfoEvent
    {
        /// <summary>
        /// Received | Sent
        /// </summary>
        public AsteriskDTMFDirection Direction { get; set; }

        /// <summary>
        ///     0-9, A-E, # or *
        /// </summary>
        public string Digit { get; set; } = default!;
    }
}