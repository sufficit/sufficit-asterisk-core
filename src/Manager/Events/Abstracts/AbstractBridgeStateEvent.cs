using System;
using System.Collections.Generic;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// </summary>
	public abstract class AbstractBridgeStateEvent : ManagerEvent
	{
        public string BridgeUniqueId { get; set; }
        public string BridgeType { get; set; }
        public string BridgeTechnology { get; set; }
        public string BridgeCreator { get; set; }
        public string BridgeName { get; set; }
        public int BridgeNumChannels { get; set; }
	}
}
