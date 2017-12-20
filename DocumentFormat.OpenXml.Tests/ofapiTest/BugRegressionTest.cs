// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for BugRegressionTest
    /// </summary>
    public class BugRegressionTest : OpenXmlDomTestBase
    {
        /// <summary>
        ///Constructor.
        ///</summary>
        public BugRegressionTest(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <summary>
        /// Regress OpenXmlValidator bugs when validating against Office2007.
        /// </summary>
        [Fact]
        public void Validator2007BugRegressionTest()
        {
            OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2007);

            Bug423998(validator);
            Bug423974(validator);
            Bug424104(validator);
            Bug412116(validator);
            Bug345436(validator);
            Bug403545(validator);
            Bug429396(validator);
            Bug514988(validator);
            Bug448264(validator);
            Bug319778(validator);
            Bug643538(validator);
            Bug669663(validator);
            Bug583585(validator);
            Bug704004(validator);
            Bug743591(validator);
        }

        /// <summary>
        /// Regress OpenXmlValidator bugs when validating against Office2010.
        /// </summary>
        [Fact]
        public void Validator2010BugRegressionTest()
        {
            OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2010);

            Bug662644(validator);
            Bug662650(validator);
            Bug663841(validator);
            Bug663834(validator);
            Bug669663(validator);
            Bug704004(validator);
            Bug743591(validator);
        }

        #region validator bugs resgression

        [System.Diagnostics.Conditional("DEBUG")]
        private void AssertValidationErrorCategory(string expected, ValidationErrorInfo targetErrorInfo)
        {
#if DEBUG
            Assert.Equal(expected, targetErrorInfo.ValidationErrorCategory);
#endif
        }

        private void Bug743591(OpenXmlValidator validator)
        {
            //<xsd:complexType name="CT_ColorScale">
            //  <xsd:sequence>
            //    <xsd:element name="cfvo" type="CT_Cfvo" minOccurs="2" maxOccurs="unbounded">
            //    <xsd:element name="color" type="x:CT_Color" minOccurs="2" maxOccurs="unbounded">
            //  </xsd:sequence>
            //</xsd:complexType>

            DocumentFormat.OpenXml.Spreadsheet.ColorScale colorScale = new DocumentFormat.OpenXml.Spreadsheet.ColorScale(
"<x:colorScale xmlns:x=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\">" +
"    <x:cfvo type=\"min\" val=\"0\" />" +
"    <x:color theme=\"4\" />" +
"    <x:color theme=\"6\" />" +
"</x:colorScale>");

            var results = validator.Validate(colorScale);
            Assert.Single(results);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", results.First().Id);
            Assert.EndsWith(":cfvo>.", results.First().Description);

            colorScale.PrependChild(new DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValueObject() { Type = DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValueObjectValues.Min });
            results = validator.Validate(colorScale);
            Assert.Empty(results);

            colorScale.PrependChild(new DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValueObject() { Type = DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValueObjectValues.Max });
            results = validator.Validate(colorScale);
            Assert.Empty(results);

            colorScale.LastChild.Remove();
            results = validator.Validate(colorScale);
            Assert.Single(results);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", results.First().Id);
            Assert.EndsWith(":color>.", results.First().Description);

            colorScale.Append(new DocumentFormat.OpenXml.Spreadsheet.Color());
            colorScale.Append(new DocumentFormat.OpenXml.Spreadsheet.Color());
            results = validator.Validate(colorScale);
            Assert.Empty(results);
        }

        private void Bug704004(OpenXmlValidator validator)
        {
            //<w:p>
            //    <ve:AlternateContent />
            //    <w:r>
            //        <w:t>Acb</w:t>
            //        <w:rPr>
            //            <w:rFonts w:hint="eastAsia"/>
            //        </w:rPr>
            //    </w:r>
            //</w:p>
            Paragraph p = new Paragraph();
            AlternateContent acb = p.AppendChild(new AlternateContent());
            // one error, w:rPr should before the w:t
            p.AppendChild(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text() { Text = "Acb" },
                                  new RunProperties(new RunFonts() { Hint = FontTypeHintValues.EastAsia })
                                  )
                          );

            // an empty "AlternateContent"
            var errors = validator.Validate(p); // should no hang, no OOM
            Assert.Equal(2, errors.Count());
            Assert.Equal("Sch_IncompleteContentExpectingComplex", errors.First().Id);
            Assert.Same(p.FirstChild, errors.First().Node);  // acb should have a choice
            Assert.Same(p.FirstChild.NextSibling().FirstChild.NextSibling(), errors.ElementAt(1).RelatedNode);

            // append an empty "Choice"
            p.AddNamespaceDeclaration("w14", "http://w14");
            acb.AppendChild(new AlternateContentChoice() { Requires = "w14" });
            errors = validator.Validate(p); // should no hang, no OOM
            Assert.Single(errors);
            Assert.Same(p.FirstChild.NextSibling().FirstChild.NextSibling(), errors.ElementAt(0).RelatedNode);

            // append an empty "Fallback"
            acb.AppendChild(new AlternateContentFallback());
            errors = validator.Validate(p); // should no hang, no OOM
            Assert.Single(errors);
            Assert.Same(p.FirstChild.NextSibling().FirstChild.NextSibling(), errors.ElementAt(0).RelatedNode);
        }

        private void Bug583585(OpenXmlValidator validator)
        {
            var element = new DocumentFormat.OpenXml.Presentation.ModificationVerifier();
            element.SaltData = "8fkqu/A/6B1OQrRX1Vb3oQ";

            var errors = validator.Validate(element);
            Assert.Equal(7, errors.Count());
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_MissRequiredAttribute", errors.First().Id);
        }

        private void Bug669663(OpenXmlValidator validator)
        {
            var framePr = new FrameProperties();
            framePr.Height = 32767;

            var errors = validator.Validate(framePr);
            Assert.Single(errors);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", errors.First().Id);
            AssertValidationErrorCategory("Sch_MaxInclusiveConstraintFailed", errors.First());
        }

        private void Bug663834(OpenXmlValidator validator)
        {
            DocumentFormat.OpenXml.Wordprocessing.StatusText st = new StatusText();
            st.Val = "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";

            var errors = validator.Validate(st);
            Assert.Single(errors);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", errors.First().Id);
            AssertValidationErrorCategory("Sch_MaxLengthConstraintFailed", errors.First());
            Assert.EndsWith("The length must be smaller than or equal to 140.", errors.First().Description);
        }

        private void Bug663841(OpenXmlValidator validator)
        {
            DocumentFormat.OpenXml.Office2010.Ink.ContextNode cn = new DocumentFormat.OpenXml.Office2010.Ink.ContextNode() { Type = "root" };

            cn.RotatedBoundingBox = new ListValue<StringValue>();
            cn.RotatedBoundingBox.Items.Add("aaa");
            cn.RotatedBoundingBox.Items.Add("bbb");

            var errors = validator.Validate(cn);
            Assert.Single(errors);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", errors.First().Id);
        }

        private void Bug662650(OpenXmlValidator validator)
        {
            DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods spsm = new StylePaneSortMethods();
            spsm.Val = new StringValue();
            spsm.Val.Value = "aaaaaa";

            var errors = validator.Validate(spsm);
            Assert.Single(errors);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", errors.First().Id);
        }

        private void Bug662644(OpenXmlValidator validator)
        {
            DocumentFormat.OpenXml.Office2010.Excel.FormControlProperties fp = new DocumentFormat.OpenXml.Office2010.Excel.FormControlProperties();

            var errors = validator.Validate(fp);
            Assert.Empty(errors);

            fp.AppendChild(new DocumentFormat.OpenXml.Office2010.Excel.BorderColor());
            errors = validator.Validate(fp);
            Assert.Single(errors);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", errors.First().Id);
        }

        private void Bug643538(OpenXmlValidator validator)
        {
            var element = new DocumentFormat.OpenXml.Spreadsheet.OleObject() { ShapeId = 1 };

            // the EmbeddedObjectProperties is only valid in Office2010.
            element.EmbeddedObjectProperties = new DocumentFormat.OpenXml.Spreadsheet.EmbeddedObjectProperties();

            // In Office2007, the OleObject has no children.
            var errors = validator.Validate(element);
            Assert.Single(errors);
            Assert.Same(element, errors.First().Node);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", errors.First().Id);

            // Office2010, no error on OleObject, but an error on EmbeddedObjectProperties.
            var o14Validator = new OpenXmlValidator(FileFormatVersions.Office2010);
            errors = o14Validator.Validate(element);
            Assert.Single(errors);
            Assert.Same(element.EmbeddedObjectProperties, errors.First().Node);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", errors.First().Id);
        }

        private void Bug319778(OpenXmlValidator validator)
        {
            DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare element = new DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare();

            element.WrapText = DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues.Left;
            element.DistanceFromLeft = new UInt32Value();
            element.DistanceFromLeft.InnerText = "Foo";

            var errors = validator.Validate(element);
            Assert.Single(errors);
            Assert.Same(element, errors.First().Node);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", errors.First().Id);
            Assert.Equal("The attribute 'distL' has invalid value 'Foo'. The string 'Foo' is not a valid 'UInt32' value.", errors.First().Description);
        }

        private void Bug448264(OpenXmlValidator validator)
        {
            TableCellMarginDefault tcmd = new TableCellMarginDefault();
            tcmd.AppendChild(new TopMargin());
            var errorChild = tcmd.AppendChild(new LeftMargin()); // LeftMargin is wrong elemnt, it should be TableCellLeftMargin, but the two element has same element tag.

            var errors = validator.Validate(tcmd);
            Assert.Single(errors);
            Assert.Same(tcmd, errors.First().Node);
            Assert.Same(errorChild, errors.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_InvalidElementContentWrongType", errors.First().Id);
            Assert.Equal("The element has child element 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:left' of invalid type 'LeftMargin'.", errors.First().Description);
        }

        private void Bug514988(OpenXmlValidator validator)
        {
            var paragraph = new Paragraph();
            paragraph.RsidParagraphAddition = new HexBinaryValue();
            OpenXmlAttribute rsidR = paragraph.GetAttribute("rsidR", paragraph.NamespaceUri);
            OpenXmlAttribute newattr = new OpenXmlAttribute(rsidR.LocalName, rsidR.NamespaceUri, "0102");
            paragraph.SetAttribute(newattr);
            var errors = new OpenXmlValidator().Validate(paragraph);
            Assert.Single(errors);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", errors.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:rsidR' has invalid value '0102'. The actual length according to datatype 'hexBinary' is not equal to the specified length. The expected length is 4.", errors.First().Description);
        }

        private void Bug423988(OpenXmlValidator validator)
        {
            var shape = new DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape();
            shape.TextBody = new DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody();
            var errors = validator.Validate(shape);
            Assert.Single(errors);
            Assert.Same(shape, errors.First().Node);
            Assert.Same(shape.TextBody, errors.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, errors.First().ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", errors.First().Id);
        }

        private void Bug429396(OpenXmlValidator validator)
        {
            DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity docsecurity = new DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity();

            var errors = validator.Validate(docsecurity);
            Assert.Single(errors);
            Assert.EndsWith("The text value cannot be empty.", errors.First().Description);
        }

        private void Bug425476(OpenXmlValidator validator)
        {
            var element = new Shading() { Color = "invalid union value", Val = ShadingPatternValues.Percent10 };
            var errors = validator.Validate(element);
            Assert.Single(errors);
        }

        private void Bug412116(OpenXmlValidator validator)
        {
            DocumentFormat.OpenXml.Drawing.Charts.Trendline tl = new DocumentFormat.OpenXml.Drawing.Charts.Trendline();
            tl.AppendChild(new DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties());
            var errors = validator.Validate(tl);
            Assert.Single(errors);
            Assert.Same(tl, errors.First().Node);
        }

        private void Bug345436(OpenXmlValidator validator)
        {
            var p = new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.SectionProperties());
            var errors = validator.Validate(p);
            Assert.Single(errors);
            Assert.Same(p, errors.First().Node);
            Assert.EndsWith("List of possible elements expected: <http://schemas.openxmlformats.org/wordprocessingml/2006/main:pPr>.", errors.First().Description);
        }

        private void Bug403545(OpenXmlValidator validator)
        {
            var lvl = new Level() { LevelIndex = 0 };
            lvl.AppendChild(new StartNumberingValue() { Val = 1 });
            lvl.AddNamespaceDeclaration("O15", "http://O15.com");
            var ac = lvl.AppendChild(new AlternateContent(new AlternateContentChoice() { Requires = "O15" }, new AlternateContentFallback()));
            var errors = validator.Validate(lvl);
            Assert.Empty(errors);
        }

        private void Bug424104(OpenXmlValidator validator)
        {
            //
            // change <xsd:any > to <xsd:any minOccurs=0 in CT_OfficeArtExtension"
            DocumentFormat.OpenXml.Drawing.Extension ext = new DocumentFormat.OpenXml.Drawing.Extension() { Uri = "test" };
            var errors = validator.Validate(ext);
            Assert.Empty(errors);

            // CT_Extension in PPT, <xsd:any > wihtout minOccurs
            var pext = new DocumentFormat.OpenXml.Presentation.Extension();
            pext.Uri = "http://www.live.com";
            errors = validator.Validate(pext);
            Assert.Single(errors);
            Assert.EndsWith("any element in namespace '##any'.", errors.First().Description);
        }

        private void Bug423974(OpenXmlValidator validator)
        {
            var element = new DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape();
            var errors = validator.Validate(element);
            Assert.Single(errors);
            Assert.Equal("The element has incomplete content.".Length, errors.First().Description.LastIndexOf(" List of possible elements expected:"));
        }

        private void Bug423998(OpenXmlValidator validator)
        {
            var element = new DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape();
            var errors = validator.Validate(element);
            Assert.Single(errors);
            Assert.Equal("The element has incomplete content.".Length, errors.First().Description.LastIndexOf(" List of possible elements expected:"));

            element.AppendChild(new DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody());
            var errors2 = validator.Validate(element);
            Assert.Equal(2, errors2.Count());

            var message1 = errors.First().Description;
            var list1 = message1.Substring(message1.IndexOf("List of possible elements expected:"));

            var message2 = errors.First().Description;
            var list2 = message2.Substring(message2.IndexOf("List of possible elements expected:"));

            Assert.Equal(list1, list2);
        }

        #endregion

        /// <summary>
        ///Bug448241
        ///</summary>
        [Fact]
        public void Bug448241()
        {
            DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault tablecellmar = new DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault();
            var wrongChild = tablecellmar.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.LeftMargin());
            var leftmar = tablecellmar.TableCellLeftMargin;

            // should be null, as the correct child should be TableCellLeftMargin
            Assert.Null(leftmar);

            tablecellmar.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.BottomMargin());
            Assert.Null(leftmar);

            // **** Set a correct left.
            var correctChild = tablecellmar.TableCellLeftMargin = new TableCellLeftMargin();
            Assert.NotNull(tablecellmar.TableCellLeftMargin);
            Assert.Same(tablecellmar.LastChild, tablecellmar.BottomMargin);

            // the wrong child should still be there.
            Assert.Same(wrongChild, tablecellmar.FirstChild);

            // **** Top, wrong, correctLeft, Bottom
            tablecellmar.TopMargin = new TopMargin();
            Assert.NotNull(tablecellmar.TableCellLeftMargin);
            Assert.Same(tablecellmar.LastChild, tablecellmar.BottomMargin);
            Assert.Same(tablecellmar.FirstChild, tablecellmar.TopMargin);

            // the wrong child should still be there.
            Assert.Same(wrongChild, tablecellmar.FirstChild.NextSibling());

            // **** Top, wrong, Bottom
            tablecellmar.RemoveChild(correctChild);
            Assert.Null(tablecellmar.TableCellLeftMargin);
            Assert.Same(tablecellmar.LastChild, tablecellmar.BottomMargin);
            Assert.Same(tablecellmar.FirstChild, tablecellmar.TopMargin);

            // the wrong child should still be there.
            Assert.Same(wrongChild, tablecellmar.FirstChild.NextSibling());

            // =========== case for xsd:choice ==============
            var shapeTaget = new DocumentFormat.OpenXml.Presentation.ShapeTarget();
            var wrongBg = shapeTaget.AppendChild(new DocumentFormat.OpenXml.Presentation.Background());

            Assert.Null(shapeTaget.BackgroundAnimation);

            // **** set a correct one.
            var correctBg = shapeTaget.BackgroundAnimation = new DocumentFormat.OpenXml.Presentation.BackgroundAnimation();

            Assert.Equal(1, shapeTaget.ChildElements.Count);
            Assert.Same(correctBg, shapeTaget.BackgroundAnimation);
        }

        /// <summary>
        ///Bug396358
        ///</summary>
        [Fact]
        public void Bug396358()
        {
            using (var stream = GetStream(TestFiles.mailmerge, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var part = doc.MainDocumentPart.DocumentSettingsPart.MailMergeRecipientDataPart;

                Assert.Null(part.MailMergeRecipients);
                Assert.NotNull(part.Recipients);
                Assert.NotNull(part.PartRootElement);
                Assert.IsType<Recipients>(part.PartRootElement);

                part.Recipients = new Recipients();

                Assert.Throws<InvalidOperationException>(() => part.MailMergeRecipients = new DocumentFormat.OpenXml.Office.Word.MailMergeRecipients());
            }
        }

        /// <summary>
        ///Bug537858
        ///</summary>
        [Fact]
        public void Bug537858()
        {
            var s = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.animation, true))
            using (var doc = PresentationDocument.Open(stream, true, s))
            {
                var sp = doc.PresentationPart.GetPartById("rId4") as SlidePart;
                var t = sp.Slide.ChildElements[2] as Transition;

                Assert.Empty(t.ExtendedAttributes);
                Assert.Single(t.NamespaceDeclarations);
            }
        }

        /// <summary>
        ///Bug544244
        ///</summary>
        [Fact]
        public void Bug544244()
        {
            var pageMargins = new DocumentFormat.OpenXml.Spreadsheet.PageMargins();
            pageMargins.Header = new DoubleValue();
            pageMargins.Header.InnerText = "0.51200000000000001";
            pageMargins.Top = 1;

            Assert.Equal("1", pageMargins.Top.ToString());
            Assert.Equal("0.51200000000000001", pageMargins.Header.InnerText);
            Assert.Equal(0.512, pageMargins.Header.Value);
            Assert.Equal("0.51200000000000001", pageMargins.Header.InnerText);
        }

        /// <summary>
        ///Bug665268
        ///</summary>
        [Fact]
        public void Bug665268()
        {
            var comment = new DocumentFormat.OpenXml.Wordprocessing.Comment();
            comment.Date = new DateTimeValue();
            comment.Date.InnerText = "2007-04-24T15:42:11.037";
            Assert.True(comment.Date.HasValue);
            Assert.Equal("2007-04-24T15:42:11.037", comment.Date.InnerText);
        }
    }
}
