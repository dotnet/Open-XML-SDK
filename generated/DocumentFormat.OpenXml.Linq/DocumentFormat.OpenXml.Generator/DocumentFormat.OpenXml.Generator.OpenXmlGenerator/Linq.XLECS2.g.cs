// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xlecs2="http://schemas.microsoft.com/office/spreadsheetml/2025/externalCodeService2" namespace.
    /// </summary>
    public static partial class XLECS2
    {
        /// <summary>
        /// Defines the XML namespace associated with the xlecs2 prefix.
        /// </summary>
        public static readonly XNamespace xlecs2 = "http://schemas.microsoft.com/office/spreadsheetml/2025/externalCodeService2";

        /// <summary>
        /// Represents the xlecs2:externalCodeServiceImageAsInput XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.maxHeight" />, <see cref="NoNamespace.maxWidth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalCodeServiceImageAsInput.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalCodeServiceImageAsInput = xlecs2 + "externalCodeServiceImageAsInput";
    }
}
