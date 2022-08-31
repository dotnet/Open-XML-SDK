# Release Process

1. Update CHANGELOG.md with user visible changes
2. Ensure backend is building successfully (it verifies that all data we expect is present in the SDK)
3. Create release (tag)
4. Create AzDo Release to push to NuGet.org
5. Update `PackageValidationBaselineVersion` [here](src/Directory.Build.targets) to new version for backwards compatibility checks