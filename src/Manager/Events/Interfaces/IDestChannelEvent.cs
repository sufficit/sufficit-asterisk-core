using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IDestChannelEvent
    {
        string DestChannel { get; }
        string DestChannelState { get; }
        string DestChannelStateDesc { get; }
        string DestCallerIdNum { get; }
        string DestCallerIdName { get; }
        string DestConnectedLineNum { get; }
        string DestConnectedLineName { get; }
        string DestLanguage { get; }
        string DestContext { get; }
        string DestExten { get; }
        string DestPriority { get; }
        string DestUniqueId { get; }
        string DestLinkedId { get; }
    }
}
