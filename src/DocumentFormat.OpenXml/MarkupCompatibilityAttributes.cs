// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the Markup Compatibility Attributes.
    /// </summary>
    public class MarkupCompatibilityAttributes
    {
        internal static string MCPrefix = NamespaceIdMap.GetNamespacePrefix(NamespaceIdMap.GetNamespaceId(AlternateContent.MarkupCompatibilityNamespace));

        /// <summary>
        /// Gets or sets a whitespace-delimited list of prefixes, where each
        ///  prefix identifies an ignorable namespace.
        /// </summary>
        public StringValue Ignorable { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of element-qualified names
        ///  that identify the expanded names of elements. The content of the
        ///  elements shall be processed, even if the elements themselves are
        ///  ignored.
        /// </summary>
        public StringValue ProcessContent { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of element qualified names
        ///  that identify the expanded names of elements. The elements are suggested
        ///  by a markup producer for preservation by markup editors, even if
        ///  the elements themselves are ignored.
        /// </summary>
        public StringValue PreserveElements { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of attribute qualified names
        ///  that identify expanded names of attributes. The attributes were
        ///  suggested by a markup producer for preservation by markup editors.
        /// </summary>
        public StringValue PreserveAttributes { get; set; }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of prefixes that identify
        ///  a set of namespace names.
        /// </summary>
        public StringValue MustUnderstand { get; set; }
    }
}
