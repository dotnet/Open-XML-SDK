using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    internal static partial class TestAssets
    {
        public static IFile Open(string name, FileAccess access)
        {
            switch (access)
            {
                case FileAccess.Read:
                    return new MemoryFile(GetStream(name), name);
                case FileAccess.ReadWrite:
                    return new MemoryFile(GetStream(name).AsMemoryStream(), name);
                case FileAccess.Write:
                    return GetStream(name).AsFile(Path.GetExtension(name), access);
                default:
                    throw new InvalidOperationException();
            }
        }

        public static IFile Open(string name) => Open(name, FileAccess.Read);

        public static IFile AsFile(string name) => GetStream(name).AsFile(Path.GetExtension(name));

        public static IFile AsFile(string name, FileAccess access) => GetStream(name).AsFile(Path.GetExtension(name), access);

        public static Stream GetStream(string name)
        {
            var assembly = typeof(TestFileStreams).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Tests.assets.{name}");
            var names = assembly.GetManifestResourceNames().OrderBy(t => t).ToList();

            Assert.NotNull(stream);

            return stream;
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
    }
}
