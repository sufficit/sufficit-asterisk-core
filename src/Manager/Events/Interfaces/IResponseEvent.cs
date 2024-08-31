using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IResponseEvent : IManagerEvent
    {
		/// <summary>
		/// Get/Set the action id of the ManagerAction that caused this event.
		 /// </summary>
		string ActionId { get; set; }

		/// <summary>
		/// Get/Set the internal action id of the ManagerAction that caused this event.
		/// </summary>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		string? InternalActionId { get; set; }
	}
}
