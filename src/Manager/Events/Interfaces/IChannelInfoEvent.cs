using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Facility to Events Panel, 
	/// </summary>
    public interface IChannelInfoEvent : IChannelEvent, IChannelStateEvent
	{
		string? CallerIdNum { get; }
		string? CallerIdName { get; }

		string Language { get; }
		string Context { get; }
		string Exten { get; }
		string Priority { get; }
		string LinkedId { get; }
	}
}
