using Sufficit.Asterisk.Manager.Events;
using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// An AgentDumpEvent is triggered when an agent dumps the caller while listening
	/// to the queue announcement.
	/// </summary>
	public class AgentDumpEvent : AbstractQueueAgentEvent
	{
	}
}