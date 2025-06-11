using Sufficit.Asterisk.Manager.Events;
using System.Collections.Generic;

namespace Sufficit.Asterisk
{
    public interface IParseSupport
    {
        void Parse(string key, string value);

        /// <summary>
        ///     It receives the complete buffer dictionary and waits as response the dictionary that should be used for populate the properties.<br />        ///     
        ///     * if has custom treatment, just return the updated attributes <br />  
        /// </summary>
        /// <remarks>* if has no custom treatments, just return full attributes</remarks>
        /// <param name="attributes">buffer dictionary</param>
        /// <returns>updated merged dictionary</returns>
        IDictionary<string, string> ParseSpecial(IDictionary<string, string>? attributes);

        object GetSetter();
    }
}