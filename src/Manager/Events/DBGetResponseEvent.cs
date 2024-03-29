using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A DBGetResponseEvent is sent in response to a DBGetAction and contains the entry that was queried.<br />
    ///     Available since Asterisk 1.2
    /// </summary>
    /// <seealso cref="Manager.Action.DBGetAction" />
    public class DBGetResponseEvent : ResponseEvent
    {
        /// <summary>
        ///     Get/Set the family of the database entry that was queried.
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        ///     Get/Set the key of the database entry that was queried.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        ///     Get/Set the value of the database entry that was queried.
        /// </summary>
        public string Val { get; set; }
    }
}