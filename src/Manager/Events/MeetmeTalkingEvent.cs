namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A MeetMeTalkingEvent is triggered when a user starts talking in a meet me conference.
    /// </summary>
    public class MeetmeTalkingEvent : AbstractMeetmeEvent
    {
        public bool Status { get; set; }
    }
}