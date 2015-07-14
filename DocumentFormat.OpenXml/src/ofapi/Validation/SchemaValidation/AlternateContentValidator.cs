// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
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
                validationContext.EmitError(errorInfo);
            }

            OpenXmlElement child;
            
            child = acElement.GetFirstNonMiscElementChild();

            while (child != null)
            {
                if (child is AlternateContent)
                {
                    // Rule: An AlternateContent element shall not be the child of an AlternateContent element.
                    errorInfo = validationContext.ComposeMcValidationError(acElement, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), ValidationResources.MC_ShallNotContainAlternateContent);
                    validationContext.EmitError(errorInfo);

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
                                validationContext.EmitError(errorInfo);

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
                                validationContext.EmitError(errorInfo);
                            }
                            break;

                        case 2:
                            // Already one Fallback. Can not have more than one Fallback
                            errorInfo = validationContext.ComposeMcValidationError(acElement, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), ValidationResources.MC_ShallContainChoice);
                            validationContext.EmitError(errorInfo);
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
                        validationContext.EmitError(errorInfo);
                    }

                    // Markup consumers shall generate an error if they encounter the xml:lang or xml:space attributes on an AlternateContent element.
                    // Markup consumers shall generate an error if they encounter the xml:lang or xml:space attributes on a Choice element, regardless of whether the element is preceded by a selected Choice element.
                    // Markup consumers shall generate an error if they encounter the xml:lang or xml:space attributes on a Fallback element, regardless of whether the element is preceded by a selected Choice element.
                    if (IsXmlSpaceOrXmlLangAttribue(exAttribute))
                    {
                        // report error.
                        errorInfo = validationContext.ComposeMcValidationError(acElement, "MC_InvalidXmlAttribute", acElement.LocalName);
                        validationContext.EmitError(errorInfo);
                    }
                }
            }

            // validate MC attribues (Ignorable, PreserveElements, etc.) of this element.
            CompatibilityRuleAttributesValidator.ValidateMcAttributes(validationContext);


            AlternateContentChoice choice = acElement as AlternateContentChoice;
            if (choice != null)
            {
                // All Choice elements shall have a Requires attribute whose value contains a whitespace-delimited list of namespace prefixes
                if (choice.Requires == null)
                {
                    // report error
                    errorInfo = validationContext.ComposeMcValidationError(acElement, "MC_MissedRequiresAttribute");
                    validationContext.EmitError(errorInfo);
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
                            validationContext.EmitError(errorInfo);
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
      
    /// <summary>
    /// Compatibility-Rule Attributes 
    /// </summary>
    static class CompatibilityRuleAttributesValidator
    {
        /// <summary>
        /// Validate compatibility rule attributes - Ignorable, ProcessContent, PreserveElements, PreserveAttributes, MustUnderstand.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        internal static void ValidateMcAttributes(ValidationContext validationContext)
        {
            var element = validationContext.Element;
            if (element.MCAttributes == null)
            {
                return;
            }

            HashSet<string> ignorableNamespaces = null;
            ValidationErrorInfo errorInfo;

            if (element.MCAttributes != null)
            {
                // validate Ignorable attribute
                if (!string.IsNullOrEmpty(element.MCAttributes.Ignorable))
                {
                    ignorableNamespaces = new HashSet<string>();

                    // rule: the prefix must already be defined.
                    var prefixes = new ListValue<StringValue>();
                    prefixes.InnerText = element.MCAttributes.Ignorable;
                    foreach (var prefix in prefixes.Items)
                    {
                        var ignorableNamespace = element.LookupNamespace(prefix);
                        if (string.IsNullOrEmpty(ignorableNamespace))
                        {
                            // error, the prefix is not defined.
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidIgnorableAttribute", element.MCAttributes.Ignorable);
                            validationContext.EmitError(errorInfo);
                        }
                        else
                        {
                            ignorableNamespaces.Add(ignorableNamespace);
                        }
                    }
                }


                // validate PreserveAttributes attribute
                if (!string.IsNullOrEmpty(element.MCAttributes.PreserveAttributes))
                {
                    // The ProcessAttributes attribute value shall not reference any attribute name that does not belong to a namespace
                    // that is identified by the Ignorable attribute of the same element.
                    if (ignorableNamespaces == null)
                    {
                        // must have Ignorable on same element.
                        errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveAttributesAttribute", element.MCAttributes.PreserveAttributes);
                        validationContext.EmitError(errorInfo);
                    }
                    else
                    {
                        string errorQName = ValidateQNameList(element.MCAttributes.PreserveAttributes, ignorableNamespaces, validationContext);
                        if (!string.IsNullOrEmpty(errorQName))
                        {
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveAttributesAttribute", element.MCAttributes.PreserveAttributes);
                            validationContext.EmitError(errorInfo);
                        }
                    }
                }

                // validate PreserveElements attribute
                if (!string.IsNullOrEmpty(element.MCAttributes.PreserveElements))
                {
                    // The ProcessAttributes attribute value shall not reference any attribute name that does not belong to a namespace
                    // that is identified by the Ignorable attribute of the same element.
                    if (ignorableNamespaces == null)
                    {
                        // must have Ignorable on same element.
                        errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveElementsAttribute", element.MCAttributes.PreserveElements);
                        validationContext.EmitError(errorInfo);
                    }
                    else
                    {
                        string errorQName = ValidateQNameList(element.MCAttributes.PreserveElements, ignorableNamespaces, validationContext);
                        if (!string.IsNullOrEmpty(errorQName))
                        {
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveElementsAttribute", element.MCAttributes.PreserveElements);
                            validationContext.EmitError(errorInfo);
                        }
                    }
                }

                // validate ProcessContent attribute
                if (!string.IsNullOrEmpty(element.MCAttributes.ProcessContent))
                {
                    // The ProcessAttributes attribute value shall not reference any attribute name that does not belong to a namespace
                    // that is identified by the Ignorable attribute of the same element.
                    if (ignorableNamespaces == null)
                    {
                        // must have Ignorable on same element.
                        errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidProcessContentAttribute", element.MCAttributes.ProcessContent);
                        validationContext.EmitError(errorInfo);
                    }
                    else
                    {
                        string errorQName = ValidateQNameList(element.MCAttributes.ProcessContent, ignorableNamespaces, validationContext);
                        if (!string.IsNullOrEmpty(errorQName))
                        {
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidProcessContentAttribute", element.MCAttributes.ProcessContent);
                            validationContext.EmitError(errorInfo);
                        }
                    }

                    foreach (var exAttribute in element.ExtendedAttributes)
                    {
                         // Markup consumers that encounter a non-ignored element that has an xml:lang or xml:space attribute and is also identified by a ProcessContent attribute value might generate an error.
                        if (AlternateContentValidator.IsXmlSpaceOrXmlLangAttribue(exAttribute))
                        {
                            // report error.
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidXmlAttributeWithProcessContent");
                            validationContext.EmitError(errorInfo);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(element.MCAttributes.MustUnderstand))
                {
                    // TODO: MustUnderstand
                    // A markup consumer that does not understand these identified namespaces shall not continue to process the markup document

                    // rule: the prefix must already be defined.
                    var prefixes = new ListValue<StringValue>();
                    prefixes.InnerText = element.MCAttributes.MustUnderstand;
                    foreach (var prefix in prefixes.Items)
                    {
                        var mustunderstandNamespace = element.LookupNamespace(prefix);
                        if (string.IsNullOrEmpty(mustunderstandNamespace))
                        {
                            // report error, the prefix is not defined.
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidMustUnderstandAttribute", element.MCAttributes.MustUnderstand);
                            validationContext.EmitError(errorInfo);
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Validate QName list in PreserveElements, PreserveAttributes, ProcessContent.
        /// </summary>
        /// <param name="qnameList">The QName list to be validated.</param>
        /// <param name="ignorableNamespaces">The ignorable namespaces.</param>
        /// <param name="validationContext"></param>
        /// <returns>The QName that is not valid.</returns>
        internal static string ValidateQNameList(string qnameList, HashSet<string> ignorableNamespaces, ValidationContext validationContext)
        {
            Debug.Assert(!string.IsNullOrEmpty(qnameList));

            var qnames = new ListValue<StringValue>();
            qnames.InnerText = qnameList;

            foreach (var qname in qnames.Items)
            {
                // must be QName
                var items = qname.Value.Split(':');
                if (items.Length != 2)
                {
                    return qname;
                }

                // Prefix must be already defined.
                var attributeNamesapce = validationContext.Element.LookupNamespace(items[0]);
                if (string.IsNullOrEmpty(attributeNamesapce))
                {
                    return qname;
                }

                // The namespace must be identified by the Ignorable attribute at the same element.
                if (!ignorableNamespaces.Contains(attributeNamesapce))
                {
                    return qname;
                }
            }

            return null;
        }

    }

        /// <summary>
    /// Static class to hold extension methods for OpenXmlElement.
    /// </summary>
    internal static partial class OpenXmlElementExtensionMethods
    {
        #region MC related methods

        internal static OpenXmlElement GetFirstChildMc(this OpenXmlElement parent, MCContext mcContext, FileFormatVersions format)
        {
            var child = parent.GetFirstNonMiscElementChild();
            return parent.GetChildMc(child, mcContext, format);
        }

        internal static OpenXmlElement GetNextChildMc(this OpenXmlElement parent, OpenXmlElement child, MCContext mcContext, FileFormatVersions format)
        {
            var next = child.GetNextNonMiscElementSibling();
            var mcTier = child.Parent;

            if (next == null && mcTier != parent)
            {
                // the child must be under element in ProcessContent or ACB
                if (mcTier is AlternateContentChoice || mcTier is AlternateContentFallback)
                {
                    mcTier = mcTier.Parent;
                }
                Debug.Assert(mcTier != null);

                // there is no more next sibling in this level, then try to find the next siblig of the up level.
                return parent.GetNextChildMc(mcTier, mcContext, format);
            }

            return parent.GetChildMc(next, mcContext, format);
        }

        /// <summary>
        /// Gets the next child (skip all MC elements (skip ACB layer, skip Ignorabled element.)).
        /// </summary>
        /// <param name="parent">The logic parent element.</param>
        /// <param name="child">The child element to be tested.</param>
        /// <param name="mcContext">Markup Compatibility context.</param>
        /// <param name="format">Targeting file format (Office2007 or Office201).</param>
        /// <returns>The logic child (when we apply a MC pre-processer).</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "parent")]
        private static OpenXmlElement GetChildMc(this OpenXmlElement parent, OpenXmlElement child, MCContext mcContext, FileFormatVersions format)
        {
            // Use stack to cache the next siblings in different levels.
            Stack<OpenXmlElement> nextSiblings = new Stack<OpenXmlElement>();

            while (child != null)
            {
                var acb = child as AlternateContent;
                if (acb == null && child.IsInVersion(format))
                {
                    return child;
                }
                else
                {
                    mcContext.PushMCAttributes2(child.MCAttributes, child.LookupNamespace);
                    if (acb != null)
                    {
                        nextSiblings.Push(child.GetNextNonMiscElementSibling());
                        var select = mcContext.GetContentFromACBlock(acb, format);
                        if (select != null)
                        {
                            child = select.GetFirstNonMiscElementChild();
                        }
                        else
                        {
                            // The ACB has no children elements. 
                            // case like: <acb/> <acb><choice/><fallback/></acb>
                            child = null;
                        }
                    }
                    else
                    {
                        // Ignorable element, skip it
                        if (mcContext.IsIgnorableNs(child.NamespaceUri))
                        {
                            // Any element marked with ProcessContent should be an Ignorable Element
                            if (mcContext.IsProcessContent(child))
                            {
                                nextSiblings.Push(child.GetNextNonMiscElementSibling());
                                //
                                child = child.GetFirstNonMiscElementChild();
                            }
                            else
                            {
                                child = child.GetNextNonMiscElementSibling();
                            }
                        }
                        else
                        {
                            mcContext.PopMCAttributes2();
                            return child;
                        }
                    }
                    mcContext.PopMCAttributes2();
                }

                while (child == null && nextSiblings.Count > 0)
                {
                    child = nextSiblings.Pop();
                }
            }

            // child is null.
            return child;
        }

        #endregion
    }
}
