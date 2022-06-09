// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    public sealed class TemporaryFile : IFile
    {
        private TemporaryFile(string path)
        {
            Path = path;
        }

        public static IFile Create() => new TemporaryFile(System.IO.Path.GetTempFileName());

        public string Path { get; }

        public Stream Open() => File.Open(Path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

        public void Dispose()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
    }
}
