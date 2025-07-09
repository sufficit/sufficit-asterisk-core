<h1>
  Sufficit.Asterisk.Core
  <a href="https://github.com/sufficit"><img src="https://avatars.githubusercontent.com/u/66928451?s=200&v=4" alt="Sufficit Logo" width="80" align="right"></a>
</h1>

[![NuGet](https://img.shields.io/nuget/v/Sufficit.Asterisk.Core.svg)](https://www.nuget.org/packages/Sufficit.Asterisk.Core/)

## 📖 About the Project

`Sufficit.Asterisk.Core` is the **foundational library** for all Asterisk-related operations in the Sufficit ecosystem. It provides essential data models, interfaces, events, and configuration classes that serve as the building blocks for AMI connections, FastAGI servers, and telephony applications.

This library is designed to be **framework-agnostic** and **multi-target**, supporting everything from .NET Standard 2.0 for legacy applications to the latest .NET 9 for modern cloud-native services.

### 🏗️ Architecture Overview

Sufficit.Asterisk.Core serves as the **foundation layer** for the entire Asterisk ecosystem:
┌─────────────────────────────────────────────────────────────┐
│                    Application Layer                        │
├─────────────────────────────────────────────────────────────┤
│  Sufficit.AMIEvents  │  Sufficit.Asterisk.Manager          │
│  (Persistent AMI)    │  (Temporary AMI)                     │
├─────────────────────────────────────────────────────────────┤
│  Sufficit.Asterisk.FastAGI  │  Sufficit.Asterisk.Utils     │
│  (AGI Server)               │  (Utility Functions)          │
├─────────────────────────────────────────────────────────────┤
│                 Sufficit.Asterisk.Core                     │
│            (Foundation - Events, Models, Interfaces)        │
└─────────────────────────────────────────────────────────────┘
## ✨ Key Features

### 🎯 Core Components

* **Manager Events** - Comprehensive event models for all Asterisk AMI events
* **Manager Actions** - Action classes for AMI command execution
* **Connection Interfaces** - Abstractions for AMI and AGI connections
* **Configuration Models** - Settings classes for connection parameters
* **Extension Methods** - Utility methods for common operations
* **Multi-Framework Support** - .NET Standard 2.0, .NET 6, 7, 8, 9

### 📡 Event System

* **Type-safe event handling** with strongly-typed event classes
* **Event inheritance hierarchy** for efficient event processing
* **Custom event registration** support
* **Event metadata** including timestamps and system information

### 🔧 Configuration Management

* **Connection parameters** with validation
* **Reconnection policies** with progressive backoff
* **SSL/TLS support** configuration
* **Timeout and retry settings**

### 🌐 Multi-Target Framework Support

| Framework | Use Case | Benefits |
|-----------|----------|----------|
| **.NET Standard 2.0** | Legacy applications, Xamarin | Maximum compatibility |
| **.NET 6** | Long-term support applications | Stable, supported until 2024 |
| **.NET 7** | Current applications | Performance improvements |
| **.NET 8** | Modern LTS applications | Latest LTS with best performance |
| **.NET 9** | Cutting-edge applications | Latest features and optimizations |

## 🚀 Getting Started

### 📋 Prerequisites

* **.NET SDK** - Version depends on your target framework
* **Asterisk Server** - For testing and integration
* **Basic understanding** of Asterisk concepts (channels, events, actions)

### 📦 Installation

**.NET CLI:**dotnet add package Sufficit.Asterisk.Core
**Package Manager Console:**Install-Package Sufficit.Asterisk.Core
### 🔗 Package References
<PackageReference Include="Sufficit.Asterisk.Core" Version="1.*" />
## 🛠️ Usage Examples

### Event Handling
using Sufficit.Asterisk.Manager.Events;

public class EventProcessor
{
    public void HandleAsteriskEvents()
    {
        // Handle new channel events
        var newChannelEvent = new NewChannelEvent
        {
            Channel = "SIP/1000-0001a4c",
            ChannelState = "0",
            Context = "default",
            Exten = "1001"
        };
        
        ProcessNewChannel(newChannelEvent);
    }
    
    private void ProcessNewChannel(NewChannelEvent evt)
    {
        Console.WriteLine($"New call: {evt.Channel} -> {evt.Exten}");
        
        // Extract channel technology
        var tech = evt.Channel?.Split('/')[0]; // "SIP"
        
        // Process based on channel state
        switch (evt.ChannelState)
        {
            case "0": // Down
                Console.WriteLine("Channel is down");
                break;
            case "4": // Ring
                Console.WriteLine("Channel is ringing");
                break;
            case "6": // Up
                Console.WriteLine("Channel is answered");
                break;
        }
    }
}
### Connection Configuration
using Sufficit.Asterisk.Manager;

public class ConnectionSetup
{
    public ManagerConnectionParameters CreateParameters()
    {
        return new ManagerConnectionParameters
        {
            Server = "asterisk.example.com",
            Port = 5038,
            Username = "manager",
            Secret = "password",
            ConnectTimeout = TimeSpan.FromSeconds(30),
            ReadTimeout = TimeSpan.FromSeconds(30)
        };
    }
    
    public ReconnectorParameters CreateReconnectionPolicy()
    {
        return new ReconnectorParameters
        {
            KeepAlive = true,
            ReconnectRetryMax = 0, // Infinite retries
            ReconnectRetryFast = 5,
            ReconnectIntervalFast = 5000, // 5 seconds
            ReconnectIntervalMax = 30000  // 30 seconds max
        };
    }
}
### Event Subscription System
using Sufficit.Asterisk.Manager.Events;

public class TelephonyMonitor
{
    private readonly Dictionary<string, EventHandler<IManagerEvent>> _eventHandlers;
    
    public TelephonyMonitor()
    {
        _eventHandlers = new Dictionary<string, EventHandler<IManagerEvent>>();
        SetupEventHandlers();
    }
    
    private void SetupEventHandlers()
    {
        // Type-safe event handling
        RegisterHandler<NewChannelEvent>(OnNewChannel);
        RegisterHandler<HangupEvent>(OnHangup);
        RegisterHandler<PeerStatusEvent>(OnPeerStatus);
        RegisterHandler<NewStateEvent>(OnChannelStateChange);
    }
    
    private void RegisterHandler<T>(Action<T> handler) where T : IManagerEvent
    {
        var eventName = typeof(T).Name.Replace("Event", "");
        _eventHandlers[eventName] = (sender, evt) =>
        {
            if (evt is T typedEvent)
                handler(typedEvent);
        };
    }
    
    private void OnNewChannel(NewChannelEvent evt)
    {
        Console.WriteLine($"📞 New Channel: {evt.Channel}");
        
        // Extract useful information
        var channelParts = evt.Channel?.Split('-');
        var technology = channelParts?[0]?.Split('/')[0]; // SIP, PJSIP, IAX2, etc.
        var identifier = channelParts?[0]?.Split('/')[1];  // Extension or trunk name
        
        Console.WriteLine($"   Technology: {technology}");
        Console.WriteLine($"   Identifier: {identifier}");
        Console.WriteLine($"   Context: {evt.Context}");
        Console.WriteLine($"   Extension: {evt.Exten}");
    }
    
    private void OnHangup(HangupEvent evt)
    {
        Console.WriteLine($"📴 Call Ended: {evt.Channel}");
        Console.WriteLine($"   Cause: {evt.Cause} ({evt.CauseTxt})");
        
        // Common hangup causes
        switch (evt.Cause)
        {
            case "16": // Normal call clearing
                Console.WriteLine("   ✅ Normal hangup");
                break;
            case "17": // User busy
                Console.WriteLine("   📵 Busy");
                break;
            case "18": // No user responding
                Console.WriteLine("   📞 No answer");
                break;
            case "19": // No answer from user
                Console.WriteLine("   ⏰ Timeout");
                break;
            default:
                Console.WriteLine($"   ❓ Other cause: {evt.CauseTxt}");
                break;
        }
    }
    
    private void OnPeerStatus(PeerStatusEvent evt)
    {
        Console.WriteLine($"🔌 Peer Status: {evt.Peer} -> {evt.PeerStatus}");
        
        switch (evt.PeerStatus?.ToLower())
        {
            case "registered":
                Console.WriteLine("   ✅ Peer is online");
                break;
            case "unregistered":
                Console.WriteLine("   ❌ Peer is offline");
                break;
            case "unreachable":
                Console.WriteLine("   🔴 Peer is unreachable");
                break;
            case "reachable":
                Console.WriteLine("   🟢 Peer is reachable");
                break;
        }
    }
    
    private void OnChannelStateChange(NewStateEvent evt)
    {
        Console.WriteLine($"🔄 Channel State: {evt.Channel} -> {evt.ChannelState}");
        
        // Channel states according to Asterisk
        var stateDescriptions = new Dictionary<string, string>
        {
            ["0"] = "Down",
            ["1"] = "Reserved",
            ["2"] = "OffHook",
            ["3"] = "Dialing",
            ["4"] = "Ring",
            ["5"] = "Ringing",
            ["6"] = "Up (Answered)",
            ["7"] = "Busy",
            ["8"] = "Dialing Offhook",
            ["9"] = "Pre-ring"
        };
        
        if (stateDescriptions.TryGetValue(evt.ChannelState ?? "", out var description))
        {
            Console.WriteLine($"   📊 State: {description}");
        }
    }
}
### Custom Event Implementation
using Sufficit.Asterisk.Manager.Events;

/// <summary>
/// Custom event for application-specific monitoring
/// </summary>
public class CustomApplicationEvent : ManagerEventBase
{
    public string? ApplicationName { get; set; }
    public string? ApplicationData { get; set; }
    public string? Channel { get; set; }
    public string? UniqueId { get; set; }
    
    public CustomApplicationEvent() : base("CustomApplication") { }
    
    public override string ToString()
    {
        return $"CustomApplication: {ApplicationName} on {Channel}";
    }
}

// Usage in event handler
public void HandleCustomEvent(CustomApplicationEvent evt)
{
    Console.WriteLine($"Custom App: {evt.ApplicationName}");
    Console.WriteLine($"Data: {evt.ApplicationData}");
    Console.WriteLine($"Channel: {evt.Channel}");
}
## 🏗️ Architecture & Design Patterns

### Event Inheritance Hierarchy
// Base interfaces and classes
public interface IManagerEvent
{
    string EventName { get; }
    DateTime DateReceived { get; set; }
}

public interface IManagerEventFromAsterisk : IManagerEvent
{
    double? Timestamp { get; }
    string? SystemName { get; }
}

// Concrete event implementation
public class NewChannelEvent : ManagerEventBase, IManagerEventFromAsterisk
{
    public string? Channel { get; set; }
    public string? ChannelState { get; set; }
    public string? Context { get; set; }
    public string? Exten { get; set; }
    public double? Timestamp { get; set; }
    public string? SystemName { get; set; }
    
    public NewChannelEvent() : base("NewChannel") { }
}
### Configuration Builder Pattern
public class AsteriskConnectionBuilder
{
    private ManagerConnectionParameters _parameters = new();
    private ReconnectorParameters _reconnector = new();
    
    public AsteriskConnectionBuilder WithServer(string address, int port = 5038)
    {
        _parameters.Server = address;
        _parameters.Port = port;
        return this;
    }
    
    public AsteriskConnectionBuilder WithCredentials(string username, string password)
    {
        _parameters.Username = username;
        _parameters.Secret = password;
        return this;
    }
    
    public AsteriskConnectionBuilder WithTimeouts(TimeSpan connect, TimeSpan read)
    {
        _parameters.ConnectTimeout = connect;
        _parameters.ReadTimeout = read;
        return this;
    }
    
    public AsteriskConnectionBuilder WithReconnection(bool keepAlive = true, int maxRetries = 0)
    {
        _reconnector.KeepAlive = keepAlive;
        _reconnector.ReconnectRetryMax = maxRetries;
        return this;
    }
    
    public AsteriskConnectionBuilder WithSSL(bool enable = true)
    {
        _parameters.SSL = enable;
        return this;
    }
    
    public (ManagerConnectionParameters connection, ReconnectorParameters reconnector) Build()
    {
        ValidateConfiguration();
        return (_parameters, _reconnector);
    }
    
    private void ValidateConfiguration()
    {
        if (string.IsNullOrEmpty(_parameters.Server))
            throw new ArgumentException("Server address is required");
            
        if (string.IsNullOrEmpty(_parameters.Username))
            throw new ArgumentException("Username is required");
            
        if (string.IsNullOrEmpty(_parameters.Secret))
            throw new ArgumentException("Password is required");
    }
}

// Usage
var (connection, reconnector) = new AsteriskConnectionBuilder()
    .WithServer("asterisk.example.com", 5038)
    .WithCredentials("manager", "secret")
    .WithTimeouts(TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30))
    .WithReconnection(keepAlive: true, maxRetries: 0)
    .WithSSL(false)
    .Build();
## 🔧 Advanced Features

### Event Filtering and Routing
public class EventRouter
{
    private readonly Dictionary<Type, List<IEventHandler>> _handlers = new();
    
    public void RegisterHandler<T>(IEventHandler<T> handler) where T : IManagerEvent
    {
        var eventType = typeof(T);
        if (!_handlers.ContainsKey(eventType))
            _handlers[eventType] = new List<IEventHandler>();
            
        _handlers[eventType].Add(handler);
    }
    
    public async Task RouteEventAsync(IManagerEvent evt)
    {
        var eventType = evt.GetType();
        
        if (_handlers.TryGetValue(eventType, out var handlers))
        {
            var tasks = handlers.Select(h => h.HandleAsync(evt));
            await Task.WhenAll(tasks);
        }
        
        // Also route to base type handlers
        await RouteToBaseHandlers(evt, eventType.BaseType);
    }
    
    private async Task RouteToBaseHandlers(IManagerEvent evt, Type? baseType)
    {
        if (baseType == null || baseType == typeof(object))
            return;
            
        if (_handlers.TryGetValue(baseType, out var handlers))
        {
            var tasks = handlers.Select(h => h.HandleAsync(evt));
            await Task.WhenAll(tasks);
        }
        
        await RouteToBaseHandlers(evt, baseType.BaseType);
    }
}

public interface IEventHandler
{
    Task HandleAsync(IManagerEvent evt);
}

public interface IEventHandler<T> : IEventHandler where T : IManagerEvent
{
    Task HandleAsync(T evt);
}
### Connection State Management
public enum ConnectionState
{
    Disconnected,
    Connecting,
    Connected,
    Authenticating,
    Authenticated,
    Disconnecting,
    Failed
}

public class ConnectionStateManager
{
    private ConnectionState _currentState = ConnectionState.Disconnected;
    private readonly object _stateLock = new();
    
    public event EventHandler<ConnectionStateChangedEventArgs>? StateChanged;
    
    public ConnectionState CurrentState
    {
        get { lock (_stateLock) return _currentState; }
        private set
        {
            ConnectionState oldState;
            lock (_stateLock)
            {
                oldState = _currentState;
                _currentState = value;
            }
            
            if (oldState != value)
            {
                StateChanged?.Invoke(this, new ConnectionStateChangedEventArgs(oldState, value));
            }
        }
    }
    
    public bool CanTransitionTo(ConnectionState newState)
    {
        return newState switch
        {
            ConnectionState.Connecting => CurrentState == ConnectionState.Disconnected,
            ConnectionState.Connected => CurrentState == ConnectionState.Connecting,
            ConnectionState.Authenticating => CurrentState == ConnectionState.Connected,
            ConnectionState.Authenticated => CurrentState == ConnectionState.Authenticating,
            ConnectionState.Disconnecting => CurrentState is ConnectionState.Connected or ConnectionState.Authenticated,
            ConnectionState.Disconnected => CurrentState == ConnectionState.Disconnecting,
            ConnectionState.Failed => true, // Can transition to failed from any state
            _ => false
        };
    }
    
    public void TransitionTo(ConnectionState newState)
    {
        if (!CanTransitionTo(newState))
            throw new InvalidOperationException($"Cannot transition from {CurrentState} to {newState}");
            
        CurrentState = newState;
    }
}

public class ConnectionStateChangedEventArgs : EventArgs
{
    public ConnectionState OldState { get; }
    public ConnectionState NewState { get; }
    public DateTime Timestamp { get; }
    
    public ConnectionStateChangedEventArgs(ConnectionState oldState, ConnectionState newState)
    {
        OldState = oldState;
        NewState = newState;
        Timestamp = DateTime.UtcNow;
    }
}
### Metrics and Monitoring
public class AsteriskMetrics
{
    private readonly Dictionary<string, int> _eventCounts = new();
    private readonly List<TimeSpan> _connectionTimes = new();
    private DateTime _lastEventTime = DateTime.MinValue;
    
    public void RecordEvent(IManagerEvent evt)
    {
        var eventType = evt.GetType().Name;
        
        lock (_eventCounts)
        {
            _eventCounts[eventType] = _eventCounts.GetValueOrDefault(eventType, 0) + 1;
        }
        
        _lastEventTime = DateTime.UtcNow;
    }
    
    public void RecordConnectionTime(TimeSpan connectionTime)
    {
        lock (_connectionTimes)
        {
            _connectionTimes.Add(connectionTime);
            
            // Keep only last 100 connection times
            if (_connectionTimes.Count > 100)
                _connectionTimes.RemoveAt(0);
        }
    }
    
    public MetricsSnapshot GetSnapshot()
    {
        lock (_eventCounts)
        lock (_connectionTimes)
        {
            return new MetricsSnapshot
            {
                EventCounts = new Dictionary<string, int>(_eventCounts),
                AverageConnectionTime = _connectionTimes.Count > 0 
                    ? TimeSpan.FromTicks((long)_connectionTimes.Average(t => t.Ticks))
                    : TimeSpan.Zero,
                LastEventTime = _lastEventTime,
                TotalEvents = _eventCounts.Values.Sum(),
                ConnectionAttempts = _connectionTimes.Count
            };
        }
    }
}

public class MetricsSnapshot
{
    public Dictionary<string, int> EventCounts { get; set; } = new();
    public TimeSpan AverageConnectionTime { get; set; }
    public DateTime LastEventTime { get; set; }
    public int TotalEvents { get; set; }
    public int ConnectionAttempts { get; set; }
    
    public void PrintReport()
    {
        Console.WriteLine("=== Asterisk Metrics Report ===");
        Console.WriteLine($"Total Events: {TotalEvents}");
        Console.WriteLine($"Connection Attempts: {ConnectionAttempts}");
        Console.WriteLine($"Average Connection Time: {AverageConnectionTime.TotalMilliseconds:F2}ms");
        Console.WriteLine($"Last Event: {LastEventTime:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine("\nEvent Breakdown:");
        
        foreach (var kvp in EventCounts.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
        }
    }
}
## 🧪 Testing and Utilities

### Event Factory for Testing
public static class EventFactory
{
    public static NewChannelEvent CreateNewChannel(string channel, string context = "default", string exten = "1000")
    {
        return new NewChannelEvent
        {
            Channel = channel,
            Context = context,
            Exten = exten,
            ChannelState = "4", // Ring
            UniqueId = Guid.NewGuid().ToString(),
            DateReceived = DateTime.UtcNow,
            Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
        };
    }
    
    public static HangupEvent CreateHangup(string channel, string cause = "16", string causeTxt = "Normal Clearing")
    {
        return new HangupEvent
        {
            Channel = channel,
            Cause = cause,
            CauseTxt = causeTxt,
            UniqueId = Guid.NewGuid().ToString(),
            DateReceived = DateTime.UtcNow,
            Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
        };
    }
    
    public static PeerStatusEvent CreatePeerStatus(string peer, string status = "Registered")
    {
        return new PeerStatusEvent
        {
            Peer = peer,
            PeerStatus = status,
            DateReceived = DateTime.UtcNow,
            Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
        };
    }
}

// Usage in tests
[Test]
public void EventProcessor_Should_Handle_NewChannel()
{
    // Arrange
    var processor = new EventProcessor();
    var evt = EventFactory.CreateNewChannel("SIP/1000-00000001", "default", "1001");
    
    // Act
    processor.HandleEvent(evt);
    
    // Assert
    // Verify expected behavior
}
### Configuration Validation
public static class ConfigurationValidator
{
    public static ValidationResult ValidateConnectionParameters(ManagerConnectionParameters parameters)
    {
        var errors = new List<string>();
        
        if (string.IsNullOrWhiteSpace(parameters.Server))
            errors.Add("Server address cannot be empty");
            
        if (parameters.Port <= 0 || parameters.Port > 65535)
            errors.Add("Port must be between 1 and 65535");
            
        if (string.IsNullOrWhiteSpace(parameters.Username))
            errors.Add("Username cannot be empty");
            
        if (string.IsNullOrWhiteSpace(parameters.Secret))
            errors.Add("Password cannot be empty");
            
        if (parameters.ConnectTimeout <= TimeSpan.Zero)
            errors.Add("Connect timeout must be positive");
            
        if (parameters.ReadTimeout <= TimeSpan.Zero)
            errors.Add("Read timeout must be positive");
            
        return new ValidationResult
        {
            IsValid = errors.Count == 0,
            Errors = errors
        };
    }
    
    public static ValidationResult ValidateReconnectorParameters(ReconnectorParameters parameters)
    {
        var errors = new List<string>();
        
        if (parameters.ReconnectRetryFast < 0)
            errors.Add("Fast retry count cannot be negative");
            
        if (parameters.ReconnectRetryMax < 0)
            errors.Add("Max retry count cannot be negative");
            
        if (parameters.ReconnectIntervalFast <= 0)
            errors.Add("Fast retry interval must be positive");
            
        if (parameters.ReconnectIntervalMax <= 0)
            errors.Add("Max retry interval must be positive");
            
        if (parameters.ReconnectIntervalMax < parameters.ReconnectIntervalFast)
            errors.Add("Max interval cannot be less than fast interval");
            
        return new ValidationResult
        {
            IsValid = errors.Count == 0,
            Errors = errors
        };
    }
}

public class ValidationResult
{
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new();
    
    public void ThrowIfInvalid()
    {
        if (!IsValid)
            throw new ArgumentException($"Configuration validation failed: {string.Join(", ", Errors)}");
    }
}
## 🔗 Integration Examples

### ASP.NET Core Integration
// Program.cs
builder.Services.Configure<ManagerConnectionParameters>(
    builder.Configuration.GetSection("Asterisk:Connection"));
    
builder.Services.Configure<ReconnectorParameters>(
    builder.Configuration.GetSection("Asterisk:Reconnection"));

// Validation
builder.Services.AddOptions<ManagerConnectionParameters>()
    .Validate(config => ConfigurationValidator.ValidateConnectionParameters(config).IsValid);
### Dependency Injection Setup
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAsteriskCore(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ManagerConnectionParameters>(configuration.GetSection("Asterisk:Connection"));
        services.Configure<ReconnectorParameters>(configuration.GetSection("Asterisk:Reconnection"));
        
        services.AddSingleton<EventRouter>();
        services.AddSingleton<AsteriskMetrics>();
        services.AddSingleton<ConnectionStateManager>();
        
        return services;
    }
}
### Configuration Example
{
  "Asterisk": {
    "Connection": {
      "Server": "asterisk.example.com",
      "Port": 5038,
      "Username": "manager",
      "Secret": "password",
      "ConnectTimeout": "00:00:30",
      "ReadTimeout": "00:00:30",
      "SSL": false
    },
    "Reconnection": {
      "KeepAlive": true,
      "ReconnectRetryMax": 0,
      "ReconnectRetryFast": 5,
      "ReconnectIntervalFast": 5000,
      "ReconnectIntervalMax": 30000
    }
  }
}
## 📊 Performance Considerations

### Memory Management
// Efficient event handling with object pooling
public class EventPool<T> where T : class, IManagerEvent, new()
{
    private readonly ConcurrentQueue<T> _pool = new();
    private readonly int _maxPoolSize;
    
    public EventPool(int maxPoolSize = 100)
    {
        _maxPoolSize = maxPoolSize;
    }
    
    public T Get()
    {
        return _pool.TryDequeue(out var item) ? item : new T();
    }
    
    public void Return(T item)
    {
        if (_pool.Count < _maxPoolSize)
        {
            // Reset item properties if needed
            item.DateReceived = default;
            _pool.Enqueue(item);
        }
    }
}
### Event Processing Optimization
public class OptimizedEventProcessor
{
    private readonly Channel<IManagerEvent> _eventChannel;
    private readonly ChannelWriter<IManagerEvent> _writer;
    private readonly Task _processingTask;
    
    public OptimizedEventProcessor()
    {
        var options = new BoundedChannelOptions(1000)
        {
            FullMode = BoundedChannelFullMode.Wait,
            SingleReader = true,
            SingleWriter = false
        };
        
        _eventChannel = Channel.CreateBounded<IManagerEvent>(options);
        _writer = _eventChannel.Writer;
        
        _processingTask = ProcessEventsAsync();
    }
    
    public async ValueTask QueueEventAsync(IManagerEvent evt)
    {
        await _writer.WriteAsync(evt);
    }
    
    private async Task ProcessEventsAsync()
    {
        await foreach (var evt in _eventChannel.Reader.ReadAllAsync())
        {
            try
            {
                await ProcessEventAsync(evt);
            }
            catch (Exception ex)
            {
                // Log error but continue processing
                Console.WriteLine($"Error processing event: {ex.Message}");
            }
        }
    }
    
    private async Task ProcessEventAsync(IManagerEvent evt)
    {
        // Event processing logic
        await Task.Delay(1); // Simulate async work
    }
}
## 🤝 Contributing

We welcome contributions to Sufficit.Asterisk.Core! This foundational library benefits from:

### 🎯 Areas for Contribution

* **New Event Types** - Adding support for additional Asterisk events
* **Performance Optimizations** - Improving event processing and memory usage
* **Documentation** - Examples, tutorials, and API documentation
* **Testing** - Unit tests, integration tests, and performance tests
* **Framework Support** - Ensuring compatibility with new .NET versions

### 📝 Contribution Guidelines

1. **Fork the Project**
2. **Create Feature Branch** (`git checkout -b feature/AmazingFeature`)
3. **Add Tests** for new functionality
4. **Update Documentation** as needed
5. **Commit Changes** (`git commit -m 'Add AmazingFeature'`)
6. **Push to Branch** (`git push origin feature/AmazingFeature`)
7. **Open Pull Request**

### 🧪 Testing Requirements

* **Unit Tests** for all new classes and methods
* **Integration Tests** for event processing scenarios
* **Performance Tests** for critical paths
* **Multi-Framework Testing** across supported .NET versions

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

## 📧 Contact

Sufficit - [contato@sufficit.com.br](mailto:contato@sufficit.com.br)

Project Link: [https://github.com/sufficit/sufficit-asterisk-core](https://github.com/sufficit/sufficit-asterisk-core)

---

## 🔗 Related Projects

- **[Sufficit.Asterisk.Manager](https://github.com/sufficit/sufficit-asterisk-manager)** - Quick, temporary AMI operations
- **[Sufficit.AMIEvents](https://github.com/sufficit/sufficit-ami-events)** - Persistent, long-running AMI connections
- **[Sufficit.Asterisk.FastAGI](https://github.com/sufficit/sufficit-asterisk-fastagi)** - FastAGI server implementation  
- **[Sufficit.Asterisk.Utils](https://github.com/sufficit/sufficit-asterisk-utils)** - Asterisk utility functions
- **[Sufficit.Asterisk.Shared](https://github.com/sufficit/sufficit-asterisk-shared)** - Shared components and extensions

## 📚 Additional Resources

- [Asterisk Manager Interface Documentation](https://wiki.asterisk.org/wiki/display/AST/Asterisk+Manager+Interface+%28AMI%29)
- [Asterisk Events Reference](https://wiki.asterisk.org/wiki/display/AST/Asterisk+Manager+Interface+%28AMI%29+Events)
- [.NET Multi-Targeting](https://docs.microsoft.com/en-us/dotnet/standard/frameworks)
- [System.Text.Json Documentation](https://docs.microsoft.com/en-us/dotnet/api/system.text.json)
- [Channel-based Producer-Consumer Pattern](https://docs.microsoft.com/en-us/dotnet/core/extensions/channels)