using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public abstract class ManagerEventFromAsterisk : ManagerEvent, IManagerEventFromAsterisk
    {
        /// <inheritdoc cref="IManagerEventFromAsterisk.Timestamp"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public double? Timestamp { get; set; }
    }
}
