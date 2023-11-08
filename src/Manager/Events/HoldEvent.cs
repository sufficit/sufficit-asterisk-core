using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A HoldEvent is triggered by the SIP channel driver when a channel is put on hold.<br />
    ///     It is implemented in channels/chan_sip.c.<br />
    ///     Available since Asterisk 1.2
    /// </summary>
    /// <seealso cref="Manager.Event.UnholdEvent" />
    public class HoldEvent : AbstractChannelInfoEvent
    {
        public string Status { get; set; }
    }
}