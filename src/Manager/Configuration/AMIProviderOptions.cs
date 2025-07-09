using System;

namespace Sufficit.Asterisk.Manager
{   
    /// <summary>
    /// Configuration parameters for Asterisk Manager Interface Provider.
    /// Used for long-term, persistent connections to Asterisk servers.
    /// </summary>
    /// <remarks>
    /// AMIProviderOptions is designed for persistent, long-running connections that maintain
    /// event listeners and automatic reconnection. This differs from ManagerConnectionParameters
    /// which is intended for short-term, single-action connections.
    /// 
    /// Key differences:
    /// - AMIProvider: Long-term connection with event handling and auto-reconnection
    /// - ManagerConnection: Short-term connection for executing specific actions then disconnecting
    /// 
    /// Use AMIProvider when you need:
    /// - Continuous event monitoring from Asterisk
    /// - Automatic reconnection on connection loss
    /// - Persistent connection state management
    /// 
    /// Use ManagerConnection when you need:
    /// - Execute a command and disconnect
    /// - One-time operations
    /// - Manual connection lifecycle management
    /// 
    /// Example JSON configuration:
    /// <code>
    /// {
    ///   "AMIProviderOptions": [
    ///     {
    ///       "Enabled": true,
    ///       "Title": "Primary Asterisk Server",
    ///       "Address": "asterisk1.example.com",
    ///       "Port": 5038,
    ///       "Username": "manager",
    ///       "Password": "secret",
    ///       "KeepAlive": true,
    ///       "ReconnectRetryMax": 0,
    ///       "ReconnectIntervalMax": 30000,
    ///       "InitialRetry": {
    ///         "EnableInitialRetry": true,
    ///         "MaxInitialRetryAttempts": 0,
    ///         "InitialRetryDelayMs": 5000,
    ///         "MaxRetryDelayMs": 30000,
    ///         "DelayIncrementMs": 1000,
    ///         "StopOnAuthenticationFailure": true
    ///       }
    ///     }
    ///   ]
    /// }
    /// </code>
    /// </remarks>
    public class AMIProviderOptions : ManagerConnectionParameters
    {
        /// <summary>
        /// Title of default configuration section (appsettings.json)
        /// </summary>
        public const string SECTIONNAME = "AMIProviderOptions";

        /// <summary>
        /// Indicates whether this provider is enabled and should be used for connections.
        /// When false, the provider will be skipped during initialization.
        /// Default is true.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Friendly name/title for this provider instance.
        /// Used for logging and identification purposes.
        /// Default is "Untitled".
        /// </summary>
        public string Title { get; set; } = "Untitled";

        /// <summary>
        /// Alternative property name for Username to maintain backward compatibility.
        /// Maps directly to the base Username property.
        /// </summary>
        public string? User { get => base.Username; set => base.Username = value ?? string.Empty; }

        /// <summary>
        /// Configuration parameters for initial connection retry behavior.
        /// These settings control how the provider attempts to establish the first connection
        /// to the Asterisk server before the standard reconnection logic takes over.
        /// </summary>
        public InitialConnectionRetryParameters InitialRetry { get; set; } = new InitialConnectionRetryParameters();

        public override bool Equals(object? obj)
            => obj is AMIProviderOptions other && 
            other.Enabled == Enabled && 
            other.Title == Title && 
            other.InitialRetry.Equals(InitialRetry) &&
            base.Equals(obj);

        public override int GetHashCode()
            => (Enabled, Title, InitialRetry).GetHashCode() ^ base.GetHashCode();
    }
}
