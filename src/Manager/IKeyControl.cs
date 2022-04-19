using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// using a key to filter events
    /// </summary>
    public interface IKeyControl
    {
        string Key { get; }
    }
}
