using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
    public class SecurityEvent
    {
        public string? Title { get; set; }
        public int Severity { get; set; }
        public string? AccountId { get; set; }
        public string? RemoteAddress { get; set; }
        public bool UsingPassword { get; set; }
        public string? Challenge { get; set; }
        public DateTime DateReceived { get; set; }
        public string? Service { get; set; }
    }
}
