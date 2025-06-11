using Sufficit.Asterisk.Manager.Action;
using Sufficit.Asterisk.Manager.Events.Abstracts;
using Sufficit.Asterisk.Manager.Response;
using System;
using System.Threading;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Defines the contract for a handler that processes responses for a sent manager action.
    /// This interface must be compatible with the existing usage in ManagerConnection.
    /// </summary>
    public interface IResponseHandler
    {
        /// <summary>
        /// Gets or sets the hash code associated with this handler,
        /// used as a key in the ManagerConnection's handler dictionaries.
        /// This is typically set by ManagerConnection when the handler is registered.
        /// </summary>
        int Hash { get; set; }

        /// <summary>
        /// Gets or sets the type of the response expected from the operation.
        /// </summary>
        Type? ResponseType { get; set; } 

        /// <summary>
        /// Gets the ManagerAction instance this handler is associated with.
        /// </summary>
        ManagerAction Action { get; }

        /// <summary>
        /// Handles an incoming response from the Asterisk server.
        /// </summary>
        /// <param name="response">The response received from Asterisk.</param>
        void HandleResponse(ManagerResponseEvent response);

        /// <summary>
        /// Handles an exception that occurred.
        /// </summary>
        /// <param name="ex">The exception.</param>
        void HandleException(Exception ex);

        /// <summary>
        /// Handles a cancellation request.
        /// </summary>
        /// <param name="cancellationToken">The token that signaled cancellation.</param>
        void HandleCancel(CancellationToken cancellationToken);
    }

}