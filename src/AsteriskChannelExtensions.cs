using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
    public static class AsteriskChannelExtensions
    {
        public static AsteriskChannel ToAsteriskChannel(this string source) => new AsteriskChannel(source);

        public static AsteriskChannelProtocol ToAsteriskChannelProtocol(this string source)
        {
            switch (source.ToUpperInvariant().Trim())
            {
                case "LOCAL": return AsteriskChannelProtocol.LOCAL;
                case "SIP": return AsteriskChannelProtocol.SIP;
                case "PJSIP": return AsteriskChannelProtocol.PJSIP;
                case "IAX": return AsteriskChannelProtocol.IAX;
                case "IAX2": return AsteriskChannelProtocol.IAX2;
                default: throw new Exception($"not rechognized protocol: { source }");
            }
        }

        public static string ToChannelString(this AsteriskChannel source)
        {
            return $"{source.Protocol}/{source.Name}:{source.Suffix}";
        }
    }
}
