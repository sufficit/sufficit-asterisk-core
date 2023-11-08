using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     An ConfbridgeListRoomsCompleteEvent is triggered after the state of all ConfBridgeRooms has been reported in response to an ConfbridgeListRoomsAction.<br/>
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/ConfBridge+AMI+Actions">https://wiki.asterisk.org/wiki/display/AST/ConfBridge+AMI+Actions</see>
    /// </summary>
    /// <seealso cref="ConfbridgeListRoomsEvent" />
    public class ConfbridgeListRoomsCompleteEvent : ResponseEvent
    {

    }
}
