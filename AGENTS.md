# Open XML SDK repository instructions

## Build, test, and analyzer commands

Run commands from the repository root.

- Restore: `dotnet restore Open-XML-SDK.slnx`
- Build the solution: `dotnet build Open-XML-SDK.slnx --no-restore`
- Run the full test suite: `dotnet test Open-XML-SDK.slnx --no-restore`
- Run one test project: `dotnet test --project test/DocumentFormat.OpenXml.Framework.Tests/DocumentFormat.OpenXml.Framework.Tests.csproj --no-restore`
- Run one test: `dotnet test --project test/DocumentFormat.OpenXml.Framework.Tests/DocumentFormat.OpenXml.Framework.Tests.csproj --no-restore --filter "FullyQualifiedName~DocumentFormat.OpenXml.Framework.Tests.ElementLookupTests.BuiltInOpenXmlElements"`
- Collect the same xUnit TRX-style output CI uses: `dotnet test Open-XML-SDK.slnx --no-restore -- --results-directory ./test-results --report-xunit-trx`

There is no separate lint command in the repo. `dotnet build` is the analyzer pass: StyleCop and .NET analyzers are wired in through `Directory.Build.targets` / `src/Directory.Build.props`, and release builds treat warnings as errors.

Use the .NET SDK from `global.json` (`10.0.100`, with `rollForward: feature`).

## High-level architecture

The repository is split into four main product assemblies plus in-repo code generation:

- `src/DocumentFormat.OpenXml.Framework`: low-level package, part, element, metadata, validation, and feature infrastructure. `OpenXmlPackage`, `OpenXmlPart`, and `OpenXmlElement` live here.
- `src/DocumentFormat.OpenXml`: the main SDK surface. It layers strongly typed parts, schema types, factories, and document types on top of the framework assembly.
- `src/DocumentFormat.OpenXml.Features`: opt-in package/document features that extend the main SDK without bloating the core assembly.
- `src/DocumentFormat.OpenXml.Linq`: XLINQ-focused helpers layered on top of the framework package.
- `gen/` + `data/`: schema/part metadata is stored as JSON under `data/`, then consumed by the Roslyn source generator projects in `gen/` during build.

Generated code is emitted into the top-level `generated/<ProjectName>/` tree. CI deletes `*.g.cs`, rebuilds, and fails if `generated/` changes unexpectedly, so schema- or generator-related edits must leave that tree up to date.

Tests are organized by layer (`Framework.Tests`, `Packaging.Tests`, `Linq.Tests`, etc.). Binary/sample fixtures live in `test/DocumentFormat.OpenXml.Tests.Assets` as embedded resources, and shared helper code under `test/Common` is linked into each test project by `test/Directory.Build.targets`.

## Key repository conventions

- Do not hand-edit files under `generated/`. Change the source generator inputs (`data/**`, `gen/**`) or the handwritten partials in `src/**`, then rebuild so the generated output is refreshed.
- Many public SDK types are `partial` because generated code provides the bulk of the API surface and handwritten partials add special behavior. When adjusting schema-specific behavior, look for an existing handwritten partial beside the generated type before introducing a new pattern.
- Core behavior is feature-driven. Packages, parts, and elements commonly resolve behavior through `IFeatureCollection` (`Features.Get<T>()` / `GetRequired<T>()`) rather than hard-coded service lookups.
- Public API compatibility is tracked with `PublicAPI/PublicAPI.*.txt` files included as analyzer inputs. If a change intentionally modifies the public surface, update the relevant shipped/unshipped API files in that project.
- The repo is heavily multi-targeted. Root `Directory.Build.props` controls product, framework, test, and sample target frameworks, and CI also exercises `ProjectLoadStyle=net35`, `net40`, and `All`. Avoid changes that only work on the newest target unless the project file already gates them.
