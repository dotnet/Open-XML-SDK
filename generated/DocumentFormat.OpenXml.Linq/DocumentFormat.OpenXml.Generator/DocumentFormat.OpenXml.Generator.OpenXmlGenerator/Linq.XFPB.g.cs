// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xfpb="http://schemas.microsoft.com/office/spreadsheetml/2022/featurepropertybag" namespace.
    /// </summary>
    public static partial class XFPB
    {
        /// <summary>
        /// Defines the XML namespace associated with the xfpb prefix.
        /// </summary>
        public static readonly XNamespace xfpb = "http://schemas.microsoft.com/office/spreadsheetml/2022/featurepropertybag";

        /// <summary>
        /// Represents the xfpb:a XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bag" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="b" />, <see cref="bagId" />, <see cref="d" />, <see cref="i" />, <see cref="rel" />, <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ArrayFeatureProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName a = xfpb + "a";

        /// <summary>
        /// Represents the xfpb:b XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="a" />, <see cref="bag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BoolFeatureProperty, Xsdboolean.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName b = xfpb + "b";

        /// <summary>
        /// Represents the xfpb:bag XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="FeaturePropertyBags" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="a" />, <see cref="b" />, <see cref="bagId" />, <see cref="d" />, <see cref="i" />, <see cref="rel" />, <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.att" />, <see cref="NoNamespace.bagExtId" />, <see cref="NoNamespace.extRef" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FeaturePropertyBag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bag = xfpb + "bag";

        /// <summary>
        /// Represents the xfpb:bagExt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="FeaturePropertyBags" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BagExtensions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bagExt = xfpb + "bagExt";

        /// <summary>
        /// Represents the xfpb:bagId XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="a" />, <see cref="bag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BagFeatureProperty, XsdunsignedInt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bagId = xfpb + "bagId";

        /// <summary>
        /// Represents the xfpb:d XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="a" />, <see cref="bag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DecimalFeatureProperty, Xsddouble.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName d = xfpb + "d";

        /// <summary>
        /// Represents the xfpb:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bagExt" />, <see cref="FeaturePropertyBags" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xfpb + "extLst";

        /// <summary>
        /// Represents the xfpb:FeaturePropertyBags XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="bag" />, <see cref="bagExt" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FeaturePropertyBags.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FeaturePropertyBags = xfpb + "FeaturePropertyBags";

        /// <summary>
        /// Represents the xfpb:i XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="a" />, <see cref="bag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IntFeatureProperty, Xsdinteger.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i = xfpb + "i";

        /// <summary>
        /// Represents the xfpb:rel XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="a" />, <see cref="bag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelFeatureProperty, RelXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rel = xfpb + "rel";

        /// <summary>
        /// Represents the xfpb:s XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="a" />, <see cref="bag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringFeatureProperty, SXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName s = xfpb + "s";
    }
}
