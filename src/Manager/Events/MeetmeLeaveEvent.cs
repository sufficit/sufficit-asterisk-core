namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A MeetMeLeaveEvent is triggered if a channel leaves a meet me conference.<br />
    ///     It is implemented in apps/app_meetme.c
    /// </summary>
    public class MeetmeLeaveEvent : AbstractMeetmeEvent
    {
        public string CallerIdNum { get; set; }

        public string CallerIdName { get; set; }

        public long Duration { get; set; }
    }
}