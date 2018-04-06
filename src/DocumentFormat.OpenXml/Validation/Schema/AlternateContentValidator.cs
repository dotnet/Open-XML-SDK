// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Validator for MarkupCompatibility feature - AlternateContent.
    /// </summary>
    /// <remarks>
    /// See Ecma376 "Part 5: Markup Compatibility and Extensibility" for reference.
    /// </remarks>
    internal class AlternateContentValidator
    {
        /// <summary>
        /// Validate ACB syntax - AlternateContent, Choice, Fallback and their attributes.
        /// </summary>
        /// <param name="validationContext"></param>
        internal static void Validate(ValidationContext validationContext)
        {
            AlternateContent acElement = (AlternateContent)validationContext.Element;

            // Validate MC attribute on AlternateContent
            ValidateMcAttributesOnAcb(validationContext, acElement);

            int status = 0;
            ValidationErrorInfo errorInfo;

            if (acElement.ChildElements.Count == 0)
            {
                // Rule: An AlternateContent element shall contain one or more Choice child elements
                errorInfo = validationContext.ComposeMcValidationError(acElement, "Sch_IncompleteContentExpectingComplex", ValidationResources.MC_ShallContainChoice);
                validationContext.AddError(errorInfo);
            }

            OpenXmlElement child;

            child = acElement.GetFirstNonMiscElementChild();

            while (child != null)
            {
                if (child is AlternateContent)
                {
                    // Rule: An AlternateContent element shall not be the child of an AlternateContent element.
                    errorInfo = validationContext.ComposeMcValidationError(acElement, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), ValidationResources.MC_ShallNotContainAlternateContent);
                    validationContext.AddError(errorInfo);
                }
                else
                {
                    switch (status)
                    {
                        case 0:
                            // expect a Choice
                            if (child is AlternateContentChoice)
                            {
                                // validate the MC attributes on Choice
                                ValidateMcAttributesOnAcb(validationContext, child);
                                status = 1;
                            }
                            else
                            {
                                // Rule: An AlternateContent element shall contain one or more Choice child elements
                                errorInfo = validationContext.ComposeMcValidationError(acElement, "Sch_IncompleteContentExpectingComplex", ValidationResources.MC_ShallContainChoice);
                                validationContext.AddError(errorInfo);

                                if (child is AlternateContentFallback)
                                {
                                    // validate the MC attributes on Fallback
                                    ValidateMcAttributesOnAcb(validationContext, child);
                                }
                            }

                            break;

                        case 1:
                            // Already one Choice, expect Choice or Fallback
                            if (child is AlternateContentChoice)
                            {
                                // validate the MC attributes on Choice
                                ValidateMcAttributesOnAcb(validationContext, child);
                                status = 1;
                            }
                            else if (child is AlternateContentFallback)
                            {
                                // validate the MC attributes on Fallback
                                ValidateMcAttributesOnAcb(validationContext, child);
                                status = 2;
                            }
                            else
                            {
                                errorInfo = validationContext.ComposeMcValidationError(acElement, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), ValidationResources.MC_ShallContainChoice);
                                validationContext.AddError(errorInfo);
                            }

                            break;

                        case 2:
                            // Already one Fallback. Can not have more than one Fallback
                            errorInfo = validationContext.ComposeMcValidationError(acElement, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), ValidationResources.MC_ShallContainChoice);
                            validationContext.AddError(errorInfo);
                            break;
                    }
                }

                child = child.GetNextNonMiscElementSibling();
            }

            return;
        }

        /// <summary>
        /// Validate attributes on AlternateContent, Choice and Fallback element.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <param name="acElement">The element to be validated.</param>
        private static void ValidateMcAttributesOnAcb(ValidationContext validationContext, OpenXmlElement acElement)
        {
            ValidationErrorInfo errorInfo;

            // AlternateContent elements might include the attributes Ignorable, MustUnderstand, ProcessContent, PreserveElements, and PreserveAttributes
            // These attributes’ qualified names shall be prefixed when associated with an AlternateContent / Choice / Fallback element.
            // A markup consumer shall generate an error if it encounters an unprefixed attribute name associated with an AlternateContent element.
            if (acElement.ExtendedAttributes != null)
            {
                foreach (var exAttribute in acElement.ExtendedAttributes)
                {
                    if (string.IsNullOrEmpty(exAttribute.Prefix))
                    {
                        // error on any unprefixed attributes
                        errorInfo = validationContext.ComposeMcValidationError(acElement, ValidationResources.MC_ErrorOnUnprefixedAttributeName, exAttribute.XmlQualifiedName.ToString());
                        validationContext.AddError(errorInfo);
                    }

                    // Markup consumers shall generate an error if they encounter the xml:lang or xml:space attributes on an AlternateContent element.
                    // Markup consumers shall generate an error if they encounter the xml:lang or xml:space attributes on a Choice element, regardless of whether the element is preceded by a selected Choice element.
                    // Markup consumers shall generate an error if they encounter the xml:lang or xml:space attributes on a Fallback element, regardless of whether the element is preceded by a selected Choice element.
                    if (IsXmlSpaceOrXmlLangAttribue(exAttribute))
                    {
                        // report error.
                        errorInfo = validationContext.ComposeMcValidationError(acElement, "MC_InvalidXmlAttribute", acElement.LocalName);
                        validationContext.AddError(errorInfo);
                    }
                }
            }

            // validate MC attributes (Ignorable, PreserveElements, etc.) of this element.
            CompatibilityRuleAttributesValidator.ValidateMcAttributes(validationContext);

            if (acElement is AlternateContentChoice choice)
            {
                // All Choice elements shall have a Requires attribute whose value contains a whitespace-delimited list of namespace prefixes
                if (choice.Requires == null)
                {
                    // report error
                    errorInfo = validationContext.ComposeMcValidationError(acElement, "MC_MissedRequiresAttribute");
                    validationContext.AddError(errorInfo);
                }
                else
                {
                    var prefixes = new ListValue<StringValue>();
                    prefixes.InnerText = choice.Requires;
                    foreach (var prefix in prefixes.Items)
                    {
                        var ignorableNamespace = choice.LookupNamespace(prefix);
                        if (string.IsNullOrEmpty(ignorableNamespace))
                        {
                            // report error, the prefix is not defined.
                            errorInfo = validationContext.ComposeMcValidationError(choice, "MC_InvalidRequiresAttribute", choice.Requires);
                            validationContext.AddError(errorInfo);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Test whether the attribute is "xml:space" or "xml:lang".
        /// </summary>
        /// <param name="attribute">The attribute to be tested.</param>
        /// <returns>True if the attribute is "xml:space" or "xml:lang".</returns>
        internal static bool IsXmlSpaceOrXmlLangAttribue(OpenXmlAttribute attribute)
        {
            if ("http://www.w3.org/XML/1998/namespace" == attribute.NamespaceUri)
            {
                if (attribute.LocalName == "space" || attribute.LocalName == "lang")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
