// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xlecs="http://schemas.microsoft.com/office/spreadsheetml/2023/externalCodeService" namespace.
    /// </summary>
    public static class XLECS
    {
        /// <summary>
        /// Defines the XML namespace associated with the xlecs prefix.
        /// </summary>
        public static readonly XNamespace xlecs = "http://schemas.microsoft.com/office/spreadsheetml/2023/externalCodeService";

        /// <summary>
        /// Represents the xlecs:externalCodeService XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoShow" />, <see cref="NoNamespace.timeout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalCodeService.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalCodeService = xlecs + "externalCodeService";
    }
}
