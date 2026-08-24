using System;
using System.Collections.Generic;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
	/// <summary>
	/// </summary>
	public abstract class AbstractBridgeStateEvent : ManagerEvent
	{
        public string BridgeUniqueId { get; set; } = string.Empty;
        public string BridgeType { get; set; } = string.Empty;
        public string BridgeTechnology { get; set; } = string.Empty;
        public string BridgeCreator { get; set; } = string.Empty;
        public string BridgeName { get; set; } = string.Empty;
        public int BridgeNumChannels { get; set; }
	}
}
