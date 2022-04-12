using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager
{
    public interface IManagerConnection
    {
        string Hostname { get; set; }
        bool KeepAlive { get; set; }
        int SocketReceiveBufferSize { get; set; }
        string Version { get; }
        AsteriskVersion AsteriskVersion { get; }
        bool IsConnected();
    }
}
