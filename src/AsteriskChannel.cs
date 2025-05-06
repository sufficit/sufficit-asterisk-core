using System;

namespace Sufficit.Asterisk
{
    public class AsteriskChannel
    {
        public string Id { get; set; } = default!;

        public AsteriskChannelProtocol Protocol { get; set; }

        public string? Name { get; set; }

        public string? Context { get; set; }

        public string? Suffix { get; set; }

        public string GetPeer() => $"{Protocol}/{Name}";

        #region OVERRIDES

        public override string ToString() => Id;

        public override bool Equals(object? obj)
            => obj is AsteriskChannel other
            && string.Equals(Id, other.Id, StringComparison.OrdinalIgnoreCase)
            && Protocol.Equals(other.Protocol)
            && string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase)
            && string.Equals(Context, other.Context, StringComparison.OrdinalIgnoreCase)
            && string.Equals(Suffix, other.Suffix, StringComparison.OrdinalIgnoreCase);

        public override int GetHashCode()
            => (Id, Protocol, Name, Context, Suffix).GetHashCode();

        #endregion
    }
}
