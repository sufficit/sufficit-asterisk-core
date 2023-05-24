using Sufficit.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A PeerlistCompleteEvent is triggered after the details of all peers has been reported in response to an SIPPeersAction or SIPShowPeerAction.<br/>
    /// Available since Asterisk 1.2
    /// </summary>
    /// <seealso cref="Manager.Event.PeerEntryEvent"/>
    /// <seealso cref="Manager.Action.SIPPeersAction"/>
    /// <seealso cref="Manager.Action.SIPShowPeerAction"/>
    public class PeerlistCompleteEvent : ResponseEvent
	{

		/// <summary>
		/// Get/Set the number of PeerEvents that have been reported.</summary>
		public uint ListItems { get; set; }

		public string EventList { get; set; }
	}
}