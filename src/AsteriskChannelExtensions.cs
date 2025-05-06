using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
    public static class AsteriskChannelExtensions
    {        
        public static string ToChannelString(this AsteriskChannel source)
        {
            return $"{source.Protocol}/{source.Name}:{source.Suffix}";
        }
    }
}
