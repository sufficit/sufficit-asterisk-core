using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
	/// <summary>
	/// Abstract base class providing common properties for all queue events.
	/// </summary>
	public abstract class QueueEvent : ManagerEventFromAsterisk, IQueueEvent
	{
        /// <inheritdoc cref="IQueueEvent.Queue"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonPropertyName("queue")]
        public string Queue { get; set; } = default!;
    }
}