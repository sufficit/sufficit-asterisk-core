namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a DTMF digit has ended on a channel.<br/>
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+ManagerEvent_DTMFEnd">https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+ManagerEvent_DTMFEnd</see>
    /// </summary>
    public class DTMFEndEvent : ManagerEvent
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



        //{"channel":"SIP/datora-0000674e","channelstate":"6","channelstatedesc":"Up","calleridnum":"552127672585","calleridname":"552127672585","connectedlinenum":"\u003Cunknown\u003E","connectedlinename":"\u003Cunknown\u003E","language":"pt_BR","context":"ivr-8","exten":"s","priority":"14","uniqueid":"1651500601.160655","linkedid":"1651500601.160655"}
    }
}
