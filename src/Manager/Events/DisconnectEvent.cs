using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// A DisconnectEvent is triggered when the connection to the asterisk server is lost.<br/>
	/// It is a pseudo event not directly related to an asterisk generated event.
	/// </summary>
	public class DisconnectEvent : ConnectionStateEvent
	{        
        [JsonPropertyName("message")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Message { get; set; }
    }
}