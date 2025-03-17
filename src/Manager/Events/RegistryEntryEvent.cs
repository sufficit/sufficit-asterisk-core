using Sufficit.Asterisk.Channels;
using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public class RegistryEntryEvent : ResponseEvent
    {
        [JsonPropertyName("host")]
        public string Host { get; set; } = default!;

        [JsonPropertyName("port")]
        public int Port { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; } = default!;

        /// <summary>
        ///     DNS name for the host, if it was used, or same as host
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; set; } = default!;

        [JsonPropertyName("domainport")]
        public int DomainPort {  get; set; }

        [JsonPropertyName("refresh")]
        public int Refresh {  get; set; }

        [JsonPropertyName("state")]
        public RegistrationState State { get; set; }

        /// <summary>
        ///     Unix Timestamp for the registration event
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("registrationtime")]
        public double RegistrationTime { get; set; }
    }
}
