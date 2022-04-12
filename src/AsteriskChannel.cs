using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk
{
    public class AsteriskChannel
    {
        [JsonConstructor]
        public AsteriskChannel() { }

        public AsteriskChannel(string source)
        {
            if (!string.IsNullOrWhiteSpace(source))
            {
                Id = source;
                var splitted = Id.Split('/');
                var tech = splitted[0];
                Protocol = tech.ToAsteriskChannelProtocol();

                var track = splitted[1];
                var separator = track.LastIndexOf('-');
                if (separator > -1)
                {
                    Suffix = track.Substring(separator + 1, track.Length - (separator + 1));
                    Name = track.Substring(0, separator);
                } 
                else 
                { 
                    Name = track; 
                }
            }
            else { throw new ArgumentNullException("source"); }
        }

        public string Id { get; set; }

        public AsteriskChannelProtocol Protocol { get; set; }

        public string Name { get; set; }

        public string Suffix { get; set; }

        public string GetPeer() => $"{Protocol}/{Name}";

        public override string ToString() => Id;
    }
}
