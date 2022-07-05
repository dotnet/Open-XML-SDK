// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class OpenXmlNamespaceTests
    {
        [Fact]
        public void NamespaceCount()
        {
            var resolver = new OpenXmlNamespaceResolver();
            Assert.Equal(148, resolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope.All).Count);
        }

        [InlineData("", "", FileFormatVersions.Office2007, 0)]
        [InlineData("http://www.w3.org/XML/1998/namespace", "xml", FileFormatVersions.Office2007, 1)]
        [InlineData("http://schemas.openxmlformats.org/package/2006/metadata/core-properties", "cp", FileFormatVersions.Office2007, 2)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", "ap", FileFormatVersions.Office2007, 3)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/custom-properties", "op", FileFormatVersions.Office2007, 4)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", "vt", FileFormatVersions.Office2007, 5)]
        [InlineData("http://purl.org/dc/elements/1.1/", "dc", FileFormatVersions.Office2007, 6)]
        [InlineData("http://purl.org/dc/terms/", "dcterms", FileFormatVersions.Office2007, 7)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/characteristics", "ac", FileFormatVersions.Office2007, 8)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/bibliography", "b", FileFormatVersions.Office2007, 9)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/main", "a", FileFormatVersions.Office2007, 10)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/chart", "c", FileFormatVersions.Office2007, 11)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", "cdr", FileFormatVersions.Office2007, 12)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/compatibility", "comp", FileFormatVersions.Office2007, 13)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/diagram", "dgm", FileFormatVersions.Office2007, 14)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas", "lc", FileFormatVersions.Office2007, 15)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", "wp", FileFormatVersions.Office2007, 16)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/picture", "pic", FileFormatVersions.Office2007, 17)]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing", "xdr", FileFormatVersions.Office2007, 18)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/relationships", "r", FileFormatVersions.Office2007, 19)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/customXml", "ds", FileFormatVersions.Office2007, 20)]
        [InlineData("http://schemas.openxmlformats.org/officeDocument/2006/math", "m", FileFormatVersions.Office2007, 21)]
        [InlineData("http://schemas.openxmlformats.org/spreadsheetml/2006/main", "x", FileFormatVersions.Office2007, 22)]
        [InlineData("http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w", FileFormatVersions.Office2007, 23)]
        [InlineData("http://schemas.openxmlformats.org/presentationml/2006/main", "p", FileFormatVersions.Office2007, 24)]
        [InlineData("http://schemas.openxmlformats.org/schemaLibrary/2006/main", "sl", FileFormatVersions.Office2007, 25)]
        [InlineData("urn:schemas-microsoft-com:vml", "v", FileFormatVersions.Office2007, 26)]
        [InlineData("urn:schemas-microsoft-com:office:office", "o", FileFormatVersions.Office2007, 27)]
        [InlineData("urn:schemas-microsoft-com:office:word", "w10", FileFormatVersions.Office2007, 28)]
        [InlineData("urn:schemas-microsoft-com:office:excel", "xvml", FileFormatVersions.Office2007, 29)]
        [InlineData("urn:schemas-microsoft-com:office:powerpoint", "pvml", FileFormatVersions.Office2007, 30)]
        [InlineData("http://schemas.openxmlformats.org/markup-compatibility/2006", "mc", FileFormatVersions.Office2007, 31)]
        [InlineData("http://schemas.microsoft.com/office/excel/2006/main", "xne", FileFormatVersions.Office2007, 32)]
        [InlineData("http://schemas.microsoft.com/office/word/2006/wordml", "wne", FileFormatVersions.Office2007, 33)]
        [InlineData("http://schemas.microsoft.com/office/2006/01/customui", "mso", FileFormatVersions.Office2007, 34)]
        [InlineData("http://schemas.microsoft.com/office/2006/activeX", "ax", FileFormatVersions.Office2007, 35)]
        [InlineData("http://schemas.microsoft.com/office/2006/coverPageProps", "cppr", FileFormatVersions.Office2007, 36)]
        [InlineData("http://schemas.microsoft.com/office/2006/customDocumentInformationPanel", "cdip", FileFormatVersions.Office2007, 37)]
        [InlineData("http://schemas.microsoft.com/office/2006/metadata/contentType", "ct", FileFormatVersions.Office2007, 38)]
        [InlineData("http://schemas.microsoft.com/office/2006/metadata/customXsn", "ntns", FileFormatVersions.Office2007, 39)]
        [InlineData("http://schemas.microsoft.com/office/2006/metadata/longProperties", "lp", FileFormatVersions.Office2007, 40)]
        [InlineData("http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes", "ma", FileFormatVersions.Office2007, 41)]
        [InlineData("http://www.w3.org/2001/XMLSchema", "xsd", FileFormatVersions.Office2007, 42)]
        [InlineData("http://www.w3.org/2003/InkML", "inkml", FileFormatVersions.Office2007, 43)]
        [InlineData("http://www.w3.org/2003/04/emma", "emma", FileFormatVersions.Office2007, 44)]
        [InlineData("http://schemas.microsoft.com/ink/2010/main", "msink", FileFormatVersions.Office2007, 45)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2007/8/2/chart", "c14", FileFormatVersions.Office2010, 46)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2010/chartDrawing", "cdr14", FileFormatVersions.Office2010, 47)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2010/main", "a14", FileFormatVersions.Office2010, 48)]
        [InlineData("http://schemas.microsoft.com/office/powerpoint/2010/main", "p14", FileFormatVersions.Office2010, 49)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2010/picture", "pic14", FileFormatVersions.Office2010, 50)]
        [InlineData("http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing", "wp14", FileFormatVersions.Office2010, 51)]
        [InlineData("http://schemas.microsoft.com/office/word/2010/wordml", "w14", FileFormatVersions.Office2010, 52)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2009/9/main", "x14", FileFormatVersions.Office2010, 53)]
        [InlineData("http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing", "xdr14", FileFormatVersions.Office2010, 54)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac", "x14ac", FileFormatVersions.Office2010, 55)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2008/diagram", "dsp", FileFormatVersions.Office2010, 56)]
        [InlineData("http://schemas.microsoft.com/office/2009/07/customui", "mso14", FileFormatVersions.Office2010, 57)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2010/diagram", "dgm14", FileFormatVersions.Office2010, 58)]
        [InlineData("http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas", "wpc", FileFormatVersions.Office2010, 59)]
        [InlineData("http://schemas.microsoft.com/office/word/2010/wordprocessingGroup", "wpg", FileFormatVersions.Office2010, 60)]
        [InlineData("http://schemas.microsoft.com/office/word/2010/wordprocessingShape", "wps", FileFormatVersions.Office2010, 61)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2010/slicer", "sle", FileFormatVersions.Office2010, 62)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2010/compatibility", "com14", FileFormatVersions.Office2010, 63)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2012/chart", "c15", FileFormatVersions.Office2013, 64)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2012/chartStyle", "cs", FileFormatVersions.Office2013, 65)]
        [InlineData("http://schemas.microsoft.com/office/webextensions/webextension/2010/11", "we", FileFormatVersions.Office2013, 66)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2012/main", "a15", FileFormatVersions.Office2013, 67)]
        [InlineData("http://schemas.microsoft.com/office/powerpoint/2012/main", "p15", FileFormatVersions.Office2013, 68)]
        [InlineData("http://schemas.microsoft.com/office/word/2012/wordml", "w15", FileFormatVersions.Office2013, 69)]
        [InlineData("http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11", "wetp", FileFormatVersions.Office2013, 70)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2010/11/main", "x15", FileFormatVersions.Office2013, 71)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac", "x12ac", FileFormatVersions.Office2013, 72)]
        [InlineData("http://schemas.microsoft.com/office/thememl/2012/main", "thm15", FileFormatVersions.Office2013, 73)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac", "x15ac", FileFormatVersions.Office2013, 74)]
        [InlineData("http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing", "wp15", FileFormatVersions.Office2013, 75)]
        [InlineData("http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings", "pRoam", FileFormatVersions.Office2013, 76)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2012/timeslicer", "tsle", FileFormatVersions.Office2013, 77)]
        [InlineData("http://schemas.microsoft.com/office/powerpoint/2015/main", "p16", FileFormatVersions.Office2016, 78)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2014/main", "a16", FileFormatVersions.Office2016, 79)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2014/chartex", "cx", FileFormatVersions.Office2016, 80)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2014/chart/ac", "c16ac", FileFormatVersions.Office2016, 81)]
        [InlineData("http://schemas.microsoft.com/office/drawing/2014/chart", "c16", FileFormatVersions.Office2016, 82)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2014/revision", "xr", FileFormatVersions.Office2016, 83)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2014/11/main", "x16", FileFormatVersions.Office2016, 84)]
        [InlineData("http://schemas.microsoft.com/office/spreadsheetml/2015/02/main", "x16r2", FileFormatVersions.Office2016, 85)]
        [InlineData("http://schemas.microsoft.com/office/word/2015/wordml/symex", "w16se", FileFormatVersions.Office2016, 86)]
        [Theory]
        public void NamespacePrefixTest(string ns, string prefix, FileFormatVersions version, byte id)
        {
            var resolver = new OpenXmlNamespaceResolver();
            var idResolver = new OpenXmlNamespaceIdResolver();

            var idPrefix = idResolver.GetPrefix(id);
            var idUri = resolver.LookupNamespace(idPrefix);

            var nsFromNs = new OpenXmlNamespace(ns);
            var nsFromId = new OpenXmlNamespace(idUri);

            Assert.Equal(nsFromNs, nsFromId);
            Assert.Equal(ns, resolver.LookupNamespace(prefix));
            Assert.Equal(prefix, resolver.LookupPrefix(ns));

            foreach (var v in FileFormatVersionExtensions.AllVersions)
            {
                Assert.Equal(v == version, resolver.GetVersion(nsFromNs) == v);
                Assert.Equal(v == version, resolver.HasVersion(nsFromNs, v));
            }
        }
    }
}
