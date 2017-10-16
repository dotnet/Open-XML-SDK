using System.IO;
using System.Reflection;

namespace DocumentFormat.OpenXml.Tests
{
    internal static class TestFileStreams
    {
        private static Stream GetStream(string name)
        {
            return typeof(TestFileStreams).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Tests.assets.TestFiles.{name}");
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

        public static Stream _5Errors => GetStream("5Errors.docx");

        public static Stream Algn_tab_TabAlignment => GetStream("Algn_tab_TabAlignment.pptx");

        public static Stream animation => GetStream("animation.pptx");

        public static Stream AnnotationRef => GetStream("AnnotationRef.docx");

        public static Stream autosave => GetStream("autosave.pptx");

        public static Stream basicspreadsheet => GetStream("basicspreadsheet.xlsx");

        public static Stream Comments => GetStream("Comments.xlsx");

        public static Stream complex0docx => GetStream("complex0.docx");

        public static Stream complex2010docx => GetStream("complex2010.docx");

        public static Stream excel14 => GetStream("excel14.xlsx");

        public static Stream extlst => GetStream("extlst.xlsx");

        public static Stream HelloO14 => GetStream("HelloO14.docx");

        public static Stream mailmerge => GetStream("mailmerge.docx");

        public static Stream May_12_04 => GetStream("May_12_04.docx");

        public static Stream mcdoc => GetStream("mcdoc.docx");

        public static Stream MCExecl => GetStream("MCExecl.xlsx");

        public static Stream mcppt => GetStream("mcppt.pptx");

        public static Stream mediareference => GetStream("mediareference.pptx");

        public static Stream o09_Performance_typical_pptx => GetStream("o09_Performance_typical.pptx");

        public static Stream Revision___NameCommentChange => GetStream("Revision_NameCommentChange.xlsx");

        public static Stream simpleSdt => GetStream("simpleSdt.docx");

        public static Stream vmldrawingroot => GetStream("vmldrawingroot.xlsx");

        public static Stream Youtube => GetStream("Youtube.xlsx");
    }
}
