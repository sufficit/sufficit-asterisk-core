using Sufficit.Asterisk.Manager;
using System;
namespace Sufficit.Asterisk.IO
{
    /// <summary>
    /// An NotConnectedException is thrown when a send action fails due to a socket not connected.
    /// </summary>
    public class NotConnectedException : AsteriskManagerException
    {
        const string MESSAGE = "underlaying connection is not ready";
        public NotConnectedException(string? msg = null) : base(msg ?? MESSAGE)
        {
            
        }

        public NotConnectedException(string? msg, Exception ex) : base(msg ?? MESSAGE, ex)
        {

        }
    }
}