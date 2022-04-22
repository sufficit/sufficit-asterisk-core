using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sufficit.Asterisk
{
    public class PeerInfo
    {
        public AsteriskChannelProtocol Protocol { get; set; }
        public string Name { get; set; }
        public AsteriskChannelState Status { get; set; }
    }
}
