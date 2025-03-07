using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events
{
    public class LocalOptimizationBeginEvent : ManagerEventFromAsterisk
    {
        /// <summary>
        /// Store all unknown (without setter) keys from manager event.<br/>
        /// Use in default Parse method <see cref="IParseSupport.Parse(string, string)"/>
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Attributes { get; internal set; }
    }
}
