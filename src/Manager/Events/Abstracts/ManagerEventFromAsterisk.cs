using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    public abstract class ManagerEventFromAsterisk : ManagerEvent, IManagerEventFromAsterisk
    {        
        /// <inheritdoc cref="IManagerEventFromAsterisk.Timestamp"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <inheritdoc cref="IManagerEventFromAsterisk.SystemName"/>
        [JsonPropertyName("systemname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? SystemName { get; set; }
    }
}
