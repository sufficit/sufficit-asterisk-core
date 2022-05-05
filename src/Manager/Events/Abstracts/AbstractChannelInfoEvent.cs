using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Abstract base class providing common properties for HangupEvent, NewChannelEvent and NewStateEvent.
	/// </summary>
	public abstract class AbstractChannelInfoEvent : AbstractChannelStateEvent, IChannelInfoEvent
	{
		public string UniqueId { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? LinkedId { get; set; }

		/// OLD CLASS

		/// <summary>
		/// Get/Set the Caller*ID of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? CallerId { get; set; }

		/// <summary>
		/// Get/Set the Caller*ID of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		public string CallerIdNum { get; set; }

		/// <summary>
		/// Get/Set the Caller*ID Name of the channel if set or &lt;unknown&gt; if none has been set.
		/// </summary>
		public string CallerIdName { get; set; }

		/// <summary>
		/// Get/Set the (new) state of the channel.<br/>
		/// The following states are used:<br/>
		/// <ul>
		/// <li>Down</li>
		/// <li>OffHook</li>
		/// <li>Dialing</li>
		/// <li>Ring</li>
		/// <li>Ringing</li>
		/// <li>Up</li>
		/// <li>Busy</li>
		/// </ul>
		/// </summary>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? State { get; set; }

		/// <summary>
		/// Get/Set channel AccountCode
		/// </summary>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? AccountCode { get; set; }

		public string ConnectedLineNum { get; set; }

		public string ConnectedLineName { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Server { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Language { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Exten { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Context { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Priority { get; set; }
	}
}
