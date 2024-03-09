using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a DTMF digit has ended on a channel.<br/>
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+ManagerEvent_DTMFEnd">https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+ManagerEvent_DTMFEnd</see>
    /// </summary>
    public class DTMFEndEvent : AbstractChannelInfoEvent
    {
        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the digit.
        /// </summary>
        public string Digit { get; set; }

        /// <summary>
        /// Gets or sets the duration ms.
        /// </summary>
        public int DurationMs { get; set; }
    }
}
