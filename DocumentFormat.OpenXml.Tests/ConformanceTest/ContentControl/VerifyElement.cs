// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Wordprocessing;
    using W15 = DocumentFormat.OpenXml.Office2013.Word;
    using ConstStr = DocumentFormat.OpenXml.Tests.ContentControl.ConstantStrings;
    using LogUtil;

    /// <summary>
    /// To check whether a document has been changed correctly
    /// </summary>
    public class VerifyElement
    {
        /// <summary>
        /// To check whether a document has been changed correctly
        /// </summary>
        /// <param name="filePath">Verify file</param>
        /// <param name="log">Logger</param>
        public static void VerifyContentControlElement(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, false))
            {
                foreach (Tag tag in package.MainDocumentPart.Document.Descendants<Tag>())
                {
                    SdtBlock sdtBlock;
                    SdtCell SdtCell;
                    W15.SdtRepeatedSection sdtRepeatedSection;
                    int elementNum;

                    switch (tag.Val.Value)
                    {
                        //Tag is "Test1.1.1"
                        case ConstStr.TestTagStrings.TagContent01:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtContentBlock.Descendants<RunStyle>().Where(e => e.Val == ConstStr.RunStyleValues.Placeholder).Count();

                            log.Verify(elementNum == 0, "Element does not appear as expected. Its elements are \"style\", \"PlaceholderText\" value.");
                            log.Verify(sdtBlock.SdtContentBlock.InnerText == ConstStr.TestStrings.ContentControlString2, "In the text is not expected.");
                            break;

                        //Tag is "Test1.1.2"
                        case ConstStr.TestTagStrings.TagContent02:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtContentBlock.Descendants<RunStyle>().Where(e => e.Val == ConstStr.RunStyleValues.Placeholder).Count();

                            log.Verify(elementNum != 0, "Do not expect element appeared. Its elements are \"style\", \"PlaceholderText\" value.");
                            log.Verify(sdtBlock.SdtContentBlock.InnerText == ConstStr.TestStrings.ContentControlString1, "In the text is not expected.");
                            break;

                        //Tag is "Test1.2.1"
                        case ConstStr.TestTagStrings.TagContent03:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count();

                            log.Verify(elementNum != 0, "Element does not appear as expected. Its elements are \"appearance\".");

                            if (elementNum != 0)
                            {
                                log.Verify(sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val == W15.SdtAppearance.Tags, "Do not have the expected value element.Its values is \"Tags\".");
                            }
                            break;

                        //Tag is "Test1.2.2"
                        case ConstStr.TestTagStrings.TagContent04:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count();

                            log.Verify(elementNum != 0, "Element does not appear as expected. Its elements are \"appearance\".");

                            if (elementNum != 0)
                            {
                                log.Verify(sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val == W15.SdtAppearance.Hidden, "Do not have the expected value element.Its values is \"Hidden\".");
                            }
                            break;

                        //Tag is "Test1.2.3"
                        case ConstStr.TestTagStrings.TagContent05:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();
                                
                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count();

                            if (elementNum != 0)
                            {
                                log.Verify(sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val == W15.SdtAppearance.BoundingBox, "Do not have the expected value element.Its values is \"BoundingBox\".");
                            }
                            else
                            {
                                log.Pass("There is no element appearance. This is enabled by default.");
                            }
                            break;

                        //Tag is "Test1.3.1"
                        case ConstStr.TestTagStrings.TagContent06:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Color>().Count();

                            log.Verify(elementNum != 0, "Element does not appear as expected. Its elements are \"color\".");
                            log.Verify(sdtBlock.SdtProperties.Descendants<W15.Color>().First().Val.Value == ConstStr.TestColorValues.TestColor, string.Format("Do not have the expected value element.Its values is \"{0}\".", ConstStr.TestColorValues.TestColor));
                            break;

                        //Tag is "Test1.3.2"
                        case ConstStr.TestTagStrings.TagContent07:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.Color>().Count();

                            log.Verify(elementNum == 0, "Element does not appear as expected. Its elements are \"color\".");
                            break;

                        //Tag is "Test1.4.1"
                        case ConstStr.TestTagStrings.TagContent08:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtProperties.Descendants<W15.SdtRepeatedSection>().Count();

                            log.Verify(elementNum != 0, "Element does not appear as expected. Its elements are \"SdtRepeatedSection\".");
                            break;

                        //Tag is "Test1.4.2"
                        case ConstStr.TestTagStrings.TagContent09:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            elementNum = sdtBlock.SdtContentBlock.Descendants<SdtBlock>().First().SdtProperties.Descendants<W15.SdtRepeatedSectionItem>().Count();

                            log.Verify(elementNum != 0, "Element does not appear as expected. Its elements are \"SdtRepeatedSectionItem\".");
                            break;

                        //Tag is "Test1.4.3"
                        case ConstStr.TestTagStrings.TagContent10:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            sdtRepeatedSection = sdtBlock.SdtProperties.Descendants<W15.SdtRepeatedSection>().First();

                            log.Verify(sdtRepeatedSection.DoNotAllowInsertDeleteSection.Val.Value == false, "Do not have the expected value element. Its values is \"0\" or \"false\".");
                            break;

                        //Tag is "Test1.4.4"
                        case ConstStr.TestTagStrings.TagContent11:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();
                            var sectionTitles = sdtBlock.Descendants<W15.SectionTitle>();
                            if (sectionTitles.Count() > 0)
                            {
                                log.VerifySubString(
                                    sectionTitles.First().Val,
                                    "TEST_TEST",
                                    "SectionTitle is detected and updated");
                            }
                            else
                            {
                                log.Fail("SectionTitle is not detected.");
                            }
                            break;

                        //Tag is "Test1.5.1_1"
                        case ConstStr.TestTagStrings.TagContent12:
                            SdtCell = tag.Ancestors<SdtCell>().First();

                            log.Verify(SdtCell.InnerText == ConstStr.TestStrings.ContentControlCellString1, string.Format("Do not have the expected value element. Its values is \"{0}\".", ConstStr.TestStrings.ContentControlCellString1));
                            break;

                        //Tag is "Test1.5.1_2"
                        case ConstStr.TestTagStrings.TagContent13:
                            SdtCell = tag.Ancestors<SdtCell>().First();

                            log.Verify(SdtCell.InnerText == ConstStr.TestStrings.ContentControlCellString2, string.Format("Do not have the expected value element. Its values is \"{0}\".", ConstStr.TestStrings.ContentControlCellString2));
                            break;

                        //Tag is "Test1.5.1_3"
                        case ConstStr.TestTagStrings.TagContent14:
                            SdtCell = tag.Ancestors<SdtCell>().First();

                            log.Verify(SdtCell.InnerText == ConstStr.TestStrings.ContentControlCellString3, string.Format("Do not have the expected value element. Its values is \"{0}\".", ConstStr.TestStrings.ContentControlCellString3));
                            break;

                        //Tag is "Test1.5.1_4"
                        case ConstStr.TestTagStrings.TagContent15:
                            SdtCell = tag.Ancestors<SdtCell>().First();

                            log.Verify(SdtCell.InnerText == ConstStr.TestStrings.ContentControlCellString4, string.Format("Do not have the expected value element. Its values is \"{0}\".", ConstStr.TestStrings.ContentControlCellString4));
                            break;

                        default:
                            log.Fail(string.Format("Unknown tag appeared. Tag name is [{0}]", tag.Val.Value));
                            break;
                    }
                }
            }
        }
    }
}
