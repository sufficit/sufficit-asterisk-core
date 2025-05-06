using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A HangupRequestEvent is raised when a channel is hang up.<br/>
	/// </summary>
	public class HangupRequestEvent : AbstractChannelInfoEvent
	{		
		/// <summary>
		/// Get/Set the cause of the hangup.
		/// </summary>
		public int Cause { get; set; }

        /// <summary>
        ///     <para>A description of why the channel was hung up.</para>
        /// </summary>
		/// <example>"Normal Clearing", "User Busy", "No Answer", etc.</example>
		/// <since><version>12.0.0</version></since>
        [JsonPropertyName("causetxt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? CauseTxt { get; set; }
    }
}