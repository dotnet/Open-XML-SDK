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

    public class EditElement
    {
        public static void EditContentControlElements(string filePath, VerifiableLog log)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(filePath, true))
            {
                foreach (Tag tag in package.MainDocumentPart.Document.Descendants<Tag>())
                {
                    SdtBlock sdtBlock;
                    W15.SdtRepeatedSection sdtRepeatedSection;

                    switch (tag.Val.Value)
                    {
                        //Tag is "Test1.1.1"
                        //Edit run style(value="PlaceholderText") element is remove
                        case ConstStr.TestTagStrings.TagContent01:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            sdtBlock.SdtContentBlock.Descendants<RunStyle>().Where(e => e.Val == ConstStr.RunStyleValues.Placeholder).First().Remove();
                            sdtBlock.SdtContentBlock.Descendants<Text>().First().Text = ConstStr.TestStrings.ContentControlString2;

                            log.Pass(string.Format("Edit Content Control string and string style of target tag=[{0}], Remove is style(value=\"PlaceholderText\") element.", ConstStr.TestTagStrings.TagContent01));
                            break;

                        //Tag is "Test1.1.2"
                        //Edit run style(value="PlaceholderText") element is append child
                        case ConstStr.TestTagStrings.TagContent02:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            RunStyle runStyle = new RunStyle();
                            runStyle.Val = ConstStr.RunStyleValues.Placeholder;
                            sdtBlock.SdtContentBlock.Descendants<Run>().First().RunProperties.AppendChild<RunStyle>(runStyle);

                            sdtBlock.SdtContentBlock.Descendants<Text>().First().Text = ConstStr.TestStrings.ContentControlString1;

                            log.Pass(string.Format("Edit Content Control string and string style of target tag=[{0}], Remove is style(value=\"PlaceholderText\") element.", ConstStr.TestTagStrings.TagContent02));
                            break;

                        //Tag is "Test1.2.1"
                        //Edit Appearance element in attribute. It's value "Tag"
                        case ConstStr.TestTagStrings.TagContent03:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            if (sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count() == 0)
                            {
                                W15.Appearance appearance = new W15.Appearance();
                                appearance.Val = W15.SdtAppearance.Tags;

                                sdtBlock.SdtProperties.AppendChild<W15.Appearance>(appearance);

                                log.Pass(string.Format("Edit Content Control an appearance element in attribute of target tag=[{0}], Append an appearance element(value=Tga).", ConstStr.TestTagStrings.TagContent03));
                            }
                            else
                            {
                                sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val.Value = W15.SdtAppearance.Tags;

                                log.Pass(string.Format("Edit Content Control an appearance element in attribute of target tag=[{0}], Change an appearance attribute(value=Tga).", ConstStr.TestTagStrings.TagContent03));
                            }
                                
                            break;

                        //Tag is "Test1.2.2"
                        //Edit Appearance element in attribute. It's value "Hidden"
                        case ConstStr.TestTagStrings.TagContent04:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            if (sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count() == 0)
                            {
                                W15.Appearance appearance = new W15.Appearance();
                                appearance.Val = W15.SdtAppearance.Hidden;

                                sdtBlock.SdtProperties.AppendChild<W15.Appearance>(appearance);

                                log.Pass(string.Format("Edit Content Control an appearance element in attribute of target tag=[{0}], Append an appearance element(value=Hidden).", ConstStr.TestTagStrings.TagContent04));
                            }
                            else
                            {
                                sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val.Value = W15.SdtAppearance.Hidden;

                                log.Pass(string.Format("Edit Content Control an appearance element in attribute of target tag=[{0}], Change an appearance attribute(value=Hidden).", ConstStr.TestTagStrings.TagContent04));
                            }
                            break;

                        //Tag is "Test1.2.3"
                        //Edit Appearance element in attribute. It's value "BoundingBox"
                        case ConstStr.TestTagStrings.TagContent05:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            if (sdtBlock.SdtProperties.Descendants<W15.Appearance>().Count() == 0)
                            {
                                W15.Appearance appearance = new W15.Appearance();
                                appearance.Val = W15.SdtAppearance.BoundingBox;

                                sdtBlock.SdtProperties.AppendChild<W15.Appearance>(appearance);

                                log.Pass(string.Format("Edit Content Control an appearance element in attribute of target tag=[{0}], Append an appearance element(value=BoundingBox).", ConstStr.TestTagStrings.TagContent05));
                            }
                            else
                            {
                                sdtBlock.SdtProperties.Descendants<W15.Appearance>().First().Val.Value = W15.SdtAppearance.BoundingBox;

                                log.Pass(string.Format("Edit Content Control an appearance element in attribute of target tag=[{0}], Change an appearance attribute(value=BoundingBox).", ConstStr.TestTagStrings.TagContent05));
                            }
                            break;

                        //Tag is "Test1.3.1"
                        //Edit Color element. The value of its element, make changes or value added.
                        case ConstStr.TestTagStrings.TagContent06:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            if (sdtBlock.SdtProperties.Descendants<W15.Color>().Count() == 0)
                            {
                                W15.Color color = new W15.Color();
                                color.Val = ConstStr.TestColorValues.TestColor;

                                sdtBlock.SdtProperties.AppendChild<W15.Color>(color);

                                log.Pass(string.Format("Edit Content Control a color element of target tag=[{0}], Append a Color element(value={1}).", ConstStr.TestTagStrings.TagContent06, ConstStr.TestColorValues.TestColor));
                            }
                            else
                            {
                                W15.Color color =  sdtBlock.SdtProperties.Descendants<W15.Color>().First();
                                color.Val = ConstStr.TestColorValues.TestColor;

                                log.Pass(string.Format("Edit Content Control a color element of target tag=[{0}], Change a Color element value={1}.", ConstStr.TestTagStrings.TagContent06, ConstStr.TestColorValues.TestColor));
                            }
                            break;

                        //Tag is "Test1.3.2"
                        //Edit Color element. Removes the element.
                        case ConstStr.TestTagStrings.TagContent07:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            if (sdtBlock.SdtProperties.Descendants<W15.Color>().Count() != 0)
                            {
                                sdtBlock.SdtProperties.Descendants<W15.Color>().First().Remove();

                                log.Pass(string.Format("Edit Content Control a color element of target tag=[{0}], Removes the element.", ConstStr.TestTagStrings.TagContent07));
                            }
                            else
                            {
                                log.Fail(string.Format("Not found to be edited. Target tag=[{0}].", ConstStr.TestTagStrings.TagContent07));
                            }
                            break;

                        //Tag is "Test1.4.3"
                        //Edit DoNotAllowInsertDeleteSection element. The value of its element, make changes or value added.
                        case ConstStr.TestTagStrings.TagContent10:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();

                            if (sdtBlock.SdtProperties.Descendants<W15.SdtRepeatedSection>().Count() != 0)
                            {
                                sdtRepeatedSection = sdtBlock.SdtProperties.Descendants<W15.SdtRepeatedSection>().First();
                                sdtRepeatedSection.DoNotAllowInsertDeleteSection.Val.Value = false;

                                log.Pass(string.Format("Edit Content Control a DoNotAllowInsertDeleteSection element of target tag=[{0}], Change The DoNotAllowInsertDeleteSection element. Its element in attribute value is false.", ConstStr.TestTagStrings.TagContent10));
                            }
                            else
                            {
                                sdtRepeatedSection = new W15.SdtRepeatedSection();
                                sdtRepeatedSection.DoNotAllowInsertDeleteSection.Val.Value = false;
                                sdtBlock.SdtProperties.AppendChild<W15.SdtRepeatedSection>(sdtRepeatedSection);

                                log.Pass(string.Format("Edit Content Control a DoNotAllowInsertDeleteSection element of target tag=[{0}], Append The DoNotAllowInsertDeleteSection element. Its element in attribute value is false.", ConstStr.TestTagStrings.TagContent10));
                            } 
                            break;

                        //Tag is "Test1.4.4"
                        //Edit sectionTitle element. The value of its element, make changes or value added.
                        case ConstStr.TestTagStrings.TagContent11:
                            sdtBlock = tag.Ancestors<SdtBlock>().First();
                                
                            var sectionTitles = sdtBlock.Descendants<W15.SectionTitle>();
                            if (sectionTitles.Count() > 0)
                            {
                                sectionTitles.First().Val = "TEST_TEST";
                                log.Pass("SectionTitle is detected and updated.");
                            }
                            else
                            {
                                log.Fail("SectionTitle is not found.");
                            }
                            break;
                    }
                }
            }
        }
    }
}
