using Sufficit.Asterisk.Manager.Events;
using System.Collections.Generic;

namespace Sufficit.Asterisk
{
    public interface IParseSupport
    {
        Dictionary<string, string>? Attributes { get; }
        void Parse(string key, string value);
        Dictionary<string, string> ParseSpecial(Dictionary<string, string>? attributes);
        object GetSetter();
    }
}