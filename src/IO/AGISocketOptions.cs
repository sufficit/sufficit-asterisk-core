using System;
using System.Text;

namespace Sufficit.Asterisk.IO
{
    /// <summary>
    /// Client and Server sockets options
    /// </summary>
    public class AGISocketOptions
    {
        /// <summary>
        /// Section for use of .json configurations
        /// </summary>
        public const string SECTIONNAME = "FastAGISocket";

        /// <summary>
        ///     Total bytes for buffer size. <br />
        ///     Its important to avoid split of received and send messages <br />
        ///     Asterisk uses a dynamic value, so you have to choose by yourself
        /// </summary>
        public uint BufferSize { get; set; }
            = 8192 * 2;

        public Encoding Encoding { get; set; }
            = Encoding.ASCII;

        public const uint RECEIVE_TIMEOUT = 10000;

        /// <summary>
        /// Default milliseconds for receive timeout. <br />
        /// It can be changed for any request context. <br />
        /// 0 = default
        /// </summary>
        public uint ReceiveTimeout { get; set; }
            = RECEIVE_TIMEOUT;

        public const uint SEND_TIMEOUT = 5000;

        /// <summary>
        /// Default milliseconds for send timeout. <br />
        /// It can be changed for any request context. <br />
        /// 0 = default
        /// </summary>
        public uint SendTimeout { get; set; }
            = SEND_TIMEOUT;
    }
}
