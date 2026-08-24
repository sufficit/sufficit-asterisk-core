using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Abstract base class for several call parking related events.
    /// </summary>
    public abstract class AbstractParkedCallEvent : ManagerEvent
    {
        /// <summary>
        ///     Get/Set the extension the channel is or was parked at.
        /// </summary>
        public string Exten { get; set; } = string.Empty;

        /// <summary>
        ///     Get/Set the Caller*ID number of the parked channel.
        /// </summary>
        public string CallerId { get; set; } = string.Empty;

        /// <summary>
        ///     Get/Set the Caller*ID number of the parked channel.
        /// </summary>
        public string CallerIdNum { get; set; } = string.Empty;

        /// <summary>
        ///     Get/Set the Caller*ID name of the parked channel.
        /// </summary>
        public string CallerIdName { get; set; } = string.Empty;
    }
}
