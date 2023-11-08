using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IPeerStatusEvent : IPeerStatus, IPeerUnreachable
    {
        /// <summary>
        /// IP Address of that peer
        /// </summary>
        string? Address { get; }

        /// <summary>
		/// Returns the ping time of the client if status equals "Reachable" or "Lagged"; if the status
		/// equals "Unreachable" it returns how long the last response took (in ms) for IAX peers or -1
		/// for SIP peers.
		/// </summary>
        int? Time { get; }
    }
}