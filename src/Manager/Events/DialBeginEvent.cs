using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A dial begin event is triggered whenever when a dial action has started.<br/>
    /// </summary>
    public class DialBeginEvent : AbstractDestChannelEvent
    {
        /// <summary>
        /// The non-technology specific device being dialed
        /// </summary>
        public string DialString { get; set; } = string.Empty;
    }
}