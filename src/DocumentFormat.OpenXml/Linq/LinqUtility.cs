// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Utility class.
    /// </summary>
    public static class LinqUtility
    {
        #region OpenXmlPart Information

        private static OpenXmlPartInfos? _openXmlPartInfos;

        /// <summary>
        /// Gets information about the collection of subclasses of <see cref="OpenXmlPart" />,
        /// each of which has a single concrete subclass of <see cref="OpenXmlPartRootElement" />
        /// as its root element.
        /// </summary>
        public static OpenXmlPartInfos OpenXmlPartInfos => _openXmlPartInfos ??= new OpenXmlPartInfos();

        #endregion

        #region Preliminary Stuff

        /// <summary>
        /// Gets the collection of namespace prefixes of the w:document root element.
        /// </summary>
        public static readonly IReadOnlyCollection<string> WordprocessingNsPrefixes =
            new HashSet<string>(new[]
            {
                "wpc",
                "cx",

                // "cx1",
                // "cx2",
                // "cx3",
                // "cx4",
                // "cx5",
                // "cx6",
                // "cx7",
                // "cx8",
                "mc",
                "aink",
                "am3d",
                "o",
                "r",
                "m",
                "v",
                "wp14",
                "wp",
                "w10",
                "w",
                "w14",
                "w15",

                // "w16cex",
                "w16cid",

                // "w16",
                // "w16sdtdh",
                "w16se",
                "wpg",

                // "wpi",
                "wne",
                "wps",
            });

        /// <summary>
        /// Collection of namespace and mc:Ignorable attributes for wordprocessing-related
        /// root elements.
        /// </summary>
        public static readonly IReadOnlyCollection<XAttribute> WordprocessingNsAttributes =
            WordprocessingNsPrefixes
                .Select(CreateNsAttribute)
                .Concat(new[] { new XAttribute(MC.Ignorable, "w14 w15 w16se w16cid wp14") })
                .ToList()
                .AsReadOnly();

        /// <summary>
        ///
        /// </summary>
        public static readonly IReadOnlyCollection<string> WordprocessingNsUris =
            new HashSet<string>(WordprocessingNsPrefixes.Select(GetNamespaceUri));

        /// <summary>
        /// Creates a namespace attribute for the given namespace prefix.
        /// </summary>
        /// <param name="prefix">The namespace prefix.</param>
        /// <returns>The namespace attribute.</returns>
        public static XAttribute CreateNsAttribute(string prefix)
        {
            return new(XNamespace.Xmlns + prefix, GetNamespaceUri(prefix));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string GetNamespaceUri(string prefix)
        {
            return OpenXmlNamespace.GetNamespaceUri(prefix) ??
                   throw new ArgumentException($"Invalid namespace prefix: '{prefix}'.");
        }

        #endregion
    }
}
