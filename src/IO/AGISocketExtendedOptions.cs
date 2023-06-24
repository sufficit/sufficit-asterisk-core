using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sufficit.Asterisk.IO
{
    /// <summary>
    ///     Client and Server sockets options
    /// </summary>
    public class AGISocketExtendedOptions : AGISocketOptions
    {
        /// <summary>
        ///     TCP port to use, connect or bind
        /// </summary>
        public uint Port { get; set; }
            = 4573; // TCP

        /// <summary>
        ///     For server, bind address. <br />
        ///     For client, destination address. <br />
        /// </summary>
        public IPAddress? Address { get; set; }

        /// <summary>
        ///     Listen at IPV4 and IPV6
        /// </summary>
        public bool DualMode { get; set; }
            = true;

    }
}
