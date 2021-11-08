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
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charspptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInbyletterpptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withShadow_100charsAnimationFlyInallatoncepptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withShadow_100charsAnimationFlyInbyletterpptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withShadow_100charspptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withShadow_200charsAnimationFlyInallatoncepptx };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withShadow_200charspptx };
        }

        public static IEnumerable<object[]> GetSpreadsheetDocuments()
        {
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SharedWorkbook };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SheetData };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SheetViewsFSB };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.SST };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.Styles };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Spreadsheet.Smallset.Table };
        }

        public static IEnumerable<object[]> GetWordprocessingDocuments()
        {
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AutoSpaceDE };
            yield return new object[] { TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.Empty };
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
                AppendCollectionOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextBody, AppendCollectionType.Array);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void AppendArrayXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetFirstSheetPart, GetSheetData, AppendCollectionType.Array);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void AppendIEnumerableTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetAnyComposite, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void AppendIEnumerablePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetAnyComposite, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void AppendIEnumerableXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AppendCollectionOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetFirstSheetPart, GetSheetData, AppendCollectionType.IEnumerable);
            }
        }

        #endregion Append Collection

        #region Pend Operations

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void AppendChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetBody, PendType.Append);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void AppendChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextBody, PendType.Append);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void AppendChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetFirstSheetPart, GetSheetData, PendType.Append);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void PreppendChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetBody, PendType.Prepend);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void PreppendChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextBody, PendType.Prepend);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void PreppendChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                PendTestOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetFirstSheetPart, GetSheetData, PendType.Prepend);
            }
        }

        #endregion Pend Operations

        #region Insert Before/After

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertBeforeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetTextParagraph, GetFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetTextParagraph, GetLastChild, InsertType.Before);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertBeforePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, GetFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, GetLastChild, InsertType.Before);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertBeforeXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, GetLastSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, GetFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, GetLastSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, GetLastChild, InsertType.Before);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertAfterTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetTextParagraph, GetLastChild, InsertType.After);
                InsertTestOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetTextParagraph, GetFirstChild, InsertType.After);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertAfterPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, GetFirstChild, InsertType.After);
                InsertTestOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, GetLastChild, InsertType.After);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertAfterXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertTestOnFile(testfile, GetLastSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, GetFirstChild, InsertType.After);
                InsertTestOnFile(testfile, GetLastSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, GetLastChild, InsertType.After);
            }
        }

        #endregion Insert Before/After

        #region InsertAt

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertAtTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertAtOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetTextParagraph, InsertAtPosition.AnyValid);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertAtPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertAtOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, InsertAtPosition.AnyValid);
                InsertAtOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, InsertAtPosition.AsFirst);
                InsertAtOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, InsertAtPosition.NextToFirst);
                InsertAtOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, InsertAtPosition.NextToLast);
                InsertAtOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, InsertAtPosition.AsLast);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertAtXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertAtOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, InsertAtPosition.AnyValid);
                InsertAtOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, InsertAtPosition.AsFirst);
                InsertAtOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, InsertAtPosition.NextToFirst);
                InsertAtOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, InsertAtPosition.NextToLast);
                InsertAtOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, InsertAtPosition.AsLast);
            }
        }

        #endregion InsertAt

        #region Insert Before/After Self

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void InsertRelativeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertRelativeOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetTextParagraph, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, GetMainPart, GetBody, source, GetMainPart, GetTextParagraph, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void InsertRelativePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertRelativeOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, GetSlidePart, GetSlideTextBody, source, GetSlidePart, GetSlideTextParagraph, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void InsertRelativeXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                InsertRelativeOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, GetFirstSheetPart, GetSheetData, source, GetLastSheetPart, GetSheetDataRow, InsertRel.BeforeSelf);
            }
        }

        #endregion Insert Before/After Self

        #region RemoveAllChildren

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveAllChildrenTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllChildrenOnFile(testfile, GetMainPart, GetElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, GetMainPart, GetElementWithChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveAllChildrenPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllChildrenOnFile(testfile, GetSlidePart, GetElementWithChildren);
                RemoveAllChildrenOnFile(testfile, GetSlidePart, GetElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, GetSlidePart, GetFirstChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveAllChildrenXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllChildrenOnFile(testfile, GetLastSheetPart, GetElementWithChildren);
                RemoveAllChildrenOnFile(testfile, GetLastSheetPart, GetElementWithoutChildren);
                RemoveAllChildrenOnFile(testfile, GetLastSheetPart, GetFirstChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveAllTypedChildrenTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllTypedChildrenOnFile(testfile, GetMainPart, GetAnyWithLeafAndCompositeChild, typeof(OpenXmlCompositeElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveAllTypedChildrenPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllTypedChildrenOnFile(testfile, GetSlidePart, GetAnyWithLeafAndCompositeChild, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, GetSlidePart, GetAnyWithLeafAndCompositeChild, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveAllTypedChildrenXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAllTypedChildrenOnFile(testfile, GetLastSheetPart, GetAnyWithCompositeChild, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, GetLastSheetPart, GetAnyWithLeafChild, typeof(OpenXmlLeafElement));
            }
        }

        #endregion RemoveAllChildren

        #region RemoveChild

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveChildOnFile(testfile, GetMainPart, GetElementWithChildren, GetAnyChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveChildOnFile(testfile, GetSlidePart, GetSlideTextBody, GetFirstChild);
                RemoveChildOnFile(testfile, GetSlidePart, GetSlideTextBody, GetAnyChild);
                RemoveChildOnFile(testfile, GetSlidePart, GetSlideTextBody, GetLastChild);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveChildOnFile(testfile, GetLastSheetPart, GetSheetData, GetAnyChild);
            }
        }

        #endregion RemoveChild

        #region Remove

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void RemoveTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveOnFile(testfile, GetMainPart, GetAnyLeaf);
                RemoveOnFile(testfile, GetMainPart, GetAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemovePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveOnFile(testfile, GetSlidePart, GetSlideTextBody);
                RemoveOnFile(testfile, GetSlidePart, GetAnyLeaf);
                RemoveOnFile(testfile, GetSlidePart, GetAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveOnFile(testfile, GetLastSheetPart, GetSheetData);
                RemoveOnFile(testfile, GetLastSheetPart, GetAnyLeaf);
                RemoveOnFile(testfile, GetLastSheetPart, GetAnyComposite);
            }
        }

        #endregion Remove

        #region ReplaceChild<T>(OpenXmlElement, T)

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void ReplaceChildTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ReplaceChildOnFile(testfile, GetMainPart, GetBody, GetAnyChild, source, GetMainPart, GetAnyChild, typeof(OpenXmlElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void ReplaceChildPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ReplaceChildOnFile(testfile, GetSlidePart, GetSlideTextBody, GetAnyChild, source, GetSlidePart, GetAnyChild, typeof(OpenXmlElement));
                ReplaceChildOnFile(testfile, GetSlidePart, GetAnyWithLeafAndCompositeChild, GetAnyCompositeChild, source, GetSlidePart, GetAnyChild, typeof(OpenXmlCompositeElement));
                ReplaceChildOnFile(testfile, GetSlidePart, GetAnyWithLeafAndCompositeChild, GetAnyLeafChild, source, GetSlidePart, GetAnyChild, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void ReplaceChildXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ReplaceChildOnFile(testfile, GetLastSheetPart, GetSheetData, GetAnyChild, source, GetLastSheetPart, GetAnyChild, typeof(OpenXmlElement));
            }
        }

        #endregion ReplaceChild<T>(OpenXmlElement, T)

        #region OpenXmlAttribute

        // w:rsidR="00B327F7" w:rsidRPr="00B327F7" w:rsidRDefault="00BB7AFC" w:rsidP="00EC35BB"
        // xmlns:ve="http://schemas.openxmlformats.org/markup-compatibility/2006"
        // xmlns:objA="urn:schemas-microsoft-com:office:office"
        // xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships"
        // xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math"
        // xmlns:v="urn:schemas-microsoft-com:vml"
        // xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing"
        // xmlns:w10="urn:schemas-microsoft-com:office:word"
        // xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main"
        // xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml"

        // xmlns:a="http://schemas.openxmlformats.org/drawingml/2006/main"
        // xmlns:p="http://schemas.openxmlformats.org/presentationml/2006/main"
        [Fact]
        public void OpenXmlAttributeValueTypeTest()
        {
            Log.Comment("Constructing a default OpenXmlAttribute and assign it to another variable...");
            var oxaX = default(OpenXmlAttribute);
            var oxaY = oxaX;
            Log.VerifyTrue(oxaX == oxaY, "The assigned OpenXmlAttribute variable is NOT equal to original one.");

            Log.Comment("Constructing OpenXmlAttribute w:rsidR and assigning it to another variable...");
            var wrsidR = new OpenXmlAttribute("w", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "00B327F7");
            var wrsidP = wrsidR;
            Log.VerifyTrue(wrsidP == wrsidR, "The assigned OpenXmlAttribute variable is NOT equal to original one.");

#pragma warning disable CS0618 // Type or member is obsolete
            wrsidP.LocalName = "rsidP";
            wrsidP.Value = "00EC35BB";
#pragma warning restore CS0618 // Type or member is obsolete
            Log.Comment("Assigned new LocalName: {0} with ByValue: {1} and comparing it with original w:rsidR", wrsidP.LocalName, wrsidP.Value);
            Log.VerifyFalse(wrsidP == wrsidR, "The assigned OpenXmlAttribute variable IS equal to original one.");
        }

        [Fact]
        public void OpenXmlAttributeEqualTest()
        {
            Log.Comment("Comparing two default OpenXmlAttribute...");
            var defaultA = default(OpenXmlAttribute);
            var defaultB = default(OpenXmlAttribute);
            Log.VerifyTrue(defaultA == defaultB, "Two default OpenXmlAttribute are NOT equal.");
            Log.VerifyFalse(defaultA != defaultB, "Two default OpenXmlAttribute are Equal.");

            var wrsidRA = new OpenXmlAttribute("w", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "00B327F7");
            var wrsidRB = new OpenXmlAttribute("w", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "00B327F7");
            Log.Comment("Comparing two {0} OpenXmlAttribute with value {1}...", wrsidRA.GetFullName(), wrsidRA.Value);
            Log.Comment("HashCode for {0}: {1}", wrsidRA.XmlQualifiedName, wrsidRA.GetHashCode());
            Log.VerifyTrue(wrsidRA == wrsidRB, "Two OpenXmlAttribute with same leftBorders are NOT equal by ==.");
            Log.VerifyTrue(wrsidRA.Equals((object)wrsidRB), "Two OpenXmlAttribute with same leftBorders are NOT equal by Equals().");
            Log.VerifyFalse(wrsidRA != wrsidRB, "Two OpenXmlAttribute with fame leftBorders are NOT equal by !=.");

            var wrsidR = new OpenXmlAttribute("w", "rsidR", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "00B327F7");
            var wrsidP = new OpenXmlAttribute("w", "rsidP", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "00EC35BB");
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
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (var package = testfile.Open(false))
            {
                var part = package.DescendantParts().Where(p => p.IsReflectable()).FirstOrDefault();
                var dom = part.RootElement;
                var e1 = dom.Descendants().Where(d => !d.ExtendedAttributes.Any()).PickSecond();

                Assert.NotNull(e1.ExtendedAttributes);

                var e2 = dom.Descendants().Where(d => !d.ExtendedAttributes.Any()).PickFirst(d => d != e1);

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
                GetAttributeOnFile(testfile, GetMainPart, GetElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributeOnFile(testfile, GetSlidePart, GetElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetAttributeXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributeOnFile(testfile, GetLastSheetPart, GetElementWithAttributes);
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
                GetAttributesOnFile(testfile, GetMainPart, GetElementWithoutAttributes);
                GetAttributesOnFile(testfile, GetMainPart, GetElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributesOnFile(testfile, GetSlidePart, GetElementWithoutAttributes);
                GetAttributesOnFile(testfile, GetSlidePart, GetElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetAttributesXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetAttributesOnFile(testfile, GetLastSheetPart, GetElementWithoutAttributes);
                GetAttributesOnFile(testfile, GetLastSheetPart, GetElementWithFixedAttributeOnly);
            }
        }

        #endregion GetAttributes

        #region SetAttribute(OpenXmlAttribute)

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void SetAttributeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributeOnFile(testfile, GetMainPart, GetTextParagraph, source, GetMainPart, GetElementWithFixedAttributeOnly, GetExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void SetAttributePPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributeOnFile(testfile, GetSlidePart, GetSlideTextParagraph, source, GetSlidePart, GetElementWithFixedAttributeOnly, GetExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void SetAttributeXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributeOnFile(testfile, GetLastSheetPart, GetSheetData, source, GetLastSheetPart, GetElementWithFixedAttributeOnly, GetExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void SetAttributesTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributesOnFile(testfile, GetMainPart, GetAnyElement, source, GetMainPart, GetElementWithoutAttributes);
                SetAttributesOnFile(testfile, GetMainPart, GetAnyElement, source, GetMainPart, GetElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void SetAttributesPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributesOnFile(testfile, GetSlidePart, GetAnyComposite, source, GetSlidePart, GetElementWithoutAttributes);
                SetAttributesOnFile(testfile, GetSlidePart, GetAnyComposite, source, GetSlidePart, GetElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void SetAttributesXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetAttributesOnFile(testfile, GetLastSheetPart, GetAnyComposite, source, GetLastSheetPart, GetElementWithoutAttributes);
                SetAttributesOnFile(testfile, GetLastSheetPart, GetAnyComposite, source, GetLastSheetPart, GetElementWithFixedAttributeOnly);
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
                RemoveAttributeOnFile(testfile, GetMainPart, GetElementWithoutAttributes, GetFixedAttribute);
                RemoveAttributeOnFile(testfile, GetMainPart, GetElementWithAttributes, GetExistingAttribute);
                RemoveAttributeOnFile(testfile, GetMainPart, GetElementWithMixedAttribute, GetExistingFixedAttribute);
                RemoveAttributeOnFile(testfile, GetMainPart, GetElementWithMixedAttribute, GetNonExistingFixedAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void RemoveAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAttributeOnFile(testfile, GetSlidePart, GetElementWithFixedAttributeOnly, GetExistingFixedAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void RemoveAttributeXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                RemoveAttributeOnFile(testfile, GetLastSheetPart, GetElementWithFixedAttributeOnly, GetExistingFixedAttribute);
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
                ClearAllAttributesOnFile(testfile, GetMainPart, GetElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, GetMainPart, GetElementWithAttributes);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void ClearAllAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ClearAllAttributesOnFile(testfile, GetSlidePart, GetElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, GetSlidePart, GetElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void ClearAllAttributesXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                ClearAllAttributesOnFile(testfile, GetLastSheetPart, GetElementWithoutAttributes);
                ClearAllAttributesOnFile(testfile, GetLastSheetPart, GetElementWithFixedAttributeOnly);
            }
        }

        #endregion ClearAllAttributes

        #region AddNamespaceDeclaration

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void AddNamespaceDeclarationTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                AddNamespaceDeclarationOnFile(testfile, GetMainPart, GetElementWithNamespaceDeclarations, source, GetAnyOpenXmlPart, GetElementWithNamespaceDeclarations, GetExistingNamespaceDeclaration);
                AddNamespaceDeclarationOnFile(testfile, GetMainPart, GetElementWithoutNamespaceDeclarations, source, GetAnyOpenXmlPart, GetElementWithNamespaceDeclarations, GetExistingNamespaceDeclaration);
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
                NamespaceDeclarationsOnFile(testfile, GetAnyOpenXmlPart, GetElementWithNamespaceDeclarations);
                NamespaceDeclarationsOnFile(testfile, GetAnyOpenXmlPart, GetElementWithoutNamespaceDeclarations);
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
                RemoveNamespaceDeclarationOnFile(testfile, GetAnyOpenXmlPart, GetElementWithNamespaceDeclarations, GetExistingNamespaceDeclaration);
                RemoveNamespaceDeclarationOnFile(testfile, GetAnyOpenXmlPart, GetElementWithNamespaceDeclarations, GetNonExistingNamespaceDeclaration);
                RemoveNamespaceDeclarationOnFile(testfile, GetAnyOpenXmlPart, GetElementWithoutNamespaceDeclarations, GetNonExistingNamespaceDeclaration);
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
                GetOuterXmlOnFile(testfile, GetMainPart, GetElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, GetMainPart, GetElementWithoutChildren);
                GetOuterXmlOnFile(testfile, GetMainPart, GetElementWithChildren);
                GetOuterXmlOnFile(testfile, GetMainPart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetOuterXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetOuterXmlOnFile(testfile, GetSlidePart, GetElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, GetSlidePart, GetElementWithoutChildren);
                GetOuterXmlOnFile(testfile, GetSlidePart, GetElementWithChildren);
                GetOuterXmlOnFile(testfile, GetSlidePart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetOuterXmlXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetOuterXmlOnFile(testfile, GetLastSheetPart, GetElementWithoutAttributes);
                GetOuterXmlOnFile(testfile, GetLastSheetPart, GetElementWithoutChildren);
                GetOuterXmlOnFile(testfile, GetLastSheetPart, GetElementWithChildren);
                GetOuterXmlOnFile(testfile, GetLastSheetPart, GetElementWithAttributesAndChildren);
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
                CloneOnFile(testfile, GetMainPart, GetElementWithoutChildren);
                CloneOnFile(testfile, GetMainPart, GetElementWithoutAttributes);
                CloneOnFile(testfile, GetMainPart, GetElementWithChildren);
                CloneOnFile(testfile, GetMainPart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void ClonePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneOnFile(testfile, GetSlidePart, GetElementWithoutChildren);
                CloneOnFile(testfile, GetSlidePart, GetElementWithoutAttributes);
                CloneOnFile(testfile, GetSlidePart, GetElementWithChildren);
                CloneOnFile(testfile, GetSlidePart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void CloneXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneOnFile(testfile, GetLastSheetPart, GetElementWithoutChildren);
                CloneOnFile(testfile, GetLastSheetPart, GetElementWithoutAttributes);
                CloneOnFile(testfile, GetLastSheetPart, GetElementWithChildren);
                CloneOnFile(testfile, GetLastSheetPart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.Empty)]
        public void CloneNodeFalseTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneNodeFalseOnFile(testfile, GetMainPart, GetElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, GetMainPart, GetElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, GetMainPart, GetElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, GetMainPart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void CloneNodeFalsePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneNodeFalseOnFile(testfile, GetSlidePart, GetElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, GetSlidePart, GetElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, GetSlidePart, GetElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, GetSlidePart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void CloneNodeFalseXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                CloneNodeFalseOnFile(testfile, GetLastSheetPart, GetElementWithoutAttributes);
                CloneNodeFalseOnFile(testfile, GetLastSheetPart, GetElementWithAttributesOnly);
                CloneNodeFalseOnFile(testfile, GetLastSheetPart, GetElementWithoutChildren);
                CloneNodeFalseOnFile(testfile, GetLastSheetPart, GetElementWithAttributesAndChildren);
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
                GetInnerXmlOnFile(testfile, GetMainPart, GetAnyLeaf);
                GetInnerXmlOnFile(testfile, GetMainPart, GetAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void GetInnerXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetInnerXmlOnFile(testfile, GetSlidePart, GetAnyLeaf);
                GetInnerXmlOnFile(testfile, GetSlidePart, GetAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void GetInnerXmlXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetInnerXmlOnFile(testfile, GetLastSheetPart, GetAnyLeaf);
                GetInnerXmlOnFile(testfile, GetLastSheetPart, GetAnyComposite);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void SetInnerXmlPPTTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetInnerXmlOnFile(testfile, GetSlidePart, GetElementWithoutChildren, source, GetSlidePart, GetElementWithAttributesOnly);
                SetInnerXmlOnFile(testfile, GetSlidePart, GetElementWithoutChildren, source, GetSlidePart, GetElementWithChildren);
                SetInnerXmlOnFile(testfile, GetSlidePart, GetElementWithChildren, source, GetSlidePart, GetElementWithAttributesAndChildren);
                SetInnerXmlOnFile(testfile, GetSlidePart, GetElementWithAttributesAndChildren, source, GetSlidePart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void SetInnerXmlXSLTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook, false))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                SetInnerXmlOnFile(testfile, GetLastSheetPart, GetElementWithoutChildren, source, GetLastSheetPart, GetElementWithAttributesOnly);
                SetInnerXmlOnFile(testfile, GetLastSheetPart, GetElementWithoutChildren, source, GetLastSheetPart, GetElementWithChildren);
                SetInnerXmlOnFile(testfile, GetLastSheetPart, GetElementWithChildren, source, GetLastSheetPart, GetElementWithAttributesAndChildren);
                SetInnerXmlOnFile(testfile, GetLastSheetPart, GetElementWithAttributesAndChildren, source, GetLastSheetPart, GetElementWithAttributesAndChildren);
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
                WriteToOnFile(testfile, GetMainPart, GetElementWithoutAttributes);
                WriteToOnFile(testfile, GetMainPart, GetElementWithoutChildren);
                WriteToOnFile(testfile, GetMainPart, GetElementWithChildren);
                WriteToOnFile(testfile, GetMainPart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetPowerPointDocuments))]
        public void WriteToPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                WriteToOnFile(testfile, GetSlidePart, GetSlideTextBody);
                WriteToOnFile(testfile, GetSlidePart, GetElementWithoutChildren);
                WriteToOnFile(testfile, GetSlidePart, GetElementWithChildren);
                WriteToOnFile(testfile, GetSlidePart, GetElementWithAttributesAndChildren);
            }
        }

        [Theory]
        [MemberData(nameof(GetSpreadsheetDocuments))]
        public void WriteToXSLTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                WriteToOnFile(testfile, GetLastSheetPart, GetSheetData);
                WriteToOnFile(testfile, GetLastSheetPart, GetElementWithoutChildren);
                WriteToOnFile(testfile, GetLastSheetPart, GetElementWithChildren);
                WriteToOnFile(testfile, GetLastSheetPart, GetElementWithAttributesAndChildren);
            }
        }

        #endregion WriteTo

        #region Events

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventAppendChildTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getBodyNoEvent = e => GetBody(e).SetEventHandler(InvalidEventHandler);

                PendTestOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getBodyNoEvent, PendType.Append);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventPreppendChildTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getBodyNoEvent = e => GetBody(e).SetEventHandler(InvalidEventHandler);

                PendTestOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getBodyNoEvent, PendType.Prepend);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventAppendArrayTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getBodyNoEvent = e => GetBody(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => GetTextParagraph(e).SetEventHandler(InvalidEventHandler);

                AppendCollectionOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, AppendCollectionType.Array);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventAppendIEnumerableTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);

                AppendCollectionOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getAnyCompositeNoEvent, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertBeforeTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => GetTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertTestOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, GetFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, GetLastChild, InsertType.Before);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertAfterTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => GetTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertTestOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, GetLastChild, InsertType.After);
                InsertTestOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, GetFirstChild, InsertType.After);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertAtTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => GetTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertAtOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, InsertAtPosition.AnyValid);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventInsertRelativeTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getTextParagraphNoEvent = e => GetTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertRelativeOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, GetMainPart, getBody4Event, source, GetMainPart, getTextParagraphNoEvent, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveAllChildrenTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getElementWithoutChildren4Event = e => GetElementWithoutChildren(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getElementWithChildren4Event = e => GetElementWithChildren(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveAllChildrenOnFile(testfile, GetMainPart, getElementWithChildren4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveAllTypedChildrenTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => GetAnyWithLeafAndCompositeChild(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveAllTypedChildrenOnFile(testfile, GetMainPart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, GetMainPart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveChildTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => GetAnyChild(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => GetAnyLeaf(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => GetAnyComposite(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveChildOnFile(testfile, GetMainPart, getBody4Event, GetAnyChild);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventRemoveTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => GetAnyChild(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => GetAnyLeaf(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => GetAnyComposite(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveOnFile(testfile, GetAnyOpenXmlPart, getAnyChild4Event);
                RemoveOnFile(testfile, GetAnyOpenXmlPart, getAnyLeaf4Event);
                RemoveOnFile(testfile, GetAnyOpenXmlPart, getAnyComposite4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventReplaceChildTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBody4Event = e => GetBody(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyChild4Event = e => GetAnyChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyLeafChild4Event = e => GetAnyLeafChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyCompositeChild4Event = e => GetAnyCompositeChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => GetAnyWithLeafAndCompositeChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getBodyNoEvent = e => GetBody(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyChildNoEvent = e => GetAnyChild(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyLeafChildNoEvent = e => GetAnyLeafChild(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyCompositeChildNoEvent = e => GetAnyCompositeChild(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyWithLeafAndCompositeElementNoEvent = e => GetAnyWithLeafAndCompositeChild(e).SetEventHandler(InvalidEventHandler);

                ReplaceChildOnFile(testfile, GetMainPart, GetBody, getAnyChild4Event, source, GetMainPart, getAnyChildNoEvent, typeof(OpenXmlElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventGetAttributeTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithAttributesNoEvent = e => GetElementWithAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);

                GetAttributeOnFile(testfile, GetMainPart, getElementWithAttributesNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventGetAttributesTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => GetElementWithAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                GetAttributesOnFile(testfile, GetMainPart, getElementWithoutAttributesNoEvent);
                GetAttributesOnFile(testfile, GetMainPart, getElementWithAttributesNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventSetAttributeTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => GetElementWithAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                SetAttributeOnFile(testfile, GetMainPart, getAnyCompositeNoEvent, source, GetMainPart, getElementWithAttributesNoEvent, GetExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventSetAttributesTest(string testPath)
        {
            using (var source = TestAssets.OpenFile(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                SetAttributesOnFile(testfile, GetMainPart, getAnyCompositeNoEvent, source, GetMainPart, getElementWithoutAttributesNoEvent);
                SetAttributesOnFile(testfile, GetMainPart, getAnyCompositeNoEvent, source, GetMainPart, getElementWithFixedAttributeOnlyNoEvent);
                SetAttributesOnFile(testfile, GetMainPart, getAnyCompositeNoEvent, source, GetMainPart, getElementWithMixedAttributeNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventRemoveAttributeTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => GetElementWithAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                RemoveAttributeOnFile(testfile, GetAnyOpenXmlPart, getElementWithAttributesNoEvent, GetExistingAttribute);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventClearAllAttributesTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                ClearAllAttributesOnFile(testfile, GetMainPart, getElementWithoutAttributesNoEvent);
                ClearAllAttributesOnFile(testfile, GetMainPart, getElementWithFixedAttributeOnlyNoEvent);
                ClearAllAttributesOnFile(testfile, GetMainPart, getElementWithExtendedAttributeOnlyNoEvent);
                ClearAllAttributesOnFile(testfile, GetMainPart, getElementWithMixedAttributeNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventGetOuterXmlTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                GetOuterXmlOnFile(testfile, GetMainPart, getElementWithoutAttributesNoEvent);
                GetOuterXmlOnFile(testfile, GetMainPart, getElementWithoutChildrenNoEvent);
                GetOuterXmlOnFile(testfile, GetMainPart, getElementWithChildrenNoEvent);
                GetOuterXmlOnFile(testfile, GetMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventCloneTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                CloneOnFile(testfile, GetMainPart, getElementWithoutChildrenNoEvent);
                CloneOnFile(testfile, GetMainPart, getElementWithoutAttributesNoEvent);
                CloneOnFile(testfile, GetMainPart, getElementWithChildrenNoEvent);
                CloneOnFile(testfile, GetMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventCloneNodeFalseTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => GetElementWithAttributesOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                CloneNodeFalseOnFile(testfile, GetMainPart, getElementWithoutAttributesNoEvent);
                CloneNodeFalseOnFile(testfile, GetMainPart, getElementWithAttributesOnlyNoEvent);
                CloneNodeFalseOnFile(testfile, GetMainPart, getElementWithoutChildrenNoEvent);
                CloneNodeFalseOnFile(testfile, GetMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [MemberData(nameof(GetWordprocessingDocuments))]
        public void EventGetInnerXmlTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyLeafNoEvent = e => GetAnyLeaf(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => GetElementWithAttributesOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                GetInnerXmlOnFile(testfile, GetMainPart, getAnyLeafNoEvent);
                GetInnerXmlOnFile(testfile, GetMainPart, getAnyCompositeNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventSetInnerXmlTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutChildren4Event = e => GetElementWithoutChildren(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getElementWithChildren4Event = e => GetElementWithChildren(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getElementWithAttributesAndChildren4Event = e => GetElementWithAttributesAndChildren(e).SetEventHandler(ValidReplaceEventHandler);

                GetTargetElement getElementWithAttributesOnlyNoEvent = e => GetElementWithAttributesOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                SetInnerXmlOnFile(testfile, GetMainPart, getElementWithAttributesAndChildren4Event, source, GetMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
        public void EventWriteToTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getBodyNoEvent = e => GetBody(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                WriteToOnFile(testfile, GetMainPart, getElementWithoutChildrenNoEvent);
                WriteToOnFile(testfile, GetMainPart, getElementWithChildrenNoEvent);
                WriteToOnFile(testfile, GetMainPart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        #endregion Events

        #region PPT Events

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventAppendChildPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getSlideTextBodyNoEvent = e => GetSlideTextBody(e).SetEventHandler(InvalidEventHandler);

                PendTestOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextBodyNoEvent, PendType.Append);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventPreppendChildPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getSlideTextBodyNoEvent = e => GetSlideTextBody(e).SetEventHandler(InvalidEventHandler);

                PendTestOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextBodyNoEvent, PendType.Prepend);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventAppendArrayPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getSlideTextBodyNoEvent = e => GetSlideTextBody(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => GetSlideTextParagraph(e).SetEventHandler(InvalidEventHandler);

                AppendCollectionOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, AppendCollectionType.Array);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventAppendIEnumerablePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);

                AppendCollectionOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getAnyCompositeNoEvent, AppendCollectionType.IEnumerable);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInsertBeforePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => GetSlideTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertTestOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, GetFirstChild, InsertType.Before);
                InsertTestOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, GetLastChild, InsertType.Before);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInsertAfterPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => GetSlideTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertTestOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, GetLastChild, InsertType.After);
                InsertTestOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, GetFirstChild, InsertType.After);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInsertAtPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => GetSlideTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertAtOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AnyValid);
                InsertAtOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AsFirst);
                InsertAtOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.NextToFirst);
                InsertAtOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.NextToLast);
                InsertAtOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, InsertAtPosition.AsLast);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventInertRelativePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidInsertEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => GetSlideTextParagraph(e).SetEventHandler(InvalidEventHandler);

                InsertRelativeOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, InsertRel.AfterSelf);
                InsertRelativeOnFile(testfile, GetSlidePart, getSlideTextBody4Event, source, GetSlidePart, getSlideTextParagraphNoEvent, InsertRel.BeforeSelf);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveAllChildrenPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getElementWithoutChildren4Event = e => GetElementWithoutChildren(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getElementWithChildren4Event = e => GetElementWithChildren(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveAllChildrenOnFile(testfile, GetSlidePart, getElementWithChildren4Event);
                RemoveAllChildrenOnFile(testfile, GetSlidePart, getElementWithoutChildren4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveAllTypedChildrenPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => GetAnyWithLeafAndCompositeChild(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveAllTypedChildrenOnFile(testfile, GetSlidePart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlCompositeElement));
                RemoveAllTypedChildrenOnFile(testfile, GetSlidePart, getAnyWithLeafAndCompositeElement4Event, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveChildPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => GetAnyChild(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => GetAnyLeaf(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => GetAnyComposite(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveChildOnFile(testfile, GetSlidePart, getSlideTextBody4Event, GetFirstChild);
                RemoveChildOnFile(testfile, GetSlidePart, getSlideTextBody4Event, GetAnyChild);
                RemoveChildOnFile(testfile, GetSlidePart, getSlideTextBody4Event, GetLastChild);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemovePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyChild4Event = e => GetAnyChild(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyLeaf4Event = e => GetAnyLeaf(e).SetEventHandler(ValidRemoveEventHandler);
                GetTargetElement getAnyComposite4Event = e => GetAnyComposite(e).SetEventHandler(ValidRemoveEventHandler);

                RemoveOnFile(testfile, GetSlidePart, getSlideTextBody4Event);
                RemoveOnFile(testfile, GetSlidePart, getAnyChild4Event);
                RemoveOnFile(testfile, GetSlidePart, getAnyLeaf4Event);
                RemoveOnFile(testfile, GetSlidePart, getAnyComposite4Event);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventReplaceChildPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBody4Event = e => GetSlideTextBody(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyChild4Event = e => GetAnyChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyLeafChild4Event = e => GetAnyLeafChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyCompositeChild4Event = e => GetAnyCompositeChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getAnyWithLeafAndCompositeElement4Event = e => GetAnyWithLeafAndCompositeChild(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getSlideTextBodyNoEvent = e => GetSlideTextBody(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyChildNoEvent = e => GetAnyChild(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyLeafChildNoEvent = e => GetAnyLeafChild(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyCompositeChildNoEvent = e => GetAnyCompositeChild(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyWithLeafAndCompositeElementNoEvent = e => GetAnyWithLeafAndCompositeChild(e).SetEventHandler(InvalidEventHandler);

                ReplaceChildOnFile(testfile, GetSlidePart, GetSlideTextBody, getAnyChild4Event, source, GetSlidePart, getAnyChildNoEvent, typeof(OpenXmlElement));
                ReplaceChildOnFile(testfile, GetSlidePart, GetAnyWithLeafAndCompositeChild, getAnyCompositeChild4Event, source, GetSlidePart, getAnyChildNoEvent, typeof(OpenXmlCompositeElement));
                ReplaceChildOnFile(testfile, GetSlidePart, GetAnyWithLeafAndCompositeChild, getAnyLeafChild4Event, source, GetSlidePart, getAnyChildNoEvent, typeof(OpenXmlLeafElement));
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithAttributesNoEvent = e => GetElementWithAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);

                GetAttributeOnFile(testfile, GetSlidePart, getElementWithAttributesNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                GetAttributesOnFile(testfile, GetSlidePart, GetElementWithFixedAttributeOnly);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventSetAttributePPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesNoEvent = e => GetElementWithAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getSlideTextParagraphNoEvent = e => GetSlideTextParagraph(e).SetEventHandler(InvalidEventHandler);

                SetAttributeOnFile(testfile, GetSlidePart, getAnyCompositeNoEvent, source, GetSlidePart, getElementWithAttributesNoEvent, GetExistingAttribute);
                SetAttributeOnFile(testfile, GetSlidePart, getSlideTextParagraphNoEvent, source, GetSlidePart, getElementWithFixedAttributeOnlyNoEvent, GetExistingAttribute);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventSetAttributesPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                SetAttributesOnFile(testfile, GetSlidePart, getAnyCompositeNoEvent, source, GetMainPart, getElementWithoutAttributesNoEvent);
                SetAttributesOnFile(testfile, GetSlidePart, getAnyCompositeNoEvent, source, GetMainPart, getElementWithFixedAttributeOnlyNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventRemoveAttributePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                RemoveAttributeOnFile(testfile, GetSlidePart, GetElementWithFixedAttributeOnly, GetExistingFixedAttribute);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventClearAllAttributesPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithFixedAttributeOnlyNoEvent = e => GetElementWithFixedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithExtendedAttributeOnlyNoEvent = e => GetElementWithExtendedAttributeOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithMixedAttributeNoEvent = e => GetElementWithMixedAttribute(e).SetEventHandler(InvalidEventHandler);

                ClearAllAttributesOnFile(testfile, GetSlidePart, getElementWithoutAttributesNoEvent);
                ClearAllAttributesOnFile(testfile, GetSlidePart, getElementWithFixedAttributeOnlyNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetOuterXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                GetOuterXmlOnFile(testfile, GetSlidePart, getElementWithoutAttributesNoEvent);
                GetOuterXmlOnFile(testfile, GetSlidePart, getElementWithoutChildrenNoEvent);
                GetOuterXmlOnFile(testfile, GetSlidePart, getElementWithChildrenNoEvent);
                GetOuterXmlOnFile(testfile, GetSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventClonePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                CloneOnFile(testfile, GetSlidePart, getElementWithoutChildrenNoEvent);
                CloneOnFile(testfile, GetSlidePart, getElementWithoutAttributesNoEvent);
                CloneOnFile(testfile, GetSlidePart, getElementWithChildrenNoEvent);
                CloneOnFile(testfile, GetSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventCloneNodeFalsePPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutAttributesNoEvent = e => GetElementWithoutAttributes(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => GetElementWithAttributesOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                CloneNodeFalseOnFile(testfile, GetSlidePart, getElementWithoutAttributesNoEvent);
                CloneNodeFalseOnFile(testfile, GetSlidePart, getElementWithAttributesOnlyNoEvent);
                CloneNodeFalseOnFile(testfile, GetSlidePart, getElementWithoutChildrenNoEvent);
                CloneNodeFalseOnFile(testfile, GetSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventGetInnerXmlPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getAnyLeafNoEvent = e => GetAnyLeaf(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getAnyCompositeNoEvent = e => GetAnyComposite(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesOnlyNoEvent = e => GetElementWithAttributesOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                GetInnerXmlOnFile(testfile, GetSlidePart, GetAnyLeaf);
                GetInnerXmlOnFile(testfile, GetSlidePart, GetAnyComposite);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventSetInnerXmlPPTTest(string sourcePath, string testPath)
        {
            using (var source = TestAssets.OpenFile(sourcePath, true))
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getElementWithoutChildren4Event = e => GetElementWithoutChildren(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getElementWithChildren4Event = e => GetElementWithChildren(e).SetEventHandler(ValidReplaceEventHandler);
                GetTargetElement getElementWithAttributesAndChildren4Event = e => GetElementWithAttributesAndChildren(e).SetEventHandler(ValidReplaceEventHandler);

                GetTargetElement getElementWithAttributesOnlyNoEvent = e => GetElementWithAttributesOnly(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                SetInnerXmlOnFile(testfile, GetSlidePart, getElementWithoutChildren4Event, source, GetSlidePart, getElementWithAttributesOnlyNoEvent);
                SetInnerXmlOnFile(testfile, GetSlidePart, getElementWithoutChildren4Event, source, GetSlidePart, getElementWithChildrenNoEvent);
                SetInnerXmlOnFile(testfile, GetSlidePart, getElementWithChildren4Event, source, GetSlidePart, getElementWithAttributesAndChildrenNoEvent);
                SetInnerXmlOnFile(testfile, GetSlidePart, getElementWithAttributesAndChildren4Event, source, GetSlidePart, getElementWithAttributesAndChildrenNoEvent);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        public void EventWriteToPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            {
                GetTargetElement getSlideTextBodyNoEvent = e => GetSlideTextBody(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithoutChildrenNoEvent = e => GetElementWithoutChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithChildrenNoEvent = e => GetElementWithChildren(e).SetEventHandler(InvalidEventHandler);
                GetTargetElement getElementWithAttributesAndChildrenNoEvent = e => GetElementWithAttributesAndChildren(e).SetEventHandler(InvalidEventHandler);

                WriteToOnFile(testfile, GetSlidePart, getSlideTextBodyNoEvent);
                WriteToOnFile(testfile, GetSlidePart, getElementWithoutChildrenNoEvent);
                WriteToOnFile(testfile, GetSlidePart, getElementWithChildrenNoEvent);
                WriteToOnFile(testfile, GetSlidePart, getElementWithAttributesAndChildrenNoEvent);
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
                {
                    Log.Warning("Current hostPart is NOT reflectable.");
                }

                AnnotationType(hostPart, GetBody);
                AnnotationT(hostPart, GetBody);
                AnnotationArray(hostPart, GetBody);
                AnnotationCollection(hostPart, GetBody);
            }
        }

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        [Theory]
        public void AnnotationPPTTest(string testPath)
        {
            using (var testfile = TestAssets.OpenFile(testPath, true))
            using (OpenXmlPackage target = testfile.Open(true))
            {
                Log.Comment("Loading target MainPart...");
                OpenXmlPart hostPart = GetSlidePart(target);

                if (!hostPart.IsReflectable())
                {
                    Log.Warning("Current hostPart is NOT reflectable.");
                }

                AnnotationType(hostPart, GetSlideTextBody);
                AnnotationT(hostPart, GetSlideTextBody);
                AnnotationArray(hostPart, GetSlideTextBody);
                AnnotationCollection(hostPart, GetSlideTextBody);
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
                OpenXmlPart hostPart = GetLastSheetPart(target);

                if (!hostPart.IsReflectable())
                {
                    Log.Warning("Current hostPart is NOT reflectable.");
                }

                AnnotationType(hostPart, GetSheetData);
                AnnotationT(hostPart, GetSheetData);
                AnnotationArray(hostPart, GetSheetData);
                AnnotationCollection(hostPart, GetSheetData);
            }
        }

        #endregion Annotation

        #region InvalidOperations

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Presentation.Smallset.Text_withExtrusion_200charsAnimationFlyInallatoncepptx, TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
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

                    GetFirstChild(root).AppendChild(testPackage.MainPart().RootElement().Elements().FirstOrDefault());

                    root.PartRootElement().Save();
                }
            });
        }

        #endregion InvalidOperations

        #region Bug Regression

        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.Complex1NOR, TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd)]
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
                if (element is null)
                {
                    Log.Warning("No lockedCanvas element found in specified document.");
                    return;
                }

                if (element is OpenXmlUnknownElement)
                {
                    Log.Fail("Element {0} is loaded as OpenXmlUnknownElement, instead of expected LockedCanvasElement.", element.Path());
                }
                else
                {
                    Log.Pass("Element {0} is loaded as strongly type {1}.", element.Path(), element.GetType().FullName);
                }
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
                using (var package = testfile.Open(true))
                {
                    // <w:fonts xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
                    // xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships"
                    // xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main"
                    // xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" mc:Ignorable="w14">
                    //   ....
                    // </w:fonts>
                    var fontTablePart = (package as WordprocessingDocument).MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                    var fonts = fontTablePart.Fonts;

                    // check if mc:Ignorable="w14" and if there is an attribute named xmlns:w14
                    var ignorable = fonts.GetAttributes().Where(a => a.LocalName == "Ignorable" && a.Value == "w14").FirstOrDefault();
                    if (ignorable == default(OpenXmlAttribute))
                    {
                        Log.Fail("No mc:Ignorable attribute with value {0} exists", "w14");
                    }
                    else
                    {
                        Log.Pass("mc:Ignorable attribute with value {0} exists", "w14");
                    }

                    var w14ns = fonts.OuterXml.Contains(@"xmlns:w14=""http://schemas.microsoft.com/office/word/2010/wordml");
                    if (!w14ns)
                    {
                        Log.Fail("No w14 namespace declaration found.");
                    }
                    else
                    {
                        Log.Pass("w14 namespace declaration found on fonts element.");
                    }
                }

                using (var package = testfile.Open(false))
                {
                    // <w:fonts mc:Ignorable="w14" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main">
                    //   ....
                    // </w>
                    var fontTablePart = (package as WordprocessingDocument).MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                    var fonts = fontTablePart.Fonts;

                    // check if mc:Ignorable="w14" and if there is an attribute named xmlns:w14
                    var ignorable = fonts.GetAttributes().Where(a => a.LocalName == "Ignorable" && a.Value == "w14").FirstOrDefault();
                    if (ignorable == default(OpenXmlAttribute))
                    {
                        Log.Fail("No mc:Ignorable attribute with value {0} exists", "w14");
                    }
                    else
                    {
                        Log.Pass("mc:Ignorable attribute with value {0} exists", "w14");
                    }

                    var w14ns = fonts.OuterXml.Contains(@"xmlns:w14=""http://schemas.microsoft.com/office/word/2010/wordml");
                    if (!w14ns)
                    {
                        Log.Fail("No w14 namespace declaration found.");
                    }
                    else
                    {
                        Log.Pass("w14 namespace declaration found on fonts element.");
                    }
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
