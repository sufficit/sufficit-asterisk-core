using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class AMIQueueMemberStatusEvent
    {
        public Dictionary<string, string> Attributes { get; set; }

        public string Queue { get; set; }
        public string Interface { get; set; }
        public string StateInterface { get; set; }
        public string MemberName { get; set; }
        public string Membership { get; set; }
        public int Penalty { get; set; }
        public int CallsTaken { get; set; }
        public double LastCall { get; set; }
        public bool Paused { get; set; }
        public int Status { get; set; }
        public bool Ringinuse { get; set; }
        public bool InCall { get; set; }
        public string PausedReason { get; set; }

        public int LastPause
        {
            get
            {
                int result = 0;
                int.TryParse(Attributes?["lastpause"], out result);
                return result;
            }
        }

        public int WrapUpTime
        {
            get
            {
                int result = 0;
                int.TryParse(Attributes?["wrapuptime"], out result);
                return result;
            }
        }

        public DateTime DateReceived { get; set; }
    }
}
