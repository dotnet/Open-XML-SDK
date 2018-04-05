// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlCompositeElementTestClass : OpenXmlDomTestBase
    {
        public OpenXmlCompositeElementTestClass(ITestOutputHelper output)
            : base(output)
        {
        }

        public static IEnumerable<object[]> GetPowerPointDocuments()
        {
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charspptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInbyletterpptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withShadow_100charsAnimationFlyInallatoncepptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withShadow_100charsAnimationFlyInbyletterpptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withShadow_100charspptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withShadow_200charsAnimationFlyInallatoncepptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withShadow_200charspptx };
        }

        public static IEnumerable<object[]> GetSpreadsheetDocuments()
        {
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SharedWorkbook };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SheetData };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SheetViewsFSB };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SST };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.Styles };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.table };
        }

        public static IEnumerable<object[]> GetWordprocessingDocuments()
        {
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AutoSpaceDE };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.empty };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.Para };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.ParagraphDoc };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.ParagraphAlignment };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.ParagraphLineSpace };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.ParagraphSpaceInLine };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.SectionBreak };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.Temp };
        }

        #region Elements

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        [Theory]
        public void DummyObjectForEmptyChildElementsTest(string path)
        {
            using (var file = TestAssets.OpenFile(path, false))
            using (var package = file.Open(false))
            {
                var part = package.DescendantParts().Where(p => p.IsReflectable()).FirstOrDefault();
                var dom = part.RootElement;
                var e1 = dom.Descendants().Where(d => !d.HasChildren).PickSecond();
                Assert.NotNull(e1.ChildElements);
                var e2 = dom.Descendants().Where(d => !d.HasChildren).PickFirst(d => d != e1);
                Assert.NotNull(e2.ChildElements);
                Assert.Equal(e1.ChildElements, e2.ChildElements);
            }
        }

        #endregion Elements

        #region Append Collection

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void AppendArrayPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextBody, AppendCollectionType.Array);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void AppendArrayXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, AppendCollectionType.Array);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void AppendIEnumerableTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, getMainPart, getBody, source, getMainPart, getAnyComposite, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void AppendIEnumerablePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getAnyComposite, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void AppendIEnumerableXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, AppendCollectionType.IEnumerable);
            }
        }

        #endregion Append Collection

        #region Pend Operations

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void AppendChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getBody, PendType.Append);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void AppendChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextBody, PendType.Append);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void AppendChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, PendType.Append);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void PreppendChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getBody, PendType.Prepend);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void PreppendChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextBody, PendType.Prepend);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void PreppendChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, getFirstSheetPart, getSheetData, source, getFirstSheetPart, getSheetData, PendType.Prepend);
            }
        }

        #endregion Pend Operations

        #region Insert Before/After

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertBeforeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getLastChild, InsertType.Before);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertBeforePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getLastChild, InsertType.Before);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertBeforeXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getLastChild, InsertType.Before);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertAfterTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getLastChild, InsertType.After);
                InsertTestOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, getFirstChild, InsertType.After);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertAfterPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getFirstChild, InsertType.After);
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, getLastChild, InsertType.After);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertAfterXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getFirstChild, InsertType.After);
                InsertTestOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, getLastChild, InsertType.After);
            }
        }

        #endregion Insert Before/After

        #region InsertAt

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertAtTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertAtOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, InsertAtPosition.AnyValid);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertAtPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.AnyValid);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.AsFirst);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.NextToFirst);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.NextToLast);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertAtPosition.AsLast);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertAtXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
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

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertRelativeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertRelativeOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getMainPart, getBody, source, getMainPart, getTextParagraph, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertRelativePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody, source, getSlidePart, getSlideTextParagraph, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertRelativeXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertRelativeOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getFirstSheetPart, getSheetData, source, getLastSheetPart, getSheetDataRow, InsertRel.BeforeSelf);
            }
        }

        #endregion Insert Before/After Self

        #region RemoveAllChildren

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveAllChildrenTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllChildrenOnFile(testfile, getMainPart, getElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, getMainPart, getElementWithChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveAllChildrenPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithChildren);
                RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, getSlidePart, getFirstChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveAllChildrenXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllChildrenOnFile(testfile, getLastSheetPart, getElementWithChildren);
                RemoveAllChildrenOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, getLastSheetPart, getFirstChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveAllTypedChildrenTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllTypedChildrenOnFile(testfile, getMainPart, getAnyWithLeafAndCompositeChild, typeof(OpenXmlCompositeElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveAllTypedChildrenPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveAllTypedChildrenXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllTypedChildrenOnFile(testfile, getLastSheetPart, getAnyWithCompositeChild, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, getLastSheetPart, getAnyWithLeafChild, typeof(OpenXmlLeafElement));
            }
        }

        #endregion RemoveAllChildren

        #region RemoveChild

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveChildOnFile(testfile, getMainPart, getElementWithChildren, getAnyChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody, getFirstChild);
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody, getAnyChild);
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody, getLastChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveChildOnFile(testfile, getLastSheetPart, getSheetData, getAnyChild);
            }
        }

        #endregion RemoveChild

        #region Remove

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveOnFile(testfile, getMainPart, getAnyLeaf);
                RemoveOnFile(testfile, getMainPart, getAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemovePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveOnFile(testfile, getSlidePart, getSlideTextBody);
                RemoveOnFile(testfile, getSlidePart, getAnyLeaf);
                RemoveOnFile(testfile, getSlidePart, getAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveOnFile(testfile, getLastSheetPart, getSheetData);
                RemoveOnFile(testfile, getLastSheetPart, getAnyLeaf);
                RemoveOnFile(testfile, getLastSheetPart, getAnyComposite);
            }
        }

        #endregion Remove

        #region ReplaceChild<T>(OpenXmlElement, T)

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void ReplaceChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ReplaceChildOnFile(testfile, getMainPart, getBody, getAnyChild, source, getMainPart, getAnyChild, typeof(OpenXmlElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void ReplaceChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ReplaceChildOnFile(testfile, getSlidePart, getSlideTextBody, getAnyChild, source, getSlidePart, getAnyChild, typeof(OpenXmlElement));
                ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyCompositeChild, source, getSlidePart, getAnyChild, typeof(OpenXmlCompositeElement));
                ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyLeafChild, source, getSlidePart, getAnyChild, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void ReplaceChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
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
            Log.Comment("Assigned new LocalName: {0} with ByValue: {1} and comparing it with original w:rsidR", wrsidP.LocalName, wrsidP.Value);
            Log.VerifyFalse(wrsidP == wrsidR, "The assigned OpenXmlAttribute variable IS equal to original one.");
            Log.VerifyFalse(object.ReferenceEquals(wrsidP, wrsidR), "The assigned OpenXmlAttribute variable IS reference equal to original one.");
        }

        [Fact]
        public void OpenXmlAttributeEqualTest()
        {
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

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void DummyIEnumerableForExtendedAttributesTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (var package = testfile.Open(false))
            {
                var part = package.DescendantParts().Where(p => p.IsReflectable()).FirstOrDefault();
                var dom = part.RootElement;
                var e1 = dom.Descendants().Where(d => d.ExtendedAttributes.Count() == 0).PickSecond();

                Assert.NotNull(e1.ExtendedAttributes);

                var e2 = dom.Descendants().Where(d => d.ExtendedAttributes.Count() == 0).PickFirst(d => d != e1);

                Assert.NotNull(e2.ExtendedAttributes);
                Assert.Equal(e1.ExtendedAttributes, e2.ExtendedAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void GetAttributeTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributeOnFile(testfile, getMainPart, getElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributeOnFile(testfile, getSlidePart, getElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetAttributeXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributeOnFile(testfile, getLastSheetPart, getElementWithAttributes);
            }
        }

        #endregion GetAttribute

        #region GetAttributes

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void GetAttributesTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributesOnFile(testfile, getMainPart, getElementWithoutAttributes);
                GetAttributesOnFile(testfile, getMainPart, getElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributesOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                GetAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetAttributesXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributesOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                GetAttributesOnFile(testfile, getLastSheetPart, getElementWithFixedAttributeOnly);
            }
        }

        #endregion GetAttributes

        #region SetAttribute(OpenXmlAttribute)

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void SetAttributeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributeOnFile(testfile, getMainPart, getTextParagraph, source, getMainPart, getElementWithFixedAttributeOnly, getExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void SetAttributePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributeOnFile(testfile, getSlidePart, getSlideTextParagraph, source, getSlidePart, getElementWithFixedAttributeOnly, getExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void SetAttributeXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributeOnFile(testfile, getLastSheetPart, getSheetData, source, getLastSheetPart, getElementWithFixedAttributeOnly, getExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void SetAttributesTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributesOnFile(testfile, getMainPart, getAnyElement, source, getMainPart, getElementWithoutAttributes);
                SetAttributesOnFile(testfile, getMainPart, getAnyElement, source, getMainPart, getElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void SetAttributesPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributesOnFile(testfile, getSlidePart, getAnyComposite, source, getSlidePart, getElementWithoutAttributes);
                SetAttributesOnFile(testfile, getSlidePart, getAnyComposite, source, getSlidePart, getElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void SetAttributesXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributesOnFile(testfile, getLastSheetPart, getAnyComposite, source, getLastSheetPart, getElementWithoutAttributes);
                SetAttributesOnFile(testfile, getLastSheetPart, getAnyComposite, source, getLastSheetPart, getElementWithFixedAttributeOnly);
            }
        }

        #endregion SetAttribute(OpenXmlAttribute)

        #region RemoveAttribute(localName, namespaceUri)

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveAttributeTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithoutAttributes, getFixedAttribute);
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithAttributes, getExistingAttribute);
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithMixedAttribute, getExistingFixedAttribute);
                RemoveAttributeOnFile(testfile, getMainPart, getElementWithMixedAttribute, getNonExistingFixedAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAttributeOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly, getExistingFixedAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveAttributeXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAttributeOnFile(testfile, getLastSheetPart, getElementWithFixedAttributeOnly, getExistingFixedAttribute);
            }
        }

        #endregion RemoveAttribute(localName, namespaceUri)

        #region ClearAllAttributes

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void ClearAllAttributesTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void ClearAllAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void ClearAllAttributesXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ClearAllAttributesOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, getLastSheetPart, getElementWithFixedAttributeOnly);
            }
        }

        #endregion ClearAllAttributes

        #region AddNamespaceDeclaration

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void AddNamespaceDeclarationTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AddNamespaceDeclarationOnFile(testfile, getMainPart, getElementWithNamespaceDeclarations, source, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getExistingNamespaceDeclaration);
                AddNamespaceDeclarationOnFile(testfile, getMainPart, getElementWithoutNamespaceDeclarations, source, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getExistingNamespaceDeclaration);
            }
        }
        #endregion AddNamespaceDeclaration

        #region NamespaceDeclarations

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void NamespaceDeclarationsTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                NamespaceDeclarationsOnFile(testfile, getAnyOpenXmlPart, getElementWithNamespaceDeclarations);
                NamespaceDeclarationsOnFile(testfile, getAnyOpenXmlPart, getElementWithoutNamespaceDeclarations);
            }
        }
        #endregion NamespaceDeclarations

        #region RemoveNamespaceDeclaration
        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveNamespaceDeclarationTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveNamespaceDeclarationOnFile(testfile, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getExistingNamespaceDeclaration);
                RemoveNamespaceDeclarationOnFile(testfile, getAnyOpenXmlPart, getElementWithNamespaceDeclarations, getNonExistingNamespaceDeclaration);
                RemoveNamespaceDeclarationOnFile(testfile, getAnyOpenXmlPart, getElementWithoutNamespaceDeclarations, getNonExistingNamespaceDeclaration);
            }
        }
        #endregion RemoveNamespaceDeclaration

        #region OuterXml

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void GetOuterXmlTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutChildren);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithChildren);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetOuterXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutChildren);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithChildren);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetOuterXmlXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithChildren);
                GetOuterXmlOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion OuterXml

        #region Clone

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void CloneTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneOnFile(testfile, getMainPart, getElementWithoutChildren);
                CloneOnFile(testfile, getMainPart, getElementWithoutAttributes);
                CloneOnFile(testfile, getMainPart, getElementWithChildren);
                CloneOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void ClonePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneOnFile(testfile, getSlidePart, getElementWithoutChildren);
                CloneOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                CloneOnFile(testfile, getSlidePart, getElementWithChildren);
                CloneOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void CloneXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                CloneOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                CloneOnFile(testfile, getLastSheetPart, getElementWithChildren);
                CloneOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.empty)]
        public void CloneNodeFalseTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void CloneNodeFalsePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void CloneNodeFalseXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion Clone

        #region InnerXml

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void GetInnerXmlTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetInnerXmlOnFile(testfile, getMainPart, getAnyLeaf);
                GetInnerXmlOnFile(testfile, getMainPart, getAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetInnerXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetInnerXmlOnFile(testfile, getSlidePart, getAnyLeaf);
                GetInnerXmlOnFile(testfile, getSlidePart, getAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetInnerXmlXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetInnerXmlOnFile(testfile, getLastSheetPart, getAnyLeaf);
                GetInnerXmlOnFile(testfile, getLastSheetPart, getAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void SetInnerXmlPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren, source, getSlidePart, getElementWithAttributesOnly);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren, source, getSlidePart, getElementWithChildren);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithChildren, source, getSlidePart, getElementWithAttributesAndChildren);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren, source, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void SetInnerXmlXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithoutChildren, source, getLastSheetPart, getElementWithAttributesOnly);
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithoutChildren, source, getLastSheetPart, getElementWithChildren);
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithChildren, source, getLastSheetPart, getElementWithAttributesAndChildren);
                SetInnerXmlOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren, source, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion InnerXml

        #region WriteTo

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void WriteToTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                WriteToOnFile(testfile, getMainPart, getElementWithoutAttributes);
                WriteToOnFile(testfile, getMainPart, getElementWithoutChildren);
                WriteToOnFile(testfile, getMainPart, getElementWithChildren);
                WriteToOnFile(testfile, getMainPart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void WriteToPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                WriteToOnFile(testfile, getSlidePart, getSlideTextBody);
                WriteToOnFile(testfile, getSlidePart, getElementWithoutChildren);
                WriteToOnFile(testfile, getSlidePart, getElementWithChildren);
                WriteToOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void WriteToXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                WriteToOnFile(testfile, getLastSheetPart, getSheetData);
                WriteToOnFile(testfile, getLastSheetPart, getElementWithoutChildren);
                WriteToOnFile(testfile, getLastSheetPart, getElementWithChildren);
                WriteToOnFile(testfile, getLastSheetPart, getElementWithAttributesAndChildren);
            }
        }

        #endregion WriteTo

        #region Events

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventAppendChildTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);

                PendTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getBodyNoEvent, PendType.Append);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventPreppendChildTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);

                PendTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getBodyNoEvent, PendType.Prepend);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventAppendArrayTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

                AppendCollectionOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, AppendCollectionType.Array);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventAppendIEnumerableTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);

                AppendCollectionOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getAnyCompositeNoEvent, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertBeforeTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getLastChild, InsertType.Before);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertAfterTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getLastChild, InsertType.After);
                InsertTestOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, getFirstChild, InsertType.After);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertAtTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertAtOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, InsertAtPosition.AnyValid);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertRelativeTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => getTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertRelativeOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getMainPart, getBody4Event, source, getMainPart, getTextParagraphNoEvent, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveAllChildrenTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validRemoveEventHandler);

                RemoveAllChildrenOnFile(testfile, getMainPart, getElementWithChildren4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveAllTypedChildrenTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(validRemoveEventHandler);

                RemoveAllTypedChildrenOnFile(testfile, getMainPart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, getMainPart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveChildTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

                RemoveChildOnFile(testfile, getMainPart, getBody4Event, getAnyChild);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => getBody(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

                RemoveOnFile(testfile, getAnyOpenXmlPart, getAnyChild4Event);
                RemoveOnFile(testfile, getAnyOpenXmlPart, getAnyLeaf4Event);
                RemoveOnFile(testfile, getAnyOpenXmlPart, getAnyComposite4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventReplaceChildTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
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

                ReplaceChildOnFile(testfile, getMainPart, getBody, getAnyChild4Event, source, getMainPart, getAnyChildNoEvent, typeof(OpenXmlElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventGetAttributeTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);

                GetAttributeOnFile(testfile, getMainPart, getElementWithAttributesNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventGetAttributesTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                GetAttributesOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
                GetAttributesOnFile(testfile, getMainPart, getElementWithAttributesNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventSetAttributeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                SetAttributeOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithAttributesNoEvent, getExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventSetAttributesTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                SetAttributesOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithoutAttributesNoEvent);
                SetAttributesOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithFixedAttributeOnlyNoEvent);
                SetAttributesOnFile(testfile, getMainPart, getAnyCompositeNoEvent, source, getMainPart, getElementWithMixedAttributeNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventRemoveAttributeTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                RemoveAttributeOnFile(testfile, getAnyOpenXmlPart, getElementWithAttributesNoEvent, getExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventClearAllAttributesTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithFixedAttributeOnlyNoEvent);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithExtendedAttributeOnlyNoEvent);
                ClearAllAttributesOnFile(testfile, getMainPart, getElementWithMixedAttributeNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventGetOuterXmlTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithChildrenNoEvent);
                GetOuterXmlOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventCloneTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                CloneOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
                CloneOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
                CloneOnFile(testfile, getMainPart, getElementWithChildrenNoEvent);
                CloneOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventCloneNodeFalseTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutAttributesNoEvent);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesOnlyNoEvent);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
                CloneNodeFalseOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventGetInnerXmlTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyLeafNoEvent = e => getAnyLeaf(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                GetInnerXmlOnFile(testfile, getMainPart, getAnyLeafNoEvent);
                GetInnerXmlOnFile(testfile, getMainPart, getAnyCompositeNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventSetInnerXmlTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validReplaceEventHandler);
                GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validReplaceEventHandler);
                GetTargetElement getElementWithAttributesAndChildren4Event = e => getElementWithAttributesAndChildren(e).SetEventHandler(validReplaceEventHandler);

                GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                SetInnerXmlOnFile(testfile, getMainPart, getElementWithAttributesAndChildren4Event, source, getMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventWriteToTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBodyNoEvent = e => getBody(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                WriteToOnFile(testfile, getMainPart, getElementWithoutChildrenNoEvent);
                WriteToOnFile(testfile, getMainPart, getElementWithChildrenNoEvent);
                WriteToOnFile(testfile, getMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        #endregion Events

        #region PPT Events

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventAppendChildPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);

                PendTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextBodyNoEvent, PendType.Append);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventPreppendChildPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);

                PendTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextBodyNoEvent, PendType.Prepend);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventAppendArrayPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

                AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, AppendCollectionType.Array);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventAppendIEnumerablePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);

                AppendCollectionOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getAnyCompositeNoEvent, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInsertBeforePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getLastChild, InsertType.Before);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInsertAfterPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getLastChild, InsertType.After);
                InsertTestOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, getFirstChild, InsertType.After);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInsertAtPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AnyValid);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AsFirst);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.NextToFirst);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.NextToLast);
                InsertAtOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AsLast);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInertRelativePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

                InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, getSlidePart, getSlideTextBody4Event, source, getSlidePart, getSlideTextParagraphNoEvent, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveAllChildrenPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validRemoveEventHandler);

                RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithChildren4Event);
                RemoveAllChildrenOnFile(testfile, getSlidePart, getElementWithoutChildren4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveAllTypedChildrenPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => getAnyWithLeafAndCompositeChild(e).SetEventHandler(validRemoveEventHandler);

                RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveChildPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody4Event, getFirstChild);
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody4Event, getAnyChild);
                RemoveChildOnFile(testfile, getSlidePart, getSlideTextBody4Event, getLastChild);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemovePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => getSlideTextBody(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => getAnyChild(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => getAnyLeaf(e).SetEventHandler(validRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => getAnyComposite(e).SetEventHandler(validRemoveEventHandler);

                RemoveOnFile(testfile, getSlidePart, getSlideTextBody4Event);
                RemoveOnFile(testfile, getSlidePart, getAnyChild4Event);
                RemoveOnFile(testfile, getSlidePart, getAnyLeaf4Event);
                RemoveOnFile(testfile, getSlidePart, getAnyComposite4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventReplaceChildPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
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

                ReplaceChildOnFile(testfile, getSlidePart, getSlideTextBody, getAnyChild4Event, source, getSlidePart, getAnyChildNoEvent, typeof(OpenXmlElement));
                ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyCompositeChild4Event, source, getSlidePart, getAnyChildNoEvent, typeof(OpenXmlCompositeElement));
                ReplaceChildOnFile(testfile, getSlidePart, getAnyWithLeafAndCompositeChild, getAnyLeafChild4Event, source, getSlidePart, getAnyChildNoEvent, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);

                GetAttributeOnFile(testfile, getSlidePart, getElementWithAttributesNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                GetAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventSetAttributePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => getElementWithAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => getSlideTextParagraph(e).SetEventHandler(invalidEventHandler);

                SetAttributeOnFile(testfile, getSlidePart, getAnyCompositeNoEvent, source, getSlidePart, getElementWithAttributesNoEvent, getExistingAttribute);
                SetAttributeOnFile(testfile, getSlidePart, getSlideTextParagraphNoEvent, source, getSlidePart, getElementWithFixedAttributeOnlyNoEvent, getExistingAttribute);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventSetAttributesPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                SetAttributesOnFile(testfile, getSlidePart, getAnyCompositeNoEvent, source, getMainPart, getElementWithoutAttributesNoEvent);
                SetAttributesOnFile(testfile, getSlidePart, getAnyCompositeNoEvent, source, getMainPart, getElementWithFixedAttributeOnlyNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                RemoveAttributeOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnly, getExistingFixedAttribute);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventClearAllAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => getElementWithFixedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => getElementWithExtendedAttributeOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => getElementWithMixedAttribute(e).SetEventHandler(invalidEventHandler);

                ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
                ClearAllAttributesOnFile(testfile, getSlidePart, getElementWithFixedAttributeOnlyNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetOuterXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithChildrenNoEvent);
                GetOuterXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventClonePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                CloneOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
                CloneOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
                CloneOnFile(testfile, getSlidePart, getElementWithChildrenNoEvent);
                CloneOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventCloneNodeFalsePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => getElementWithoutAttributes(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutAttributesNoEvent);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesOnlyNoEvent);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
                CloneNodeFalseOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetInnerXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyLeafNoEvent = e => getAnyLeaf(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => getAnyComposite(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                GetInnerXmlOnFile(testfile, getSlidePart, getAnyLeaf);
                GetInnerXmlOnFile(testfile, getSlidePart, getAnyComposite);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventSetInnerXmlPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutChildren4Event = e => getElementWithoutChildren(e).SetEventHandler(validReplaceEventHandler);
                GetTargetElement getElementWithChildren4Event = e => getElementWithChildren(e).SetEventHandler(validReplaceEventHandler);
                GetTargetElement getElementWithAttributesAndChildren4Event = e => getElementWithAttributesAndChildren(e).SetEventHandler(validReplaceEventHandler);

                GetTargetElement getElementWithAttributesOnlyNoEvent = e => getElementWithAttributesOnly(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren4Event, source, getSlidePart, getElementWithAttributesOnlyNoEvent);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithoutChildren4Event, source, getSlidePart, getElementWithChildrenNoEvent);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithChildren4Event, source, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
                SetInnerXmlOnFile(testfile, getSlidePart, getElementWithAttributesAndChildren4Event, source, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventWriteToPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBodyNoEvent = e => getSlideTextBody(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => getElementWithoutChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => getElementWithChildren(e).SetEventHandler(invalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => getElementWithAttributesAndChildren(e).SetEventHandler(invalidEventHandler);

                WriteToOnFile(testfile, getSlidePart, getSlideTextBodyNoEvent);
                WriteToOnFile(testfile, getSlidePart, getElementWithoutChildrenNoEvent);
                WriteToOnFile(testfile, getSlidePart, getElementWithChildrenNoEvent);
                WriteToOnFile(testfile, getSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
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
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        [Theory]
        public void AnnotationTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (OpenXmlPackage target = testfile.Open(true))
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

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        [Theory]
        public void AnnotationPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (OpenXmlPackage target = testfile.Open(true))
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

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SharedWorkbook)]
        [Theory]
        public void AnnotationXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (OpenXmlPackage target = testfile.Open(true))
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

        #endregion Annotation

        #region InvalidOperations

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SharedWorkbook, TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook)]
        [Theory]
        public void AppendArrayWithElementsOnTree(string sourcePath, string testPath)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                using (var sourcefile = TestAssets.OpenFile(sourcePath, true))
                using (var sourcePackage = sourcefile.Open(true))
                using (var testfile = TestAssets.OpenFile(testPath, false))
                using (var testPackage = testfile.Open(false))
                {
                    var root = sourcePackage.MainPart().RootElement();

                    getFirstChild(root).AppendChild(testPackage.MainPart().RootElement().Elements().FirstOrDefault());

                    root.PartRootElement().Save();
                }
            });
        }

        #endregion InvalidOperations

        #region Bug Regression

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        [Theory]
        public void Bug242463_SetRootXmlTest(string sourcePath, string testPath)
        {
            using (var sourcefile = TestAssets.OpenFile(sourcePath, false))
            using (var sourcePackage = sourcefile.Open(false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (var testpackage = testfile.Open(true))
            {
                var root = testpackage.MainPart().RootElement();
                var root2 = new Document(sourcePackage.MainPart().RootElement().OuterXml);
                (root2 as Document).Save(testpackage.MainPart() as MainDocumentPart);
            }
        }

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        [Theory]
        public void Bug247894_LoadDocumentTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (var testpackage = testfile.Open(true))
            {
                var root = testpackage.MainPart().RootElement();
                var document = Assert.IsType<Document>(root);

                document.GetPartRootElement().Save();
            }
        }

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.ForTestCase.Bug242602_SDT_unknown)]
        [Theory]
        public void Bug242602_UnknownElement_Text(string path)
        {
            using (var testfile = TestAssets.OpenFile(path, false))
            using (var testpackage = testfile.Open(false))
            {
                var unknowns = testpackage.DescendantParts()
                    .Where(p => p.IsReflectable())
                    .SelectMany(p => p.RootElement().Descendants<OpenXmlUnknownElement>())
                    .ToList();

                Assert.NotEmpty(unknowns);

                foreach (var unknown in unknowns)
                {
                    Assert.NotNull(unknown);
                }
            }
        }

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.ForTestCase.Bug201775_testfile)]
        [Theory]
        public void Bug201775_lockedCanvas(string path)
        {
            using (var testfile = TestAssets.OpenFile(path, false))
            using (var package = testfile.Open(false))
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

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.BugRegression._680607HelloO14)]
        [Theory]

        // [Description("Office14: 680607")]
        public void Bug680607_SaveOutWord14Beta2File(string path)
        {
            using (var testfile = TestAssets.OpenFile(path, true))
            {
                using (var Package = testfile.Open(true))
                {
                    //<w:fonts xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
                    //xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships"
                    //xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main"
                    //xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" mc:Ignorable="w14">
                    //   ....
                    //</w:fonts>
                    var fontTablePart = (Package as WordprocessingDocument).MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                    var fonts = fontTablePart.Fonts;

                    // check if mc:Ignorable="w14" and if there is an attribute named xmlns:w14
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

                using (var Package = testfile.Open(false))
                {
                    //<w:fonts mc:Ignorable="w14" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main">
                    //   ....
                    //</w>
                    var fontTablePart = (Package as WordprocessingDocument).MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                    var fonts = fontTablePart.Fonts;

                    // check if mc:Ignorable="w14" and if there is an attribute named xmlns:w14
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
        }

        [Fact]

        // [Description("671248")]
        public void Bug671248_ExtendedAndMcAttributesAfterConstructingWithOuterXml()
        {
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
