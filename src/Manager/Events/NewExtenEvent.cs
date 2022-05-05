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
		/// Get/Set the name of the context of the connected extension.
		/// </summary>
		public string Context { get; set; }

		/// <summary>
		/// Get/Set the extension.
		/// </summary>
		public string Extension { get; set; }

		/// <summary>
		/// Get/Set the priority.
		/// </summary>
		public int Priority { get; set; }

		//:{"channel":"SIP/datora-00006713","channelstate":"6","channelstatedesc":"Up","calleridnum":"5521981122623","calleridname":"5521981122623","connectedlinenum":"\u003Cunknown\u003E","connectedlinename":"\u003Cunknown\u003E","language":"pt_BR","exten":"s","uniqueid":"1651499126.160106","linkedid":"1651499126.160106"}}
	}
}