using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A PeerEntryEvent is triggered in response to a SIPPeersAction or SIPShowPeerAction and contains information about a peer.<br/>
	/// It is implemented in channels/chan_sip.c
	/// </summary>
	public class PeerEntryEvent : ResponseEvent, IPeerStatus
	{
        #region IMPLEMENT INTERFACE PEER STATUS

        string IPeerStatus.Peer => $"{ChannelType.ToString().ToUpperInvariant()}/{ObjectName}";

		PeerStatus IPeerStatus.PeerStatus => this.GetPeerStatus();

        #endregion

        /// <summary>
        /// For SIP peers this is "SIP".
        /// </summary>
        public AsteriskChannelProtocol ChannelType { get; set; }

		public string ObjectName { get; set; }

		/// <summary>
		/// For SIP peers this is either "peer" or "user".
		/// </summary>
		public string ChanObjectType { get; set; }

		/// <summary>
		/// Get/Set the IP address of the peer.
		/// </summary>
		public string IpAddress { get; set; }
		public int IpPort { get; set; }
		public bool Dynamic { get; set; }
		public bool NatSupport { get; set; }
		public bool VideoSupport { get; set; }
		public bool TextSupport { get; set; }
		public bool Acl { get; set; }
		public string Status { get; set; }
		public bool RealtimeDevice { get; set; }
		public bool AutoForceRPort { get; set; }
		public bool ForceRPort { get; set; }
		public bool AutoComedia { get; set; }
		public bool Comedia { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string? Description { get; set; }

    }
}