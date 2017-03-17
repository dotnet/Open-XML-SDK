// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml;
using Xunit;
using DocumentFormat.OpenXml.Wordprocessing;
using W = DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlCompositeElementTest and is intended
    ///to contain all OpenXmlCompositeElementTest Unit Tests
    ///</summary>
    
    public class OpenXmlCompositeElementTest
    {


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
        ///A test for PrependChild
        ///</summary>
        public void PrependChildTestHelper<T>()
            where T : OpenXmlElement
        {
            OpenXmlCompositeElement target = CreateOpenXmlCompositeElement();
            T newChild = default(T);
            T expected = default(T);
            T actual;
            actual = target.PrependChild<T>(newChild);
            Assert.Equal(expected, actual);
        }

        internal virtual OpenXmlCompositeElement CreateOpenXmlCompositeElement()
        {
            // TODO: Instantiate an appropriate concrete class.
            OpenXmlCompositeElement target = null;
            return target;
        }

        /// <summary>
        /// Test the GetElement() / SetElement() in class OpenXmlCompositeElement
        /// </summary>
        [Fact]
        public void CompositeElementGetSetChildrenTest()
        {
            // test case for OpenXmlCompositeType.OneSequence
            RunProperties target = new RunProperties();
            Bold bold = new Bold();
            target.Bold = bold;

            Assert.Same(bold, target.Bold);
            Assert.Same(bold, target.FirstChild);

            Italic italic = new Italic();
            target.AppendChild(italic);
            Assert.Same(bold, target.Bold);
            Assert.Same(italic, target.Italic);
            Assert.Same(italic, target.LastChild);

            OpenXmlMiscNode miscNod = new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, @"<!-- my comment --> ");
            target.InsertAfter(miscNod, italic);
            Assert.Same(bold, target.Bold);
            Assert.Same(italic, target.Italic);
            Assert.Same(miscNod, target.LastChild);

            Caps caps = new Caps();
            target.Caps = caps;
            Assert.Same(bold, target.Bold);
            Assert.Same(italic, target.Italic);
            Assert.Same(caps, target.Caps);
            Assert.Same(miscNod, target.LastChild);

            Shadow shadow = new Shadow();
            target.InsertAfter(shadow, miscNod);
            Assert.Same(bold, target.Bold);
            Assert.Same(italic, target.Italic);
            Assert.Same(caps, target.Caps);
            Assert.Same(shadow, target.Shadow);
            Assert.Same(shadow, target.LastChild);

            // test case for OpenXmlCompositeType.OneChoice
            FieldChar fieldChar = new FieldChar();
           
            FieldData fldData = new FieldData();
            fieldChar.FieldData = fldData;
            Assert.Same(fldData, fieldChar.FieldData);

            FormFieldData ffData = new FormFieldData();
            fieldChar.FormFieldData = ffData;
            Assert.Same(ffData, fieldChar.FormFieldData);
            Assert.Null(fieldChar.FieldData);

            miscNod = new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, @"<!-- OpenXmlCompositeType.OneChoice --> ");
            fieldChar.PrependChild(miscNod);
            Assert.Same(miscNod, fieldChar.FirstChild);
            Assert.Same(ffData, fieldChar.LastChild);
            Assert.Same(ffData, fieldChar.FormFieldData);
            Assert.Null(fieldChar.FieldData);

            NumberingChange numChange = new NumberingChange();
            fieldChar.NumberingChange = numChange;
            Assert.Same(miscNod, fieldChar.FirstChild);
            Assert.Same(numChange, fieldChar.LastChild);
            Assert.Same(numChange, fieldChar.NumberingChange);
            Assert.Null(fieldChar.FieldData);


        }

    
        /// <summary>
        /// Test the class factory of GraphicObjectData
        /// The schema for CT_GraphicalObjectData is xsd:any without namespace specified
        /// </summary>
        [Fact]
        public void GraphicObjectDataTest()
        {
            string outerXml = "<w:drawing xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" >" +
                              "<wp:inline distT=\"0\" distB=\"0\" distL=\"0\" distR=\"0\">" +
                              "<a:graphic xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\">" +
                              "<a:graphicData uri=\"http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas\">" +
                              "<lc:lockedCanvas xmlns:lc=\"http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas\">" +
                              "<a:sp><a:txSp><a:txBody><a:p><a:r><a:t>Text in drawing.</a:t></a:r></a:p></a:txBody></a:txSp></a:sp>" +
                              "</lc:lockedCanvas></a:graphicData></a:graphic></wp:inline></w:drawing>";

            W.Drawing drawing = new W.Drawing(outerXml);

            Assert.IsType(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline), drawing.FirstChild);
            Assert.IsType(typeof(DocumentFormat.OpenXml.Drawing.Graphic), drawing.FirstChild.FirstChild);
            Assert.IsType(typeof(DocumentFormat.OpenXml.Drawing.GraphicData), drawing.FirstChild.FirstChild.FirstChild);
            Assert.IsType(typeof(DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas), drawing.FirstChild.FirstChild.FirstChild.FirstChild);

            DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas lockedCanvas = drawing.FirstChild.FirstChild.FirstChild.FirstChild as DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas;

            Assert.IsType(typeof(DocumentFormat.OpenXml.Drawing.Run), lockedCanvas.FirstChild.FirstChild.FirstChild.FirstChild.FirstChild);
            
            DocumentFormat.OpenXml.Drawing.Run run = lockedCanvas.FirstChild.FirstChild.FirstChild.FirstChild.FirstChild as DocumentFormat.OpenXml.Drawing.Run;
            
            Assert.Equal("Text in drawing.", run.Text.Text);
            Assert.Equal("Text in drawing.", run.InnerText);
            Assert.Equal("Text in drawing.", lockedCanvas.InnerText);
            Assert.Equal("Text in drawing.", drawing.InnerText);
        }


        /// <summary>
        /// Test the Clone on OpenXmlUnknownElement.
        /// </summary>
        [Fact]
        public void CloneUnknownElementTest()
        {
            string outerXml = "<a:txBody xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\"><a:p><a:r><a:t>Text in &lt;drawing&gt;.</a:t></a:r></a:p></a:txBody>";

            OpenXmlUnknownElement unknownElement = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(outerXml);

            Assert.IsType(typeof(OpenXmlUnknownElement), unknownElement.FirstChild);
            Assert.IsType(typeof(OpenXmlUnknownElement), unknownElement.FirstChild.FirstChild);
            Assert.IsType(typeof(OpenXmlUnknownElement), unknownElement.FirstChild.FirstChild.FirstChild);
            // Assert.IsType(unknownElement.FirstChild.FirstChild.FirstChild.FirstChild, typeof(OpenXmlMiscNode));
            Assert.Equal("Text in <drawing>.", (unknownElement.FirstChild.FirstChild.FirstChild as OpenXmlUnknownElement).Text);

            Assert.Equal(outerXml, unknownElement.OuterXml);

            OpenXmlElement clonedElement = unknownElement.CloneNode(true);

            Assert.Equal("txBody", clonedElement.LocalName);
            Assert.Equal("a", clonedElement.Prefix);
            Assert.Equal("http://schemas.openxmlformats.org/drawingml/2006/main", clonedElement.NamespaceUri);
            Assert.IsType(typeof(OpenXmlUnknownElement), clonedElement);

            Assert.IsType(typeof(OpenXmlUnknownElement), clonedElement.FirstChild);
            Assert.IsType(typeof(OpenXmlUnknownElement), clonedElement.FirstChild.FirstChild);
            Assert.IsType(typeof(OpenXmlUnknownElement), clonedElement.FirstChild.FirstChild.FirstChild);
            //Assert.IsType(typeof(OpenXmlMiscNode), clonedElement.FirstChild.FirstChild.FirstChild.FirstChild);
            Assert.Equal("Text in <drawing>.", (clonedElement.FirstChild.FirstChild.FirstChild as OpenXmlUnknownElement).Text);

            Assert.Equal(outerXml, clonedElement.OuterXml);

            clonedElement = unknownElement.CloneNode(false);

            Assert.Equal("txBody", clonedElement.LocalName);
            Assert.Equal("a", clonedElement.Prefix);
            Assert.Equal("http://schemas.openxmlformats.org/drawingml/2006/main", clonedElement.NamespaceUri);
            Assert.Null(clonedElement.FirstChild);

        }

                
        /// <summary>
        /// Test the exception case for OpenXmlCompositeElement.ReplaceChild().
        /// </summary>
        [Fact]
        public void ReplaceChildExceptionTest()
        {
            Assert.Throws<System.InvalidOperationException>(() =>
                {
                    Paragraph p = new Paragraph();
                    ParagraphProperties ppr = p.AppendChild(new ParagraphProperties());
                    var autoSpace = ppr.AppendChild(new AutoSpaceDE());
                    autoSpace.Val = true;

                    var autoSpace2 = new AutoSpaceDE() { Val = false };

                    p.ReplaceChild(autoSpace2, autoSpace);
                });
        }

        /// <summary>
        /// Test the exception case for OpenXmlCompositeElement.RemoveChild().
        /// </summary>
        [Fact]
        public void RemoveChildExceptionTest()
        {
            Assert.Throws<System.InvalidOperationException>(() =>
            {
                Paragraph p = new Paragraph();
                ParagraphProperties ppr = p.AppendChild(new ParagraphProperties());
                var autoSpace = ppr.AppendChild(new AutoSpaceDE());
                autoSpace.Val = true;

                p.RemoveChild(autoSpace);
            });
        }

        /// <summary>
        /// Test the bug case for OpenXmlPartRootElement.
        /// </summary>
        [Fact]
        public void Bug242463Test()
        {
            string tempFile = System.IO.Path.GetTempFileName();
            
            using (WordprocessingDocument myDoc = WordprocessingDocument.Create(tempFile, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = myDoc.AddMainDocumentPart();

                string xml = "<w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:body><w:p w:rsidR=\"00AB54A4\" w:rsidRDefault=\"00F06412\"><w:r><w:t>Hello World</w:t></w:r></w:p><w:sectPr w:rsidR=\"00AB54A4\" w:rsidSect=\"00801195\"><w:pgSz w:w=\"12240\" w:h=\"15840\" /><w:pgMar w:top=\"1440\" w:right=\"1440\" w:bottom=\"1440\" w:left=\"1440\" w:header=\"720\" w:footer=\"720\" w:gutter=\"0\" /><w:cols w:space=\"720\" /><w:docGrid w:linePitch=\"360\" /></w:sectPr></w:body></w:document>";

                mainPart.Document = new Document(xml);

                // should no exception
                mainPart.Document.Save();
            }

            System.IO.File.Delete(tempFile);
        }

                
        /// <summary>
        /// Test the bug case for OpenXmlPartRootElement.
        /// </summary>
        [Fact]
        public void Bug225919Test()
        {
            string propertiesXml = "<ap:Properties xmlns:ap=\"http://schemas.openxmlformats.org/officeDocument/2006/extended-properties\">" +
                                        "<ap:TitlesOfParts>" +
                                            "<vt:vector baseType=\"lpstr\" size=\"1\" xmlns:vt=\"http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes\">" +
                                                "<vt:lpstr />" +
                                            "</vt:vector>" +
                                        "</ap:TitlesOfParts>" +
                                    "</ap:Properties>";
                    
            var properties = new DocumentFormat.OpenXml.ExtendedProperties.Properties();
            var property = properties.AppendChild( new DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts() );;
            property.VTVector = new DocumentFormat.OpenXml.VariantTypes.VTVector();
            property.VTVector.BaseType = DocumentFormat.OpenXml.VariantTypes.VectorBaseValues.Lpstr;
            property.VTVector.Size = 1;
            property.VTVector.AppendChild(new DocumentFormat.OpenXml.VariantTypes.VTLPSTR() );

            Assert.Equal(propertiesXml, properties.OuterXml);

            propertiesXml = "<op:Properties xmlns:op=\"http://schemas.openxmlformats.org/officeDocument/2006/custom-properties\">" +
                            "<op:property fmtid=\"{D5CDD505-2E9C-101B-9397-08002B2CF9AE}\" pid=\"2\" name=\"crap\">" +
                            "<vt:bool xmlns:vt=\"http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes\">true</vt:bool>" +
                            "</op:property>" +
                            "</op:Properties>";

            var customProperties = new DocumentFormat.OpenXml.CustomProperties.Properties();
            var foo = new DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty();
            foo.Name = "crap";
            // format id is required, i copied this from a Word document.
            foo.FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}";
            // property id is required.
            foo.PropertyId = 2;
            foo.VTBool = new DocumentFormat.OpenXml.VariantTypes.VTBool("true");
            customProperties.AppendChild(foo);

            Assert.Equal(propertiesXml, customProperties.OuterXml);

            var clone = customProperties.CloneNode(true);

            Assert.Equal(0, clone.GetAttributes().Count);
            Assert.Equal(propertiesXml, clone.OuterXml);
        }
    }
}
