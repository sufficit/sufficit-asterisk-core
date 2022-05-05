namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A dial event is triggered whenever a phone attempts to dial someone.<br/>
	/// This event is implemented in apps/app_dial.c.<br/>
	/// Available since Asterisk 1.2.
	/// </summary>
	public class DialStateEvent : AbstractChannelInfoEvent
	{
		public string DialString { get; set; }
		public string SubEvent { get; set; }
		public string DialStatus { get; set; }
		/// <summary>
		/// Returns the name of the source channel.
		/// </summary>
		public string Src { get; set; }
		/// <summary>
		/// Get/Set the name of the destination channel.
		/// </summary>
		public string Destination { get; set; }
		/// <summary>
		/// Get/Set the unique ID of the source channel.
		/// </summary>
		public string SrcUniqueId { get; set; }
		/// <summary>
		/// Get/Set the unique ID of the distination channel.
		/// </summary>
		public string DestUniqueId { get; set; }

		public string DestChannel { get; set; }

		public string DestChannelState { get; set; }

		public string DestChannelStateDesc { get; set; }
		public string DestCallerIdNum { get; set; }
		public string DestCallerIdName { get; set; }
		public string DestConnectedLineNum { get; set; }
		public string DestConnectedLineName { get; set; }
		public string DestLanguage { get; set; }
		public string DestContext { get; set; }
		public string DestExten { get; set; }
		public string DestPriority { get; set; }
		public string DestLinkedId { get; set; }

		public string Context { get; set; }
		public string Priority { get; set; }
	}
}