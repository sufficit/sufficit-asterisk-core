using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IChannelEvent
    {
        string Channel { get; }

        AsteriskChannelState ChannelState { get; set; }
    }
}
