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
		/// <summary>
		/// Get/Set the Caller*ID of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		string? CallerIdNum { get; }

		/// <summary>
		/// Get/Set the Caller*ID Name of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		string? CallerIdName { get; }

		string? ConnectedLineNum { get; }
		string? ConnectedLineName { get; }

		string Language { get; }
		string Context { get; }
		string Exten { get; }
		string Priority { get; }

		string AccountCode { get; }
	}
}
