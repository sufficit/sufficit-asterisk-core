using Sufficit.Asterisk.Manager.Action;
using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    ///     Default exception for Asterisk Manager Action with a Error or Failure response.<br />
    /// </summary>
    public class AsteriskManagerResponseFailedException : AsteriskManagerException
    {
        [JsonPropertyName("action")]
        public ManagerAction Action { get; }

        public AsteriskManagerResponseFailedException (string message, ManagerAction action, Exception inner) : base (message, inner)
        {
            Action = action;
        }

        public AsteriskManagerResponseFailedException(ManagerAction action, Exception inner) : base(null, inner)
        {
            Action = action;
        }
    }
}
