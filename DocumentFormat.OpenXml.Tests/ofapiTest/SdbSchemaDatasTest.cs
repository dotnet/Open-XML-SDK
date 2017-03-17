// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using Xunit;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for SdbSchemaDatasTest and is intended
    ///to contain all SdbSchemaDatasTest Unit Tests
    ///</summary>
    
    public class SdbSchemaDatasTest
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
        ///A test for Load
        ///</summary>
        ///<remarks>
        ///This check is for Ecma376 schema.
        ///</remarks>
        [Fact]
        public void LoadSdbSchemaDatasTest()
        {
            var actual = SdbSchemaDatas.GetOffice2007SchemaDatas();

            AttributeConstraintTest(actual);

            SimpleLoadTest(actual);

            DocumentConstraintTest(actual);
            
            BodyConstraintTest(actual);

            ParagraphConstraintTest(actual);

            TextboxConstraintTest(actual);

            SimpleTypeConstraintTest(actual);
        }

        private void AttributeConstraintTest(SdbSchemaDatas actual)
        {
              //<xsd:complexType name="CT_FileVersion">
              //  <xsd:attribute name="appName" type="xsd:string" use="optional">
              //  <xsd:attribute name="lastEdited" type="xsd:string" use="optional">
              //  <xsd:attribute name="lowestEdited" type="xsd:string" use="optional">
              //  <xsd:attribute name="rupBuild" type="xsd:string" use="optional">
              //  <xsd:attribute name="codeName" type="ST_Guid" use="optional">
              //</xsd:complexType>

            var schemaTypeData = actual.GetSchemaTypeData(DocumentFormat.OpenXml.Spreadsheet.FileVersion.ElementTypeIdConst);
            Assert.Equal(5, schemaTypeData.AttributeConstraintsCount);

            AttributeConstraint attributeConstraint;

            for (int i = 0; i < 4; i++)
            {
                attributeConstraint = schemaTypeData.AttributeConstraints[i];
                Assert.Equal(XsdAttributeUse.Optional, attributeConstraint.XsdAttributeUse);
                Assert.IsType(typeof(StringRestriction), attributeConstraint.SimpleTypeConstraint);
            }

            attributeConstraint = schemaTypeData.AttributeConstraints[4];
            Assert.Equal(XsdAttributeUse.Optional, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(TokenRestriction), attributeConstraint.SimpleTypeConstraint);

              //<xsd:complexType name="CT_LsdException">
              //  <xsd:attribute name="name" type="ST_String" use="required">
              //  <xsd:attribute name="locked" type="ST_OnOff">
              //  <xsd:attribute name="uiPriority" type="ST_DecimalNumber">
              //  <xsd:attribute name="semiHidden" type="ST_OnOff">
              //  <xsd:attribute name="unhideWhenUsed" type="ST_OnOff">
              //  <xsd:attribute name="qFormat" type="ST_OnOff">
              //</xsd:complexType>

            schemaTypeData = actual.GetSchemaTypeData(LatentStyleExceptionInfo.ElementTypeIdConst);
            Assert.Equal(6, schemaTypeData.AttributeConstraintsCount);

            attributeConstraint = schemaTypeData.AttributeConstraints[0];
            Assert.Equal(XsdAttributeUse.Required, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(StringRestriction), attributeConstraint.SimpleTypeConstraint);

            attributeConstraint = schemaTypeData.AttributeConstraints[1];
            Assert.Equal(XsdAttributeUse.None, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(BooleanValueRestriction), attributeConstraint.SimpleTypeConstraint);

            attributeConstraint = schemaTypeData.AttributeConstraints[2];
            Assert.Equal(XsdAttributeUse.None, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(Int32ValueRestriction), attributeConstraint.SimpleTypeConstraint);
            
            attributeConstraint = schemaTypeData.AttributeConstraints[3];
            Assert.Equal(XsdAttributeUse.None, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(BooleanValueRestriction), attributeConstraint.SimpleTypeConstraint);

            attributeConstraint = schemaTypeData.AttributeConstraints[4];
            Assert.Equal(XsdAttributeUse.None, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(BooleanValueRestriction), attributeConstraint.SimpleTypeConstraint);

            attributeConstraint = schemaTypeData.AttributeConstraints[5];
            Assert.Equal(XsdAttributeUse.None, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(BooleanValueRestriction), attributeConstraint.SimpleTypeConstraint);

              //<xsd:complexType name="CT_HdrFtrRef">
              //  <xsd:complexContent>
              //    <xsd:extension base="CT_Rel">
              //      <xsd:attribute name="type" type="ST_HdrFtr" use="required">
              //    </xsd:extension>
              //  </xsd:complexContent>
              //</xsd:complexType>
            
              //<xsd:complexType name="CT_Rel">
              //  <xsd:attribute ref="r:id" use="required">
              //</xsd:complexType>
        
              //<xsd:simpleType name="ST_HdrFtr">
              //  <xsd:restriction base="xsd:string">
              //    <xsd:enumeration value="even">
              //    <xsd:enumeration value="default">
              //    <xsd:enumeration value="first">
              //  </xsd:restriction>
              //</xsd:simpleType>
            schemaTypeData = actual.GetSchemaTypeData(HeaderReference.ElementTypeIdConst);
            Assert.Equal(2, schemaTypeData.AttributeConstraintsCount);

            // in generated code, @type if the first, and @r:id is the second
            attributeConstraint = schemaTypeData.AttributeConstraints[0];
            Assert.Equal(XsdAttributeUse.Required, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(EnumValueRestriction), attributeConstraint.SimpleTypeConstraint);

            attributeConstraint = schemaTypeData.AttributeConstraints[1];
            Assert.Equal(XsdAttributeUse.Required, attributeConstraint.XsdAttributeUse);
            Assert.IsType(typeof(StringRestriction), attributeConstraint.SimpleTypeConstraint);

        }

        private void SimpleLoadTest(SdbSchemaDatas actual)
        {
            var schemaTypeData = actual.GetSchemaTypeData(RunProperties.ElementTypeIdConst);
            Assert.True(schemaTypeData.IsCompositeType);
            Assert.False(schemaTypeData.IsSimpleContent);

            schemaTypeData = actual.GetSchemaTypeData(Bold.ElementTypeIdConst);
            Assert.False(schemaTypeData.IsCompositeType);
            Assert.False(schemaTypeData.IsSimpleContent);
        }

        private void DocumentConstraintTest(SdbSchemaDatas actual)
        {
            ElementParticle elementParticle;
            // CT_Document 
            //<xsd:complexType name="CT_DocumentBase">
            //  <xsd:sequence>
            //    <xsd:element name="background" type="CT_Background" minOccurs="0"/>
            //  </xsd:sequence>
            //</xsd:complexType>
            //<xsd:complexType name="CT_Document">
            //  <xsd:complexContent>
            //    <xsd:extension base="CT_DocumentBase">
            //      <xsd:sequence>
            //        <xsd:element name="body" type="CT_Body" minOccurs="0" maxOccurs="1"/>
            //      </xsd:sequence>
            //      <xsd:attribute name="conformance" type="ST_DocumentConformance" />
            //    </xsd:extension>
            //  </xsd:complexContent>
            //</xsd:complexType>  
            var document = new Document();
            var body = new Body();
            var documentData = actual.GetSchemaTypeData(document.ElementTypeId);
            Assert.Equal(document.ElementTypeId, documentData.OpenXmlTypeId);
            Assert.True(documentData.HasAttributeConstraints);
            Assert.Null(documentData.SimpleTypeConstraint);
            Assert.True(documentData.IsCompositeType);
            Assert.False(documentData.IsSimpleContent);

            var particle = documentData.ParticleConstraint;
            Assert.Equal(ParticleType.Sequence, particle.ParticleType);
            Assert.Equal(1, particle.MinOccurs);
            Assert.Equal(1, particle.MaxOccurs);
            Assert.Equal(2, particle.ChildrenParticles.Length);
            Assert.False(particle.UnboundedMaxOccurs);
            Assert.False(particle.IsSimple());

            {
                // the sequence of CT_DocumentBase
                particle = documentData.ParticleConstraint.ChildrenParticles[0];
                Assert.Equal(ParticleType.Sequence, particle.ParticleType);
                Assert.Equal(1, particle.MinOccurs);
                Assert.Equal(1, particle.MaxOccurs);
                Assert.Equal(1, particle.ChildrenParticles.Length);
                Assert.False(particle.UnboundedMaxOccurs);
                Assert.True(particle.IsSimple());

                {
                    // the element <w:background>
                    elementParticle = particle.ChildrenParticles[0] as ElementParticle;
                    Assert.NotNull(elementParticle);
                    Assert.Equal(ParticleType.Element, elementParticle.ParticleType);
                    Assert.Equal(0, elementParticle.MinOccurs);
                    Assert.Equal(1, elementParticle.MaxOccurs);
                    Assert.Equal((new DocumentBackground()).ElementTypeId, elementParticle.ElementId);
                    Assert.Null(elementParticle.ChildrenParticles);
                    Assert.False(elementParticle.UnboundedMaxOccurs);
                }

                // the sequence of CT_Document
                particle = documentData.ParticleConstraint.ChildrenParticles[1];
                Assert.Equal(ParticleType.Sequence, particle.ParticleType);
                Assert.Equal(1, particle.MinOccurs);
                Assert.Equal(1, particle.MaxOccurs);
                Assert.Equal(1, particle.ChildrenParticles.Length);
                Assert.False(particle.UnboundedMaxOccurs);
                Assert.True(particle.IsSimple());

                {
                    // the element <w:body>
                    elementParticle = particle.ChildrenParticles[0] as ElementParticle;
                    Assert.NotNull(elementParticle);
                    Assert.Equal(ParticleType.Element, elementParticle.ParticleType);
                    Assert.Equal(0, elementParticle.MinOccurs);
                    Assert.Equal(1, elementParticle.MaxOccurs);
                    Assert.Equal(body.ElementTypeId, elementParticle.ElementId);
                    Assert.Null(elementParticle.ChildrenParticles);
                    Assert.False(elementParticle.UnboundedMaxOccurs);
                }
            }
        }

        private void BodyConstraintTest(SdbSchemaDatas actual)
        {
            ElementParticle elementParticle;
            
            //<xsd:complexType name="CT_Body">
            //  <xsd:sequence>
            //    <xsd:group ref="EG_BlockLevelElts" minOccurs="0" maxOccurs="unbounded" />
            //    <xsd:element name="sectPr" minOccurs="0" maxOccurs="1" type="CT_SectPr" />
            //  </xsd:sequence>
            //</xsd:complexType>
            //<xsd:group name="EG_BlockLevelElts">
            //  <xsd:choice>
            //    <xsd:group ref="EG_BlockLevelChunkElts" minOccurs="0" maxOccurs="unbounded" />
            //    <xsd:element name="altChunk" type="CT_AltChunk" minOccurs="0" maxOccurs="unbounded" />
            //  </xsd:choice>
            //</xsd:group>

            //************ changed in EcmaD
          //<xsd:group name="EG_BlockLevelChunkElts">
          //  <xsd:choice>
          //    <xsd:group ref="EG_ContentBlockContent" minOccurs="0" maxOccurs="unbounded" />
          //  </xsd:choice>
          //</xsd:group>
          //<xsd:group name="EG_BlockLevelChunkEltsNoRev">
          //  <xsd:choice>
          //    <xsd:group ref="EG_ContentBlockContentNoRev" minOccurs="0" maxOccurs="unbounded" />
          //  </xsd:choice>
          //</xsd:group>
          //<xsd:group name="EG_BlockLevelEltsBase">
          //  <xsd:choice>
          //    <xsd:element name="altChunk" type="CT_AltChunk" minOccurs="0" maxOccurs="unbounded"></xsd:element>
          //  </xsd:choice>
          //</xsd:group>
          //<xsd:group name="EG_BlockLevelElts">
          //  <xsd:choice>
          //    <xsd:group ref="EG_BlockLevelEltsBase" minOccurs="0" maxOccurs="unbounded" />
          //    <xsd:group ref="EG_BlockLevelChunkElts" minOccurs="0" maxOccurs="unbounded" />
          //  </xsd:choice>


            var body = new Body();
            var bodyData = actual.GetSchemaTypeData(body.ElementTypeId);
            Assert.Equal(body.ElementTypeId, bodyData.OpenXmlTypeId);
            Assert.False(bodyData.HasAttributeConstraints);
            Assert.Null(bodyData.SimpleTypeConstraint);
            Assert.True(bodyData.IsCompositeType);
            Assert.False(bodyData.IsSimpleContent);

            var particle = bodyData.ParticleConstraint;
            Assert.Equal(ParticleType.Sequence, particle.ParticleType);
            Assert.Equal(1, particle.MinOccurs);
            Assert.Equal(1, particle.MaxOccurs);
            Assert.Equal(2, particle.ChildrenParticles.Length);
            Assert.False(particle.UnboundedMaxOccurs);
            Assert.False(particle.IsSimple());
            {
                // the first child of body is a group EG_BlockLevelElts
                particle = bodyData.ParticleConstraint.ChildrenParticles[0];
                Assert.Equal(ParticleType.Group, particle.ParticleType);
                Assert.Equal(0, particle.MinOccurs);
                Assert.True(particle.UnboundedMaxOccurs);
                Assert.Equal(1, particle.ChildrenParticles.Length);
                Assert.False(particle.IsSimple());

                {
                    // the group EG_BlockLevelElts contains 1 child - choice particle
                    particle = particle.ChildrenParticles[0];
                    Assert.Equal(ParticleType.Choice, particle.ParticleType);
                    Assert.Equal(1, particle.MinOccurs);
                    Assert.Equal(1, particle.MaxOccurs);
                    Assert.False(particle.UnboundedMaxOccurs);
                    Assert.False(particle.IsSimple());

                    {
                        // the choice particle contains 2 children
                        Assert.Equal(2, particle.ChildrenParticles.Length);

                        // the first is the group EG_BlockLevelEltsBase
                        var firstParticle = particle.ChildrenParticles[0];
                        Assert.NotNull(firstParticle);
                        Assert.Equal(ParticleType.Group, firstParticle.ParticleType);
                        Assert.Equal(0, firstParticle.MinOccurs);
                        Assert.True(firstParticle.UnboundedMaxOccurs);
                        {
                            // the group EG_BlockLevelEltsBase contains 1 child - choice particle
                            var choiceParticle = firstParticle.ChildrenParticles[0];
                            Assert.Equal(ParticleType.Choice, choiceParticle.ParticleType);
                            Assert.Equal(1, choiceParticle.MinOccurs);
                            Assert.Equal(1, choiceParticle.MaxOccurs);
                            Assert.False(choiceParticle.UnboundedMaxOccurs);
                            Assert.True(choiceParticle.IsSimple());
                            {
                                // the "altChunk" element.
                                elementParticle = choiceParticle.ChildrenParticles[0] as ElementParticle;
                                Assert.NotNull(elementParticle);
                                Assert.Equal(ParticleType.Element, elementParticle.ParticleType);
                                Assert.Equal(0, elementParticle.MinOccurs);
                                Assert.True(elementParticle.UnboundedMaxOccurs);
                                Assert.Equal(AltChunk.ElementTypeIdConst, elementParticle.ElementId);
                                Assert.Null(elementParticle.ChildrenParticles);
                            }
                        }

                        // second is a group particle
                        particle = particle.ChildrenParticles[1];
                        Assert.Equal(ParticleType.Group, particle.ParticleType);
                        Assert.Equal(0, particle.MinOccurs);
                        Assert.True(particle.UnboundedMaxOccurs);
                    }
                }

                // the last element of body is sectPr
                elementParticle = bodyData.ParticleConstraint.ChildrenParticles[1] as ElementParticle;
                Assert.NotNull(elementParticle);
                Assert.Equal(ParticleType.Element, elementParticle.ParticleType);
                Assert.Equal(0, elementParticle.MinOccurs);
                Assert.Equal(1, elementParticle.MaxOccurs);
                Assert.Equal((new SectionProperties()).ElementTypeId, elementParticle.ElementId);
                Assert.Null(elementParticle.ChildrenParticles);
                Assert.False(elementParticle.UnboundedMaxOccurs);
            }
        }

        private void ParagraphConstraintTest(SdbSchemaDatas actual)
        {

            //<xsd:complexType name="CT_P">
            //  <xsd:sequence>
            //    <xsd:element name="pPr" type="CT_PPr" minOccurs="0" />
            //    <xsd:group ref="EG_PContent" minOccurs="0" maxOccurs="unbounded" />
            //  </xsd:sequence>
            //  <xsd:attribute name="rsidRPr" type="ST_LongHexNumber" />
            //  <xsd:attribute name="rsidR" type="ST_LongHexNumber" />
            //  <xsd:attribute name="rsidDel" type="ST_LongHexNumber" />
            //  <xsd:attribute name="rsidP" type="ST_LongHexNumber" />
            //  <xsd:attribute name="rsidRDefault" type="ST_LongHexNumber" />
            //</xsd:complexType>
            var paragraph = new Paragraph();

            var paragraphData = actual.GetSchemaTypeData(paragraph);
            Assert.Equal(paragraph.ElementTypeId, paragraphData.OpenXmlTypeId);
            Assert.True(paragraphData.HasAttributeConstraints);
            Assert.Equal(8, paragraphData.AttributeConstraintsCount);
            Assert.Null(paragraphData.SimpleTypeConstraint);
            Assert.True(paragraphData.IsCompositeType);
            Assert.False(paragraphData.IsSimpleContent);

            var particle = paragraphData.ParticleConstraint;
            Assert.Equal(ParticleType.Sequence, particle.ParticleType);
            Assert.Equal(1, particle.MinOccurs);
            Assert.Equal(1, particle.MaxOccurs);
            Assert.Equal(2, particle.ChildrenParticles.Length);
            Assert.False(particle.UnboundedMaxOccurs);
            Assert.False(particle.IsSimple());
            {
                // the first element of paragraph is pPr
                var elementParticle = paragraphData.ParticleConstraint.ChildrenParticles[0] as ElementParticle;
                Assert.NotNull(elementParticle);
                Assert.Equal(ParticleType.Element, elementParticle.ParticleType);
                Assert.Equal(0, elementParticle.MinOccurs);
                Assert.Equal(1, elementParticle.MaxOccurs);
                Assert.Equal((new ParagraphProperties()).ElementTypeId, elementParticle.ElementId);
                Assert.Null(elementParticle.ChildrenParticles);
                Assert.False(elementParticle.UnboundedMaxOccurs);

                // the second child of paragraph is a group EG_PContent
                particle = paragraphData.ParticleConstraint.ChildrenParticles[1];
                Assert.Equal(ParticleType.Group, particle.ParticleType);
                Assert.Equal(0, particle.MinOccurs);
                Assert.True(particle.UnboundedMaxOccurs);
                Assert.Equal(1, particle.ChildrenParticles.Length);
                Assert.False(particle.IsSimple());
            }


        }

        private void TextboxConstraintTest(SdbSchemaDatas actual)
        {
              //<xsd:complexType name="CT_Textbox">
              //  <xsd:choice>
              //    <xsd:element ref="w:txbxContent" minOccurs="0" />
              //    <xsd:any namespace="##local" processContents="skip" />
              //  </xsd:choice>
              //  <xsd:attributeGroup ref="AG_Id" />
              //  <xsd:attributeGroup ref="AG_Style" />
              //  <xsd:attribute name="inset" type="xsd:string" use="optional">
              //  <xsd:attribute ref="o:singleclick">
              //</xsd:complexType>

            var constraintData = actual.GetSchemaTypeData(DocumentFormat.OpenXml.Vml.TextBox.ElementTypeIdConst);
            Assert.Equal(DocumentFormat.OpenXml.Vml.TextBox.ElementTypeIdConst, constraintData.OpenXmlTypeId);
            Assert.True(constraintData.HasAttributeConstraints);
            Assert.Equal(4, constraintData.AttributeConstraintsCount);
            Assert.Null(constraintData.SimpleTypeConstraint);
            Assert.True(constraintData.IsCompositeType);
            Assert.False(constraintData.IsSimpleContent);

            var particle = constraintData.ParticleConstraint;
            Assert.Equal(ParticleType.Choice, particle.ParticleType);
            Assert.Equal(1, particle.MinOccurs);
            Assert.Equal(1, particle.MaxOccurs);
            Assert.Equal(2, particle.ChildrenParticles.Length);
            Assert.False(particle.UnboundedMaxOccurs);
            Assert.False(particle.IsSimple());
            {
                ElementParticle elementParticle = particle.ChildrenParticles[0] as ElementParticle;
                Assert.Equal(ParticleType.Element, elementParticle.ParticleType);
                Assert.Equal(0, elementParticle.MinOccurs);
                Assert.False(elementParticle.UnboundedMaxOccurs);
                Assert.Equal(1, elementParticle.MaxOccurs);
                Assert.Null(elementParticle.ChildrenParticles);
                Assert.True(elementParticle.IsSimple());

                AnyParticle anyParticle = particle.ChildrenParticles[1] as AnyParticle;
                Assert.Equal(ParticleType.Any, anyParticle.ParticleType);
                Assert.Equal(1, anyParticle.MinOccurs);
                Assert.False(anyParticle.UnboundedMaxOccurs);
                Assert.Equal(1, anyParticle.MaxOccurs);
                Assert.Null(anyParticle.ChildrenParticles);
                Assert.True(anyParticle.IsSimple());
            }
        }

        private void SimpleTypeConstraintTest(SdbSchemaDatas actual)
        {
            // <Bibliography:SourceType /> is a simple type
            // <xsd:element name="SourceType" type="ST_SourceType">

            SourceType sourceType = new SourceType();
            var schemaTypeData = actual.GetSchemaTypeData(sourceType.ElementTypeId);
            Assert.Equal(sourceType.ElementTypeId, schemaTypeData.OpenXmlTypeId);
            Assert.False(schemaTypeData.HasAttributeConstraints);
            Assert.NotNull(schemaTypeData.SimpleTypeConstraint);
            Assert.False(schemaTypeData.IsCompositeType);
            Assert.True(schemaTypeData.IsSimpleContent);

            Assert.Null(schemaTypeData.ParticleConstraint);

            // ST_SourceType is ST_String255 based enum
            Assert.IsType(typeof(EnumValueRestriction), schemaTypeData.SimpleTypeConstraint);
            Assert.Equal(XsdType.Enum, schemaTypeData.SimpleTypeConstraint.XsdType);
            Assert.Equal(RestrictionField.None, schemaTypeData.SimpleTypeConstraint.RestrictionField);
            Assert.True(schemaTypeData.SimpleTypeConstraint.IsEnum);
            Assert.False(schemaTypeData.SimpleTypeConstraint.IsList);
            Assert.Null(schemaTypeData.SimpleTypeConstraint.Pattern);

            // <Bibliography:ConferenceName /> is a simple type
            //<xsd:element name="ConferenceName" type="ST_String255">
            ConferenceName conferenceName = new ConferenceName();

            schemaTypeData = actual.GetSchemaTypeData(conferenceName.ElementTypeId);
            Assert.Equal(conferenceName.ElementTypeId, schemaTypeData.OpenXmlTypeId);
            Assert.False(schemaTypeData.HasAttributeConstraints);
            Assert.NotNull(schemaTypeData.SimpleTypeConstraint);
            Assert.False(schemaTypeData.IsCompositeType);
            Assert.True(schemaTypeData.IsSimpleContent);

            Assert.Null(schemaTypeData.ParticleConstraint);

            //<xsd:simpleType name="ST_String255">
            //  <xsd:restriction base="xsd:string">
            //    <xsd:minLength value="0" />
            //    <xsd:maxLength value="255" />
            //  </xsd:restriction>
            //</xsd:simpleType>
            Assert.IsType(typeof(StringRestriction), schemaTypeData.SimpleTypeConstraint);
            Assert.Equal(XsdType.String, schemaTypeData.SimpleTypeConstraint.XsdType);
            Assert.False(schemaTypeData.SimpleTypeConstraint.IsEnum);
            Assert.False(schemaTypeData.SimpleTypeConstraint.IsList);
            Assert.Null(schemaTypeData.SimpleTypeConstraint.Pattern);

            var stringConstraint = schemaTypeData.SimpleTypeConstraint as StringRestriction;
            Assert.Equal(RestrictionField.MinLength | RestrictionField.MaxLength, stringConstraint.RestrictionField);
            Assert.Equal(0, stringConstraint.MinLength);
            Assert.Equal(255, stringConstraint.MaxLength);
        }
    }
}
