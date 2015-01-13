# Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

!include $(MAKEFILE_DEF)


# CSCFLAGS

CSCFLAGS=$(CSCFLAGS) /nowarn:3003


# Output

FILE_DLL=$(OFAPIBLDDIR)\$(CONFIG)\$(OPENXMLDLL)


# Documentation File

DOC=/doc:$(OFAPIBLDDIR)\$(CONFIG)\$(OPENXMLDLLDOC)


# Target

TARGET=/target:library


# References

OXLIB=/lib:$(DIR_TOOLS_BIN_URT_WPF),$(DIR_TOOLS_LIB_ROOT)
REFERENCES=/reference:WindowsBase.dll


# Sources

FILES_SRC=\
	$(OXFRAMEWORKDIR)\AlternateContent.cs \
	$(OXFRAMEWORKDIR)\ConformanceClasses.cs \
	$(OXFRAMEWORKDIR)\DataPartReferenceRelationship.cs \
	$(OXFRAMEWORKDIR)\ExceptionMessages.Designer.cs \
	$(OXFRAMEWORKDIR)\IFixedTypePart.cs \
	$(OXFRAMEWORKDIR)\MediaDataPart.cs \
	$(OXFRAMEWORKDIR)\NamespaceIdMap.cs \
	$(OXFRAMEWORKDIR)\OpenXmlAttribute.cs \
	$(OXFRAMEWORKDIR)\OpenXmlBasePart.cs \
	$(OXFRAMEWORKDIR)\OpenXmlCompositeElement.cs \
	$(OXFRAMEWORKDIR)\OpenXmlElement.cs \
	$(OXFRAMEWORKDIR)\OpenXmlElement2.cs \
	$(OXFRAMEWORKDIR)\OpenXmlElementContext.cs \
	$(OXFRAMEWORKDIR)\OpenXmlElementList.cs \
	$(OXFRAMEWORKDIR)\OpenXmlLeafElement.cs \
	$(OXFRAMEWORKDIR)\OpenXmlLeafTextElement.cs \
	$(OXFRAMEWORKDIR)\OpenXmlNonElementNode.cs \
	$(OXFRAMEWORKDIR)\OpenXmlObsolete.cs \
	$(OXFRAMEWORKDIR)\OpenXmlPackage.cs \
	$(OXFRAMEWORKDIR)\OpenXmlPartRootElement.cs \
	$(OXFRAMEWORKDIR)\OpenXmlReader.cs \
	$(OXFRAMEWORKDIR)\OpenXmlSimpleType.cs \
	$(OXFRAMEWORKDIR)\OpenXmlUnknownElement.cs \
	$(OXFRAMEWORKDIR)\OpenXmlWriter.cs \
	$(OXFRAMEWORKDIR)\PartConstraintRule.cs \
	$(OXFRAMEWORKDIR)\PartContainer.cs \
	$(OXFRAMEWORKDIR)\PartExtensionProvider.cs \
	$(OXFRAMEWORKDIR)\ReferenceRelationship.cs \
	$(OXFRAMEWORKDIR)\RelationshipTypeList.cs \
	$(OXFRAMEWORKDIR)\ReservedElementTypeIds.cs \
	$(OXFRAMEWORKDIR)\UnknownPart.cs \
	$(OXFRAMEWORKDIR)\XmlDOMTextWriter.cs \
	$(OXFRAMEWORKDIR)\Profiler.cs \
    \
	$(GENERATEDCODEDIR)\O12UnionHelper.cs \
	$(GENERATEDCODEDIR)\O14UnionHelper.cs \
	$(GENERATEDCODEDIR)\O15UnionHelper.cs \
	$(GENERATEDCODEDIR)\package.cs \
	$(GENERATEDCODEDIR)\PartialSemanticConstraintRegistry.cs \
	$(GENERATEDCODEDIR)\PartParitalDef.cs \
	$(GENERATEDCODEDIR)\RootElementFactory.cs \
	$(GENERATEDCODEDIR)\schemas-microsoft-com_office_excel.cs \
	$(GENERATEDCODEDIR)\schemas-microsoft-com_office_office.cs \
	$(GENERATEDCODEDIR)\schemas-microsoft-com_office_powerpoint.cs \
	$(GENERATEDCODEDIR)\schemas-microsoft-com_office_word.cs \
	$(GENERATEDCODEDIR)\schemas-microsoft-com_vml.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_ink_2010_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_01_customui.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_activeX.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_coverPageProps.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_customDocumentInformationPanel.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_metadata_contentType.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_metadata_customXsn.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_metadata_longProperties.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2006_metadata_properties_metaAttributes.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_2009_07_customui.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2007_8_2_chart.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2008_diagram.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2010_chartDrawing.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2010_compatibility.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2010_diagram.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2010_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2010_picture.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2010_slicer.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2012_timeslicer.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_excel_2006_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_excel_2010_spreadsheetDrawing.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_powerpoint_2010_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_spreadsheetml_2009_9_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2006_wordml.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2010_wordml.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2010_wordprocessingCanvas.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2010_wordprocessingDrawing.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2010_wordprocessingGroup.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2010_wordprocessingShape.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_chart.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_chartDrawing.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_compatibility.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_diagram.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_lockedCanvas.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_main.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_picture.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_spreadsheetDrawing.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_drawingml_2006_wordprocessingDrawing.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_officeDocument_2006_bibliography.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_officeDocument_2006_characteristics.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_officeDocument_2006_custom-properties.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_officeDocument_2006_customXml.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_officeDocument_2006_docPropsVTypes.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_officeDocument_2006_extended-properties.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_officeDocument_2006_math.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_presentationml_2006_main.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_schemaLibrary_2006_main.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_spreadsheetml_2006_main.cs \
	$(GENERATEDCODEDIR)\schemas_openxmlformats_org_wordprocessingml_2006_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2012_wordml.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_webextensions_webextension_2010_11.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2012_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2012_chart.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_drawing_2012_chartStyle.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_powerpoint_2012_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_thememl_2012_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_webextensions_taskpanes_2010_11.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_spreadsheetml_2010_11_main.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_spreadsheetml_2011_1_ac.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_spreadsheetml_2010_11_ac.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_word_2012_wordprocessingDrawing.cs \
	$(GENERATEDCODEDIR)\schemas_microsoft_com_office_powerpoint_2012_roamingSettings.cs \
	$(GENERATEDCODEDIR)\www_w3_org_2003_04_emma.cs \
	$(GENERATEDCODEDIR)\www_w3_org_2003_InkML.cs \
	$(GENERATEDCODEDIR)\www_w3_org_XML_1998_namespace.cs \
    \
	$(OFAPIDIR)\BinaryTypeEnums.cs \
	$(OFAPIDIR)\DocumentTypeDetector.cs \
	$(OFAPIDIR)\DocumentTypeEnum.cs \
	$(OFAPIDIR)\ExtensionMethods.cs \
	$(OFAPIDIR)\GlobalSuppressions.cs \
	$(OFAPIDIR)\ofapi.cs \
	$(OFAPIDIR)\HelperPartialClass.cs \
	$(OFAPIDIR)\PackageDocument.cs \
	$(OFAPIDIR)\RootElementFactory1.cs \
	$(OFAPIDIR)\SchemaInfoAttribute.cs \
	$(OFAPIDIR)\Sources1.cs \
	$(OFAPIDIR)\Wordprocessing.cs \
    \
	$(OFAPIDIR)\Properties\AssemblyInfo.cs \
    \
	$(OFAPIDIR)\Validation\PresentationDocumentValidator.cs \
	$(OFAPIDIR)\Validation\SpreadsheetDocumentValidator.cs \
	$(OFAPIDIR)\Validation\DocumentValidator.cs \
	$(OFAPIDIR)\Validation\OpenXmlValidator.cs \
	$(OFAPIDIR)\Validation\ValidationResources.Designer.cs \
	$(OFAPIDIR)\Validation\ValidationContext.cs \
	$(OFAPIDIR)\Validation\ValidationErrorInfo.cs \
	$(OFAPIDIR)\Validation\ValidationResult.cs \
	$(OFAPIDIR)\Validation\ValidationSettings.cs \
	$(OFAPIDIR)\Validation\ValidationTraverser.cs \
	$(OFAPIDIR)\Validation\WordprocessingDocumentValidator.cs \
	$(OFAPIDIR)\Validation\XmlPath.cs \
    \
	$(OFAPIDIR)\Validation\SchemaValidation\AlternateContentValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\SdbDataHead.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\UnionHelper.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\AllParticleValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\AnyParticleValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\AttributeConstraint.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\BinDataTypes.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\ChoiceParticleValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\GroupParticleValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\ParticleConstraint.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\ParticleValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\SchemaTypeData.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\SchemaTypeValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\SchemaValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\SdbSchemaDatas.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\SequenceParticleValidator.cs \
	$(OFAPIDIR)\Validation\SchemaValidation\SimpleTypes.cs \
    \
	$(OFAPIDIR)\Validation\SemanticValidation\Enums.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticValidator.cs \
    \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraintRegistry\SemanticConstraintRegistry.cs \
    \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeAbsentConditionToValue.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeAbsentConditionToNonValue.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeCannotOmitConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeValueLessEqualToAnother.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeMutualExclusive.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeRequiredConditionToValue.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeValueLengthConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeValuePatternConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeValueRangeConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeValueSetConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\AttributeValueConditionToAnother.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\IndexReferenceConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\ReferenceExistConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\RelationshipExistConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\RelationshipTypeConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\RootAttributeUniqueConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\SemanticConstraint.cs \
	$(OFAPIDIR)\Validation\SemanticValidation\SemanticConstraint\UniqueAttributeValueConstraint.cs


EXCEPTIONMESSAGESRES=$(OXFRAMEWORKDIR)\ExceptionMessages
VALIDATIONRESOURCESRES=$(OFAPIDIR)\Validation\ValidationResources

RESOURCE=\
	/resource:$(EXCEPTIONMESSAGESRES).resources,DocumentFormat.OpenXml.ExceptionMessages.resources \
	/resource:$(VALIDATIONRESOURCESRES).resources,DocumentFormat.OpenXml.Validation.ValidationResources.resources \

# Rules

$(FILE_DLL): $(FILES_SRC) $(EXCEPTIONMESSAGESRES).resources $(VALIDATIONRESOURCESRES).resources
	$(CSC) $(CSCFLAGS) /out:$@ $(TARGET) $(FILES_SRC) $(RESOURCE) $(OXLIB) $(REFERENCES) $(DOC)

$(EXCEPTIONMESSAGESRES).resources: $(EXCEPTIONMESSAGESRES).resx
	$(RESGEN) $(RCFLAGS) $(EXCEPTIONMESSAGESRES).resx $@

$(VALIDATIONRESOURCESRES).resources: $(VALIDATIONRESOURCESRES).resx
	$(RESGEN) $(RCFLAGS) $(VALIDATIONRESOURCESRES).resx $@

BUILD: $(FILE_DLL)


clean:
	del /q $(OFAPIBLDDIR)\$(CONFIG)\*
	if exist $(EXCEPTIONMESSAGESRES).resources del $(EXCEPTIONMESSAGESRES).resources
	if exist $(VALIDATIONRESOURCESRES).resources del $(VALIDATIONRESOURCESRES).resources
	echo Clean done