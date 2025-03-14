using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sufficit.Asterisk
{
    /// <summary>
    /// A relative severity of the security event
    /// </summary>
    public enum Severity
    {
        [EnumMember(Value = "Informational")]
        Informational,

        [EnumMember(Value = "Error")]
        Error
    }
}
