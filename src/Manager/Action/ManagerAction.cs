using System.Collections;
using System.Collections.Specialized;

namespace Sufficit.Asterisk.Manager.Action
{
    /// <summary>
    ///     This class implements the ManagerAction interface
    ///     and can serve as base class for your concrete Action implementations.
    /// </summary>
    public abstract class ManagerAction
    {
        /// <summary>
        ///     Manager API Action key. Also use as ProxyAction key to <see cref="ProxyAction">ProxyAction</see> actions.
        /// </summary>
        public abstract string Action { get; }

        /// <summary>
        /// Key: Value <br />
        /// All action lines skipping the reserved ones like "variable"
        /// </summary>
        public virtual IDictionary? Dictionary { get; set; }

        /// <summary>
        /// Variable: concat all items here ... <br />
        /// Can have multiple keys with the same name
        /// </summary>
        public virtual NameValueCollection? Variable { get; set; }

        public string ActionId { get; set; } = default!;

        /// <summary>
        ///     Specify a server to which to send your commands (x.x.x.x or hostname).<br />
        ///     This should match the server name specified in your config file's "host" entry.
        ///     If you do not specify a server, the proxy will pick the first one it finds -- fine in single-server configurations.
        /// </summary>
        public string? Server { get; set; }

        /// <summary>
        ///     You can use this as a simple authentication mechanism.<br />
        ///     Rather than have to login with a username &amp; password,
        ///     you can specify a <b>ProxyKey</b> that must be passed from
        ///     a client before requests are processed.<br />
        ///     This is helpful in situations where you would like to authenticate and
        ///     execute an action in a single step.
        /// </summary>
        public virtual string? ProxyKey { get; set; }
    }
}