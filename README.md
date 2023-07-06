# Appwrite .NET SDK

![License](https://img.shields.io/github/license/appwrite/sdk-for-dotnet.svg?style=flat-square)
![Version](https://img.shields.io/badge/api%20version-1.3.2-blue.svg?style=flat-square)
[![Build Status](https://img.shields.io/travis/com/appwrite/sdk-generator?style=flat-square)](https://travis-ci.com/appwrite/sdk-generator)
[![Twitter Account](https://img.shields.io/twitter/follow/appwrite?color=00acee&label=twitter&style=flat-square)](https://twitter.com/appwrite)
[![Discord](https://img.shields.io/discord/564160730845151244?label=discord&style=flat-square)](https://appwrite.io/discord)

**This SDK is compatible with Appwrite server version 1.3.x. For older versions, please check [previous releases](https://github.com/appwrite/sdk-for-dotnet/releases).**

Appwrite is an open-source backend as a service server that abstract and simplify complex and repetitive development tasks behind a very simple to use REST API. Appwrite aims to help you develop your apps faster and in a more secure way. Use the .NET SDK to integrate your app with the Appwrite server to easily start interacting with all of Appwrite backend APIs and tools. For full API documentation and tutorials go to [https://appwrite.io/docs](https://appwrite.io/docs)


## Installation

### .NET
Add this reference to your project's `.csproj` file:

```xml
<PackageReference Include="Appwrite" Version="0.4.1" />
```

You can install packages from the command line:

```powershell
# Package Manager
Install-Package Appwrite -Version 0.4.1

# or .NET CLI
dotnet add package Appwrite --version 0.4.1
```



## Getting Started

### Initialize & Make API Request
Once you add the dependencies, its extremely easy to get started with the SDK; All you need to do is import the package in your code, set your Appwrite credentials, and start making API calls. Below is a simple example:

```csharp
using Appwrite;

static async Task Main(string[] args)
{
  var client = Client();

  client
    .setEndpoint('http://[HOSTNAME_OR_IP]/v1') // Make sure your endpoint is accessible
    .setProject('5ff3379a01d25') // Your project ID
    .setKey('cd868c7af8bdc893b4...93b7535db89')
    .setSelfSigned() // Use only on dev mode with a self-signed SSL cert
  ;

  var users = Users(client);

  try {
    var user = await users.Create(ID.Unique(), 'email@example.com', 'password', 'name');
    Console.WriteLine(user.ToMap());
  } catch (AppwriteException e) {
    Console.WriteLine(e.Message);
  }
}
```

### Error Handling
The Appwrite .NET SDK raises `AppwriteException` object with `message`, `code` and `response` properties. You can handle any errors by catching `AppwriteException` and present the `message` to the user or handle it yourself based on the provided error information. Below is an example.

```csharp
var users = Users(client);

try {
  var user = await users.Create(ID.Unique(), 'email@example.com', 'password', 'name');
  Console.WriteLine(user.ToMap());
} catch (AppwriteException e) {
  Console.WriteLine(e.Message);
}
```

### Learn more
You can use the following resources to learn more and get help
- 🚀 [Getting Started Tutorial](https://appwrite.io/docs/getting-started-for-server)
- 📜 [Appwrite Docs](https://appwrite.io/docs)
- 💬 [Discord Community](https://appwrite.io/discord)
- 🚂 [Appwrite Dart Playground](https://github.com/appwrite/playground-for-dotnet)


## Contribution

This library is auto-generated by Appwrite custom [SDK Generator](https://github.com/appwrite/sdk-generator). To learn more about how you can help us improve this SDK, please check the [contribution guide](https://github.com/appwrite/sdk-generator/blob/master/CONTRIBUTING.md) before sending a pull-request.

## License

Please see the [BSD-3-Clause license](https://raw.githubusercontent.com/appwrite/appwrite/master/LICENSE) file for more information.