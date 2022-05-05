using System.Collections.Generic;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     IActionVariable
    /// </summary>
    public interface IActionVariable
    {
        Dictionary<string, string> GetVariables();
        void SetVariables(Dictionary<string, string> vars);
    }
}
