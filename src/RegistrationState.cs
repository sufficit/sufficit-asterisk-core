using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sufficit.Asterisk
{
    /// <summary>
    /// For sip this may be one of (not sure if all of these are exposed via the
    /// manager api, at least "Registered" and "Timeout" are used though
    /// </summary>
    public enum RegistrationState
    {
        [EnumMember(Value = "Unknown")]
        Unknown,

        [EnumMember(Value = "Registered")]
        Registered,

        [EnumMember(Value = "Unregistered")]
        Unregistered,

        [EnumMember(Value = "Rejected")]
        Rejected,

        [EnumMember(Value = "Failed")]
        Failed,

        [EnumMember(Value = "Request Sent")]
        RequestSent,

        [EnumMember(Value = "Auth. Sent")]
        AuthSent,

        [EnumMember(Value = "Timeout")]
        Timeout,

        [EnumMember(Value = "No Authentication")]
        NoAuthentication,

        [EnumMember(Value = "Unreachable")]
        Unreachable,
    }
}
