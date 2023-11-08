using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A NewChannelEvent is triggered when a new channel is created.<br/>
	/// It is implemented in channel.c
	/// </summary>
	public class NewConnectedLine : AbstractChannelInfoEvent
	{

	}
}