using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A ZapShowChannelsCompleteEvent is triggered after the state of all zap channels has been reported
    /// in response to a ZapShowChannelsAction.
    /// </summary>
    /// <seealso cref="Manager.Action.ZapShowChannelsAction" />
    /// <seealso cref="Manager.Event.ZapShowChannelsEvent" />
    public class ZapShowChannelsCompleteEvent : ResponseEvent
	{

	}
}