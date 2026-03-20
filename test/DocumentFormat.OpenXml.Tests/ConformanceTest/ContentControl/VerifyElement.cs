// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Linq;
using Xunit;

using ConstStr = DocumentFormat.OpenXml.Tests.ContentControl.ConstantStrings;
using W15 = DocumentFormat.OpenXml.Office2013.Word;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    /// <summary>
    /// To check whether a document has been changed correctly
    /// </summary>
    public static class VerifyElement
    {
        /// <summary>
        /// To check whether a document has been changed correctly
        /// </summary>
        internal static void VerifyContentControlElement(Stream stream, ITestOutputHelper log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(stream, false))
            {
                foreach (Tag tag in package.MainDocumentPart.Document.Descendants<Tag>())
                {
                    SdtBlock sdtBlock;
                    SdtCell sdtCell;
                    W15.SdtRepeatedSection sdtRepeatedSection;
                    int elementNum;

                    switch (tag.Val.Value)
                    {
                        // Tag is "Test1.1.1"
                        case ConstStr.TestTagStrings.TagContent01:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtContentBlock.Descendants<RunStyle>().Where(e => e.Val == ConstStr.RunStyleValues.Placeholder).Count();

                            Assert.Equal(0, elementNum);
                            Assert.Equal(ConstStr.TestStrings.ContentControlString2, sdtBlock.SdtContentBlock.InnerText);
                            break;

                        // Tag is "Test1.1.2"
                        case ConstStr.TestTagStrings.TagContent02:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtContentBlock.Descendants<RunStyle>().Where(e => e.Val == ConstStr.RunStyleValues.Placeholder).Count();

                            Assert.NotEqual(0, elementNum);
                            Assert.Equal(ConstStr.TestStrings.ContentControlString1, sdtBlock.SdtContentBlock.InnerText);
                            break;

                        // Tag is "Test1.2.1"
                        case ConstStr.TestTagStrings.TagContent03:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count();

                            Assert.NotEqual(0, elementNum);

                            if (elementNum != 0)
                            {
                                Assert.Equal(W15.SdtAppearance.Tags, sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val.Value);
                            }

                            break;

                        // Tag is "Test1.2.2"
                        case ConstStr.TestTagStrings.TagContent04:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count();

                            Assert.NotEqual(0, elementNum);

                            if (elementNum != 0)
                            {
                                Assert.Equal(W15.SdtAppearance.Hidden, sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val.Value);
                            }

                            break;

                        // Tag is "Test1.2.3"
                        case ConstStr.TestTagStrings.TagContent05:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count();

                            if (elementNum != 0)
                            {
                                Assert.Equal(W15.SdtAppearance.BoundingBox, sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val.Value);
                            }
                            else
                            {
                                log.WriteLine("There is no element appearance. This is enabled by default.");
                            }

                            break;

                        // Tag is "Test1.3.1"
                        case ConstStr.TestTagStrings.TagContent06:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Color>().Count();

                            Assert.NotEqual(0, elementNum);
                            Assert.Equal(ConstStr.TestColorValues.TestColor, sdtBlock.SdtProperties.Descendants<W15.Color>().First().Val.Value);
                            break;

                        // Tag is "Test1.3.2"
                        case ConstStr.TestTagStrings.TagContent07:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Color>().Count();

                            Assert.Equal(0, elementNum);
                            break;

                        // Tag is "Test1.4.1"
                        case ConstStr.TestTagStrings.TagContent08:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.SdtRepeatedSection>().Count();

                            Assert.NotEqual(0, elementNum);
                            break;

                        // Tag is "Test1.4.2"
                        case ConstStr.TestTagStrings.TagContent09:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtContentBlock.Descendants<SdtBlock>().First().SdtProperties.Descendants<W15.SdtRepeatedSectionItem>().Count();

                            Assert.NotEqual(0, elementNum);
                            break;

                        // Tag is "Test1.4.3"
                        case ConstStr.TestTagStrings.TagContent10:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            sdtRepeatedSection = sdtBlock.SdtProperties.Descendants<W15.SdtRepeatedSection>().First();

                            Assert.False(sdtRepeatedSection.DoNotAllowInsertDeleteSection.Val.Value, "Do not have the expected value element. Its values is \"0\" or \"false\".");
                            break;

                        // Tag is "Test1.4.4"
                        case ConstStr.TestTagStrings.TagContent11:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();
                            var sectionTitles = sdtBlock.Descendants<W15.SectionTitle>();
                            if (sectionTitles.Any())
                            {
                                Assert.Contains("TEST_TEST", sectionTitles.First().Val);
                            }
                            else
                            {
                                Assert.Fail("SectionTitle is not detected.");
                            }

                            break;

                        // Tag is "Test1.5.1_1"
                        case ConstStr.TestTagStrings.TagContent12:
                            sdtCell = tag.Ancestors<SdtCell>().First();

                            Assert.Equal(ConstStr.TestStrings.ContentControlCellString1, sdtCell.InnerText);
                            break;

                        // Tag is "Test1.5.1_2"
                        case ConstStr.TestTagStrings.TagContent13:
                            sdtCell = tag.Ancestors<SdtCell>().First();

                            Assert.Equal(ConstStr.TestStrings.ContentControlCellString2, sdtCell.InnerText);
                            break;

                        // Tag is "Test1.5.1_3"
                        case ConstStr.TestTagStrings.TagContent14:
                            sdtCell = tag.Ancestors<SdtCell>().First();

                            Assert.Equal(ConstStr.TestStrings.ContentControlCellString3, sdtCell.InnerText);
                            break;

                        // Tag is "Test1.5.1_4"
                        case ConstStr.TestTagStrings.TagContent15:
                            sdtCell = tag.Ancestors<SdtCell>().First();

                            Assert.Equal(ConstStr.TestStrings.ContentControlCellString4, sdtCell.InnerText);
                            break;

                        default:
                            Assert.Fail(string.Format("Unknown tag appeared. Tag name is [{0}]", tag.Val.Value));
                            break;
                    }
                }
            }
        }
    }
}
