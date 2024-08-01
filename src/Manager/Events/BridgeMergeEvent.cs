using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when two bridges are merged.
    /// </summary>
    public class BridgeMergeEvent : ManagerEventFromAsterisk
    {
        public string ToBridgeUniqueId { get; set; } = default!;
        public string ToBridgeType { get; set; } = default!;
        public string ToBridgeTechnology { get; set; } = default!;

        /// <summary>
        ///     Entity that created the bridge if applicable
        /// </summary>
        public string ToBridgeCreator { get; set; } = default!;

        /// <summary>
        ///     Name used to refer to the bridge by its BridgeCreator if applicable
        /// </summary>
        public string ToBridgeName { get; set; } = default!;
        public string ToBridgeNumChannels { get; set; } = default!;

        /// <summary>
        /// none <br />
        /// talker <br />
        /// single The video source mode for the bridge.
        /// </summary>
        public string ToBridgeVideoSourceMode { get; set; } = default!;
        public string? ToBridgeVideoSource { get; set; }


        public string FromBridgeUniqueId { get; set; } = default!;
        public string FromBridgeType { get; set; } = default!;
        public string FromBridgeTechnology { get; set; } = default!;

        /// <summary>
        ///     Entity that created the bridge if applicable
        /// </summary>
        public string FromBridgeCreator { get; set; } = default!;

        /// <summary>
        ///     Name used to refer to the bridge by its BridgeCreator if applicable
        /// </summary>
        public string FromBridgeName { get; set; } = default!;
        public string FromBridgeNumChannels { get; set; } = default!;

        /// <summary>
        /// none <br />
        /// talker <br />
        /// single The video source mode for the bridge.
        /// </summary>
        public string FromBridgeVideoSourceMode { get; set; } = default!;
        public string? FromBridgeVideoSource { get; set; }
    }
}
