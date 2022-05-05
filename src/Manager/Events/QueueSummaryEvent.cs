namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class QueueSummaryEvent : ManagerEvent
    {
        /// <summary>
        /// Queue name
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        /// Logged operators count in queue
        /// </summary>
        public int LoggedIn { get; set; }

        /// <summary>
        /// Available operators in queue
        /// </summary>
        public int Available { get; set; }

        /// <summary>
        /// Calls count
        /// </summary>
        public int Callers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int HoldTime { get; set; }

        /// <summary>
        /// Total talk time
        /// </summary>
        public int TalkTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int LongestHoldTime { get; set; }
    }
}
