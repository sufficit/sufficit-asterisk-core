using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public abstract class ManagerEvent : IManagerEvent
    {
        #region IMPLEMENT INTERFACE MANAGER EVENT

        /// <inheritdoc cref="IManagerEvent.Privilege"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Privilege Privilege { get; set; }

        /// <inheritdoc cref="IManagerEvent.DateReceived"/>
        public DateTime DateReceived { get; }

        #endregion

        public ManagerEvent() { DateReceived = DateTime.UtcNow; }
    }
}
