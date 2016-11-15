using System.IO;
using System.Reflection;

namespace DocumentFormat.OpenXml.Tests
{
    internal static class TestFileStreams
    {
        private static byte[] GetStream(string name)
        {
            using (var stream = typeof(TestFileStreams).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Tests.{name}"))
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);

                return ms.ToArray();
            }
        }

        public static byte[] _5Errors => GetStream("5Errors.docx");

        public static byte[] Algn_tab_TabAlignment => GetStream("Algn_tab_TabAlignment.pptx");

        public static byte[] animation => GetStream("animation.pptx");

        public static byte[] AnnotationRef => GetStream("AnnotationRef.docx");

        public static byte[] autosave => GetStream("autosave.pptx");

        public static byte[] basicspreadsheet => GetStream("basicspreadsheet.xlsx");

        public static byte[] Comments => GetStream("Comments.xlsx");

        public static byte[] complex0docx => GetStream("complex0.docx");

        public static byte[] complex2010docx => GetStream("complex2010.docx");

        public static byte[] excel14 => GetStream("excel14.xlsx");

        public static byte[] extlst => GetStream("extlst.xlsx");

        public static byte[] HelloO14 => GetStream("HelloO14.docx");

        public static byte[] mailmerge => GetStream("mailmerge.docx");

        public static byte[] May_12_04 => GetStream("May_12_04.docx");

        public static byte[] mcdoc => GetStream("mcdoc.docx");

        public static byte[] MCExecl => GetStream("MCExecl.xlsx");

        public static byte[] mcppt => GetStream("mcppt.pptx");

        public static byte[] mediareference => GetStream("mediareference.pptx");

        public static byte[] o09_Performance_typical_pptx => GetStream("o09_Performance_typical.pptx");

        public static byte[] Revision___NameCommentChange => GetStream("Revision_NameCommentChange.xlsx");

        public static byte[] simpleSdt => GetStream("simpleSdt.docx");

        public static byte[] vmldrawingroot => GetStream("vmldrawingroot.xlsx");

        public static byte[] Youtube => GetStream("Youtube.xlsx");
    }
}