// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Features;

internal sealed class FilePackageFeature : StreamPackageFeature, IPackageStreamFeature
{
    private readonly string _path;

    public FilePackageFeature(string path, PackageOpenMode mode)
        : base(CreateStream(path, mode), mode, isOwned: true)
    {
        _path = path;
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

    protected override Stream GetStream(FileMode mode, FileAccess access)
    {
        if (_path is null)
        {
            return Stream;
        }

        if (Mode == mode && Access == access)
        {
            return Stream;
        }

        DisposeStreamIfOwned();

        var share = access == FileAccess.ReadWrite ? FileShare.None : FileShare.Read;

        return File.Open(_path, mode, access, share);
    }
}
