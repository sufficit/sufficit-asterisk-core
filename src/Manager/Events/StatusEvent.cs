using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A StatusEvent is triggered for each active channel in response to a StatusAction.
	/// </summary>
	/// <seealso cref="Manager.Action.StatusAction" />
	public class StatusEvent : ResponseEvent, IChannelEvent, IManagerEvent, IChannelInfoEvent
	{
		#region IMPLEMENT INTERFACE CHANNEL EVENT

		public string Channel { get; set; }

		/// <summary>
		/// Get/Set Channel State
		/// </summary>
		public AsteriskChannelState ChannelState { get; set; }

		public string? ChannelStateDesc { get; set; }

		#endregion
		public string ConnectedLineNum { get; set; }
		public string ConnectedLineName { get; set; }
		public string Language { get; set; }
		public string Exten { get; set; }
		public string LinkedId { get; set; }
		public string Type { get; set; }
		public string EffectiveConnectedLineNum { get; set; }
		public string EffectiveConnectedLineName { get; set; }
		public string TimeToHangup { get; set; }
		public string Application { get; set; }
		public string Data { get; set; }
		public string NativeFormats { get; set; }
		public string ReadFormat { get; set; }
		public string WriteFormat { get; set; }
		public string CallGroup { get; set; }
		public string PickupGroup { get; set; }

		/// <summary> Returns the Caller*ID of this channel.</summary>
		/// <summary> Sets the Caller*ID of this channel.</summary>
		public string CallerId { get; set; }

		/// <summary> Returns the Caller*ID Name of this channel.</summary>
		/// <summary> Sets the Caller*ID Name of this channel.</summary>
		public string CallerIdName { get; set; }

		/// <summary> Returns the Caller*ID Number of this channel.</summary>
		/// <summary> Sets the Caller*ID Number of this channel.</summary>
		public string CallerIdNum { get; set; }

		/// <summary> Returns the account code of this channel.</summary>
		/// <summary> Sets the account code of this channel.</summary>
		public string Account { get; set; }
		public string AccountCode { get; set; }
		public string State { get; set; }
		public string Context { get; set; }
		public string Extension { get; set; }
		public string Priority { get; set; }

		/// <summary> Returns the number of elapsed seconds.</summary>
		/// <summary> Sets the number of elapsed seconds.</summary>
		public int Seconds { get; set; }

		/// <summary> Returns the name of the linked channel if this channel is bridged.</summary>
		/// <summary> Sets the name of the linked channel.</summary>
		public string Link { get; set; }

		public string UniqueId { get; set; }
		public string BridgeId { get; set; }
		public string ReadTrans { get; set; }
		public string WriteTrans { get; set; }
		public string? Dnid { get; set; }
	}
}