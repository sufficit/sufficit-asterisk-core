using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufficit.Asterisk.IO
{
    public interface ISocketConnection : ISocketStatus, IDisposable
    {   
        bool IsHangUp { get; }

        IPAddress? LocalAddress { get; }
        int LocalPort { get; }
        IPAddress? RemoteAddress { get; }
        int RemotePort { get; }

        bool IsRemoteRequest { get; }

        Task WriteAsync(string data, CancellationToken cancellationToken);        

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
