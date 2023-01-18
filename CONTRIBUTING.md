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

[VisualStudio]: https://docs.microsoft.com/dotnet/core/install/sdk?pivots=os-windows#install-with-visual-studio

## Tests

There are a number of unit tests in the project. Running `dotnet test` will run them. Additionally, builds target `net35` and `netstandard2.0` which by default aren't tested; in order to do that set `TestTargetFramework` to match the test asset framework and `TestDependencyTargetFramework` to set the framework used for the test. This is done automatically on the CI builds to ensure we get some test coverage on those builds (although the `net35` will be run on `net452` since there's no support to run it on `net35` itself).