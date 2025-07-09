using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Interface for Asterisk Manager providers that handle individual AMI connections.
    /// Provides contract for connection lifecycle management and provider state control.
    /// </summary>
    /// <remarks>
    /// This interface defines the core functionality for AMI providers:
    /// - Provider state control (enabled/disabled)
    /// - Graceful disconnection and cleanup
    /// - Provider identification and configuration access
    /// - Basic lifecycle management
    /// - Connection management capabilities
    /// 
    /// Implementations should support:
    /// - Temporary connections (connect, execute, disconnect)
    /// - Persistent connections (connect once, keep alive)
    /// - Proper async disposal patterns
    /// - Thread-safe operations
    /// - Configuration-based connection parameters
    /// </remarks>
    public interface IAsteriskManagerProvider : IDisposable, IAsyncDisposable
    {
        /// <summary>
        /// Human-readable title/name for this provider instance.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Indicates whether the provider is currently enabled and operational.
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// Current active connection to the Asterisk server, if any.
        /// Returns null if no connection is established or connection is disposed.
        /// </summary>
        IManagerConnection? Connection { get; }

        /// <summary>
        /// Establishes a connection to the Asterisk server with default keep-alive settings.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token for the operation</param>
        /// <returns>Active IManagerConnection ready for use</returns>
        /// <exception cref="InvalidOperationException">Thrown when connection fails due to authentication or server issues</exception>
        /// <exception cref="OperationCanceledException">Thrown when operation is cancelled</exception>
        Task<IManagerConnection> ConnectAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Establishes a connection to the Asterisk server with specified keep-alive behavior.
        /// </summary>
        /// <param name="keepAlive">
        /// Whether to maintain persistent connection (true) or allow automatic disconnect (false).
        /// When null, uses the provider's default configuration.
        /// </param>
        /// <param name="cancellationToken">Cancellation token for the operation</param>
        /// <returns>Active IManagerConnection ready for use</returns>
        /// <exception cref="InvalidOperationException">Thrown when connection fails due to authentication or server issues</exception>
        /// <exception cref="OperationCanceledException">Thrown when operation is cancelled</exception>
        Task<IManagerConnection> ConnectAsync(bool? keepAlive = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a valid, ready-to-use connection to the Asterisk server.
        /// This method ensures the connection is established and authenticated.
        /// Primarily used for internal operations and advanced scenarios.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token for the operation</param>
        /// <returns>Valid IManagerConnection ready for immediate use</returns>
        /// <exception cref="InvalidOperationException">Thrown when connection cannot be established</exception>
        /// <exception cref="OperationCanceledException">Thrown when operation is cancelled</exception>
        ValueTask<IManagerConnection> GetValidConnection(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gracefully disconnects from the Asterisk server and cleans up resources.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token for the operation</param>
        /// <returns>Task representing the disconnection operation</returns>
        Task DisconnectAsync(CancellationToken cancellationToken = default);
    }
}
