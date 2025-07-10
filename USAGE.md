# Usage Examples - Sufficit.Asterisk.Core

## Getting Started

### Prerequisites

* **.NET SDK** - Version depends on your target framework
* **Asterisk Server** - For testing and integration
* **Basic understanding** of Asterisk concepts (channels, events, actions)

## Event Handling

### Basic Event Processing

```csharp
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
```

## Connection Configuration

### Basic Connection Setup

```csharp
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
```

## Event Subscription System

### Advanced Event Handling

```csharp
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
        Console.WriteLine($"?? New Channel: {evt.Channel}");
        
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
        Console.WriteLine($"?? Call Ended: {evt.Channel}");
        Console.WriteLine($"   Cause: {evt.Cause} ({evt.CauseTxt})");
        
        // Common hangup causes
        switch (evt.Cause)
        {
            case "16": // Normal call clearing
                Console.WriteLine("   ? Normal hangup");
                break;
            case "17": // User busy
                Console.WriteLine("   ?? Busy");
                break;
            case "18": // No user responding
                Console.WriteLine("   ?? No answer");
                break;
            case "19": // No answer from user
                Console.WriteLine("   ? Timeout");
                break;
            default:
                Console.WriteLine($"   ? Other cause: {evt.CauseTxt}");
                break;
        }
    }
    
    private void OnPeerStatus(PeerStatusEvent evt)
    {
        Console.WriteLine($"?? Peer Status: {evt.Peer} -> {evt.PeerStatus}");
        
        switch (evt.PeerStatus?.ToLower())
        {
            case "registered":
                Console.WriteLine("   ? Peer is online");
                break;
            case "unregistered":
                Console.WriteLine("   ? Peer is offline");
                break;
            case "unreachable":
                Console.WriteLine("   ?? Peer is unreachable");
                break;
            case "reachable":
                Console.WriteLine("   ?? Peer is reachable");
                break;
        }
    }
    
    private void OnChannelStateChange(NewStateEvent evt)
    {
        Console.WriteLine($"?? Channel State: {evt.Channel} -> {evt.ChannelState}");
        
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
            Console.WriteLine($"   ?? State: {description}");
        }
    }
}
```

## Custom Event Implementation

### Creating Custom Events

```csharp
using Sufficit.Asterisk.Manager.Events;

/// <summary>
/// Custom event for specific business requirements
/// </summary>
public class CustomBusinessEvent : ManagerEvent
{
    public string? BusinessId { get; set; }
    public string? CustomerNumber { get; set; }
    public string? EventType { get; set; }
    public DateTime Timestamp { get; set; }
    
    public CustomBusinessEvent(ManagerMessage message) : base(message)
    {
        BusinessId = message["BusinessId"];
        CustomerNumber = message["CustomerNumber"];
        EventType = message["EventType"];
        
        if (DateTime.TryParse(message["Timestamp"], out var timestamp))
        {
            Timestamp = timestamp;
        }
    }
}
```

## Multi-Target Framework Support

### Framework-Specific Features

```csharp
#if NET6_0_OR_GREATER
using System.Text.Json;

public class ModernEventProcessor
{
    public string SerializeEvent<T>(T evt) where T : IManagerEvent
    {
        return JsonSerializer.Serialize(evt, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
    }
}
#endif

#if NETSTANDARD2_0
using Newtonsoft.Json;

public class LegacyEventProcessor
{
    public string SerializeEvent<T>(T evt) where T : IManagerEvent
    {
        return JsonConvert.SerializeObject(evt, Formatting.Indented);
    }
}
#endif
```

## Architecture Integration

### Foundation Layer Usage

```csharp
// This library serves as foundation for:

// 1. AMI Managers
public class AMIManager
{
    private readonly IManagerEvent _event;
    private readonly ManagerConnectionParameters _params;
    
    // Uses core events and connection parameters
}

// 2. FastAGI Servers
public class FastAGIServer
{
    private readonly IManagerEvent _event;
    
    // Uses core events for AGI responses
}

// 3. Utility Libraries
public class UtilityService
{
    private readonly ManagerConnectionParameters _params;
    
    // Uses core configuration models
}
```

## Performance Considerations

### Efficient Event Processing

```csharp
public class HighPerformanceEventProcessor
{
    private readonly ConcurrentDictionary<string, Type> _eventTypeCache = new();
    
    public void ProcessEvent(ManagerMessage message)
    {
        var eventName = message.Event;
        if (string.IsNullOrEmpty(eventName))
            return;
            
        // Use cached type lookup for better performance
        var eventType = _eventTypeCache.GetOrAdd(eventName, name =>
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.Equals($"{name}Event", StringComparison.OrdinalIgnoreCase));
        });
        
        if (eventType != null)
        {
            var evt = Activator.CreateInstance(eventType, message) as IManagerEvent;
            // Process the strongly-typed event
        }
    }
}
```

## Error Handling

### Robust Event Processing

```csharp
public class RobustEventProcessor
{
    private readonly ILogger<RobustEventProcessor> _logger;
    
    public async Task ProcessEventSafely(IManagerEvent evt)
    {
        try
        {
            await ProcessEventInternal(evt);
        }
        catch (Exception ex) when (ex is not OperationCanceledException)
        {
            _logger.LogError(ex, "Error processing event {EventType}: {Event}",
                evt.GetType().Name, evt);
                
            // Optionally implement retry logic or dead letter queue
        }
    }
    
    private async Task ProcessEventInternal(IManagerEvent evt)
    {
        // Your event processing logic
        await Task.CompletedTask;
    }
}
```