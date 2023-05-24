using System;
using System.Collections.Generic;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A BridgeEvent is triggered when a link between two voice
	/// channels is established ("Link") or discontinued ("Unlink").
	/// As of Asterisk 1.6 the Bridge event is reported directly by Asterisk.
	/// Asterisk versions up to 1.4 report individual events: LinkEvent and UnlinkEvent.
	/// For maximum compatibily do not use the Link and Unlink events in your code.
	/// Just use the Bridge event and check for isLink() and isUnlink().
	/// </summary>
	public class BridgeEvent : ManagerEvent, IParseSupport
	{
		public enum BridgeStates
		{
			Unknown,
			BRIDGE_STATE_LINK,
			BRIDGE_STATE_UNLINK
		}

		public enum BridgeTypes
		{
			Unknown,
			/// <summary> A channel.c bridge </summary>
			BRIDGE_TYPE_CORE,
			/// <summary> An RTP peer-2-peer bridge (NAT support only). </summary>
			BRIDGE_TYPE_RTP_DIRECT,
			/// <summary> An RTP native bridge. </summary>
			BRIDGE_TYPE_RTP_NATIVE,
			/// <summary> A remote (re-invite) bridge </summary>
			BRIDGE_TYPE_RTP_REMOTE
		}

		internal BridgeStates bridgeState;
		internal bool islink;
		internal bool isunlink;


		#region ParseSpecial(Dictionary<string, string> attributes)
		/// <summary>
		/// Unknown properties parser
		/// </summary>
		/// <param name="attributes">dictionary</param>
		/// <returns>updated dictionary</returns>
		public Dictionary<string, string> ParseSpecial(Dictionary<string, string>? attributes)
		{
			if (attributes == null)
			{
				// returning empty dictionary to avoid errors
				return new Dictionary<string, string>();
			}

			var updated = new Dictionary<string,string>(attributes.Count);
			foreach(KeyValuePair<string, string> pair in attributes)
			{
				string value = pair.Value.ToLowerInvariant();
				switch (pair.Key.ToLowerInvariant())
				{
					case "bridgestate":
						switch(value)
						{
							case "link":
								this.BridgeState = BridgeStates.BRIDGE_STATE_LINK;
								break;
							case "unlink":
								this.BridgeState = BridgeStates.BRIDGE_STATE_UNLINK;
								break;
						}
						break;

					case "bridgetype":
						switch (value)
						{
							case "rtp-native":
								this.BridgeType = BridgeTypes.BRIDGE_TYPE_RTP_NATIVE;
								break;
							case "rtp-direct":
								this.BridgeType = BridgeTypes.BRIDGE_TYPE_RTP_DIRECT;
								break;
							case "rtp-remote":
								this.BridgeType = BridgeTypes.BRIDGE_TYPE_RTP_REMOTE;
								break;
							case "core":
								this.BridgeType = BridgeTypes.BRIDGE_TYPE_CORE;
								break;
						}
						break;

					default:
						updated.Add(pair.Key, pair.Value);
						break;
				}
			}

			return updated;
		}

		#region Parse(string key, string value) 

		/// <summary>
		///     Unknown properties parser
		/// </summary>
		/// <param name="key">key name</param>
		/// <param name="value">key value</param>
		/// <returns>true - value parsed, false - can't parse value</returns>
		public virtual void Parse(string key, string value)
		{
			if (Attributes == null)
				Attributes = new Dictionary<string, string>();

			if (Attributes.ContainsKey(key))
				// Key already presents, add with delimiter
				Attributes[key] += string.Concat(Common.LINE_SEPARATOR, value);
			else
				Attributes.Add(key, value);
		}

		public object GetSetter() => this;

		public Dictionary<string, string>? Attributes { get; internal set; }

		#endregion

		#endregion

		public string? Response { get; set; }

		public string? Reason { get; set; }

        /// <summary>
        /// Link if the two channels have been linked,
        /// Unlink if they have been unlinked.
        /// </summary>
        public BridgeStates BridgeState { get; set; }
        public BridgeTypes BridgeType { get; set; }
        public string? Channel1 { get; set; }
        public string? Channel2 { get; set; }
        public string? UniqueId1 { get; set; }
        public string? UniqueId2 { get; set; }
        public string? CallerId1 { get; set; }
        public string? CallerId2 { get; set; }
    }
}
