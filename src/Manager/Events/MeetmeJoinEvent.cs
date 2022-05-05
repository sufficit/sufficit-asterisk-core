namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A MeetMeJoinEvent is triggered if a channel joins a meet me conference.<br />
    ///     It is implemented in apps/app_meetme.c
    /// </summary>
    public class MeetmeJoinEvent : AbstractMeetmeEvent
    {
        public string CallerIdNum { get; set; }

        public string CallerIdName { get; set; }
    }
}