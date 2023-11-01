using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Description("NOT_INUSE")]
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
