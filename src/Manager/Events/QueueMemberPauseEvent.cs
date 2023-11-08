using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised when a member is paused/unpaused in the queue.<br />
    /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
    /// </summary>
    public class QueueMemberPauseEvent : QueueMemberEvent
    {
        /// <summary>
        /// The reason a member was paused.
        /// </summary>
        public string Reason { get; set; }
	}
}