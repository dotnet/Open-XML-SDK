// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{

    public class DocumentTraverseTest : OpenXmlDomTestBase
    {
        /// <summary>
        /// Traversing up the specified Document Part using Parent, Ancestors(), and Ancestors&ltT&gt Methods
        /// </summary>
        /// <typeparam name="T">the PartRootElement</typeparam>
        /// <param name="part">the openXmlPart which the root element existed on</param>
        /// <param name="root">the loaded part root element to be traversed</param>
        private void TestTraverseUp<U>(OpenXmlPart part, OpenXmlElement root) where U : OpenXmlElement
        {
            String UTagName = (Activator.CreateInstance(typeof(U)) as OpenXmlElement).LocalName;

            Log.Comment("retrieve last child of the root element in XElement");
            XElement Xroot = ConvertToXElement(part, root);

            Log.Comment("Check if the parent returns correctly");
            VerifyEqual(Xroot.Parent, root.Parent, part);

            Log.Comment("check if Ancestors returns correctly");
            VerifyEqual(Xroot.Ancestors(), root.Ancestors(), part);

            Log.Comment("Check if the Ancestors<T> returns correctly");
            Log.Comment("check if the Ancestors<OpenXmlElement> returns correctly");
            VerifyEqual(Xroot.Ancestors(), root.Ancestors<OpenXmlElement>(), part);

            Log.Comment("check if the Ancestors<{0}> returns correctly", typeof(U).Name);
            VerifyEqual(Xroot.Ancestors().Where(x => x.Name.LocalName == UTagName), root.Ancestors<U>(), part);
        }

        /// <summary>
        /// Traversing down the specified element using HasChildren, FirstChild, LastChild, ChildElements(), Descendants(), Elements()
        /// GetFirstChildOfType, and GetEnumerator methods
        /// </summary>
        /// <typeparam name="U">The specified child type need to be traversed</typeparam>
        /// <param name="part">the OpenXmlPart in which the element exists</param>
        /// <param name="root">the OpenXmlElement need to be traversed</param>
        private void TestTraverseDown<U>(OpenXmlPart part, OpenXmlElement root) where U : OpenXmlElement
        {

            String UTagName = (Activator.CreateInstance(typeof(U)) as OpenXmlElement).LocalName;
            XElement Xroot = ConvertToXElement(part, root);

            Log.Comment(" ****** test HasChildren ******");
            Log.Comment("check if the hasChildren is correct");
            Log.VerifyTrue(Xroot.HasElements == root.HasChildren, "hasChildren is not correct");

            if (root.HasChildren)
            {
                OpenXmlElement firstChild = root.FirstChild;
                XElement XfirstChild = Xroot.Elements().ElementAt(0);

                Log.Comment(" ****** test FirstChild ******");
                Log.Comment("check if the first child retrieved is correct");
                VerifyEqual(XfirstChild, ConvertToXElement(part, firstChild), null);

                Log.Comment(" ****** test LastChild ******");
                Log.Comment("check if the last child retrieved is correct");
                VerifyEqual(Xroot.Elements().Last(), ConvertToXElement(part, root.LastChild), null);

                Log.Comment(" ****** test ChildElements ******");
                Log.Comment("check if the children is returned correct");
                VerifyEqual(Xroot.Elements(), root.ChildElements, part);

                Log.Comment(" ****** test Descendants ******");
                Log.Comment("check if the decndants if the first child returned are correct");
                VerifyEqual(Xroot.Descendants(), root.Descendants(), part);


                Log.Comment(" ******test Elements<T> ******");
                Log.Comment("check if the Element<OpenXmlElement> returned are correct");
                VerifyEqual(Xroot.Elements(), root.Elements<OpenXmlElement>(), part);

                Log.Comment("check if the Element<{0}> returned are correct", typeof(U).Name);
                VerifyEqual(Xroot.Elements().Where(x => x.Name.LocalName == UTagName), root.Elements<U>(), part);

                Log.Comment(" ****** test Descendants<T> ******");
                Log.Comment("check if the Descendants<OpenXmlElement> of the first child are returned correctly");
                VerifyEqual(Xroot.Descendants(), root.Descendants<OpenXmlElement>(), part);

                Log.Comment("check if the Decendants<{0}> returned are correct", typeof(U).Name);
                VerifyEqual(Xroot.Descendants().Where(x => x.Name.LocalName == UTagName), root.Descendants<U>(), part);

                Log.Comment(" ****** test GetFirstChildOfType<T> ******");
                Log.Comment("check if the GetFirstChild<OpenXmlElement> returns the first child element");
                VerifyEqual(Xroot.Elements().First(), ConvertToXElement(part, root.GetFirstChild<OpenXmlElement>()), null);

                Log.Comment("check if the GetFirstChild<{0}> returns the correct result", typeof(U).Name);
                VerifyEqual(Xroot.Elements().Where(x => x.Name.LocalName == UTagName).First(), ConvertToXElement(part, root.GetFirstChild<U>()), null);

                Log.Comment(" ****** test GetEnumerator() ******");
                Log.Comment("check if the GetEnumerator returns the correct result");
                VerifyEqual(Xroot.Elements(), root, part);

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
                Log.Warning("No Children exists");
        }

        /// <summary>
        /// Traversing siblings of the specified element using PreviousSibling, PreviousSibling &lt T &gt 
        /// NextSibling, NextSibling&ltT&gt, ElementsBefore, ElementsAfter, IsBefore, IsAfter"/>
        /// </summary>
        /// <typeparam name="U">Type of the sibling used by generic traversing method</typeparam>
        /// <param name="part">the OpenXmlPart in which the element exists</param>
        /// <param name="Element">the OpenXmlElement need to be traversed</param>
        private void TestTraverseSibling<U>(OpenXmlPart part, OpenXmlElement Element) where U : OpenXmlElement
        {
            String UTagName = (Activator.CreateInstance(typeof(U)) as OpenXmlElement).LocalName;

            OpenXmlElement walker = Element;
            XElement Xele = ConvertToXElement(part, Element);
            XElement Xwalker = Xele;

            Log.Comment("****** test ElementsAfter ******");
            VerifyEqual(Xwalker.ElementsAfterSelf(), walker.ElementsAfter(), part);

            Log.Comment("****** test NextSibling ******");
            Log.Comment("check if the nextSibling returns correctly");

            while (Xwalker.NextNode != null && walker.NextSibling() != null)
            {
                Xwalker = Xwalker.ElementsAfterSelf().First();
                walker = walker.NextSibling();

                VerifyEqual(Xwalker, walker, part);
            }

            if (Xwalker.NextNode == null && walker.NextSibling() == null)
            {
                Log.Comment("check if the current element is the last sibling of the original element");
                VerifyEqual(Xele.Parent.Elements().Last(), walker, part);

                Log.Pass("All next siblings have been retrieved correctly");
            }
            else
                Log.Fail("nextSibling doesn't return correctly");

            Log.Comment("****** test ElementsBefore ******");
            VerifyEqual(Xwalker.ElementsBeforeSelf(), walker.ElementsBefore(), part);


            Log.Comment("****** test PreviousSibling ******");
            while (Xwalker.PreviousNode != null && walker.PreviousSibling() != null)
            {
                Xwalker = Xwalker.ElementsBeforeSelf().Last();
                walker = walker.PreviousSibling();
                VerifyEqual(Xwalker, walker, part);
            }

            if (Xwalker.PreviousNode == null && walker.PreviousSibling() == null)
            {
                Log.Comment("check if the current element is the first sibling of the original element");
                VerifyEqual(Xele.Parent.Elements().First(), walker, part);

                Log.Pass("All Previous siblings have been retrieved correctly");
            }
            else
                Log.Fail("PreviousSibling doesn't return correctly");


            Log.Comment("****** test NextSibling<OpenXmlElement> ******");

            while (Xwalker.NextNode != null && walker.NextSibling() != null)
            {
                Xwalker = Xwalker.ElementsAfterSelf().First();
                walker = walker.NextSibling<OpenXmlElement>();

                VerifyEqual(Xwalker, walker, part);
            }

            if (Xwalker.NextNode == null && walker.NextSibling() == null)
            {
                Log.Comment("check if the current element is the last sibling of the original element");
                VerifyEqual(Xele.Parent.Elements().Last(), walker, part);

                Log.Pass("All next siblings have been retrieved correctly");
            }
            else
                Log.Fail("nextSibling doesn't return correctly");


            Log.Comment("****** test PreviousSibling<OpenXmlElement>() ******");
            while (Xwalker.PreviousNode != null && walker.PreviousSibling<OpenXmlElement>() != null)
            {
                Xwalker = Xwalker.ElementsBeforeSelf().Last();
                walker = walker.PreviousSibling<OpenXmlElement>();
                VerifyEqual(Xwalker, walker, part);
            }

            if (Xwalker.PreviousNode == null && walker.PreviousSibling<OpenXmlElement>() == null)
            {
                Log.Comment("check if the current element is the first sibling of the original element");
                VerifyEqual(Xele.Parent.Elements().First(), walker, part);

                Log.Pass("All Previous siblings have been retrieved correctly");
            }
            else
                Log.Fail("PreviousSibling doesn't return correctly");

            Log.Comment("****** test NextSibling<{0}> ******", typeof(U).Name);
            while (Xwalker.ElementsAfterSelf().Where(x => x.Name.LocalName == UTagName).Count() != 0 && walker.NextSibling<U>() != null)
            {
                Xwalker = Xwalker.ElementsAfterSelf().Where(x => x.Name.LocalName == UTagName).First();
                walker = walker.NextSibling<U>();

                VerifyEqual(Xwalker, walker, part);
            }

            Log.Comment("****** test PreviousSibling<{0}>() ******", typeof(U).Name);
            while (Xwalker.ElementsBeforeSelf().Where(x => x.Name.LocalName == UTagName).Count() != 0 && walker.PreviousSibling<U>() != null)
            {
                Xwalker = Xwalker.ElementsBeforeSelf().Where(x => x.Name.LocalName == UTagName).Last();
                walker = walker.PreviousSibling<U>();
                VerifyEqual(Xwalker, walker, part);
            }
        }

        #region Word Document Traversing ...

        [Fact]

        public void TraverseWordDocument()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            //description = " Case ID: 75567, 75568, 75505, 75506, 76083, 76084";
            foreach (var testfile in CopyTestFiles(@"wordprocessing\paragraph", false, 3))
            {
                Log.BeginGroup(testfile.Name);

                Log.Comment("open test file {0} for traversing", testfile);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(testfile.FullName, false))
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
        }

        #endregion

        #region SpreadSheet Document Traversing ...

        [Fact]

        public void TraverseSpreadSheetDocument()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            foreach (var testfile in CopyTestFiles(@"SpreadSheet\smallset", false, 3))
            {
                Log.BeginGroup(testfile.Name);
                Log.Comment("open test file {0} for traversing", testfile);
                using (SpreadsheetDocument excel = SpreadsheetDocument.Open(testfile.FullName, false))
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
        }

        #endregion

        #region PPT Document Traversing ...

        [Fact]

        public void TraversePPTDocument()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            foreach (var testfile in CopyTestFiles(@"presentation\smallset", false, 3))
            {
                Log.BeginGroup(testfile.Name);
                Log.Comment("open test file {0} for traversing", testfile);
                using (PresentationDocument ppt = PresentationDocument.Open(testfile.FullName, false))
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

        #endregion
    }
}
