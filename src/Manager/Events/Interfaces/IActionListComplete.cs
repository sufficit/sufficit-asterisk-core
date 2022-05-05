using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IActionListComplete
    {
        string EventList { get; }

        uint ListItems { get; }
    }
}
