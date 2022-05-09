using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{

    /// <summary>
    ///     Raised when a device state changes.<br />
    ///     This differs from the ExtensionStatus event because this event is raised for all device state changes, not only for changes that affect dialplan hints.
    /// </summary>
    public class DeviceStateChangeEvent : ManagerEventFromAsterisk
    {
        public string Device { get; set; }

        public AsteriskDeviceStatus State { get; set; }
    }
}