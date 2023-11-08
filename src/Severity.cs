using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
    /// <summary>
    /// A relative severity of the security event
    /// </summary>
    [Flags]
    public enum Severity
    {
        Informational,
        Error
    }
}
