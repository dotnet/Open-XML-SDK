// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:vt="http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes" namespace.
    /// </summary>
    public static class VT
    {
        /// <summary>
        /// Defines the XML namespace associated with the vt prefix.
        /// </summary>
        public static readonly XNamespace vt = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes";

        /// <summary>
        /// Represents the vt:array XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@bool" />, <see cref="bstr" />, <see cref="cy" />, <see cref="date" />, <see cref="@decimal" />, <see cref="error" />, <see cref="i1" />, <see cref="i2" />, <see cref="i4" />, <see cref="@int" />, <see cref="r4" />, <see cref="r8" />, <see cref="ui1" />, <see cref="ui2" />, <see cref="ui4" />, <see cref="@uint" />, <see cref="variant" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.baseType" />, <see cref="NoNamespace.lBound" />, <see cref="NoNamespace.uBound" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTArray.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName array = vt + "array";

        /// <summary>
        /// Represents the vt:blob XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="AP.DigSig" />, <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTBlob.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blob = vt + "blob";

        /// <summary>
        /// Represents the vt:bool XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTBool.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @bool = vt + "bool";

        /// <summary>
        /// Represents the vt:bstr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTBString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bstr = vt + "bstr";

        /// <summary>
        /// Represents the vt:cf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.format" />, <see cref="NoNamespace.size" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTClipboardData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cf = vt + "cf";

        /// <summary>
        /// Represents the vt:clsid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTClassId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clsid = vt + "clsid";

        /// <summary>
        /// Represents the vt:cy XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTCurrency.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cy = vt + "cy";

        /// <summary>
        /// Represents the vt:date XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTDate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName date = vt + "date";

        /// <summary>
        /// Represents the vt:decimal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTDecimal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @decimal = vt + "decimal";

        /// <summary>
        /// Represents the vt:empty XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName empty = vt + "empty";

        /// <summary>
        /// Represents the vt:error XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTError.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName error = vt + "error";

        /// <summary>
        /// Represents the vt:filetime XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTFileTime.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filetime = vt + "filetime";

        /// <summary>
        /// Represents the vt:i1 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTByte.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i1 = vt + "i1";

        /// <summary>
        /// Represents the vt:i2 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTShort.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i2 = vt + "i2";

        /// <summary>
        /// Represents the vt:i4 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTInt32.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i4 = vt + "i4";

        /// <summary>
        /// Represents the vt:i8 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTInt64.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i8 = vt + "i8";

        /// <summary>
        /// Represents the vt:int XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTInteger.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @int = vt + "int";

        /// <summary>
        /// Represents the vt:lpstr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTLPSTR.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lpstr = vt + "lpstr";

        /// <summary>
        /// Represents the vt:lpwstr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTLPWSTR.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lpwstr = vt + "lpwstr";

        /// <summary>
        /// Represents the vt:null XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTNull.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @null = vt + "null";

        /// <summary>
        /// Represents the vt:oblob XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTOBlob.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oblob = vt + "oblob";

        /// <summary>
        /// Represents the vt:ostorage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTOStorage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ostorage = vt + "ostorage";

        /// <summary>
        /// Represents the vt:ostream XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTOStreamData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ostream = vt + "ostream";

        /// <summary>
        /// Represents the vt:r4 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTFloat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName r4 = vt + "r4";

        /// <summary>
        /// Represents the vt:r8 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTDouble.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName r8 = vt + "r8";

        /// <summary>
        /// Represents the vt:storage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTStorage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName storage = vt + "storage";

        /// <summary>
        /// Represents the vt:stream XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTStreamData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stream = vt + "stream";

        /// <summary>
        /// Represents the vt:ui1 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTUnsignedByte.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ui1 = vt + "ui1";

        /// <summary>
        /// Represents the vt:ui2 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTUnsignedShort.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ui2 = vt + "ui2";

        /// <summary>
        /// Represents the vt:ui4 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTUnsignedInt32.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ui4 = vt + "ui4";

        /// <summary>
        /// Represents the vt:ui8 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTUnsignedInt64.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ui8 = vt + "ui8";

        /// <summary>
        /// Represents the vt:uint XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="array" />, <see cref="variant" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTUnsignedInteger.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @uint = vt + "uint";

        /// <summary>
        /// Represents the vt:variant XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="array" />, <see cref="variant" />, <see cref="vector" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="array" />, <see cref="blob" />, <see cref="@bool" />, <see cref="bstr" />, <see cref="cf" />, <see cref="clsid" />, <see cref="cy" />, <see cref="date" />, <see cref="@decimal" />, <see cref="empty" />, <see cref="error" />, <see cref="filetime" />, <see cref="i1" />, <see cref="i2" />, <see cref="i4" />, <see cref="i8" />, <see cref="@int" />, <see cref="lpstr" />, <see cref="lpwstr" />, <see cref="@null" />, <see cref="oblob" />, <see cref="ostorage" />, <see cref="ostream" />, <see cref="r4" />, <see cref="r8" />, <see cref="storage" />, <see cref="stream" />, <see cref="ui1" />, <see cref="ui2" />, <see cref="ui4" />, <see cref="ui8" />, <see cref="@uint" />, <see cref="variant" />, <see cref="vector" />, <see cref="vstream" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Variant.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName variant = vt + "variant";

        /// <summary>
        /// Represents the vt:vector XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="AP.HeadingPairs" />, <see cref="AP.HLinks" />, <see cref="AP.TitlesOfParts" />, <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@bool" />, <see cref="bstr" />, <see cref="cf" />, <see cref="clsid" />, <see cref="cy" />, <see cref="date" />, <see cref="error" />, <see cref="filetime" />, <see cref="i1" />, <see cref="i2" />, <see cref="i4" />, <see cref="i8" />, <see cref="lpstr" />, <see cref="lpwstr" />, <see cref="r4" />, <see cref="r8" />, <see cref="ui1" />, <see cref="ui2" />, <see cref="ui4" />, <see cref="ui8" />, <see cref="variant" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.baseType" />, <see cref="NoNamespace.size" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTVector.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vector = vt + "vector";

        /// <summary>
        /// Represents the vt:vstream XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OP.property" />, <see cref="variant" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.version" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VTVStreamData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vstream = vt + "vstream";
    }
}
