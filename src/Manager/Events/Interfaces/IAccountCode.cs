using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    /// Used by events with accountcode property, useful to filter events
    /// </summary>
    public interface IAccountCode
    {
        string? AccountCode { get; }
    }
}
