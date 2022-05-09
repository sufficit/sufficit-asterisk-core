using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
	/// <summary>
	/// Desvice Status.
	/// </summary>
	public enum AsteriskDeviceStatus
    {
        Unknown,
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
