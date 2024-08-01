using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// </summary>

namespace Sufficit.Asterisk.Manager.Events
{
    public class FailedACLEvent : ManagerEventFromAsterisk
    {
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string LocalAddress { get; set; } = default!;
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string RemoteAddress { get; set; } = default!;
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string ACLName { get; set; } = default!;

        public DateTime EventTv { get; set; }

        public string Severity { get; set; } = default!;

        public string Service { get; set; } = default!;

        public string EventVersion { get; set; } = default!;
        
        public string AccountId { get; set; } = default!;

        public string SessionId { get; set; } = default!;
    }
}
