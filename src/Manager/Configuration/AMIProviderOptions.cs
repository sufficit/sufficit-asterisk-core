﻿using System;

namespace Sufficit.Asterisk.Manager.Configuration
{
    /// <summary>
    /// Parametros de configuração para Asterisk Manager Interface
    /// </summary>
    public class AMIProviderOptions
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

        public string Address { get; set; } = default!;

        public int Port { get; set; } = 4573;

        public string? User { get; set; }

        public string? Password { get; set; }

        /// <summary>
        /// Manter conexão ativa e reconectar sempre que cair (usado para ouvir eventos) <br />
        /// Ou usá-la somente para enviar comandos
        /// </summary>
        public bool KeepAlive { get; set; } = false;

        public override bool Equals(object? obj)
            => obj is AMIProviderOptions other && 
            other.Enabled == Enabled && 
            other.Title == Title && 
            other.Address == Address && 
            other.Port == Port && 
            other.User == User && 
            other.Password == Password &&
            other.KeepAlive == KeepAlive;

        public override int GetHashCode()
            => (Enabled, Title, Address, Port, User, Password, KeepAlive).GetHashCode();
    }
}
