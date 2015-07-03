/***************************************************************************

Copyright (c) Microsoft Corporation 2012-2013.

This code is licensed using the Microsoft Public License (Ms-PL).  The text of the license can be found here:

http://www.microsoft.com/resources/sharedsource/licensingbasics/publiclicense.mspx

Published at http://OpenXmlDeveloper.org
Resource Center and Documentation: http://openxmldeveloper.org/wiki/w/wiki/powertools-for-open-xml.aspx

Developer: Eric White
Blog: http://www.ericwhite.com
Twitter: @EricWhiteDev
Email: eric@ericwhite.com

Version: 2.7.03
 * Enhancements to support RTL

Version: 2.6.00
 * Enhancements to support HtmlConverter.cs

***************************************************************************/

using System;
using System.IO;
using System.IO.Packaging;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;
using System.Drawing;

namespace OpenXmlPowerTools
{
    public static class PtOpenXmlExtensions
    {
        public static XDocument GetXDocument(this OpenXmlPart part)
        {
            try
            {
                XDocument partXDocument = part.Annotation<XDocument>();
                if (partXDocument != null)
                    return partXDocument;
                using (Stream partStream = part.GetStream())
                {
                    if (partStream.Length == 0)
                    {
                        partXDocument = new XDocument();
                        partXDocument.Declaration = new XDeclaration("1.0", "UTF-8", "yes");
                    }
                    else
                        using (XmlReader partXmlReader = XmlReader.Create(partStream))
                            partXDocument = XDocument.Load(partXmlReader);
                }
                part.AddAnnotation(partXDocument);
                return partXDocument;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static XDocument GetXDocument(this OpenXmlPart part, out XmlNamespaceManager namespaceManager)
        {

            XDocument partXDocument = part.Annotation<XDocument>();
            namespaceManager = part.Annotation<XmlNamespaceManager>();
            if (partXDocument != null)
            {
                if (namespaceManager != null)
                    return partXDocument;
                namespaceManager = GetManagerFromXDocument(partXDocument);
                part.AddAnnotation(namespaceManager);
                return partXDocument;
            }

            using (Stream partStream = part.GetStream())
            {
                if (partStream.Length == 0)
                {
                    partXDocument = new XDocument();
                    partXDocument.Declaration = new XDeclaration("1.0", "UTF-8", "yes");
                    part.AddAnnotation(partXDocument);
                    return partXDocument;
                }
                else
                {
                    using (XmlReader partXmlReader = XmlReader.Create(partStream))
                    {
                        partXDocument = XDocument.Load(partXmlReader);
                        XmlNameTable nameTable = partXmlReader.NameTable;
                        namespaceManager = new XmlNamespaceManager(nameTable);
                        part.AddAnnotation(partXDocument);
                        part.AddAnnotation(namespaceManager);
                        return partXDocument;
                    }
                }
            }
        }

        public static void PutXDocument(this OpenXmlPart part)
        {
            XDocument partXDocument = part.GetXDocument();
            if (partXDocument != null)
            {
#if true
                using (Stream partStream = part.GetStream(FileMode.Create, FileAccess.Write))
                using (XmlWriter partXmlWriter = XmlWriter.Create(partStream))
                    partXDocument.Save(partXmlWriter);
#else
                byte[] array = Encoding.UTF8.GetBytes(partXDocument.ToString(SaveOptions.DisableFormatting));
                using (MemoryStream ms = new MemoryStream(array))
                    part.FeedData(ms);
#endif
            }
        }

        public static void PutXDocumentWithFormatting(this OpenXmlPart part)
        {
            XDocument partXDocument = part.GetXDocument();
            if (partXDocument != null)
            {
                using (Stream partStream = part.GetStream(FileMode.Create, FileAccess.Write))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.OmitXmlDeclaration = true;
                    settings.NewLineOnAttributes = true;
                    using (XmlWriter partXmlWriter = XmlWriter.Create(partStream, settings))
                        partXDocument.Save(partXmlWriter);
                }
            }
        }

        public static void PutXDocument(this OpenXmlPart part, XDocument document)
        {
            using (Stream partStream = part.GetStream(FileMode.Create, FileAccess.Write))
            using (XmlWriter partXmlWriter = XmlWriter.Create(partStream))
                document.Save(partXmlWriter);
            part.RemoveAnnotations<XDocument>();
            part.AddAnnotation(document);
        }

        private static XmlNamespaceManager GetManagerFromXDocument(XDocument xDocument)
        {
            XmlReader reader = xDocument.CreateReader();
            XDocument newXDoc = XDocument.Load(reader);
            XElement rootElement = xDocument.Elements().FirstOrDefault();
            rootElement.ReplaceWith(newXDoc.Root);
            XmlNameTable nameTable = reader.NameTable;
            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(nameTable);
            return namespaceManager;
        }

        public static IEnumerable<XElement> LogicalChildrenContent(this XElement element)
        {
            if (element.Name == W.document)
                return element.Descendants(W.body).Take(1);
            if (element.Name == W.body ||
                element.Name == W.tc ||
                element.Name == W.txbxContent)
                return element
                    .DescendantsTrimmed(e =>
                        e.Name == W.tbl ||
                        e.Name == W.p)
                    .Where(e =>
                        e.Name == W.p ||
                        e.Name == W.tbl);
            if (element.Name == W.tbl)
                return element
                    .DescendantsTrimmed(W.tr)
                    .Where(e => e.Name == W.tr);
            if (element.Name == W.tr)
                return element
                    .DescendantsTrimmed(W.tc)
                    .Where(e => e.Name == W.tc);
            if (element.Name == W.p)
                return element
                    .DescendantsTrimmed(e => e.Name == W.r ||
                        e.Name == W.pict ||
                        e.Name == W.drawing)
                    .Where(e => e.Name == W.r ||
                        e.Name == W.pict ||
                        e.Name == W.drawing);
            if (element.Name == W.r)
                return element
                    .DescendantsTrimmed(e => W.SubRunLevelContent.Contains(e.Name))
                    .Where(e => W.SubRunLevelContent.Contains(e.Name));
            if (element.Name == MC.AlternateContent)
                return element
                    .DescendantsTrimmed(e =>
                        e.Name == W.pict ||
                        e.Name == W.drawing ||
                        e.Name == MC.Fallback)
                    .Where(e =>
                        e.Name == W.pict ||
                        e.Name == W.drawing);
            if (element.Name == W.pict || element.Name == W.drawing)
                return element
                    .DescendantsTrimmed(W.txbxContent)
                    .Where(e => e.Name == W.txbxContent);
            return XElement.EmptySequence;
        }

        public static IEnumerable<XElement> LogicalChildrenContent(
            this IEnumerable<XElement> source)
        {
            foreach (XElement e1 in source)
                foreach (XElement e2 in e1.LogicalChildrenContent())
                    yield return e2;
        }

        public static IEnumerable<XElement> LogicalChildrenContent(
            this XElement element, XName name)
        {
            return element.LogicalChildrenContent().Where(e => e.Name == name);
        }

        public static IEnumerable<XElement> LogicalChildrenContent(
            this IEnumerable<XElement> source, XName name)
        {
            foreach (XElement e1 in source)
                foreach (XElement e2 in e1.LogicalChildrenContent(name))
                    yield return e2;
        }

        public static IEnumerable<OpenXmlPart> ContentParts(this WordprocessingDocument doc)
        {
            yield return doc.MainDocumentPart;
            foreach (var hdr in doc.MainDocumentPart.HeaderParts)
                yield return hdr;
            foreach (var ftr in doc.MainDocumentPart.FooterParts)
                yield return ftr;
            if (doc.MainDocumentPart.FootnotesPart != null)
                yield return doc.MainDocumentPart.FootnotesPart;
            if (doc.MainDocumentPart.EndnotesPart != null)
                yield return doc.MainDocumentPart.EndnotesPart;
        }

        private static void AddPart(HashSet<OpenXmlPart> partList, OpenXmlPart part)
        {
            if (partList.Contains(part))
                return;
            partList.Add(part);
            foreach (IdPartPair p in part.Parts)
                AddPart(partList, p.OpenXmlPart);
        }

        // the following three functions, plus the recursive function above,
        // creates a complete list of all parts in package.
        public static List<OpenXmlPart> GetAllParts(this WordprocessingDocument doc)
        {
            // use the following so that parts are processed only once
            HashSet<OpenXmlPart> partList = new HashSet<OpenXmlPart>();
            foreach (IdPartPair p in doc.Parts)
                AddPart(partList, p.OpenXmlPart);
            return partList.OrderBy(p => p.ContentType).ThenBy(p => p.Uri.ToString()).ToList();
        }

        public static List<OpenXmlPart> GetAllParts(this SpreadsheetDocument doc)
        {
            // use the following so that parts are processed only once
            HashSet<OpenXmlPart> partList = new HashSet<OpenXmlPart>();
            foreach (IdPartPair p in doc.Parts)
                AddPart(partList, p.OpenXmlPart);
            return partList.OrderBy(p => p.ContentType).ThenBy(p => p.Uri.ToString()).ToList();
        }

        public static List<OpenXmlPart> GetAllParts(this PresentationDocument doc)
        {
            // use the following so that parts are processed only once
            HashSet<OpenXmlPart> partList = new HashSet<OpenXmlPart>();
            foreach (IdPartPair p in doc.Parts)
                AddPart(partList, p.OpenXmlPart);
            return partList.OrderBy(p => p.ContentType).ThenBy(p => p.Uri.ToString()).ToList();
        }

    }

    public static class FlatOpc
    {
        private class FlatOpcTupple
        {
            public char FoCharacter;
            public int FoChunk;
        }

        private static XElement GetContentsAsXml(PackagePart part)
        {
            XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

            if (part.ContentType.EndsWith("xml"))
            {
                using (Stream str = part.GetStream())
                using (StreamReader streamReader = new StreamReader(str))
                using (XmlReader xr = XmlReader.Create(streamReader))
                    return new XElement(pkg + "part",
                        new XAttribute(pkg + "name", part.Uri),
                        new XAttribute(pkg + "contentType", part.ContentType),
                        new XElement(pkg + "xmlData",
                            XElement.Load(xr)
                        )
                    );
            }
            else
            {
                using (Stream str = part.GetStream())
                using (BinaryReader binaryReader = new BinaryReader(str))
                {
                    int len = (int)binaryReader.BaseStream.Length;
                    byte[] byteArray = binaryReader.ReadBytes(len);
                    // the following expression creates the base64String, then chunks
                    // it to lines of 76 characters long
                    string base64String = (System.Convert.ToBase64String(byteArray))
                        .Select
                        (
                            (c, i) => new FlatOpcTupple()
                            {
                                FoCharacter = c,
                                FoChunk = i / 76
                            }
                        )
                        .GroupBy(c => c.FoChunk)
                        .Aggregate(
                            new StringBuilder(),
                            (s, i) =>
                                s.Append(
                                    i.Aggregate(
                                        new StringBuilder(),
                                        (seed, it) => seed.Append(it.FoCharacter),
                                        sb => sb.ToString()
                                    )
                                )
                                .Append(Environment.NewLine),
                            s => s.ToString()
                        );
                    return new XElement(pkg + "part",
                        new XAttribute(pkg + "name", part.Uri),
                        new XAttribute(pkg + "contentType", part.ContentType),
                        new XAttribute(pkg + "compression", "store"),
                        new XElement(pkg + "binaryData", base64String)
                    );
                }
            }
        }

        private static XProcessingInstruction GetProcessingInstruction(string path)
        {
            var fi = new FileInfo(path);
            if (Util.IsWordprocessingML(fi.Extension))
                return new XProcessingInstruction("mso-application",
                            "progid=\"Word.Document\"");
            if (Util.IsPresentationML(fi.Extension))
                return new XProcessingInstruction("mso-application",
                            "progid=\"PowerPoint.Show\"");
            if (Util.IsSpreadsheetML(fi.Extension))
                return new XProcessingInstruction("mso-application",
                            "progid=\"Excel.Sheet\"");
            return null;
        }

        public static XmlDocument OpcToXmlDocument(string fileName)
        {
            using (Package package = Package.Open(fileName))
            {
                XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

                XDeclaration declaration = new XDeclaration("1.0", "UTF-8", "yes");
                XDocument doc = new XDocument(
                    declaration,
                    GetProcessingInstruction(fileName),
                    new XElement(pkg + "package",
                        new XAttribute(XNamespace.Xmlns + "pkg", pkg.ToString()),
                        package.GetParts().Select(part => GetContentsAsXml(part))
                    )
                );
                return GetXmlDocument(doc);
            }
        }

        public static XDocument OpcToXDocument(string fileName)
        {
            using (Package package = Package.Open(fileName))
            {
                XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

                XDeclaration declaration = new XDeclaration("1.0", "UTF-8", "yes");
                XDocument doc = new XDocument(
                    declaration,
                    GetProcessingInstruction(fileName),
                    new XElement(pkg + "package",
                        new XAttribute(XNamespace.Xmlns + "pkg", pkg.ToString()),
                        package.GetParts().Select(part => GetContentsAsXml(part))
                    )
                );
                return doc;
            }
        }

        public static string[] OpcToText(string fileName)
        {
            using (Package package = Package.Open(fileName))
            {
                XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

                XDeclaration declaration = new XDeclaration("1.0", "UTF-8", "yes");
                XDocument doc = new XDocument(
                    declaration,
                    GetProcessingInstruction(fileName),
                    new XElement(pkg + "package",
                        new XAttribute(XNamespace.Xmlns + "pkg", pkg.ToString()),
                        package.GetParts().Select(part => GetContentsAsXml(part))
                    )
                );
                return doc.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            }
        }

        private static XmlDocument GetXmlDocument(XDocument document)
        {
            using (XmlReader xmlReader = document.CreateReader())
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                if (document.Declaration != null)
                {
                    XmlDeclaration dec = xmlDoc.CreateXmlDeclaration(document.Declaration.Version,
                        document.Declaration.Encoding, document.Declaration.Standalone);
                    xmlDoc.InsertBefore(dec, xmlDoc.FirstChild);
                }
                return xmlDoc;
            }
        }

        private static XDocument GetXDocument(this XmlDocument document)
        {
            XDocument xDoc = new XDocument();
            using (XmlWriter xmlWriter = xDoc.CreateWriter())
                document.WriteTo(xmlWriter);
            XmlDeclaration decl =
                document.ChildNodes.OfType<XmlDeclaration>().FirstOrDefault();
            if (decl != null)
                xDoc.Declaration = new XDeclaration(decl.Version, decl.Encoding,
                    decl.Standalone);
            return xDoc;
        }

        public static void FlatToOpc(XmlDocument doc, string outputPath)
        {
            XDocument xd = GetXDocument(doc);
            FlatToOpc(xd, outputPath);
        }

        public static void FlatToOpc(string xmlText, string outputPath)
        {
            XDocument xd = XDocument.Parse(xmlText);
            FlatToOpc(xd, outputPath);
        }

        public static void FlatToOpc(XDocument doc, string outputPath)
        {
            XNamespace pkg =
                "http://schemas.microsoft.com/office/2006/xmlPackage";
            XNamespace rel =
                "http://schemas.openxmlformats.org/package/2006/relationships";

            using (Package package = Package.Open(outputPath, FileMode.Create))
            {
                // add all parts (but not relationships)
                foreach (var xmlPart in doc.Root
                    .Elements()
                    .Where(p =>
                        (string)p.Attribute(pkg + "contentType") !=
                        "application/vnd.openxmlformats-package.relationships+xml"))
                {
                    string name = (string)xmlPart.Attribute(pkg + "name");
                    string contentType = (string)xmlPart.Attribute(pkg + "contentType");
                    if (contentType.EndsWith("xml"))
                    {
                        Uri u = new Uri(name, UriKind.Relative);
                        PackagePart part = package.CreatePart(u, contentType,
                            CompressionOption.SuperFast);
                        using (Stream str = part.GetStream(FileMode.Create))
                        using (XmlWriter xmlWriter = XmlWriter.Create(str))
                            xmlPart.Element(pkg + "xmlData")
                                .Elements()
                                .First()
                                .WriteTo(xmlWriter);
                    }
                    else
                    {
                        Uri u = new Uri(name, UriKind.Relative);
                        PackagePart part = package.CreatePart(u, contentType,
                            CompressionOption.SuperFast);
                        using (Stream str = part.GetStream(FileMode.Create))
                        using (BinaryWriter binaryWriter = new BinaryWriter(str))
                        {
                            string base64StringInChunks =
                                (string)xmlPart.Element(pkg + "binaryData");
                            char[] base64CharArray = base64StringInChunks
                                .Where(c => c != '\r' && c != '\n').ToArray();
                            byte[] byteArray =
                                System.Convert.FromBase64CharArray(base64CharArray,
                                0, base64CharArray.Length);
                            binaryWriter.Write(byteArray);
                        }
                    }
                }

                foreach (var xmlPart in doc.Root.Elements())
                {
                    string name = (string)xmlPart.Attribute(pkg + "name");
                    string contentType = (string)xmlPart.Attribute(pkg + "contentType");
                    if (contentType ==
                        "application/vnd.openxmlformats-package.relationships+xml")
                    {
                        // add the package level relationships
                        if (name == "/_rels/.rels")
                        {
                            foreach (XElement xmlRel in
                                xmlPart.Descendants(rel + "Relationship"))
                            {
                                string id = (string)xmlRel.Attribute("Id");
                                string type = (string)xmlRel.Attribute("Type");
                                string target = (string)xmlRel.Attribute("Target");
                                string targetMode =
                                    (string)xmlRel.Attribute("TargetMode");
                                if (targetMode == "External")
                                    package.CreateRelationship(
                                        new Uri(target, UriKind.Absolute),
                                        TargetMode.External, type, id);
                                else
                                    package.CreateRelationship(
                                        new Uri(target, UriKind.Relative),
                                        TargetMode.Internal, type, id);
                            }
                        }
                        else
                        // add part level relationships
                        {
                            string directory = name.Substring(0, name.IndexOf("/_rels"));
                            string relsFilename = name.Substring(name.LastIndexOf('/'));
                            string filename =
                                relsFilename.Substring(0, relsFilename.IndexOf(".rels"));
                            PackagePart fromPart = package.GetPart(
                                new Uri(directory + filename, UriKind.Relative));
                            foreach (XElement xmlRel in
                                xmlPart.Descendants(rel + "Relationship"))
                            {
                                string id = (string)xmlRel.Attribute("Id");
                                string type = (string)xmlRel.Attribute("Type");
                                string target = (string)xmlRel.Attribute("Target");
                                string targetMode =
                                    (string)xmlRel.Attribute("TargetMode");
                                if (targetMode == "External")
                                    fromPart.CreateRelationship(
                                        new Uri(target, UriKind.Absolute),
                                        TargetMode.External, type, id);
                                else
                                    fromPart.CreateRelationship(
                                        new Uri(target, UriKind.Relative),
                                        TargetMode.Internal, type, id);
                            }
                        }
                    }
                }
            }
        }
    }

    public class Base64
    {
        public static string ConvertToBase64(string fileName)
        {
            byte[] ba = System.IO.File.ReadAllBytes(fileName);
            string base64String = (System.Convert.ToBase64String(ba))
                .Select
                (
                    (c, i) => new
                    {
                        Chunk = i / 76,
                        Character = c
                    }
                )
                .GroupBy(c => c.Chunk)
                .Aggregate(
                    new StringBuilder(),
                    (s, i) =>
                        s.Append(
                            i.Aggregate(
                                new StringBuilder(),
                                (seed, it) => seed.Append(it.Character),
                                sb => sb.ToString()
                            )
                        )
                        .Append(Environment.NewLine),
                    s =>
                    {
                        s.Length -= Environment.NewLine.Length;
                        return s.ToString();
                    }
                );

            return base64String;
        }

        public static byte[] ConvertFromBase64(string fileName, string b64)
        {
            string b64b = b64.Replace("\r\n", "");
            byte[] ba = System.Convert.FromBase64String(b64b);
            return ba;
        }
    }

    public static class WordprocessingMLUtil
    {
        private static HashSet<string> UnknownFonts = new HashSet<string>();
        private static HashSet<string> KnownFamilies = null;

        public static int CalcWidthOfRunInTwips(XElement r)
        {
            if (KnownFamilies == null)
            {
                KnownFamilies = new HashSet<string>();
                var families = FontFamily.Families;
                foreach (var fam in families)
                    KnownFamilies.Add(fam.Name);
            }

            var fontName = (string)r.Attribute(PtOpenXml.pt + "FontName");
            if (fontName == null)
                fontName = (string)r.Ancestors(W.p).First().Attribute(PtOpenXml.pt + "FontName");
            if (fontName == null)
                throw new OpenXmlPowerToolsException("Internal Error, should have FontName attribute");
            if (UnknownFonts.Contains(fontName))
                return 0;

            var rPr = r.Element(W.rPr);
            if (rPr == null)
                throw new OpenXmlPowerToolsException("Internal Error, should have run properties");
            var languageType = (string)r.Attribute(PtOpenXml.LanguageType);
            decimal? sz = null;
            if (languageType == "bidi")
                sz = (decimal?)rPr.Elements(W.szCs).Attributes(W.val).FirstOrDefault();
            else
                sz = (decimal?)rPr.Elements(W.sz).Attributes(W.val).FirstOrDefault();
            if (sz == null)
                sz = 22m;

            // unknown font families will throw ArgumentException, in which case just return 0
            if (!KnownFamilies.Contains(fontName))
                return 0;
            // in theory, all unknown fonts are found by the above test, but if not...
            FontFamily ff;
            try
            {
                ff = new FontFamily(fontName);
            }
            catch (ArgumentException)
            {
                UnknownFonts.Add(fontName);

                return 0;
            }
            FontStyle fs = FontStyle.Regular;
            var bold = GetBoolProp(rPr, W.b) || GetBoolProp(rPr, W.bCs);
            var italic = GetBoolProp(rPr, W.i) || GetBoolProp(rPr, W.iCs);
            if (bold && !italic)
                fs = FontStyle.Bold;
            if (italic && !bold)
                fs = FontStyle.Italic;
            if (bold && italic)
                fs = FontStyle.Bold | FontStyle.Italic;

            var runText = r.DescendantsTrimmed(W.txbxContent)
                .Where(e => e.Name == W.t)
                .Select(t => (string)t)
                .StringConcatenate();

            var tabLength = r.DescendantsTrimmed(W.txbxContent)
                .Where(e => e.Name == W.tab)
                .Select(t => (decimal)t.Attribute(PtOpenXml.TabWidth))
                .Sum();

            if (runText.Length == 0 && tabLength == 0)
                return 0;

            int multiplier = 1;
            if (runText.Length <= 2)
                multiplier = 100;
            else if (runText.Length <= 4)
                multiplier = 50;
            else if (runText.Length <= 8)
                multiplier = 25;
            else if (runText.Length <= 16)
                multiplier = 12;
            else if (runText.Length <= 32)
                multiplier = 6;
            if (multiplier != 1)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < multiplier; i++)
                    sb.Append(runText);
                runText = sb.ToString();
            }

            try
            {
                using (Font f = new Font(ff, (float)sz / 2f, fs))
                {
                    System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                    Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                    var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                    var dpi = 96m;
                    var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                    return twip;
                }
            }
            catch (ArgumentException)
            {
                try
                {
                    var fs2 = FontStyle.Regular;
                    using (Font f = new Font(ff, (float)sz / 2f, fs2))
                    {
                        System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                        Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                        var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                        var dpi = 96m;
                        var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                        return twip;
                    }
                }
                catch (ArgumentException)
                {
                    var fs2 = FontStyle.Bold;
                    try
                    {
                        using (Font f = new Font(ff, (float)sz / 2f, fs2))
                        {
                            System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                            Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                            var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                            var dpi = 96m;
                            var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                            return twip;
                        }
                    }
                    catch (ArgumentException)
                    {
                        // if both regular and bold fail, then get metrics for Times New Roman
                        // use the original FontStyle (in fs)
                        FontFamily ff2;
                        ff2 = new FontFamily("Times New Roman");
                        using (Font f = new Font(ff2, (float)sz / 2f, fs))
                        {
                            System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                            Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                            var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                            var dpi = 96m;
                            var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                            return twip;
                        }
                    }
                }
            }
        }

        public static bool GetBoolProp(XElement runProps, XName xName)
        {
            var p = runProps.Element(xName);
            if (p == null)
                return false;
            var v = p.Attribute(W.val);
            if (v == null)
                return true;
            var s = v.Value.ToLower();
            if (s == "0" || s == "false")
                return false;
            if (s == "1" || s == "true")
                return true;
            return false;
        }
    }

    public static class PresentationMLUtil
    {
        public static void FixUpPresentationDocument(PresentationDocument pDoc)
        {
            foreach (var part in pDoc.GetAllParts())
            {
                if (part.ContentType == "application/vnd.openxmlformats-officedocument.presentationml.slide+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.presentationml.slideLayout+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.presentationml.notesSlide+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.theme+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.drawingml.chart+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml" ||
                    part.ContentType == "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml" ||
                    part.ContentType == "application/vnd.ms-office.drawingml.diagramDrawing+xml")
                {
                    XDocument xd = part.GetXDocument();
                    xd.Descendants().Attributes("smtClean").Remove();
                    xd.Descendants().Attributes("smtId").Remove();
                    part.PutXDocument();
                }
                if (part.ContentType == "application/vnd.openxmlformats-officedocument.vmlDrawing")
                {
                    string fixedContent = null;

                    using (var stream = part.GetStream(FileMode.Open, FileAccess.ReadWrite))
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            //string input = @"    <![if gte mso 9]><v:imagedata o:relid=""rId15""";
                            var input = sr.ReadToEnd();
                            string pattern = @"<!\[(?<test>.*)\]>";
                            //string replacement = "<![CDATA[${test}]]>";
                            //fixedContent = Regex.Replace(input, pattern, replacement, RegexOptions.Multiline);
                            fixedContent = Regex.Replace(input, pattern, m =>
                            {
                                var g = m.Groups[1].Value;
                                if (g.StartsWith("CDATA["))
                                    return "<![" + g + "]>";
                                else
                                    return "<![CDATA[" + g + "]]>";
                            },
                            RegexOptions.Multiline);

                            //var input = @"xxxxx o:relid=""rId1"" o:relid=""rId1"" xxxxx";
                            pattern = @"o:relid=[""'](?<id1>.*)[""'] o:relid=[""'](?<id2>.*)[""']";
                            fixedContent = Regex.Replace(fixedContent, pattern, m =>
                            {
                                var g = m.Groups[1].Value;
                                return @"o:relid=""" + g + @"""";
                            },
                            RegexOptions.Multiline);

                            fixedContent = fixedContent.Replace("</xml>ml>", "</xml>");

                            stream.SetLength(fixedContent.Length);
                        }
                    }
                    using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(fixedContent)))
                        part.FeedData(ms);
                }
            }
        }
    }

    public static class SpreadsheetMLUtil
    {
        public static string GetCellType(string value)
        {
            if (value.Any(c => !Char.IsDigit(c) && c != '.'))
                return "str";
            return null;
        }

        public static string IntToColumnId(int i)
        {
            if (i >= 0 && i <= 25)
                return ((char)(((int)'A') + i)).ToString();
            if (i >= 26 && i <= 701)
            {
                int v = i - 26;
                int h = v / 26;
                int l = v % 26;
                return ((char)(((int)'A') + h)).ToString() + ((char)(((int)'A') + l)).ToString();
            }
            // 17576
            if (i >= 702 && i <= 18277)
            {
                int v = i - 702;
                int h = v / 676;
                int r = v % 676;
                int m = r / 26;
                int l = r % 26;
                return ((char)(((int)'A') + h)).ToString() +
                    ((char)(((int)'A') + m)).ToString() +
                    ((char)(((int)'A') + l)).ToString();
            }
            throw new ColumnReferenceOutOfRange(i.ToString());
        }

        private static int CharToInt(char c)
        {
            return (int)c - (int)'A';
        }

        public static int ColumnIdToInt(string cid)
        {
            if (cid.Length == 1)
                return CharToInt(cid[0]);
            if (cid.Length == 2)
            {
                return CharToInt(cid[0]) * 26 + CharToInt(cid[1]) + 26;
            }
            if (cid.Length == 3)
            {

                return CharToInt(cid[0]) * 676 + CharToInt(cid[1]) * 26 + CharToInt(cid[2]) + 702;
            }
            throw new ColumnReferenceOutOfRange(cid);
        }

        public static IEnumerable<string> ColumnIDs()
        {
            for (var c = (int)'A'; c <= (int)'Z'; ++c)
                yield return ((char)c).ToString();
            for (var c1 = (int)'A'; c1 <= (int)'Z'; ++c1)
                for (var c2 = (int)'A'; c2 <= (int)'Z'; ++c2)
                    yield return ((char)c1).ToString() + ((char)c2).ToString();
            for (var d1 = (int)'A'; d1 <= (int)'Z'; ++d1)
                for (var d2 = (int)'A'; d2 <= (int)'Z'; ++d2)
                    for (var d3 = (int)'A'; d3 <= (int)'Z'; ++d3)
                        yield return ((char)d1).ToString() + ((char)d2).ToString() + ((char)d3).ToString();
        }

        public static string ColumnIdOf(string cellReference)
        {
            string columnIdOf = cellReference.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9').First();
            return columnIdOf;
        }
    }

    public class Util
    {
        public static string[] WordprocessingExtensions = new[] {
            ".docx",
            ".docm",
            ".dotx",
            ".dotm",
        };

        public static bool IsWordprocessingML(string ext)
        {
            return WordprocessingExtensions.Contains(ext.ToLower());
        }

        public static string[] SpreadsheetExtensions = new[] {
            ".xlsx",
            ".xlsm",
            ".xltx",
            ".xltm",
            ".xlam",
        };

        public static bool IsSpreadsheetML(string ext)
        {
            return SpreadsheetExtensions.Contains(ext.ToLower());
        }

        public static string[] PresentationExtensions = new[] {
            ".pptx",
            ".potx",
            ".ppsx",
            ".pptm",
            ".potm",
            ".ppsm",
            ".ppam",
        };

        public static bool IsPresentationML(string ext)
        {
            return PresentationExtensions.Contains(ext.ToLower());
        }
    }

    public class FieldInfo
    {
        public string FieldType;
        public string[] Switches;
        public string[] Arguments;
    }

    public static class FieldParser
    {
        private enum State
        {
            InToken,
            InWhiteSpace,
            InQuotedToken,
            OnOpeningQuote,
            OnClosingQuote,
            OnBackslash,
        }

        private static string[] GetTokens(string field)
        {
            State state = State.InWhiteSpace;
            int tokenStart = 0;
            char quoteStart = char.MinValue;
            List<string> tokens = new List<string>();
            for (int c = 0; c < field.Length; c++)
            {
                if (Char.IsWhiteSpace(field[c]))
                {
                    if (state == State.InToken)
                    {
                        tokens.Add(field.Substring(tokenStart, c - tokenStart));
                        state = State.InWhiteSpace;
                        continue;
                    }
                    if (state == State.OnOpeningQuote)
                    {
                        tokenStart = c;
                        state = State.InQuotedToken;
                    }
                    if (state == State.OnClosingQuote)
                        state = State.InWhiteSpace;
                    continue;
                }
                if (field[c] == '\\')
                {
                    if (state == State.InQuotedToken)
                    {
                        state = State.OnBackslash;
                        continue;
                    }
                }
                if (state == State.OnBackslash)
                {
                    state = State.InQuotedToken;
                    continue;
                }
                if (field[c] == '"' || field[c] == '\'' || field[c] == 0x201d)
                {
                    if (state == State.InWhiteSpace)
                    {
                        quoteStart = field[c];
                        state = State.OnOpeningQuote;
                        continue;
                    }
                    if (state == State.InQuotedToken)
                    {
                        if (field[c] == quoteStart)
                        {
                            tokens.Add(field.Substring(tokenStart, c - tokenStart));
                            state = State.OnClosingQuote;
                            continue;
                        }
                        continue;
                    }
                    if (state == State.OnOpeningQuote)
                    {
                        if (field[c] == quoteStart)
                        {
                            state = State.OnClosingQuote;
                            continue;
                        }
                        else
                        {
                            tokenStart = c;
                            state = State.InQuotedToken;
                            continue;
                        }
                    }
                    continue;
                }
                if (state == State.InWhiteSpace)
                {
                    tokenStart = c;
                    state = State.InToken;
                    continue;
                }
                if (state == State.OnOpeningQuote)
                {
                    tokenStart = c;
                    state = State.InQuotedToken;
                    continue;
                }
                if (state == State.OnClosingQuote)
                {
                    tokenStart = c;
                    state = State.InToken;
                    continue;
                }
            }
            if (state == State.InToken)
                tokens.Add(field.Substring(tokenStart, field.Length - tokenStart));
            return tokens.ToArray();
        }

        public static FieldInfo ParseField(string field)
        {
            FieldInfo emptyField = new FieldInfo
            {
                FieldType = "",
                Arguments = new string[] { },
                Switches = new string[] { },
            };

            if (field.Length == 0)
                return emptyField;
            string fieldType = field.TrimStart().Split(' ').FirstOrDefault();
            if (fieldType == null || fieldType.ToUpper() != "HYPERLINK")
                return emptyField;
            string[] tokens = GetTokens(field);
            if (tokens.Length == 0)
                return emptyField;
            FieldInfo fieldInfo = new FieldInfo()
            {
                FieldType = tokens[0],
                Switches = tokens.Where(t => t[0] == '\\').ToArray(),
                Arguments = tokens.Skip(1).Where(t => t[0] != '\\').ToArray(),
            };
            return fieldInfo;
        }
    }

    class ContentPartRelTypeIdTuple
    {
        public OpenXmlPart ContentPart { get; set; }
        public string RelationshipType { get; set; }
        public string RelationshipId { get; set; }
    }

    // This class is used to prevent duplication of images
    class ImageData
    {
        private string ContentType { get; set; }
        private byte[] Image { get; set; }
        public OpenXmlPart ImagePart { get; set; }
        public List<ContentPartRelTypeIdTuple> ContentPartRelTypeIdList = new List<ContentPartRelTypeIdTuple>();

        public ImageData(ImagePart part)
        {
            ContentType = part.ContentType;
            using (Stream s = part.GetStream(FileMode.Open, FileAccess.Read))
            {
                Image = new byte[s.Length];
                s.Read(Image, 0, (int)s.Length);
            }
        }

        public void AddContentPartRelTypeResourceIdTupple(OpenXmlPart contentPart, string relationshipType, string relationshipId)
        {
            ContentPartRelTypeIdList.Add(
                new ContentPartRelTypeIdTuple()
                {
                    ContentPart = contentPart,
                    RelationshipType = relationshipType,
                    RelationshipId = relationshipId,
                });
        }

        public void WriteImage(ImagePart part)
        {
            using (Stream s = part.GetStream(FileMode.Create, FileAccess.ReadWrite))
                s.Write(Image, 0, Image.GetUpperBound(0) + 1);
        }

        public bool Compare(ImageData arg)
        {
            if (ContentType != arg.ContentType)
                return false;
            if (Image.GetLongLength(0) != arg.Image.GetLongLength(0))
                return false;
            // Compare the arrays byte by byte
            long length = Image.GetLongLength(0);
            byte[] image1 = Image;
            byte[] image2 = arg.Image;
            for (long n = 0; n < length; n++)
                if (image1[n] != image2[n])
                    return false;
            return true;
        }
    }

    // This class is used to prevent duplication of media
    class MediaData
    {
        private string ContentType { get; set; }
        private byte[] Media { get; set; }
        public DataPart DataPart { get; set; }
        public List<ContentPartRelTypeIdTuple> ContentPartRelTypeIdList = new List<ContentPartRelTypeIdTuple>();

        public MediaData(DataPart part)
        {
            ContentType = part.ContentType;
            using (Stream s = part.GetStream(FileMode.Open, FileAccess.Read))
            {
                Media = new byte[s.Length];
                s.Read(Media, 0, (int)s.Length);
            }
        }

        public void AddContentPartRelTypeResourceIdTupple(OpenXmlPart contentPart, string relationshipType, string relationshipId)
        {
            ContentPartRelTypeIdList.Add(
                new ContentPartRelTypeIdTuple()
                {
                    ContentPart = contentPart,
                    RelationshipType = relationshipType,
                    RelationshipId = relationshipId,
                });
        }

        public void WriteMedia(DataPart part)
        {
            using (Stream s = part.GetStream(FileMode.Create, FileAccess.ReadWrite))
                s.Write(Media, 0, Media.GetUpperBound(0) + 1);
        }

        public bool Compare(MediaData arg)
        {
            if (ContentType != arg.ContentType)
                return false;
            if (Media.GetLongLength(0) != arg.Media.GetLongLength(0))
                return false;
            // Compare the arrays byte by byte
            long length = Media.GetLongLength(0);
            byte[] media1 = Media;
            byte[] media2 = arg.Media;
            for (long n = 0; n < length; n++)
                if (media1[n] != media2[n])
                    return false;
            return true;
        }
    }

    public static class UriFixer
    {
        public static void FixInvalidUri(Stream fs, Func<string, Uri> invalidUriHandler)
        {
            XNamespace relNs = "http://schemas.openxmlformats.org/package/2006/relationships";
            using (ZipArchive za = new ZipArchive(fs, ZipArchiveMode.Update))
            {
                foreach (var entry in za.Entries.ToList())
                {
                    if (!entry.Name.EndsWith(".rels"))
                        continue;
                    bool replaceEntry = false;
                    XDocument entryXDoc = null;
                    using (var entryStream = entry.Open())
                    {
                        try
                        {
                            entryXDoc = XDocument.Load(entryStream);
                            if (entryXDoc.Root != null && entryXDoc.Root.Name.Namespace == relNs)
                            {
                                var urisToCheck = entryXDoc
                                    .Descendants(relNs + "Relationship")
                                    .Where(r => r.Attribute("TargetMode") != null && (string)r.Attribute("TargetMode") == "External");
                                foreach (var rel in urisToCheck)
                                {
                                    var target = (string)rel.Attribute("Target");
                                    if (target != null)
                                    {
                                        try
                                        {
                                            Uri uri = new Uri(target);
                                        }
                                        catch (UriFormatException)
                                        {
                                            Uri newUri = invalidUriHandler(target);
                                            rel.Attribute("Target").Value = newUri.ToString();
                                            replaceEntry = true;
                                        }
                                    }
                                }
                            }
                        }
                        catch (XmlException)
                        {
                            continue;
                        }
                    }
                    if (replaceEntry)
                    {
                        var fullName = entry.FullName;
                        entry.Delete();
                        var newEntry = za.CreateEntry(fullName);
                        using (StreamWriter writer = new StreamWriter(newEntry.Open()))
                        using (XmlWriter xmlWriter = XmlWriter.Create(writer))
                        {
                            entryXDoc.WriteTo(xmlWriter);
                        }
                    }
                }
            }
        }
    }

    public static class ACTIVEX
    {
        public static XNamespace activex =
            "http://schemas.microsoft.com/office/2006/activeX";
        public static XName classid = activex + "classid";
        public static XName font = activex + "font";
        public static XName license = activex + "license";
        public static XName name = activex + "name";
        public static XName ocx = activex + "ocx";
        public static XName ocxPr = activex + "ocxPr";
        public static XName persistence = activex + "persistence";
        public static XName value = activex + "value";
    }

    public static class BIBLIO
    {
        public static XNamespace biblio =
            "http://schemas.microsoft.com/office/word/2004/10/bibliography";
        public static XName AlbumTitle = biblio + "AlbumTitle";
        public static XName Artist = biblio + "Artist";
        public static XName Author = biblio + "Author";
        public static XName City = biblio + "City";
        public static XName Comments = biblio + "Comments";
        public static XName Composer = biblio + "Composer";
        public static XName Conductor = biblio + "Conductor";
        public static XName ConferenceName = biblio + "ConferenceName";
        public static XName Country = biblio + "Country";
        public static XName Day = biblio + "Day";
        public static XName DayAccessed = biblio + "DayAccessed";
        public static XName Editor = biblio + "Editor";
        public static XName First = biblio + "First";
        public static XName Guid = biblio + "Guid";
        public static XName InternetSiteTitle = biblio + "InternetSiteTitle";
        public static XName Inventor = biblio + "Inventor";
        public static XName Last = biblio + "Last";
        public static XName LCID = biblio + "LCID";
        public static XName Main = biblio + "Main";
        public static XName Medium = biblio + "Medium";
        public static XName Middle = biblio + "Middle";
        public static XName Month = biblio + "Month";
        public static XName MonthAccessed = biblio + "MonthAccessed";
        public static XName NameList = biblio + "NameList";
        public static XName NumberVolumes = biblio + "NumberVolumes";
        public static XName Pages = biblio + "Pages";
        public static XName PatentNumber = biblio + "PatentNumber";
        public static XName Performer = biblio + "Performer";
        public static XName Person = biblio + "Person";
        public static XName ProducerName = biblio + "ProducerName";
        public static XName ProductionCompany = biblio + "ProductionCompany";
        public static XName Publisher = biblio + "Publisher";
        public static XName RefOrder = biblio + "RefOrder";
        public static XName ShortTitle = biblio + "ShortTitle";
        public static XName Source = biblio + "Source";
        public static XName Sources = biblio + "Sources";
        public static XName SourceType = biblio + "SourceType";
        public static XName Tag = biblio + "Tag";
        public static XName Title = biblio + "Title";
        public static XName Translator = biblio + "Translator";
        public static XName Type = biblio + "Type";
        public static XName URL = biblio + "URL";
        public static XName Version = biblio + "Version";
        public static XName Volume = biblio + "Volume";
        public static XName Year = biblio + "Year";
        public static XName YearAccessed = biblio + "YearAccessed";
    }

    public static class INK
    {
        public static XNamespace ink =
            "http://schemas.microsoft.com/ink/2010/main";
        public static XName context = ink + "context";
        public static XName sourceLink = ink + "sourceLink";
    }

    public static class SSNoNamespace
    {
        public static XName _ref = "ref";
        public static XName applyAlignment = "applyAlignment";
        public static XName applyBorder = "applyBorder";
        public static XName applyFont = "applyFont";
        public static XName applyNumberFormat = "applyNumberFormat";
        public static XName appName = "appName";
        public static XName baseType = "baseType";
        public static XName borderId = "borderId";
        public static XName bottom = "bottom";
        public static XName builtinId = "builtinId";
        public static XName calcId = "calcId";
        public static XName count = "count";
        public static XName customHeight = "customHeight";
        public static XName defaultColWidth = "defaultColWidth";
        public static XName defaultPivotStyle = "defaultPivotStyle";
        public static XName defaultRowHeight = "defaultRowHeight";
        public static XName defaultTableStyle = "defaultTableStyle";
        public static XName defaultThemeVersion = "defaultThemeVersion";
        public static XName displayName = "displayName";
        public static XName fillId = "fillId";
        public static XName fontId = "fontId";
        public static XName footer = "footer";
        public static XName formatCode = "formatCode";
        public static XName header = "header";
        public static XName horizontal = "horizontal";
        public static XName vertical = "vertical";
        public static XName ht = "ht";
        public static XName id = "id";
        public static XName lastEdited = "lastEdited";
        public static XName left = "left";
        public static XName lowestEdited = "lowestEdited";
        public static XName max = "max";
        public static XName min = "min";
        public static XName name = "name";
        public static XName numFmtId = "numFmtId";
        public static XName patternType = "patternType";
        public static XName r = "r";
        public static XName rgb = "rgb";
        public static XName right = "right";
        public static XName rupBuild = "rupBuild";
        public static XName s = "s";
        public static XName sheetId = "sheetId";
        public static XName showColumnStripes = "showColumnStripes";
        public static XName showFirstColumn = "showFirstColumn";
        public static XName showLastColumn = "showLastColumn";
        public static XName showRowStripes = "showRowStripes";
        public static XName size = "size";
        public static XName spans = "spans";
        public static XName sqref = "sqref";
        public static XName style = "style";
        public static XName t = "t";
        public static XName tabSelected = "tabSelected";
        public static XName theme = "theme";
        public static XName thickBot = "thickBot";
        public static XName top = "top";
        public static XName totalsRowShown = "totalsRowShown";
        public static XName uniqueCount = "uniqueCount";
        public static XName val = "val";
        public static XName width = "width";
        public static XName windowHeight = "windowHeight";
        public static XName windowWidth = "windowWidth";
        public static XName workbookViewId = "workbookViewId";
        public static XName xfId = "xfId";
        public static XName xWindow = "xWindow";
        public static XName yWindow = "yWindow";
    }

    public static class WNE
    {
        public static XNamespace wne =
            "http://schemas.microsoft.com/office/word/2006/wordml";
        public static XName acd = wne + "acd";
        public static XName acdEntry = wne + "acdEntry";
        public static XName acdManifest = wne + "acdManifest";
        public static XName acdName = wne + "acdName";
        public static XName acds = wne + "acds";
        public static XName active = wne + "active";
        public static XName argValue = wne + "argValue";
        public static XName fci = wne + "fci";
        public static XName fciBasedOn = wne + "fciBasedOn";
        public static XName fciIndexBasedOn = wne + "fciIndexBasedOn";
        public static XName fciName = wne + "fciName";
        public static XName hash = wne + "hash";
        public static XName kcmPrimary = wne + "kcmPrimary";
        public static XName kcmSecondary = wne + "kcmSecondary";
        public static XName keymap = wne + "keymap";
        public static XName keymaps = wne + "keymaps";
        public static XName macro = wne + "macro";
        public static XName macroName = wne + "macroName";
        public static XName mask = wne + "mask";
        public static XName recipientData = wne + "recipientData";
        public static XName recipients = wne + "recipients";
        public static XName swArg = wne + "swArg";
        public static XName tcg = wne + "tcg";
        public static XName toolbarData = wne + "toolbarData";
        public static XName toolbars = wne + "toolbars";
        public static XName val = wne + "val";
        public static XName wch = wne + "wch";
    }

    public static class WPC
    {
        public static XNamespace wpc =
            "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas";
    }

    public static class WPG
    {
        public static XNamespace wpg =
            "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup";
    }

    public static class WPI
    {
        public static XNamespace wpi =
            "http://schemas.microsoft.com/office/word/2010/wordprocessingInk";
    }

    public static class A
    {
        public static XNamespace a =
            "http://schemas.openxmlformats.org/drawingml/2006/main";
        public static XName accent1 = a + "accent1";
        public static XName accent2 = a + "accent2";
        public static XName accent3 = a + "accent3";
        public static XName accent4 = a + "accent4";
        public static XName accent5 = a + "accent5";
        public static XName accent6 = a + "accent6";
        public static XName ahLst = a + "ahLst";
        public static XName ahPolar = a + "ahPolar";
        public static XName ahXY = a + "ahXY";
        public static XName alpha = a + "alpha";
        public static XName alphaBiLevel = a + "alphaBiLevel";
        public static XName alphaCeiling = a + "alphaCeiling";
        public static XName alphaFloor = a + "alphaFloor";
        public static XName alphaInv = a + "alphaInv";
        public static XName alphaMod = a + "alphaMod";
        public static XName alphaModFix = a + "alphaModFix";
        public static XName alphaOff = a + "alphaOff";
        public static XName alphaOutset = a + "alphaOutset";
        public static XName alphaRepl = a + "alphaRepl";
        public static XName anchor = a + "anchor";
        public static XName arcTo = a + "arcTo";
        public static XName audioCd = a + "audioCd";
        public static XName audioFile = a + "audioFile";
        public static XName avLst = a + "avLst";
        public static XName backdrop = a + "backdrop";
        public static XName band1H = a + "band1H";
        public static XName band1V = a + "band1V";
        public static XName band2H = a + "band2H";
        public static XName band2V = a + "band2V";
        public static XName bevel = a + "bevel";
        public static XName bevelB = a + "bevelB";
        public static XName bevelT = a + "bevelT";
        public static XName bgClr = a + "bgClr";
        public static XName bgFillStyleLst = a + "bgFillStyleLst";
        public static XName biLevel = a + "biLevel";
        public static XName bldChart = a + "bldChart";
        public static XName bldDgm = a + "bldDgm";
        public static XName blend = a + "blend";
        public static XName blip = a + "blip";
        public static XName blipFill = a + "blipFill";
        public static XName blue = a + "blue";
        public static XName blueMod = a + "blueMod";
        public static XName blueOff = a + "blueOff";
        public static XName blur = a + "blur";
        public static XName bodyPr = a + "bodyPr";
        public static XName bottom = a + "bottom";
        public static XName br = a + "br";
        public static XName buAutoNum = a + "buAutoNum";
        public static XName buBlip = a + "buBlip";
        public static XName buChar = a + "buChar";
        public static XName buClr = a + "buClr";
        public static XName buClrTx = a + "buClrTx";
        public static XName buFont = a + "buFont";
        public static XName buFontTx = a + "buFontTx";
        public static XName buNone = a + "buNone";
        public static XName buSzPct = a + "buSzPct";
        public static XName buSzPts = a + "buSzPts";
        public static XName buSzTx = a + "buSzTx";
        public static XName camera = a + "camera";
        public static XName cell3D = a + "cell3D";
        public static XName chart = a + "chart";
        public static XName chExt = a + "chExt";
        public static XName chOff = a + "chOff";
        public static XName close = a + "close";
        public static XName clrChange = a + "clrChange";
        public static XName clrFrom = a + "clrFrom";
        public static XName clrMap = a + "clrMap";
        public static XName clrRepl = a + "clrRepl";
        public static XName clrScheme = a + "clrScheme";
        public static XName clrTo = a + "clrTo";
        public static XName cNvCxnSpPr = a + "cNvCxnSpPr";
        public static XName cNvGraphicFramePr = a + "cNvGraphicFramePr";
        public static XName cNvGrpSpPr = a + "cNvGrpSpPr";
        public static XName cNvPicPr = a + "cNvPicPr";
        public static XName cNvPr = a + "cNvPr";
        public static XName cNvSpPr = a + "cNvSpPr";
        public static XName comp = a + "comp";
        public static XName cont = a + "cont";
        public static XName contourClr = a + "contourClr";
        public static XName cs = a + "cs";
        public static XName cubicBezTo = a + "cubicBezTo";
        public static XName custClr = a + "custClr";
        public static XName custClrLst = a + "custClrLst";
        public static XName custDash = a + "custDash";
        public static XName custGeom = a + "custGeom";
        public static XName cxn = a + "cxn";
        public static XName cxnLst = a + "cxnLst";
        public static XName cxnSp = a + "cxnSp";
        public static XName cxnSpLocks = a + "cxnSpLocks";
        public static XName defPPr = a + "defPPr";
        public static XName defRPr = a + "defRPr";
        public static XName dgm = a + "dgm";
        public static XName dk1 = a + "dk1";
        public static XName dk2 = a + "dk2";
        public static XName ds = a + "ds";
        public static XName duotone = a + "duotone";
        public static XName ea = a + "ea";
        public static XName effect = a + "effect";
        public static XName effectDag = a + "effectDag";
        public static XName effectLst = a + "effectLst";
        public static XName effectRef = a + "effectRef";
        public static XName effectStyle = a + "effectStyle";
        public static XName effectStyleLst = a + "effectStyleLst";
        public static XName end = a + "end";
        public static XName endCxn = a + "endCxn";
        public static XName endParaRPr = a + "endParaRPr";
        public static XName ext = a + "ext";
        public static XName extLst = a + "extLst";
        public static XName extraClrScheme = a + "extraClrScheme";
        public static XName extraClrSchemeLst = a + "extraClrSchemeLst";
        public static XName extrusionClr = a + "extrusionClr";
        public static XName fgClr = a + "fgClr";
        public static XName fill = a + "fill";
        public static XName fillOverlay = a + "fillOverlay";
        public static XName fillRect = a + "fillRect";
        public static XName fillRef = a + "fillRef";
        public static XName fillStyleLst = a + "fillStyleLst";
        public static XName fillToRect = a + "fillToRect";
        public static XName firstCol = a + "firstCol";
        public static XName firstRow = a + "firstRow";
        public static XName flatTx = a + "flatTx";
        public static XName fld = a + "fld";
        public static XName fmtScheme = a + "fmtScheme";
        public static XName folHlink = a + "folHlink";
        public static XName font = a + "font";
        public static XName fontRef = a + "fontRef";
        public static XName fontScheme = a + "fontScheme";
        public static XName gamma = a + "gamma";
        public static XName gd = a + "gd";
        public static XName gdLst = a + "gdLst";
        public static XName glow = a + "glow";
        public static XName gradFill = a + "gradFill";
        public static XName graphic = a + "graphic";
        public static XName graphicData = a + "graphicData";
        public static XName graphicFrame = a + "graphicFrame";
        public static XName graphicFrameLocks = a + "graphicFrameLocks";
        public static XName gray = a + "gray";
        public static XName grayscl = a + "grayscl";
        public static XName green = a + "green";
        public static XName greenMod = a + "greenMod";
        public static XName greenOff = a + "greenOff";
        public static XName gridCol = a + "gridCol";
        public static XName grpFill = a + "grpFill";
        public static XName grpSp = a + "grpSp";
        public static XName grpSpLocks = a + "grpSpLocks";
        public static XName grpSpPr = a + "grpSpPr";
        public static XName gs = a + "gs";
        public static XName gsLst = a + "gsLst";
        public static XName headEnd = a + "headEnd";
        public static XName highlight = a + "highlight";
        public static XName hlink = a + "hlink";
        public static XName hlinkClick = a + "hlinkClick";
        public static XName hlinkHover = a + "hlinkHover";
        public static XName hlinkMouseOver = a + "hlinkMouseOver";
        public static XName hsl = a + "hsl";
        public static XName hslClr = a + "hslClr";
        public static XName hue = a + "hue";
        public static XName hueMod = a + "hueMod";
        public static XName hueOff = a + "hueOff";
        public static XName innerShdw = a + "innerShdw";
        public static XName insideH = a + "insideH";
        public static XName insideV = a + "insideV";
        public static XName inv = a + "inv";
        public static XName invGamma = a + "invGamma";
        public static XName lastCol = a + "lastCol";
        public static XName lastRow = a + "lastRow";
        public static XName latin = a + "latin";
        public static XName left = a + "left";
        public static XName lightRig = a + "lightRig";
        public static XName lin = a + "lin";
        public static XName ln = a + "ln";
        public static XName lnB = a + "lnB";
        public static XName lnBlToTr = a + "lnBlToTr";
        public static XName lnDef = a + "lnDef";
        public static XName lnL = a + "lnL";
        public static XName lnR = a + "lnR";
        public static XName lnRef = a + "lnRef";
        public static XName lnSpc = a + "lnSpc";
        public static XName lnStyleLst = a + "lnStyleLst";
        public static XName lnT = a + "lnT";
        public static XName lnTlToBr = a + "lnTlToBr";
        public static XName lnTo = a + "lnTo";
        public static XName lstStyle = a + "lstStyle";
        public static XName lt1 = a + "lt1";
        public static XName lt2 = a + "lt2";
        public static XName lum = a + "lum";
        public static XName lumMod = a + "lumMod";
        public static XName lumOff = a + "lumOff";
        public static XName lvl1pPr = a + "lvl1pPr";
        public static XName lvl2pPr = a + "lvl2pPr";
        public static XName lvl3pPr = a + "lvl3pPr";
        public static XName lvl4pPr = a + "lvl4pPr";
        public static XName lvl5pPr = a + "lvl5pPr";
        public static XName lvl6pPr = a + "lvl6pPr";
        public static XName lvl7pPr = a + "lvl7pPr";
        public static XName lvl8pPr = a + "lvl8pPr";
        public static XName lvl9pPr = a + "lvl9pPr";
        public static XName majorFont = a + "majorFont";
        public static XName masterClrMapping = a + "masterClrMapping";
        public static XName minorFont = a + "minorFont";
        public static XName miter = a + "miter";
        public static XName moveTo = a + "moveTo";
        public static XName neCell = a + "neCell";
        public static XName noAutofit = a + "noAutofit";
        public static XName noFill = a + "noFill";
        public static XName norm = a + "norm";
        public static XName normAutofit = a + "normAutofit";
        public static XName nvCxnSpPr = a + "nvCxnSpPr";
        public static XName nvGraphicFramePr = a + "nvGraphicFramePr";
        public static XName nvGrpSpPr = a + "nvGrpSpPr";
        public static XName nvPicPr = a + "nvPicPr";
        public static XName nvSpPr = a + "nvSpPr";
        public static XName nwCell = a + "nwCell";
        public static XName objectDefaults = a + "objectDefaults";
        public static XName off = a + "off";
        public static XName outerShdw = a + "outerShdw";
        public static XName overrideClrMapping = a + "overrideClrMapping";
        public static XName p = a + "p";
        public static XName path = a + "path";
        public static XName pathLst = a + "pathLst";
        public static XName pattFill = a + "pattFill";
        public static XName pic = a + "pic";
        public static XName picLocks = a + "picLocks";
        public static XName pos = a + "pos";
        public static XName pPr = a + "pPr";
        public static XName prstClr = a + "prstClr";
        public static XName prstDash = a + "prstDash";
        public static XName prstGeom = a + "prstGeom";
        public static XName prstShdw = a + "prstShdw";
        public static XName prstTxWarp = a + "prstTxWarp";
        public static XName pt = a + "pt";
        public static XName quadBezTo = a + "quadBezTo";
        public static XName quickTimeFile = a + "quickTimeFile";
        public static XName r = a + "r";
        public static XName rect = a + "rect";
        public static XName red = a + "red";
        public static XName redMod = a + "redMod";
        public static XName redOff = a + "redOff";
        public static XName reflection = a + "reflection";
        public static XName relIds = a + "relIds";
        public static XName relOff = a + "relOff";
        public static XName right = a + "right";
        public static XName rot = a + "rot";
        public static XName round = a + "round";
        public static XName rPr = a + "rPr";
        public static XName sat = a + "sat";
        public static XName satMod = a + "satMod";
        public static XName satOff = a + "satOff";
        public static XName scene3d = a + "scene3d";
        public static XName schemeClr = a + "schemeClr";
        public static XName scrgbClr = a + "scrgbClr";
        public static XName seCell = a + "seCell";
        public static XName shade = a + "shade";
        public static XName snd = a + "snd";
        public static XName softEdge = a + "softEdge";
        public static XName solidFill = a + "solidFill";
        public static XName sp = a + "sp";
        public static XName sp3d = a + "sp3d";
        public static XName spAutoFit = a + "spAutoFit";
        public static XName spcAft = a + "spcAft";
        public static XName spcBef = a + "spcBef";
        public static XName spcPct = a + "spcPct";
        public static XName spcPts = a + "spcPts";
        public static XName spDef = a + "spDef";
        public static XName spLocks = a + "spLocks";
        public static XName spPr = a + "spPr";
        public static XName srcRect = a + "srcRect";
        public static XName srgbClr = a + "srgbClr";
        public static XName st = a + "st";
        public static XName stCxn = a + "stCxn";
        public static XName stretch = a + "stretch";
        public static XName style = a + "style";
        public static XName swCell = a + "swCell";
        public static XName sx = a + "sx";
        public static XName sy = a + "sy";
        public static XName sym = a + "sym";
        public static XName sysClr = a + "sysClr";
        public static XName t = a + "t";
        public static XName tab = a + "tab";
        public static XName tableStyle = a + "tableStyle";
        public static XName tableStyleId = a + "tableStyleId";
        public static XName tabLst = a + "tabLst";
        public static XName tailEnd = a + "tailEnd";
        public static XName tbl = a + "tbl";
        public static XName tblBg = a + "tblBg";
        public static XName tblGrid = a + "tblGrid";
        public static XName tblPr = a + "tblPr";
        public static XName tblStyle = a + "tblStyle";
        public static XName tblStyleLst = a + "tblStyleLst";
        public static XName tc = a + "tc";
        public static XName tcBdr = a + "tcBdr";
        public static XName tcPr = a + "tcPr";
        public static XName tcStyle = a + "tcStyle";
        public static XName tcTxStyle = a + "tcTxStyle";
        public static XName theme = a + "theme";
        public static XName themeElements = a + "themeElements";
        public static XName themeOverride = a + "themeOverride";
        public static XName tile = a + "tile";
        public static XName tileRect = a + "tileRect";
        public static XName tint = a + "tint";
        public static XName top = a + "top";
        public static XName tr = a + "tr";
        public static XName txBody = a + "txBody";
        public static XName txDef = a + "txDef";
        public static XName txSp = a + "txSp";
        public static XName uFill = a + "uFill";
        public static XName uFillTx = a + "uFillTx";
        public static XName uLn = a + "uLn";
        public static XName uLnTx = a + "uLnTx";
        public static XName up = a + "up";
        public static XName useSpRect = a + "useSpRect";
        public static XName videoFile = a + "videoFile";
        public static XName wavAudioFile = a + "wavAudioFile";
        public static XName wholeTbl = a + "wholeTbl";
        public static XName xfrm = a + "xfrm";
    }

    public static class A14
    {
        public static XNamespace a14 =
            "http://schemas.microsoft.com/office/drawing/2010/main";
        public static XName artisticChalkSketch = a14 + "artisticChalkSketch";
        public static XName artisticGlass = a14 + "artisticGlass";
        public static XName artisticGlowEdges = a14 + "artisticGlowEdges";
        public static XName artisticLightScreen = a14 + "artisticLightScreen";
        public static XName artisticPlasticWrap = a14 + "artisticPlasticWrap";
        public static XName artisticTexturizer = a14 + "artisticTexturizer";
        public static XName backgroundMark = a14 + "backgroundMark";
        public static XName backgroundRemoval = a14 + "backgroundRemoval";
        public static XName brightnessContrast = a14 + "brightnessContrast";
        public static XName cameraTool = a14 + "cameraTool";
        public static XName colorTemperature = a14 + "colorTemperature";
        public static XName compatExt = a14 + "compatExt";
        public static XName cpLocks = a14 + "cpLocks";
        public static XName extLst = a14 + "extLst";
        public static XName foregroundMark = a14 + "foregroundMark";
        public static XName hiddenEffects = a14 + "hiddenEffects";
        public static XName hiddenFill = a14 + "hiddenFill";
        public static XName hiddenLine = a14 + "hiddenLine";
        public static XName hiddenScene3d = a14 + "hiddenScene3d";
        public static XName hiddenSp3d = a14 + "hiddenSp3d";
        public static XName imgEffect = a14 + "imgEffect";
        public static XName imgLayer = a14 + "imgLayer";
        public static XName imgProps = a14 + "imgProps";
        public static XName legacySpreadsheetColorIndex = a14 + "legacySpreadsheetColorIndex";
        public static XName m = a14 + "m";
        public static XName saturation = a14 + "saturation";
        public static XName shadowObscured = a14 + "shadowObscured";
        public static XName sharpenSoften = a14 + "sharpenSoften";
        public static XName useLocalDpi = a14 + "useLocalDpi";
    }

    public static class C
    {
        public static XNamespace c =
            "http://schemas.openxmlformats.org/drawingml/2006/chart";
        public static XName applyToEnd = c + "applyToEnd";
        public static XName applyToFront = c + "applyToFront";
        public static XName applyToSides = c + "applyToSides";
        public static XName area3DChart = c + "area3DChart";
        public static XName areaChart = c + "areaChart";
        public static XName auto = c + "auto";
        public static XName autoTitleDeleted = c + "autoTitleDeleted";
        public static XName autoUpdate = c + "autoUpdate";
        public static XName axId = c + "axId";
        public static XName axPos = c + "axPos";
        public static XName backWall = c + "backWall";
        public static XName backward = c + "backward";
        public static XName bandFmt = c + "bandFmt";
        public static XName bandFmts = c + "bandFmts";
        public static XName bar3DChart = c + "bar3DChart";
        public static XName barChart = c + "barChart";
        public static XName barDir = c + "barDir";
        public static XName baseTimeUnit = c + "baseTimeUnit";
        public static XName bubble3D = c + "bubble3D";
        public static XName bubbleChart = c + "bubbleChart";
        public static XName bubbleScale = c + "bubbleScale";
        public static XName bubbleSize = c + "bubbleSize";
        public static XName builtInUnit = c + "builtInUnit";
        public static XName cat = c + "cat";
        public static XName catAx = c + "catAx";
        public static XName chart = c + "chart";
        public static XName chartObject = c + "chartObject";
        public static XName chartSpace = c + "chartSpace";
        public static XName clrMapOvr = c + "clrMapOvr";
        public static XName crossAx = c + "crossAx";
        public static XName crossBetween = c + "crossBetween";
        public static XName crosses = c + "crosses";
        public static XName crossesAt = c + "crossesAt";
        public static XName custSplit = c + "custSplit";
        public static XName custUnit = c + "custUnit";
        public static XName data = c + "data";
        public static XName date1904 = c + "date1904";
        public static XName dateAx = c + "dateAx";
        public static XName delete = c + "delete";
        public static XName depthPercent = c + "depthPercent";
        public static XName dispBlanksAs = c + "dispBlanksAs";
        public static XName dispEq = c + "dispEq";
        public static XName dispRSqr = c + "dispRSqr";
        public static XName dispUnits = c + "dispUnits";
        public static XName dispUnitsLbl = c + "dispUnitsLbl";
        public static XName dLbl = c + "dLbl";
        public static XName dLblPos = c + "dLblPos";
        public static XName dLbls = c + "dLbls";
        public static XName doughnutChart = c + "doughnutChart";
        public static XName downBars = c + "downBars";
        public static XName dPt = c + "dPt";
        public static XName dropLines = c + "dropLines";
        public static XName dTable = c + "dTable";
        public static XName errBars = c + "errBars";
        public static XName errBarType = c + "errBarType";
        public static XName errDir = c + "errDir";
        public static XName errValType = c + "errValType";
        public static XName explosion = c + "explosion";
        public static XName ext = c + "ext";
        public static XName externalData = c + "externalData";
        public static XName extLst = c + "extLst";
        public static XName f = c + "f";
        public static XName firstSliceAng = c + "firstSliceAng";
        public static XName floor = c + "floor";
        public static XName fmtId = c + "fmtId";
        public static XName formatCode = c + "formatCode";
        public static XName formatting = c + "formatting";
        public static XName forward = c + "forward";
        public static XName gapDepth = c + "gapDepth";
        public static XName gapWidth = c + "gapWidth";
        public static XName grouping = c + "grouping";
        public static XName h = c + "h";
        public static XName headerFooter = c + "headerFooter";
        public static XName hiLowLines = c + "hiLowLines";
        public static XName hMode = c + "hMode";
        public static XName holeSize = c + "holeSize";
        public static XName hPercent = c + "hPercent";
        public static XName idx = c + "idx";
        public static XName intercept = c + "intercept";
        public static XName invertIfNegative = c + "invertIfNegative";
        public static XName lang = c + "lang";
        public static XName layout = c + "layout";
        public static XName layoutTarget = c + "layoutTarget";
        public static XName lblAlgn = c + "lblAlgn";
        public static XName lblOffset = c + "lblOffset";
        public static XName leaderLines = c + "leaderLines";
        public static XName legend = c + "legend";
        public static XName legendEntry = c + "legendEntry";
        public static XName legendPos = c + "legendPos";
        public static XName line3DChart = c + "line3DChart";
        public static XName lineChart = c + "lineChart";
        public static XName logBase = c + "logBase";
        public static XName lvl = c + "lvl";
        public static XName majorGridlines = c + "majorGridlines";
        public static XName majorTickMark = c + "majorTickMark";
        public static XName majorTimeUnit = c + "majorTimeUnit";
        public static XName majorUnit = c + "majorUnit";
        public static XName manualLayout = c + "manualLayout";
        public static XName marker = c + "marker";
        public static XName max = c + "max";
        public static XName min = c + "min";
        public static XName minorGridlines = c + "minorGridlines";
        public static XName minorTickMark = c + "minorTickMark";
        public static XName minorTimeUnit = c + "minorTimeUnit";
        public static XName minorUnit = c + "minorUnit";
        public static XName minus = c + "minus";
        public static XName multiLvlStrCache = c + "multiLvlStrCache";
        public static XName multiLvlStrRef = c + "multiLvlStrRef";
        public static XName name = c + "name";
        public static XName noEndCap = c + "noEndCap";
        public static XName noMultiLvlLbl = c + "noMultiLvlLbl";
        public static XName numCache = c + "numCache";
        public static XName numFmt = c + "numFmt";
        public static XName numLit = c + "numLit";
        public static XName numRef = c + "numRef";
        public static XName oddFooter = c + "oddFooter";
        public static XName oddHeader = c + "oddHeader";
        public static XName ofPieChart = c + "ofPieChart";
        public static XName ofPieType = c + "ofPieType";
        public static XName order = c + "order";
        public static XName orientation = c + "orientation";
        public static XName overlap = c + "overlap";
        public static XName overlay = c + "overlay";
        public static XName pageMargins = c + "pageMargins";
        public static XName pageSetup = c + "pageSetup";
        public static XName period = c + "period";
        public static XName perspective = c + "perspective";
        public static XName pictureFormat = c + "pictureFormat";
        public static XName pictureOptions = c + "pictureOptions";
        public static XName pictureStackUnit = c + "pictureStackUnit";
        public static XName pie3DChart = c + "pie3DChart";
        public static XName pieChart = c + "pieChart";
        public static XName pivotFmt = c + "pivotFmt";
        public static XName pivotFmts = c + "pivotFmts";
        public static XName pivotSource = c + "pivotSource";
        public static XName plotArea = c + "plotArea";
        public static XName plotVisOnly = c + "plotVisOnly";
        public static XName plus = c + "plus";
        public static XName printSettings = c + "printSettings";
        public static XName protection = c + "protection";
        public static XName pt = c + "pt";
        public static XName ptCount = c + "ptCount";
        public static XName radarChart = c + "radarChart";
        public static XName radarStyle = c + "radarStyle";
        public static XName rAngAx = c + "rAngAx";
        public static XName rich = c + "rich";
        public static XName rotX = c + "rotX";
        public static XName rotY = c + "rotY";
        public static XName roundedCorners = c + "roundedCorners";
        public static XName scaling = c + "scaling";
        public static XName scatterChart = c + "scatterChart";
        public static XName scatterStyle = c + "scatterStyle";
        public static XName secondPiePt = c + "secondPiePt";
        public static XName secondPieSize = c + "secondPieSize";
        public static XName selection = c + "selection";
        public static XName separator = c + "separator";
        public static XName ser = c + "ser";
        public static XName serAx = c + "serAx";
        public static XName serLines = c + "serLines";
        public static XName shape = c + "shape";
        public static XName showBubbleSize = c + "showBubbleSize";
        public static XName showCatName = c + "showCatName";
        public static XName showDLblsOverMax = c + "showDLblsOverMax";
        public static XName showHorzBorder = c + "showHorzBorder";
        public static XName showKeys = c + "showKeys";
        public static XName showLeaderLines = c + "showLeaderLines";
        public static XName showLegendKey = c + "showLegendKey";
        public static XName showNegBubbles = c + "showNegBubbles";
        public static XName showOutline = c + "showOutline";
        public static XName showPercent = c + "showPercent";
        public static XName showSerName = c + "showSerName";
        public static XName showVal = c + "showVal";
        public static XName showVertBorder = c + "showVertBorder";
        public static XName sideWall = c + "sideWall";
        public static XName size = c + "size";
        public static XName sizeRepresents = c + "sizeRepresents";
        public static XName smooth = c + "smooth";
        public static XName splitPos = c + "splitPos";
        public static XName splitType = c + "splitType";
        public static XName spPr = c + "spPr";
        public static XName stockChart = c + "stockChart";
        public static XName strCache = c + "strCache";
        public static XName strLit = c + "strLit";
        public static XName strRef = c + "strRef";
        public static XName style = c + "style";
        public static XName surface3DChart = c + "surface3DChart";
        public static XName surfaceChart = c + "surfaceChart";
        public static XName symbol = c + "symbol";
        public static XName thickness = c + "thickness";
        public static XName tickLblPos = c + "tickLblPos";
        public static XName tickLblSkip = c + "tickLblSkip";
        public static XName tickMarkSkip = c + "tickMarkSkip";
        public static XName title = c + "title";
        public static XName trendline = c + "trendline";
        public static XName trendlineLbl = c + "trendlineLbl";
        public static XName trendlineType = c + "trendlineType";
        public static XName tx = c + "tx";
        public static XName txPr = c + "txPr";
        public static XName upBars = c + "upBars";
        public static XName upDownBars = c + "upDownBars";
        public static XName userInterface = c + "userInterface";
        public static XName userShapes = c + "userShapes";
        public static XName v = c + "v";
        public static XName val = c + "val";
        public static XName valAx = c + "valAx";
        public static XName varyColors = c + "varyColors";
        public static XName view3D = c + "view3D";
        public static XName w = c + "w";
        public static XName wireframe = c + "wireframe";
        public static XName wMode = c + "wMode";
        public static XName x = c + "x";
        public static XName xMode = c + "xMode";
        public static XName xVal = c + "xVal";
        public static XName y = c + "y";
        public static XName yMode = c + "yMode";
        public static XName yVal = c + "yVal";
    }

    public static class CDR
    {
        public static XNamespace cdr =
            "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing";
        public static XName absSizeAnchor = cdr + "absSizeAnchor";
        public static XName blipFill = cdr + "blipFill";
        public static XName cNvCxnSpPr = cdr + "cNvCxnSpPr";
        public static XName cNvGraphicFramePr = cdr + "cNvGraphicFramePr";
        public static XName cNvGrpSpPr = cdr + "cNvGrpSpPr";
        public static XName cNvPicPr = cdr + "cNvPicPr";
        public static XName cNvPr = cdr + "cNvPr";
        public static XName cNvSpPr = cdr + "cNvSpPr";
        public static XName cxnSp = cdr + "cxnSp";
        public static XName ext = cdr + "ext";
        public static XName from = cdr + "from";
        public static XName graphicFrame = cdr + "graphicFrame";
        public static XName grpSp = cdr + "grpSp";
        public static XName grpSpPr = cdr + "grpSpPr";
        public static XName nvCxnSpPr = cdr + "nvCxnSpPr";
        public static XName nvGraphicFramePr = cdr + "nvGraphicFramePr";
        public static XName nvGrpSpPr = cdr + "nvGrpSpPr";
        public static XName nvPicPr = cdr + "nvPicPr";
        public static XName nvSpPr = cdr + "nvSpPr";
        public static XName pic = cdr + "pic";
        public static XName relSizeAnchor = cdr + "relSizeAnchor";
        public static XName sp = cdr + "sp";
        public static XName spPr = cdr + "spPr";
        public static XName style = cdr + "style";
        public static XName to = cdr + "to";
        public static XName txBody = cdr + "txBody";
        public static XName x = cdr + "x";
        public static XName xfrm = cdr + "xfrm";
        public static XName y = cdr + "y";
    }

    public static class COM
    {
        public static XNamespace com =
            "http://schemas.openxmlformats.org/drawingml/2006/compatibility";
        public static XName legacyDrawing = com + "legacyDrawing";
    }

    public static class CP
    {
        public static XNamespace cp =
            "http://schemas.openxmlformats.org/package/2006/metadata/core-properties";
        public static XName category = cp + "category";
        public static XName contentStatus = cp + "contentStatus";
        public static XName contentType = cp + "contentType";
        public static XName coreProperties = cp + "coreProperties";
        public static XName keywords = cp + "keywords";
        public static XName lastModifiedBy = cp + "lastModifiedBy";
        public static XName lastPrinted = cp + "lastPrinted";
        public static XName revision = cp + "revision";
    }

    public static class CUSTPRO
    {
        public static XNamespace custpro =
            "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties";
        public static XName Properties = custpro + "Properties";
        public static XName property = custpro + "property";
    }

    public static class DC
    {
        public static XNamespace dc =
            "http://purl.org/dc/elements/1.1/";
        public static XName creator = dc + "creator";
        public static XName description = dc + "description";
        public static XName subject = dc + "subject";
        public static XName title = dc + "title";
    }

    public static class DCTERMS
    {
        public static XNamespace dcterms =
            "http://purl.org/dc/terms/";
        public static XName created = dcterms + "created";
        public static XName modified = dcterms + "modified";
    }

    public static class DGM
    {
        public static XNamespace dgm =
            "http://schemas.openxmlformats.org/drawingml/2006/diagram";
        public static XName adj = dgm + "adj";
        public static XName adjLst = dgm + "adjLst";
        public static XName alg = dgm + "alg";
        public static XName animLvl = dgm + "animLvl";
        public static XName animOne = dgm + "animOne";
        public static XName bg = dgm + "bg";
        public static XName bulletEnabled = dgm + "bulletEnabled";
        public static XName cat = dgm + "cat";
        public static XName catLst = dgm + "catLst";
        public static XName chMax = dgm + "chMax";
        public static XName choose = dgm + "choose";
        public static XName chPref = dgm + "chPref";
        public static XName clrData = dgm + "clrData";
        public static XName colorsDef = dgm + "colorsDef";
        public static XName constr = dgm + "constr";
        public static XName constrLst = dgm + "constrLst";
        public static XName cxn = dgm + "cxn";
        public static XName cxnLst = dgm + "cxnLst";
        public static XName dataModel = dgm + "dataModel";
        public static XName desc = dgm + "desc";
        public static XName dir = dgm + "dir";
        public static XName effectClrLst = dgm + "effectClrLst";
        public static XName _else = dgm + "else";
        public static XName extLst = dgm + "extLst";
        public static XName fillClrLst = dgm + "fillClrLst";
        public static XName forEach = dgm + "forEach";
        public static XName hierBranch = dgm + "hierBranch";
        public static XName _if = dgm + "if";
        public static XName layoutDef = dgm + "layoutDef";
        public static XName layoutNode = dgm + "layoutNode";
        public static XName linClrLst = dgm + "linClrLst";
        public static XName orgChart = dgm + "orgChart";
        public static XName param = dgm + "param";
        public static XName presLayoutVars = dgm + "presLayoutVars";
        public static XName presOf = dgm + "presOf";
        public static XName prSet = dgm + "prSet";
        public static XName pt = dgm + "pt";
        public static XName ptLst = dgm + "ptLst";
        public static XName relIds = dgm + "relIds";
        public static XName resizeHandles = dgm + "resizeHandles";
        public static XName rule = dgm + "rule";
        public static XName ruleLst = dgm + "ruleLst";
        public static XName sampData = dgm + "sampData";
        public static XName scene3d = dgm + "scene3d";
        public static XName shape = dgm + "shape";
        public static XName sp3d = dgm + "sp3d";
        public static XName spPr = dgm + "spPr";
        public static XName style = dgm + "style";
        public static XName styleData = dgm + "styleData";
        public static XName styleDef = dgm + "styleDef";
        public static XName styleLbl = dgm + "styleLbl";
        public static XName t = dgm + "t";
        public static XName title = dgm + "title";
        public static XName txEffectClrLst = dgm + "txEffectClrLst";
        public static XName txFillClrLst = dgm + "txFillClrLst";
        public static XName txLinClrLst = dgm + "txLinClrLst";
        public static XName txPr = dgm + "txPr";
        public static XName varLst = dgm + "varLst";
        public static XName whole = dgm + "whole";
    }

    public static class DGM14
    {
        public static XNamespace dgm14 =
            "http://schemas.microsoft.com/office/drawing/2010/diagram";
        public static XName cNvPr = dgm14 + "cNvPr";
        public static XName recolorImg = dgm14 + "recolorImg";
    }

    public static class DIGSIG
    {
        public static XNamespace digsig =
            "http://schemas.microsoft.com/office/2006/digsig";
        public static XName ApplicationVersion = digsig + "ApplicationVersion";
        public static XName ColorDepth = digsig + "ColorDepth";
        public static XName HorizontalResolution = digsig + "HorizontalResolution";
        public static XName ManifestHashAlgorithm = digsig + "ManifestHashAlgorithm";
        public static XName Monitors = digsig + "Monitors";
        public static XName OfficeVersion = digsig + "OfficeVersion";
        public static XName SetupID = digsig + "SetupID";
        public static XName SignatureComments = digsig + "SignatureComments";
        public static XName SignatureImage = digsig + "SignatureImage";
        public static XName SignatureInfoV1 = digsig + "SignatureInfoV1";
        public static XName SignatureProviderDetails = digsig + "SignatureProviderDetails";
        public static XName SignatureProviderId = digsig + "SignatureProviderId";
        public static XName SignatureProviderUrl = digsig + "SignatureProviderUrl";
        public static XName SignatureText = digsig + "SignatureText";
        public static XName SignatureType = digsig + "SignatureType";
        public static XName VerticalResolution = digsig + "VerticalResolution";
        public static XName WindowsVersion = digsig + "WindowsVersion";
    }

    public static class DS
    {
        public static XNamespace ds =
            "http://schemas.openxmlformats.org/officeDocument/2006/customXml";
        public static XName datastoreItem = ds + "datastoreItem";
        public static XName itemID = ds + "itemID";
        public static XName schemaRef = ds + "schemaRef";
        public static XName schemaRefs = ds + "schemaRefs";
        public static XName uri = ds + "uri";
    }

    public static class DSP
    {
        public static XNamespace dsp =
            "http://schemas.microsoft.com/office/drawing/2008/diagram";
        public static XName dataModelExt = dsp + "dataModelExt";
    }

    public static class EP
    {
        public static XNamespace ep =
            "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties";
        public static XName Application = ep + "Application";
        public static XName AppVersion = ep + "AppVersion";
        public static XName Characters = ep + "Characters";
        public static XName CharactersWithSpaces = ep + "CharactersWithSpaces";
        public static XName Company = ep + "Company";
        public static XName DocSecurity = ep + "DocSecurity";
        public static XName HeadingPairs = ep + "HeadingPairs";
        public static XName HiddenSlides = ep + "HiddenSlides";
        public static XName HLinks = ep + "HLinks";
        public static XName HyperlinkBase = ep + "HyperlinkBase";
        public static XName HyperlinksChanged = ep + "HyperlinksChanged";
        public static XName Lines = ep + "Lines";
        public static XName LinksUpToDate = ep + "LinksUpToDate";
        public static XName Manager = ep + "Manager";
        public static XName MMClips = ep + "MMClips";
        public static XName Notes = ep + "Notes";
        public static XName Pages = ep + "Pages";
        public static XName Paragraphs = ep + "Paragraphs";
        public static XName PresentationFormat = ep + "PresentationFormat";
        public static XName Properties = ep + "Properties";
        public static XName ScaleCrop = ep + "ScaleCrop";
        public static XName SharedDoc = ep + "SharedDoc";
        public static XName Slides = ep + "Slides";
        public static XName Template = ep + "Template";
        public static XName TitlesOfParts = ep + "TitlesOfParts";
        public static XName TotalTime = ep + "TotalTime";
        public static XName Words = ep + "Words";
    }

    public static class LC
    {
        public static XNamespace lc =
            "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas";
        public static XName lockedCanvas = lc + "lockedCanvas";
    }

    public static class M
    {
        public static XNamespace m =
            "http://schemas.openxmlformats.org/officeDocument/2006/math";
        public static XName acc = m + "acc";
        public static XName accPr = m + "accPr";
        public static XName aln = m + "aln";
        public static XName alnAt = m + "alnAt";
        public static XName alnScr = m + "alnScr";
        public static XName argPr = m + "argPr";
        public static XName argSz = m + "argSz";
        public static XName bar = m + "bar";
        public static XName barPr = m + "barPr";
        public static XName baseJc = m + "baseJc";
        public static XName begChr = m + "begChr";
        public static XName borderBox = m + "borderBox";
        public static XName borderBoxPr = m + "borderBoxPr";
        public static XName box = m + "box";
        public static XName boxPr = m + "boxPr";
        public static XName brk = m + "brk";
        public static XName brkBin = m + "brkBin";
        public static XName brkBinSub = m + "brkBinSub";
        public static XName cGp = m + "cGp";
        public static XName cGpRule = m + "cGpRule";
        public static XName chr = m + "chr";
        public static XName count = m + "count";
        public static XName cSp = m + "cSp";
        public static XName ctrlPr = m + "ctrlPr";
        public static XName d = m + "d";
        public static XName defJc = m + "defJc";
        public static XName deg = m + "deg";
        public static XName degHide = m + "degHide";
        public static XName den = m + "den";
        public static XName diff = m + "diff";
        public static XName dispDef = m + "dispDef";
        public static XName dPr = m + "dPr";
        public static XName e = m + "e";
        public static XName endChr = m + "endChr";
        public static XName eqArr = m + "eqArr";
        public static XName eqArrPr = m + "eqArrPr";
        public static XName f = m + "f";
        public static XName fName = m + "fName";
        public static XName fPr = m + "fPr";
        public static XName func = m + "func";
        public static XName funcPr = m + "funcPr";
        public static XName groupChr = m + "groupChr";
        public static XName groupChrPr = m + "groupChrPr";
        public static XName grow = m + "grow";
        public static XName hideBot = m + "hideBot";
        public static XName hideLeft = m + "hideLeft";
        public static XName hideRight = m + "hideRight";
        public static XName hideTop = m + "hideTop";
        public static XName interSp = m + "interSp";
        public static XName intLim = m + "intLim";
        public static XName intraSp = m + "intraSp";
        public static XName jc = m + "jc";
        public static XName lim = m + "lim";
        public static XName limLoc = m + "limLoc";
        public static XName limLow = m + "limLow";
        public static XName limLowPr = m + "limLowPr";
        public static XName limUpp = m + "limUpp";
        public static XName limUppPr = m + "limUppPr";
        public static XName lit = m + "lit";
        public static XName lMargin = m + "lMargin";
        public static XName _m = m + "m";
        public static XName mathFont = m + "mathFont";
        public static XName mathPr = m + "mathPr";
        public static XName maxDist = m + "maxDist";
        public static XName mc = m + "mc";
        public static XName mcJc = m + "mcJc";
        public static XName mcPr = m + "mcPr";
        public static XName mcs = m + "mcs";
        public static XName mPr = m + "mPr";
        public static XName mr = m + "mr";
        public static XName nary = m + "nary";
        public static XName naryLim = m + "naryLim";
        public static XName naryPr = m + "naryPr";
        public static XName noBreak = m + "noBreak";
        public static XName nor = m + "nor";
        public static XName num = m + "num";
        public static XName objDist = m + "objDist";
        public static XName oMath = m + "oMath";
        public static XName oMathPara = m + "oMathPara";
        public static XName oMathParaPr = m + "oMathParaPr";
        public static XName opEmu = m + "opEmu";
        public static XName phant = m + "phant";
        public static XName phantPr = m + "phantPr";
        public static XName plcHide = m + "plcHide";
        public static XName pos = m + "pos";
        public static XName postSp = m + "postSp";
        public static XName preSp = m + "preSp";
        public static XName r = m + "r";
        public static XName rad = m + "rad";
        public static XName radPr = m + "radPr";
        public static XName rMargin = m + "rMargin";
        public static XName rPr = m + "rPr";
        public static XName rSp = m + "rSp";
        public static XName rSpRule = m + "rSpRule";
        public static XName scr = m + "scr";
        public static XName sepChr = m + "sepChr";
        public static XName show = m + "show";
        public static XName shp = m + "shp";
        public static XName smallFrac = m + "smallFrac";
        public static XName sPre = m + "sPre";
        public static XName sPrePr = m + "sPrePr";
        public static XName sSub = m + "sSub";
        public static XName sSubPr = m + "sSubPr";
        public static XName sSubSup = m + "sSubSup";
        public static XName sSubSupPr = m + "sSubSupPr";
        public static XName sSup = m + "sSup";
        public static XName sSupPr = m + "sSupPr";
        public static XName strikeBLTR = m + "strikeBLTR";
        public static XName strikeH = m + "strikeH";
        public static XName strikeTLBR = m + "strikeTLBR";
        public static XName strikeV = m + "strikeV";
        public static XName sty = m + "sty";
        public static XName sub = m + "sub";
        public static XName subHide = m + "subHide";
        public static XName sup = m + "sup";
        public static XName supHide = m + "supHide";
        public static XName t = m + "t";
        public static XName transp = m + "transp";
        public static XName type = m + "type";
        public static XName val = m + "val";
        public static XName vertJc = m + "vertJc";
        public static XName wrapIndent = m + "wrapIndent";
        public static XName wrapRight = m + "wrapRight";
        public static XName zeroAsc = m + "zeroAsc";
        public static XName zeroDesc = m + "zeroDesc";
        public static XName zeroWid = m + "zeroWid";
    }

    public static class MC
    {
        public static XNamespace mc =
            "http://schemas.openxmlformats.org/markup-compatibility/2006";
        public static XName AlternateContent = mc + "AlternateContent";
        public static XName Choice = mc + "Choice";
        public static XName Fallback = mc + "Fallback";
        public static XName Ignorable = mc + "Ignorable";
        public static XName PreserveAttributes = mc + "PreserveAttributes";
    }

    public static class MDSSI
    {
        public static XNamespace mdssi =
            "http://schemas.openxmlformats.org/package/2006/digital-signature";
        public static XName Format = mdssi + "Format";
        public static XName RelationshipReference = mdssi + "RelationshipReference";
        public static XName SignatureTime = mdssi + "SignatureTime";
        public static XName Value = mdssi + "Value";
    }

    public static class MP
    {
        public static XNamespace mp =
            "http://schemas.microsoft.com/office/mac/powerpoint/2008/main";
        public static XName cube = mp + "cube";
        public static XName flip = mp + "flip";
        public static XName transition = mp + "transition";
    }

    public static class MV
    {
        public static XNamespace mv =
            "urn:schemas-microsoft-com:mac:vml";
        public static XName blur = mv + "blur";
        public static XName complextextbox = mv + "complextextbox";
    }

    public static class NoNamespace
    {
        public static XName a = "a";
        public static XName accent1 = "accent1";
        public static XName accent2 = "accent2";
        public static XName accent3 = "accent3";
        public static XName accent4 = "accent4";
        public static XName accent5 = "accent5";
        public static XName accent6 = "accent6";
        public static XName action = "action";
        public static XName activeCell = "activeCell";
        public static XName activeCol = "activeCol";
        public static XName activePane = "activePane";
        public static XName activeRow = "activeRow";
        public static XName advise = "advise";
        public static XName algn = "algn";
        public static XName Algorithm = "Algorithm";
        public static XName alignWithMargins = "alignWithMargins";
        public static XName allowcomments = "allowcomments";
        public static XName allowOverlap = "allowOverlap";
        public static XName allUniqueName = "allUniqueName";
        public static XName alt = "alt";
        public static XName alwaysShow = "alwaysShow";
        public static XName amount = "amount";
        public static XName amt = "amt";
        public static XName anchor = "anchor";
        public static XName anchorCtr = "anchorCtr";
        public static XName ang = "ang";
        public static XName animBg = "animBg";
        public static XName annotation = "annotation";
        public static XName applyAlignment = "applyAlignment";
        public static XName applyAlignmentFormats = "applyAlignmentFormats";
        public static XName applyBorder = "applyBorder";
        public static XName applyBorderFormats = "applyBorderFormats";
        public static XName applyFill = "applyFill";
        public static XName applyFont = "applyFont";
        public static XName applyFontFormats = "applyFontFormats";
        public static XName applyNumberFormat = "applyNumberFormat";
        public static XName applyNumberFormats = "applyNumberFormats";
        public static XName applyPatternFormats = "applyPatternFormats";
        public static XName applyProtection = "applyProtection";
        public static XName applyWidthHeightFormats = "applyWidthHeightFormats";
        public static XName arcsize = "arcsize";
        public static XName arg = "arg";
        public static XName aspectratio = "aspectratio";
        public static XName assign = "assign";
        public static XName attribute = "attribute";
        public static XName author = "author";
        public static XName authorId = "authorId";
        public static XName auto = "auto";
        public static XName autoEnd = "autoEnd";
        public static XName autoFormatId = "autoFormatId";
        public static XName autoLine = "autoLine";
        public static XName autoStart = "autoStart";
        public static XName axis = "axis";
        public static XName b = "b";
        public static XName backdepth = "backdepth";
        public static XName bandRow = "bandRow";
        public static XName _base = "base";
        public static XName baseField = "baseField";
        public static XName baseItem = "baseItem";
        public static XName baseline = "baseline";
        public static XName baseType = "baseType";
        public static XName behindDoc = "behindDoc";
        public static XName bestFit = "bestFit";
        public static XName bg1 = "bg1";
        public static XName bg2 = "bg2";
        public static XName bIns = "bIns";
        public static XName bld = "bld";
        public static XName bldStep = "bldStep";
        public static XName blend = "blend";
        public static XName blurRad = "blurRad";
        public static XName bmkName = "bmkName";
        public static XName borderId = "borderId";
        public static XName bottom = "bottom";
        public static XName bright = "bright";
        public static XName brightness = "brightness";
        public static XName builtinId = "builtinId";
        public static XName bwMode = "bwMode";
        public static XName by = "by";
        public static XName c = "c";
        public static XName cacheId = "cacheId";
        public static XName cacheIndex = "cacheIndex";
        public static XName calcmode = "calcmode";
        public static XName cap = "cap";
        public static XName caption = "caption";
        public static XName categoryIdx = "categoryIdx";
        public static XName cell = "cell";
        public static XName cellColor = "cellColor";
        public static XName cellRange = "cellRange";
        public static XName _char = "char";
        public static XName charset = "charset";
        public static XName chart = "chart";
        public static XName clearComments = "clearComments";
        public static XName clearFormats = "clearFormats";
        public static XName click = "click";
        public static XName clientInsertedTime = "clientInsertedTime";
        public static XName clrIdx = "clrIdx";
        public static XName clrSpc = "clrSpc";
        public static XName cmd = "cmd";
        public static XName cmpd = "cmpd";
        public static XName codeName = "codeName";
        public static XName coerce = "coerce";
        public static XName colId = "colId";
        public static XName color = "color";
        public static XName colors = "colors";
        public static XName colorTemp = "colorTemp";
        public static XName colPageCount = "colPageCount";
        public static XName cols = "cols";
        public static XName comma = "comma";
        public static XName command = "command";
        public static XName commandType = "commandType";
        public static XName comment = "comment";
        public static XName compatLnSpc = "compatLnSpc";
        public static XName concurrent = "concurrent";
        public static XName connection = "connection";
        public static XName connectionId = "connectionId";
        public static XName connectloc = "connectloc";
        public static XName consecutive = "consecutive";
        public static XName constrainbounds = "constrainbounds";
        public static XName containsInteger = "containsInteger";
        public static XName containsNumber = "containsNumber";
        public static XName containsSemiMixedTypes = "containsSemiMixedTypes";
        public static XName containsString = "containsString";
        public static XName contrast = "contrast";
        public static XName control1 = "control1";
        public static XName control2 = "control2";
        public static XName coordorigin = "coordorigin";
        public static XName coordsize = "coordsize";
        public static XName copy = "copy";
        public static XName count = "count";
        public static XName createdVersion = "createdVersion";
        public static XName cryptAlgorithmClass = "cryptAlgorithmClass";
        public static XName cryptAlgorithmSid = "cryptAlgorithmSid";
        public static XName cryptAlgorithmType = "cryptAlgorithmType";
        public static XName cryptProviderType = "cryptProviderType";
        public static XName csCatId = "csCatId";
        public static XName cstate = "cstate";
        public static XName csTypeId = "csTypeId";
        public static XName culture = "culture";
        public static XName current = "current";
        public static XName customFormat = "customFormat";
        public static XName customList = "customList";
        public static XName customWidth = "customWidth";
        public static XName cx = "cx";
        public static XName cy = "cy";
        public static XName d = "d";
        public static XName data = "data";
        public static XName dataCaption = "dataCaption";
        public static XName dataDxfId = "dataDxfId";
        public static XName dataField = "dataField";
        public static XName dateTime = "dateTime";
        public static XName dateTimeGrouping = "dateTimeGrouping";
        public static XName dde = "dde";
        public static XName ddeService = "ddeService";
        public static XName ddeTopic = "ddeTopic";
        public static XName def = "def";
        public static XName defaultMemberUniqueName = "defaultMemberUniqueName";
        public static XName defaultPivotStyle = "defaultPivotStyle";
        public static XName defaultRowHeight = "defaultRowHeight";
        public static XName defaultSize = "defaultSize";
        public static XName defaultTableStyle = "defaultTableStyle";
        public static XName defStyle = "defStyle";
        public static XName defTabSz = "defTabSz";
        public static XName degree = "degree";
        public static XName delay = "delay";
        public static XName descending = "descending";
        public static XName descr = "descr";
        public static XName destId = "destId";
        public static XName destination = "destination";
        public static XName destinationFile = "destinationFile";
        public static XName destOrd = "destOrd";
        public static XName dgmfontsize = "dgmfontsize";
        public static XName dgmstyle = "dgmstyle";
        public static XName diagonalDown = "diagonalDown";
        public static XName diagonalUp = "diagonalUp";
        public static XName dimension = "dimension";
        public static XName dimensionUniqueName = "dimensionUniqueName";
        public static XName dir = "dir";
        public static XName dirty = "dirty";
        public static XName display = "display";
        public static XName displayFolder = "displayFolder";
        public static XName displayName = "displayName";
        public static XName dist = "dist";
        public static XName distB = "distB";
        public static XName distL = "distL";
        public static XName distR = "distR";
        public static XName distT = "distT";
        public static XName divId = "divId";
        public static XName dpi = "dpi";
        public static XName dr = "dr";
        public static XName DrawAspect = "DrawAspect";
        public static XName dt = "dt";
        public static XName dur = "dur";
        public static XName dx = "dx";
        public static XName dxfId = "dxfId";
        public static XName dy = "dy";
        public static XName dz = "dz";
        public static XName eaLnBrk = "eaLnBrk";
        public static XName eb = "eb";
        public static XName edited = "edited";
        public static XName editPage = "editPage";
        public static XName end = "end";
        public static XName endA = "endA";
        public static XName endangle = "endangle";
        public static XName endDate = "endDate";
        public static XName endPos = "endPos";
        public static XName endSnd = "endSnd";
        public static XName eqn = "eqn";
        public static XName evalOrder = "evalOrder";
        public static XName evt = "evt";
        public static XName exp = "exp";
        public static XName extProperty = "extProperty";
        public static XName f = "f";
        public static XName fact = "fact";
        public static XName field = "field";
        public static XName fieldId = "fieldId";
        public static XName fieldListSortAscending = "fieldListSortAscending";
        public static XName fieldPosition = "fieldPosition";
        public static XName fileType = "fileType";
        public static XName fillcolor = "fillcolor";
        public static XName filled = "filled";
        public static XName fillId = "fillId";
        public static XName filter = "filter";
        public static XName filterVal = "filterVal";
        public static XName first = "first";
        public static XName firstDataCol = "firstDataCol";
        public static XName firstDataRow = "firstDataRow";
        public static XName firstHeaderRow = "firstHeaderRow";
        public static XName firstRow = "firstRow";
        public static XName fitshape = "fitshape";
        public static XName fitToPage = "fitToPage";
        public static XName fld = "fld";
        public static XName flip = "flip";
        public static XName fmla = "fmla";
        public static XName fmtid = "fmtid";
        public static XName folHlink = "folHlink";
        public static XName followColorScheme = "followColorScheme";
        public static XName fontId = "fontId";
        public static XName footer = "footer";
        public static XName _for = "for";
        public static XName forceAA = "forceAA";
        public static XName format = "format";
        public static XName formatCode = "formatCode";
        public static XName formula = "formula";
        public static XName forName = "forName";
        public static XName fov = "fov";
        public static XName frame = "frame";
        public static XName from = "from";
        public static XName fromWordArt = "fromWordArt";
        public static XName fullCalcOnLoad = "fullCalcOnLoad";
        public static XName func = "func";
        public static XName g = "g";
        public static XName gdRefAng = "gdRefAng";
        public static XName gdRefR = "gdRefR";
        public static XName gdRefX = "gdRefX";
        public static XName gdRefY = "gdRefY";
        public static XName goal = "goal";
        public static XName gradientshapeok = "gradientshapeok";
        public static XName groupBy = "groupBy";
        public static XName grpId = "grpId";
        public static XName guid = "guid";
        public static XName h = "h";
        public static XName hangingPunct = "hangingPunct";
        public static XName hashData = "hashData";
        public static XName header = "header";
        public static XName headerRowBorderDxfId = "headerRowBorderDxfId";
        public static XName headerRowDxfId = "headerRowDxfId";
        public static XName hidden = "hidden";
        public static XName hier = "hier";
        public static XName hierarchy = "hierarchy";
        public static XName hierarchyUsage = "hierarchyUsage";
        public static XName highlightClick = "highlightClick";
        public static XName hlink = "hlink";
        public static XName horizontal = "horizontal";
        public static XName horizontalCentered = "horizontalCentered";
        public static XName horizontalDpi = "horizontalDpi";
        public static XName horzOverflow = "horzOverflow";
        public static XName hR = "hR";
        public static XName htmlFormat = "htmlFormat";
        public static XName htmlTables = "htmlTables";
        public static XName hue = "hue";
        public static XName i = "i";
        public static XName i1 = "i1";
        public static XName iconId = "iconId";
        public static XName iconSet = "iconSet";
        public static XName id = "id";
        public static XName Id = "Id";
        public static XName iddest = "iddest";
        public static XName idref = "idref";
        public static XName idsrc = "idsrc";
        public static XName idx = "idx";
        public static XName imgH = "imgH";
        public static XName imgW = "imgW";
        public static XName _in = "in";
        public static XName includeNewItemsInFilter = "includeNewItemsInFilter";
        public static XName indent = "indent";
        public static XName index = "index";
        public static XName indexed = "indexed";
        public static XName initials = "initials";
        public static XName insetpen = "insetpen";
        public static XName invalEndChars = "invalEndChars";
        public static XName invalidUrl = "invalidUrl";
        public static XName invalStChars = "invalStChars";
        public static XName isInverted = "isInverted";
        public static XName issignatureline = "issignatureline";
        public static XName item = "item";
        public static XName itemPrintTitles = "itemPrintTitles";
        public static XName joinstyle = "joinstyle";
        public static XName justifyLastLine = "justifyLastLine";
        public static XName key = "key";
        public static XName keyAttribute = "keyAttribute";
        public static XName l = "l";
        public static XName lang = "lang";
        public static XName lastClr = "lastClr";
        public static XName lastIdx = "lastIdx";
        public static XName lat = "lat";
        public static XName latinLnBrk = "latinLnBrk";
        public static XName layout = "layout";
        public static XName layoutInCell = "layoutInCell";
        public static XName left = "left";
        public static XName len = "len";
        public static XName length = "length";
        public static XName level = "level";
        public static XName lightharsh2 = "lightharsh2";
        public static XName lightlevel = "lightlevel";
        public static XName lightlevel2 = "lightlevel2";
        public static XName lightposition = "lightposition";
        public static XName lightposition2 = "lightposition2";
        public static XName lim = "lim";
        public static XName link = "link";
        public static XName lIns = "lIns";
        public static XName loCatId = "loCatId";
        public static XName locked = "locked";
        public static XName lon = "lon";
        public static XName loop = "loop";
        public static XName loTypeId = "loTypeId";
        public static XName lum = "lum";
        public static XName lvl = "lvl";
        public static XName macro = "macro";
        public static XName man = "man";
        public static XName manualBreakCount = "manualBreakCount";
        public static XName mapId = "mapId";
        public static XName marL = "marL";
        public static XName max = "max";
        public static XName maxAng = "maxAng";
        public static XName maxR = "maxR";
        public static XName maxRank = "maxRank";
        public static XName maxSheetId = "maxSheetId";
        public static XName maxValue = "maxValue";
        public static XName maxX = "maxX";
        public static XName maxY = "maxY";
        public static XName mdx = "mdx";
        public static XName measureGroup = "measureGroup";
        public static XName memberName = "memberName";
        public static XName merge = "merge";
        public static XName meth = "meth";
        public static XName min = "min";
        public static XName minAng = "minAng";
        public static XName minR = "minR";
        public static XName minRefreshableVersion = "minRefreshableVersion";
        public static XName minSupportedVersion = "minSupportedVersion";
        public static XName minValue = "minValue";
        public static XName minVer = "minVer";
        public static XName minX = "minX";
        public static XName minY = "minY";
        public static XName modelId = "modelId";
        public static XName moveWithCells = "moveWithCells";
        public static XName n = "n";
        public static XName name = "name";
        public static XName _new = "new";
        public static XName newLength = "newLength";
        public static XName newName = "newName";
        public static XName nextAc = "nextAc";
        public static XName nextId = "nextId";
        public static XName noChangeArrowheads = "noChangeArrowheads";
        public static XName noChangeAspect = "noChangeAspect";
        public static XName noChangeShapeType = "noChangeShapeType";
        public static XName nodeType = "nodeType";
        public static XName noEditPoints = "noEditPoints";
        public static XName noGrp = "noGrp";
        public static XName noRot = "noRot";
        public static XName noUngrp = "noUngrp";
        public static XName np = "np";
        public static XName ns = "ns";
        public static XName numCol = "numCol";
        public static XName numFmtId = "numFmtId";
        public static XName o = "o";
        public static XName ObjectID = "ObjectID";
        public static XName objects = "objects";
        public static XName ObjectType = "ObjectType";
        public static XName objId = "objId";
        public static XName offset = "offset";
        public static XName old = "old";
        public static XName oldComment = "oldComment";
        public static XName oldName = "oldName";
        public static XName oleUpdate = "oleUpdate";
        public static XName on = "on";
        public static XName op = "op";
        public static XName orient = "orient";
        public static XName orientation = "orientation";
        public static XName origin = "origin";
        public static XName _out = "out";
        public static XName outline = "outline";
        public static XName outlineData = "outlineData";
        public static XName p = "p";
        public static XName pane = "pane";
        public static XName panose = "panose";
        public static XName paperSize = "paperSize";
        public static XName par = "par";
        public static XName parameterType = "parameterType";
        public static XName parent = "parent";
        public static XName password = "password";
        public static XName pasteAll = "pasteAll";
        public static XName pasteValues = "pasteValues";
        public static XName path = "path";
        public static XName pathEditMode = "pathEditMode";
        public static XName patternType = "patternType";
        public static XName phldr = "phldr";
        public static XName pid = "pid";
        public static XName pitchFamily = "pitchFamily";
        public static XName pivot = "pivot";
        public static XName points = "points";
        public static XName pos = "pos";
        public static XName position = "position";
        public static XName post = "post";
        public static XName preferPic = "preferPic";
        public static XName preserve = "preserve";
        public static XName pressure = "pressure";
        public static XName previousCol = "previousCol";
        public static XName previousRow = "previousRow";
        public static XName pri = "pri";
        public static XName priority = "priority";
        public static XName progId = "progId";
        public static XName ProgID = "ProgID";
        public static XName provid = "provid";
        public static XName prst = "prst";
        public static XName prstMaterial = "prstMaterial";
        public static XName ptsTypes = "ptsTypes";
        public static XName ptType = "ptType";
        public static XName qsCatId = "qsCatId";
        public static XName qsTypeId = "qsTypeId";
        public static XName r = "r";
        public static XName rad = "rad";
        public static XName readingOrder = "readingOrder";
        public static XName recordCount = "recordCount";
        public static XName _ref = "ref";
        public static XName ref3D = "ref3D";
        public static XName refersTo = "refersTo";
        public static XName refreshedBy = "refreshedBy";
        public static XName refreshedDate = "refreshedDate";
        public static XName refreshedVersion = "refreshedVersion";
        public static XName refreshOnLoad = "refreshOnLoad";
        public static XName refType = "refType";
        public static XName relativeFrom = "relativeFrom";
        public static XName relativeHeight = "relativeHeight";
        public static XName relId = "relId";
        public static XName Requires = "Requires";
        public static XName restart = "restart";
        public static XName rev = "rev";
        public static XName rgb = "rgb";
        public static XName rId = "rId";
        public static XName rig = "rig";
        public static XName right = "right";
        public static XName rIns = "rIns";
        public static XName rot = "rot";
        public static XName rotWithShape = "rotWithShape";
        public static XName rowColShift = "rowColShift";
        public static XName rowDrillCount = "rowDrillCount";
        public static XName rowPageCount = "rowPageCount";
        public static XName rows = "rows";
        public static XName rtl = "rtl";
        public static XName rtlCol = "rtlCol";
        public static XName s = "s";
        public static XName saltData = "saltData";
        public static XName sat = "sat";
        public static XName saveData = "saveData";
        public static XName saveSubsetFonts = "saveSubsetFonts";
        public static XName sb = "sb";
        public static XName scaled = "scaled";
        public static XName scaling = "scaling";
        public static XName scenarios = "scenarios";
        public static XName scope = "scope";
        public static XName script = "script";
        public static XName securityDescriptor = "securityDescriptor";
        public static XName seek = "seek";
        public static XName sendLocale = "sendLocale";
        public static XName series = "series";
        public static XName seriesIdx = "seriesIdx";
        public static XName serverSldId = "serverSldId";
        public static XName serverSldModifiedTime = "serverSldModifiedTime";
        public static XName setDefinition = "setDefinition";
        public static XName shapeId = "shapeId";
        public static XName ShapeID = "ShapeID";
        public static XName sheet = "sheet";
        public static XName sheetId = "sheetId";
        public static XName sheetPosition = "sheetPosition";
        public static XName show = "show";
        public static XName showAll = "showAll";
        public static XName showCaptions = "showCaptions";
        public static XName showColHeaders = "showColHeaders";
        public static XName showColStripes = "showColStripes";
        public static XName showColumnStripes = "showColumnStripes";
        public static XName showErrorMessage = "showErrorMessage";
        public static XName showFirstColumn = "showFirstColumn";
        public static XName showHeader = "showHeader";
        public static XName showInputMessage = "showInputMessage";
        public static XName showLastColumn = "showLastColumn";
        public static XName showRowHeaders = "showRowHeaders";
        public static XName showRowStripes = "showRowStripes";
        public static XName showValue = "showValue";
        public static XName shrinkToFit = "shrinkToFit";
        public static XName si = "si";
        public static XName sId = "sId";
        public static XName simplePos = "simplePos";
        public static XName size = "size";
        public static XName skewangle = "skewangle";
        public static XName smoothness = "smoothness";
        public static XName smtClean = "smtClean";
        public static XName source = "source";
        public static XName sourceFile = "sourceFile";
        public static XName SourceId = "SourceId";
        public static XName sourceLinked = "sourceLinked";
        public static XName sourceSheetId = "sourceSheetId";
        public static XName sourceType = "sourceType";
        public static XName sp = "sp";
        public static XName spans = "spans";
        public static XName spcCol = "spcCol";
        public static XName spcFirstLastPara = "spcFirstLastPara";
        public static XName spid = "spid";
        public static XName spidmax = "spidmax";
        public static XName spinCount = "spinCount";
        public static XName splitFirst = "splitFirst";
        public static XName spokes = "spokes";
        public static XName sqlType = "sqlType";
        public static XName sqref = "sqref";
        public static XName src = "src";
        public static XName srcId = "srcId";
        public static XName srcOrd = "srcOrd";
        public static XName st = "st";
        public static XName stA = "stA";
        public static XName stAng = "stAng";
        public static XName start = "start";
        public static XName startangle = "startangle";
        public static XName startDate = "startDate";
        public static XName status = "status";
        public static XName strike = "strike";
        public static XName _string = "string";
        public static XName strokecolor = "strokecolor";
        public static XName stroked = "stroked";
        public static XName strokeweight = "strokeweight";
        public static XName style = "style";
        public static XName styleId = "styleId";
        public static XName styleName = "styleName";
        public static XName subtotal = "subtotal";
        public static XName summaryBelow = "summaryBelow";
        public static XName swAng = "swAng";
        public static XName sx = "sx";
        public static XName sy = "sy";
        public static XName sz = "sz";
        public static XName t = "t";
        public static XName tab = "tab";
        public static XName tableBorderDxfId = "tableBorderDxfId";
        public static XName tableColumnId = "tableColumnId";
        public static XName Target = "Target";
        public static XName textlink = "textlink";
        public static XName textRotation = "textRotation";
        public static XName theme = "theme";
        public static XName thresh = "thresh";
        public static XName thruBlk = "thruBlk";
        public static XName time = "time";
        public static XName tIns = "tIns";
        public static XName tint = "tint";
        public static XName tm = "tm";
        public static XName to = "to";
        public static XName tooltip = "tooltip";
        public static XName top = "top";
        public static XName topLabels = "topLabels";
        public static XName topLeftCell = "topLeftCell";
        public static XName totalsRowShown = "totalsRowShown";
        public static XName track = "track";
        public static XName trans = "trans";
        public static XName transition = "transition";
        public static XName trend = "trend";
        public static XName twoDigitTextYear = "twoDigitTextYear";
        public static XName tx = "tx";
        public static XName tx1 = "tx1";
        public static XName tx2 = "tx2";
        public static XName txBox = "txBox";
        public static XName txbxSeq = "txbxSeq";
        public static XName txbxStory = "txbxStory";
        public static XName ty = "ty";
        public static XName type = "type";
        public static XName Type = "Type";
        public static XName typeface = "typeface";
        public static XName u = "u";
        public static XName ua = "ua";
        public static XName uiExpand = "uiExpand";
        public static XName unbalanced = "unbalanced";
        public static XName uniqueCount = "uniqueCount";
        public static XName uniqueId = "uniqueId";
        public static XName uniqueName = "uniqueName";
        public static XName uniqueParent = "uniqueParent";
        public static XName updateAutomatic = "updateAutomatic";
        public static XName updatedVersion = "updatedVersion";
        public static XName uri = "uri";
        public static XName URI = "URI";
        public static XName url = "url";
        public static XName useAutoFormatting = "useAutoFormatting";
        public static XName useDef = "useDef";
        public static XName user = "user";
        public static XName userName = "userName";
        public static XName v = "v";
        public static XName val = "val";
        public static XName value = "value";
        public static XName valueType = "valueType";
        public static XName varScale = "varScale";
        public static XName vert = "vert";
        public static XName vertical = "vertical";
        public static XName verticalCentered = "verticalCentered";
        public static XName verticalDpi = "verticalDpi";
        public static XName vertOverflow = "vertOverflow";
        public static XName viewpoint = "viewpoint";
        public static XName viewpointorigin = "viewpointorigin";
        public static XName w = "w";
        public static XName weight = "weight";
        public static XName width = "width";
        public static XName workbookViewId = "workbookViewId";
        public static XName wR = "wR";
        public static XName wrap = "wrap";
        public static XName wrapText = "wrapText";
        public static XName x = "x";
        public static XName x1 = "x1";
        public static XName x2 = "x2";
        public static XName xfId = "xfId";
        public static XName xl97 = "xl97";
        public static XName xmlDataType = "xmlDataType";
        public static XName xpath = "xpath";
        public static XName xSplit = "xSplit";
        public static XName y = "y";
        public static XName y1 = "y1";
        public static XName y2 = "y2";
        public static XName year = "year";
        public static XName yrange = "yrange";
        public static XName ySplit = "ySplit";
        public static XName z = "z";
    }

    public static class O
    {
        public static XNamespace o =
            "urn:schemas-microsoft-com:office:office";
        public static XName allowincell = o + "allowincell";
        public static XName allowoverlap = o + "allowoverlap";
        public static XName althref = o + "althref";
        public static XName borderbottomcolor = o + "borderbottomcolor";
        public static XName borderleftcolor = o + "borderleftcolor";
        public static XName borderrightcolor = o + "borderrightcolor";
        public static XName bordertopcolor = o + "bordertopcolor";
        public static XName bottom = o + "bottom";
        public static XName bullet = o + "bullet";
        public static XName button = o + "button";
        public static XName bwmode = o + "bwmode";
        public static XName bwnormal = o + "bwnormal";
        public static XName bwpure = o + "bwpure";
        public static XName callout = o + "callout";
        public static XName clip = o + "clip";
        public static XName clippath = o + "clippath";
        public static XName cliptowrap = o + "cliptowrap";
        public static XName colormenu = o + "colormenu";
        public static XName colormru = o + "colormru";
        public static XName column = o + "column";
        public static XName complex = o + "complex";
        public static XName connectangles = o + "connectangles";
        public static XName connectlocs = o + "connectlocs";
        public static XName connectortype = o + "connectortype";
        public static XName connecttype = o + "connecttype";
        public static XName detectmouseclick = o + "detectmouseclick";
        public static XName dgmlayout = o + "dgmlayout";
        public static XName dgmlayoutmru = o + "dgmlayoutmru";
        public static XName dgmnodekind = o + "dgmnodekind";
        public static XName diagram = o + "diagram";
        public static XName doubleclicknotify = o + "doubleclicknotify";
        public static XName entry = o + "entry";
        public static XName extrusion = o + "extrusion";
        public static XName extrusionok = o + "extrusionok";
        public static XName FieldCodes = o + "FieldCodes";
        public static XName fill = o + "fill";
        public static XName forcedash = o + "forcedash";
        public static XName gfxdata = o + "gfxdata";
        public static XName hr = o + "hr";
        public static XName hralign = o + "hralign";
        public static XName href = o + "href";
        public static XName hrnoshade = o + "hrnoshade";
        public static XName hrpct = o + "hrpct";
        public static XName hrstd = o + "hrstd";
        public static XName idmap = o + "idmap";
        public static XName ink = o + "ink";
        public static XName insetmode = o + "insetmode";
        public static XName left = o + "left";
        public static XName LinkType = o + "LinkType";
        public static XName _lock = o + "lock";
        public static XName LockedField = o + "LockedField";
        public static XName master = o + "master";
        public static XName ole = o + "ole";
        public static XName oleicon = o + "oleicon";
        public static XName OLEObject = o + "OLEObject";
        public static XName oned = o + "oned";
        public static XName opacity2 = o + "opacity2";
        public static XName preferrelative = o + "preferrelative";
        public static XName proxy = o + "proxy";
        public static XName r = o + "r";
        public static XName regroupid = o + "regroupid";
        public static XName regrouptable = o + "regrouptable";
        public static XName rel = o + "rel";
        public static XName relationtable = o + "relationtable";
        public static XName relid = o + "relid";
        public static XName right = o + "right";
        public static XName rules = o + "rules";
        public static XName shapedefaults = o + "shapedefaults";
        public static XName shapelayout = o + "shapelayout";
        public static XName signatureline = o + "signatureline";
        public static XName singleclick = o + "singleclick";
        public static XName skew = o + "skew";
        public static XName spid = o + "spid";
        public static XName spt = o + "spt";
        public static XName suggestedsigner = o + "suggestedsigner";
        public static XName suggestedsigner2 = o + "suggestedsigner2";
        public static XName suggestedsigneremail = o + "suggestedsigneremail";
        public static XName tablelimits = o + "tablelimits";
        public static XName tableproperties = o + "tableproperties";
        public static XName targetscreensize = o + "targetscreensize";
        public static XName title = o + "title";
        public static XName top = o + "top";
        public static XName userdrawn = o + "userdrawn";
        public static XName userhidden = o + "userhidden";
        public static XName v = o + "v";
    }

    public static class P
    {
        public static XNamespace p =
            "http://schemas.openxmlformats.org/presentationml/2006/main";
        public static XName anim = p + "anim";
        public static XName animClr = p + "animClr";
        public static XName animEffect = p + "animEffect";
        public static XName animMotion = p + "animMotion";
        public static XName animRot = p + "animRot";
        public static XName animScale = p + "animScale";
        public static XName attrName = p + "attrName";
        public static XName attrNameLst = p + "attrNameLst";
        public static XName audio = p + "audio";
        public static XName bg = p + "bg";
        public static XName bgPr = p + "bgPr";
        public static XName bgRef = p + "bgRef";
        public static XName bldAsOne = p + "bldAsOne";
        public static XName bldDgm = p + "bldDgm";
        public static XName bldGraphic = p + "bldGraphic";
        public static XName bldLst = p + "bldLst";
        public static XName bldOleChart = p + "bldOleChart";
        public static XName bldP = p + "bldP";
        public static XName bldSub = p + "bldSub";
        public static XName blinds = p + "blinds";
        public static XName blipFill = p + "blipFill";
        public static XName bodyStyle = p + "bodyStyle";
        public static XName bold = p + "bold";
        public static XName boldItalic = p + "boldItalic";
        public static XName boolVal = p + "boolVal";
        public static XName by = p + "by";
        public static XName cBhvr = p + "cBhvr";
        public static XName charRg = p + "charRg";
        public static XName checker = p + "checker";
        public static XName childTnLst = p + "childTnLst";
        public static XName circle = p + "circle";
        public static XName clrMap = p + "clrMap";
        public static XName clrMapOvr = p + "clrMapOvr";
        public static XName clrVal = p + "clrVal";
        public static XName cm = p + "cm";
        public static XName cmAuthor = p + "cmAuthor";
        public static XName cmAuthorLst = p + "cmAuthorLst";
        public static XName cmd = p + "cmd";
        public static XName cMediaNode = p + "cMediaNode";
        public static XName cmLst = p + "cmLst";
        public static XName cNvCxnSpPr = p + "cNvCxnSpPr";
        public static XName cNvGraphicFramePr = p + "cNvGraphicFramePr";
        public static XName cNvGrpSpPr = p + "cNvGrpSpPr";
        public static XName cNvPicPr = p + "cNvPicPr";
        public static XName cNvPr = p + "cNvPr";
        public static XName cNvSpPr = p + "cNvSpPr";
        public static XName comb = p + "comb";
        public static XName cond = p + "cond";
        public static XName contentPart = p + "contentPart";
        public static XName control = p + "control";
        public static XName controls = p + "controls";
        public static XName cover = p + "cover";
        public static XName cSld = p + "cSld";
        public static XName cSldViewPr = p + "cSldViewPr";
        public static XName cTn = p + "cTn";
        public static XName custData = p + "custData";
        public static XName custDataLst = p + "custDataLst";
        public static XName custShow = p + "custShow";
        public static XName custShowLst = p + "custShowLst";
        public static XName cut = p + "cut";
        public static XName cViewPr = p + "cViewPr";
        public static XName cxnSp = p + "cxnSp";
        public static XName defaultTextStyle = p + "defaultTextStyle";
        public static XName diamond = p + "diamond";
        public static XName dissolve = p + "dissolve";
        public static XName embed = p + "embed";
        public static XName embeddedFont = p + "embeddedFont";
        public static XName embeddedFontLst = p + "embeddedFontLst";
        public static XName endCondLst = p + "endCondLst";
        public static XName endSnd = p + "endSnd";
        public static XName endSync = p + "endSync";
        public static XName ext = p + "ext";
        public static XName externalData = p + "externalData";
        public static XName extLst = p + "extLst";
        public static XName fade = p + "fade";
        public static XName fltVal = p + "fltVal";
        public static XName font = p + "font";
        public static XName from = p + "from";
        public static XName graphicEl = p + "graphicEl";
        public static XName graphicFrame = p + "graphicFrame";
        public static XName gridSpacing = p + "gridSpacing";
        public static XName grpSp = p + "grpSp";
        public static XName grpSpPr = p + "grpSpPr";
        public static XName guide = p + "guide";
        public static XName guideLst = p + "guideLst";
        public static XName handoutMaster = p + "handoutMaster";
        public static XName handoutMasterId = p + "handoutMasterId";
        public static XName handoutMasterIdLst = p + "handoutMasterIdLst";
        public static XName hf = p + "hf";
        public static XName hsl = p + "hsl";
        public static XName inkTgt = p + "inkTgt";
        public static XName italic = p + "italic";
        public static XName iterate = p + "iterate";
        public static XName kinsoku = p + "kinsoku";
        public static XName link = p + "link";
        public static XName modifyVerifier = p + "modifyVerifier";
        public static XName newsflash = p + "newsflash";
        public static XName nextCondLst = p + "nextCondLst";
        public static XName normalViewPr = p + "normalViewPr";
        public static XName notes = p + "notes";
        public static XName notesMaster = p + "notesMaster";
        public static XName notesMasterId = p + "notesMasterId";
        public static XName notesMasterIdLst = p + "notesMasterIdLst";
        public static XName notesStyle = p + "notesStyle";
        public static XName notesSz = p + "notesSz";
        public static XName notesTextViewPr = p + "notesTextViewPr";
        public static XName notesViewPr = p + "notesViewPr";
        public static XName nvCxnSpPr = p + "nvCxnSpPr";
        public static XName nvGraphicFramePr = p + "nvGraphicFramePr";
        public static XName nvGrpSpPr = p + "nvGrpSpPr";
        public static XName nvPicPr = p + "nvPicPr";
        public static XName nvPr = p + "nvPr";
        public static XName nvSpPr = p + "nvSpPr";
        public static XName oleChartEl = p + "oleChartEl";
        public static XName oleObj = p + "oleObj";
        public static XName origin = p + "origin";
        public static XName otherStyle = p + "otherStyle";
        public static XName outlineViewPr = p + "outlineViewPr";
        public static XName par = p + "par";
        public static XName ph = p + "ph";
        public static XName photoAlbum = p + "photoAlbum";
        public static XName pic = p + "pic";
        public static XName plus = p + "plus";
        public static XName pos = p + "pos";
        public static XName presentation = p + "presentation";
        public static XName prevCondLst = p + "prevCondLst";
        public static XName pRg = p + "pRg";
        public static XName pull = p + "pull";
        public static XName push = p + "push";
        public static XName random = p + "random";
        public static XName randomBar = p + "randomBar";
        public static XName rCtr = p + "rCtr";
        public static XName regular = p + "regular";
        public static XName restoredLeft = p + "restoredLeft";
        public static XName restoredTop = p + "restoredTop";
        public static XName rgb = p + "rgb";
        public static XName rtn = p + "rtn";
        public static XName scale = p + "scale";
        public static XName seq = p + "seq";
        public static XName set = p + "set";
        public static XName sld = p + "sld";
        public static XName sldId = p + "sldId";
        public static XName sldIdLst = p + "sldIdLst";
        public static XName sldLayout = p + "sldLayout";
        public static XName sldLayoutId = p + "sldLayoutId";
        public static XName sldLayoutIdLst = p + "sldLayoutIdLst";
        public static XName sldLst = p + "sldLst";
        public static XName sldMaster = p + "sldMaster";
        public static XName sldMasterId = p + "sldMasterId";
        public static XName sldMasterIdLst = p + "sldMasterIdLst";
        public static XName sldSyncPr = p + "sldSyncPr";
        public static XName sldSz = p + "sldSz";
        public static XName sldTgt = p + "sldTgt";
        public static XName slideViewPr = p + "slideViewPr";
        public static XName snd = p + "snd";
        public static XName sndAc = p + "sndAc";
        public static XName sndTgt = p + "sndTgt";
        public static XName sorterViewPr = p + "sorterViewPr";
        public static XName sp = p + "sp";
        public static XName split = p + "split";
        public static XName spPr = p + "spPr";
        public static XName spTgt = p + "spTgt";
        public static XName spTree = p + "spTree";
        public static XName stCondLst = p + "stCondLst";
        public static XName strips = p + "strips";
        public static XName strVal = p + "strVal";
        public static XName stSnd = p + "stSnd";
        public static XName style = p + "style";
        public static XName subSp = p + "subSp";
        public static XName subTnLst = p + "subTnLst";
        public static XName tag = p + "tag";
        public static XName tagLst = p + "tagLst";
        public static XName tags = p + "tags";
        public static XName tav = p + "tav";
        public static XName tavLst = p + "tavLst";
        public static XName text = p + "text";
        public static XName tgtEl = p + "tgtEl";
        public static XName timing = p + "timing";
        public static XName titleStyle = p + "titleStyle";
        public static XName tmAbs = p + "tmAbs";
        public static XName tmPct = p + "tmPct";
        public static XName tmpl = p + "tmpl";
        public static XName tmplLst = p + "tmplLst";
        public static XName tn = p + "tn";
        public static XName tnLst = p + "tnLst";
        public static XName to = p + "to";
        public static XName transition = p + "transition";
        public static XName txBody = p + "txBody";
        public static XName txEl = p + "txEl";
        public static XName txStyles = p + "txStyles";
        public static XName val = p + "val";
        public static XName video = p + "video";
        public static XName viewPr = p + "viewPr";
        public static XName wedge = p + "wedge";
        public static XName wheel = p + "wheel";
        public static XName wipe = p + "wipe";
        public static XName xfrm = p + "xfrm";
        public static XName zoom = p + "zoom";
    }

    public static class P14
    {
        public static XNamespace p14 =
            "http://schemas.microsoft.com/office/powerpoint/2010/main";
        public static XName bmk = p14 + "bmk";
        public static XName bmkLst = p14 + "bmkLst";
        public static XName bmkTgt = p14 + "bmkTgt";
        public static XName bounceEnd = p14 + "bounceEnd";
        public static XName bwMode = p14 + "bwMode";
        public static XName cNvContentPartPr = p14 + "cNvContentPartPr";
        public static XName cNvPr = p14 + "cNvPr";
        public static XName conveyor = p14 + "conveyor";
        public static XName creationId = p14 + "creationId";
        public static XName doors = p14 + "doors";
        public static XName dur = p14 + "dur";
        public static XName extLst = p14 + "extLst";
        public static XName fade = p14 + "fade";
        public static XName ferris = p14 + "ferris";
        public static XName flash = p14 + "flash";
        public static XName flip = p14 + "flip";
        public static XName flythrough = p14 + "flythrough";
        public static XName gallery = p14 + "gallery";
        public static XName glitter = p14 + "glitter";
        public static XName honeycomb = p14 + "honeycomb";
        public static XName laserTraceLst = p14 + "laserTraceLst";
        public static XName media = p14 + "media";
        public static XName modId = p14 + "modId";
        public static XName nvContentPartPr = p14 + "nvContentPartPr";
        public static XName nvPr = p14 + "nvPr";
        public static XName pan = p14 + "pan";
        public static XName pauseEvt = p14 + "pauseEvt";
        public static XName playEvt = p14 + "playEvt";
        public static XName presetBounceEnd = p14 + "presetBounceEnd";
        public static XName prism = p14 + "prism";
        public static XName resumeEvt = p14 + "resumeEvt";
        public static XName reveal = p14 + "reveal";
        public static XName ripple = p14 + "ripple";
        public static XName section = p14 + "section";
        public static XName sectionLst = p14 + "sectionLst";
        public static XName seekEvt = p14 + "seekEvt";
        public static XName showEvtLst = p14 + "showEvtLst";
        public static XName shred = p14 + "shred";
        public static XName sldId = p14 + "sldId";
        public static XName sldIdLst = p14 + "sldIdLst";
        public static XName stopEvt = p14 + "stopEvt";
        public static XName _switch = p14 + "switch";
        public static XName tracePt = p14 + "tracePt";
        public static XName tracePtLst = p14 + "tracePtLst";
        public static XName triggerEvt = p14 + "triggerEvt";
        public static XName trim = p14 + "trim";
        public static XName vortex = p14 + "vortex";
        public static XName warp = p14 + "warp";
        public static XName wheelReverse = p14 + "wheelReverse";
        public static XName window = p14 + "window";
        public static XName xfrm = p14 + "xfrm";
    }

    public static class P15
    {
        public static XNamespace p15 =
            "http://schemas.microsoft.com/office15/powerpoint";
        public static XName extElement = p15 + "extElement";
    }

    public static class PAV
    {
        public static XNamespace pav = "http://schemas.microsoft.com/office/2007/6/19/audiovideo";
        public static XName media = pav + "media";
        public static XName srcMedia = pav + "srcMedia";
        public static XName bmkLst = pav + "bmkLst";
    }

    public static class Pic
    {
        public static XNamespace pic =
            "http://schemas.openxmlformats.org/drawingml/2006/picture";
        public static XName blipFill = pic + "blipFill";
        public static XName cNvPicPr = pic + "cNvPicPr";
        public static XName cNvPr = pic + "cNvPr";
        public static XName nvPicPr = pic + "nvPicPr";
        public static XName _pic = pic + "pic";
        public static XName spPr = pic + "spPr";
    }

    public static class Plegacy
    {
        public static XNamespace plegacy = "urn:schemas-microsoft-com:office:powerpoint";
        public static XName textdata = plegacy + "textdata";
    }

    public static class R
    {
        public static XNamespace r =
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships";
        public static XName blip = r + "blip";
        public static XName cs = r + "cs";
        public static XName dm = r + "dm";
        public static XName embed = r + "embed";
        public static XName href = r + "href";
        public static XName id = r + "id";
        public static XName link = r + "link";
        public static XName lo = r + "lo";
        public static XName pict = r + "pict";
        public static XName qs = r + "qs";
        public static XName verticalDpi = r + "verticalDpi";
    }

    public static class S
    {
        public static XNamespace s =
            "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
        public static XName alignment = s + "alignment";
        public static XName anchor = s + "anchor";
        public static XName author = s + "author";
        public static XName authors = s + "authors";
        public static XName autoFilter = s + "autoFilter";
        public static XName autoSortScope = s + "autoSortScope";
        public static XName b = s + "b";
        public static XName bgColor = s + "bgColor";
        public static XName bk = s + "bk";
        public static XName border = s + "border";
        public static XName borders = s + "borders";
        public static XName bottom = s + "bottom";
        public static XName brk = s + "brk";
        public static XName c = s + "c";
        public static XName cacheField = s + "cacheField";
        public static XName cacheFields = s + "cacheFields";
        public static XName cacheHierarchies = s + "cacheHierarchies";
        public static XName cacheHierarchy = s + "cacheHierarchy";
        public static XName cacheSource = s + "cacheSource";
        public static XName calcChain = s + "calcChain";
        public static XName calcPr = s + "calcPr";
        public static XName calculatedColumnFormula = s + "calculatedColumnFormula";
        public static XName calculatedItem = s + "calculatedItem";
        public static XName calculatedItems = s + "calculatedItems";
        public static XName calculatedMember = s + "calculatedMember";
        public static XName calculatedMembers = s + "calculatedMembers";
        public static XName cell = s + "cell";
        public static XName cellMetadata = s + "cellMetadata";
        public static XName cellSmartTag = s + "cellSmartTag";
        public static XName cellSmartTagPr = s + "cellSmartTagPr";
        public static XName cellSmartTags = s + "cellSmartTags";
        public static XName cellStyle = s + "cellStyle";
        public static XName cellStyles = s + "cellStyles";
        public static XName cellStyleXfs = s + "cellStyleXfs";
        public static XName cellWatch = s + "cellWatch";
        public static XName cellWatches = s + "cellWatches";
        public static XName cellXfs = s + "cellXfs";
        public static XName cfRule = s + "cfRule";
        public static XName cfvo = s + "cfvo";
        public static XName charset = s + "charset";
        public static XName chartFormat = s + "chartFormat";
        public static XName chartFormats = s + "chartFormats";
        public static XName chartsheet = s + "chartsheet";
        public static XName col = s + "col";
        public static XName colBreaks = s + "colBreaks";
        public static XName colFields = s + "colFields";
        public static XName colHierarchiesUsage = s + "colHierarchiesUsage";
        public static XName colHierarchyUsage = s + "colHierarchyUsage";
        public static XName colItems = s + "colItems";
        public static XName color = s + "color";
        public static XName colorFilter = s + "colorFilter";
        public static XName colors = s + "colors";
        public static XName colorScale = s + "colorScale";
        public static XName cols = s + "cols";
        public static XName comment = s + "comment";
        public static XName commentList = s + "commentList";
        public static XName comments = s + "comments";
        public static XName condense = s + "condense";
        public static XName conditionalFormat = s + "conditionalFormat";
        public static XName conditionalFormats = s + "conditionalFormats";
        public static XName conditionalFormatting = s + "conditionalFormatting";
        public static XName connection = s + "connection";
        public static XName connections = s + "connections";
        public static XName consolidation = s + "consolidation";
        public static XName control = s + "control";
        public static XName controlPr = s + "controlPr";
        public static XName controls = s + "controls";
        public static XName customFilter = s + "customFilter";
        public static XName customFilters = s + "customFilters";
        public static XName customPr = s + "customPr";
        public static XName customProperties = s + "customProperties";
        public static XName customSheetView = s + "customSheetView";
        public static XName customSheetViews = s + "customSheetViews";
        public static XName d = s + "d";
        public static XName dataBar = s + "dataBar";
        public static XName dataConsolidate = s + "dataConsolidate";
        public static XName dataField = s + "dataField";
        public static XName dataFields = s + "dataFields";
        public static XName dataRef = s + "dataRef";
        public static XName dataRefs = s + "dataRefs";
        public static XName dataValidation = s + "dataValidation";
        public static XName dataValidations = s + "dataValidations";
        public static XName dateGroupItem = s + "dateGroupItem";
        public static XName dbPr = s + "dbPr";
        public static XName ddeItem = s + "ddeItem";
        public static XName ddeItems = s + "ddeItems";
        public static XName ddeLink = s + "ddeLink";
        public static XName definedName = s + "definedName";
        public static XName definedNames = s + "definedNames";
        public static XName deletedField = s + "deletedField";
        public static XName diagonal = s + "diagonal";
        public static XName dialogsheet = s + "dialogsheet";
        public static XName dimension = s + "dimension";
        public static XName dimensions = s + "dimensions";
        public static XName discretePr = s + "discretePr";
        public static XName drawing = s + "drawing";
        public static XName dxf = s + "dxf";
        public static XName dxfs = s + "dxfs";
        public static XName dynamicFilter = s + "dynamicFilter";
        public static XName e = s + "e";
        public static XName entries = s + "entries";
        public static XName evenFooter = s + "evenFooter";
        public static XName evenHeader = s + "evenHeader";
        public static XName ext = s + "ext";
        public static XName extend = s + "extend";
        public static XName externalBook = s + "externalBook";
        public static XName externalLink = s + "externalLink";
        public static XName extLst = s + "extLst";
        public static XName f = s + "f";
        public static XName family = s + "family";
        public static XName fgColor = s + "fgColor";
        public static XName field = s + "field";
        public static XName fieldGroup = s + "fieldGroup";
        public static XName fieldsUsage = s + "fieldsUsage";
        public static XName fieldUsage = s + "fieldUsage";
        public static XName fill = s + "fill";
        public static XName fills = s + "fills";
        public static XName filter = s + "filter";
        public static XName filterColumn = s + "filterColumn";
        public static XName filters = s + "filters";
        public static XName firstFooter = s + "firstFooter";
        public static XName firstHeader = s + "firstHeader";
        public static XName font = s + "font";
        public static XName fonts = s + "fonts";
        public static XName foo = s + "foo";
        public static XName format = s + "format";
        public static XName formats = s + "formats";
        public static XName formula = s + "formula";
        public static XName formula1 = s + "formula1";
        public static XName formula2 = s + "formula2";
        public static XName from = s + "from";
        public static XName futureMetadata = s + "futureMetadata";
        public static XName gradientFill = s + "gradientFill";
        public static XName group = s + "group";
        public static XName groupItems = s + "groupItems";
        public static XName groupLevel = s + "groupLevel";
        public static XName groupLevels = s + "groupLevels";
        public static XName groupMember = s + "groupMember";
        public static XName groupMembers = s + "groupMembers";
        public static XName groups = s + "groups";
        public static XName header = s + "header";
        public static XName headerFooter = s + "headerFooter";
        public static XName headers = s + "headers";
        public static XName horizontal = s + "horizontal";
        public static XName hyperlink = s + "hyperlink";
        public static XName hyperlinks = s + "hyperlinks";
        public static XName i = s + "i";
        public static XName iconFilter = s + "iconFilter";
        public static XName iconSet = s + "iconSet";
        public static XName ignoredError = s + "ignoredError";
        public static XName ignoredErrors = s + "ignoredErrors";
        public static XName indexedColors = s + "indexedColors";
        public static XName inputCells = s + "inputCells";
        public static XName _is = s + "is";
        public static XName item = s + "item";
        public static XName items = s + "items";
        public static XName k = s + "k";
        public static XName kpi = s + "kpi";
        public static XName kpis = s + "kpis";
        public static XName left = s + "left";
        public static XName legacyDrawing = s + "legacyDrawing";
        public static XName legacyDrawingHF = s + "legacyDrawingHF";
        public static XName location = s + "location";
        public static XName m = s + "m";
        public static XName main = s + "main";
        public static XName map = s + "map";
        public static XName maps = s + "maps";
        public static XName mdx = s + "mdx";
        public static XName mdxMetadata = s + "mdxMetadata";
        public static XName measureGroup = s + "measureGroup";
        public static XName measureGroups = s + "measureGroups";
        public static XName member = s + "member";
        public static XName members = s + "members";
        public static XName mergeCell = s + "mergeCell";
        public static XName mergeCells = s + "mergeCells";
        public static XName metadata = s + "metadata";
        public static XName metadataStrings = s + "metadataStrings";
        public static XName metadataType = s + "metadataType";
        public static XName metadataTypes = s + "metadataTypes";
        public static XName mp = s + "mp";
        public static XName mpMap = s + "mpMap";
        public static XName mps = s + "mps";
        public static XName mruColors = s + "mruColors";
        public static XName ms = s + "ms";
        public static XName n = s + "n";
        public static XName name = s + "name";
        public static XName nc = s + "nc";
        public static XName ndxf = s + "ndxf";
        public static XName numFmt = s + "numFmt";
        public static XName numFmts = s + "numFmts";
        public static XName objectPr = s + "objectPr";
        public static XName oc = s + "oc";
        public static XName oddFooter = s + "oddFooter";
        public static XName oddHeader = s + "oddHeader";
        public static XName odxf = s + "odxf";
        public static XName olapPr = s + "olapPr";
        public static XName oldFormula = s + "oldFormula";
        public static XName oleItem = s + "oleItem";
        public static XName oleItems = s + "oleItems";
        public static XName oleLink = s + "oleLink";
        public static XName oleObject = s + "oleObject";
        public static XName oleObjects = s + "oleObjects";
        public static XName outline = s + "outline";
        public static XName outlinePr = s + "outlinePr";
        public static XName p = s + "p";
        public static XName page = s + "page";
        public static XName pageField = s + "pageField";
        public static XName pageFields = s + "pageFields";
        public static XName pageItem = s + "pageItem";
        public static XName pageMargins = s + "pageMargins";
        public static XName pages = s + "pages";
        public static XName pageSetup = s + "pageSetup";
        public static XName pageSetUpPr = s + "pageSetUpPr";
        public static XName pane = s + "pane";
        public static XName parameter = s + "parameter";
        public static XName parameters = s + "parameters";
        public static XName patternFill = s + "patternFill";
        public static XName phoneticPr = s + "phoneticPr";
        public static XName picture = s + "picture";
        public static XName pivotArea = s + "pivotArea";
        public static XName pivotAreas = s + "pivotAreas";
        public static XName pivotCache = s + "pivotCache";
        public static XName pivotCacheDefinition = s + "pivotCacheDefinition";
        public static XName pivotCacheRecords = s + "pivotCacheRecords";
        public static XName pivotCaches = s + "pivotCaches";
        public static XName pivotField = s + "pivotField";
        public static XName pivotFields = s + "pivotFields";
        public static XName pivotHierarchies = s + "pivotHierarchies";
        public static XName pivotHierarchy = s + "pivotHierarchy";
        public static XName pivotSelection = s + "pivotSelection";
        public static XName pivotTableDefinition = s + "pivotTableDefinition";
        public static XName pivotTableStyleInfo = s + "pivotTableStyleInfo";
        public static XName printOptions = s + "printOptions";
        public static XName protectedRange = s + "protectedRange";
        public static XName protectedRanges = s + "protectedRanges";
        public static XName protection = s + "protection";
        public static XName query = s + "query";
        public static XName queryCache = s + "queryCache";
        public static XName queryTable = s + "queryTable";
        public static XName queryTableDeletedFields = s + "queryTableDeletedFields";
        public static XName queryTableField = s + "queryTableField";
        public static XName queryTableFields = s + "queryTableFields";
        public static XName queryTableRefresh = s + "queryTableRefresh";
        public static XName r = s + "r";
        public static XName raf = s + "raf";
        public static XName rangePr = s + "rangePr";
        public static XName rangeSet = s + "rangeSet";
        public static XName rangeSets = s + "rangeSets";
        public static XName rc = s + "rc";
        public static XName rcc = s + "rcc";
        public static XName rcft = s + "rcft";
        public static XName rcmt = s + "rcmt";
        public static XName rcv = s + "rcv";
        public static XName rdn = s + "rdn";
        public static XName reference = s + "reference";
        public static XName references = s + "references";
        public static XName reviewed = s + "reviewed";
        public static XName reviewedList = s + "reviewedList";
        public static XName revisions = s + "revisions";
        public static XName rfmt = s + "rfmt";
        public static XName rFont = s + "rFont";
        public static XName rgbColor = s + "rgbColor";
        public static XName right = s + "right";
        public static XName ris = s + "ris";
        public static XName rm = s + "rm";
        public static XName row = s + "row";
        public static XName rowBreaks = s + "rowBreaks";
        public static XName rowFields = s + "rowFields";
        public static XName rowHierarchiesUsage = s + "rowHierarchiesUsage";
        public static XName rowHierarchyUsage = s + "rowHierarchyUsage";
        public static XName rowItems = s + "rowItems";
        public static XName rPh = s + "rPh";
        public static XName rPr = s + "rPr";
        public static XName rqt = s + "rqt";
        public static XName rrc = s + "rrc";
        public static XName rsnm = s + "rsnm";
        public static XName _s = s + "s";
        public static XName scenario = s + "scenario";
        public static XName scenarios = s + "scenarios";
        public static XName scheme = s + "scheme";
        public static XName selection = s + "selection";
        public static XName serverFormat = s + "serverFormat";
        public static XName serverFormats = s + "serverFormats";
        public static XName set = s + "set";
        public static XName sets = s + "sets";
        public static XName shadow = s + "shadow";
        public static XName sharedItems = s + "sharedItems";
        public static XName sheet = s + "sheet";
        public static XName sheetCalcPr = s + "sheetCalcPr";
        public static XName sheetData = s + "sheetData";
        public static XName sheetDataSet = s + "sheetDataSet";
        public static XName sheetFormatPr = s + "sheetFormatPr";
        public static XName sheetId = s + "sheetId";
        public static XName sheetIdMap = s + "sheetIdMap";
        public static XName sheetName = s + "sheetName";
        public static XName sheetNames = s + "sheetNames";
        public static XName sheetPr = s + "sheetPr";
        public static XName sheetProtection = s + "sheetProtection";
        public static XName sheets = s + "sheets";
        public static XName sheetView = s + "sheetView";
        public static XName sheetViews = s + "sheetViews";
        public static XName si = s + "si";
        public static XName singleXmlCell = s + "singleXmlCell";
        public static XName singleXmlCells = s + "singleXmlCells";
        public static XName smartTags = s + "smartTags";
        public static XName sortByTuple = s + "sortByTuple";
        public static XName sortCondition = s + "sortCondition";
        public static XName sortState = s + "sortState";
        public static XName sst = s + "sst";
        public static XName stop = s + "stop";
        public static XName stp = s + "stp";
        public static XName strike = s + "strike";
        public static XName styleSheet = s + "styleSheet";
        public static XName sz = s + "sz";
        public static XName t = s + "t";
        public static XName tabColor = s + "tabColor";
        public static XName table = s + "table";
        public static XName tableColumn = s + "tableColumn";
        public static XName tableColumns = s + "tableColumns";
        public static XName tablePart = s + "tablePart";
        public static XName tableParts = s + "tableParts";
        public static XName tables = s + "tables";
        public static XName tableStyle = s + "tableStyle";
        public static XName tableStyleElement = s + "tableStyleElement";
        public static XName tableStyleInfo = s + "tableStyleInfo";
        public static XName tableStyles = s + "tableStyles";
        public static XName text = s + "text";
        public static XName textField = s + "textField";
        public static XName textFields = s + "textFields";
        public static XName textPr = s + "textPr";
        public static XName to = s + "to";
        public static XName top = s + "top";
        public static XName top10 = s + "top10";
        public static XName totalsRowFormula = s + "totalsRowFormula";
        public static XName tp = s + "tp";
        public static XName tpl = s + "tpl";
        public static XName tpls = s + "tpls";
        public static XName tr = s + "tr";
        public static XName tupleCache = s + "tupleCache";
        public static XName u = s + "u";
        public static XName undo = s + "undo";
        public static XName userInfo = s + "userInfo";
        public static XName users = s + "users";
        public static XName v = s + "v";
        public static XName val = s + "val";
        public static XName value = s + "value";
        public static XName valueMetadata = s + "valueMetadata";
        public static XName values = s + "values";
        public static XName vertAlign = s + "vertAlign";
        public static XName vertical = s + "vertical";
        public static XName volType = s + "volType";
        public static XName volTypes = s + "volTypes";
        public static XName webPr = s + "webPr";
        public static XName webPublishItem = s + "webPublishItem";
        public static XName webPublishItems = s + "webPublishItems";
        public static XName worksheet = s + "worksheet";
        public static XName worksheetEx14 = s + "worksheetEx14";
        public static XName worksheetSource = s + "worksheetSource";
        public static XName x = s + "x";
        public static XName xf = s + "xf";
        public static XName xmlCellPr = s + "xmlCellPr";
        public static XName xmlColumnPr = s + "xmlColumnPr";
        public static XName xmlPr = s + "xmlPr";
    }

    public static class SL
    {
        public static XNamespace sl =
            "http://schemas.openxmlformats.org/schemaLibrary/2006/main";
        public static XName manifestLocation = sl + "manifestLocation";
        public static XName schema = sl + "schema";
        public static XName schemaLibrary = sl + "schemaLibrary";
        public static XName uri = sl + "uri";
    }

    public static class SLE
    {
        public static XNamespace sle =
            "http://schemas.microsoft.com/office/drawing/2010/slicer";
        public static XName slicer = sle + "slicer";
    }

    public static class VML
    {
        public static XNamespace vml =
            "urn:schemas-microsoft-com:vml";
        public static XName arc = vml + "arc";
        public static XName background = vml + "background";
        public static XName curve = vml + "curve";
        public static XName ext = vml + "ext";
        public static XName f = vml + "f";
        public static XName fill = vml + "fill";
        public static XName formulas = vml + "formulas";
        public static XName group = vml + "group";
        public static XName h = vml + "h";
        public static XName handles = vml + "handles";
        public static XName image = vml + "image";
        public static XName imagedata = vml + "imagedata";
        public static XName line = vml + "line";
        public static XName oval = vml + "oval";
        public static XName path = vml + "path";
        public static XName polyline = vml + "polyline";
        public static XName rect = vml + "rect";
        public static XName roundrect = vml + "roundrect";
        public static XName shadow = vml + "shadow";
        public static XName shape = vml + "shape";
        public static XName shapetype = vml + "shapetype";
        public static XName stroke = vml + "stroke";
        public static XName textbox = vml + "textbox";
        public static XName textpath = vml + "textpath";
    }

    public static class VT
    {
        public static XNamespace vt =
            "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes";
        public static XName _bool = vt + "bool";
        public static XName filetime = vt + "filetime";
        public static XName i4 = vt + "i4";
        public static XName lpstr = vt + "lpstr";
        public static XName lpwstr = vt + "lpwstr";
        public static XName r8 = vt + "r8";
        public static XName variant = vt + "variant";
        public static XName vector = vt + "vector";
    }

    public static class W
    {
        public static XNamespace w =
            "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
        public static XName abstractNum = w + "abstractNum";
        public static XName abstractNumId = w + "abstractNumId";
        public static XName accent1 = w + "accent1";
        public static XName accent2 = w + "accent2";
        public static XName accent3 = w + "accent3";
        public static XName accent4 = w + "accent4";
        public static XName accent5 = w + "accent5";
        public static XName accent6 = w + "accent6";
        public static XName activeRecord = w + "activeRecord";
        public static XName activeWritingStyle = w + "activeWritingStyle";
        public static XName actualPg = w + "actualPg";
        public static XName addressFieldName = w + "addressFieldName";
        public static XName adjustLineHeightInTable = w + "adjustLineHeightInTable";
        public static XName adjustRightInd = w + "adjustRightInd";
        public static XName after = w + "after";
        public static XName afterAutospacing = w + "afterAutospacing";
        public static XName afterLines = w + "afterLines";
        public static XName algIdExt = w + "algIdExt";
        public static XName algIdExtSource = w + "algIdExtSource";
        public static XName alias = w + "alias";
        public static XName aliases = w + "aliases";
        public static XName alignBordersAndEdges = w + "alignBordersAndEdges";
        public static XName alignment = w + "alignment";
        public static XName alignTablesRowByRow = w + "alignTablesRowByRow";
        public static XName allowPNG = w + "allowPNG";
        public static XName allowSpaceOfSameStyleInTable = w + "allowSpaceOfSameStyleInTable";
        public static XName altChunk = w + "altChunk";
        public static XName altChunkPr = w + "altChunkPr";
        public static XName altName = w + "altName";
        public static XName alwaysMergeEmptyNamespace = w + "alwaysMergeEmptyNamespace";
        public static XName alwaysShowPlaceholderText = w + "alwaysShowPlaceholderText";
        public static XName anchor = w + "anchor";
        public static XName anchorLock = w + "anchorLock";
        public static XName annotationRef = w + "annotationRef";
        public static XName applyBreakingRules = w + "applyBreakingRules";
        public static XName appName = w + "appName";
        public static XName ascii = w + "ascii";
        public static XName asciiTheme = w + "asciiTheme";
        public static XName attachedSchema = w + "attachedSchema";
        public static XName attachedTemplate = w + "attachedTemplate";
        public static XName attr = w + "attr";
        public static XName author = w + "author";
        public static XName autofitToFirstFixedWidthCell = w + "autofitToFirstFixedWidthCell";
        public static XName autoFormatOverride = w + "autoFormatOverride";
        public static XName autoHyphenation = w + "autoHyphenation";
        public static XName autoRedefine = w + "autoRedefine";
        public static XName autoSpaceDE = w + "autoSpaceDE";
        public static XName autoSpaceDN = w + "autoSpaceDN";
        public static XName autoSpaceLikeWord95 = w + "autoSpaceLikeWord95";
        public static XName b = w + "b";
        public static XName background = w + "background";
        public static XName balanceSingleByteDoubleByteWidth = w + "balanceSingleByteDoubleByteWidth";
        public static XName bar = w + "bar";
        public static XName basedOn = w + "basedOn";
        public static XName bCs = w + "bCs";
        public static XName bdr = w + "bdr";
        public static XName before = w + "before";
        public static XName beforeAutospacing = w + "beforeAutospacing";
        public static XName beforeLines = w + "beforeLines";
        public static XName behavior = w + "behavior";
        public static XName behaviors = w + "behaviors";
        public static XName between = w + "between";
        public static XName bg1 = w + "bg1";
        public static XName bg2 = w + "bg2";
        public static XName bibliography = w + "bibliography";
        public static XName bidi = w + "bidi";
        public static XName bidiVisual = w + "bidiVisual";
        public static XName blockQuote = w + "blockQuote";
        public static XName body = w + "body";
        public static XName bodyDiv = w + "bodyDiv";
        public static XName bookFoldPrinting = w + "bookFoldPrinting";
        public static XName bookFoldPrintingSheets = w + "bookFoldPrintingSheets";
        public static XName bookFoldRevPrinting = w + "bookFoldRevPrinting";
        public static XName bookmarkEnd = w + "bookmarkEnd";
        public static XName bookmarkStart = w + "bookmarkStart";
        public static XName bordersDoNotSurroundFooter = w + "bordersDoNotSurroundFooter";
        public static XName bordersDoNotSurroundHeader = w + "bordersDoNotSurroundHeader";
        public static XName bottom = w + "bottom";
        public static XName bottomFromText = w + "bottomFromText";
        public static XName br = w + "br";
        public static XName cachedColBalance = w + "cachedColBalance";
        public static XName calcOnExit = w + "calcOnExit";
        public static XName calendar = w + "calendar";
        public static XName cantSplit = w + "cantSplit";
        public static XName caps = w + "caps";
        public static XName category = w + "category";
        public static XName cellDel = w + "cellDel";
        public static XName cellIns = w + "cellIns";
        public static XName cellMerge = w + "cellMerge";
        public static XName chapSep = w + "chapSep";
        public static XName chapStyle = w + "chapStyle";
        public static XName _char = w + "char";
        public static XName characterSpacingControl = w + "characterSpacingControl";
        public static XName charset = w + "charset";
        public static XName charSpace = w + "charSpace";
        public static XName checkBox = w + "checkBox";
        public static XName _checked = w + "checked";
        public static XName checkErrors = w + "checkErrors";
        public static XName checkStyle = w + "checkStyle";
        public static XName citation = w + "citation";
        public static XName clear = w + "clear";
        public static XName clickAndTypeStyle = w + "clickAndTypeStyle";
        public static XName clrSchemeMapping = w + "clrSchemeMapping";
        public static XName cnfStyle = w + "cnfStyle";
        public static XName code = w + "code";
        public static XName col = w + "col";
        public static XName colDelim = w + "colDelim";
        public static XName colFirst = w + "colFirst";
        public static XName colLast = w + "colLast";
        public static XName color = w + "color";
        public static XName cols = w + "cols";
        public static XName column = w + "column";
        public static XName combine = w + "combine";
        public static XName combineBrackets = w + "combineBrackets";
        public static XName comboBox = w + "comboBox";
        public static XName comment = w + "comment";
        public static XName commentRangeEnd = w + "commentRangeEnd";
        public static XName commentRangeStart = w + "commentRangeStart";
        public static XName commentReference = w + "commentReference";
        public static XName comments = w + "comments";
        public static XName compat = w + "compat";
        public static XName compatSetting = w + "compatSetting";
        public static XName connectString = w + "connectString";
        public static XName consecutiveHyphenLimit = w + "consecutiveHyphenLimit";
        public static XName contextualSpacing = w + "contextualSpacing";
        public static XName continuationSeparator = w + "continuationSeparator";
        public static XName control = w + "control";
        public static XName convMailMergeEsc = w + "convMailMergeEsc";
        public static XName count = w + "count";
        public static XName countBy = w + "countBy";
        public static XName cr = w + "cr";
        public static XName cryptAlgorithmClass = w + "cryptAlgorithmClass";
        public static XName cryptAlgorithmSid = w + "cryptAlgorithmSid";
        public static XName cryptAlgorithmType = w + "cryptAlgorithmType";
        public static XName cryptProvider = w + "cryptProvider";
        public static XName cryptProviderType = w + "cryptProviderType";
        public static XName cryptProviderTypeExt = w + "cryptProviderTypeExt";
        public static XName cryptProviderTypeExtSource = w + "cryptProviderTypeExtSource";
        public static XName cryptSpinCount = w + "cryptSpinCount";
        public static XName cs = w + "cs";
        public static XName csb0 = w + "csb0";
        public static XName csb1 = w + "csb1";
        public static XName cstheme = w + "cstheme";
        public static XName customMarkFollows = w + "customMarkFollows";
        public static XName customStyle = w + "customStyle";
        public static XName customXml = w + "customXml";
        public static XName customXmlDelRangeEnd = w + "customXmlDelRangeEnd";
        public static XName customXmlDelRangeStart = w + "customXmlDelRangeStart";
        public static XName customXmlInsRangeEnd = w + "customXmlInsRangeEnd";
        public static XName customXmlInsRangeStart = w + "customXmlInsRangeStart";
        public static XName customXmlMoveFromRangeEnd = w + "customXmlMoveFromRangeEnd";
        public static XName customXmlMoveFromRangeStart = w + "customXmlMoveFromRangeStart";
        public static XName customXmlMoveToRangeEnd = w + "customXmlMoveToRangeEnd";
        public static XName customXmlMoveToRangeStart = w + "customXmlMoveToRangeStart";
        public static XName customXmlPr = w + "customXmlPr";
        public static XName dataBinding = w + "dataBinding";
        public static XName dataSource = w + "dataSource";
        public static XName dataType = w + "dataType";
        public static XName date = w + "date";
        public static XName dateFormat = w + "dateFormat";
        public static XName dayLong = w + "dayLong";
        public static XName dayShort = w + "dayShort";
        public static XName ddList = w + "ddList";
        public static XName decimalSymbol = w + "decimalSymbol";
        public static XName _default = w + "default";
        public static XName defaultTableStyle = w + "defaultTableStyle";
        public static XName defaultTabStop = w + "defaultTabStop";
        public static XName defLockedState = w + "defLockedState";
        public static XName defQFormat = w + "defQFormat";
        public static XName defSemiHidden = w + "defSemiHidden";
        public static XName defUIPriority = w + "defUIPriority";
        public static XName defUnhideWhenUsed = w + "defUnhideWhenUsed";
        public static XName del = w + "del";
        public static XName delInstrText = w + "delInstrText";
        public static XName delText = w + "delText";
        public static XName description = w + "description";
        public static XName destination = w + "destination";
        public static XName dir = w + "dir";
        public static XName dirty = w + "dirty";
        public static XName displacedByCustomXml = w + "displacedByCustomXml";
        public static XName display = w + "display";
        public static XName displayBackgroundShape = w + "displayBackgroundShape";
        public static XName displayHangulFixedWidth = w + "displayHangulFixedWidth";
        public static XName displayHorizontalDrawingGridEvery = w + "displayHorizontalDrawingGridEvery";
        public static XName displayText = w + "displayText";
        public static XName displayVerticalDrawingGridEvery = w + "displayVerticalDrawingGridEvery";
        public static XName distance = w + "distance";
        public static XName div = w + "div";
        public static XName divBdr = w + "divBdr";
        public static XName divId = w + "divId";
        public static XName divs = w + "divs";
        public static XName divsChild = w + "divsChild";
        public static XName dllVersion = w + "dllVersion";
        public static XName docDefaults = w + "docDefaults";
        public static XName docGrid = w + "docGrid";
        public static XName docLocation = w + "docLocation";
        public static XName docPart = w + "docPart";
        public static XName docPartBody = w + "docPartBody";
        public static XName docPartCategory = w + "docPartCategory";
        public static XName docPartGallery = w + "docPartGallery";
        public static XName docPartList = w + "docPartList";
        public static XName docPartObj = w + "docPartObj";
        public static XName docPartPr = w + "docPartPr";
        public static XName docParts = w + "docParts";
        public static XName docPartUnique = w + "docPartUnique";
        public static XName document = w + "document";
        public static XName documentProtection = w + "documentProtection";
        public static XName documentType = w + "documentType";
        public static XName docVar = w + "docVar";
        public static XName docVars = w + "docVars";
        public static XName doNotAutoCompressPictures = w + "doNotAutoCompressPictures";
        public static XName doNotAutofitConstrainedTables = w + "doNotAutofitConstrainedTables";
        public static XName doNotBreakConstrainedForcedTable = w + "doNotBreakConstrainedForcedTable";
        public static XName doNotBreakWrappedTables = w + "doNotBreakWrappedTables";
        public static XName doNotDemarcateInvalidXml = w + "doNotDemarcateInvalidXml";
        public static XName doNotDisplayPageBoundaries = w + "doNotDisplayPageBoundaries";
        public static XName doNotEmbedSmartTags = w + "doNotEmbedSmartTags";
        public static XName doNotExpandShiftReturn = w + "doNotExpandShiftReturn";
        public static XName doNotHyphenateCaps = w + "doNotHyphenateCaps";
        public static XName doNotIncludeSubdocsInStats = w + "doNotIncludeSubdocsInStats";
        public static XName doNotLeaveBackslashAlone = w + "doNotLeaveBackslashAlone";
        public static XName doNotOrganizeInFolder = w + "doNotOrganizeInFolder";
        public static XName doNotRelyOnCSS = w + "doNotRelyOnCSS";
        public static XName doNotSaveAsSingleFile = w + "doNotSaveAsSingleFile";
        public static XName doNotShadeFormData = w + "doNotShadeFormData";
        public static XName doNotSnapToGridInCell = w + "doNotSnapToGridInCell";
        public static XName doNotSuppressBlankLines = w + "doNotSuppressBlankLines";
        public static XName doNotSuppressIndentation = w + "doNotSuppressIndentation";
        public static XName doNotSuppressParagraphBorders = w + "doNotSuppressParagraphBorders";
        public static XName doNotTrackFormatting = w + "doNotTrackFormatting";
        public static XName doNotTrackMoves = w + "doNotTrackMoves";
        public static XName doNotUseEastAsianBreakRules = w + "doNotUseEastAsianBreakRules";
        public static XName doNotUseHTMLParagraphAutoSpacing = w + "doNotUseHTMLParagraphAutoSpacing";
        public static XName doNotUseIndentAsNumberingTabStop = w + "doNotUseIndentAsNumberingTabStop";
        public static XName doNotUseLongFileNames = w + "doNotUseLongFileNames";
        public static XName doNotUseMarginsForDrawingGridOrigin = w + "doNotUseMarginsForDrawingGridOrigin";
        public static XName doNotValidateAgainstSchema = w + "doNotValidateAgainstSchema";
        public static XName doNotVertAlignCellWithSp = w + "doNotVertAlignCellWithSp";
        public static XName doNotVertAlignInTxbx = w + "doNotVertAlignInTxbx";
        public static XName doNotWrapTextWithPunct = w + "doNotWrapTextWithPunct";
        public static XName drawing = w + "drawing";
        public static XName drawingGridHorizontalOrigin = w + "drawingGridHorizontalOrigin";
        public static XName drawingGridHorizontalSpacing = w + "drawingGridHorizontalSpacing";
        public static XName drawingGridVerticalOrigin = w + "drawingGridVerticalOrigin";
        public static XName drawingGridVerticalSpacing = w + "drawingGridVerticalSpacing";
        public static XName dropCap = w + "dropCap";
        public static XName dropDownList = w + "dropDownList";
        public static XName dstrike = w + "dstrike";
        public static XName dxaOrig = w + "dxaOrig";
        public static XName dyaOrig = w + "dyaOrig";
        public static XName dynamicAddress = w + "dynamicAddress";
        public static XName eastAsia = w + "eastAsia";
        public static XName eastAsianLayout = w + "eastAsianLayout";
        public static XName eastAsiaTheme = w + "eastAsiaTheme";
        public static XName ed = w + "ed";
        public static XName edGrp = w + "edGrp";
        public static XName edit = w + "edit";
        public static XName effect = w + "effect";
        public static XName element = w + "element";
        public static XName em = w + "em";
        public static XName embedBold = w + "embedBold";
        public static XName embedBoldItalic = w + "embedBoldItalic";
        public static XName embedItalic = w + "embedItalic";
        public static XName embedRegular = w + "embedRegular";
        public static XName embedSystemFonts = w + "embedSystemFonts";
        public static XName embedTrueTypeFonts = w + "embedTrueTypeFonts";
        public static XName emboss = w + "emboss";
        public static XName enabled = w + "enabled";
        public static XName encoding = w + "encoding";
        public static XName endnote = w + "endnote";
        public static XName endnotePr = w + "endnotePr";
        public static XName endnoteRef = w + "endnoteRef";
        public static XName endnoteReference = w + "endnoteReference";
        public static XName endnotes = w + "endnotes";
        public static XName enforcement = w + "enforcement";
        public static XName entryMacro = w + "entryMacro";
        public static XName equalWidth = w + "equalWidth";
        public static XName equation = w + "equation";
        public static XName evenAndOddHeaders = w + "evenAndOddHeaders";
        public static XName exitMacro = w + "exitMacro";
        public static XName family = w + "family";
        public static XName ffData = w + "ffData";
        public static XName fHdr = w + "fHdr";
        public static XName fieldMapData = w + "fieldMapData";
        public static XName fill = w + "fill";
        public static XName first = w + "first";
        public static XName firstColumn = w + "firstColumn";
        public static XName firstLine = w + "firstLine";
        public static XName firstLineChars = w + "firstLineChars";
        public static XName firstRow = w + "firstRow";
        public static XName fitText = w + "fitText";
        public static XName flatBorders = w + "flatBorders";
        public static XName fldChar = w + "fldChar";
        public static XName fldCharType = w + "fldCharType";
        public static XName fldData = w + "fldData";
        public static XName fldLock = w + "fldLock";
        public static XName fldSimple = w + "fldSimple";
        public static XName fmt = w + "fmt";
        public static XName followedHyperlink = w + "followedHyperlink";
        public static XName font = w + "font";
        public static XName fontKey = w + "fontKey";
        public static XName fonts = w + "fonts";
        public static XName fontSz = w + "fontSz";
        public static XName footer = w + "footer";
        public static XName footerReference = w + "footerReference";
        public static XName footnote = w + "footnote";
        public static XName footnoteLayoutLikeWW8 = w + "footnoteLayoutLikeWW8";
        public static XName footnotePr = w + "footnotePr";
        public static XName footnoteRef = w + "footnoteRef";
        public static XName footnoteReference = w + "footnoteReference";
        public static XName footnotes = w + "footnotes";
        public static XName forceUpgrade = w + "forceUpgrade";
        public static XName forgetLastTabAlignment = w + "forgetLastTabAlignment";
        public static XName format = w + "format";
        public static XName formatting = w + "formatting";
        public static XName formProt = w + "formProt";
        public static XName formsDesign = w + "formsDesign";
        public static XName frame = w + "frame";
        public static XName frameLayout = w + "frameLayout";
        public static XName framePr = w + "framePr";
        public static XName frameset = w + "frameset";
        public static XName framesetSplitbar = w + "framesetSplitbar";
        public static XName ftr = w + "ftr";
        public static XName fullDate = w + "fullDate";
        public static XName gallery = w + "gallery";
        public static XName glossaryDocument = w + "glossaryDocument";
        public static XName grammar = w + "grammar";
        public static XName gridAfter = w + "gridAfter";
        public static XName gridBefore = w + "gridBefore";
        public static XName gridCol = w + "gridCol";
        public static XName gridSpan = w + "gridSpan";
        public static XName group = w + "group";
        public static XName growAutofit = w + "growAutofit";
        public static XName guid = w + "guid";
        public static XName gutter = w + "gutter";
        public static XName gutterAtTop = w + "gutterAtTop";
        public static XName h = w + "h";
        public static XName hAnchor = w + "hAnchor";
        public static XName hanging = w + "hanging";
        public static XName hangingChars = w + "hangingChars";
        public static XName hAnsi = w + "hAnsi";
        public static XName hAnsiTheme = w + "hAnsiTheme";
        public static XName hash = w + "hash";
        public static XName hdr = w + "hdr";
        public static XName hdrShapeDefaults = w + "hdrShapeDefaults";
        public static XName header = w + "header";
        public static XName headerReference = w + "headerReference";
        public static XName headerSource = w + "headerSource";
        public static XName helpText = w + "helpText";
        public static XName hidden = w + "hidden";
        public static XName hideGrammaticalErrors = w + "hideGrammaticalErrors";
        public static XName hideMark = w + "hideMark";
        public static XName hideSpellingErrors = w + "hideSpellingErrors";
        public static XName highlight = w + "highlight";
        public static XName hint = w + "hint";
        public static XName history = w + "history";
        public static XName hMerge = w + "hMerge";
        public static XName horzAnchor = w + "horzAnchor";
        public static XName hps = w + "hps";
        public static XName hpsBaseText = w + "hpsBaseText";
        public static XName hpsRaise = w + "hpsRaise";
        public static XName hRule = w + "hRule";
        public static XName hSpace = w + "hSpace";
        public static XName hyperlink = w + "hyperlink";
        public static XName hyphenationZone = w + "hyphenationZone";
        public static XName i = w + "i";
        public static XName iCs = w + "iCs";
        public static XName id = w + "id";
        public static XName ignoreMixedContent = w + "ignoreMixedContent";
        public static XName ilvl = w + "ilvl";
        public static XName imprint = w + "imprint";
        public static XName ind = w + "ind";
        public static XName initials = w + "initials";
        public static XName inkAnnotations = w + "inkAnnotations";
        public static XName ins = w + "ins";
        public static XName insDel = w + "insDel";
        public static XName insideH = w + "insideH";
        public static XName insideV = w + "insideV";
        public static XName instr = w + "instr";
        public static XName instrText = w + "instrText";
        public static XName isLgl = w + "isLgl";
        public static XName jc = w + "jc";
        public static XName keepLines = w + "keepLines";
        public static XName keepNext = w + "keepNext";
        public static XName kern = w + "kern";
        public static XName kinsoku = w + "kinsoku";
        public static XName lang = w + "lang";
        public static XName lastColumn = w + "lastColumn";
        public static XName lastRenderedPageBreak = w + "lastRenderedPageBreak";
        public static XName lastValue = w + "lastValue";
        public static XName lastRow = w + "lastRow";
        public static XName latentStyles = w + "latentStyles";
        public static XName layoutRawTableWidth = w + "layoutRawTableWidth";
        public static XName layoutTableRowsApart = w + "layoutTableRowsApart";
        public static XName leader = w + "leader";
        public static XName left = w + "left";
        public static XName leftChars = w + "leftChars";
        public static XName leftFromText = w + "leftFromText";
        public static XName legacy = w + "legacy";
        public static XName legacyIndent = w + "legacyIndent";
        public static XName legacySpace = w + "legacySpace";
        public static XName lid = w + "lid";
        public static XName line = w + "line";
        public static XName linePitch = w + "linePitch";
        public static XName lineRule = w + "lineRule";
        public static XName lines = w + "lines";
        public static XName lineWrapLikeWord6 = w + "lineWrapLikeWord6";
        public static XName link = w + "link";
        public static XName linkedToFile = w + "linkedToFile";
        public static XName linkStyles = w + "linkStyles";
        public static XName linkToQuery = w + "linkToQuery";
        public static XName listEntry = w + "listEntry";
        public static XName listItem = w + "listItem";
        public static XName listSeparator = w + "listSeparator";
        public static XName lnNumType = w + "lnNumType";
        public static XName _lock = w + "lock";
        public static XName locked = w + "locked";
        public static XName lsdException = w + "lsdException";
        public static XName lvl = w + "lvl";
        public static XName lvlJc = w + "lvlJc";
        public static XName lvlOverride = w + "lvlOverride";
        public static XName lvlPicBulletId = w + "lvlPicBulletId";
        public static XName lvlRestart = w + "lvlRestart";
        public static XName lvlText = w + "lvlText";
        public static XName mailAsAttachment = w + "mailAsAttachment";
        public static XName mailMerge = w + "mailMerge";
        public static XName mailSubject = w + "mailSubject";
        public static XName mainDocumentType = w + "mainDocumentType";
        public static XName mappedName = w + "mappedName";
        public static XName marBottom = w + "marBottom";
        public static XName marH = w + "marH";
        public static XName markup = w + "markup";
        public static XName marLeft = w + "marLeft";
        public static XName marRight = w + "marRight";
        public static XName marTop = w + "marTop";
        public static XName marW = w + "marW";
        public static XName matchSrc = w + "matchSrc";
        public static XName maxLength = w + "maxLength";
        public static XName mirrorIndents = w + "mirrorIndents";
        public static XName mirrorMargins = w + "mirrorMargins";
        public static XName monthLong = w + "monthLong";
        public static XName monthShort = w + "monthShort";
        public static XName moveFrom = w + "moveFrom";
        public static XName moveFromRangeEnd = w + "moveFromRangeEnd";
        public static XName moveFromRangeStart = w + "moveFromRangeStart";
        public static XName moveTo = w + "moveTo";
        public static XName moveToRangeEnd = w + "moveToRangeEnd";
        public static XName moveToRangeStart = w + "moveToRangeStart";
        public static XName multiLevelType = w + "multiLevelType";
        public static XName multiLine = w + "multiLine";
        public static XName mwSmallCaps = w + "mwSmallCaps";
        public static XName name = w + "name";
        public static XName namespaceuri = w + "namespaceuri";
        public static XName next = w + "next";
        public static XName nlCheck = w + "nlCheck";
        public static XName noBorder = w + "noBorder";
        public static XName noBreakHyphen = w + "noBreakHyphen";
        public static XName noColumnBalance = w + "noColumnBalance";
        public static XName noEndnote = w + "noEndnote";
        public static XName noExtraLineSpacing = w + "noExtraLineSpacing";
        public static XName noHBand = w + "noHBand";
        public static XName noLeading = w + "noLeading";
        public static XName noLineBreaksAfter = w + "noLineBreaksAfter";
        public static XName noLineBreaksBefore = w + "noLineBreaksBefore";
        public static XName noProof = w + "noProof";
        public static XName noPunctuationKerning = w + "noPunctuationKerning";
        public static XName noResizeAllowed = w + "noResizeAllowed";
        public static XName noSpaceRaiseLower = w + "noSpaceRaiseLower";
        public static XName noTabHangInd = w + "noTabHangInd";
        public static XName notTrueType = w + "notTrueType";
        public static XName noVBand = w + "noVBand";
        public static XName noWrap = w + "noWrap";
        public static XName nsid = w + "nsid";
        public static XName _null = w + "null";
        public static XName num = w + "num";
        public static XName numbering = w + "numbering";
        public static XName numberingChange = w + "numberingChange";
        public static XName numFmt = w + "numFmt";
        public static XName numId = w + "numId";
        public static XName numIdMacAtCleanup = w + "numIdMacAtCleanup";
        public static XName numPicBullet = w + "numPicBullet";
        public static XName numPicBulletId = w + "numPicBulletId";
        public static XName numPr = w + "numPr";
        public static XName numRestart = w + "numRestart";
        public static XName numStart = w + "numStart";
        public static XName numStyleLink = w + "numStyleLink";
        public static XName _object = w + "object";
        public static XName odso = w + "odso";
        public static XName offsetFrom = w + "offsetFrom";
        public static XName oMath = w + "oMath";
        public static XName optimizeForBrowser = w + "optimizeForBrowser";
        public static XName orient = w + "orient";
        public static XName original = w + "original";
        public static XName other = w + "other";
        public static XName outline = w + "outline";
        public static XName outlineLvl = w + "outlineLvl";
        public static XName overflowPunct = w + "overflowPunct";
        public static XName p = w + "p";
        public static XName pageBreakBefore = w + "pageBreakBefore";
        public static XName panose1 = w + "panose1";
        public static XName paperSrc = w + "paperSrc";
        public static XName pBdr = w + "pBdr";
        public static XName percent = w + "percent";
        public static XName permEnd = w + "permEnd";
        public static XName permStart = w + "permStart";
        public static XName personal = w + "personal";
        public static XName personalCompose = w + "personalCompose";
        public static XName personalReply = w + "personalReply";
        public static XName pgBorders = w + "pgBorders";
        public static XName pgMar = w + "pgMar";
        public static XName pgNum = w + "pgNum";
        public static XName pgNumType = w + "pgNumType";
        public static XName pgSz = w + "pgSz";
        public static XName pict = w + "pict";
        public static XName picture = w + "picture";
        public static XName pitch = w + "pitch";
        public static XName pixelsPerInch = w + "pixelsPerInch";
        public static XName placeholder = w + "placeholder";
        public static XName pos = w + "pos";
        public static XName position = w + "position";
        public static XName pPr = w + "pPr";
        public static XName pPrChange = w + "pPrChange";
        public static XName pPrDefault = w + "pPrDefault";
        public static XName prefixMappings = w + "prefixMappings";
        public static XName printBodyTextBeforeHeader = w + "printBodyTextBeforeHeader";
        public static XName printColBlack = w + "printColBlack";
        public static XName printerSettings = w + "printerSettings";
        public static XName printFormsData = w + "printFormsData";
        public static XName printFractionalCharacterWidth = w + "printFractionalCharacterWidth";
        public static XName printPostScriptOverText = w + "printPostScriptOverText";
        public static XName printTwoOnOne = w + "printTwoOnOne";
        public static XName proofErr = w + "proofErr";
        public static XName proofState = w + "proofState";
        public static XName pStyle = w + "pStyle";
        public static XName ptab = w + "ptab";
        public static XName qFormat = w + "qFormat";
        public static XName query = w + "query";
        public static XName r = w + "r";
        public static XName readModeInkLockDown = w + "readModeInkLockDown";
        public static XName recipientData = w + "recipientData";
        public static XName recommended = w + "recommended";
        public static XName relativeTo = w + "relativeTo";
        public static XName relyOnVML = w + "relyOnVML";
        public static XName removeDateAndTime = w + "removeDateAndTime";
        public static XName removePersonalInformation = w + "removePersonalInformation";
        public static XName restart = w + "restart";
        public static XName result = w + "result";
        public static XName revisionView = w + "revisionView";
        public static XName rFonts = w + "rFonts";
        public static XName richText = w + "richText";
        public static XName right = w + "right";
        public static XName rightChars = w + "rightChars";
        public static XName rightFromText = w + "rightFromText";
        public static XName rPr = w + "rPr";
        public static XName rPrChange = w + "rPrChange";
        public static XName rPrDefault = w + "rPrDefault";
        public static XName rsid = w + "rsid";
        public static XName rsidDel = w + "rsidDel";
        public static XName rsidP = w + "rsidP";
        public static XName rsidR = w + "rsidR";
        public static XName rsidRDefault = w + "rsidRDefault";
        public static XName rsidRoot = w + "rsidRoot";
        public static XName rsidRPr = w + "rsidRPr";
        public static XName rsids = w + "rsids";
        public static XName rsidSect = w + "rsidSect";
        public static XName rsidTr = w + "rsidTr";
        public static XName rStyle = w + "rStyle";
        public static XName rt = w + "rt";
        public static XName rtl = w + "rtl";
        public static XName rtlGutter = w + "rtlGutter";
        public static XName ruby = w + "ruby";
        public static XName rubyAlign = w + "rubyAlign";
        public static XName rubyBase = w + "rubyBase";
        public static XName rubyPr = w + "rubyPr";
        public static XName salt = w + "salt";
        public static XName saveFormsData = w + "saveFormsData";
        public static XName saveInvalidXml = w + "saveInvalidXml";
        public static XName savePreviewPicture = w + "savePreviewPicture";
        public static XName saveSmartTagsAsXml = w + "saveSmartTagsAsXml";
        public static XName saveSubsetFonts = w + "saveSubsetFonts";
        public static XName saveThroughXslt = w + "saveThroughXslt";
        public static XName saveXmlDataOnly = w + "saveXmlDataOnly";
        public static XName scrollbar = w + "scrollbar";
        public static XName sdt = w + "sdt";
        public static XName sdtContent = w + "sdtContent";
        public static XName sdtEndPr = w + "sdtEndPr";
        public static XName sdtPr = w + "sdtPr";
        public static XName sectPr = w + "sectPr";
        public static XName sectPrChange = w + "sectPrChange";
        public static XName selectFldWithFirstOrLastChar = w + "selectFldWithFirstOrLastChar";
        public static XName semiHidden = w + "semiHidden";
        public static XName sep = w + "sep";
        public static XName separator = w + "separator";
        public static XName settings = w + "settings";
        public static XName shadow = w + "shadow";
        public static XName shapeDefaults = w + "shapeDefaults";
        public static XName shapeid = w + "shapeid";
        public static XName shapeLayoutLikeWW8 = w + "shapeLayoutLikeWW8";
        public static XName shd = w + "shd";
        public static XName showBreaksInFrames = w + "showBreaksInFrames";
        public static XName showEnvelope = w + "showEnvelope";
        public static XName showingPlcHdr = w + "showingPlcHdr";
        public static XName showXMLTags = w + "showXMLTags";
        public static XName sig = w + "sig";
        public static XName size = w + "size";
        public static XName sizeAuto = w + "sizeAuto";
        public static XName smallCaps = w + "smallCaps";
        public static XName smartTag = w + "smartTag";
        public static XName smartTagPr = w + "smartTagPr";
        public static XName smartTagType = w + "smartTagType";
        public static XName snapToGrid = w + "snapToGrid";
        public static XName softHyphen = w + "softHyphen";
        public static XName solutionID = w + "solutionID";
        public static XName sourceFileName = w + "sourceFileName";
        public static XName space = w + "space";
        public static XName spaceForUL = w + "spaceForUL";
        public static XName spacing = w + "spacing";
        public static XName spacingInWholePoints = w + "spacingInWholePoints";
        public static XName specVanish = w + "specVanish";
        public static XName spelling = w + "spelling";
        public static XName splitPgBreakAndParaMark = w + "splitPgBreakAndParaMark";
        public static XName src = w + "src";
        public static XName start = w + "start";
        public static XName startOverride = w + "startOverride";
        public static XName statusText = w + "statusText";
        public static XName storeItemID = w + "storeItemID";
        public static XName storeMappedDataAs = w + "storeMappedDataAs";
        public static XName strictFirstAndLastChars = w + "strictFirstAndLastChars";
        public static XName strike = w + "strike";
        public static XName style = w + "style";
        public static XName styleId = w + "styleId";
        public static XName styleLink = w + "styleLink";
        public static XName styleLockQFSet = w + "styleLockQFSet";
        public static XName styleLockTheme = w + "styleLockTheme";
        public static XName stylePaneFormatFilter = w + "stylePaneFormatFilter";
        public static XName stylePaneSortMethod = w + "stylePaneSortMethod";
        public static XName styles = w + "styles";
        public static XName subDoc = w + "subDoc";
        public static XName subFontBySize = w + "subFontBySize";
        public static XName subsetted = w + "subsetted";
        public static XName suff = w + "suff";
        public static XName summaryLength = w + "summaryLength";
        public static XName suppressAutoHyphens = w + "suppressAutoHyphens";
        public static XName suppressBottomSpacing = w + "suppressBottomSpacing";
        public static XName suppressLineNumbers = w + "suppressLineNumbers";
        public static XName suppressOverlap = w + "suppressOverlap";
        public static XName suppressSpacingAtTopOfPage = w + "suppressSpacingAtTopOfPage";
        public static XName suppressSpBfAfterPgBrk = w + "suppressSpBfAfterPgBrk";
        public static XName suppressTopSpacing = w + "suppressTopSpacing";
        public static XName suppressTopSpacingWP = w + "suppressTopSpacingWP";
        public static XName swapBordersFacingPages = w + "swapBordersFacingPages";
        public static XName sym = w + "sym";
        public static XName sz = w + "sz";
        public static XName szCs = w + "szCs";
        public static XName t = w + "t";
        public static XName t1 = w + "t1";
        public static XName t2 = w + "t2";
        public static XName tab = w + "tab";
        public static XName table = w + "table";
        public static XName tabs = w + "tabs";
        public static XName tag = w + "tag";
        public static XName targetScreenSz = w + "targetScreenSz";
        public static XName tbl = w + "tbl";
        public static XName tblBorders = w + "tblBorders";
        public static XName tblCellMar = w + "tblCellMar";
        public static XName tblCellSpacing = w + "tblCellSpacing";
        public static XName tblGrid = w + "tblGrid";
        public static XName tblGridChange = w + "tblGridChange";
        public static XName tblHeader = w + "tblHeader";
        public static XName tblInd = w + "tblInd";
        public static XName tblLayout = w + "tblLayout";
        public static XName tblLook = w + "tblLook";
        public static XName tblOverlap = w + "tblOverlap";
        public static XName tblpPr = w + "tblpPr";
        public static XName tblPr = w + "tblPr";
        public static XName tblPrChange = w + "tblPrChange";
        public static XName tblPrEx = w + "tblPrEx";
        public static XName tblPrExChange = w + "tblPrExChange";
        public static XName tblpX = w + "tblpX";
        public static XName tblpXSpec = w + "tblpXSpec";
        public static XName tblpY = w + "tblpY";
        public static XName tblpYSpec = w + "tblpYSpec";
        public static XName tblStyle = w + "tblStyle";
        public static XName tblStyleColBandSize = w + "tblStyleColBandSize";
        public static XName tblStylePr = w + "tblStylePr";
        public static XName tblStyleRowBandSize = w + "tblStyleRowBandSize";
        public static XName tblW = w + "tblW";
        public static XName tc = w + "tc";
        public static XName tcBorders = w + "tcBorders";
        public static XName tcFitText = w + "tcFitText";
        public static XName tcMar = w + "tcMar";
        public static XName tcPr = w + "tcPr";
        public static XName tcPrChange = w + "tcPrChange";
        public static XName tcW = w + "tcW";
        public static XName temporary = w + "temporary";
        public static XName tentative = w + "tentative";
        public static XName text = w + "text";
        public static XName textAlignment = w + "textAlignment";
        public static XName textboxTightWrap = w + "textboxTightWrap";
        public static XName textDirection = w + "textDirection";
        public static XName textInput = w + "textInput";
        public static XName tgtFrame = w + "tgtFrame";
        public static XName themeColor = w + "themeColor";
        public static XName themeFill = w + "themeFill";
        public static XName themeFillShade = w + "themeFillShade";
        public static XName themeFillTint = w + "themeFillTint";
        public static XName themeFontLang = w + "themeFontLang";
        public static XName themeShade = w + "themeShade";
        public static XName themeTint = w + "themeTint";
        public static XName titlePg = w + "titlePg";
        public static XName tl2br = w + "tl2br";
        public static XName tmpl = w + "tmpl";
        public static XName tooltip = w + "tooltip";
        public static XName top = w + "top";
        public static XName topFromText = w + "topFromText";
        public static XName topLinePunct = w + "topLinePunct";
        public static XName tplc = w + "tplc";
        public static XName tr = w + "tr";
        public static XName tr2bl = w + "tr2bl";
        public static XName trackRevisions = w + "trackRevisions";
        public static XName trHeight = w + "trHeight";
        public static XName trPr = w + "trPr";
        public static XName trPrChange = w + "trPrChange";
        public static XName truncateFontHeightsLikeWP6 = w + "truncateFontHeightsLikeWP6";
        public static XName txbxContent = w + "txbxContent";
        public static XName type = w + "type";
        public static XName types = w + "types";
        public static XName u = w + "u";
        public static XName udl = w + "udl";
        public static XName uiCompat97To2003 = w + "uiCompat97To2003";
        public static XName uiPriority = w + "uiPriority";
        public static XName ulTrailSpace = w + "ulTrailSpace";
        public static XName underlineTabInNumList = w + "underlineTabInNumList";
        public static XName unhideWhenUsed = w + "unhideWhenUsed";
        public static XName updateFields = w + "updateFields";
        public static XName uri = w + "uri";
        public static XName url = w + "url";
        public static XName usb0 = w + "usb0";
        public static XName usb1 = w + "usb1";
        public static XName usb2 = w + "usb2";
        public static XName usb3 = w + "usb3";
        public static XName useAltKinsokuLineBreakRules = w + "useAltKinsokuLineBreakRules";
        public static XName useAnsiKerningPairs = w + "useAnsiKerningPairs";
        public static XName useFELayout = w + "useFELayout";
        public static XName useNormalStyleForList = w + "useNormalStyleForList";
        public static XName usePrinterMetrics = w + "usePrinterMetrics";
        public static XName useSingleBorderforContiguousCells = w + "useSingleBorderforContiguousCells";
        public static XName useWord2002TableStyleRules = w + "useWord2002TableStyleRules";
        public static XName useWord97LineBreakRules = w + "useWord97LineBreakRules";
        public static XName useXSLTWhenSaving = w + "useXSLTWhenSaving";
        public static XName val = w + "val";
        public static XName vAlign = w + "vAlign";
        public static XName value = w + "value";
        public static XName vAnchor = w + "vAnchor";
        public static XName vanish = w + "vanish";
        public static XName vendorID = w + "vendorID";
        public static XName vert = w + "vert";
        public static XName vertAlign = w + "vertAlign";
        public static XName vertAnchor = w + "vertAnchor";
        public static XName vertCompress = w + "vertCompress";
        public static XName view = w + "view";
        public static XName viewMergedData = w + "viewMergedData";
        public static XName vMerge = w + "vMerge";
        public static XName vMergeOrig = w + "vMergeOrig";
        public static XName vSpace = w + "vSpace";
        public static XName _w = w + "w";
        public static XName wAfter = w + "wAfter";
        public static XName wBefore = w + "wBefore";
        public static XName webHidden = w + "webHidden";
        public static XName webSettings = w + "webSettings";
        public static XName widowControl = w + "widowControl";
        public static XName wordWrap = w + "wordWrap";
        public static XName wpJustification = w + "wpJustification";
        public static XName wpSpaceWidth = w + "wpSpaceWidth";
        public static XName wrap = w + "wrap";
        public static XName wrapTrailSpaces = w + "wrapTrailSpaces";
        public static XName writeProtection = w + "writeProtection";
        public static XName x = w + "x";
        public static XName xAlign = w + "xAlign";
        public static XName xpath = w + "xpath";
        public static XName y = w + "y";
        public static XName yAlign = w + "yAlign";
        public static XName yearLong = w + "yearLong";
        public static XName yearShort = w + "yearShort";
        public static XName zoom = w + "zoom";
        public static XName zOrder = w + "zOrder";
        public static XName tblCaption = w + "tblCaption";
        public static XName tblDescription = w + "tblDescription";
        public static XName startChars = w + "startChars";
        public static XName end = w + "end";
        public static XName endChars = w + "endChars";
        public static XName evenHBand = w + "evenHBand";
        public static XName evenVBand = w + "evenVBand";
        public static XName firstRowFirstColumn = w + "firstRowFirstColumn";
        public static XName firstRowLastColumn = w + "firstRowLastColumn";
        public static XName lastRowFirstColumn = w + "lastRowFirstColumn";
        public static XName lastRowLastColumn = w + "lastRowLastColumn";
        public static XName oddHBand = w + "oddHBand";
        public static XName oddVBand = w + "oddVBand";
        public static XName headers = w + "headers";

        public static XName[] BlockLevelContentContainers =
        {
            W.body,
            W.tc,
            W.txbxContent,
            W.hdr,
            W.ftr,
            W.endnote,
            W.footnote
        };

        public static XName[] SubRunLevelContent =
        {
            W.br,
            W.cr,
            W.dayLong,
            W.dayShort,
            W.drawing,
            W.drawing,
            W.monthLong,
            W.monthShort,
            W.noBreakHyphen,
            W.ptab,
            W.pgNum,
            W.pict,
            W.softHyphen,
            W.sym,
            W.t,
            W.tab,
            W.yearLong,
            W.yearShort,
            MC.AlternateContent,
        };
    }

    public static class W10
    {
        public static XNamespace w10 =
            "urn:schemas-microsoft-com:office:word";
        public static XName anchorlock = w10 + "anchorlock";
        public static XName borderbottom = w10 + "borderbottom";
        public static XName borderleft = w10 + "borderleft";
        public static XName borderright = w10 + "borderright";
        public static XName bordertop = w10 + "bordertop";
        public static XName wrap = w10 + "wrap";
    }

    public static class W14
    {
        public static XNamespace w14 =
            "http://schemas.microsoft.com/office/word/2010/wordml";
        public static XName algn = w14 + "algn";
        public static XName alpha = w14 + "alpha";
        public static XName ang = w14 + "ang";
        public static XName b = w14 + "b";
        public static XName bevel = w14 + "bevel";
        public static XName bevelB = w14 + "bevelB";
        public static XName bevelT = w14 + "bevelT";
        public static XName blurRad = w14 + "blurRad";
        public static XName camera = w14 + "camera";
        public static XName cap = w14 + "cap";
        public static XName checkbox = w14 + "checkbox";
        public static XName _checked = w14 + "checked";
        public static XName checkedState = w14 + "checkedState";
        public static XName cmpd = w14 + "cmpd";
        public static XName cntxtAlts = w14 + "cntxtAlts";
        public static XName cNvContentPartPr = w14 + "cNvContentPartPr";
        public static XName conflictMode = w14 + "conflictMode";
        public static XName contentPart = w14 + "contentPart";
        public static XName contourClr = w14 + "contourClr";
        public static XName contourW = w14 + "contourW";
        public static XName defaultImageDpi = w14 + "defaultImageDpi";
        public static XName dir = w14 + "dir";
        public static XName discardImageEditingData = w14 + "discardImageEditingData";
        public static XName dist = w14 + "dist";
        public static XName docId = w14 + "docId";
        public static XName editId = w14 + "editId";
        public static XName enableOpenTypeKerning = w14 + "enableOpenTypeKerning";
        public static XName endA = w14 + "endA";
        public static XName endPos = w14 + "endPos";
        public static XName entityPicker = w14 + "entityPicker";
        public static XName extrusionClr = w14 + "extrusionClr";
        public static XName extrusionH = w14 + "extrusionH";
        public static XName fadeDir = w14 + "fadeDir";
        public static XName fillToRect = w14 + "fillToRect";
        public static XName font = w14 + "font";
        public static XName glow = w14 + "glow";
        public static XName gradFill = w14 + "gradFill";
        public static XName gs = w14 + "gs";
        public static XName gsLst = w14 + "gsLst";
        public static XName h = w14 + "h";
        public static XName hueMod = w14 + "hueMod";
        public static XName id = w14 + "id";
        public static XName kx = w14 + "kx";
        public static XName ky = w14 + "ky";
        public static XName l = w14 + "l";
        public static XName lat = w14 + "lat";
        public static XName ligatures = w14 + "ligatures";
        public static XName lightRig = w14 + "lightRig";
        public static XName lim = w14 + "lim";
        public static XName lin = w14 + "lin";
        public static XName lon = w14 + "lon";
        public static XName lumMod = w14 + "lumMod";
        public static XName lumOff = w14 + "lumOff";
        public static XName miter = w14 + "miter";
        public static XName noFill = w14 + "noFill";
        public static XName numForm = w14 + "numForm";
        public static XName numSpacing = w14 + "numSpacing";
        public static XName nvContentPartPr = w14 + "nvContentPartPr";
        public static XName paraId = w14 + "paraId";
        public static XName path = w14 + "path";
        public static XName pos = w14 + "pos";
        public static XName props3d = w14 + "props3d";
        public static XName prst = w14 + "prst";
        public static XName prstDash = w14 + "prstDash";
        public static XName prstMaterial = w14 + "prstMaterial";
        public static XName r = w14 + "r";
        public static XName rad = w14 + "rad";
        public static XName reflection = w14 + "reflection";
        public static XName rev = w14 + "rev";
        public static XName rig = w14 + "rig";
        public static XName rot = w14 + "rot";
        public static XName round = w14 + "round";
        public static XName sat = w14 + "sat";
        public static XName satMod = w14 + "satMod";
        public static XName satOff = w14 + "satOff";
        public static XName scaled = w14 + "scaled";
        public static XName scene3d = w14 + "scene3d";
        public static XName schemeClr = w14 + "schemeClr";
        public static XName shade = w14 + "shade";
        public static XName shadow = w14 + "shadow";
        public static XName solidFill = w14 + "solidFill";
        public static XName srgbClr = w14 + "srgbClr";
        public static XName stA = w14 + "stA";
        public static XName stPos = w14 + "stPos";
        public static XName styleSet = w14 + "styleSet";
        public static XName stylisticSets = w14 + "stylisticSets";
        public static XName sx = w14 + "sx";
        public static XName sy = w14 + "sy";
        public static XName t = w14 + "t";
        public static XName textFill = w14 + "textFill";
        public static XName textId = w14 + "textId";
        public static XName textOutline = w14 + "textOutline";
        public static XName tint = w14 + "tint";
        public static XName uncheckedState = w14 + "uncheckedState";
        public static XName val = w14 + "val";
        public static XName w = w14 + "w";
        public static XName wProps3d = w14 + "wProps3d";
        public static XName wScene3d = w14 + "wScene3d";
        public static XName wShadow = w14 + "wShadow";
        public static XName wTextFill = w14 + "wTextFill";
        public static XName wTextOutline = w14 + "wTextOutline";
        public static XName xfrm = w14 + "xfrm";
    }

    public static class W3DIGSIG
    {
        public static XNamespace w3digsig =
            "http://www.w3.org/2000/09/xmldsig#";
        public static XName CanonicalizationMethod = w3digsig + "CanonicalizationMethod";
        public static XName DigestMethod = w3digsig + "DigestMethod";
        public static XName DigestValue = w3digsig + "DigestValue";
        public static XName Exponent = w3digsig + "Exponent";
        public static XName KeyInfo = w3digsig + "KeyInfo";
        public static XName KeyValue = w3digsig + "KeyValue";
        public static XName Manifest = w3digsig + "Manifest";
        public static XName Modulus = w3digsig + "Modulus";
        public static XName Object = w3digsig + "Object";
        public static XName Reference = w3digsig + "Reference";
        public static XName RSAKeyValue = w3digsig + "RSAKeyValue";
        public static XName Signature = w3digsig + "Signature";
        public static XName SignatureMethod = w3digsig + "SignatureMethod";
        public static XName SignatureProperties = w3digsig + "SignatureProperties";
        public static XName SignatureProperty = w3digsig + "SignatureProperty";
        public static XName SignatureValue = w3digsig + "SignatureValue";
        public static XName SignedInfo = w3digsig + "SignedInfo";
        public static XName Transform = w3digsig + "Transform";
        public static XName Transforms = w3digsig + "Transforms";
        public static XName X509Certificate = w3digsig + "X509Certificate";
        public static XName X509Data = w3digsig + "X509Data";
        public static XName X509IssuerName = w3digsig + "X509IssuerName";
        public static XName X509SerialNumber = w3digsig + "X509SerialNumber";
    }

    public static class WP
    {
        public static XNamespace wp =
            "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing";
        public static XName align = wp + "align";
        public static XName anchor = wp + "anchor";
        public static XName cNvGraphicFramePr = wp + "cNvGraphicFramePr";
        public static XName docPr = wp + "docPr";
        public static XName effectExtent = wp + "effectExtent";
        public static XName extent = wp + "extent";
        public static XName inline = wp + "inline";
        public static XName lineTo = wp + "lineTo";
        public static XName positionH = wp + "positionH";
        public static XName positionV = wp + "positionV";
        public static XName posOffset = wp + "posOffset";
        public static XName simplePos = wp + "simplePos";
        public static XName start = wp + "start";
        public static XName wrapNone = wp + "wrapNone";
        public static XName wrapPolygon = wp + "wrapPolygon";
        public static XName wrapSquare = wp + "wrapSquare";
        public static XName wrapThrough = wp + "wrapThrough";
        public static XName wrapTight = wp + "wrapTight";
        public static XName wrapTopAndBottom = wp + "wrapTopAndBottom";
    }

    public static class WP14
    {
        public static XNamespace wp14 =
            "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing";
        public static XName editId = wp14 + "editId";
        public static XName pctHeight = wp14 + "pctHeight";
        public static XName pctPosVOffset = wp14 + "pctPosVOffset";
        public static XName pctWidth = wp14 + "pctWidth";
        public static XName sizeRelH = wp14 + "sizeRelH";
        public static XName sizeRelV = wp14 + "sizeRelV";
    }

    public static class WPS
    {
        public static XNamespace wps =
            "http://schemas.microsoft.com/office/word/2010/wordprocessingShape";
        public static XName altTxbx = wps + "altTxbx";
        public static XName bodyPr = wps + "bodyPr";
        public static XName cNvSpPr = wps + "cNvSpPr";
        public static XName spPr = wps + "spPr";
        public static XName style = wps + "style";
        public static XName textbox = wps + "textbox";
        public static XName txbx = wps + "txbx";
        public static XName wsp = wps + "wsp";
    }

    public static class X
    {
        public static XNamespace x =
            "urn:schemas-microsoft-com:office:excel";
        public static XName Anchor = x + "Anchor";
        public static XName AutoFill = x + "AutoFill";
        public static XName ClientData = x + "ClientData";
        public static XName Column = x + "Column";
        public static XName MoveWithCells = x + "MoveWithCells";
        public static XName Row = x + "Row";
        public static XName SizeWithCells = x + "SizeWithCells";
    }

    public static class XDR
    {
        public static XNamespace xdr =
            "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing";
        public static XName absoluteAnchor = xdr + "absoluteAnchor";
        public static XName blipFill = xdr + "blipFill";
        public static XName clientData = xdr + "clientData";
        public static XName cNvCxnSpPr = xdr + "cNvCxnSpPr";
        public static XName cNvGraphicFramePr = xdr + "cNvGraphicFramePr";
        public static XName cNvGrpSpPr = xdr + "cNvGrpSpPr";
        public static XName cNvPicPr = xdr + "cNvPicPr";
        public static XName cNvPr = xdr + "cNvPr";
        public static XName cNvSpPr = xdr + "cNvSpPr";
        public static XName col = xdr + "col";
        public static XName colOff = xdr + "colOff";
        public static XName contentPart = xdr + "contentPart";
        public static XName cxnSp = xdr + "cxnSp";
        public static XName ext = xdr + "ext";
        public static XName from = xdr + "from";
        public static XName graphicFrame = xdr + "graphicFrame";
        public static XName grpSp = xdr + "grpSp";
        public static XName grpSpPr = xdr + "grpSpPr";
        public static XName nvCxnSpPr = xdr + "nvCxnSpPr";
        public static XName nvGraphicFramePr = xdr + "nvGraphicFramePr";
        public static XName nvGrpSpPr = xdr + "nvGrpSpPr";
        public static XName nvPicPr = xdr + "nvPicPr";
        public static XName nvSpPr = xdr + "nvSpPr";
        public static XName oneCellAnchor = xdr + "oneCellAnchor";
        public static XName pic = xdr + "pic";
        public static XName pos = xdr + "pos";
        public static XName row = xdr + "row";
        public static XName rowOff = xdr + "rowOff";
        public static XName sp = xdr + "sp";
        public static XName spPr = xdr + "spPr";
        public static XName style = xdr + "style";
        public static XName to = xdr + "to";
        public static XName twoCellAnchor = xdr + "twoCellAnchor";
        public static XName txBody = xdr + "txBody";
        public static XName wsDr = xdr + "wsDr";
        public static XName xfrm = xdr + "xfrm";
    }

    public static class XDR14
    {
        public static XNamespace xdr14 =
            "http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing";
        public static XName cNvContentPartPr = xdr14 + "cNvContentPartPr";
        public static XName cNvPr = xdr14 + "cNvPr";
        public static XName nvContentPartPr = xdr14 + "nvContentPartPr";
        public static XName nvPr = xdr14 + "nvPr";
        public static XName xfrm = xdr14 + "xfrm";
    }

    public static class XM
    {
        public static XNamespace xm =
            "http://schemas.microsoft.com/office/excel/2006/main";
        public static XName f = xm + "f";
        public static XName _ref = xm + "ref";
        public static XName sqref = xm + "sqref";
    }

    public static class XSI
    {
        public static XNamespace xsi =
            "http://www.w3.org/2001/XMLSchema-instance";
        public static XName type = xsi + "type";
    }


    /************************************* end generated classes *************************************/

    public static class PtOpenXml
    {
        public static XNamespace ptOpenXml = "http://powertools.codeplex.com/documentbuilder/2011/insert";
        public static XName Insert = ptOpenXml + "Insert";
        public static XName Id = "Id";

        public static XNamespace pt = "http://powertools.codeplex.com/2011";
        public static XName Uri = pt + "Uri";

        public static XName trPr = pt + "trPr";
        public static XName tcPr = pt + "tcPr";
        public static XName rPr = pt + "rPr";
        public static XName pPr = pt + "pPr";
        public static XName tblPr = pt + "tblPr";
        public static XName style = pt + "style";

        public static XName FontName = pt + "FontName";
        public static XName LanguageType = pt + "LanguageType";
        public static XName AbstractNumId = pt + "AbstractNumId";
        public static XName StyleName = pt + "StyleName";
        public static XName TabWidth = pt + "TabWidth";
        public static XName Leader = pt + "Leader";
    }

    public class InvalidOpenXmlDocumentException : Exception
    {
        public InvalidOpenXmlDocumentException(string message) : base(message) { }
    }

    public class OpenXmlPowerToolsException : Exception
    {
        public OpenXmlPowerToolsException(string message) : base(message) { }
    }

    public class ColumnReferenceOutOfRange : Exception
    {
        public ColumnReferenceOutOfRange(string columnReference)
            : base(string.Format("Column reference ({0}) is out of range.", columnReference))
        {
        }
    }

    public class WorksheetAlreadyExistsException : Exception
    {
        public WorksheetAlreadyExistsException(string sheetName)
            : base(string.Format("The worksheet ({0}) already exists.", sheetName))
        {
        }
    }
}
