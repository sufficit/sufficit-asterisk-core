using Sufficit.Asterisk.Manager;
using Sufficit.Asterisk.Manager.Events;
using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// A UnknownEvent is triggered on unknown event from manager/proxy.
    /// </summary>
    public class UnknownEvent : ManagerEventFromAsterisk
    {
        public string Channel {get; set;}

        public string Server { get; set; }

        public string UniqueId { get; set; }
    }
}
