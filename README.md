# Sufficit.Asterisk.Core

[![NuGet](https://img.shields.io/nuget/v/Sufficit.Asterisk.Core.svg)](https://www.nuget.org/packages/Sufficit.Asterisk.Core/)

## Description

`Sufficit.Asterisk.Core` is the **foundational library** for all Asterisk-related operations in the Sufficit ecosystem. It provides essential data models, interfaces, events, and configuration classes that serve as the building blocks for AMI connections, FastAGI servers, and telephony applications. This library is designed to be **framework-agnostic** and **multi-target**, supporting everything from .NET Standard 2.0 for legacy applications to the latest .NET 9 for modern cloud-native services.

## Features

### Core Components
- **Manager Events** - Comprehensive event models for all Asterisk AMI events
- **Manager Actions** - Action classes for AMI command execution
- **Connection Interfaces** - Abstractions for AMI and AGI connections
- **Configuration Models** - Settings classes for connection parameters
- **Extension Methods** - Utility methods for common operations
- **Multi-Framework Support** - .NET Standard 2.0, .NET 6, 7, 8, 9

### Event System
- **Type-safe event handling** with strongly-typed event classes
- **Event inheritance hierarchy** for efficient event processing
- **Custom event registration** support
- **Event metadata** including timestamps and system information

### Configuration Management
- **Connection parameters** with validation
- **Reconnection policies** with progressive backoff
- **SSL/TLS support** configuration
- **Timeout and retry settings**

### Multi-Target Framework Support

| Framework | Use Case | Benefits |
|-----------|----------|----------|
| **.NET Standard 2.0** | Legacy applications, Xamarin | Maximum compatibility |
| **.NET 6** | Long-term support applications | Stable, supported until 2024 |
| **.NET 7** | Current applications | Performance improvements |
| **.NET 8** | Modern LTS applications | Latest LTS with best performance |
| **.NET 9** | Cutting-edge applications | Latest features and optimizations |

## Installation

**.NET CLI:**dotnet add package Sufficit.Asterisk.Core
**Package Manager Console:**Install-Package Sufficit.Asterisk.Core
**Package References:**<PackageReference Include="Sufficit.Asterisk.Core" Version="1.*" />
## Usage

For detailed usage examples and documentation, see [USAGE.md](USAGE.md).

## License

This project is licensed under the [MIT License](LICENSE).

## References and Thanks

This project builds upon the excellent foundation provided by several open-source Asterisk .NET libraries. We would like to express our sincere gratitude to the original authors and contributors:

### Reference Projects

- **[Asterisk.NET by roblthegreat](https://github.com/roblthegreat/Asterisk.NET)** - One of the original Asterisk .NET implementations that served as initial inspiration and reference for AMI protocol handling.

- **[AsterNET by AsterNET Team](https://github.com/AsterNET/AsterNET)** - A comprehensive Asterisk .NET library that provided valuable insights into event parsing, action implementations, and connection management patterns.

These projects were instrumental in understanding Asterisk protocols, best practices, and .NET integration patterns. While Sufficit.Asterisk.Core has been developed from the ground up with modern .NET practices and our specific architectural requirements, we acknowledge the valuable learning and inspiration drawn from these pioneering efforts.

**Made with ❤️ by the Sufficit Team**