﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Equality comparer for determining value equality for <see cref="OpenXmlElement"/>.
    /// </summary>
    public static class OpenXmlElementComparers
    {
        /// <summary>
        /// Gets the default equality comparer.
        /// </summary>
        public static IEqualityComparer<OpenXmlElement> Default { get; } = Create(new OpenXmlElementEqualityOptions());

        /// <summary>
        /// Creates a <see cref="IEqualityComparer{OpenXmlElement}"/> based on the given options./>
        /// </summary>
        /// <param name="openXmlElementEqualityOptions">The options defining equality.</param>
        /// <returns></returns>
        public static IEqualityComparer<OpenXmlElement> Create(OpenXmlElementEqualityOptions openXmlElementEqualityOptions)
        {
            return new OpenXmlElementEqualityComparer(openXmlElementEqualityOptions);
        }
    }
}
