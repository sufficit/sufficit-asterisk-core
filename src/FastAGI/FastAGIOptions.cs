using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.FastAGI
{
    public class FastAGIOptions
    {
        /// <summary>
        /// Section for use of .json configurations
        /// </summary>
        public const string SECTIONNAME = "FastAGI";

        /// <summary>
        ///     Sets the TCP port to listen on for new connections.<br />
        ///     The default bind port is 4573.
        /// </summary>
        public uint Port { get; set; } = 4573;

        /// <summary> The address to listen on.</summary>
        public string Address { get; set; } = "[::]";

        /// <summary>
        ///     Sets the number of worker threads in the thread pool.<br />
        ///     This equals the maximum number of concurrent requests this AGIServer can serve.<br />
        ///     The default pool size is 10.
        /// </summary>
        public uint Workers { get; set; } = 10;

        /// <summary>
        ///     If set to true, causes the AGIChannel to throw an exception when a status code of 511 (Channel Dead) is returned.<br />
        ///     This is set to false by default to maintain backwards compatibility 
        /// </summary>
        public bool SC511_CAUSES_EXCEPTION { get; set; } = false;

        /// <summary>
        ///     If set to true, causes the AGIChannel to throw an exception when return status is 0 and reply is HANGUP.<br />
        ///     This is set to false by default to maintain backwards compatibility
        /// </summary>
        [Obsolete("not used anymore, there is an event to control the hangup")]
        public bool SCHANGUP_CAUSES_EXCEPTION { get; set; } = false;

        public AGIScriptMapping[] ScriptMapping { get; set; } = { };
    }
}
