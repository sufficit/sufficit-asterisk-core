namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// An UnholdEvent is triggered by the SIP channel driver when a channel is no longer put on hold.<br/>
    /// It is implemented in channels/chan_sip.c.<br/>
    /// Available since Asterisk 1.2
    /// </summary>
    /// <seealso cref="Manager.Event.HoldEvent"/>
    public class UnholdEvent : AbstractChannelInfoEvent
    {

	}
}