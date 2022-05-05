using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IPeerUnreachable : IPeerStatus
	{
		/// <summary>
		/// Returns the cause of a rejection or unregistration.<br/>
		/// For IAX peers this is set only if the status equals "Rejected".<br/>
		/// For SIP peers this is set if the status equals "Unregistered" and the peer was unregistered
		/// due to an expiration. In that case the cause is set to "Expired".
		/// </summary>
		/// <summary> Sets the cause of the rejection or unregistration.</summary>
		PeerUnreachableCause? Cause { get; }
	}
}
