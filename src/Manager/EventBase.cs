using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager
{
    public abstract class EventBase : IEventBase
    {
        [JsonIgnore]
        public abstract string Key { get; }

        public virtual DateTime DateReceived { get; set; }

        //public virtual DateTime Timestamp { get; set; }
    }
}
