using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// An ExtensionStatusEvent is triggered when the state of an extension changes.<br/>
	/// It is implemented in manager.c
	/// </summary>
	public class AMIExtensionStatusEvent : EventBase , IExtensionStatusEvent
	{
		[JsonIgnore]
		public override string Key => "Event:ExtensionStatus";

		/// <summary>
		/// Get/Set the extension hint.
		/// </summary>
		public string Hint { get; set; }

		/// <summary>
		/// Get/Set the extension.
		/// </summary>
		public string Exten { get; set; }

		/// <summary>
		/// Get/Set the context of the extension.
		/// </summary>
		public string Context { get; set; }

		/// <summary>
		/// Get/Set the state of the extension.
		/// </summary>
		public ExtensionStatus Status { get; set; }
	}
}