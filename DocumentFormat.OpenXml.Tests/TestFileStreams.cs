using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public interface IFile : IDisposable
    {
        string Path { get; }

        Stream Open();
    }

    internal class MemoryFile : IFile
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

    internal class TemporaryFile : IFile
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

    internal static class TestAssets
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

        public static class TestDataStorage
        {
            public static class V2FxTestFiles
            {
                public static class Bvt
                {
                    public const string complex2005_12rtm = "TestDataStorage.v2FxTestFiles.bvt.complex2005_12rtm.docx";

                    public const string O12Typical = "TestDataStorage.v2FxTestFiles.bvt.O12Typical.pptx";

                    public const string PerformanceEng = "TestDataStorage.v2FxTestFiles.bvt.PerformanceEng.xlsx";
                }
            }
        }

    }

    internal static class TestFileStreams
    {
        private static Stream GetStream(string name)
        {
            return typeof(TestFileStreams).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Tests.assets.TestFiles.{name}");
        }

        public static IFile AsFile(this Stream stream, string extension) => new CopiedFile(stream, extension, FileAccess.ReadWrite);

        public static IFile AsFile(this Stream stream, string extension, FileAccess access) => new CopiedFile(stream, extension, access);

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

        public static class Templates
        {
            public static Stream Document => GetStream("Document.dotx");

            public static Stream Presentation = GetStream("Presentation.potx");

            public static Stream Spreadsheet = GetStream("Spreadsheet.xltx");
        }

        public static Stream _5Errors => GetStream("5Errors.docx");

        public static Stream Algn_tab_TabAlignment => GetStream("Algn_tab_TabAlignment.pptx");

        public static Stream animation => GetStream("animation.pptx");

        public static Stream AnnotationRef => GetStream("AnnotationRef.docx");

        public static Stream autosave => GetStream("autosave.pptx");

        public static Stream basicspreadsheet => GetStream("basicspreadsheet.xlsx");

        public static Stream Comments => GetStream("Comments.xlsx");

        public static Stream CommentsDocx => GetStream("Comments.docx");

        public static Stream complex0docx => GetStream("complex0.docx");

        public static Stream complex2010docx => GetStream("complex2010.docx");

        public static Stream DataBoundContentControls => GetStream("Data-Bound-Content-Controls.docx");

        public static Stream Document => GetStream("Document.docx");

        public static Stream DocPropertiesPath => GetStream("DocProperties.xml");

        public static Stream excel14 => GetStream("excel14.xlsx");

        public static Stream extlst => GetStream("extlst.xlsx");

        public static Stream HelloO14 => GetStream("HelloO14.docx");

        public static Stream Hyperlink => GetStream("Hyperlink.docx");

        public static Stream Image => GetStream("Image.png");

        public static Stream mailmerge => GetStream("mailmerge.docx");

        public static Stream May_12_04 => GetStream("May_12_04.docx");

        public static Stream mcdoc => GetStream("mcdoc.docx");

        public static Stream MCExecl => GetStream("MCExecl.xlsx");

        public static Stream mcppt => GetStream("mcppt.pptx");

        public static Stream mediareference => GetStream("mediareference.pptx");

        public static Stream o09_Performance_typical_pptx => GetStream("o09_Performance_typical.pptx");

        public static Stream Plain => GetStream("Plain.docx");

        public static Stream Presentation => GetStream("Presentation.pptx");

        public static Stream Revision___NameCommentChange => GetStream("Revision_NameCommentChange.xlsx");

        public static Stream simpleSdt => GetStream("simpleSdt.docx");

        public static Stream Spreadsheet => GetStream("Spreadsheet.xlsx");

        public static Stream Strict01 => GetStream("Strict01.docx");

        public static Stream vmldrawingroot => GetStream("vmldrawingroot.xlsx");

        public static Stream UnknownElement => GetStream("UnknownElement.docx");

        public static Stream Youtube => GetStream("Youtube.xlsx");
    }
}
