using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    internal static partial class TestAssets
    {
        public static IFile OpenFile(string name, FileAccess access)
        {
            switch (access)
            {
                case FileAccess.Read:
                    return new MemoryFile(GetStream(name), name);
                case FileAccess.ReadWrite:
                    return new MemoryFile(GetStream(name).AsMemoryStream(), name);
                case FileAccess.Write:
                    return new CopiedFile(GetStream(name), Path.GetExtension(name), FileAccess.Write);
                default:
                    throw new InvalidOperationException();
            }
        }

        public static Stream GetStream(string name)
        {
            var assembly = typeof(TestFiles).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Tests.assets.{name}");
            var names = assembly.GetManifestResourceNames().OrderBy(t => t).ToList();

            Assert.NotNull(stream);

            return stream;
        }

        public static Stream GetStream(string name, bool writeable)
        {
            var stream = GetStream(name);

            return writeable ? stream.AsMemoryStream() : stream;
        }

        public static IFile OpenFile(string name) => OpenFile(name, FileAccess.Read);

        public static IFile OpenAsFile(string name, FileAccess access)
        {
            return new CopiedFile(GetStream(name), Path.GetExtension(name), access);
        }

        public static IFile AsFile(string name, FileAccess access) => GetStream(name).AsFile(Path.GetExtension(name), access);

        public static IFile AsFile(this Stream stream, string extension, FileAccess access) => new CopiedFile(stream, extension, access);

        public static MemoryStream AsMemoryStream(this Stream stream)
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
