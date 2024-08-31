using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A CdrEvent is triggered when a call detail record is generated, usually at the end of a call.<br />
    ///     To enable CdrEvents you have to add enabled = yes to the general section in
    ///     cdr_manager.conf.<br />
    ///     This event is implemented in cdr/cdr_manager.c
    /// </summary>
    public class CdrEvent : ManagerEvent
    {
        public string? AccountCode { get; set; }

        public string? Source { get; set; }

        public string Destination { get; set; } = string.Empty;

        public string DestinationContext { get; set; } = string.Empty;

        public string CallerId { get; set; } = string.Empty;

        public string Channel { get; set; } = string.Empty;

        public string? DestinationChannel { get; set; }

        public string LastApplication { get; set; } = string.Empty;

        public string? LastData { get; set; }

        public string StartTime { get; set; } = string.Empty;

        public string AnswerTime { get; set; } = string.Empty;

        public string EndTime { get; set; } = string.Empty;

        public long Duration { get; set; }

        public long BillableSeconds { get; set; }

        public string Disposition { get; set; } = string.Empty;

        public string AMAFlags { get; set; } = string.Empty;

        public string UniqueId { get; set; } = default!;

        public string? UserField { get; set; }
    }
}