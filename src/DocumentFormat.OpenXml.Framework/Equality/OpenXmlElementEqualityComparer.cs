// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml
{
    internal sealed class OpenXmlElementEqualityComparer : IEqualityComparer<OpenXmlElement>
    {
        /// <summary>
        /// Gets the options regulating how equality is defined.
        /// </summary>
        internal OpenXmlElementEqualityOptions Options { get; }

        internal OpenXmlElementEqualityComparer(OpenXmlElementEqualityOptions options)
        {
            this.Options = options;
        }

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

        internal static bool PrefixAndQNameEqual(OpenXmlElement x, OpenXmlElement y, OpenXmlElementEqualityOptions options)
        {
            OpenXmlQualifiedName tQName = x.ParsedState.Metadata.QName;
            OpenXmlQualifiedName oQName = y.ParsedState.Metadata.QName;

            if (!tQName.Equals(oQName))
            {
                return false;
            }

            if (options.SkipPrefixComparison)
            {
                return true;
            }

            string turi = tQName.Namespace.Uri;
            string ouri = oQName.Namespace.Uri;

            var tPrefix = x.LookupPrefixLocal(ouri);
            var oPrefix = y.LookupPrefixLocal(ouri);

            if (string.IsNullOrEmpty(tPrefix))
            {
               tPrefix = x.Features.GetNamespaceResolver().LookupPrefix(turi);
            }

            if (string.IsNullOrEmpty(oPrefix))
            {
                oPrefix = y.Features.GetNamespaceResolver().LookupPrefix(ouri);
            }

            return string.Equals(tPrefix, oPrefix, StringComparison.Ordinal);
        }

        internal static bool MoveNextAndTrackCount(ref OpenXmlElementList.Enumerator e1, ref OpenXmlElementList.Enumerator e2, ref int e1ctr, ref int e2ctr)
        {
            if (e1.MoveNext())
            {
                e1ctr++;
                if (e2.MoveNext())
                {
                    e2ctr++;
                    return true;
                }
            }
            else if (e2.MoveNext())
            {
                e2ctr++;
            }

            return false;
        }
    }
}
