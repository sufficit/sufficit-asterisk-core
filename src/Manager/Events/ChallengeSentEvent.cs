namespace Sufficit.Asterisk.Manager.Events
{

    /// <summary>
    ///     Raised when an Asterisk service sends an authentication challenge to a request..<br />
    /// </summary>
    public class ChallengeSentEvent : ManagerEvent
    {
        public string Status { get; set; }
    }
}