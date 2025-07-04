namespace Sufficit.Asterisk.Manager.Action
{
    /// <summary>
    ///     The LoginAction authenticates the connection.<br />
    ///     A successful login is the precondition for sending any other action except
    ///     for the ChallengeAction.<br />
    ///     An unsuccessful login results in an ManagerError being received from the
    ///     server with a message set to "Authentication failed" and the socket being
    ///     closed by Asterisk.
    /// </summary>
    /// <seealso cref="Manager.Action.ChallengeAction" />
    /// <seealso cref="Manager.Response.ManagerError" />
    public class LoginAction : ManagerAction
    {
        /// <summary>
        ///     Creates a new LoginAction that performs a cleartext login.<br />
        ///     You should not use cleartext login if you are concerned about security and login with a password hash instead.
        /// </summary>
        /// <param name="username">the username as configured in Asterisk's manager.conf</param>
        /// <param name="secret">the user's password as configured in Asterisk's manager.conf</param>
        /// <seealso cref="Manager.Action.ChallengeAction" />
        public LoginAction(string username, string secret)
        {
            Username = username;
            Secret = secret;
        }

        /// <summary>
        ///     Creates a new LoginAction that performs a login via challenge/response.
        /// </summary>
        /// <param name="username">the username as configured in Asterisk's manager.conf</param>
        /// <param name="authType">
        ///     the digest alogrithm, must match the digest algorithm that was used with the corresponding
        ///     ChallengeAction.
        /// </param>
        /// <param name="key">the hash of the user's password and the challenge</param>
        public LoginAction(string username, string authType, string key)
        {
            Username = username;
            AuthType = authType;
            Key = key;
        }

        /// <summary>
        ///     Creates a new LoginAction that performs a login via challenge/response.
        /// </summary>
        /// <param name="username">the username as configured in Asterisk's manager.conf</param>
        /// <param name="authType">
        ///     the digest alogrithm, must match the digest algorithm that was used with the corresponding
        ///     ChallengeAction.
        /// </param>
        /// <param name="key">the hash of the user's password and the challenge</param>
        /// <param name="events">
        ///     the event mask.<br />
        ///     Set to "on" if all events should be send, "off" if not events should be sent
        ///     or a combination of "system", "call" and "log" (separated by ',') to specify what kind of events should be sent.
        /// </param>
        public LoginAction(string username, string authType, string key, string events)
        {
            Username = username;
            AuthType = authType;
            Key = key;
            Events = events;
        }

        /// <summary>
        ///     Get the name of this action, i.e. "Login".
        /// </summary>
        public override string Action => "Login";        

        /// <summary>
        ///     Get/Set the username as configured in asterik's manager.conf.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     Get/Set the secret to use when using cleartext login.<br />
        ///     The secret contains the user's password as configured in Asterisk's manager.conf.<br />
        ///     The secret and key properties are mutually exclusive.
        /// </summary>
        public string? Secret { get; set; }

        /// <summary>
        ///     Get/Set the digest alogrithm when using challenge/response.<br />
        ///     The digest algorithm is used to create the key based on the challenge and
        ///     the user's password.<br />
        ///     Currently Asterisk supports "plaintext" or "MD5".
        /// </summary>
        public string AuthType { get; set; } = "plaintext";

        /// <summary>
        ///     Key to use with MD5 authentication. To create the key, you must initialize a new MD5 hash, call the 'Challenge' AMI action, update the hash with the response, then update the hash with the secret as specified in manager.conf. The key value must be the final result of the hash as a 32 character lower-case hex string without any "0x" prepended.
        /// </summary>
        public string? Key { get; set; }

        /// <summary>
        ///     Get/Set the event mask.<br />
        ///     Set to "on" if all events should be send, "off" if not events should be sent or a combination of
        ///     "system", "call" and "log" (separated by ',') to specify what kind of events should be sent.
        /// </summary>
        public string Events { get; set; } = "off";
    }
}