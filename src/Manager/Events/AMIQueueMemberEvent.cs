using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class AMIQueueMemberEvent
    {
        public Dictionary<string, string> Attributes { get; set; }

        public string Name { get; set; }
        public string MemberName { get; set; }
        public string Queue { get; set; }
        public string Location { get; set; }
        public string Membership { get; set; }
        public int Penalty { get; set; }
        public int CallsTaken { get; set; }
        public double LastCall { get; set; }
        public int Status { get; set; }
        public bool Paused { get; set; }
        public string PausedReason { get; set; }
        public bool InCall { get; set; }
        public string ActionId { get; set; }
        public string InternalActionId { get; set; }
        public string Channel { get; set; }
        public DateTime DateReceived { get; set; }
        public string Privilege { get; set; }
        public string Server { get; set; }
        public double Timestamp { get; set; }
        public string UniqueId { get; set; }

        public string StateInterface => Attributes?["stateinterface"];

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
    }
}
