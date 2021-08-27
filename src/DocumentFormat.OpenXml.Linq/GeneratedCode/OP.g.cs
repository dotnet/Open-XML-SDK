// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:op="http://schemas.openxmlformats.org/officeDocument/2006/custom-properties" namespace.
    /// </summary>
    public static class OP
    {
        /// <summary>
        /// Defines the XML namespace associated with the op prefix.
        /// </summary>
        public static readonly XNamespace op = "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties";

        /// <summary>
        /// Represents the op:Properties XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="property" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Properties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Properties = op + "Properties";

        /// <summary>
        /// Represents the op:property XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="VT.array" />, <see cref="VT.blob" />, <see cref="VT.@bool" />, <see cref="VT.bstr" />, <see cref="VT.cf" />, <see cref="VT.clsid" />, <see cref="VT.cy" />, <see cref="VT.date" />, <see cref="VT.@decimal" />, <see cref="VT.empty" />, <see cref="VT.error" />, <see cref="VT.filetime" />, <see cref="VT.i1" />, <see cref="VT.i2" />, <see cref="VT.i4" />, <see cref="VT.i8" />, <see cref="VT.@int" />, <see cref="VT.lpstr" />, <see cref="VT.lpwstr" />, <see cref="VT.@null" />, <see cref="VT.oblob" />, <see cref="VT.ostorage" />, <see cref="VT.ostream" />, <see cref="VT.r4" />, <see cref="VT.r8" />, <see cref="VT.storage" />, <see cref="VT.stream" />, <see cref="VT.ui1" />, <see cref="VT.ui2" />, <see cref="VT.ui4" />, <see cref="VT.ui8" />, <see cref="VT.@uint" />, <see cref="VT.vector" />, <see cref="VT.vstream" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fmtid" />, <see cref="NoNamespace.linkTarget" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.pid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomDocumentProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName property = op + "property";
    }
}
