using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufficit.Asterisk.Manager
{
    public interface IAMIProvider
    {
        bool Enabled { get; }

        Task DisconnectAsync(CancellationToken cancellationToken);
    }
}
