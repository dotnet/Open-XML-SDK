// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Internal.SchemaValidation;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for McValidationTest
    /// </summary>
    
    public class McValidationTest
    {
        ///<summary>
        ///Constructor.
        ///</summary>
        public McValidationTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        /// Test ACB syntax 
        /// </summary>
        [Fact]
        public void AcbSyntaxValidationTest()
        {
            var validator = new SchemaValidator();
            var element = new Run();
            var acFallback = new AlternateContentFallback();
            var ac = element.AppendChild(new AlternateContent());
            var errors = validator.Validate(ac).Errors;
            // Error case: must have one choice, can not have AlternateContent as di
            Assert.Equal(1, errors.Count());
            Assert.Equal("Sch_IncompleteContentExpectingComplex", errors[0].Id);

            ac.AddNamespaceDeclaration("o15", "http://o15.com");
            //ac.NamespaceDeclarations
            ac.AppendChild(new AlternateContentChoice() { Requires = "o15" });
            errors = validator.Validate(ac).Errors;
            Assert.Equal(0, errors.Count());

            ac.AddNamespaceDeclaration("o14", "http://o14.com");
            ac.PrependChild(new AlternateContentChoice() { Requires = "o14" });
            errors = validator.Validate(ac).Errors;
            Assert.Equal(0, errors.Count());

            ac.AppendChild(acFallback);
            errors = validator.Validate(ac).Errors;
            Assert.Equal(0, errors.Count());

            // Error case: should not contains AlternateContent directly as child.
            ac.AppendChild(new AlternateContent());
            errors = validator.Validate(ac).Errors;
            Assert.Equal(1, errors.Count());
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", errors.First().Id);
            ac.RemoveChild(ac.LastChild);

            // Error case: can only contains one Fallback.
            ac.AppendChild(new AlternateContentFallback());
            errors = validator.Validate(ac).Errors;
            Assert.Equal(1, errors.Count());
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", errors.First().Id);
            ac.RemoveChild(ac.LastChild);

            ac.RemoveChild(acFallback);
            // Error case: wrong sequence
            ac.PrependChild(acFallback);
            errors = validator.Validate(ac).Errors;
            Assert.Equal(1, errors.Count());
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", errors.First().Id);
            ac.RemoveChild(acFallback);
            ac.Append(acFallback);

            var langAttribute = new OpenXmlAttribute("xml:lang", "http://www.w3.org/XML/1998/namespace", "en-us");
            ac.SetAttribute(langAttribute);
            errors = validator.Validate(ac).Errors;
            Assert.Equal(1, errors.Count());
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Equal("MC_InvalidXmlAttribute", errors.First().Id);
            Assert.Equal( "The AlternateContent element should not have an xml:lang or xml:space attribute.", errors[0].Description);
            ac.RemoveAttribute(langAttribute.LocalName, langAttribute.NamespaceUri);

            ac.FirstChild.SetAttribute(langAttribute);
            errors = validator.Validate(ac).Errors;
            Assert.Equal(1, errors.Count());
            Assert.Same(ac.FirstChild, errors[0].Node);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Equal("MC_InvalidXmlAttribute", errors.First().Id);
            Assert.Equal("The Choice element should not have an xml:lang or xml:space attribute.", errors[0].Description);
            ac.FirstChild.RemoveAttribute(langAttribute.LocalName, langAttribute.NamespaceUri);

            ac.LastChild.SetAttribute(langAttribute);
            errors = validator.Validate(ac).Errors;
            Assert.Equal(1, errors.Count());
            Assert.Same(ac.LastChild, errors[0].Node);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Equal("MC_InvalidXmlAttribute", errors.First().Id);
            Assert.Equal("The Fallback element should not have an xml:lang or xml:space attribute.", errors[0].Description);
            ac.LastChild.RemoveAttribute(langAttribute.LocalName, langAttribute.NamespaceUri);

            AlternateContentChoice choice1 = ac.FirstChild as AlternateContentChoice;
            choice1.Requires = "o17 o15";
            errors = validator.Validate(ac).Errors;
            Assert.Equal(1, errors.Count());
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Same(choice1, errors[0].Node);
            Assert.Equal("MC_InvalidRequiresAttribute", errors.First().Id);
            Assert.Equal("The Requires attribute is invalid - The value 'o17 o15' contains an invalid prefix that is not defined.", errors[0].Description);

            choice1.Requires = null;
            errors = validator.Validate(ac).Errors;
            Assert.Equal(ValidationErrorType.MarkupCompatibility, errors.First().ErrorType);
            Assert.Equal(1, errors.Count());
            Assert.Same(choice1, errors[0].Node);
            Assert.Equal("MC_MissedRequiresAttribute", errors.First().Id);
            Assert.Equal("All Choice elements must have a Requires attribute whose value contains a whitespace delimited list of namespace prefixes.", errors[0].Description);
        }

        /// <summary>
        /// Test compatibility-rule attributes
        /// </summary>
        [Fact]
        public void CompatibilityRuleAttributesValidationTest()
        {
            var validator = new SchemaValidator();
            var element = new Paragraph();
            var run = new Run();
            
            element.AppendChild(run);

            var result = validator.Validate(element);
            Assert.True(result.Valid);

            element.AddNamespaceDeclaration("o15", "http://o15.com");
            result = validator.Validate(element);
            Assert.True(result.Valid);

            run.MCAttributes = new MarkupCompatibilityAttributes();
            run.MCAttributes.Ignorable = "o15";
            result = validator.Validate(element);
            Assert.True(result.Valid);

            run.AddNamespaceDeclaration("w15", "http://w15.com");
            result = validator.Validate(element);
            Assert.True(result.Valid);

            run.MCAttributes.Ignorable = "o15 w15";
            result = validator.Validate(element);
            Assert.True(result.Valid);

            run.MCAttributes.PreserveAttributes = "  o15:id w15:*";
            run.MCAttributes.PreserveElements = "o15:*  w15:*  ";
            run.MCAttributes.ProcessContent = "  o15:newE   w15:newW  ";
            result = validator.Validate(element);
            Assert.True(result.Valid);

            run.MCAttributes.PreserveElements = "x15:* ";
            result = validator.Validate(element);
            Assert.False(result.Valid);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, result.Errors[0].ErrorType);
            Assert.Equal("MC_InvalidPreserveElementsAttribute", result.Errors[0].Id);

            run.MCAttributes.Ignorable = null;
            run.MCAttributes.PreserveAttributes = null;
            run.MCAttributes.PreserveElements = "w15:*";
            run.MCAttributes.ProcessContent = "";
            result = validator.Validate(element);
            Assert.False(result.Valid);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, result.Errors[0].ErrorType);
            Assert.Equal("MC_InvalidPreserveElementsAttribute", result.Errors[0].Id);

            run.MCAttributes.Ignorable = "o15";
            run.MCAttributes.PreserveAttributes = "";
            run.MCAttributes.PreserveElements = "w15:*";
            result = validator.Validate(element);
            Assert.False(result.Valid);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, result.Errors[0].ErrorType);
            Assert.Equal("MC_InvalidPreserveElementsAttribute", result.Errors[0].Id);
            run.MCAttributes.PreserveElements = null;

            run.MCAttributes.ProcessContent = "w14:newW";
            result = validator.Validate(element);
            Assert.False(result.Valid);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, result.Errors[0].ErrorType);
            Assert.Equal("MC_InvalidProcessContentAttribute", result.Errors[0].Id);
            run.MCAttributes.ProcessContent = null;

            var spaceAttribute = new OpenXmlAttribute("xml:space", "http://www.w3.org/XML/1998/namespace", "preserve");
            run.MCAttributes.ProcessContent = "o15:newP";
            run.SetAttribute(spaceAttribute);
            result = validator.Validate(element);
            Assert.False(result.Valid);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, result.Errors[0].ErrorType);
            Assert.Equal("MC_InvalidXmlAttributeWithProcessContent", result.Errors[0].Id);
            run.MCAttributes.ProcessContent = null;
            
            run.SetAttribute(new OpenXmlAttribute("o15:id", "http://o15.com", "1"));
            result = validator.Validate(element);
            Assert.True(result.Valid);

            run.MCAttributes.Ignorable = "o15 w15 x15";
            result = validator.Validate(element);
            Assert.False(result.Valid);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal(ValidationErrorType.MarkupCompatibility, result.Errors[0].ErrorType);
            Assert.Equal("MC_InvalidIgnorableAttribute", result.Errors[0].Id);

            run.MCAttributes.Ignorable = "o15 w15";
            run.SetAttribute(new OpenXmlAttribute("x15:id", "http://x15.com", "1"));
            result = validator.Validate(element);
            Assert.False(result.Valid);
            Assert.Equal(1, result.Errors.Count);
        }

        /// <summary>
        /// Test the following functions.
        /// GetFirstChildMc(this OpenXmlElement parent, MCContext mcContext, MCMode mcMode)
        /// GetNextChildMc(this OpenXmlElement parent, OpenXmlElement child, MCContext mcContext, MCMode mcMode)
        /// </summary>
        [Fact]
        public void GetChildMcTest()
        {
            MCContext mcContext = new MCContext();
            ParagraphProperties pPr;
            Run run1, run2;
            Paragraph p = new Paragraph(pPr = new ParagraphProperties() { WordWrap = new WordWrap() { Val = true } },
                                         new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comments -->"),
                                         run1 = new Run(new Text("Text 1.")),
                                         run2 = new Run(new Text("Text 2.")));

            var target = p.GetFirstChildMc(mcContext, FileFormatVersions.Office2007);
            Assert.Same(pPr, target);
            target = p.GetNextChildMc(target, mcContext, FileFormatVersions.Office2007);
            Assert.Same(run1, target);
            target = p.GetNextChildMc(target, mcContext, FileFormatVersions.Office2007);
            Assert.Same(run2, target);

            OpenXmlUnknownElement ignorableElement = new OpenXmlUnknownElement("w14test", "span", "http://w14.com");
            p.AddNamespaceDeclaration("w14test", "http://w14.com");

            ignorableElement.MCAttributes = new MarkupCompatibilityAttributes() { Ignorable="w14test" };
            p.InsertAfter(ignorableElement, pPr);
            
            mcContext = new MCContext();
            target = p.GetFirstChildMc(mcContext, FileFormatVersions.Office2007);
            Assert.Same(pPr, target);
            target = p.GetNextChildMc(target, mcContext, FileFormatVersions.Office2007);
            Assert.Same(run1, target);
            target = p.GetNextChildMc(target, mcContext, FileFormatVersions.Office2007);
            Assert.Same(run2, target);

            Run runInAcb = new Run(new Text("Text in ACB."));
            AlternateContent acb = new AlternateContent(new AlternateContentChoice() { Requires = "w14test" },
                                                        new AlternateContentFallback(runInAcb));
            p.InsertAfter(acb, pPr);

            mcContext = new MCContext();
            target = p.GetFirstChildMc(mcContext, FileFormatVersions.Office2007);
            Assert.Same(pPr, target);
            target = p.GetNextChildMc(target, mcContext, FileFormatVersions.Office2007);
            Assert.Same(runInAcb, target);
            target = p.GetNextChildMc(target, mcContext, FileFormatVersions.Office2007);
            Assert.Same(run1, target);
            target = p.GetNextChildMc(target, mcContext, FileFormatVersions.Office2007);
            Assert.Same(run2, target);
        }
         
        /// <summary>
        /// Validating MC.
        /// </summary>
        [Fact]
        public void AcbValidationTest()
        {
            MCContext mcContext = new MCContext();
            ParagraphProperties pPr;
            Run run1, run2;
            Paragraph p = new Paragraph(pPr = new ParagraphProperties() { WordWrap = new WordWrap() { Val = true } },
                                         new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comments -->"),
                                         run1 = new Run(new Text("Text 1.")),
                                         run2 = new Run(new Text("Text 2.")));

            p.AddNamespaceDeclaration("w14test", "http://w14.com");

            OpenXmlUnknownElement ignorableElement = new OpenXmlUnknownElement("w14test", "span", "http://w14.com");
            ignorableElement.MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14test" };
            p.InsertAfter(ignorableElement, pPr);

            Run runInAcb = new Run(new Text("Text in ACB."));
            Run run2InAcb = new Run(new Text("Text 2 in ACB."));
            AlternateContent acb = new AlternateContent(new AlternateContentChoice() { Requires = "w14test" },
                                                        new AlternateContentFallback(runInAcb, run2InAcb));
            p.InsertAfter(acb, pPr);

            var validator = new OpenXmlValidator();
            var errors = validator.Validate(p);
            Assert.Equal(0, errors.Count());

            p.AppendChild(new OpenXmlUnknownElement("w15test", "art", "http://w15.com"));
            errors = validator.Validate(p);
            Assert.Equal(1, errors.Count());
            p.RemoveChild(p.LastChild);

            acb.LastChild.Append(new OpenXmlUnknownElement("w15test", "art", "http://w15.com"));
            errors = validator.Validate(p);
            Assert.Equal(1, errors.Count());
        }

               
        /// <summary>
        /// Validating content under ACB.
        /// </summary>
        [Fact]
        public void AcbContentValidationTest()
        {
            string xml = "<w:p xmlns:w14=\"http://schemas.microsoft.com/office/word/2010/wordml\" mc:Ignorable=\"w14\" " +
                "xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" xmlns:v=\"urn:schemas-microsoft-com:vml\" " +
            "xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidR=\"00A35C47\" w14:paraId=\"017B6C57\" w14:editId=\"32F17AD3\" >" +
            "<w:r><mc:AlternateContent>" +
            "<mc:Choice Requires=\"w14\"><w:drawing><v:rect/></w:drawing></mc:Choice>" +
            "<mc:Fallback><w:pict><v:textbox/></w:pict></mc:Fallback>" +
            "</mc:AlternateContent></w:r>" +
            "</w:p>";

            var p = new Paragraph(xml);
            var acb = p.FirstChild.FirstChild as AlternateContent;

            // Should report error in the "Choice" branch.
            var validator = new OpenXmlValidator(FileFormatVersions.Office2010);
            var errors = validator.Validate(p);
            Assert.Equal(1, errors.Count());
            Assert.Same(acb.FirstChild.FirstChild, errors.First().Node);


            // Should report error in "Fallback" branch.
            validator = new OpenXmlValidator(FileFormatVersions.Office2007);
            errors = validator.Validate(p);
            Assert.Equal(1, errors.Count());
            Assert.Same(acb.LastChild.FirstChild, errors.First().Node);
        }
    }
}
