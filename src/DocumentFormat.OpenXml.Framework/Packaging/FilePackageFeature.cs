// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class FilePackageFeature : StreamPackageFeature
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
            PackageOpenMode.ReadWrite => FileMode.OpenOrCreate,
            _ => throw new NotImplementedException(),
        };
        var share = openMode == PackageOpenMode.Read ? FileShare.Read : FileShare.None;

        return File.Open(path, mode, access, share);
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
