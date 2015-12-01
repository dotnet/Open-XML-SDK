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

Version: 2.6.00

***************************************************************************/

using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public partial class WmlDocument : OpenXmlPowerToolsDocument
    {
        public WmlDocument AddToc(string xPath, string switches, string title, int? rightTabPos)
        {
            return (WmlDocument)ReferenceAdder.AddToc(this, xPath, switches, title, rightTabPos);
        }
        public WmlDocument AddTof(string xPath, string switches, int? rightTabPos)
        {
            return (WmlDocument)ReferenceAdder.AddTof(this, xPath, switches, rightTabPos);
        }
        public WmlDocument AddToa(string xPath, string switches, int? rightTabPos)
        {
            return (WmlDocument)ReferenceAdder.AddToa(this, xPath, switches, rightTabPos);
        }
    }

    public class ReferenceAdder
    {
        public static WmlDocument AddToc(WmlDocument document, string xPath, string switches, string title, int? rightTabPos)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(document))
            {
                using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                {
                    AddToc(doc, xPath, switches, title, rightTabPos);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        public static void AddToc(WordprocessingDocument doc, string xPath, string switches, string title, int? rightTabPos)
        {
            UpdateFontTablePart(doc);
            UpdateStylesPartForToc(doc);
            UpdateStylesWithEffectsPartForToc(doc);

            if (title == null)
                title = "Contents";
            if (rightTabPos == null)
                rightTabPos = 9350;

            // {0} tocTitle (default = "Contents")
            // {1} rightTabPosition (default = 9350)
            // {2} switches

            String xmlString =
@"<w:sdt xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
  <w:sdtPr>
    <w:docPartObj>
      <w:docPartGallery w:val='Table of Contents'/>
      <w:docPartUnique/>
    </w:docPartObj>
  </w:sdtPr>
  <w:sdtEndPr>
    <w:rPr>
     <w:rFonts w:asciiTheme='minorHAnsi' w:cstheme='minorBidi' w:eastAsiaTheme='minorHAnsi' w:hAnsiTheme='minorHAnsi'/>
     <w:color w:val='auto'/>
     <w:sz w:val='22'/>
     <w:szCs w:val='22'/>
     <w:lang w:eastAsia='en-US'/>
    </w:rPr>
  </w:sdtEndPr>
  <w:sdtContent>
    <w:p>
      <w:pPr>
        <w:pStyle w:val='TOCHeading'/>
      </w:pPr>
      <w:r>
        <w:t>{0}</w:t>
      </w:r>
    </w:p>
    <w:p>
      <w:pPr>
        <w:pStyle w:val='TOC1'/>
        <w:tabs>
          <w:tab w:val='right' w:leader='dot' w:pos='{1}'/>
        </w:tabs>
        <w:rPr>
          <w:noProof/>
        </w:rPr>
      </w:pPr>
      <w:r>
        <w:fldChar w:fldCharType='begin' w:dirty='true'/>
      </w:r>
      <w:r>
        <w:instrText xml:space='preserve'> {2} </w:instrText>
      </w:r>
      <w:r>
        <w:fldChar w:fldCharType='separate'/>
      </w:r>
    </w:p>
    <w:p>
      <w:r>
        <w:rPr>
          <w:b/>
          <w:bCs/>
          <w:noProof/>
        </w:rPr>
        <w:fldChar w:fldCharType='end'/>
      </w:r>
    </w:p>
  </w:sdtContent>
</w:sdt>";

            XmlReader sdtReader = XmlReader.Create(new StringReader(String.Format(xmlString, title, rightTabPos, switches)));
            XElement sdt = XElement.Load(sdtReader);

            XmlNamespaceManager namespaceManager;
            XDocument mainXDoc = doc.MainDocumentPart.GetXDocument(out namespaceManager);
            namespaceManager.AddNamespace("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            XElement addBefore = mainXDoc.XPathSelectElement(xPath, namespaceManager);
            if (addBefore == null)
                throw new OpenXmlPowerToolsException("XPath expression did not select an element");

            addBefore.AddBeforeSelf(sdt);
            doc.MainDocumentPart.PutXDocument();

            XDocument settingsXDoc = doc.MainDocumentPart.DocumentSettingsPart.GetXDocument();
            XElement updateFields = settingsXDoc.Descendants(W.updateFields).FirstOrDefault();
            if (updateFields != null)
                updateFields.Attribute(W.val).Value = "true";
            else
            {
                updateFields = new XElement(W.updateFields,
                    new XAttribute(W.val, "true"));
                settingsXDoc.Root.Add(updateFields);
            }
            doc.MainDocumentPart.DocumentSettingsPart.PutXDocument();
        }

        public static WmlDocument AddTof(WmlDocument document, string xPath, string switches, int? rightTabPos)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(document))
            {
                using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                {
                    AddTof(doc, xPath, switches, rightTabPos);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        public static void AddTof(WordprocessingDocument doc, string xPath, string switches, int? rightTabPos)
        {
            UpdateFontTablePart(doc);
            UpdateStylesPartForTof(doc);
            UpdateStylesWithEffectsPartForTof(doc);

            if (rightTabPos == null)
                rightTabPos = 9350;

            // {0} rightTabPosition (default = 9350)
            // {1} switches

            string xmlString =
@"<w:p xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
  <w:pPr>
    <w:pStyle w:val='TableofFigures'/>
    <w:tabs>
      <w:tab w:val='right' w:leader='dot' w:pos='{0}'/>
    </w:tabs>
    <w:rPr>
      <w:noProof/>
    </w:rPr>
  </w:pPr>
  <w:r>
    <w:fldChar w:fldCharType='begin' dirty='true'/>
  </w:r>
  <w:r>
    <w:instrText xml:space='preserve'> {1} </w:instrText>
  </w:r>
  <w:r>
    <w:fldChar w:fldCharType='separate'/>
  </w:r>
  <w:r>
    <w:fldChar w:fldCharType='end'/>
  </w:r>
</w:p>";
            XDocument mainXDoc = doc.MainDocumentPart.GetXDocument();

            XmlReader paragraphReader = XmlReader.Create(new StringReader(String.Format(xmlString, rightTabPos, switches)));
            XElement paragraph = XElement.Load(paragraphReader);
            XmlNameTable nameTable = paragraphReader.NameTable;
            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(nameTable);
            namespaceManager.AddNamespace("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            XElement addBefore = mainXDoc.XPathSelectElement(xPath, namespaceManager);
            if (addBefore == null)
                throw new OpenXmlPowerToolsException("XPath expression did not select an element");

            addBefore.AddBeforeSelf(paragraph);
            doc.MainDocumentPart.PutXDocument();

            XDocument settingsXDoc = doc.MainDocumentPart.DocumentSettingsPart.GetXDocument();
            XElement updateFields = settingsXDoc.Descendants(W.updateFields).FirstOrDefault();
            if (updateFields != null)
                updateFields.Attribute(W.val).Value = "true";
            else
            {
                updateFields = new XElement(W.updateFields,
                    new XAttribute(W.val, "true"));
                settingsXDoc.Root.Add(updateFields);
            }
            doc.MainDocumentPart.DocumentSettingsPart.PutXDocument();
        }

        public static WmlDocument AddToa(WmlDocument document, string xPath, string switches, int? rightTabPos)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(document))
            {
                using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                {
                    AddToa(doc, xPath, switches, rightTabPos);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        public static void AddToa(WordprocessingDocument doc, string xPath, string switches, int? rightTabPos)
        {
            UpdateFontTablePart(doc);
            UpdateStylesPartForToa(doc);
            UpdateStylesWithEffectsPartForToa(doc);

            if (rightTabPos == null)
                rightTabPos = 9350;

            // {0} rightTabPosition (default = 9350)
            // {1} switches

            string xmlString =
@"<w:p xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
  <w:pPr>
    <w:pStyle w:val='TOAHeading'/>
    <w:tabs>
      <w:tab w:val='right'
             w:leader='dot'
             w:pos='{0}'/>
      </w:tabs>
    <w:rPr>
      <w:rFonts w:asciiTheme='minorHAnsi'
                w:eastAsiaTheme='minorEastAsia'
                w:hAnsiTheme='minorHAnsi'
                w:cstheme='minorBidi'/>
      <w:b w:val='0'/>
      <w:bCs w:val='0'/>
      <w:noProof/>
      <w:sz w:val='22'/>
      <w:szCs w:val='22'/>
    </w:rPr>
  </w:pPr>
  <w:r>
    <w:fldChar w:fldCharType='begin'/>
  </w:r>
  <w:r>
    <w:instrText xml:space='preserve'> {1} </w:instrText>
  </w:r>
  <w:r>
    <w:fldChar w:fldCharType='separate'/>
  </w:r>
  <w:r>
    <w:fldChar w:fldCharType='end'/>
  </w:r>
</w:p>";

            XDocument mainXDoc = doc.MainDocumentPart.GetXDocument();

            XmlReader paragraphReader = XmlReader.Create(new StringReader(String.Format(xmlString, rightTabPos, switches)));
            XElement paragraph = XElement.Load(paragraphReader);
            XmlNameTable nameTable = paragraphReader.NameTable;
            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(nameTable);
            namespaceManager.AddNamespace("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            XElement addBefore = mainXDoc.XPathSelectElement(xPath, namespaceManager);
            if (addBefore == null)
                throw new OpenXmlPowerToolsException("XPath expression did not select an element");

            addBefore.AddBeforeSelf(paragraph);
            doc.MainDocumentPart.PutXDocument();

            XDocument settingsXDoc = doc.MainDocumentPart.DocumentSettingsPart.GetXDocument();
            XElement updateFields = settingsXDoc.Descendants(W.updateFields).FirstOrDefault();
            if (updateFields != null)
                updateFields.Attribute(W.val).Value = "true";
            else
            {
                updateFields = new XElement(W.updateFields,
                    new XAttribute(W.val, "true"));
                settingsXDoc.Root.Add(updateFields);
            }
            doc.MainDocumentPart.DocumentSettingsPart.PutXDocument();
        }

        private static void AddElementIfMissing(XDocument partXDoc, XElement existing, string newElement)
        {
            if (existing != null)
                return;
            XElement newXElement = XElement.Parse(newElement);
            newXElement.Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
            partXDoc.Root.Add(newXElement);
        }

        private static void UpdateFontTablePart(WordprocessingDocument doc)
        {
            FontTablePart fontTablePart = doc.MainDocumentPart.FontTablePart;
            if (fontTablePart == null)
                throw new Exception("Todo need to insert font table part");
            XDocument fontTableXDoc = fontTablePart.GetXDocument();

            AddElementIfMissing(fontTableXDoc,
                fontTableXDoc
                    .Root
                    .Elements(W.font)
                    .Where(e => (string)e.Attribute(W.name) == "Tahoma")
                    .FirstOrDefault(),
                @"<w:font w:name='Tahoma' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                     <w:panose1 w:val='020B0604030504040204'/>
                     <w:charset w:val='00'/>
                     <w:family w:val='swiss'/>
                     <w:pitch w:val='variable'/>
                     <w:sig w:usb0='E1002EFF' w:usb1='C000605B' w:usb2='00000029' w:usb3='00000000' w:csb0='000101FF' w:csb1='00000000'/>
                   </w:font>");

            fontTablePart.PutXDocument();
        }

        private static void UpdatePartForToc(OpenXmlPart part)
        {
            XDocument xDoc = part.GetXDocument();

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TOCHeading")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph' w:styleId='TOCHeading' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='TOC Heading'/>
                    <w:basedOn w:val='Heading1'/>
                    <w:next w:val='Normal'/>
                    <w:uiPriority w:val='39'/>
                    <w:semiHidden/>
                    <w:unhideWhenUsed/>
                    <w:qFormat/>
                    <w:pPr>
                      <w:outlineLvl w:val='9'/>
                    </w:pPr>
                    <w:rPr>
                      <w:lang w:eastAsia='ja-JP'/>
                    </w:rPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TOC1")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph' w:styleId='TOC1' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='toc 1'/>
                    <w:basedOn w:val='Normal'/>
                    <w:next w:val='Normal'/>
                    <w:autoRedefine/>
                    <w:uiPriority w:val='39'/>
                    <w:unhideWhenUsed/>
                    <w:pPr>
                      <w:spacing w:after='100'/>
                    </w:pPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TOC2")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph' w:styleId='TOC2' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='toc 2'/>
                    <w:basedOn w:val='Normal'/>
                    <w:next w:val='Normal'/>
                    <w:autoRedefine/>
                    <w:uiPriority w:val='39'/>
                    <w:unhideWhenUsed/>
                    <w:pPr>
                      <w:spacing w:after='100'/>
                      <w:ind w:left='220'/>
                    </w:pPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TOC3")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph' w:styleId='TOC3' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='toc 3'/>
                    <w:basedOn w:val='Normal'/>
                    <w:next w:val='Normal'/>
                    <w:autoRedefine/>
                    <w:uiPriority w:val='39'/>
                    <w:unhideWhenUsed/>
                    <w:pPr>
                      <w:spacing w:after='100'/>
                      <w:ind w:left='440'/>
                    </w:pPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TOC4")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph' w:styleId='TOC4' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='toc 4'/>
                    <w:basedOn w:val='Normal'/>
                    <w:next w:val='Normal'/>
                    <w:autoRedefine/>
                    <w:uiPriority w:val='39'/>
                    <w:unhideWhenUsed/>
                    <w:pPr>
                      <w:spacing w:after='100'/>
                      <w:ind w:left='660'/>
                    </w:pPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "character" && (string)e.Attribute(W.styleId) == "Hyperlink")
                    .FirstOrDefault(),
                @"<w:style w:type='character' w:styleId='Hyperlink' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                     <w:name w:val='Hyperlink'/>
                     <w:basedOn w:val='DefaultParagraphFont'/>
                     <w:uiPriority w:val='99'/>
                     <w:unhideWhenUsed/>
                     <w:rPr>
                       <w:color w:val='0000FF' w:themeColor='hyperlink'/>
                       <w:u w:val='single'/>
                     </w:rPr>
                   </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "BalloonText")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph' w:styleId='BalloonText' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='Balloon Text'/>
                    <w:basedOn w:val='Normal'/>
                    <w:link w:val='BalloonTextChar'/>
                    <w:uiPriority w:val='99'/>
                    <w:semiHidden/>
                    <w:unhideWhenUsed/>
                    <w:pPr>
                      <w:spacing w:after='0' w:line='240' w:lineRule='auto'/>
                    </w:pPr>
                    <w:rPr>
                      <w:rFonts w:ascii='Tahoma' w:hAnsi='Tahoma' w:cs='Tahoma'/>
                      <w:sz w:val='16'/>
                      <w:szCs w:val='16'/>
                    </w:rPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "character" &&
                        (bool?)e.Attribute(W.customStyle) == true && (string)e.Attribute(W.styleId) == "BalloonTextChar")
                    .FirstOrDefault(),
                @"<w:style w:type='character' w:customStyle='1' w:styleId='BalloonTextChar' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='Balloon Text Char'/>
                    <w:basedOn w:val='DefaultParagraphFont'/>
                    <w:link w:val='BalloonText'/>
                    <w:uiPriority w:val='99'/>
                    <w:semiHidden/>
                    <w:rPr>
                      <w:rFonts w:ascii='Tahoma' w:hAnsi='Tahoma' w:cs='Tahoma'/>
                      <w:sz w:val='16'/>
                      <w:szCs w:val='16'/>
                    </w:rPr>
                  </w:style>");

            part.PutXDocument();
        }

        private static void UpdateStylesPartForToc(WordprocessingDocument doc)
        {
            StylesPart stylesPart = doc.MainDocumentPart.StyleDefinitionsPart;
            if (stylesPart == null)
                return;
            UpdatePartForToc(stylesPart);
        }

        private static void UpdateStylesWithEffectsPartForToc(WordprocessingDocument doc)
        {
            StylesWithEffectsPart stylesWithEffectsPart = doc.MainDocumentPart.StylesWithEffectsPart;
            if (stylesWithEffectsPart == null)
                return;
            UpdatePartForToc(stylesWithEffectsPart);
        }

        private static void UpdatePartForTof(OpenXmlPart part)
        {
            XDocument xDoc = part.GetXDocument();

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TableofFigures")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph' w:styleId='TableofFigures' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='table of figures'/>
                    <w:basedOn w:val='Normal'/>
                    <w:next w:val='Normal'/>
                    <w:uiPriority w:val='99'/>
                    <w:unhideWhenUsed/>
                    <w:pPr>
                      <w:spacing w:after='0'/>
                    </w:pPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "character" && (string)e.Attribute(W.styleId) == "Hyperlink")
                    .FirstOrDefault(),
                @"<w:style w:type='character' w:styleId='Hyperlink' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                     <w:name w:val='Hyperlink'/>
                     <w:basedOn w:val='DefaultParagraphFont'/>
                     <w:uiPriority w:val='99'/>
                     <w:unhideWhenUsed/>
                     <w:rPr>
                       <w:color w:val='0000FF' w:themeColor='hyperlink'/>
                       <w:u w:val='single'/>
                     </w:rPr>
                   </w:style>");
            part.PutXDocument();
        }

        private static void UpdateStylesPartForTof(WordprocessingDocument doc)
        {
            StylesPart stylesPart = doc.MainDocumentPart.StyleDefinitionsPart;
            if (stylesPart == null)
                return;
            UpdatePartForTof(stylesPart);
        }

        private static void UpdateStylesWithEffectsPartForTof(WordprocessingDocument doc)
        {
            StylesWithEffectsPart stylesWithEffectsPart = doc.MainDocumentPart.StylesWithEffectsPart;
            if (stylesWithEffectsPart == null)
                return;
            UpdatePartForTof(stylesWithEffectsPart);
        }

        private static void UpdatePartForToa(OpenXmlPart part)
        {
            XDocument xDoc = part.GetXDocument();

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TableofAuthorities")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph'
                           w:styleId='TableofAuthorities'
                           xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='table of authorities'/>
                    <w:basedOn w:val='Normal'/>
                    <w:next w:val='Normal'/>
                    <w:uiPriority w:val='99'/>
                    <w:semiHidden/>
                    <w:unhideWhenUsed/>
                    <w:rsid w:val='0090569D'/>
                    <w:pPr>
                      <w:spacing w:after='0'/>
                      <w:ind w:left='220'
                             w:hanging='220'/>
                    </w:pPr>
                  </w:style>");

            AddElementIfMissing(
                xDoc,
                xDoc.Root.Elements(W.style)
                    .Where(e => (string)e.Attribute(W.type) == "paragraph" && (string)e.Attribute(W.styleId) == "TOAHeading")
                    .FirstOrDefault(),
                @"<w:style w:type='paragraph'
                           w:styleId='TOAHeading'
                           xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main'>
                    <w:name w:val='toa heading'/>
                    <w:basedOn w:val='Normal'/>
                    <w:next w:val='Normal'/>
                    <w:uiPriority w:val='99'/>
                    <w:semiHidden/>
                    <w:unhideWhenUsed/>
                    <w:rsid w:val='0090569D'/>
                    <w:pPr>
                      <w:spacing w:before='120'/>
                    </w:pPr>
                    <w:rPr>
                      <w:rFonts w:asciiTheme='majorHAnsi'
                                w:eastAsiaTheme='majorEastAsia'
                                w:hAnsiTheme='majorHAnsi'
                                w:cstheme='majorBidi'/>
                      <w:b/>
                      <w:bCs/>
                      <w:sz w:val='24'/>
                      <w:szCs w:val='24'/>
                    </w:rPr>
                  </w:style>");

            part.PutXDocument();
        }

        private static void UpdateStylesPartForToa(WordprocessingDocument doc)
        {
            StylesPart stylesPart = doc.MainDocumentPart.StyleDefinitionsPart;
            if (stylesPart == null)
                return;
            UpdatePartForToa(stylesPart);
        }

        private static void UpdateStylesWithEffectsPartForToa(WordprocessingDocument doc)
        {
            StylesWithEffectsPart stylesWithEffectsPart = doc.MainDocumentPart.StylesWithEffectsPart;
            if (stylesWithEffectsPart == null)
                return;
            UpdatePartForToa(stylesWithEffectsPart);
        }
    }
}
