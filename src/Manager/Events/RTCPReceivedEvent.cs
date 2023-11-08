using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
	public class RTCPReceivedEvent : ManagerEvent
	{
		public string From { get; set; } = default!;
        public int SequenceNumberCycles { get; set; }
        public string RTT { get; set; } = default!;
        public long IAJitter { get; set; }
        public string PT { get; set; } = default!;
        public int ReceptionReports { get; set; }
        public string LastSR { get; set; } = default!;
        public string DLSR { get; set; } = default!;
        public long FractionLost { get; set; }
        public long SenderSSRC { get; set; }
        public long HighestSequence { get; set; }
        public int PacketsLost { get; set; }
    }
}
