// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Options defining the behaviour of equality for <see cref="OpenXmlElement"/>.
    /// </summary>
    public sealed class OpenXmlElementEqualityOptions
    {
        /// <summary>
        /// Gets a value indicating whether extended attributes should be considered when determining equality.
        /// </summary>
        public bool IncludeExtendedAttributes { get; init; } = true;

        /// <summary>
        /// Gets a value indicating whether MC attributes should be considered when determining equality.
        /// </summary>
        public bool IncludeMCAttributes { get; init; } = true;

        /// <summary>
        /// Gets a value indicating whether namespace should alone be used when comparing idenity of elements, skipping prefix lookup.
        /// </summary>
        public bool CompareNamespaceInsteadOfPrefix { get; init; } = false;

        /// <summary>
        /// Gets a value indicating whether elements must be parsed which ensures order of schema is used instead of input ordering.
        /// </summary>
        public bool RequireParsed { get; init; } = false;
    }
}
