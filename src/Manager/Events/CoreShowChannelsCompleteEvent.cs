using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public class CoreShowChannelsCompleteEvent : ResponseEvent
    {
        [JsonPropertyName("listitems")]
        public int ListItems { get; set; }

        [JsonPropertyName("eventlist")]
        public string EventList { get; set; } = default!;
    }
}
