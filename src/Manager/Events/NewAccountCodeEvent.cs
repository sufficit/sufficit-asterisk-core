using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Represents an event triggered when a new account code is assigned to a channel.
    /// </summary>
    /// <remarks>This event provides information about the new account code and, optionally, the previous
    /// account code. It is typically used to track changes in account codes for a specific channel.</remarks>
    public class NewAccountCodeEvent : AbstractChannelInfoEvent
    {
        [JsonPropertyName("oldaccountcode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? OldAccountCode { get; set; }
    }
}