// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests;

public class FilePackageFeatureTests
{
    [Fact]
    public void OpenInvalidFileFailsGracefully()
    {
        // Arrange
        var path = Path.GetTempFileName();
        File.WriteAllText(path, "This is not a valid document");

        // Act
        Assert.Throws<FileFormatException>(() => new FilePackageFeature(path, PackageOpenMode.Read));

        // Assert
        using var reopened = File.Open(path, FileMode.Open, FileAccess.Read);
        Assert.NotNull(reopened);
    }
}
