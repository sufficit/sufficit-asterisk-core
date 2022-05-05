namespace Sufficit.Asterisk.Manager.Events
{
    public class ChannelReloadEvent : ManagerEvent
    {
        /// <summary>
        ///     For SIP peers this is "SIP".
        /// </summary>
        public string ChannelType { get; set; }

        /// <summary>
        ///     Get/Set the name of the channel.
        /// </summary>
        public string ReloadReason { get; set; }

        public int UserCount { get; set; }

        public int PeerCount { get; set; }

        public int RegistryCount { get; set; }
    }
}