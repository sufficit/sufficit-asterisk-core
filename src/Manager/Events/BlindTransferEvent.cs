using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
	public class BlindTransferEvent : ManagerEventFromAsterisk
	{
        public string Result { get; set; } = default!;
        public string TransfererChannel { get; set; } = default!;
        public string TransfererChannelState { get; set; } = default!;
        public string TransfererChannelStatedesc { get; set; } = default!;
        public string TransfererCallerIdNum { get; set; } = default!;
        public string TransfererCallerIdName { get; set; } = default!;
        public string TransfererConnectedLineNum { get; set; }
        public string TransfererConnectedLineName { get; set; }
        public string TransfererLanguage { get; set; }
        public string TransfererAccountCode { get; set; }
        public string TransfererContext { get; set; }
        public string TransfererPriority { get; set; }
        public string TransfererUniqueId { get; set; }
        public string TransfereeChannel { get; set; }
        public string TransfereeChannelState { get; set; }
        public string TransfereeChannelStateDesc { get; set; }
        public string TransfereeCallerIdNum { get; set; }
        public string TransfereeCallerIdName { get; set; }
        public string TransfereeConnectedLineNum { get; set; }
        public string TransfereeConnectedLineName { get; set; }
        public string TransfereeLanguage { get; set; }
        public string TransfereeAccountCode { get; set; }
        public string TransfereeContext { get; set; }
        public string TransfereeExten { get; set; }
        public string TransfereePriority { get; set; }
        public string TransfereeUniqueId { get; set; }
        public string BridgeUniqueId { get; set; }
        public string BridgeType { get; set; }
        public string BridgeTechnology { get; set; }
        public string BridgeCreator { get; set; }
        public string BridgeName { get; set; }
        public string BridgeNumChannels { get; set; }
        public string IsExternal { get; set; }
        public string Context { get; set; }
        public string Extension { get; set; }


        public string TransfererExten { get; set; }
        public string TransfererLinkedId { get; set; }
        public string TransfereeLinkedId { get; set; }
        public string BridgeVideoSourceMode { get; set; }
    }
}
