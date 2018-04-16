// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Specifies the type of each child element's occurrence.
    /// Used in GetElement() and SetElement() for generated code.
    /// </summary>
    internal enum OpenXmlCompositeType
    {
        Other,

        /// <summary>
        /// xsd:sequence, and maxOccurs=1.
        /// </summary>
        OneSequence,

        /// <summary>
        /// xsd:choice, and maxOccurs=1.
        /// </summary>
        OneChoice,

        /// <summary>
        /// xsd:all.
        /// </summary>
        OneAll,
    }
}
