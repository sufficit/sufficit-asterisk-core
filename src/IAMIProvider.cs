using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager
{
    public interface IAMIProvider
    {
        bool Enabled { get; set; }
    }
}
