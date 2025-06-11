using System.Text;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Encapsula todos os parâmetros necessários para estabelecer uma conexão com a Asterisk Manager Interface (AMI).
    /// </summary>
    public class ManagerConnectionParameters
    {
        /// <summary>
        /// O endereço IP ou nome do host do servidor Asterisk.
        /// </summary>
        public string Hostname { get; set; } = "localhost";

        /// <summary>
        /// A porta da interface AMI. O padrão é 5038.
        /// </summary>
        public int Port { get; set; } = 5038;

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
        /// Define se a conexão deve ser mantida viva e tentar reconectar automaticamente. O padrão é true.
        /// </summary>
        public bool KeepAlive { get; set; } = true;

        /// <summary>
        /// Time in milliseconds 
        /// </summary>
        public uint? PingInterval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the old version of the feature is enabled. <br />
        /// Is your Asterisk pré .10 version ? its important because the command separator and other little things are different <br />
        /// If you don't know, set this to null and we will try to discorver
        /// </summary>
        public bool? OldVersion { get; set; } = false;


        public int ReconnectRetryFast { get; set; } = 5;
        public int ReconnectRetryMax { get; set; } = 10;
        public int ReconnectIntervalFast { get; set; } = 5000;
        public int ReconnectIntervalMax { get; set; } = 30000;
    }
}

