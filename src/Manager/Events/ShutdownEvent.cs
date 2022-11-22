namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A ShutdownEvent is triggered when the asterisk server is shut down or restarted.<br/>
	/// It is implemented in asterisk.c
	/// </summary>
	public class ShutdownEvent : ConnectionStateEvent
	{
		/// <summary>
		/// Get/Set the kind of shutdown or restart. Possible values are "Uncleanly" and "Cleanly". A
		/// shutdown is considered unclean if there are any active channels when the system is shut down.
		/// </summary>
		public string? Shutdown { get; set; }

        /// <summary>
        /// Get/Set true if the server has been restarted; false if it has been halted.
        /// </summary>
        public bool Restart { get; set; }

        public string? File { get; set; }
        public string? Func { get; set; }
        public int Line { get; set; }
        public int SequenceNumber { get; set; }
    }
}