using Sufficit.Asterisk.Manager.Events.Abstracts;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A dial begin event is triggered whenever when a dial action has completed.<br/>
    /// </summary>
	public class DialEndEvent : AbstractDestChannelEvent
    {
        /// <summary>
        /// <br/> The result of the dial operation. 
        /// <br/> ABORT - The call was aborted.
        /// <br/> ANSWER - The caller answered.
        /// <br/> BUSY - The caller was busy.
        /// <br/> CANCEL - The caller cancelled the call.
        /// <br/> CHANUNAVAIL - The requested channel is unavailable.
        /// <br/> CONGESTION - The called party is congested.
        /// <br/> CONTINUE - The dial completed, but the caller elected to continue in the dialplan.
        /// <br/> GOTO - The dial completed, but the caller jumped to a dialplan location.
        /// <br/> If known, the location the caller is jumping to will be appended to the result following a ":".
        /// <br/> NOANSWER - The called party failed to answer.
        /// </summary>
        public string DialStatus { get; set; } = string.Empty;

        /// <summary>
        /// If the call was forwarded, where the call was forwarded to
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? Forward { get; set; }
    }
}