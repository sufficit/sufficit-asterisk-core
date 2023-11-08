using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     Raised when a request's attempt to authenticate has been challenged, and the request failed the authentication challenge
    /// </summary>
    public class ChallengeResponseFailedEvent : SecurityEvent
    {
        /// <summary>
        /// The challenge that was sent
        /// </summary>
        [JsonPropertyName("challenge")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Challenge { get; set; } = default!;

        /// <summary>
        /// The response that was received
        /// </summary>
        [JsonPropertyName("response")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Response { get; set; } = default!;

        /// <summary>
        /// The expected response to the challenge
        /// </summary>
        [JsonPropertyName("expectedresponse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string ExpectedResponse { get; set; } = default!;
    }
}
