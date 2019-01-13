// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System.Diagnostics;
using System.Globalization;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Validate an OpenXmlElement based on the schema.
    /// </summary>
    internal class SchemaTypeValidator
    {
        private readonly SdbSchemaData _sdbSchemaDatas;

        /// <summary>
        /// Initializes a new instance of the SchemaTypeValidator.
        /// </summary>
        /// <param name="sdbSchemaDatas"></param>
        internal SchemaTypeValidator(SdbSchemaData sdbSchemaDatas)
        {
            _sdbSchemaDatas = sdbSchemaDatas;
        }

        /// <summary>
        /// Only validation whether the children elements are valid according to this type's constraint defined in schema.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        internal void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Element != null);

            OpenXmlElement theElement = validationContext.Element;

            Debug.Assert(!(theElement is OpenXmlUnknownElement));
            Debug.Assert(!(theElement is OpenXmlMiscNode));

            if (theElement.ElementTypeId < ReservedElementTypeIds.MaxReservedId)
            {
                // MiscElement, UnknownElement,
                // AlternateContent, AlternateContentChoice, AlternateContentFallback
                if (theElement.ElementTypeId == ReservedElementTypeIds.AlternateContentId)
                {
                    AlternateContentValidator.Validate(validationContext);
                }

                Debug.Assert(!(theElement is AlternateContentChoice));
                Debug.Assert(!(theElement is AlternateContentFallback));

                return;
            }

            // validate Inorable, ProcessContent, etc. compatibility-rule attributes
            CompatibilityRuleAttributesValidator.ValidateMcAttributes(validationContext);

            SchemaTypeData schemaTypeData = _sdbSchemaDatas.GetSchemaTypeData(theElement);

            ValidateAttributes(validationContext, schemaTypeData);

            // validate particles
            if (theElement is OpenXmlLeafTextElement)
            {
                SimpleContentComplexTypeValidator.Validate(validationContext, schemaTypeData.SimpleTypeConstraint);
            }
            else if (theElement is OpenXmlLeafElement)
            {
                EmptyComplexTypeValidator.Validate(validationContext);
            }
            else
            {
                Debug.Assert(theElement is OpenXmlCompositeElement);

                Debug.Assert(!(theElement is AlternateContentChoice));
                Debug.Assert(!(theElement is AlternateContentFallback));

                if (schemaTypeData.ParticleConstraint != null)
                {
                    // composite element
                    CompositeComplexTypeValidator.Validate(validationContext, schemaTypeData.ParticleConstraint);
                }
                else
                {
                    // special case, see O14 bug #662644
                    // A root element which does not allow any children.
                    Debug.Assert(theElement is OpenXmlPartRootElement);
                    EmptyRootComplexTypeValidator.Validate(validationContext);
                }
            }
        }

        /// <summary>
        /// Validate the attributes constraint.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <param name="schemaTypeData">The constraint data of the schema type.</param>
        private static void ValidateAttributes(ValidationContext validationContext, SchemaTypeData schemaTypeData)
        {
            var element = validationContext.Element;

            Debug.Assert(schemaTypeData.AttributeConstraintsCount == 0 || element.Attributes.Length == schemaTypeData.AttributeConstraintsCount);

            ValidationErrorInfo errorInfo;

            // validate xsd:use on attributes
            for (int i = 0; i < schemaTypeData.AttributeConstraintsCount; i++)
            {
                var attributeConstraint = schemaTypeData.AttributeConstraints[i];

                if (attributeConstraint.SupportedVersion.Includes(validationContext.FileFormat))
                {
                    // only check the attribute constraints defined in the specified file format version.
                    switch (attributeConstraint.XsdAttributeUse)
                    {
                        case XsdAttributeUse.Required:
                            var attribute = element.Attributes[i];

                            if (!attribute.HasValue)
                            {
                                string attributeQname = attribute.Tag.GetQName().ToString();

                                // error: miss required attribute
                                errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_MissRequiredAttribute", attributeQname);
                                errorInfo.SetDebugField(attributeQname, "Sch_MissRequiredAttribute");
                                validationContext.AddError(errorInfo);
                            }

                            break;

                        case XsdAttributeUse.None: // none, so use default "optional"
                        case XsdAttributeUse.Optional:
                            break;

                        case XsdAttributeUse.Prohibited: // no "prohibited" in Ecma at now.
                        default:
                            Debug.Assert(false);
                            break;
                    }

                    if (element.Attributes[i].HasValue)
                    {
                        OpenXmlSimpleType attributeValue = element.Attributes[i].Value;

                        string attributeQname = element.Attributes[i].Tag.GetQName().ToString();

                        ValidateValue(validationContext, attributeConstraint.SimpleTypeConstraint, attributeValue, attributeQname, true);
                    }
                }
                else
                {
                    if (element.Attributes[i].HasValue)
                    {
                        // The attribute is not defined in the specified version, report error.
                        if (validationContext.McContext.IsIgnorableNs(element.Attributes[i].Tag.Namespace))
                        {
                            // Ignorable attribute, no error.
                        }
                        else
                        {
                            // emit error
                            string attributeQname = element.Attributes[i].Tag.GetQName().ToString();
                            errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_UndeclaredAttribute", attributeQname);
                            errorInfo.SetDebugField(attributeQname, "Sch_UndeclaredAttribute");
                            validationContext.AddError(errorInfo);
                        }
                    }
                }
            }

            // all unknown attributes (attributes not defined in schema) are in ExtendedAttributes.
            // they should be errors
            foreach (var extendedAttribute in element.ExtendedAttributes)
            {
                if (validationContext.McContext.IsIgnorableNs(extendedAttribute.NamespaceUri))
                {
                    // Ignorable attribute, no error.
                }

                // xml:space is always allowed
                else if ("http://www.w3.org/XML/1998/namespace" == extendedAttribute.NamespaceUri)
                {
                }
                else
                {
                    // emit error
                    string attributeQname = extendedAttribute.XmlQualifiedName.ToString();
                    errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_UndeclaredAttribute", attributeQname);
                    errorInfo.SetDebugField(attributeQname, "Sch_UndeclaredAttribute");
                    validationContext.AddError(errorInfo);
                }
            }
        }

        /// <summary>
        /// Validate the value according to the simpleTypeConstraint.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <param name="simpleTypeConstraint">The constraint data of the simple type.</param>
        /// <param name="value">The value to be validated.</param>
        /// <param name="qname">The QualifiedName to be used in the error message.</param>
        /// <param name="isAttribute">Error message targeting attribute (or element).</param>
        internal static void ValidateValue(ValidationContext validationContext, SimpleTypeRestriction simpleTypeConstraint,
                                                                       OpenXmlSimpleType value, string qname, bool isAttribute)
        {
            var element = validationContext.Element;
            string errorMessageResourceId;
            ValidationErrorInfo errorInfo;
            string subMessage;

            // special case, the type is different in Office2007 and Office2010.
            if (simpleTypeConstraint is RedirectedRestriction redirectRestriction)
            {
                var targetValue = redirectRestriction.ConvertValue(value);
                ValidateValue(validationContext, redirectRestriction.TargetRestriction, targetValue, qname, isAttribute);
                return;
            }

            if (isAttribute)
            {
                errorMessageResourceId = "Sch_AttributeValueDataTypeDetailed";
            }
            else
            {
                errorMessageResourceId = "Sch_ElementValueDataTypeDetailed";
            }

            // first, check whether the string is valid according the primitive type
            if (!simpleTypeConstraint.ValidateValueType(value))
            {
                if (simpleTypeConstraint.IsEnum)
                {
                    // enum is wrong
                    errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, ValidationResources.Sch_EnumerationConstraintFailed);
                    errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_EnumerationConstraintFailed");
                }
                else if (simpleTypeConstraint.XsdType == XsdType.Union)
                {
                    errorInfo = validationContext.ComposeSchemaValidationError(element, null, isAttribute ? "Sch_AttributeUnionFailedEx" : "Sch_ElementUnionFailedEx", qname, value.InnerText);
                    errorInfo.SetDebugField(isAttribute ? qname : null, null);
                }
                else if (string.IsNullOrEmpty(value.InnerText))
                {
                    errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, isAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue);
                    errorInfo.SetDebugField(isAttribute ? qname : null, isAttribute ? "Sch_EmptyAttributeValue" : "Sch_EmptyElementValue");
                }
                else if (simpleTypeConstraint.XsdType == XsdType.SpecialBoolean)
                {
                    // special boolean is ST_OnOff which is enum in the schema.
                    errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, ValidationResources.Sch_EnumerationConstraintFailed);
                    errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_EnumerationConstraintFailed");
                }
                else if (simpleTypeConstraint.IsList)
                {
                    // List
                    errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, string.Empty);
                    errorInfo.SetDebugField(isAttribute ? qname : null, null);
                }
                else
                {
                    subMessage = SR.Format(ValidationResources.Sch_StringIsNotValidValue, value.InnerText, simpleTypeConstraint.ClrTypeName);
                    errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                    errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_StringIsNotValidValue");
                }

                validationContext.AddError(errorInfo);
            }
            else
            {
                bool validateConstraints = true;

                switch (simpleTypeConstraint.XsdType)
                {
                    case XsdType.Enum:
                    case XsdType.Boolean:
                    case XsdType.DateTime:
                    case XsdType.SpecialBoolean:
                        Debug.Assert(simpleTypeConstraint.Pattern == null);
                        Debug.Assert(simpleTypeConstraint.RestrictionField == RestrictionField.None);

                        // no other facets.
                        validateConstraints = false;
                        break;

                    case XsdType.NonNegativeInteger:
                    case XsdType.PositiveInteger:
                    case XsdType.Byte:
                    case XsdType.UnsignedByte:
                    case XsdType.Short:
                    case XsdType.UnsignedShort:
                    case XsdType.Int:
                    case XsdType.UnsignedInt:
                    case XsdType.Long:
                    case XsdType.UnsignedLong:
                    case XsdType.Float:
                    case XsdType.Double:
                    case XsdType.Decimal:
                    case XsdType.Integer: // TODO: integer should be decimal, while in current the CodeGen generate Int32 instead.
                        Debug.Assert(simpleTypeConstraint.Pattern == null);
                        Debug.Assert((simpleTypeConstraint.RestrictionField & RestrictionField.LengthRestriction) == RestrictionField.None);
                        break;

                    case XsdType.String:
                    case XsdType.Token:
                    case XsdType.HexBinary:
                    case XsdType.Base64Binary:
                    case XsdType.AnyURI:
                    case XsdType.QName:
                    case XsdType.ID:                        // no pattern defined for numeric type in Ecma376
                    case XsdType.NCName:
                    case XsdType.IDREF:
                    case XsdType.Language:
                        Debug.Assert((simpleTypeConstraint.RestrictionField & RestrictionField.MinMaxRestriction) == RestrictionField.None);
                        break;

                    case XsdType.List:
                        Debug.Assert(simpleTypeConstraint.Pattern == null);
                        Debug.Assert(simpleTypeConstraint.RestrictionField == RestrictionField.None);

                        // no other facets in current Ecma376.
                        validateConstraints = false;

                        break;

                    case XsdType.Union:
                        Debug.Assert(simpleTypeConstraint.Pattern == null);
                        Debug.Assert(simpleTypeConstraint.RestrictionField == RestrictionField.None);

                        // no other facets.
                        validateConstraints = false;
                        break;

                    default:
                        Debug.Assert(false);
                        break;
                }

                if (validateConstraints)
                {
                    var errorRestriction = simpleTypeConstraint.Validate(value);
                    if (errorRestriction != RestrictionField.None)
                    {
                        if ((errorRestriction & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
                        {
                            subMessage = SR.Format(ValidationResources.Sch_MinInclusiveConstraintFailed, simpleTypeConstraint.GetRestrictionValue(RestrictionField.MinInclusive));
                            errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                            errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_MinInclusiveConstraintFailed");
                            validationContext.AddError(errorInfo);
                        }

                        if ((errorRestriction & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
                        {
                            subMessage = SR.Format(ValidationResources.Sch_MinExclusiveConstraintFailed, simpleTypeConstraint.GetRestrictionValue(RestrictionField.MinExclusive));
                            errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                            errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_MinExclusiveConstraintFailed");
                            validationContext.AddError(errorInfo);
                        }

                        if ((errorRestriction & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
                        {
                            subMessage = SR.Format(ValidationResources.Sch_MaxInclusiveConstraintFailed, simpleTypeConstraint.GetRestrictionValue(RestrictionField.MaxInclusive));
                            errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                            errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_MaxInclusiveConstraintFailed");
                            validationContext.AddError(errorInfo);
                        }

                        if ((errorRestriction & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
                        {
                            subMessage = SR.Format(ValidationResources.Sch_MaxExclusiveConstraintFailed, simpleTypeConstraint.GetRestrictionValue(RestrictionField.MaxExclusive));
                            errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                            errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_MaxExclusiveConstraintFailed");
                            validationContext.AddError(errorInfo);
                        }

                        if ((errorRestriction & RestrictionField.Length) == RestrictionField.Length)
                        {
                            // length is not ok.
                            if (string.IsNullOrEmpty(value.InnerText))
                            {
                                errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, isAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue);
                                errorInfo.SetDebugField(isAttribute ? qname : null, isAttribute ? "Sch_EmptyAttributeValue" : "Sch_EmptyElementValue");
                                validationContext.AddError(errorInfo);
                            }
                            else
                            {
                                subMessage = SR.Format(ValidationResources.Sch_LengthConstraintFailed, simpleTypeConstraint.XsdType.GetXsdDataTypeName(), simpleTypeConstraint.GetRestrictionValue(RestrictionField.Length));
                                errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                                errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_LengthConstraintFailed");
                                validationContext.AddError(errorInfo);
                            }
                        }

                        if ((errorRestriction & RestrictionField.MinLength) == RestrictionField.MinLength)
                        {
                            // min length is not ok.
                            if (string.IsNullOrEmpty(value.InnerText))
                            {
                                errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, isAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue);
                                errorInfo.SetDebugField(isAttribute ? qname : null, isAttribute ? "Sch_EmptyAttributeValue" : "Sch_EmptyElementValue");
                                validationContext.AddError(errorInfo);
                            }
                            else
                            {
                                subMessage = SR.Format(ValidationResources.Sch_MinLengthConstraintFailed, simpleTypeConstraint.XsdType.GetXsdDataTypeName(), simpleTypeConstraint.GetRestrictionValue(RestrictionField.MinLength));
                                errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                                errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_MinLengthConstraintFailed");
                                validationContext.AddError(errorInfo);
                            }
                        }

                        if ((errorRestriction & RestrictionField.MaxLength) == RestrictionField.MaxLength)
                        {
                            // max length is not ok.
                            subMessage = SR.Format(ValidationResources.Sch_MaxLengthConstraintFailed, simpleTypeConstraint.XsdType.GetXsdDataTypeName(), simpleTypeConstraint.GetRestrictionValue(RestrictionField.MaxLength));
                            errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                            errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_MaxLengthConstraintFailed");
                            validationContext.AddError(errorInfo);
                        }

                        if ((errorRestriction & RestrictionField.Pattern) == RestrictionField.Pattern)
                        {
                            // pattern is not ok.
                            subMessage = SR.Format(ValidationResources.Sch_PatternConstraintFailed, simpleTypeConstraint.GetRestrictionValue(RestrictionField.Pattern));
                            errorInfo = validationContext.ComposeSchemaValidationError(element, null, errorMessageResourceId, qname, value.InnerText, subMessage);
                            errorInfo.SetDebugField(isAttribute ? qname : null, "Sch_PatternConstraintFailed");
                            validationContext.AddError(errorInfo);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// empty CT, OpenXmlLeafElement
        /// </summary>
        private static class EmptyComplexTypeValidator
        {
            internal static void Validate(ValidationContext validationContext)
            {
                OpenXmlLeafElement leafElement = (OpenXmlLeafElement)validationContext.Element;
                ValidationErrorInfo errorInfo;

                if (leafElement.ShadowElement != null)
                {
                    foreach (var child in leafElement.ShadowElement.ChildElements)
                    {
                        if (!(child is OpenXmlMiscNode))
                        {
                            errorInfo = validationContext.ComposeSchemaValidationError(leafElement, null, "Sch_InvalidChildinLeafElement", leafElement.XmlQualifiedName.ToString());
                            validationContext.AddError(errorInfo);
                            return; // just return one error is enough.
                        }
                    }
                }
            }
        }

        /// <summary>
        /// empty CT, but used as part root element, OpenXmlPartRootElement
        /// </summary>
        private static class EmptyRootComplexTypeValidator
        {
            internal static void Validate(ValidationContext validationContext)
            {
                var element = (OpenXmlCompositeElement)validationContext.Element;
                ValidationErrorInfo errorInfo;

                foreach (var child in element.ChildElements)
                {
                    if (!(child is OpenXmlMiscNode))
                    {
                        errorInfo = validationContext.ComposeSchemaValidationError(element, null, "Sch_InvalidChildinLeafElement", element.XmlQualifiedName.ToString());
                        validationContext.AddError(errorInfo);
                        return; // just return one error is enough.
                    }
                }
            }
        }

        /// <summary>
        /// simple content CT, OpenXmlLeafTextElement
        /// </summary>
        private static class SimpleContentComplexTypeValidator
        {
            internal static void Validate(ValidationContext validationContext, SimpleTypeRestriction simpleTypeConstraint)
            {
                // first check whether there are invalid children under this OpenXmlLeafTextElement.
                EmptyComplexTypeValidator.Validate(validationContext);

                OpenXmlLeafTextElement element = (OpenXmlLeafTextElement)validationContext.Element;
                OpenXmlSimpleType value = element.InnerTextToValue(element.Text);
                string qname = element.XmlQualifiedName.ToString();

                SchemaTypeValidator.ValidateValue(validationContext, simpleTypeConstraint, value, qname, false);
            }
        }

        /// <summary>
        /// Composite CT
        /// </summary>
        private static class CompositeComplexTypeValidator
        {
            internal static void Validate(ValidationContext validationContext, ParticleConstraint particleConstraint)
            {
                switch (particleConstraint.ParticleType)
                {
                    case ParticleType.All:
                    case ParticleType.Choice:
                    case ParticleType.Sequence:
                    case ParticleType.Group:
                        ParticleValidator particleValidator = (ParticleValidator)particleConstraint.ParticleValidator;
                        particleValidator.Validate(validationContext);
                        break;

                    case ParticleType.Invalid:
                    case ParticleType.Element:
                    case ParticleType.Any:
                    default:
                        Debug.Assert(false);
                        break;
                }
            }
        }
    }
}
