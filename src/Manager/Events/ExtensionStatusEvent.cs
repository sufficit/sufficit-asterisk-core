using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// An ExtensionStatusEvent is triggered when the state of an extension changes or in response to a <see cref="Manager.Action.ExtensionStateListAction"/>.<br/>
	/// It is implemented in manager.c
	/// </summary>
	public class ExtensionStatusEvent : ResponseEvent, IExtensionStatusEvent
	{
		string IEventBase.Key => "Event:ExtensionStatus";

		/// <summary>
		/// Get/Set the extension hint.
		/// </summary>
		[JsonPropertyName("hint")]
		public string Hint { get; set; } = default!;

        /// <summary>
        /// Get/Set the extension.
        /// </summary>
        [JsonPropertyName("exten")]
		public string Exten { get; set; } = default!;

        /// <summary>
        /// Get/Set the context of the extension.
        /// </summary>
        [JsonPropertyName("context")]
		public string Context { get; set; } = default!;

        /// <summary>
        /// Get/Set the state of the extension.
        /// </summary>
        [JsonPropertyName("status")]
		public ExtensionStatus Status { get; set; }

        [JsonPropertyName("statustext")]
        public string StatusText { get; set; } = default!;
	}
}