using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	
	/// <summary>
	/// A PeerStatusEvent is triggered when a SIP or IAX client attempts to registrer at this asterisk server.<br/>
	/// This event is implemented in channels/chan_iax2.c and channels/chan_sip.c
	/// </summary>
	public class PeerStatusEvent : ManagerEventFromAsterisk, IPeerStatusEvent
	{
		/// <inheritdoc cref="IPeerStatus.Peer"/>
		[JsonPropertyName("peer")]
		public string Peer { get; set; } = default!;

        /// <inheritdoc cref="IPeerStatus.PeerStatus"/>
        [JsonPropertyName("peerstatus")]
        public PeerStatus PeerStatus { get; set; }

        /// <inheritdoc cref="IPeerUnreachable.Cause"/>
        [JsonPropertyName("cause")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public PeerUnreachableCause? Cause { get; set; }

        /// <inheritdoc cref="IPeerStatusEvent.Time"/>
        [JsonPropertyName("time")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public int? Time { get; set; }

        /// <inheritdoc cref="IPeerStatusEvent.Address"/>
        [JsonPropertyName("address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Address { get; set; }

        [JsonPropertyName("channeltype")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? ChannelType { get; set; }
	}
}