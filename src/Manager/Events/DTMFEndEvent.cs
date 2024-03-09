using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a DTMF digit has ended on a channel.<br/>
    ///     See <see target="_blank" href="https://docs.asterisk.org/Asterisk_16_Documentation/API_Documentation/AMI_Events/DTMFEnd/">Asterisk 16 Documentation</see>
    /// </summary>
    public class DTMFEndEvent : DTMFEvent
    {
        /// <summary>
        /// Gets or sets the duration ms.
        /// </summary>
        public int DurationMs { get; set; }
    }
}
