using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
	public class RTCPSentEvent : ManagerEvent
	{
		public string? To { get; set; }
		public long CumulativeLoss { get; set; }
        public string? SentNtp { get; set; }
        public long SentRtp { get; set; }
        public double IAJitter { get; set; }
        public long SentPackets { get; set; }
        public long SentOctets { get; set; }
        public long ReportBlock { get; set; }
        public long FractionLost { get; set; }
        public long OursSrc { get; set; }
        public string? DlSr { get; set; }
        public long TheirLastSr { get; set; }
    }
}
