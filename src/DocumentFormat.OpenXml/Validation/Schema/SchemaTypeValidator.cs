// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Validate an OpenXmlElement based on the schema.
    /// </summary>
    internal class SchemaTypeValidator
    {
        private readonly FileFormatVersions _version;

        public SchemaTypeValidator(FileFormatVersions version)
        {
            _version = version;
        }

        /// <summary>
        /// Only validation whether the children elements are valid according to this type's constraint defined in schema.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        public void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Element != null);

            OpenXmlElement theElement = validationContext.Element;

            Debug.Assert(!(theElement is OpenXmlUnknownElement));
            Debug.Assert(!(theElement is OpenXmlMiscNode));

            if (theElement.IsReservedElement())
            {
                // MiscElement, UnknownElement,
                // AlternateContent, AlternateContentChoice, AlternateContentFallback
                if (theElement.IsAlternateContent())
                {
                    AlternateContentValidator.Validate(validationContext);
                }

                Debug.Assert(!(theElement is AlternateContentChoice));
                Debug.Assert(!(theElement is AlternateContentFallback));

                return;
            }

            // validate Inorable, ProcessContent, etc. compatibility-rule attributes
            CompatibilityRuleAttributesValidator.ValidateMcAttributes(validationContext);

            ValidateAttributes(validationContext);

            // validate particles
            if (theElement is OpenXmlLeafTextElement)
            {
                SimpleContentComplexTypeValidator.Validate(validationContext);
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

                if (theElement.ParticleConstraint != null)
                {
                    // composite element
                    CompositeComplexTypeValidator.Validate(validationContext, theElement.ParticleConstraint.Build(_version));
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
        private static void ValidateAttributes(ValidationContext validationContext)
        {
            var element = validationContext.Element;

            ValidationErrorInfo errorInfo;

            foreach (var attribute in element.Attributes)
            {
                ValidateValue(validationContext, attribute.Property.Validators, attribute.Value, attribute.Property.GetQName().ToString(), attribute.Property, true);
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

        internal static void ValidateValue(ValidationContext validationContext, ValidatorCollection validators, OpenXmlSimpleType value, string qname, ElementProperty<OpenXmlSimpleType> state, bool isAttribute)
        {
            var element = validationContext.Element;
            var errors = validationContext.Errors.Count;

            foreach (var validator in validators)
            {
                validator.Validate(validationContext.ToContext(value, state, isAttribute));

                // Break early if validation has hit an error
                if (errors != validationContext.Errors.Count)
                {
                    return;
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
            internal static void Validate(ValidationContext validationContext)
            {
                // first check whether there are invalid children under this OpenXmlLeafTextElement.
                EmptyComplexTypeValidator.Validate(validationContext);

                var element = (OpenXmlLeafTextElement)validationContext.Element;
                var value = element.InnerTextToValue(element.Text);
                var qname = element.XmlQualifiedName.ToString();
                var state = new ElementProperty<OpenXmlSimpleType>(element.NamespaceId, element.LocalName, 0, element.ElementData.Info.Validators, new ElementPropertyAccessor<OpenXmlSimpleType>(_ => value, (_, __) => throw new NotImplementedException(), value.GetType()));

                SchemaTypeValidator.ValidateValue(validationContext, element.ElementData.Info.Validators, value, qname, state, false);
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
