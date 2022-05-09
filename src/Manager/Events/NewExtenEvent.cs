namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A NewExtenEvent is triggered when a channel is connected to a new extension.<br/>
	/// It is implemented in pbx.c
	/// </summary>
	public class NewExtenEvent : AbstractChannelInfoEvent
	{
		public string AppdEvent { get; set; }

		/// <summary>
		/// Get/Set the name of the application that is executed.
		/// </summary>
		public string Application { get; set; }

		/// <summary>
		/// Get/Set the parameters passed to the application that is executed. The parameters are separated by a '|' character.
		/// </summary>
		public string AppData { get; set; }

		/// <summary>
		/// Get/Set the extension.
		/// </summary>
		public string Extension { get; set; }		
	}
}