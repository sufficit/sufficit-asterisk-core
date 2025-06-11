using System;
namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    ///		An ManagerActionException is thrown when a Manager Action Error Response.
    /// </summary>
    public class AsteriskManagerActionException : AsteriskManagerException
    {
        public AsteriskManagerActionException(string? message) : base(message)
        {

        }
    }
}