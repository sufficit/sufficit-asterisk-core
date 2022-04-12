namespace Sufficit.Asterisk.Events
{
    public interface SuccessfulAuthEventInterface 
    {
        Severity Severity { get; }

        string AccountId { get; }

        string RemoteAddress { get; }

        bool UsingPassword { get; }
    }
}
