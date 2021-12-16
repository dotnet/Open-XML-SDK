// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xlrd2="http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2" namespace.
    /// </summary>
    public static class XLRD2
    {
        /// <summary>
        /// Defines the XML namespace associated with the xlrd2 prefix.
        /// </summary>
        public static readonly XNamespace xlrd2 = "http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2";

        /// <summary>
        /// Represents the xlrd2:a XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="arrayData" />, <see cref="spbArrays" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.c" />, <see cref="NoNamespace.count" />, <see cref="NoNamespace.r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Array, SupportingPropertyBagArray.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName a = xlrd2 + "a";

        /// <summary>
        /// Represents the xlrd2:arrayData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="a" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ArrayData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName arrayData = xlrd2 + "arrayData";

        /// <summary>
        /// Represents the xlrd2:dxfs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="richStyleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.dxf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Dxfs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxfs = xlrd2 + "dxfs";

        /// <summary>
        /// Represents the xlrd2:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="arrayData" />, <see cref="global" />, <see cref="richStyleSheet" />, <see cref="rvTypesInfo" />, <see cref="spbArrays" />, <see cref="spbData" />, <see cref="spbStructures" />, <see cref="type" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xlrd2 + "extLst";

        /// <summary>
        /// Represents the xlrd2:flag XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="key" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueTypeReservedKeyFlag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName flag = xlrd2 + "flag";

        /// <summary>
        /// Represents the xlrd2:global XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rvTypesInfo" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="keyFlags" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueGlobalType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName global = xlrd2 + "global";

        /// <summary>
        /// Represents the xlrd2:k XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.n" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SupportingPropertyBagKey.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName k = xlrd2 + "k";

        /// <summary>
        /// Represents the xlrd2:key XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="keyFlags" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="flag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueTypeReservedKey.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName key = xlrd2 + "key";

        /// <summary>
        /// Represents the xlrd2:keyFlags XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="global" />, <see cref="type" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="key" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueTypeKeyFlags.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName keyFlags = xlrd2 + "keyFlags";

        /// <summary>
        /// Represents the xlrd2:richProperties XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="richStyleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichFormatProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName richProperties = xlrd2 + "richProperties";

        /// <summary>
        /// Represents the xlrd2:richStyles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="richStyleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rSty" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName richStyles = xlrd2 + "richStyles";

        /// <summary>
        /// Represents the xlrd2:richStyleSheet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="dxfs" />, <see cref="extLst" />, <see cref="richProperties" />, <see cref="richStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichStylesheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName richStyleSheet = xlrd2 + "richStyleSheet";

        /// <summary>
        /// Represents the xlrd2:rPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="richProperties" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.n" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichFormatProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rPr = xlrd2 + "rPr";

        /// <summary>
        /// Represents the xlrd2:rpv XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rSty" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.i" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichStylePropertyValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rpv = xlrd2 + "rpv";

        /// <summary>
        /// Represents the xlrd2:rSty XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="richStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rpv" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dxfid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rSty = xlrd2 + "rSty";

        /// <summary>
        /// Represents the xlrd2:rvTypesInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="global" />, <see cref="types" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueTypesInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rvTypesInfo = xlrd2 + "rvTypesInfo";

        /// <summary>
        /// Represents the xlrd2:s XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="spbStructures" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="k" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SupportingPropertyBagStructure.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName s = xlrd2 + "s";

        /// <summary>
        /// Represents the xlrd2:spb XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="spbData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.s" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SupportingPropertyBag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spb = xlrd2 + "spb";

        /// <summary>
        /// Represents the xlrd2:spbArrays XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="supportingPropertyBags" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="a" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SupportingPropertyBagArrayData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spbArrays = xlrd2 + "spbArrays";

        /// <summary>
        /// Represents the xlrd2:spbData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="supportingPropertyBags" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spb" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SupportingPropertyBagData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spbData = xlrd2 + "spbData";

        /// <summary>
        /// Represents the xlrd2:spbStructures XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SupportingPropertyBagStructures.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spbStructures = xlrd2 + "spbStructures";

        /// <summary>
        /// Represents the xlrd2:supportingPropertyBags XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="spbArrays" />, <see cref="spbData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SupportingPropertyBags.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName supportingPropertyBags = xlrd2 + "supportingPropertyBags";

        /// <summary>
        /// Represents the xlrd2:type XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="types" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="keyFlags" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName type = xlrd2 + "type";

        /// <summary>
        /// Represents the xlrd2:types XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rvTypesInfo" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichValueTypes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName types = xlrd2 + "types";

        /// <summary>
        /// Represents the xlrd2:v XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="a" />, <see cref="spb" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ArrayValue, SupportingPropertyBagArrayValue, SupportingPropertyBagValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName v = xlrd2 + "v";
    }
}
