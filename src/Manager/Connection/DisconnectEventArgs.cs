using System;

namespace Sufficit.Asterisk.Manager.Connection
{
    /// <summary>
    /// Event arguments for disconnection events in Asterisk Manager connections.
    /// Contains information about the cause and nature of the disconnection.
    /// </summary>
    public class DisconnectEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the cause or reason for the disconnection.
        /// This typically contains a descriptive message about what triggered the disconnection.
        /// </summary>
        public string Cause { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether the disconnection is permanent.
        /// When true, indicates that reconnection should not be attempted automatically.
        /// When false, indicates that the disconnection is temporary and reconnection may be attempted.
        /// </summary>
        public bool IsPermanent { get; set; }
    }
}