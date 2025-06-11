<h1>
  Sufficit.Asterisk.Core
  <a href="https://github.com/sufficit"><img src="https://avatars.githubusercontent.com/u/66928451?s=200&v=4" alt="Sufficit Logo" width="80" align="right"></a>
</h1>

[![NuGet](https://img.shields.io/nuget/v/Sufficit.Asterisk.Core.svg)](https://www.nuget.org/packages/Sufficit.Asterisk.Core/)

## 📖 About the Project

`Sufficit.Asterisk.Core` is the central module for the Sufficit Asterisk integration. It contains the main business logic, entities, and foundational code that underpins the communication between the Sufficit platform and Asterisk servers. This project serves as the base for all other Asterisk-related modules in the Sufficit ecosystem.

### ✨ Key Features

* Core data models (Channels, Calls, Agents, etc.).
* Business logic for handling Asterisk events.
* Essential services for interacting with Asterisk.
* Connection abstractions and configurations.

## 🚀 Getting Started

This project is a class library. The recommended way to use it is by installing the NuGet package into your project.

### 📦 NuGet Package

You can install the package via the .NET CLI or the NuGet Package Manager Console.

**.NET CLI:**

    dotnet add package Sufficit.Asterisk.Core

**Package Manager Console:**

    Install-Package Sufficit.Asterisk.Core

## 🛠️ Usage

This is a core library project and is typically not run standalone. It should be referenced by other projects in the Sufficit Asterisk ecosystem.

After installation, you can use the classes and models from the library:

**Example (`.csproj` file):**

    <ItemGroup>
      <PackageReference Include="Sufficit.Asterisk.Core" Version="x.x.x" />
    </ItemGroup>

**Example (C# Code):**

    using Sufficit.Asterisk.Core.Events;

    public void HandleNewChannel(NewChannelEvent newChannelEvent)
    {
        Console.WriteLine($"New channel created: {newChannelEvent.Channel}");
    }

## 🤝 Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1.  Fork the Project.
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`).
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`).
4.  Push to the Branch (`git push origin feature/AmazingFeature`).
5.  Open a Pull Request.

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

## 📧 Contact

Sufficit - [contato@sufficit.com.br](mailto:contato@sufficit.com.br)

Project Link: [https://github.com/sufficit/sufficit-asterisk-core](https://github.com/sufficit/sufficit-asterisk-core)