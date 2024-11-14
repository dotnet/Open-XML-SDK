// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xlpda="http://schemas.microsoft.com/office/spreadsheetml/2024/pivotDynamicArrays" namespace.
    /// </summary>
    public static partial class XLPDA
    {
        /// <summary>
        /// Defines the XML namespace associated with the xlpda prefix.
        /// </summary>
        public static readonly XNamespace xlpda = "http://schemas.microsoft.com/office/spreadsheetml/2024/pivotDynamicArrays";

        /// <summary>
        /// Represents the xlpda:pivotCacheDynamicArray XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheDynamicArray.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCacheDynamicArray = xlpda + "pivotCacheDynamicArray";
    }
}
