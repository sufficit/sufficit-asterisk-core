using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a new channel is created
    /// </summary>
    /// <seealso cref="Privilege.call" />
    /// <seealso href="https://docs.asterisk.org/Latest_API/API_Documentation/AMI_Events/Newchannel"/>
    public class NewChannelEvent : AbstractChannelInfoEvent, IChannelEvent
    {

	}
}