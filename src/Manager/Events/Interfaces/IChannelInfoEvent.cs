using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public interface IChannelInfoEvent
	{
		string Language { get; }
		string Context { get; }
		string Exten { get; }
		string Priority { get; }
		string LinkedId { get; }
	}
}
