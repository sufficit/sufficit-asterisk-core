namespace Sufficit.Asterisk.Manager.Events
{

    /// <summary>
    ///     Raised when a request fails an authentication check due to an invalid account ID.<br />
    /// </summary>
    public class InvalidAccountIDEvent : ManagerEvent
    {
        public string Status { get; set; }

        public string eventtv { get; set; }
        public string severity { get; set; }
        public string service { get; set; }
        public string eventversion { get; set; }
        public string accountid { get; set; }
        public string sessionid { get; set; }
        public string localaddress { get; set; }
        public string remoteaddress { get; set; }
        public string sessiontv { get; set; }
    }
}