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

            Output.WriteLine("retrieve last child of the root element in XElement");
            XElement xroot = ConvertToXElement(part, root);

            Output.WriteLine("Check if the parent returns correctly");
            VerifyEqual(xroot.Parent, root.Parent, part);

            Output.WriteLine("check if Ancestors returns correctly");
            VerifyEqual(xroot.Ancestors(), root.Ancestors(), part);

            Output.WriteLine("Check if the Ancestors<T> returns correctly");
            Output.WriteLine("check if the Ancestors<OpenXmlElement> returns correctly");
            VerifyEqual(xroot.Ancestors(), root.Ancestors<OpenXmlElement>(), part);

            Output.WriteLine("check if the Ancestors<{0}> returns correctly", typeof(T).Name);
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

            Output.WriteLine(" ****** test HasChildren ******");
            Output.WriteLine("check if the hasChildren is correct");
            Assert.Equal(xroot.HasElements, root.HasChildren);

            if (root.HasChildren)
            {
                OpenXmlElement firstChild = root.FirstChild;
                XElement xfirstChild = xroot.Elements().ElementAt(0);

                Output.WriteLine(" ****** test FirstChild ******");
                Output.WriteLine("check if the first child retrieved is correct");
                VerifyEqual(xfirstChild, ConvertToXElement(part, firstChild), null);

                Output.WriteLine(" ****** test LastChild ******");
                Output.WriteLine("check if the last child retrieved is correct");
                VerifyEqual(xroot.Elements().Last(), ConvertToXElement(part, root.LastChild), null);

                Output.WriteLine(" ****** test ChildElements ******");
                Output.WriteLine("check if the children is returned correct");
                VerifyEqual(xroot.Elements(), root.ChildElements, part);

                Output.WriteLine(" ****** test Descendants ******");
                Output.WriteLine("check if the descendants if the first child returned are correct");
                VerifyEqual(xroot.Descendants(), root.Descendants(), part);

                Output.WriteLine(" ******test Elements<T> ******");
                Output.WriteLine("check if the Element<OpenXmlElement> returned are correct");
                VerifyEqual(xroot.Elements(), root.Elements<OpenXmlElement>(), part);

                Output.WriteLine("check if the Element<{0}> returned are correct", typeof(T).Name);
                VerifyEqual(xroot.Elements().Where(x => x.Name.LocalName == uTagName), root.Elements<T>(), part);

                Output.WriteLine(" ****** test Descendants<T> ******");
                Output.WriteLine("check if the Descendants<OpenXmlElement> of the first child are returned correctly");
                VerifyEqual(xroot.Descendants(), root.Descendants<OpenXmlElement>(), part);

                Output.WriteLine("check if the Descendants<{0}> returned are correct", typeof(T).Name);
                VerifyEqual(xroot.Descendants().Where(x => x.Name.LocalName == uTagName), root.Descendants<T>(), part);

                Output.WriteLine(" ****** test GetFirstChildOfType<T> ******");
                Output.WriteLine("check if the GetFirstChild<OpenXmlElement> returns the first child element");
                VerifyEqual(xroot.Elements().First(), ConvertToXElement(part, root.GetFirstChild<OpenXmlElement>()), null);

                Output.WriteLine("check if the GetFirstChild<{0}> returns the correct result", typeof(T).Name);
                VerifyEqual(xroot.Elements().Where(x => x.Name.LocalName == uTagName).First(), ConvertToXElement(part, root.GetFirstChild<T>()), null);

                Output.WriteLine(" ****** test GetEnumerator() ******");
                Output.WriteLine("check if the GetEnumerator returns the correct result");
                VerifyEqual(xroot.Elements(), root, part);

                Output.WriteLine("***** test IsBefore() ******");
                foreach (var element in root.Descendants())
                {
                    if (root.FirstChild == element)
                    {
                        Assert.False(root.FirstChild.IsBefore(element), "Expect: False <> Actual: True");
                        Assert.False(root.FirstChild.IsAfter(element), "Expect: False <> Actual: True");
                    }
                    else
                    {
                        Assert.True(root.FirstChild.IsBefore(element), "Expect: True <> Actual: False");
                        Assert.False(root.FirstChild.IsAfter(element), "Expect: False <> Actual: True");
                    }
                }

                Output.WriteLine("****** test IsAfter() ******");
                foreach (var element in root.Elements())
                {
                    if (element == root.LastChild)
                    {
                        Assert.False(root.LastChild.IsAfter(element), "Expect: False <> Actual: True");
                        Assert.False(root.LastChild.IsBefore(element), "Expect: False <> Actual: True");
                    }
                    else
                    {
                        Assert.True(root.LastChild.IsAfter(element), "Expect: True <> Actual: False");
                        Assert.False(root.LastChild.IsBefore(element), "Expect: False <> Actual: True");
                    }
                }
            }
            else
            {
                Output.WriteLine("Warning: No Children exists");
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

            Output.WriteLine("****** test ElementsAfter ******");
            VerifyEqual(xwalker.ElementsAfterSelf(), walker.ElementsAfter(), part);

            Output.WriteLine("****** test NextSibling ******");
            Output.WriteLine("check if the nextSibling returns correctly");

            while (xwalker.NextNode is not null && walker.NextSibling() is not null)
            {
                xwalker = xwalker.ElementsAfterSelf().First();
                walker = walker.NextSibling();

                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.NextNode is null && walker.NextSibling() is null)
            {
                Output.WriteLine("check if the current element is the last sibling of the original element");
                VerifyEqual(xele.Parent.Elements().Last(), walker, part);

                Output.WriteLine("All next siblings have been retrieved correctly");
            }
            else
            {
                Assert.Fail("nextSibling doesn't return correctly");
            }

            Output.WriteLine("****** test ElementsBefore ******");
            VerifyEqual(xwalker.ElementsBeforeSelf(), walker.ElementsBefore(), part);

            Output.WriteLine("****** test PreviousSibling ******");
            while (xwalker.PreviousNode is not null && walker.PreviousSibling() is not null)
            {
                xwalker = xwalker.ElementsBeforeSelf().Last();
                walker = walker.PreviousSibling();
                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.PreviousNode is null && walker.PreviousSibling() is null)
            {
                Output.WriteLine("check if the current element is the first sibling of the original element");
                VerifyEqual(xele.Parent.Elements().First(), walker, part);

                Output.WriteLine("All Previous siblings have been retrieved correctly");
            }
            else
            {
                Assert.Fail("PreviousSibling doesn't return correctly");
            }

            Output.WriteLine("****** test NextSibling<OpenXmlElement> ******");

            while (xwalker.NextNode is not null && walker.NextSibling() is not null)
            {
                xwalker = xwalker.ElementsAfterSelf().First();
                walker = walker.NextSibling<OpenXmlElement>();

                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.NextNode is null && walker.NextSibling() is null)
            {
                Output.WriteLine("check if the current element is the last sibling of the original element");
                VerifyEqual(xele.Parent.Elements().Last(), walker, part);

                Output.WriteLine("All next siblings have been retrieved correctly");
            }
            else
            {
                Assert.Fail("nextSibling doesn't return correctly");
            }

            Output.WriteLine("****** test PreviousSibling<OpenXmlElement>() ******");
            while (xwalker.PreviousNode is not null && walker.PreviousSibling<OpenXmlElement>() is not null)
            {
                xwalker = xwalker.ElementsBeforeSelf().Last();
                walker = walker.PreviousSibling<OpenXmlElement>();
                VerifyEqual(xwalker, walker, part);
            }

            if (xwalker.PreviousNode is null && walker.PreviousSibling<OpenXmlElement>() is null)
            {
                Output.WriteLine("check if the current element is the first sibling of the original element");
                VerifyEqual(xele.Parent.Elements().First(), walker, part);

                Output.WriteLine("All Previous siblings have been retrieved correctly");
            }
            else
            {
                Assert.Fail("PreviousSibling doesn't return correctly");
            }

            Output.WriteLine("****** test NextSibling<{0}> ******", typeof(T).Name);
            while (xwalker.ElementsAfterSelf().Where(x => x.Name.LocalName == uTagName).Any() && walker.NextSibling<T>() is not null)
            {
                xwalker = xwalker.ElementsAfterSelf().Where(x => x.Name.LocalName == uTagName).First();
                walker = walker.NextSibling<T>();

                VerifyEqual(xwalker, walker, part);
            }

            Output.WriteLine("****** test PreviousSibling<{0}>() ******", typeof(T).Name);
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
                Output.WriteLine("<<<<<<<<<<<<< Traverse MainDocumentPart >>>>>>>>>>>>");

                Output.WriteLine("<<<<<<<<<<<< Traverse Down >>>>>>>>>>>>>>");
                Output.WriteLine("      <<<<<< traversing Body >>>>>>");
                Body body = doc.MainDocumentPart.Document.GetFirstChild<Body>();
                TestTraverseDown<Paragraph>(doc.MainDocumentPart, body);

                Output.WriteLine("      <<<<<< traversing Paragraph >>>>>>");
                TestTraverseDown<DocumentFormat.OpenXml.Wordprocessing.Run>(doc.MainDocumentPart, body.GetFirstChild<Paragraph>());

                Output.WriteLine("<<<<<<<<<<<< Traverse Up >>>>>>>>>>>>>>");
                TestTraverseUp<Paragraph>(doc.MainDocumentPart, body.LastChild);

                Output.WriteLine("<<<<<<<<<<<< Traverse Sibling >>>>>>>>>>>");
                TestTraverseSibling<Paragraph>(doc.MainDocumentPart, body.FirstChild);

                Output.WriteLine("<<<<<<<<<<<<< Traverse Non-MainDocumentPart >>>>>>>>>>>>");

                Output.WriteLine("<<<<<<<<<<<< Traverse Down >>>>>>>>>>>>>>");
                TestTraverseDown<Style>(doc.MainDocumentPart.StyleDefinitionsPart, doc.MainDocumentPart.StyleDefinitionsPart.Styles);

                Output.WriteLine("<<<<<<<<<<<< Traverse Up >>>>>>>>>>>>>>");
                TestTraverseUp<Style>(doc.MainDocumentPart.StyleDefinitionsPart, doc.MainDocumentPart.StyleDefinitionsPart.Styles.LastChild);

                Output.WriteLine("<<<<<<<<<<<< Traverse Sibling >>>>>>>>>>>");
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
                Output.WriteLine("<<<<<<<<<<<<< Traverse WorkBookPart >>>>>>>>>>>>");
                Output.WriteLine("   <<<<<<< Traverse Down >>>>>>>>");
                Output.WriteLine(" <<<<<< traversing WorkBook >>>>>>");
                TestTraverseDown<Sheets>(excel.WorkbookPart, excel.WorkbookPart.Workbook);

                Output.WriteLine(" <<<<<< traversing Sheets >>>>>>");
                TestTraverseDown<Sheet>(excel.WorkbookPart, excel.WorkbookPart.Workbook.GetFirstChild<Sheets>());

                Output.WriteLine("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<Sheets>(excel.WorkbookPart, excel.WorkbookPart.Workbook.LastChild);

                Output.WriteLine("  <<<<<< Traverse Sibling  >>>>>>");
                TestTraverseSibling<Sheets>(excel.WorkbookPart, excel.WorkbookPart.Workbook.FirstChild);

                Output.WriteLine("<<<<<<<<<<<<< Traverse Non-WorkBookPart >>>>>>>>>>>>");
                Output.WriteLine("   <<<<<<< Traverse Down >>>>>>>>");
                Output.WriteLine(" <<<<<< traversing WorkSheet >>>>>>");
                TestTraverseDown<SheetData>(excel.WorkbookPart.WorksheetParts.First(), excel.WorkbookPart.WorksheetParts.First().Worksheet);

                Output.WriteLine(" <<<<<< traversing SheetData >>>>>>");
                TestTraverseDown<Row>(excel.WorkbookPart.WorksheetParts.First(), excel.WorkbookPart.WorksheetParts.First().Worksheet.GetFirstChild<SheetData>());

                Output.WriteLine("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<SheetData>(excel.WorkbookPart.WorksheetParts.First(), excel.WorkbookPart.WorksheetParts.First().Worksheet.LastChild);

                Output.WriteLine("  <<<<<< Traverse Sibling  >>>>>>");
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
                Output.WriteLine("<<<<<<<<<<<<< Traverse PresentationPart >>>>>>>>>>>>");
                Output.WriteLine("   <<<<<<< Traverse Down >>>>>>>>");
                Output.WriteLine(" <<<<<< traversing Presentation >>>>>>");
                TestTraverseDown<SlideIdList>(ppt.PresentationPart, ppt.PresentationPart.Presentation);

                Output.WriteLine(" <<<<<< traversing SlideIdList >>>>>>");
                TestTraverseDown<SlideId>(ppt.PresentationPart, ppt.PresentationPart.Presentation.GetFirstChild<SlideIdList>());

                Output.WriteLine("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<SlideIdList>(ppt.PresentationPart, ppt.PresentationPart.Presentation.LastChild);

                Output.WriteLine("  <<<<<< Traverse Sibling  >>>>>>");
                TestTraverseSibling<SlideIdList>(ppt.PresentationPart, ppt.PresentationPart.Presentation.FirstChild);

                Output.WriteLine("<<<<<<<<<<<<< Traverse Non-PresentationPart >>>>>>>>>>>>");
                Output.WriteLine("   <<<<<<< Traverse Down >>>>>>>>");
                Output.WriteLine(" <<<<<< traversing Slide  >>>>>>");
                TestTraverseDown<CommonSlideData>(ppt.PresentationPart.SlideParts.First(), ppt.PresentationPart.SlideParts.First().Slide);

                Output.WriteLine("   <<<<<<< Traverse Up >>>>>>>>> ");
                TestTraverseUp<CommonSlideData>(ppt.PresentationPart.SlideParts.First(), ppt.PresentationPart.SlideParts.First().Slide.LastChild);

                Output.WriteLine("  <<<<<< Traverse Sibling  >>>>>>");
                TestTraverseSibling<CommonSlideData>(ppt.PresentationPart.SlideParts.First(), ppt.PresentationPart.SlideParts.First().Slide.FirstChild);
            }
        }
    }
}
