using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public class ContactStatusEvent : ManagerEventFromAsterisk
    {
        [JsonPropertyName("uri")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public string Uri { get; set; } = string.Empty;

        [JsonPropertyName("contactstatus")]
        public string ContactStatus { get; set; } = string.Empty;

        [JsonPropertyName("aor")]
        public string AOR { get; set; } = string.Empty;

        [JsonPropertyName("endpointname")]
        public string EndPointName { get; set; } = string.Empty;

        [JsonPropertyName("roundtripusec")]
        public int RoundTripUSec { get; set; }
    }
}
