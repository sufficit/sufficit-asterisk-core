using System.Text;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Represents the parameters used to configure reconnection behavior for a connection.
    /// </summary>
    /// <remarks>This class provides settings to control how a connection attempts to reconnect after a
    /// failure. It includes options for enabling automatic reconnection, specifying retry counts, and defining
    /// intervals for reconnection attempts. These parameters allow fine-tuning of reconnection behavior to balance
    /// responsiveness and resource usage.</remarks>
    public class ReconnectorParameters
    {   
        /// <summary>
        /// Define se a conexão deve ser mantida viva e tentar reconectar automaticamente. O padrão é true.
        /// </summary>
        public bool KeepAlive { get; set; } = true;

        /// <summary>
        ///     Gets or sets the number of quick retry attempts to reconnect after a connection failure.
        /// </summary>
        public int ReconnectRetryFast { get; set; } = 5;

        /// <summary>
        /// Gets or sets the maximum number of retry attempts for reconnecting after a connection failure.
        /// </summary>
        /// <remarks>* 0 for keeps trying forever</remarks>
        public int ReconnectRetryMax { get; set; } = 0;

        /// <summary>
        /// Gets or sets the interval, in milliseconds, for fast reconnection attempts.
        /// </summary>
        public int ReconnectIntervalFast { get; set; } = 5000;

        /// <summary>
        /// Gets or sets the maximum interval, in milliseconds, between reconnection attempts.
        /// </summary>
        public int ReconnectIntervalMax { get; set; } = 30000;

        public override bool Equals(object? obj)
            => obj is ReconnectorParameters other &&
            other.KeepAlive == KeepAlive &&
            other.ReconnectRetryFast == ReconnectRetryFast &&
            other.ReconnectRetryMax == ReconnectRetryMax &&
            other.ReconnectIntervalFast == ReconnectIntervalFast &&
            other.ReconnectIntervalMax == ReconnectIntervalMax;

        public override int GetHashCode()
            => (KeepAlive, ReconnectRetryFast, ReconnectRetryMax, ReconnectIntervalFast, ReconnectIntervalMax).GetHashCode();
    }
}

