// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing;

using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    using DocumentFormat.OpenXml.Tests.TaskLibraries;

    /// <summary>OpenXmlCompositeElementTestClass</summary>

    public class OpenXmlCompositeElementTestClass : OpenXmlDomTestBase
    {

        #region Elements

        [Fact]
        public void DummyObjectForEmptyChildElementsTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            var testfile = testfiles.FirstOrDefault();
            {
                Log.Comment("Opening package {0}...", testfile.FullName);
                var package = testfile.OpenPackage(false);
                Log.Comment("Find target part...");
                var part = package.DescendantParts().Where(p => p.IsReflectable()).FirstOrDefault();
                Log.Comment("Loading DOM...");
                var dom = part.RootElement;
                var e1 = dom.Descendants().Where(d => !d.HasChildren).PickSecond();
                Log.VerifyNotNull(e1.ChildElements, "Element {0} has no ChildElements but ChildElements property is not NULL.");
                var e2 = dom.Descendants().Where(d => !d.HasChildren).PickFirst(d => d != e1);
                Log.VerifyNotNull(e2.ChildElements, "Element {0} has no ChildElements but ChildElements property is not NULL.");
                Log.VerifyTrue(e1.ChildElements == e2.ChildElements, "ChildElements property of two different element are NOT equal to same dummy.");
            }
        }

        #endregion Elements

        #region Append Collection

        [Fact]
        public void AppendArrayPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
                AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextBody, AppendCollectionType.Array);
        }

        [Fact]
        public void AppendArrayXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
                AppendCollectionOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, AppendCollectionType.Array);
        }

        [Fact]
        public void AppendIEnumerableTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());
            foreach (var testfile in testfiles)
                AppendCollectionOnFile(testfile, getMainPart, getBody, source, getMainPart, getAnyComposite, AppendCollectionType.IEnumerable);
        }

        [Fact]
        public void AppendIEnumerablePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());
            foreach (var testfile in testfiles)
                AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getAnyComposite, AppendCollectionType.IEnumerable);
        }

        [Fact]
        public void AppendIEnumerableXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
                AppendCollectionOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, AppendCollectionType.IEnumerable);
        }

        #endregion Append Collection

        #region Pend Operations

        [Fact]
        public void AppendChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
                PendTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getBody, PendType.Append);
        }

        [Fact]
        public void AppendChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
                PendTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextBody, PendType.Append);
        }

        [Fact]
        public void AppendChildXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
                PendTestOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, PendType.Append);
        }

        [Fact]
        public void PreppendChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
                PendTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getBody, PendType.Prepend);
        }

        [Fact]
        public void PreppendChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());
            foreach (var testfile in testfiles)
                PendTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextBody, PendType.Prepend);
        }

        [Fact]
        public void PreppendChildXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                 .Where(f => f.IsSpreadsheetFile());
            foreach (var testfile in testfiles)
                PendTestOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, PendType.Prepend);
        }

        #endregion Pend Operations

        #region Insert Before/After

        [Fact]
        public void InsertBeforeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());
            foreach (var testfile in testfiles)
            {
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getLastChild, InsertType.Before);
            }
        }

        [Fact]
        public void InsertBeforePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getLastChild, InsertType.Before);
            }
        }

        [Fact]
        public void InsertBeforeXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());
            foreach (var testfile in testfiles)
            {
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getLastChild, InsertType.Before);
            }
        }

        [Fact]
        public void InsertAfterTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());
            foreach (var testfile in testfiles)
            {
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getLastChild, InsertType.After);
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getFirstChild, InsertType.After);
            }
        }

        [Fact]
        public void InsertAfterPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());
            foreach (var testfile in testfiles)
            {
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getFirstChild, InsertType.After);
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getLastChild, InsertType.After);
            }
        }

        [Fact]
        public void InsertAfterXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());
            foreach (var testfile in testfiles)
            {
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getFirstChild, InsertType.After);
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getLastChild, InsertType.After);
            }
        }

        #endregion Insert Before/After

        #region InsertAt

        [Fact]
        public void InsertAtTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                InsertAtOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, InsertAtPosition.AnyValid);
            }
        }

        [Fact]
        public void InsertAtPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());
            foreach (var testfile in testfiles)
            {
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.AnyValid);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.AsFirst);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.NextToFirst);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.NextToLast);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.AsLast);
            }
        }

        [Fact]
        public void InsertAtXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());
            foreach (var testfile in testfiles)
            {
                InsertAtOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertAtPosition.AnyValid);
                InsertAtOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertAtPosition.AsFirst);
                InsertAtOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertAtPosition.NextToFirst);
                InsertAtOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertAtPosition.NextToLast);
                InsertAtOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertAtPosition.AsLast);
            }
        }

        #endregion InsertAt

        #region Insert Before/After Self

        [Fact]
        public void InsertRelativeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());
            foreach (var testfile in testfiles)
            {
                InsertRelativeOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, InsertRel.BeforeSelf);
            }
        }

        [Fact]
        public void InsertRelativePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());
            foreach (var testfile in testfiles)
            {
                InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertRel.BeforeSelf);
            }
        }

        [Fact]
        public void InsertRelativeXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());
            foreach (var testfile in testfiles)
            {
                InsertRelativeOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertRel.BeforeSelf);
            }
        }

        #endregion Insert Before/After Self

        #region RemoveAllChildren

        [Fact]
        public void RemoveAllChildrenTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                RemoveAllChildrenOnFile(testfile, getMainPart, getElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, getMainPart, getElementWithChildren);
            }
        }

        [Fact]
        public void RemoveAllChildrenPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithChildren);
                RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, getSlidePart, getFirstChild);
            }
        }

        [Fact]
        public void RemoveAllChildrenXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                RemoveAllChildrenOnFile(testfile, getLastSheetPart, getElementWithChildren);
                RemoveAllChildrenOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, getLastSheetPart, getFirstChild);
            }
        }

        [Fact]
        public void RemoveAllTypedChildrenTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                RemoveAllTypedChildrenOnFile(testfile, getMainPart, getAnyWithLeafAndCompositeChild, typeof(OpenXmlCompositeElement));
            }
        }

        [Fact]
        public void RemoveAllTypedChildrenPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, typeof(OpenXmlLeafElement));
            }
        }

        [Fact]
        //cannot getAnyWithLeafAndCompositeElement
        public void RemoveAllTypedChildrenXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                RemoveAllTypedChildrenOnFile(testfile, getLastSheetPart, getAnyWithCompositeChild, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, getLastSheetPart, getAnyWithLeafChild, typeof(OpenXmlLeafElement));
            }
        }

        #endregion RemoveAllChildren

        #region RemoveChild

        [Fact]
        public void RemoveChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                RemoveChildOnFile(testfile, getMainPart, getElementWithChildren, getAnyChild);
            }
        }

        [Fact]
        public void RemoveChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody, getFirstChild);
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody, getAnyChild);
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody, getLastChild);
            }
        }

        [Fact]
        public void RemoveChildXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            var testfile = testfiles.FirstOrDefault();
            RemoveChildOnFile(testfile, getLastSheetPart, getSheetData, getAnyChild);
        }

        #endregion RemoveChild

        #region Remove

        [Fact]
        public void RemoveTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                RemoveOnFile(testfile, getMainPart, getAnyLeaf);
                RemoveOnFile(testfile, getMainPart, getAnyComposite);
            }
        }

        [Fact]
        public void RemovePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                RemoveOnFile(testfile, getSlidePart, getSlideTextBody);
                RemoveOnFile(testfile, getSlidePart, getAnyLeaf);
                RemoveOnFile(testfile, getSlidePart, getAnyComposite);
            }

        }

        [Fact]
        public void RemoveXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                RemoveOnFile(testfile, getLastSheetPart, getSheetData);
                RemoveOnFile(testfile, getLastSheetPart, getAnyLeaf);
                RemoveOnFile(testfile, getLastSheetPart, getAnyComposite);
            }
        }

        #endregion Remove

        #region ReplaceChild<T>(OpenXmlElement, T)

        [Fact]
        public void ReplaceChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                ReplaceChildOnFile(testfile, getMainPart, getBody, getAnyChild, source, getMainPart, getAnyChild, typeof(OpenXmlElement));
            }
        }

        [Fact]
        public void ReplaceChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                ReplaceChildOnFile(testfile, getSlidePart, getSlideTextBody, getAnyChild, source, getSlidePart, getAnyChild, typeof(OpenXmlElement));
                ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyCompositeChild, source, getSlidePart, getAnyChild, typeof(OpenXmlCompositeElement));
                ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyLeafChild, source, getSlidePart, getAnyChild, typeof(OpenXmlLeafElement));
            }
        }

        [Fact]
        public void ReplaceChildXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                ReplaceChildOnFile(testfile, getLastSheetPart, getSheetData, getAnyChild, source, getLastSheetPart, getAnyChild, typeof(OpenXmlElement));
            }
        }

        #endregion ReplaceChild<T>(OpenXmlElement, T)

        #region OpenXmlAttribute

        //w:rsidR="00B327F7" w:rsidRPr="00B327F7" w:rsidRDefault="00BB7AFC" w:rsidP="00EC35BB"
        // xmlns:ve="http://schemas.openxmlformats.org/markup-compatibility/2006" 
        // xmlns:objA="urn:schemas-microsoft-com:office:office" 
        // xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" 
        // xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" 
        // xmlns:v="urn:schemas-microsoft-com:vml" 
        // xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" 
        // xmlns:w10="urn:schemas-microsoft-com:office:word" 
        // xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" 
        // xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml"

        //xmlns:a="http://schemas.openxmlformats.org/drawingml/2006/main"
        //xmlns:p="http://schemas.openxmlformats.org/presentationml/2006/main"

        [Fact]
        public void OpenXmlAttributeValueTypeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Log.Comment("Constructing a default OpenXmlAttribute and assign it to another variable...");
            var oxaX = default(OpenXmlAttribute);
            var oxaY = oxaX;
            Log.VerifyTrue(oxaX == oxaY, "The assigned OpenXmlAttribute variable is NOT equal to original one.");
            Log.VerifyFalse(object.ReferenceEquals(oxaX, oxaY), "The assigned OpenXmlAttribute variable IS reference equal to original one.");

            Log.Comment("Constructing OpenXmlAttribute w:rsidR and assigning it to another variable...");
            var wrsidR = new OpenXmlAttribute { NamespaceUri = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Prefix = "w", LocalName = "rsidR", Value = "00B327F7" };
            var wrsidP = wrsidR;
            Log.VerifyTrue(wrsidP == wrsidR, "The assigned OpenXmlAttribute variable is NOT equal to original one.");
            Log.VerifyFalse(object.ReferenceEquals(wrsidP, wrsidR), "The assigned OpenXmlAttribute variable IS reference equal to original one.");

            wrsidP.LocalName = "rsidP";
            wrsidP.Value = "00EC35BB";
            Log.Comment("Assgined new LocalName: {0} with ByValue: {1} and comparing it with original w:rsidR", wrsidP.LocalName, wrsidP.Value);
            Log.VerifyFalse(wrsidP == wrsidR, "The assigned OpenXmlAttribute variable IS equal to original one.");
            Log.VerifyFalse(object.ReferenceEquals(wrsidP, wrsidR), "The assigned OpenXmlAttribute variable IS reference equal to original one.");
        }

        [Fact]
        public void OpenXmlAttributeEqualTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Log.Comment("Comparing two default OpenXmlAttribute...");
            var defaultA = default(OpenXmlAttribute);
            var defaultB = default(OpenXmlAttribute);
            Log.VerifyTrue(defaultA == defaultB, "Two default OpenXmlAttribute are NOT equal.");
            Log.VerifyFalse(defaultA != defaultB, "Two default OpenXmlAttribute are Equal.");

            var wrsidRA = new OpenXmlAttribute { NamespaceUri = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Prefix = "w", LocalName = "rsidR", Value = "00B327F7" };
            var wrsidRB = new OpenXmlAttribute { NamespaceUri = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Prefix = "w", LocalName = "rsidR", Value = "00B327F7" };
            Log.Comment("Comparing two {0} OpenXmlAttribute with value {1}...", wrsidRA.GetFullName(), wrsidRA.Value);
            Log.Comment("HashCode for {0}: {1}", wrsidRA.XmlQualifiedName, wrsidRA.GetHashCode());
            Log.VerifyTrue(wrsidRA == wrsidRB, "Two OpenXmlAttribute with same leftBorders are NOT equal by ==.");
            Log.VerifyTrue(wrsidRA.Equals((object)wrsidRB), "Two OpenXmlAttribute with same leftBorders are NOT equal by Equals().");
            Log.VerifyFalse(wrsidRA != wrsidRB, "Two OpenXmlAttribute with fame leftBorders are NOT equal by !=.");

            var wrsidR = new OpenXmlAttribute { NamespaceUri = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Prefix = "w", LocalName = "rsidR", Value = "00B327F7" };
            var wrsidP = new OpenXmlAttribute { NamespaceUri = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Prefix = "w", LocalName = "rsidP", Value = "00EC35BB" };
            Log.Comment("HashCode for {0}: {1}", wrsidR.XmlQualifiedName, wrsidR.GetHashCode());
            Log.Comment("HashCode for {0}: {1}", wrsidP.XmlQualifiedName, wrsidP.GetHashCode());
            Log.Comment("Comparing two different OpenXmlAttribute with different value...");
            Log.VerifyFalse(wrsidR == wrsidP, "Two different OpenXmlAttribute with different value are equal by ==.");
            Log.VerifyFalse(wrsidR.Equals((object)wrsidP), "Two different OpenXmlAttribute with different value are equal by Equals().");
            Log.VerifyTrue(wrsidR != wrsidP, "Two different OpenXmlAttribute with different are equal by !=.");
        }

        #endregion OpenXmlAttribute

        #region GetAttribute(string localName, string namespaceUri)

        [Fact]
        public void DummyIEnumerableForExtendedAttributesTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            var testfile = testfiles.FirstOrDefault();
            Log.Comment("Opening package {0}...", testfile.FullName);
            var package = testfile.OpenPackage(false);
            Log.Comment("Find target part...");
            var part = package.DescendantParts().Where(p => p.IsReflectable()).FirstOrDefault();
            Log.Comment("Loading DOM...");
            var dom = part.RootElement;
            var e1 = dom.Descendants().Where(d => d.ExtendedAttributes.Count() == 0).PickSecond();
            Log.VerifyNotNull(e1.ExtendedAttributes, "Element {0} has no ExtenedAttributes but ExtendedAttributes property is not NULL.");
            var e2 = dom.Descendants().Where(d => d.ExtendedAttributes.Count() == 0).PickFirst(d => d != e1);
            Log.VerifyNotNull(e2.ExtendedAttributes, "Element {0} has no ExtenedAttributes but ExtendedAttributes property is not NULL.");
            Log.VerifyTrue(e1.ExtendedAttributes == e2.ExtendedAttributes, "ExtendedAttributes property of two different element are NOT equal to same dummy.");
        }

        [Fact]
        public void GetAttributeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                GetAttributeOnFile(testfile, getMainPart, getElementWithAttributes);
            }
        }

        [Fact]
        public void GetAttributePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                GetAttributeOnFile(testfile, getSlidePart, getElementWithAttributes);
            }
        }

        [Fact]
        public void GetAttributeXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                GetAttributeOnFile(testfile, getLastSheetPart, getElementWithAttributes);
            }
        }

        #endregion GetAttribute

        #region GetAttributes

        // GetAttributes()
        [Fact]
        public void GetAttributesTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                GetAttributesOnFile(testfile, getMainPart, getElementWithoutAttributes);
                GetAttributesOnFile(testfile, getMainPart, getElementWithAttributes);
            }
        }

        [Fact]
        public void GetAttributesPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                GetAttributesOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                GetAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly);
            }
        }

        [Fact]
        public void GetAttributesXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                GetAttributesOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                GetAttributesOnFile(testfile, getLastSheetPart, getElementWithFixedAttributeOnly);
            }
        }

        #endregion GetAttributes

        #region SetAttribute(OpenXmlAttribute)

        [Fact]
        public void SetAttributeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                SetAttributeOnFile(testfile, getMainPart, getTextParagraph, source, getMainPart, getElementWithFixedAttributeOnly, getExistingAttribute);
            }
        }

        [Fact]
        public void SetAttributePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                SetAttributeOnFile(testfile, getSlidePart, getSlideTextParagraph, source, getSlidePart, getElementWithFixedAttributeOnly, getExistingAttribute);
            }
        }

        [Fact]
        public void SetAttributeXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                SetAttributeOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getElementWithFixedAttributeOnly, getExistingAttribute);
            }
        }

        [Fact]
        public void SetAttributesTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                SetAttributesOnFile(testfile, getMainPart, getAnyElement, source, getMainPart, getElementWithoutAttributes);
                SetAttributesOnFile(testfile, getMainPart, getAnyElement, source, getMainPart, getElementWithAttributes);
            }
        }

        [Fact]
        public void SetAttributesPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                SetAttributesOnFile(testfile, getSlidePart, getAnyComposite, source, getSlidePart, getElementWithoutAttributes);
                SetAttributesOnFile(testfile, getSlidePart, getAnyComposite, source, getSlidePart, getElementWithFixedAttributeOnly);
            }
        }

        [Fact]
        public void SetAttributesXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                SetAttributesOnFile(testfile, getLastSheetPart, getAnyComposite, source, getLastSheetPart, getElementWithoutAttributes);
                SetAttributesOnFile(testfile, getLastSheetPart, getAnyComposite, source, getLastSheetPart, getElementWithFixedAttributeOnly);
            }
        }

        #endregion SetAttribute(OpenXmlAttribute)

        #region RemoveAttribute(localName, namespaceUri)

        [Fact]
        public void RemoveAttributeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithoutAttributes, getFixedAttribute);
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithAttributes, getExistingAttribute);
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithMixedAttribute, getExistingFixedAttribute);
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithMixedAttribute, getNonExistingFixedAttribute);
            }
        }

        [Fact]
        public void RemoveAttributePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                RemoveAttributeOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly, getExistingFixedAttribute);
            }
        }

        [Fact]
        public void RemoveAttributeXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                RemoveAttributeOnFile(testfile, getLastSheetPart, getElementWithFixedAttributeOnly, getExistingFixedAttribute);
            }
        }

        #endregion RemoveAttribute(localName, namespaceUri)

        #region ClearAllAttributes

        [Fact]
        public void ClearAllAttributesTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithAttributes);
            }
        }

        [Fact]
        public void ClearAllAttributesPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly);
            }
        }

        [Fact]
        public void ClearAllAttributesXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                ClearAllAttributesOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, getLastSheetPart, getElementWithFixedAttributeOnly);
            }
        }

        #endregion ClearAllAttributes

        #region AddNamespaceDeclaration
        [Fact]
        public void AddNamespaceDeclarationTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                AddNamespaceDeclarationOnFile(testfile, getMainPart, getElementWithNamespaceDeclarations, source, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getExistingNamespaceDeclaration);
                AddNamespaceDeclarationOnFile(testfile, getMainPart, getElementWithoutNamespaceDeclarations, source, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getExistingNamespaceDeclaration);
            }
        }
        #endregion AddNamespaceDeclaration

        #region NamespaceDeclarations
        [Fact]
        public void NamespaceDeclarationsTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                NamespaceDeclarationsOnFile(testfile, getAnyOpenXmlPart, getElementWithNamespaceDeclarations);
                NamespaceDeclarationsOnFile(testfile, getAnyOpenXmlPart, getElementWithoutNamespaceDeclarations);
            }
        }
        #endregion NamespaceDeclarations

        #region RemoveNamespaceDeclaration
        [Fact]
        public void RemoveNamespaceDeclarationTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                RemoveNamespaceDeclarationOnFile(testfile, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getExistingNamespaceDeclaration);
                RemoveNamespaceDeclarationOnFile(testfile, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getNonExistingNamespaceDeclaration);
                RemoveNamespaceDeclarationOnFile(testfile, getAnyOpenXmlPart, getElementWithoutNamespaceDeclarations, getNonExistingNamespaceDeclaration);
            }
        }
        #endregion RemoveNamespaceDeclaration

        #region OuterXml

        [Fact]
        public void GetOuterXmlTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutChildren);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithChildren);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void GetOuterXmlPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutChildren);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithChildren);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void GetOuterXmlXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithChildren);
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion OuterXml

        #region Clone

        [Fact]
        public void CloneTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                CloneOnFile(testfile, getMainPart, getElementWithoutChildren);
                CloneOnFile(testfile, getMainPart, getElementWithoutAttributes);
                CloneOnFile(testfile, getMainPart, getElementWithChildren);
                CloneOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void ClonePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                CloneOnFile(testfile, getSlidePart, getElementWithoutChildren);
                CloneOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                CloneOnFile(testfile, getSlidePart, getElementWithChildren);
                CloneOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void CloneXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                CloneOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                CloneOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                CloneOnFile(testfile, getLastSheetPart, getElementWithChildren);
                CloneOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void CloneNodeFalseTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph", true, "empty.docx", f => f.IsWordprocessingFile(), 1);

            foreach (var testfile in testfiles)
            {
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void CloneNodeFalsePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void CloneNodeFalseXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion Clone

        #region InnerXml

        [Fact]
        public void GetInnerXmlTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                GetInnerXmlOnFile(testfile, getMainPart, getAnyLeaf);
                GetInnerXmlOnFile(testfile, getMainPart, getAnyComposite);
            }
        }

        [Fact]
        public void GetInnerXmlPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                GetInnerXmlOnFile(testfile, getSlidePart, getAnyLeaf);
                GetInnerXmlOnFile(testfile, getSlidePart, getAnyComposite);
            }
        }

        [Fact]
        public void GetInnerXmlXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                GetInnerXmlOnFile(testfile, getLastSheetPart, getAnyLeaf);
                GetInnerXmlOnFile(testfile, getLastSheetPart, getAnyComposite);
            }
        }

        [Fact]
        public void SetInnerXmlPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren, source, getSlidePart, getElementWithAttributesOnly);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren, source, getSlidePart, getElementWithChildren);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithChildren, source, getSlidePart, getElementWithAttributesAndChildren);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren, source, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void SetInnerXmlXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\spreadsheet")
                .Where(f => f.IsSpreadsheetFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithoutChildren, source, getLastSheetPart, getElementWithAttributesOnly);
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithoutChildren, source, getLastSheetPart, getElementWithChildren);
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithChildren, source, getLastSheetPart, getElementWithAttributesAndChildren);
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren, source, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion InnerXml

        #region WriteTo

        [Fact]
        public void WriteToTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            foreach (var testfile in testfiles)
            {
                WriteToOnFile(testfile, getMainPart, getElementWithoutAttributes);
                WriteToOnFile(testfile, getMainPart, getElementWithoutChildren);
                WriteToOnFile(testfile, getMainPart, getElementWithChildren);
                WriteToOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void WriteToPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            foreach (var testfile in testfiles)
            {
                WriteToOnFile(testfile, getSlidePart, getSlideTextBody);
                WriteToOnFile(testfile, getSlidePart, getElementWithoutChildren);
                WriteToOnFile(testfile, getSlidePart, getElementWithChildren);
                WriteToOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Fact]
        public void WriteToXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile());

            foreach (var testfile in testfiles)
            {
                WriteToOnFile(testfile, getLastSheetPart, getSheetData);
                WriteToOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                WriteToOnFile(testfile, getLastSheetPart, getElementWithChildren);
                WriteToOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion WriteTo

        #region Events

        //Events in CTP1
        //public event EventHandler<ElementEventArgs> ElementInserted;
        //public event EventHandler<ElementEventArgs> ElementInserting;
        //public event EventHandler<ElementEventArgs> ElementRemoved;
        //public event EventHandler<ElementEventArgs> ElementRemoving;

        [Fact]
        public void EventAppendChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            PendTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getBodyNoEvent, PendType.Append);
        }

        [Fact]
        public void EventPreppendChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            PendTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getBodyNoEvent, PendType.Prepend);
        }

        [Fact]
        public void EventAppendArrayTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            AppendCollectionOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, AppendCollectionType.Array);
        }

        [Fact]
        public void EventAppendIEnumerableTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            AppendCollectionOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getAnyCompositeNoEvent, AppendCollectionType.IEnumerable);
        }

        [Fact]
        public void EventInsertBeforeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            {
                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getLastChild, InsertType.Before);
            }
        }

        [Fact]
        public void EventInsertAfterTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            {
                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getLastChild, InsertType.After);
                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getFirstChild, InsertType.After);
            }
        }

        [Fact]
        public void EventInsertAtTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            {
                InsertAtOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, InsertAtPosition.AnyValid);
            }
        }

        [Fact]
        public void EventInsertRelativeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            {
                InsertRelativeOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, InsertRel.BeforeSelf);
            }
        }

        [Fact]
        public void EventRemoveAllChildrenTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            {
                RemoveAllChildrenOnFile(testfile, getMainPart, getElementWithChildren4Event);
            }
        }

        [Fact]
        public void EventRemoveAllTypedChildrenTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            {
                RemoveAllTypedChildrenOnFile(testfile, getMainPart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, getMainPart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlLeafElement));
            }
        }

        [Fact]
        public void EventRemoveChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            RemoveChildOnFile(testfile, getMainPart, getBody4Event, getAnyChild);
        }

        [Fact]
        public void EventRemoveTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            RemoveOnFile(testfile, getAnyOpenXmlPart, getAnyChild4Event);
            RemoveOnFile(testfile, getAnyOpenXmlPart, getAnyLeaf4Event);
            RemoveOnFile(testfile, getAnyOpenXmlPart, getAnyComposite4Event);
        }

        [Fact]
        public void EventReplaceChildTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyLeafChild4Event = e => getAnyLeafChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyCompositeChild4Event = e => getAnyCompositeChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyChildNoEvent = e => getAnyChild(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyLeafChildNoEvent = e => getAnyLeafChild(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyCompositeChildNoEvent = e => getAnyCompositeChild(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyWithLeafAndCompositeElementNoEvent = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            ReplaceChildOnFile(testfile, getMainPart, getBody, getAnyChild4Event, source, getMainPart, getAnyChildNoEvent, typeof(OpenXmlElement));
        }

        [Fact]
        public void EventGetAttributeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            GetAttributeOnFile(testfile, getMainPart, getElementWithAttributesNoEvent);
        }

        [Fact]
        public void EventGetAttributesTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            foreach (var testfile in testfiles)
            {
                GetAttributesOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
                GetAttributesOnFile(testfile, getMainPart, getElementWithAttributesNoEvent);
            }
        }

        [Fact]
        public void EventSetAttributeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            SetAttributeOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithAttributesNoEvent, getExistingAttribute);
        }

        [Fact]
        public void EventSetAttributesTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            SetAttributesOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithoutAttributesNoEvent);
            SetAttributesOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithFixedAttributeOnlyNoEvent);
            SetAttributesOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithMixedAttributeNoEvent);
        }

        //public void RemoveAttribute(string localName, string namespaceUri)
        [Fact]
        public void EventRemoveAttributeTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            foreach (var testfile in testfiles)
            {
                RemoveAttributeOnFile(testfile, getAnyOpenXmlPart, getElementWithAttributesNoEvent, getExistingAttribute);
            }
        }

        [Fact]
        public void EventClearAllAttributesTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            foreach (var testfile in testfiles)
            {
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithFixedAttributeOnlyNoEvent);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithExtendedAttributeOnlyNoEvent);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithMixedAttributeNoEvent);
            }
        }

        [Fact]
        public void EventGetOuterXmlTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
            GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
            GetOuterXmlOnFile(testfile, getMainPart, getElementWithChildrenNoEvent);
            GetOuterXmlOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventCloneTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            CloneOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
            CloneOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
            CloneOnFile(testfile, getMainPart, getElementWithChildrenNoEvent);
            CloneOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventCloneNodeFalseTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
            CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesOnlyNoEvent);
            CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
            CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventGetInnerXmlTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getAnyLeafNoEvent = e => getAnyLeaf(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            GetInnerXmlOnFile(testfile, getMainPart, getAnyLeafNoEvent);
            GetInnerXmlOnFile(testfile, getMainPart, getAnyCompositeNoEvent);
        }

        [Fact]
        public void EventSetInnerXmlTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getElementWithAttributesAndChildren4Event = e => getElementWithAttributesAndChildren(e).SetEventHandler(validReplaceEventHandler);

            GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            SetInnerXmlOnFile(testfile, getMainPart, getElementWithAttributesAndChildren4Event, source, getMainPart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventWriteToTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            WriteToOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
            WriteToOnFile(testfile, getMainPart, getElementWithChildrenNoEvent);
            WriteToOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
        }

        #endregion Events

        #region PPT Events

        [Fact]
        public void EventAppendChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            PendTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextBodyNoEvent, PendType.Append);
        }

        [Fact]
        public void EventPreppendChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            PendTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextBodyNoEvent, PendType.Prepend);
        }

        [Fact]
        public void EventAppendArrayPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, AppendCollectionType.Array);
        }

        [Fact]
        public void EventAppendIEnumerablePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getAnyCompositeNoEvent, AppendCollectionType.IEnumerable);

        }

        [Fact]
        public void EventInsertBeforePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getFirstChild, InsertType.Before);
            InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getLastChild, InsertType.Before);
        }

        [Fact]
        public void EventInsertAfterPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getLastChild, InsertType.After);
            InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getFirstChild, InsertType.After);
        }

        [Fact]
        public void EventInsertAtPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AnyValid);
            InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AsFirst);
            InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.NextToFirst);
            InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.NextToLast);
            InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AsLast);
        }

        [Fact]
        public void EventInertRelativePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
            GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertRel.AfterSelf);
            InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertRel.BeforeSelf);
        }

        [Fact]
        public void EventRemoveAllChildrenPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithChildren4Event);
            RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithoutChildren4Event);
        }

        [Fact]
        public void EventRemoveAllTypedChildrenPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlCompositeElement));
            RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlLeafElement));
        }

        [Fact]
        public void EventRemoveChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody4Event, getFirstChild);
            RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody4Event, getAnyChild);
            RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody4Event, getLastChild);
        }

        [Fact]
        public void EventRemovePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
            GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

            var testfile = testfiles.FirstOrDefault();
            RemoveOnFile(testfile, getSlidePart, getSlideTextBody4Event);
            RemoveOnFile(testfile, getSlidePart, getAnyChild4Event);
            RemoveOnFile(testfile, getSlidePart, getAnyLeaf4Event);
            RemoveOnFile(testfile, getSlidePart, getAnyComposite4Event);
        }

        [Fact]
        public void EventReplaceChildPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyLeafChild4Event = e => getAnyLeafChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyCompositeChild4Event = e => getAnyCompositeChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyChildNoEvent = e => getAnyChild(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyLeafChildNoEvent = e => getAnyLeafChild(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyCompositeChildNoEvent = e => getAnyCompositeChild(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyWithLeafAndCompositeElementNoEvent = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            ReplaceChildOnFile(testfile, getSlidePart, getSlideTextBody, getAnyChild4Event, source, getSlidePart, getAnyChildNoEvent, typeof(OpenXmlElement));
            ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyCompositeChild4Event, source, getSlidePart, getAnyChildNoEvent, typeof(OpenXmlCompositeElement));
            ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyLeafChild4Event, source, getSlidePart, getAnyChildNoEvent, typeof(OpenXmlLeafElement));
        }

        [Fact]
        public void EventGetAttributePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            GetAttributeOnFile(testfile, getSlidePart, getElementWithAttributesNoEvent);
        }

        [Fact]
        public void EventGetAttributesPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            GetAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly);
        }

        [Fact]
        public void EventSetAttributePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            SetAttributeOnFile(testfile, getSlidePart, getAnyCompositeNoEvent, source, getSlidePart, getElementWithAttributesNoEvent, getExistingAttribute);
            SetAttributeOnFile(testfile, getSlidePart, getSlideTextParagraphNoEvent, source, getSlidePart, getElementWithFixedAttributeOnlyNoEvent, getExistingAttribute);
        }

        [Fact]
        public void EventSetAttributesPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            SetAttributesOnFile(testfile, getSlidePart, getAnyCompositeNoEvent, source, getMainPart, getElementWithoutAttributesNoEvent);
            SetAttributesOnFile(testfile, getSlidePart, getAnyCompositeNoEvent, source, getMainPart, getElementWithFixedAttributeOnlyNoEvent);
        }

        [Fact]
        public void EventRemoveAttributePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            RemoveAttributeOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly, getExistingFixedAttribute);
        }

        [Fact]
        public void EventClearAllAttributesPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
            ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnlyNoEvent);
        }

        [Fact]
        public void EventGetOuterXmlPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
            GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
            GetOuterXmlOnFile(testfile, getSlidePart, getElementWithChildrenNoEvent);
            GetOuterXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventClonePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            CloneOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
            CloneOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
            CloneOnFile(testfile, getSlidePart, getElementWithChildrenNoEvent);
            CloneOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventCloneNodeFalsePPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
            CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesOnlyNoEvent);
            CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
            CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventGetInnerXmlPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getAnyLeafNoEvent = e => getAnyLeaf(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            GetInnerXmlOnFile(testfile, getSlidePart, getAnyLeaf);
            GetInnerXmlOnFile(testfile, getSlidePart, getAnyComposite);
        }

        [Fact]
        public void EventSetInnerXmlPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\presentation")
                .Where(f => f.IsPresentationFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validReplaceEventHandler);
            GetTargetElement getElementWithAttributesAndChildren4Event = e => getElementWithAttributesAndChildren(e).SetEventHandler(validReplaceEventHandler);

            GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren4Event, source, getSlidePart, getElementWithAttributesOnlyNoEvent);
            SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren4Event, source, getSlidePart, getElementWithChildrenNoEvent);
            SetInnerXmlOnFile(testfile, getSlidePart, getElementWithChildren4Event, source, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
            SetInnerXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren4Event, source, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
        }

        [Fact]
        public void EventWriteToPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile());

            GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
            GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

            var testfile = testfiles.FirstOrDefault();
            WriteToOnFile(testfile, getSlidePart, getSlideTextBodyNoEvent);
            WriteToOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
            WriteToOnFile(testfile, getSlidePart, getElementWithChildrenNoEvent);
            WriteToOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
        }

        #endregion PPT Events

        #region Annotation

        // AddAnnotation
        // Annotation(Type)
        // Annotation<T>()
        // Annotations(Type)
        // Annotations<T>()
        // RemoveAnnotations(Type)
        // RemoveAnnotations<T>()

        [Fact]
        public void AnnotationTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            var testfile = testfiles.FirstOrDefault();
            {
                Log.BeginGroup(testfile.Name);

                using (OpenXmlPackage target = testfile.OpenPackage(true))
                {
                    Log.Comment("Loading target MainPart...");
                    OpenXmlPart hostPart = target.MainPart();

                    if (!hostPart.IsReflectable())
                        Log.Warning("Current hostPart is NOT reflectable.");
                    AnnotationType(hostPart, getBody);
                    AnnotationT(hostPart, getBody);
                    AnnotationArray(hostPart, getBody);
                    AnnotationCollection(hostPart, getBody);
                }
            }
        }

        [Fact]
        public void AnnotationPPTTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"presentation\smallset")
               .Where(f => f.IsPresentationFile());

            var testfile = testfiles.FirstOrDefault();
            {
                Log.BeginGroup(testfile.Name);

                using (OpenXmlPackage target = testfile.OpenPackage(true))
                {
                    Log.Comment("Loading target MainPart...");
                    OpenXmlPart hostPart = getSlidePart(target);

                    if (!hostPart.IsReflectable())
                        Log.Warning("Current hostPart is NOT reflectable.");
                    AnnotationType(hostPart, getSlideTextBody);
                    AnnotationT(hostPart, getSlideTextBody);
                    AnnotationArray(hostPart, getSlideTextBody);
                    AnnotationCollection(hostPart, getSlideTextBody);
                }
            }
        }

        [Fact]
        public void AnnotationXSLTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"spreadsheet\smallset")
              .Where(f => f.IsSpreadsheetFile());

            var testfile = testfiles.FirstOrDefault();
            {
                Log.BeginGroup(testfile.Name);

                using (OpenXmlPackage target = testfile.OpenPackage(true))
                {
                    Log.Comment("Loading target MainPart...");
                    OpenXmlPart hostPart = getLastSheetPart(target);

                    if (!hostPart.IsReflectable())
                        Log.Warning("Current hostPart is NOT reflectable.");
                    AnnotationType(hostPart, getSheetData);
                    AnnotationT(hostPart, getSheetData);
                    AnnotationArray(hostPart, getSheetData);
                    AnnotationCollection(hostPart, getSheetData);
                }
            }
        }

        #endregion Annotation

        #region InvalidOperations

        [Fact]
        public void AppendArrayWithElementsOnTree()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile())
               .FirstOrDefault().OpenPackage(true).MainPart().RootElement()
               .InvalidOperation<InvalidOperationException>(Log, e =>
               {
                   getFirstChild(e).AppendChild<OpenXmlElement>(
                       GetTestFiles(@"asSources\wordprocessing")
                       .Where(f => f.IsWordprocessingFile()).FirstOrDefault()
                       .OpenPackage(false).MainPart().RootElement().Elements().FirstOrDefault());
               });
        }

        [Fact]
        public void AppentArryWithElementsOnTreePPT()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            CopyTestFiles(@"presentation\smallset")
                .Where(f => f.IsPresentationFile())
                .FirstOrDefault().OpenPackage(true).MainPart().RootElement()
                .InvalidOperation<InvalidOperationException>(Log, e =>
                {
                    getFirstChild(e).AppendChild<OpenXmlElement>(
                        GetTestFiles(@"asSources\presentation")
                        .Where(f => f.IsPresentationFile()).FirstOrDefault()
                        .OpenPackage(false).MainPart().RootElement().Elements().FirstOrDefault());
                });
        }

        [Fact]
        public void AppentArryWithElementsOnTreeXSLT()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            CopyTestFiles(@"spreadsheet\smallset")
                .Where(f => f.IsSpreadsheetFile())
                .FirstOrDefault().OpenPackage(true).MainPart().RootElement()
                .InvalidOperation<InvalidOperationException>(Log, e =>
                {
                    getFirstChild(e).AppendChild<OpenXmlElement>(
                        GetTestFiles(@"asSources\spreadsheet")
                        .Where(f => f.IsSpreadsheetFile()).FirstOrDefault()
                        .OpenPackage(false).MainPart().RootElement().Elements().FirstOrDefault());
                });
        }

        #endregion InvalidOperations

        #region Bug Regression

        [Fact]
        public void Bug242463_SetRootXmlTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            FileInfo source = GetTestFiles(@"asSources\wordprocessing")
                .Where(f => f.IsWordprocessingFile()).FirstOrDefault();
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            using (var testpackage = testfiles.FirstOrDefault().OpenPackage(true))
            {
                testpackage.MainPart().RootElement()
                    .ValidOperation(Log,
                    root =>
                    {
                        root = new Document(source.OpenPackage(false).MainPart().RootElement().OuterXml);
                        (root as Document).Save(testpackage.MainPart() as MainDocumentPart);
                    });
            }
        }

        [Fact]
        public void Bug247894_LoadDocumentTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"wordprocessing\paragraph")
               .Where(f => f.IsWordprocessingFile());

            using (var testpackage = testfiles.FirstOrDefault().OpenPackage(true))
            {
                testpackage.MainPart().RootElement()
                    .ValidOperation(Log,
                    root =>
                    {
                        var document = root as Document;
                    });
            }
        }

        [Fact]
        public void Bug242602_UnknownElement_Text()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"ForTestCase", true, "*.docx", f => f.IsOpenXmlFile() && f.Name.EndsWith(@"Bug242602_SDT - unknown.docx"));

            foreach (var testfile in testfiles)
            {
                Log.BeginGroup(testfile.FullName);

                using (var testpackage = testfile.OpenPackage(true))
                {
                    var unknowns = testpackage.DescendantParts()
                        .Where(p => p.IsReflectable())
                        .SelectMany(p => p.RootElement().Descendants<OpenXmlUnknownElement>());
                    foreach (var unknown in unknowns)
                    {
                        Log.Comment("UnknownElement: {0} - Text: {1}@{2}.", unknown.GetType().Name, unknown.Text, unknown.Path());
                    }
                }
                Log.Pass("Text of UnknownElement has been implemented and executed without errors.");
            }
        }

        [Fact]
        public void Bug201775_lockedCanvas()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfile = CopyTestFiles(@"ForTestCase", true, "Bug201775_testfile.docx", f => f.IsOpenXmlFile()).FirstOrDefault();

            using (var package = testfile.OpenPackage(false))
            {
                var doc = (package as WordprocessingDocument).MainDocumentPart.Document;
                // DocumentFormat.OpenXml.Drawing.LockedCanvas
                var element = doc.Descendants().Where(e => e.LocalName == "lockedCanvas").FirstOrDefault();
                if (element == null)
                {
                    Log.Warning("No lockedCanvas element found in specified document.");
                    return;
                }
                if (element is OpenXmlUnknownElement)
                    Log.Fail("Element {0} is loaded as OpenXmlUnknownElement, instead of expected LockedCanvasElement.", element.Path());
                else
                    Log.Pass("Element {0} is loaded as strongly type {1}.", element.Path(), element.GetType().FullName);
            }
        }

        [Fact]
        // [Description("Office14: 687665")]
        public void Bug687665_NewElementFromOuterXmlWithACB()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                Log.Comment("Constructing Paragraph with OuterXml...");
                string xml = "<w:p xmlns:w14=\"http://schemas.microsoft.com/office/word/2010/wordml\" mc:Ignorable=\"w14\" " +
                    "xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" xmlns:v=\"urn:schemas-microsoft-com:vml\" " +
                "xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidR=\"00A35C47\" w14:paraId=\"017B6C57\" w14:editId=\"32F17AD3\" >" +
                "<w:r><mc:AlternateContent>" +
                "<mc:Choice Requires=\"w14\"><w:drawing><v:rect/></w:drawing></mc:Choice>" +
                "<mc:Fallback><w:pict><v:textbox/></w:pict></mc:Fallback>" +
                "</mc:AlternateContent></w:r>" +
                "</w:p>";
                var p = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(xml);
                Log.Comment("Constructed Paragraph without issues.");

                Log.Comment("Accessing first child of Paragraph...");
                var r = p.FirstChild;
                Log.Pass("No NullReferenceException thrown out anymore.");
            }
            catch (NullReferenceException ex)
            {
                Log.Fail("{0} thrown out unexpected.\n{1}", ex.GetType().FullName, ex.ToString());
            }
        }

        [Fact]
        // [Description("Office14: 680607")]
        public void Bug680607_SaveOutWord14Beta2File()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfile = CopyTestFiles("BugRegression", true, "680607.HelloO14.docx", f => f.IsWordprocessingFile())
                .FirstOrDefault();

            using (var Package = testfile.OpenPackage(true))
            {
                //<w:fonts xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
                //xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" 
                //xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" 
                //xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" mc:Ignorable="w14">
                //   ....
                //</w:fonts>

                var fontTablePart = (Package as WordprocessingDocument).MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                var fonts = fontTablePart.Fonts;
                // check if mc:Ignorable="w14" and if there're attribute named xmlns:w14
                var ignorable = fonts.GetAttributes().Where(a => a.LocalName == "Ignorable" && a.Value == "w14").FirstOrDefault();
                if (ignorable == default(OpenXmlAttribute))
                    Log.Fail("No mc:Ignorable attribute with value {0} exists", "w14");
                else
                    Log.Pass("mc:Ignorable attribute with value {0} exists", "w14");

                var w14ns = fonts.OuterXml.Contains(@"xmlns:w14=""http://schemas.microsoft.com/office/word/2010/wordml");
                if (!w14ns)
                    Log.Fail("No w14 namespace declaration found.");
                else
                    Log.Pass("w14 namespace declaration found on fonts element.");
            }

            using (var Package = testfile.OpenPackage(false))
            {
                //<w:fonts mc:Ignorable="w14" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main">
                //   ....
                //</w>
                var fontTablePart = (Package as WordprocessingDocument).MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                var fonts = fontTablePart.Fonts;
                // check if mc:Ignorable="w14" and if there're attribute named xmlns:w14
                var ignorable = fonts.GetAttributes().Where(a => a.LocalName == "Ignorable" && a.Value == "w14").FirstOrDefault();
                if (ignorable == default(OpenXmlAttribute))
                    Log.Fail("No mc:Ignorable attribute with value {0} exists", "w14");
                else
                    Log.Pass("mc:Ignorable attribute with value {0} exists", "w14");

                var w14ns = fonts.OuterXml.Contains(@"xmlns:w14=""http://schemas.microsoft.com/office/word/2010/wordml");
                if (!w14ns)
                    Log.Fail("No w14 namespace declaration found.");
                else
                    Log.Pass("w14 namespace declaration found on fonts element.");
            }
        }

        [Fact]
        // [Description("671248")]
        public void Bug671248_ExtendedAndMcAttributesAfterConstructingWithOuterXml()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            string paragraphXml = "<w:p xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"w14\" "
                + "xmlns:w14=\"http://schemas.microsoft.com/office/word/2007/5/30/wordml\" "
                + "xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" "
                + "w14:paraId=\"017B6C57\" w14:editId=\"32F17AD3\" w:rsidR=\"00A35C47\"  />";
            var p = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(paragraphXml);
            Assert.NotNull(p.MCAttributes);
            Log.VerifyValue(3, p.NamespaceDeclarations.Count(), "mc, w14, w");    // mc, w14, w
            Log.VerifyValue(4, p.GetAttributes().Count, "w:rsidR, w14:paraId, w14:editId, mc:Ignorable");        // w:rsidR, w14:paraId, w14:editId, mc:Ignorable
            Log.VerifyValue(2, p.ExtendedAttributes.Count(), "w14:paraId, w14:editId");   // w14:paraId, w14:editId
        }

        #endregion Bug Regression
    }
}