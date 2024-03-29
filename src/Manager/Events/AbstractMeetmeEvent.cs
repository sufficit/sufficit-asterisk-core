using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Abstract base class providing common properties for meet me (asterisk's conference system) events.
    /// </summary>
    public abstract class AbstractMeetmeEvent : ManagerEvent
    {
        /// <summary>
        ///     Get/Set the conference number.
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string Meetme { get; set; }
        /// <summary>
        ///     Get/Set the conference user number
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public int Usernum { get; set; }
    }
}