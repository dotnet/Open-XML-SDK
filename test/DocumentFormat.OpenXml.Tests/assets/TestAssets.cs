// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    internal static partial class TestAssets
    {
        /// <summary>
        /// Open a file in memory for a test stream
        /// </summary>
        /// <param name="name">Name of embedded resource</param>
        /// <param name="isEditable">Whether resulting stream should be editable</param>
        /// <returns></returns>
        public static IFile OpenFile(string name, bool isEditable)
        {
            if (isEditable)
            {
                return new MemoryFile(GetStream(name).AsMemoryStream(), name);
            }
            else
            {
                return new MemoryFile(GetStream(name), name);
            }
        }

        /// <summary>
        /// Open a test file as an actual file on disk. Must be disposed to delete file
        /// </summary>
        /// <param name="name">Name of embedded resource</param>
        /// <param name="access">FileAccess type for file</param>
        /// <returns></returns>
        public static IFile OpenFile(string name, FileAccess access)
        {
            return new CopiedFile(GetStream(name), Path.GetExtension(name), access);
        }

        /// <summary>
        /// Gets a readonly stream for a test file
        /// </summary>
        /// <param name="name">Name of embedded resource</param>
        /// <returns></returns>
        public static Stream GetStream(string name)
        {
            var assembly = typeof(TestFiles).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Tests.assets.{name}");
            var names = assembly.GetManifestResourceNames().OrderBy(t => t).ToList();

            Assert.NotNull(stream);

            return stream;
        }

        /// <summary>
        /// Gets a stream for a test file
        /// </summary>
        /// <param name="name">Name of embedded resource</param>
        /// <param name="isEditable">Whether resulting stream should be editable</param>
        /// <returns></returns>
        public static Stream GetStream(string name, bool isEditable)
        {
            var stream = GetStream(name);

            return isEditable ? stream.AsMemoryStream() : stream;
        }

        private static Stream AsMemoryStream(this Stream stream)
        {
            if (stream is MemoryStream ms)
            {
                return ms;
            }
            else
            {
                using (stream)
                {
                    var result = new MemoryStream();
                    stream.CopyTo(result);
                    return result;
                }
            }
        }

        private class MemoryFile : IFile
        {
            private readonly Stream _stream;

            public MemoryFile(Stream stream, string path)
            {
                Path = path;
                _stream = stream;
            }

            public string Path { get; }

            public Stream Open() => _stream;

            public void Dispose()
            {
                _stream.Dispose();
            }
        }

        private class CopiedFile : IFile
        {
            private readonly FileAccess _access;

            public CopiedFile(Stream stream, string extension, FileAccess access)
            {
                Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"{Guid.NewGuid()}{extension}");

                _access = access;

                using (var fs = File.OpenWrite(Path))
                {
                    stream.CopyTo(fs);
                }
            }

            public string Path { get; }

            public Stream Open() => File.Open(Path, FileMode.Open, _access);

            public void Dispose()
            {
                File.Delete(Path);
            }
        }
    }
}
