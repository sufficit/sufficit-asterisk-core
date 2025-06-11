using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	///		Facility to Events Panel
	/// </summary>
    public interface IChannelInfoEvent : IChannelEvent, IChannelStateEvent
	{
		/// <summary>
		///		Caller*ID of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		string? CallerIdNum { get; }

		/// <summary>
		///		Caller*ID Name of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		string? CallerIdName { get; }

		string? ConnectedLineNum { get; }
		string? ConnectedLineName { get; }

		string Language { get; }

        #region WHERE

        /// <summary>
        ///		Current dialplan context of the channel
        /// </summary>
        string Context { get; }

        /// <summary>
        ///		Current dialplan extension of the channel
        /// </summary>
        string Exten { get; }

        /// <summary>
        ///		Current dialplan priority of the channel
        /// </summary>
        string Priority { get; }

		#endregion
		/// <summary>
		///		User account code for the channel, if set, or null if not set.
		/// </summary>
		string? AccountCode { get; }
	}
}
