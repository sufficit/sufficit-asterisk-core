using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// An ExtensionStatusEvent is triggered when the state of an extension changes.<br/>
	/// It is implemented in manager.c
	/// </summary>
	public class ExtensionStatusEvent : ManagerEvent, IExtensionStatusEvent
	{
		string IEventBase.Key => "Event:ExtensionStatus";

		public DateTime Received { get => this.DateReceived; }

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