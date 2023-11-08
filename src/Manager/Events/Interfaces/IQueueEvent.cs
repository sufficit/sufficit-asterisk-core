using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IQueueEvent 
    {
        /// <summary>The name of the queue</summary>
		string Queue { get; }
    }
}
