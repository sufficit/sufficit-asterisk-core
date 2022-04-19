using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// Abstract base class for events triggered in response to a ManagerAction.<br/>
	/// All ResponseEvents contain an additional action id property that links the
	/// event to the action that caused it.
	/// </summary>
	public abstract class ResponseEvent : IManagerEvent
	{
		#region IMPLEMENT INTERFACE PARSE SUPPORT

		public Dictionary<string, string> Attributes { get; set; }

		/// <summary>
		/// Unknown properties parser
		/// </summary>
		/// <param name="key">key name</param>
		/// <param name="value">key value</param>
		/// <returns>true - value parsed, false - can't parse value</returns>
		public virtual bool Parse(string key, string value)
		{
			if (Attributes == null)
			{
				Attributes = new Dictionary<string, string>();
			}

			if (Attributes.ContainsKey(key))
			{
				Attributes[key] += string.Concat(Common.LINE_SEPARATOR, value); // Key already presents, add with delimiter
			}
			else
			{
				Attributes.Add(key, value);
			}

			return true;
		}

		/// <summary>
		/// Unknown properties parser.
		/// </summary>
		/// <param name="attributes">dictionary</param>
		/// <returns>updated dictionary</returns>
		public virtual Dictionary<string, string> ParseSpecial(Dictionary<string, string> attributes)
		{
			return attributes;
		}

		#endregion

		#region IMPLEMENT INTERFACE MANAGER EVENT

		string IManagerEvent.Privilege => "system";

		public string Server { get; set; }

		public double Timestamp { get; set; }

		public string UniqueId { get; set; }

		[JsonIgnore]
		public IManagerConnection Source { get; set; }

		#endregion

		public virtual DateTime DateReceived { get; set; }

		public string Channel { get; set; }

		/// <summary>
		/// Get/Set the action id of the ManagerAction that caused this event.
		/// </summary>
		public string ActionId { get; set; }

		/// <summary>
		/// Get/Set the internal action id of the ManagerAction that caused this event.
		/// </summary>
		public string InternalActionId { get; set; }

		public ResponseEvent()
        {
			this.DateReceived = DateTime.Now;
		}

		public ResponseEvent(IManagerConnection connection) : this()
		{
			Source = connection;
		}
	}
}