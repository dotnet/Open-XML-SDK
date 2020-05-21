# Contributing

This project has adopted the [Microsoft Open Source Code of
Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct
FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com)
with any additional questions or comments.

For our general contributing guidelines please see [our dotnet/runtime contributing guide](https://github.com/dotnet/runtime/blob/master/CONTRIBUTING.md).

## Prerequisites

The only prerequisite for building, testing, and deploying from this repository
is the [.NET SDK](https://get.dot.net/).
You should install the version specified in `global.json` or a later version within
the same major.minor.Bxx "hundreds" band.
See [.NET Core Versioning](https://docs.microsoft.com/en-us/dotnet/core/versions/) for more information.

The development experience is best with [Visual Studio][VisualStudio].

## Building

This repository can be built on Windows, Linux, and OSX.

Building, testing, and packing this repository can be done by using the standard dotnet CLI commands (e.g. `dotnet build`, `dotnet test`, `dotnet pack`, etc.).

Since there are a number of targets for the project, and loading all at once may cause slow performance in Visual Studio, the target framework can be controlled by an environment variable. This is controlled in [Directory.Build.props](./Directory.Build.props) via the environment variable `ProjectLoadStyle`. This changes over time, but that file will contain what the available load configurations are. By default, this will try to default to the current LTS version of .NET Core, but allows development against previous targets if needed. This is helpful, for instance, if you don't have the latest .NET installed.  The continuous integration system sets `ProjectLoadStyle=All` to build for all targets.

[VisualStudio]: https://docs.microsoft.com/dotnet/core/install/sdk?pivots=os-windows#install-with-visual-studio