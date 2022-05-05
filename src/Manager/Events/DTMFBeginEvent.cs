namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a DTMF digit has started on a channel.<br/>
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+ManagerEvent_DTMFBegin">https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+ManagerEvent_DTMFBegin</see>
    /// </summary>
    public class DTMFBeginEvent : ManagerEvent
    {
        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the digit.
        /// </summary>
        public string Digit { get; set; }
    }
}
