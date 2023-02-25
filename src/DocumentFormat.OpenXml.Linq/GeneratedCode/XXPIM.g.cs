// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xxpim="http://schemas.microsoft.com/office/spreadsheetml/2020/pivotNov2020" namespace.
    /// </summary>
    public static class XXPIM
    {
        /// <summary>
        /// Defines the XML namespace associated with the xxpim prefix.
        /// </summary>
        public static readonly XNamespace xxpim = "http://schemas.microsoft.com/office/spreadsheetml/2020/pivotNov2020";

        /// <summary>
        /// Represents the xxpim:implicitMeasureSupport XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Xsdboolean.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName implicitMeasureSupport = xxpim + "implicitMeasureSupport";
    }
}
