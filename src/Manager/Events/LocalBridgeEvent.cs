using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    public class LocalBridgeEvent : ManagerEventFromAsterisk
    {
        public string Context { get; set; } = string.Empty;
        public string Exten { get; set; } = string.Empty;
        public string LocalOptimization { get; set; } = string.Empty;

        public string LocalOneChannel { get; set; } = string.Empty;
        public string LocalOneChannelState { get; set; } = string.Empty;
        public string LocalOneChannelStateDesc { get; set; } = string.Empty;
        public string LocalOneCallerIdNum { get; set; } = string.Empty;
        public string LocalOneCallerIdName { get; set; } = string.Empty;
        public string LocalOneConnectedLineNum { get; set; } = string.Empty;
        public string LocalOneConnectedLineName { get; set; } = string.Empty;
        public string LocalOneLanguage { get; set; } = string.Empty;
        public string LocalOneContext { get; set; } = string.Empty;
        public string LocalOneExten { get; set; } = string.Empty;
        public string LocalOnePriority { get; set; } = string.Empty;
        public string LocalOneUniqueId { get; set; } = string.Empty;
        public string LocalOneLinkedId { get; set; } = string.Empty;

        [JsonPropertyName("localoneaccountcode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? LocalOneAccountCode { get; set; }

        public string LocalTwoChannel { get; set; } = string.Empty;
        public string LocalTwoChannelState { get; set; } = string.Empty;
        public string LocalTwoChannelStateDesc { get; set; } = string.Empty;
        public string LocalTwoCallerIdNum { get; set; } = string.Empty;
        public string LocalTwoCallerIdName { get; set; } = string.Empty;
        public string LocalTwoConnectedLineNum { get; set; } = string.Empty;
        public string LocalTwoConnectedLineName { get; set; } = string.Empty;
        public string LocalTwoLanguage { get; set; } = string.Empty;
        public string LocalTwoContext { get; set; } = string.Empty;
        public string LocalTwoExten { get; set; } = string.Empty;
        public string LocalTwoPriority { get; set; } = string.Empty;
        public string LocalTwoUniqueId { get; set; } = string.Empty;
        public string LocalTwoLinkedId { get; set; } = string.Empty;

        [JsonPropertyName("localtwoaccountcode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        public string? LocalTwoAccountCode { get; set; }
    }
}
