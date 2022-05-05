using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Raised when a Queue member's status has changed
	/// </summary>
	public class QueueMemberStatusEvent : AbstractQueueMemberEvent
	{
		public uint LastPause { get; set; }
		public uint WrapUpTime { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public int? LoginTime { get; set; }
	}
}
