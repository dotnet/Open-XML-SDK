// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Linq;
using System.Xml.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    public class DocumentTraverseTest : OpenXmlDomTestBase
    {
        public DocumentTraverseTest(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <summary>
        /// Traversing up the specified Document Part using Parent, Ancestors(), and Ancestors&ltT&gt Methods
        /// </summary>
        /// <typeparam name="T">the PartRootElement</typeparam>
        /// <param name="part">the openXmlPart which the root element existed on</param>
        /// <param name="root">the loaded part root element to be traversed</param>
        private void TestTraverseUp<T>(OpenXmlPart part, OpenXmlElement root)
            where T : OpenXmlElement
        {
            string uTagName = (Activator.CreateInstance(typeof(T)) as OpenXmlElement).LocalName;

            Log.Comment("retrieve last child of the root element in XElement");
            XElement xroot = ConvertToXElement(part, root);

            Log.Comment("Check if the parent returns correctly");
            VerifyEqual(xroot.Parent, root.Parent, part);

            Log.Comment("check if Ancestors returns correctly");
            VerifyEqual(xroot.Ancestors(), root.Ancestors(), part);

            Log.Comment("Check if the Ancestors<T> returns correctly");
            Log.Comment("check if the Ancestors<OpenXmlElement> returns correctly");
            VerifyEqual(xroot.Ancestors(), root.Ancestors<OpenXmlElement>(), part);

            Log.Comment("check if the Ancestors<{0}> returns correctly", typeof(T).Name);
            VerifyEqual(xroot.Ancestors().Where(x => x.Name.LocalName == uTagName), root.Ancestors<T>(), part);
        }

        /// <summary>
        /// Traversing down the specified element using HasChildren, FirstChild, LastChild, ChildElements(), Descendants(), Elements()
        /// GetFirstChildOfType, and GetEnumerator methods
        /// </summary>
        /// <typeparam name="T">The specified child type need to be traversed</typeparam>
        /// <param name="part">the OpenXmlPart in which the element exists</param>
        /// <param name="root">the OpenXmlElement need to be traversed</param>
        private void TestTraverseDown<T>(OpenXmlPart part, OpenXmlElement root)
            where T : OpenXmlElement
        {
            string uTagName = (Activator.CreateInstance(typeof(T)) as OpenXmlElement).LocalName;
            XElement xroot = ConvertToXElement(part, root);

            Log.Comment(" ****** test HasChildren ******");
            Log.Comment("check if the hasChildren is correct");
            Log.VerifyTrue(xroot.HasElements == root.HasChildren, "hasChildren is not correct");

            if (root.HasChildren)
            {
                OpenXmlElement firstChild = root.FirstChild;
                XElement xfirstChild = xroot.Elements().ElementAt(0);

                Log.Comment(" ****** test FirstChild ******");
                Log.Comment("check if the first child retrieved is correct");
                VerifyEqual(xfirstChild, ConvertToXElement(part, firstChild), null);

                Log.Comment(" ****** test LastChild ******");
                Log.Comment("check if the last child retrieved is correct");
                VerifyEqual(xroot.Elements().Last(), ConvertToXElement(part, root.LastChild), null);

                Log.Comment(" ****** test ChildElements ******");
                Log.Comment("check if the children is returned correct");
                VerifyEqual(xroot.Elements(), root.ChildElements, part);

                Log.Comment(" ****** test Descendants ******");
                Log.Comment("check if the descendants if the first child returned are correct");
                VerifyEqual(xroot.Descendants(), root.Descendants(), part);

                Log.Comment(" ******test Elements<T> ******");
                Log.Comment("check if the Element<OpenXmlElement> returned are correct");
                VerifyEqual(xroot.Elements(), root.Elements<OpenXmlElement>(), part);

                Log.Comment("check if the Element<{0}> returned are correct", typeof(T).Name);
                VerifyEqual(xroot.Elements().Where(x => x.Name.LocalName == uTagName), root.Elements<T>(), part);

                Log.Comment(" ****** test Descendants<T> ******");
                Log.Comment("check if the Descendants<OpenXmlElement> of the first child are returned correctly");
                VerifyEqual(xroot.Descendants(), root.Descendants<OpenXmlElement>(), part);

                Log.Comment("check if the Descendants<{0}> returned are correct", typeof(T).Name);
                VerifyEqual(xroot.Descendants().Where(x => x.Name.LocalName == uTagName), root.Descendants<T>(), part);

                Log.Comment(" ****** test GetFirstChildOfType<T> ******");
                Log.Comment("check if the GetFirstChild<OpenXmlElement> returns the first child element");
                VerifyEqual(xroot.Elements().First(), ConvertToXElement(part, root.GetFirstChild<OpenXmlElement>()), null);

                Log.Comment("check if the GetFirstChild<{0}> returns the correct result", typeof(T).Name);
                VerifyEqual(xroot.Elements().Where(x => x.Name.LocalName == uTagName).First(), ConvertToXElement(part, root.GetFirstChild<T>()), null);

                Log.Comment(" ****** test GetEnumerator() ******");
                Log.Comment("check if the GetEnumerator returns the correct result");
                VerifyEqual(xroot.Elements(), root, part);

                Log.Comment("***** test IsBefore() ******");
                foreach (var element in root.Descendants())
                {
                    if (root.FirstChild == element)
                    {
                        Log.VerifyFalse(root.FirstChild.IsBefore(element), "Expect: False <> Actual: True");
                        Log.VerifyFalse(root.FirstChild.IsAfter(element), "Expect: False <> Actual: True");
                    }
                    else
                    {
                        Log.VerifyTrue(root.FirstChild.IsBefore(element), "Expect: True <> Actual: False");
                        Log.VerifyFalse(root.FirstChild.IsAfter(element), "Expect: False <> Actual: True");
                    }
                }

                Log.Comment("****** test IsAfter() ******");
                foreach (var element in root.Elements())
                {
                    if (element == root.LastChild)
                    {
                        Log.VerifyFalse(root.LastChild.IsAfter(element), "Expect: False <> Actual: True");
                        Log.VerifyFalse(root.LastChild.IsBefore(element), "Expect: False <> Actual: True");
                    }
                    else
                    {
                        Log.VerifyTrue(root.LastChild.IsAfter(element), "Expect: True <> Actual: False");
                        Log.VerifyFalse(root.LastChild.IsBefore(element), "Expect: False <> Actual: True");
                    }
                }
            }
            else
            {
                Log.Warning("No Children exists");
            }
        }

        /// <summary>
        /// Traversing siblings of the specified element using PreviousSibling, PreviousSibling &lt T &gt
        /// NextSibling, NextSibling&ltT&gt, ElementsBefore, ElementsAfter, IsBefore, IsAfter"/>
        /// </summary>
        /// <typeparam name="T">Type of the sibling used by generic traversing method</typeparam>
        /// <param name="part">the OpenXmlPart in which the element exists</param>
        /// <param name="element">the OpenXmlElement need to be traversed</param>
        private void TestTraverseSibling<T>(OpenXmlPart part, OpenXmlElement element)
            where T : OpenXmlElement
        {
            string uTagName = (Activator.CreateInstance(typeof(T)) as OpenXmlElement).LocalName;

            OpenXmlElement walker = element;
            XElement xele = ConvertToXElement(part, element);
            XElement xwalker = xele;

            Log.Comment("****** test ElementsAfter ******");
            VerifyEqual(xwalker.ElementsAfterSelf(), walker.ElementsAfter(), part);

            Log.Comment("****** test NextSibling ******");
            Log.Comment("check if the nextSibling returns correctly");

            while (xwalker.NextNode is not null && walker.NextSibling() is not null)
            {
                xwalker = xwalker.ElementsAfterSelf().First();
                walker = walker.NextSibling();

                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.NextNode is null && walker.NextSibling() is null)
            {
                Log.Comment("check if the current element is the last sibling of the original element");
                VerifyEqual(xele.Parent.Elements().Last(), walker, part);

                Log.Pass("All next siblings have been retrieved correctly");
            }
            else
            {
                Log.Fail("nextSibling doesn't return correctly");
            }

            Log.Comment("****** test ElementsBefore ******");
            VerifyEqual(xwalker.ElementsBeforeSelf(), walker.ElementsBefore(), part);

            Log.Comment("****** test PreviousSibling ******");
            while (xwalker.PreviousNode is not null && walker.PreviousSibling() is not null)
            {
                xwalker = xwalker.ElementsBeforeSelf().Last();
                walker = walker.PreviousSibling();
                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.PreviousNode is null && walker.PreviousSibling() is null)
            {
                Log.Comment("check if the current element is the first sibling of the original element");
                VerifyEqual(xele.Parent.Elements().First(), walker, part);

                Log.Pass("All Previous siblings have been retrieved correctly");
            }
            else
            {
                Log.Fail("PreviousSibling doesn't return correctly");
            }

            Log.Comment("****** test NextSibling<OpenXmlElement> ******");

            while (xwalker.NextNode is not null && walker.NextSibling() is not null)
            {
                xwalker = xwalker.ElementsAfterSelf().First();
                walker = walker.NextSibling<OpenXmlElement>();

                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.NextNode is null && walker.NextSibling() is null)
            {
                Log.Comment("check if the current element is the last sibling of the original element");
                VerifyEqual(xele.Parent.Elements().Last(), walker, part);

                Log.Pass("All next siblings have been retrieved correctly");
            }
            else
            {
                Log.Fail("nextSibling doesn't return correctly");
            }

            Log.Comment("****** test PreviousSibling<OpenXmlElement>() ******");
            while (xwalker.PreviousNode is not null && walker.PreviousSibling<OpenXmlElement>() is not null)
            {
                xwalker = xwalker.ElementsBeforeSelf().Last();
                walker = walker.PreviousSibling<OpenXmlElement>();
                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.PreviousNode is null && walker.PreviousSibling<OpenXmlElement>() is null)
            {
                Log.Comment("check if the current element is the first sibling of the original element");
                VerifyEqual(xele.Parent.Elements().First(), walker, part);

                Log.Pass("All Previous siblings have been retrieved correctly");
            }
            else
            {
                Log.Fail("PreviousSibling doesn't return correctly");
            }

            Log.Comment("****** test NextSibling<{0}> ******", typeof(T).Name);
            while (xwalker.ElementsAfterSelf().Where(x => x.Name.LocalName == uTagName).Any() && walker.NextSibling<T>() is not null)
            {
                xwalker = xwalker.ElementsAfterSelf().Where(x => x.Name.LocalName == uTagName).First();
                walker = walker.NextSibling<T>();

                VerifyEqual(xwalker, walker, part);
            }

            Log.Comment("****** test PreviousSibling<{0}>() ******", typeof(T).Name);
            while (xwalker.ElementsBeforeSelf().Where(x => x.Name.LocalName == uTagName).Any() && walker.PreviousSibling<T>() is not null)
            {
                xwalker = xwalker.ElementsBeforeSelf().Where(x => x.Name.LocalName == uTagName).Last();
                walker = walker.PreviousSibling<T>();
                VerifyEqual(xwalker, walker, part);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AutoSpaceDE)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.Empty)]
        public void TraverseWordDocument(string path)
        {
            // description = " Case ID: 75567, 75568, 75505, 75506, 76083, 76084";
            using (var file = TestAssets.GetStream(path))
            using (var doc = WordprocessingDocument.Open(file, false))
            {
                Log.Comment("<<<<<<<<<<<<< Traverse MainDocumentPart >>>>>>>>>>>>");

                Log.Comment("<<<<<<<<<<<< Traverse Down >>>>>>>>>>>>>>");
                Log.Comment("      <<<<<< traversing Body >>>>>>");
                Body body = doc.MainDocumentPart.Document.GetFirstChild<Body>();
                TestTraverseDown<Paragraph>(doc.MainDocumentPart, body);

                Log.Comment("      <<<<<< traversing Paragraph >>>>>>");
                TestTraverseDown<DocumentFormat.OpenXml.Wordprocessing.Run>(doc.MainDocumentPart, body.GetFirstChild<Paragraph>());

                Log.Comment("<<<<<<<<<<<< Traverse Up >>>>>>>>>>>>>>");
                TestTraverseUp<Paragraph>(doc.MainDocumentPart, body.LastChild);

                Log.Comment("<<<<<<<<<<<< Traverse Sibling >>>>>>>>>>>");
                TestTraverseSibling<Paragraph>(doc.MainDocumentPart, body.FirstChild);

                Log.Comment("<<<<<<<<<<<<< Traverse Non-MainDocumentPart >>>>>>>>>>>>");

                Log.Comment("<<<<<<<<<<<< Traverse Down >>>>>>>>>>>>>>");
                TestTraverseDown<Style>(doc.MainDocumentPart.StyleDefinitionsPart, doc.MainDocumentPart.StyleDefinitionsPart.Styles);

                Log.Comment("<<<<<<<<<<<< Traverse Up >>>>>>>>>>>>>>");
                TestTraverseUp<Style>(doc.MainDocumentPart.StyleDefinitionsPart, doc.MainDocumentPart.StyleDefinitionsPart.Styles.LastChild);

                Log.Comment("<<<<<<<<<<<< Traverse Sibling >>>>>>>>>>>");
                TestTraverseSibling<Style>(doc.MainDocumentPart.StyleDefinitionsPart, doc.MainDocumentPart.StyleDefinitionsPart.Styles.FirstChild);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SharedWorkbook)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SheetData)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SheetViewsFSB)]
        public void TraverseSpreadSheetDocument(string path)
        {
            using (var file = TestAssets.GetStream(path))
            using (var excel = SpreadsheetDocument.Open(file, false))
            {
                Log.Comment("<<<<<<<<<<<<< Traverse WorkBookPart >>>>>>>>>>>>");
                Log.Comment("   <<<<<<< Traverse Down >>>>>>>>");
                Log.Comment(" <<<<<< traversing WorkBook >>>>>>");
                TestTraverseDown<Sheets>(excel.WorkbookPart, excel.WorkbookPart.Workbook);

                Log.Comment(" <<<<<< traversing Sheets >>>>>>");
                TestTraverseDown<Sheet>(excel.WorkbookPart, excel.WorkbookPart.Workbook.GetFirstChild<Sheets>());

                Log.Comment("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<Sheets>(excel.WorkbookPart, excel.WorkbookPart.Workbook.LastChild);

                Log.Comment("  <<<<<< Traverse Sibling  >>>>>>");
                TestTraverseSibling<Sheets>(excel.WorkbookPart, excel.WorkbookPart.Workbook.FirstChild);

                Log.Comment("<<<<<<<<<<<<< Traverse Non-WorkBookPart >>>>>>>>>>>>");
                Log.Comment("   <<<<<<< Traverse Down >>>>>>>>");
                Log.Comment(" <<<<<< traversing WorkSheet >>>>>>");
                TestTraverseDown<SheetData>(excel.WorkbookPart.WorksheetParts.First(), excel.WorkbookPart.WorksheetParts.First().Worksheet);

                Log.Comment(" <<<<<< traversing SheetData >>>>>>");
                TestTraverseDown<Row>(excel.WorkbookPart.WorksheetParts.First(), excel.WorkbookPart.WorksheetParts.First().Worksheet.GetFirstChild<SheetData>());

                Log.Comment("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<SheetData>(excel.WorkbookPart.WorksheetParts.First(), excel.WorkbookPart.WorksheetParts.First().Worksheet.LastChild);

                Log.Comment("  <<<<<< Traverse Sibling  >>>>>>");
                TestTraverseSibling<Sheets>(excel.WorkbookPart.WorksheetParts.First(), excel.WorkbookPart.WorksheetParts.First().Worksheet.FirstChild);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInbyletterpptx)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charspptx)]
        public void TraversePPTDocument(string path)
        {
            using (var file = TestAssets.GetStream(path))
            using (var ppt = PresentationDocument.Open(file, false))
            {
                Log.Comment("<<<<<<<<<<<<< Traverse PresentationPart >>>>>>>>>>>>");
                Log.Comment("   <<<<<<< Traverse Down >>>>>>>>");
                Log.Comment(" <<<<<< traversing Presentation >>>>>>");
                TestTraverseDown<SlideIdList>(ppt.PresentationPart, ppt.PresentationPart.Presentation);

                Log.Comment(" <<<<<< traversing SlideIdList >>>>>>");
                TestTraverseDown<SlideId>(ppt.PresentationPart, ppt.PresentationPart.Presentation.GetFirstChild<SlideIdList>());

                Log.Comment("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<SlideIdList>(ppt.PresentationPart, ppt.PresentationPart.Presentation.LastChild);

                Log.Comment("  <<<<<< Traverse Sibling  >>>>>>");
                TestTraverseSibling<SlideIdList>(ppt.PresentationPart, ppt.PresentationPart.Presentation.FirstChild);

                Log.Comment("<<<<<<<<<<<<< Traverse Non-PresentationPart >>>>>>>>>>>>");
                Log.Comment("   <<<<<<< Traverse Down >>>>>>>>");
                Log.Comment(" <<<<<< traversing Slide  >>>>>>");
                TestTraverseDown<CommonSlideData>(ppt.PresentationPart.SlideParts.First(), ppt.PresentationPart.SlideParts.First().Slide);

                Log.Comment("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<CommonSlideData>(ppt.PresentationPart.SlideParts.First(), ppt.PresentationPart.SlideParts.First().Slide.LastChild);

                Log.Comment("  <<<<<< Traverse Sibling  >>>>>>");
                TestTraverseSibling<CommonSlideData>(ppt.PresentationPart.SlideParts.First(), ppt.PresentationPart.SlideParts.First().Slide.FirstChild);
            }
        }
    }
}
