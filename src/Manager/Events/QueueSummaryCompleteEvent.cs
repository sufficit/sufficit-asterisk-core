using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A QueueSummaryCompleteEvent is triggered after all queue summary data has been reported 
    /// in response to a QueueSummaryAction.
    /// Available since Asterisk 1.4
    /// </summary>
    /// <seealso cref="QueueSummaryEvent" />
    /// <seealso cref="Manager.Action.QueueSummaryAction" />
    public class QueueSummaryCompleteEvent : ResponseEvent
    {
        /// <summary>
        /// Gets or sets the number of queue summary events that were reported.
        /// </summary>
        public uint ListItems { get; set; }

        /// <summary>
        /// Gets or sets the event list type.
        /// </summary>
        public string? EventList { get; set; }
    }
}