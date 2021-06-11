using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.AsteriskManager.Events
{
    public class AMIQueueStatusCompleteEvent
    {
        public Dictionary<string, string> Attributes { get; set; }

        public string EventList => Attributes?["eventlist"];

        public int ListItems
        {
            get
            {
                int result = 0;
                int.TryParse(Attributes?["listitems"], out result);
                return result;
            }
        }
    }
}
