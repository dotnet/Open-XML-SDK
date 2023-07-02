// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DocumentFormat.OpenXml.Equality
{
    /// <summary>
    /// Equality comparer for determining value equality for <see cref="OpenXmlElement"/>.
    /// </summary>
    public sealed class OpenXmlElementEqualityComparer : IEqualityComparer<OpenXmlElement>
    {
        private static readonly OpenXmlElementEqualityComparer[] Comparers = InitializeComparers();

        private static OpenXmlElementEqualityComparer[] InitializeComparers()
        {
            // Calculate how many comparer there can maximum be.
            var hs = new HashSet<int>(Enumerable.Range(0, Enum.GetValues<OpenXmlElementEqualityOptions>().Length).Select(f => (int)Math.Pow(2, f)));
            int comparerMaxCombinations = (int)Math.Pow(2, Enum.GetValues<OpenXmlElementEqualityOptions>().Where(f => hs.Contains((int)f)).Count());

            var comparers = new OpenXmlElementEqualityComparer[comparerMaxCombinations];
            for (int i = 0; i < comparerMaxCombinations; i++)
            {
                comparers[i] = new OpenXmlElementEqualityComparer((OpenXmlElementEqualityOptions)i);
            }

            return comparers;
        }

        private OpenXmlElementEqualityComparer(OpenXmlElementEqualityOptions options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Gets the options regulating how equality is defined.
        /// </summary>
        internal OpenXmlElementEqualityOptions Options { get; }

        /// <summary>
        /// Gets the <see cref="IEqualityComparer{OpenXmlElement}"/> based on the given options./>
        /// </summary>
        /// <param name="openXmlElementEqualityOptions">The options defining equality.</param>
        /// <returns></returns>
        public static IEqualityComparer<OpenXmlElement> GetEqualityComparer(OpenXmlElementEqualityOptions openXmlElementEqualityOptions) => Comparers[(int)openXmlElementEqualityOptions];

        /// <summary>
        /// Gets the default equality comparer.
        /// </summary>
        public static IEqualityComparer<OpenXmlElement> Default => GetEqualityComparer(OpenXmlElementEqualityOptions.Default);

        /// <summary>
        /// Determines equality for two given <see cref="OpenXmlElement"/>.
        /// </summary>
        /// <param name="x">First object.</param>
        /// <param name="y">Second object.</param>
        /// <returns></returns>
        public bool Equals(OpenXmlElement? x, OpenXmlElement? y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return x.ValueEquality(y, this);
        }

        /// <summary>
        /// Calculates a hashcode based on the given <see cref="OpenXmlElement"/> object.
        /// </summary>
        /// <param name="obj">The object to get a hashcode for.</param>
        /// <returns></returns>
        public int GetHashCode([DisallowNull] OpenXmlElement obj)
        {
            if (obj == null)
            {
                return 0;
            }

            return obj.GetValueHashCode(this.Options);
        }
    }
}
