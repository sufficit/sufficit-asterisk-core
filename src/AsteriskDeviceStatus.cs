using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk
{
	/// <summary>
	///     Device Status.
	/// </summary>
	public enum AsteriskDeviceStatus
    {        
        Unknown,

        [EnumMember(Value = "NOT_INUSE")]
        NotInUse,

        InUse,
        Busy,
        Invalid,
        Unavailable,
        Ringing,
        RingInUse,
        OnHold
    }
}
