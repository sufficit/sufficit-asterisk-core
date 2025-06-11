using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufficit.Asterisk.IO
{
    public interface ISocketConnection : IDisposable
    {
        /// <summary>
        ///     Test for underlaying socket is ready and last knowning as connected   
        /// </summary>
        /// <remarks>
        ///     "Last Knowning" because the <see cref="System.Net.Sockets.Socket.Connected">Connected</see>  information from <see cref="System.Net.Sockets.Socket">Net.Socket</see> indicates only the last try (send|receive) and not the current info.
        /// </remarks>
        bool IsConnected { get; }
        
        bool IsHangUp { get; }

        IPAddress LocalAddress { get; }
        int LocalPort { get; }
        IPAddress RemoteAddress { get; }
        int RemotePort { get; }

        bool IsRemoteRequest { get; }

        void Close(string? reason = null);

        [Obsolete("prefer dispose, if you want to close that, you cant re-open, so save info that you need and than dispose.")]
        void Close(AGISocketReason reason);

        void Write(string s);

        NetworkStream? GetStream();
                
        //IEnumerable<string> ReadRequest(uint? timeoutms = null);

        IAsyncEnumerable<string> ReadRequest(CancellationToken cancellationToken);

        IAsyncEnumerable<string> ReadReply(uint? timeoutms = null);

        IAsyncEnumerable<string> ReadReplyAsync(uint? timeoutms = null, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Monitor channel hangup event
        /// </summary>
        event EventHandler? OnHangUp;

        /// <summary>
        ///     Monitor dispose event
        /// </summary>
        event EventHandler? OnDisposing;

        /// <summary>
        ///		Triggered at socket disconnect event for any reason. <br />
        ///		Source parameter may be null because disposing <br />
		///		Nulls cause means expected behaviors <br />
        /// </summary>
        event EventHandler<AGISocketReason>? OnDisconnected;

        IntPtr Handle { get; }

        AGISocketOptions Options { get; }
    }
}
