// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xxpvi="http://schemas.microsoft.com/office/spreadsheetml/2022/pivotVersionInfo" namespace.
    /// </summary>
    public static class XXPVI
    {
        /// <summary>
        /// Defines the XML namespace associated with the xxpvi prefix.
        /// </summary>
        public static readonly XNamespace xxpvi = "http://schemas.microsoft.com/office/spreadsheetml/2022/pivotVersionInfo";

        /// <summary>
        /// Represents the xxpvi:cacheVersionInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="lastRefreshFeature" />, <see cref="requiredFeature" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheVersionInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheVersionInfo = xxpvi + "cacheVersionInfo";

        /// <summary>
        /// Represents the xxpvi:lastRefreshFeature XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheVersionInfo" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LastRefreshFeatureXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastRefreshFeature = xxpvi + "lastRefreshFeature";

        /// <summary>
        /// Represents the xxpvi:lastUpdateFeature XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotVersionInfo" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LastUpdateFeatureXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastUpdateFeature = xxpvi + "lastUpdateFeature";

        /// <summary>
        /// Represents the xxpvi:pivotVersionInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="lastUpdateFeature" />, <see cref="requiredFeature" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotVersionInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotVersionInfo = xxpvi + "pivotVersionInfo";

        /// <summary>
        /// Represents the xxpvi:requiredFeature XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheVersionInfo" />, <see cref="pivotVersionInfo" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RequiredFeatureXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName requiredFeature = xxpvi + "requiredFeature";
    }
}
