// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Features;

internal sealed class FilePackageFeature : StreamPackageFeature, IPackageStreamFeature
{
    public FilePackageFeature(string path, PackageOpenMode mode)
        : base(CreateStream(path, mode), mode)
    {
    }

    private static Stream CreateStream(string path, PackageOpenMode openMode)
    {
        var access = openMode == PackageOpenMode.Read ? FileAccess.Read : FileAccess.ReadWrite;
        var mode = openMode switch
        {
            PackageOpenMode.Create => FileMode.Create,
            PackageOpenMode.Read => FileMode.Open,
            PackageOpenMode.ReadWrite => FileMode.Open,
            _ => throw new NotImplementedException(),
        };
        var share = openMode == PackageOpenMode.Read ? FileShare.Read : FileShare.None;

        return File.Open(path, mode, access, share);
    }

    Stream IPackageStreamFeature.Stream
    {
        get => Stream;
        set
        {
            var previous = Stream;
            Stream = value;
            previous.Dispose();
        }
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (disposing)
        {
            Stream.Dispose();
        }
    }
}
