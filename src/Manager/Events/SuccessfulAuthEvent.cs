using Sufficit.Asterisk;
using Sufficit.Asterisk.Events;
using Sufficit.Asterisk.Manager;
using System;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Raised when a request successfully authenticates with a service..<br />
    /// </summary>
    public class SuccessfulAuthEvent : ManagerEvent, SuccessfulAuthEventInterface
    {
        public Severity Severity { get; set; }

        public DateTime EventTv { get; set; }

        [JsonPropertyName("timestamp")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public double? TimeStamp { get; set; }

        [JsonPropertyName("accountid")]
        public string AccountId { get; set; } = default!;
        public string? SessionId { get; set; } 
        public string? LocalAddress { get; set; } 
        public string RemoteAddress { get; set; } = default!;
        public bool UsingPassword { get; set; }
        public string Service { get; set; } = default!;
    }
}