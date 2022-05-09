using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IQueueMemberEvent : IManagerEvent
    {
        /// <summary>
        ///     Get/Set the name of the member's interface.<br />
        ///     Added in Asterisk 12
        /// </summary>
        string Interface { get; }

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// </summary>
        string MemberName { get; }
    }
}
