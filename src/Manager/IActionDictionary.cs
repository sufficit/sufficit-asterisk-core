using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     IActionDictionary
    /// </summary>
    public interface IActionDictionary
    {
        /// <summary>
        /// Key: Value <br />
        /// All action lines skipping the reserved ones like "variable"
        /// </summary>
        IDictionary? Dictionary { get; }
    }
}
