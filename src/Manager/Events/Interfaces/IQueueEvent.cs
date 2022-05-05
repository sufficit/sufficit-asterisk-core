using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IQueueEvent 
    {
        /// <summary>
		/// Get/Set the name of the queue that contains this entry.
		/// </summary>
		string Queue { get; }
    }
}
