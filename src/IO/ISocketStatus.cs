using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.IO
{
    public interface ISocketStatus
    {
        /// <summary>
        ///     Test for underlaying socket is ready and last knowning as connected   
        /// </summary>
        /// <remarks>
        ///     "Last Knowning" because the <see cref="System.Net.Sockets.Socket.Connected">Connected</see>  information from <see cref="System.Net.Sockets.Socket">Net.Socket</see> indicates only the last try (send|receive) and not the current info.
        /// </remarks>
        bool IsConnected { get; }

        /// <summary>
        /// Gets the total number of bytes received through the socket.
        /// </summary>
        ulong TotalBytesReceived { get; }
    }
}
