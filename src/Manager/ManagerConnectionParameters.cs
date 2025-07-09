using System.Text;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Encapsulates all parameters necessary to establish a connection to the Asterisk Manager Interface (AMI).
    /// Designed for short-term, single-action connections where you execute commands and disconnect.
    /// </summary>
    /// <remarks>
    /// ManagerConnectionParameters is intended for single-use or short-term connections where you:
    /// - Connect to Asterisk
    /// - Execute one or more specific actions/commands
    /// - Disconnect manually
    /// 
    /// This differs from AMIProviderOptions which is designed for persistent, long-running connections
    /// that maintain event listeners and automatic reconnection capabilities.
    /// 
    /// Use ManagerConnectionParameters when you need:
    /// - Execute specific commands and disconnect
    /// - Manual connection lifecycle management
    /// - Simple, one-time operations
    /// - No event monitoring requirements
    /// 
    /// Use AMIProviderOptions when you need:
    /// - Continuous event monitoring from Asterisk
    /// - Automatic reconnection on connection loss
    /// - Persistent connection state management
    /// - Long-running background services
    /// </remarks>
    public class ManagerConnectionParameters : ReconnectorParameters
    {
        /// <summary>
        /// O endereço IP ou nome do host do servidor Asterisk.
        /// </summary>
        public string Address { get; set; } = "localhost";

        /// <summary>
        /// A porta da interface AMI. O padrão é 5038.
        /// </summary>
        public uint Port { get; set; } = Defaults.Port;

        /// <summary>
        /// O nome de usuário para autenticação na AMI.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// A senha (secret) para autenticação na AMI.
        /// </summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Indica se a autenticação MD5 (Challenge/Response) deve ser usada. O padrão é false.
        /// Se false, a autenticação será via texto plano (plaintext).
        /// </summary>
        public bool UseMD5Authentication { get; set; } = true;

        /// <summary>
        /// A codificação de caracteres a ser usada na comunicação via socket. O padrão é ASCII.
        /// </summary>
        public Encoding SocketEncoding { get; set; } = Encoding.ASCII;
                
        /// <summary>
        ///    Time interval, in milliseconds, between ping operations.
        /// </summary>
        public uint? PingInterval { get; set; } = 5000;

        /// <summary>
        /// Gets or sets a value indicating whether the old version of the feature is enabled. <br />
        /// Is your Asterisk pré .10 version ? its important because the command separator and other little things are different <br />
        /// If you don't know, set this to null and we will try to discorver
        /// </summary>
        public bool? OldVersion { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the connection should be forced to use IPv4.
        /// This can resolve PlatformNotSupportedException on some systems where dual-stack (IPv6/IPv4) socket behavior is problematic.
        /// </summary>
        public bool ForceIPv4 { get; set; } = false;

        public override bool Equals (object? obj)
            => obj is ManagerConnectionParameters other &&
            other.Address == Address &&
            other.Port == Port &&
            other.Username == Username &&
            other.Password == Password &&
            other.UseMD5Authentication == UseMD5Authentication &&
            other.SocketEncoding == SocketEncoding &&
            other.PingInterval == PingInterval &&
            other.OldVersion == OldVersion &&
            other.ForceIPv4 == ForceIPv4 &&
            base.Equals(obj);

        public override int GetHashCode()
            => (Address, Port, Username, Password, UseMD5Authentication, SocketEncoding, PingInterval, OldVersion, ForceIPv4).GetHashCode() ^ base.GetHashCode();
    }
}

