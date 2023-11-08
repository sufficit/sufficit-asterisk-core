using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A RenameEvent is triggered when the name of a channel is changed.<br/>
	/// It is implemented in channel.c
	/// </summary>
	public class RenameEvent : ManagerEvent
	{
		/// <summary>
		/// Get/Set the new name of the channel.
		/// </summary>
		public string? NewName { get; set; }

        /// <summary>
        /// Get/Set the old name of the channel.
        /// </summary>
        public string? OldName { get; set; }
    }
}