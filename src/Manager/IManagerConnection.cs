using Sufficit.Asterisk.IO;
using System;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Defines the contract for a connection to the Asterisk Manager Interface.
    /// This interface includes essential properties and methods for managing the connection lifecycle,
    /// sending actions, and handling responses/events.
    /// </summary>
    public interface IManagerConnection : ISocketStatus, IDisposable
    {       
        /// <summary>
        /// Registers a custom user event class for parsing specific user-defined events.
        /// </summary>
        /// <param name="userEventClass">The type of the user event to register.</param>
        void RegisterUserEventClass(Type userEventClass);

        /// <summary>
        /// Gets the version of the Asterisk system.
        /// </summary>
        AsteriskVersion? AsteriskVersion { get; }

        bool KeepAlive { get; }

        string Address { get; }

        bool IsDisposed { get; }
    }
}
