using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class PickupEvent : AbstractChannelInfoEvent
    {
        public string TargetChannel { get; set; } = string.Empty;
        public string TargetChannelState { get; set; } = string.Empty;
        public string TargetChannelStateDesc { get; set; } = string.Empty;
        public string TargetCalleridNum { get; set; } = string.Empty;
        public string TargetCallerIdName { get; set; } = string.Empty;
        public string TargetConnectedLineNum { get; set; } = string.Empty;
        public string TargetConnectedLineName { get; set; } = string.Empty;
        public string TargetLanguage { get; set; } = string.Empty;
        public string TargetContext { get; set; } = string.Empty;
        public string TargetExten { get; set; } = string.Empty;
        public string TargetPriority { get; set; } = string.Empty;
        public string TargetUniqueId { get; set; } = string.Empty;
        public string TargetLinkedId { get; set; } = string.Empty;
        public string? TargetAccountCode { get; set; }
    }
}
