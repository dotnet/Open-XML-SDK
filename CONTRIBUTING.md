# Contributing

This project has adopted the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/about/policies/code-of-conduct).

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

[VisualStudio]: https://docs.microsoft.com/dotnet/core/install/sdk?pivots=os-windows#install-with-visual-studio
