using System;

namespace Sufficit.Asterisk.Manager.Configuration
{
    /// <summary>
    /// Parametros de configuração para Asterisk Manager Interface
    /// </summary>
    public class AMIProviderOptions : ManagerConnectionParameters
    {
        /// <summary>
        /// Title of default configuration section (appsettings.json)
        /// </summary>
        public const string SECTIONNAME = "AMIProviderOptions";

        /// <summary>
        /// Indica se o provedor de serviços está ativo e deve ser utilizado
        /// </summary>
        public bool Enabled { get; set; } = true;

        public string Title { get; set; } = "Untitled";

        public string? User { get => base.Username; set => base.Username = value ?? string.Empty; }

        public override bool Equals(object? obj)
            => obj is AMIProviderOptions other && 
            other.Enabled == Enabled && 
            other.Title == Title && 
            base.Equals(obj);

        public override int GetHashCode()
            => (Enabled, Title).GetHashCode() ^ base.GetHashCode();
    }
}
