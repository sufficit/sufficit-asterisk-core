using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A PeerEntryEvent is triggered in response to a SIPPeersAction or SIPShowPeerAction and contains information about a peer.<br/>
	/// It is implemented in channels/chan_sip.c
	/// </summary>
	public class PeerEntryEvent : ResponseEvent, IKeyControl, IEventBase
	{
		[JsonIgnore]
		public string Key => "Event:PeerEntry";

		private string objectName;
		private string chanObjectType;
		private string ipAddress;
		private int ipPort;
		private bool dynamic;
		private bool natSupport;
		private bool videoSupport;
		private bool textSupport;
		private bool acl;
		private bool realtimedevice;

		/// <summary>
		/// For SIP peers this is "SIP".
		/// </summary>
		public AsteriskChannelProtocol ChannelType { get; set; }

		public string ObjectName
		{
			get { return this.objectName; }
			set { this.objectName = value; }
		}
		/// <summary>
		/// For SIP peers this is either "peer" or "user".
		/// </summary>
		public string ChanObjectType
		{
			get { return this.chanObjectType; }
			set { this.chanObjectType = value; }
		}
		/// <summary>
		/// Get/Set the IP address of the peer.
		/// </summary>
		public string IpAddress
		{
			get { return this.ipAddress; }
			set { this.ipAddress = value; }
		}
		public int IpPort
		{
			get { return this.ipPort; }
			set { this.ipPort = value; }
		}
		public bool Dynamic
		{
			get { return this.dynamic; }
			set { this.dynamic = value; }
		}
		public bool NatSupport
		{
			get { return this.natSupport; }
			set { this.natSupport = value; }
		}
		public bool VideoSupport
		{
			get { return this.videoSupport; }
			set { this.videoSupport = value; }
		}
		public bool TextSupport
		{
			get { return this.textSupport; }
			set { this.textSupport = value; }
		}
		public bool Acl
		{
			get { return this.acl; }
			set { this.acl = value; }
		}

		public string Status { get; set; }

		public bool RealtimeDevice
		{
			get { return this.realtimedevice; }
			set { this.realtimedevice = value; }
		}

		public PeerEntryEvent() { }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		public PeerEntryEvent(IManagerConnection source)
			: base(source)
		{
		}
	}
}