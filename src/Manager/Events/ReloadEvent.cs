namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A ReloadEvent is triggerd when the reload console command is executed or the asterisk server is started.<br/>
	/// It is implemented in manager.c
	/// </summary>
	public class ReloadEvent : ConnectionStateEvent
	{
		/// <summary>Reload event status.</summary>
		public string? Status { get; set; }

		/// <summary> Returns
		/// "Manager"
		/// "Enum"
		/// "DNSmgr"
		/// "CDR"
		/// </summary>
		public string? Module { get; set; }

        /// <summary> Returns
        /// "Reload Requested",
        /// "ENUM reload Requested",
        /// "DNSmgr reload Requested",
        /// "CDR subsystem reload requested"
        /// .</summary>
        public string? Message { get; set; }
    }
}