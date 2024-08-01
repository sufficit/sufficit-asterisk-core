using Sufficit.Asterisk.Manager.Events;
using System.Collections.Generic;

namespace Sufficit.Asterisk
{
    public interface IParseSupport
    {
        Dictionary<string, string>? Attributes { get; }

        void Parse(string key, string value);

        /// <summary>
        ///     Unknown properties parser. <br />
        ///     Custom threatments
        /// </summary>
        /// <remarks>* if has no custom treatments, just return full attributes or an empty one</remarks>
        /// <param name="attributes">buffer dictionary</param>
        /// <returns>updated merged dictionary</returns>
        Dictionary<string, string> ParseSpecial(Dictionary<string, string>? attributes);

        object GetSetter();
    }
}