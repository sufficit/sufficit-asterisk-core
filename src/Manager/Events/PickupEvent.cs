using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class PickupEvent : AbstractChannelInfoEvent
    {
        public string TargetChannel { get; set; }
        public string targetchannelstate { get; set; }
        public string targetchannelstatedesc { get; set; }
        public string targetcalleridnum { get; set; }
        public string targetcalleridname { get; set; }
        public string targetconnectedlinenum { get; set; }
        public string targetconnectedlinename { get; set; }
        public string targetlanguage { get; set; }
        public string targetcontext { get; set; }
        public string targetexten { get; set; }
        public string targetpriority { get; set; }
        public string targetuniqueid { get; set; }
        public string targetlinkedid { get; set; }
    }
}
