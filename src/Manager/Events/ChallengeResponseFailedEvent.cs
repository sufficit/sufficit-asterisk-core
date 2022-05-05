namespace Sufficit.Asterisk.Manager.Events
{

    /// <summary>
    ///     Raised when a request's attempt to authenticate has been challenged, and the request failed the authentication challenge.<br />
    /// </summary>
    public class ChallengeResponseFailedEvent : ManagerEvent
    {

        public string Status { get; set; }
    }
}
