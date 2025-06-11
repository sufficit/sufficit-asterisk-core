using System;
namespace Sufficit.Asterisk.Manager
{
	/// <summary>
	/// An ManagerException is thrown when a Manager Error Response.
	/// </summary>
	public class AsteriskManagerException : Exception
	{
        /// <summary>
        /// Creates a new ManagerException with the given message.
        /// </summary>
        public AsteriskManagerException() : base() { }

        /// <summary>
        /// Creates a new ManagerException with the given message.
        /// </summary>
        /// <param name="message">message describing the manager exception</param>
        public AsteriskManagerException(string? message) : base(message) { }

        /// <summary>
        /// Creates a new ManagerException with the given message and cause.
        /// </summary>
        /// <param name="message">message describing the manager exception</param>
        /// <param name="inner">exception that caused the manager exception</param>
        public AsteriskManagerException(string? message, Exception inner) : base(message, inner) { }
    }
}