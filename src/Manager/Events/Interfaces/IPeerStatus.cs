using Sufficit.Asterisk.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IPeerStatus
	{
		/// <summary>
		/// Returns the name of the peer that registered. The peer's name starts with "IAX2/" if it is an
		/// IAX client or "SIP/" if it is a SIP client. It is followed by the username that is used for
		/// registration.
		/// </summary>
		/// <summary> Sets the name of the peer that registered.</summary>
		string Peer { get; }

		/// <summary> Returns the registration state.<br/>
		/// This may be one of
		/// <ul>
		/// <li>Registered</li>
		/// <li>Unregistered</li>
		/// <li>Reachable</li>
		/// <li>Lagged</li>
		/// <li>Unreachable</li>
		/// <li>Rejected (IAX only)</li>
		/// </ul>
		/// </summary>
		/// <summary> Sets the registration state.</summary>
		PeerStatus PeerStatus { get; }		
	}
}