using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
	/// <summary>
	///     Abstract base class providing common properties for HangupEvent, NewChannelEvent and NewStateEvent.
	/// </summary>
	public abstract class AbstractChannelInfoEvent : AbstractChannelStateEvent, IChannelInfoEvent, IChannelStateEvent
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("language")]
        public string Language { get; set; } = default!;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("exten")]
        public string Exten { get; set; } = default!;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("context")]
        public string Context { get; set; } = default!;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("priority")]
        public string Priority { get; set; } = default!;

        /// <inheritdoc cref="IChannelInfoEvent.CallerIdNum"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		[JsonPropertyName("calleridnum")]
		public string? CallerIdNum { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.CallerIdName"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("calleridname")] 
        public string? CallerIdName { get; set; }
               
        /// <summary>
        /// Get/Set channel AccountCode
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("accountcode")]
        public string? AccountCode { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.ConnectedLineNum"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("connectedlinenum")]
        public string? ConnectedLineNum { get; set; }

        /// <inheritdoc cref="IChannelInfoEvent.ConnectedLineName"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("connectedlinename")]
        public string? ConnectedLineName { get; set; }

        #region OBSOLETE - NOT PRESENT ON 12+

        /*
         
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
        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("server")]
        public string? Server { get; set; }

        */

        #endregion
    }
}
