using Sufficit.Asterisk.IO;
using Sufficit.Asterisk.Manager.Action;
using Sufficit.Asterisk.Manager.Connection;
using Sufficit.Asterisk.Manager.Events;
using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        /// Replaces the current event subscription system with a new one.
        /// </summary>
        /// <param name="events">The new event subscription system to use.</param>
        /// <param name="disposable">Whether the previous event system should be disposed.</param>
        void Use(IManagerEventSubscriptions events, bool disposable = false);

        /// <summary>
        /// Event triggered when the connection to the Asterisk server is lost or disconnected.
        /// Provides information about the cause and nature of the disconnection.
        /// </summary>
        event EventHandler<DisconnectEventArgs>? OnDisconnected;

        /// <summary>
        /// Gets the version of the Asterisk system.
        /// </summary>
        AsteriskVersion? AsteriskVersion { get; }

        /// <summary>
        /// Gets a value indicating whether the connection should be kept alive.
        /// </summary>
        bool KeepAlive { get; }

        /// <summary>
        /// Gets the address of the Asterisk server.
        /// </summary>
        string Address { get; }

        /// <summary>
        /// Gets a value indicating whether this instance has been disposed.
        /// </summary>
        bool IsDisposed { get; }

        /// <summary>
        /// Gets a value indicating whether the connection is authenticated with the Asterisk server.
        /// </summary>
        bool IsAuthenticated { get; }

        /// <summary>
        /// Gets the socket encoding used for communication.
        /// </summary>
        Encoding SocketEncoding { get; }

        /// <summary>
        /// Gets the event management system for this connection.
        /// </summary>
        IManagerEventSubscriptions Events { get; }

        /// <summary>
        /// Gets the array of characters used as delimiters for variable parsing.
        /// </summary>
        char[] VarDelimiters { get; }

        /// <summary>
        /// Asynchronously logs into the Asterisk Manager Interface.
        /// </summary>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous login operation.</returns>
        /// <exception cref="AuthenticationFailedException">Thrown when authentication fails.</exception>
        /// <exception cref="NotConnectedException">Thrown when not connected to the server.</exception>
        Task Login(CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously logs off from the Asterisk Manager Interface.
        /// </summary>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous logoff operation.</returns>
        Task LogOff(CancellationToken cancellationToken);

        /// <summary>
        /// Sends a specified manager action to the server and asynchronously waits for a response.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response expected from the server. Must derive from <see cref="ManagerResponseEvent"/>.</typeparam>
        /// <param name="action">The manager action to be sent. This parameter cannot be <see langword="null"/>.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response of type <typeparamref name="TResponse"/>.</returns>
        /// <exception cref="NotConnectedException">Thrown when not connected to the server.</exception>
        /// <exception cref="ArgumentNullException">Thrown when action is null.</exception>
        Task<TResponse> SendActionAsync<TResponse>(ManagerAction action, CancellationToken cancellationToken) where TResponse : ManagerResponseEvent;

        /// <summary>
        /// Sends a manager action to the server and asynchronously waits for a response.
        /// </summary>
        /// <param name="action">The manager action to be sent. This parameter cannot be <see langword="null"/>.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
        /// <exception cref="NotConnectedException">Thrown when not connected to the server.</exception>
        /// <exception cref="ArgumentNullException">Thrown when action is null.</exception>
        Task<ManagerResponseEvent> SendActionAsync(ManagerAction action, CancellationToken cancellationToken);

        /// <summary>
        /// Sends a manager action of the specified type to the server and asynchronously waits for a response.
        /// </summary>
        /// <typeparam name="TAction">The type of the action to create and send. Must have a parameterless constructor.</typeparam>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
        /// <exception cref="NotConnectedException">Thrown when not connected to the server.</exception>
        Task<ManagerResponseEvent> SendActionAsync<TAction>(CancellationToken cancellationToken) where TAction : ManagerAction, new();
    }
}
