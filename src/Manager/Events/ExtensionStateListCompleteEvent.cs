using System.Text.Json.Serialization;
using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <seealso cref="ExtensionStatusEvent" />
    public class ExtensionStateListCompleteEvent : ResponseEvent, IActionListComplete
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string EventList { get; set; } = string.Empty;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public uint ListItems { get; set; }
    }
}