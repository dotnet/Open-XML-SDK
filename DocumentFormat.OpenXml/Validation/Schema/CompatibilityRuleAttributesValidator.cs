// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Compatibility-Rule Attributes
    /// </summary>
    internal static class CompatibilityRuleAttributesValidator
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
                            validationContext.AddError(errorInfo);
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
                        validationContext.AddError(errorInfo);
                    }
                    else
                    {
                        string errorQName = ValidateQNameList(element.MCAttributes.PreserveAttributes, ignorableNamespaces, validationContext);
                        if (!string.IsNullOrEmpty(errorQName))
                        {
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveAttributesAttribute", element.MCAttributes.PreserveAttributes);
                            validationContext.AddError(errorInfo);
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
                        validationContext.AddError(errorInfo);
                    }
                    else
                    {
                        string errorQName = ValidateQNameList(element.MCAttributes.PreserveElements, ignorableNamespaces, validationContext);
                        if (!string.IsNullOrEmpty(errorQName))
                        {
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveElementsAttribute", element.MCAttributes.PreserveElements);
                            validationContext.AddError(errorInfo);
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
                        validationContext.AddError(errorInfo);
                    }
                    else
                    {
                        string errorQName = ValidateQNameList(element.MCAttributes.ProcessContent, ignorableNamespaces, validationContext);
                        if (!string.IsNullOrEmpty(errorQName))
                        {
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidProcessContentAttribute", element.MCAttributes.ProcessContent);
                            validationContext.AddError(errorInfo);
                        }
                    }

                    foreach (var exAttribute in element.ExtendedAttributes)
                    {
                         // Markup consumers that encounter a non-ignored element that has an xml:lang or xml:space attribute and is also identified by a ProcessContent attribute value might generate an error.
                        if (AlternateContentValidator.IsXmlSpaceOrXmlLangAttribue(exAttribute))
                        {
                            // report error.
                            errorInfo = validationContext.ComposeMcValidationError(element, "MC_InvalidXmlAttributeWithProcessContent");
                            validationContext.AddError(errorInfo);
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
                            validationContext.AddError(errorInfo);
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
}
