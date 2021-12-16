// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xlrd="http://schemas.microsoft.com/office/spreadsheetml/2017/richdata" namespace.
    /// </summary>
    public static class XLRD
    {
        /// <summary>
        /// Defines the XML namespace associated with the xlrd prefix.
        /// </summary>
        public static readonly XNamespace xlrd = "http://schemas.microsoft.com/office/spreadsheetml/2017/richdata";

        /// <summary>
        /// Represents the xlrd:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rvData" />, <see cref="rvStructures" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xlrd + "extLst";

        /// <summary>
        /// Represents the xlrd:fb XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rv" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueFallback.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fb = xlrd + "fb";

        /// <summary>
        /// Represents the xlrd:k XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.n" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Key.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName k = xlrd + "k";

        /// <summary>
        /// Represents the xlrd:rv XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rvData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="fb" />, <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.s" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rv = xlrd + "rv";

        /// <summary>
        /// Represents the xlrd:rvData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="rv" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rvData = xlrd + "rvData";

        /// <summary>
        /// Represents the xlrd:rvStructures XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueStructures.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rvStructures = xlrd + "rvStructures";

        /// <summary>
        /// Represents the xlrd:s XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rvStructures" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="k" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueStructure.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName s = xlrd + "s";

        /// <summary>
        /// Represents the xlrd:v XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rv" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Value.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName v = xlrd + "v";
    }
}
