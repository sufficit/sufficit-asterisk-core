using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Configuration parameters for initial connection retry behavior in AMI providers.
    /// These parameters control how the system attempts to establish the first connection
    /// before the main reconnection logic takes over.
    /// </summary>
    /// <remarks>
    /// Initial connection retry is different from standard reconnection:
    /// - Initial retry happens when trying to establish the first connection to Asterisk
    /// - Standard reconnection happens after a successful connection is lost
    /// - Initial retry uses progressive delay increase to avoid overwhelming the server
    /// 
    /// Example JSON configuration:
    /// <code>
    /// {
    ///   "AMIProviderOptions": {
    ///     "Address": "asterisk.example.com",
    ///     "Username": "manager",
    ///     "Password": "secret",
    ///     "InitialRetry": {
    ///       "EnableInitialRetry": true,
    ///       "MaxInitialRetryAttempts": 0,
    ///       "InitialRetryDelayMs": 5000,
    ///       "MaxRetryDelayMs": 30000,
    ///       "DelayIncrementMs": 1000,
    ///       "StopOnAuthenticationFailure": true
    ///     }
    ///   }
    /// }
    /// </code>
    /// </remarks>
    public class InitialConnectionRetryParameters
    {
        /// <summary>
        /// Gets or sets whether initial connection retry is enabled.
        /// When true, the system will retry initial connections indefinitely until successful.
        /// When false, connection failure will stop retry attempts.
        /// Default is true.
        /// </summary>
        public bool EnableInitialRetry { get; set; } = true;

        /// <summary>
        /// Gets or sets the maximum number of initial connection retry attempts.
        /// Set to 0 for unlimited retry attempts.
        /// Default is 0 (unlimited).
        /// </summary>
        /// <remarks>
        /// This only applies to initial connection attempts. Once connected,
        /// the standard reconnection parameters take over.
        /// </remarks>
        public int MaxInitialRetryAttempts { get; set; } = 0;

        /// <summary>
        /// Gets or sets the initial delay in milliseconds before the first retry attempt.
        /// Default is 5000ms (5 seconds).
        /// </summary>
        public int InitialRetryDelayMs { get; set; } = 5000;

        /// <summary>
        /// Gets or sets the maximum delay in milliseconds between retry attempts.
        /// The delay will not exceed this value even with progressive increases.
        /// Default is 30000ms (30 seconds).
        /// </summary>
        public int MaxRetryDelayMs { get; set; } = 30000;

        /// <summary>
        /// Gets or sets the delay increment in milliseconds for each failed attempt.
        /// The delay increases by this amount after each failure up to MaxRetryDelayMs.
        /// Default is 1000ms (1 second).
        /// </summary>
        /// <remarks>
        /// Example: InitialRetryDelayMs=5000, DelayIncrementMs=1000
        /// Attempt 1: 5s delay, Attempt 2: 6s delay, Attempt 3: 7s delay, etc.
        /// </remarks>
        public int DelayIncrementMs { get; set; } = 1000;

        /// <summary>
        /// Gets or sets whether authentication failures should stop retry attempts.
        /// When true, authentication errors will stop retrying.
        /// When false, all errors (including auth) will be retried.
        /// Default is true (stop on auth failures).
        /// </summary>
        public bool StopOnAuthenticationFailure { get; set; } = true;

        public override bool Equals(object? obj)
            => obj is InitialConnectionRetryParameters other &&
            other.EnableInitialRetry == EnableInitialRetry &&
            other.MaxInitialRetryAttempts == MaxInitialRetryAttempts &&
            other.InitialRetryDelayMs == InitialRetryDelayMs &&
            other.MaxRetryDelayMs == MaxRetryDelayMs &&
            other.DelayIncrementMs == DelayIncrementMs &&
            other.StopOnAuthenticationFailure == StopOnAuthenticationFailure;

        public override int GetHashCode()
            => (EnableInitialRetry, MaxInitialRetryAttempts, InitialRetryDelayMs,
                MaxRetryDelayMs, DelayIncrementMs, StopOnAuthenticationFailure).GetHashCode();
    }
}
