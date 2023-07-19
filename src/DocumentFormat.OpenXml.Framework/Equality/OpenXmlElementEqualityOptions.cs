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
        /// Gets or sets a value indicating whether extended attributes should be considered when determining equality.
        /// </summary>
        public bool IncludeExtendedAttributes { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether mC attributes should be considered when determining equality.
        /// </summary>
        public bool IncludeMCAttributes { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether namespace should alone be used when comparing idenity of elements, skipping prefix lookup to improve performance.
        /// </summary>
        public bool SkipPrefixComparison { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether elements must be parsed which ensures order of schema is used instead of input ordering.
        /// </summary>
        public bool RequireParsed { get; set; }
    }
}
