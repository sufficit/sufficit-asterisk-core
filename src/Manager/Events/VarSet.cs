using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	public class VarSetEvent : AbstractChannelInfoEvent
	{
        [JsonPropertyName("line")]
        public int Line { get; set; }

        [JsonPropertyName("sequencenumber")]
        public int SequenceNumber { get; set; }

        [JsonPropertyName("variable")]
        public string Variable { get; set; } = default!;

        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
	}
}
