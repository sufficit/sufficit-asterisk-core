using System.Collections.Generic;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     IActionWithBody
    /// </summary>
    public interface IActionWithBody
    {
        string? Body { get; }
    }
}
