using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when music on hold has stopped on a channel.<br />
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_MusicOnHoldStop">https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_MusicOnHoldStop</see>
    /// </summary>
    public class MusicOnHoldStopEvent : AbstractChannelStateEvent
    {
        /// <summary>
        ///     Gets or sets the Caller*ID number.
        /// </summary>
        public string CallerIDNum { get; set; } = default!;

        /// <summary>
        ///     Gets or sets the Caller*ID name.
        /// </summary>
        public string CallerIDName { get; set; } = default!;

        /// <summary>
        ///     Gets or sets the connected line number.
        /// </summary>
        public string ConnectedLineNum { get; set; } = default!;

        /// <summary>
        ///     Gets or sets the connected line name.
        /// </summary>
        public string ConnectedLineName { get; set; } = default!;

        /// <summary>
        ///     Gets or sets the language.
        /// </summary>
        public string Language { get; set; } = default!;

        /// <summary>
        ///     Gets or sets the account code.
        /// </summary>
        public string? AccountCode { get; set; }

        /// <summary>
        ///     Gets or sets the context.
        /// </summary>
        public string Context { get; set; } = default!;

        /// <summary>
        ///     Gets or sets the exten.
        /// </summary>
        public string Exten { get; set; } = default!;

        /// <summary>
        ///     Gets or sets the priority.
        /// </summary>
        public string Priority { get; set; } = default!;
    }
}
