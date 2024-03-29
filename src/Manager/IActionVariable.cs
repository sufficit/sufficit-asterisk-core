﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     IActionVariable
    /// </summary>
    public interface IActionVariable
    {
        /// <summary>
        /// Variable: concat all items here ...
        /// </summary>
        NameValueCollection? Variable { get; }
    }
}
