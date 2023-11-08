using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{
    /// <summary>
    /// Abstract base class providing common properties for all queue members events.
    /// </summary>
    public abstract class QueueMemberEvent : QueueEvent, IQueueMemberEvent
    {
        /// <inheritdoc cref="IQueueMemberDestEvent.Interface"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonPropertyName("interface")]
        public string Interface { get; set; } = default!;

        /// <inheritdoc cref="IQueueMemberEvent.StateInterface"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("stateinterface")]
        public string StateInterface { get; set; } = default!;

        /// <inheritdoc cref="IQueueMemberDestEvent.MemberName"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("membername")]
        public string MemberName { get; set; } = default!;

        /// <inheritdoc cref="IQueueMemberEvent.Location"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <inheritdoc cref="IQueueMemberEvent.Membership"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("membership")]
        public string Membership { get; set; } = default!;

        /// <inheritdoc cref="IQueueMemberEvent.Penalty"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("penalty")]
        public uint Penalty { get; set; } = default!;

        /// <inheritdoc cref="IQueueMemberEvent.CallsTaken"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("callstaken")]
        public uint CallsTaken { get; set; }

        /// <inheritdoc cref="IQueueMemberEvent.LastCall"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("lastcall")]
        public int LastCall { get; set; }

        /// <inheritdoc cref="IQueueMemberEvent.LastPause"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("lastpause")]
        public string? LastPause { get; set; }

        /// <inheritdoc cref="IQueueMemberEvent.PausedReason"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("pausedreason")]
        public string? PausedReason { get; set; }

        /// <inheritdoc cref="IQueueMemberEvent.Paused"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("paused")]
        public bool Paused { get; set; }

        /// <see cref="IQueueMemberEvent.Status" />
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("status")]
        public AsteriskDeviceStatus Status { get; set; }

        /// <see cref="IQueueMemberEvent.RingInUse" />
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("ringinuse")]
        public bool RingInUse { get; }

        /// <see cref="IQueueMemberEvent.InCall" />
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("incall")]
        public bool InCall { get; }

        /// <inheritdoc cref="IQueueMemberEvent.LoginTime"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("logintime")]
        public int LoginTime { get; set; }

        /// <inheritdoc cref="IQueueMemberEvent.WrapUpTime"/>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("wrapuptime")]
        public uint WrapUpTime { get; set; }
    }
}
