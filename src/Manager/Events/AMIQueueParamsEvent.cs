using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class AMIQueueParamsEvent
    {
        public Dictionary<string, string> Attributes { get; set; }

        public string Strategy { get; set; }
        public string Queue { get; set; }
        public int Max { get; set; }
        public int Calls { get; set; }
        public int Holdtime { get; set; }
        public int Completed { get; set; }
        public int Abandoned { get; set; }
        public int ServiceLevel { get; set; }
        public float ServiceLevelPerf { get; set; }
        public int Weight { get; set; }
                
        public int TalkTime
        {
            get
            {
                int result = 0;
                int.TryParse(Attributes?["talktime"], out result);
                return result;
            }
        }

        public float ServiceLevelPerf2
        {
            get
            {
                float result = 0;
                float.TryParse(Attributes?["servicelevelperf2"], out result);
                return result;
            }
        }
        
        // PROPRIEDADES COMUNS
        public string ActionId { get; set; }
        public string InternalActionId { get; set; }
        public string Channel { get; set; }
        public DateTime DateReceived { get; set; }
        public string Privilege { get; set; }
        public string Server { get; set; }
        public double Timestamp { get; set; }
        public string UniqueId { get; set; }
    }
}
