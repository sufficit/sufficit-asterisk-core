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
        public string Peer { get; set; }

		/// <inheritdoc cref="IPeerStatus.PeerStatus"/>
		public PeerStatus PeerStatus { get; set; }

		/// <inheritdoc cref="IPeerUnreachable.Cause"/>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public PeerUnreachableCause? Cause { get; set; }
				
		/// <inheritdoc cref="IPeerStatusEvent.Time"/>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public int? Time { get; set; }

		/// <inheritdoc cref="IPeerStatusEvent.Address"/>
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? Address { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
		public string? ChannelType { get; set; }
	}
}