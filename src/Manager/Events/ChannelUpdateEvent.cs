using System;

namespace Sufficit.Asterisk.Manager.Events
{
    [Obsolete("removed on asterisk 12")]
    public class ChannelUpdateEvent : ManagerEvent
    {
        /// <summary>
        ///     Get/Set channel type
        ///     "SIP",
        ///     "IAX2",
        ///     "GTALK"
        /// </summary>
        public string ChannelType { get; set; } = string.Empty;

        public string SipCallId { get; set; } = string.Empty;

        public string SipFullContact { get; set; } = string.Empty;

        public string PeerName { get; set; } = string.Empty;

        public string IAX2CallnoLocal { get; set; } = string.Empty;

        public string IAX2CallnoRemote { get; set; } = string.Empty;

        public string IAX2Peer { get; set; } = string.Empty;

        public string GTalkSID { get; set; } = string.Empty;
    }
}