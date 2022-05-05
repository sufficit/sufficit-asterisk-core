using System;

namespace Sufficit.Asterisk.Manager.Events
{
    public static class EventsExtensions
    {
        public static PeerStatus GetPeerStatus(this PeerEntryEvent source)
        {
            var text = source.Status.Trim().ToLowerInvariant();
            if (text == "unknown") return PeerStatus.Unknown;
            if (text == "unmonitored") return PeerStatus.Unmonitored;
            if (text.StartsWith("ok")) return PeerStatus.Ok;

            return PeerStatus.Unknown;
        }
    }
}
