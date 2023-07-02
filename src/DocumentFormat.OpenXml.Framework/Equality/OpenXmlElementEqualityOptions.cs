// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Equality
{
    /// <summary>
    /// Options defining the behaviour of equality for <see cref="OpenXmlElement"/>.
    /// </summary>
    [Flags]
    public enum OpenXmlElementEqualityOptions
    {
        /// <summary>
        /// Only consider elements and their nested elements.
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies if extended attributes should be considered when determining equality.
        /// </summary>
        IncludeExtendedAttributes = 1,

        /// <summary>
        /// Specifies if MC attributes should be considered when determining equality.
        /// </summary>
        IncludeMCAttributes = 2,

        /// <summary>
        /// Specifies if namespace should alone be used when comparing idenity of elements, skipping prefix lookup.
        /// </summary>
        CompareNamespaceInsteadOfPrefix = 4,

        /// <summary>
        /// Specifies that elements must be parsed which ensures order of schema is used instead of input ordering.
        /// </summary>
        RequireParsed = 8,

        /// <summary>
        /// The default.
        /// </summary>
        Default = IncludeExtendedAttributes | IncludeMCAttributes,
    }
}
