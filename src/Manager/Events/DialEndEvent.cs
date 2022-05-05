namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A dial begin event is triggered whenever when a dial action has completed.<br/>
    /// </summary>
	public class DialEndEvent : DialEvent
    {
        public string Forward { get; set; }
    }
}