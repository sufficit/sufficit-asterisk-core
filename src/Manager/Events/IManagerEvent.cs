using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IManagerEvent : IParseSupport
    {
        string Channel { get; }

        DateTime DateReceived { get; }

        string Privilege { get; }

        string Server { get; }

        double Timestamp { get; set; }

        string UniqueId { get; }

        IManagerConnection Source { get; }
    }
}
