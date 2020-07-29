// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Validate an OpenXmlElement based on the schema.
    /// </summary>
    internal class SchemaTypeValidator
    {
        /// <summary>
        /// Only validation whether the children elements are valid according to this type's constraint defined in schema.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        public static void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Stack.Current.Element != null);

            OpenXmlElement theElement = validationContext.Stack.Current.Element;

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

            // validate Ignorable, ProcessContent, etc. compatibility-rule attributes
            CompatibilityRuleAttributesValidator.ValidateMcAttributes(validationContext);

            if (theElement is IValidator validator)
            {
                validator.Validate(validationContext);
            }

            ValidateAttributes(validationContext);

            // validate particles
            if (theElement is OpenXmlLeafTextElement)
            {
                ValidateSimpleContextComplexType(validationContext);
            }
            else if (theElement is OpenXmlLeafElement)
            {
                ValidateEmptyComplexType(validationContext);
            }
            else
            {
                Debug.Assert(theElement is OpenXmlCompositeElement);

                Debug.Assert(!(theElement is AlternateContentChoice));
                Debug.Assert(!(theElement is AlternateContentFallback));

                if (theElement.Metadata.Particle != null)
                {
                    // composite element
                    ValidateCompositeComplexType(validationContext);
                }
                else
                {
                    // special case, see O14 bug #662644
                    // A root element which does not allow any children.
                    Debug.Assert(theElement is OpenXmlPartRootElement);
                    ValidateEmptyRootComplexType(validationContext);
                }
            }
        }

        /// <summary>
        /// Validate the attributes constraint.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        private static void ValidateAttributes(ValidationContext validationContext)
        {
            var element = validationContext.Stack.Current.Element;

            ValidationErrorInfo errorInfo;

            foreach (var attribute in element.ParsedState.Attributes)
            {
                ValidateValue(validationContext, attribute.Property.Validators, attribute.Value, attribute.Property, true);
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
                else if (extendedAttribute.NamespaceUri == "http://www.w3.org/XML/1998/namespace")
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

        private static void ValidateValue(ValidationContext validationContext, ReadOnlyArray<IValidator> validators, OpenXmlSimpleType value, AttributeMetadata state, bool isAttribute)
        {
            var errors = validationContext.Errors.Count;

            using (validationContext.Stack.Push(value, state, isAttribute))
            {
                foreach (var validator in validators)
                {
                    validator.Validate(validationContext);

                    // Break early if validation has hit an error
                    if (errors != validationContext.Errors.Count)
                    {
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// empty CT, OpenXmlLeafElement
        /// </summary>
        private static void ValidateEmptyComplexType(ValidationContext validationContext)
        {
            OpenXmlLeafElement leafElement = (OpenXmlLeafElement)validationContext.Stack.Current.Element;
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

        /// <summary>
        /// empty CT, but used as part root element, OpenXmlPartRootElement
        /// </summary>
        private static void ValidateEmptyRootComplexType(ValidationContext validationContext)
        {
            var element = (OpenXmlCompositeElement)validationContext.Stack.Current.Element;
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

        /// <summary>
        /// simple content CT, OpenXmlLeafTextElement
        /// </summary>
        private static void ValidateSimpleContextComplexType(ValidationContext validationContext)
        {
            // first check whether there are invalid children under this OpenXmlLeafTextElement.
            ValidateEmptyComplexType(validationContext);

            var element = (OpenXmlLeafTextElement)validationContext.Stack.Current.Element;
            var state = new LeafAccessor(element);

            SchemaTypeValidator.ValidateValue(validationContext, element.ParsedState.Metadata.Validators, state.Value, state, false);
        }

        /// <summary>
        /// Composite CT
        /// </summary>
        private static void ValidateCompositeComplexType(ValidationContext validationContext)
        {
            var particleConstraint = validationContext.GetParticleConstraint();

            if (particleConstraint is null)
            {
                return;
            }

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

        [DebuggerDisplay("{PropertyName,nq}")]
        private class LeafAccessor : AttributeMetadata
        {
            private readonly OpenXmlLeafTextElement _element;

            public LeafAccessor(OpenXmlLeafTextElement element)
            {
                _element = element;
                Value = element.InnerTextToValue(element.Text);
            }

            public OpenXmlSimpleType Value { get; }

            public override string PropertyName => "Value";

            public override string Name => _element.LocalName;

            public override byte NamespaceId => _element.NamespaceId;

            public override ReadOnlyArray<IValidator> Validators => _element.ParsedState.Metadata.Validators;

            public override Type Type => Value.GetType();

            public override OpenXmlSimpleType CreateNew() => throw new NotImplementedException();
        }
    }
}
