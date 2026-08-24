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
        public string TransfererConnectedLineNum { get; set; } = string.Empty;
        public string TransfererConnectedLineName { get; set; } = string.Empty;
        public string TransfererLanguage { get; set; } = string.Empty;
        public string TransfererAccountCode { get; set; } = string.Empty;
        public string TransfererContext { get; set; } = string.Empty;
        public string TransfererPriority { get; set; } = string.Empty;
        public string TransfererUniqueId { get; set; } = string.Empty;
        public string TransfereeChannel { get; set; } = string.Empty;
        public string TransfereeChannelState { get; set; } = string.Empty;
        public string TransfereeChannelStateDesc { get; set; } = string.Empty;
        public string TransfereeCallerIdNum { get; set; } = string.Empty;
        public string TransfereeCallerIdName { get; set; } = string.Empty;
        public string TransfereeConnectedLineNum { get; set; } = string.Empty;
        public string TransfereeConnectedLineName { get; set; } = string.Empty;
        public string TransfereeLanguage { get; set; } = string.Empty;
        public string TransfereeAccountCode { get; set; } = string.Empty;
        public string TransfereeContext { get; set; } = string.Empty;
        public string TransfereeExten { get; set; } = string.Empty;
        public string TransfereePriority { get; set; } = string.Empty;
        public string TransfereeUniqueId { get; set; } = string.Empty;
        public string BridgeUniqueId { get; set; } = string.Empty;
        public string BridgeType { get; set; } = string.Empty;
        public string BridgeTechnology { get; set; } = string.Empty;
        public string BridgeCreator { get; set; } = string.Empty;
        public string BridgeName { get; set; } = string.Empty;
        public string BridgeNumChannels { get; set; } = string.Empty;
        public string IsExternal { get; set; } = string.Empty;
        public string Context { get; set; } = string.Empty;
        public string Extension { get; set; } = string.Empty;


        public string TransfererExten { get; set; } = string.Empty;
        public string TransfererLinkedId { get; set; } = string.Empty;
        public string TransfereeLinkedId { get; set; } = string.Empty;
        public string BridgeVideoSourceMode { get; set; } = string.Empty;
    }
}
