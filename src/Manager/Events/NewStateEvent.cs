using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A NewStateEvent is triggered when the state of a channel has changed.<br/>
    /// It is implemented in channel.c
    /// </summary>
    /// <remarks>Manager: Newstate</remarks>
    public class NewStateEvent : AbstractChannelInfoEvent, IChannelEvent
    {

	}
}