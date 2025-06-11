using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    /// <summary>
    ///     Represents a response received from the Asterisk server as the result of a
    ///     previously sent ManagerAction.<br />
    ///     The response can be linked with the action that caused it by looking the
    ///     action id attribute that will match the action id of the corresponding
    ///     action.
    /// </summary>
    public class ManagerResponseEvent : ManagerEvent
    {
        /// <summary>
        ///     Store all unknown (without setter) keys from manager event.<br />
        ///     Use in default Parse method <see cref="Parse" />.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("attributes")]
        public IDictionary<string, string>? Attributes { get; set; }

        /// <summary>
        ///     Contém uma exceção que representa uma falha.
        ///     Pode ser uma exceção de parsing (se a resposta foi malformada)
        ///     ou uma AsteriskManagerException (se o Asterisk retornou 'Response: Error').
        /// </summary>
        [JsonIgnore]
        public Exception? Exception { get; set; }
        
        /// <summary>
        ///     Specify a server to which to send your commands (x.x.x.x or hostname).<br />
        ///     This should match the server name specified in your config file's "host" entry.
        ///     If you do not specify a server, the proxy will pick the first one it finds -- fine in single-server configurations.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("server")]
        public string? Server { get; set; }

        /// <summary>
        ///     Get/Set the action id received with this response referencing the action that generated this response.
        /// </summary>
        [JsonPropertyName("actionid")]
        public string ActionId { get; set; } = default!;

        /// <summary>
        ///     Get/Set the message received with this response.<br />
        ///     The content depends on the action that generated this response.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///     Get/Set the value of the "Response:" line.<br />
        ///     This typically a String like "Success" or "Error" but depends on the action that generated this response.
        /// </summary>
        [JsonPropertyName("response")]
        public string Response { get; set; } = default!;
        
        /// <summary>
        ///     Get/Set the unique id received with this response.<br />
        ///     The unique id is used to keep track of channels created by the action sent, for example an OriginateAction.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("uniqueid")]
        public string? UniqueId { get; set; }

        [JsonPropertyName("eventlist")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? EventList { get; set; }

        /// <summary>
        ///     Custom data associated with the response.<br />
        ///     Built from attributes with a custom builder or set manually.<br />
        /// </summary>
        [JsonPropertyName("data")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public object? Data { get; set; }
    }
}