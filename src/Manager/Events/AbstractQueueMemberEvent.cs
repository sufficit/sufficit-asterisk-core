using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Abstract base class for several queue member related events.
    /// </summary>
    public abstract class AbstractQueueMemberEvent : QueueEvent, IQueueMemberEvent, IQueueMemberStatusEvent
    {
        /// <summary>
        /// Returns the name of the member's interface.<br />
        /// E.g. the channel name or agent group.<br />
        /// <b>Removed since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+13+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.<br/>
        /// <b>Replaced by : </b> <see cref="Interface"/> since <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Location { get; set; }

        /// <summary>
        /// The queue member's channel technology or location.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string Interface { get; set; }

        /// <summary>
        /// Channel technology or location from which to read device state changes.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string StateInterface { get; set; }

        /// <summary>
        /// The name of the queue member.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
		/// "dynamic" if the added member is a dynamic queue member,<br />
		/// "realtime" if the added member is a realtime queue member,<br />
		/// "static" if the added member is a static queue member.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string Membership { get; set; }

        /// <summary>
        /// The penalty associated with the queue member. When calls are distributed members with higher penalties are considered last.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public uint Penalty { get; set; }

        /// <summary>
        /// The number of calls this queue member has serviced.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public uint CallsTaken { get; set; }

        /// <summary>
        /// The time this member last took a call, expressed in seconds since 00:00, Jan 1, 1970 UTC.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public int LastCall { get; set; }

        /// <summary>
        /// When queue member is paused (not accepting calls).<br/>
        /// Evaluates <see langword="true"/> if this member has been paused,
        /// <see langword="false"/> if not.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public bool Paused { get; set; }

        /// <see cref="IQueueMemberStatusEvent.Status" />
        public AsteriskDeviceStatus Status { get; set; }

        /// <summary>
        /// Evaluates <see langword="true"/> if Ringinuse,
        /// <see langword="false"/> if not.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public bool Ringinuse { get; set; }

        /// <summary>
        /// Evaluates <see langword="true"/> if member is in call,
        /// <see langword="false"/> after LastCall time is updated.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+13+Documentation" target="_blank" alt="Asterisk 13 wiki docs">Asterisk 13</see>.
        /// </summary>
        public bool InCall { get; set; }

        /// <summary>
        /// If set when paused, the reason the queue member was paused.<br />
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+13+Documentation" target="_blank" alt="Asterisk 13 wiki docs">Asterisk 13</see>.
        /// </summary>
        public string PausedReason { get; set; }
    }
}