using System;
using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    internal static class TestAssetExtensions
    {
        public static IFile AsFile(this Stream stream, string extension) => new CopiedFile(stream, extension, FileAccess.ReadWrite);

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
