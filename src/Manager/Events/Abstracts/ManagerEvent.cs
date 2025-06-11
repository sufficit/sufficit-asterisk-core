using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    public abstract class ManagerEvent : IManagerEvent
    {
        #region IMPLEMENT INTERFACE MANAGER EVENT

        /// <inheritdoc cref="IManagerEvent.Privilege"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("privilege")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Privilege Privilege { get; set; }

        /// <inheritdoc cref="IManagerEvent.DateReceived"/>
        [JsonPropertyName("datereceived")]
        public DateTime DateReceived { get; }

        #endregion

        public ManagerEvent() { DateReceived = DateTime.UtcNow; }
    }
}
