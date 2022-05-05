using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A NewChannelEvent is triggered when a new channel is created.<br/>
	/// It is implemented in channel.c
	/// </summary>
	public class NewConnectedLine : AbstractChannelInfoEvent
	{
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Context { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Priority { get; set; }
	}
}