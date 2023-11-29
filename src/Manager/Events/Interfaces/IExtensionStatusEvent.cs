using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IExtensionStatusEvent : IEventBase
    {
		/// <summary>
		/// Get/Set the extension hint.
		/// </summary>
		string Hint { get; }

		/// <summary>
		/// Get/Set the extension.
		/// </summary>
		string Exten { get; }

		/// <summary>
		/// Get/Set the context of the extension.
		/// </summary>
		string Context { get; }

		/// <summary>
		/// Get/Set the state of the extension.
		/// </summary>
		ExtensionStatus Status { get; }
	}
}
