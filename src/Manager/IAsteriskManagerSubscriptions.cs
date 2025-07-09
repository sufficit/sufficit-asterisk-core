using Sufficit.Asterisk.Manager.Events;
using System;
using System.Collections.Generic;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Interface for managing Asterisk Manager Interface (AMI) event subscriptions and dispatching.
    /// Provides contract for event subscription, dispatching, and lifecycle management specifically
    /// for events from the Asterisk Manager Interface.
    /// </summary>
    public interface IManagerEventSubscriptions : IDisposable, IAsyncDisposable
    {
        /// <summary>
        /// Gets a value indicating whether this instance has been disposed.
        /// </summary>
        bool IsDisposed { get; }

        /// <summary>
        /// Event triggered when an unhandled event is received.
        /// </summary>
        event EventHandler<IManagerEvent>? UnhandledEvent;

        /// <summary>
        /// Subscribe to events of a specific type.
        /// </summary>
        /// <typeparam name="T">The type of event to subscribe to.</typeparam>
        /// <param name="action">The event handler to invoke when the event occurs.</param>
        /// <returns>A disposable object to unsubscribe from the event.</returns>
        IDisposable On<T>(EventHandler<T> action) where T : IManagerEvent;

        /// <summary>
        /// Dispatches an event to all registered handlers.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event to dispatch.</param>
        void Dispatch(object? sender, IManagerEvent e);

        /// <summary>
        /// Registers a custom user event class for parsing specific user-defined events.
        /// </summary>
        /// <param name="userEventClass">The type of the user event to register.</param>
        void RegisterUserEventClass(Type userEventClass);

        /// <summary>
        /// Gets or sets a value indicating whether all events should be fired, 
        /// even if no specific handlers are registered.
        /// </summary>
        bool FireAllEvents { get; set; }
    }
}