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

        public AsteriskChannel(PeerInfo source)
        {
            Id = $"{source.Protocol}/{source.Name}";
            Protocol = source.Protocol;
            Name = source.Name;
        }

        public AsteriskChannel(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentNullException("source");
            
            Id = source;
            if (Id.Contains("/"))
            {
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

                if (Name.Contains("@"))
                {
                    var withContext = Name.Split('@');
                    if (withContext.Length >= 1)
                        Context = withContext[1];

                    Name = withContext[0];
                }
            }            
        }

        public string Id { get; set; } = default!;

        public AsteriskChannelProtocol Protocol { get; set; }

        public string? Name { get; set; }

        public string? Context { get; set; }

        public string? Suffix { get; set; }

        public string GetPeer() => $"{Protocol}/{Name}";

        public override string ToString() => Id;
    }
}
