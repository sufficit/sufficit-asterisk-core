namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A dial event is triggered whenever a phone attempts to dial someone.<br/>
	/// This event is implemented in apps/app_dial.c.<br/>
	/// Available since Asterisk 1.2.
	/// </summary>
	public class DialEvent : AbstractDestChannelEvent
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
	}
}