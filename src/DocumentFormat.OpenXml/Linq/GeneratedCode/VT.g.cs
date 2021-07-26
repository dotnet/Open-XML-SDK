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
        public static readonly XName array = vt + "array";

        /// <summary>
        /// Represents the vt:blob XML element.
        /// </summary>
        public static readonly XName blob = vt + "blob";

        /// <summary>
        /// Represents the vt:bool XML element.
        /// </summary>
        public static readonly XName @bool = vt + "bool";

        /// <summary>
        /// Represents the vt:bstr XML element.
        /// </summary>
        public static readonly XName bstr = vt + "bstr";

        /// <summary>
        /// Represents the vt:cf XML element.
        /// </summary>
        public static readonly XName cf = vt + "cf";

        /// <summary>
        /// Represents the vt:clsid XML element.
        /// </summary>
        public static readonly XName clsid = vt + "clsid";

        /// <summary>
        /// Represents the vt:cy XML element.
        /// </summary>
        public static readonly XName cy = vt + "cy";

        /// <summary>
        /// Represents the vt:date XML element.
        /// </summary>
        public static readonly XName date = vt + "date";

        /// <summary>
        /// Represents the vt:decimal XML element.
        /// </summary>
        public static readonly XName @decimal = vt + "decimal";

        /// <summary>
        /// Represents the vt:empty XML element.
        /// </summary>
        public static readonly XName empty = vt + "empty";

        /// <summary>
        /// Represents the vt:error XML element.
        /// </summary>
        public static readonly XName error = vt + "error";

        /// <summary>
        /// Represents the vt:filetime XML element.
        /// </summary>
        public static readonly XName filetime = vt + "filetime";

        /// <summary>
        /// Represents the vt:i1 XML element.
        /// </summary>
        public static readonly XName i1 = vt + "i1";

        /// <summary>
        /// Represents the vt:i2 XML element.
        /// </summary>
        public static readonly XName i2 = vt + "i2";

        /// <summary>
        /// Represents the vt:i4 XML element.
        /// </summary>
        public static readonly XName i4 = vt + "i4";

        /// <summary>
        /// Represents the vt:i8 XML element.
        /// </summary>
        public static readonly XName i8 = vt + "i8";

        /// <summary>
        /// Represents the vt:int XML element.
        /// </summary>
        public static readonly XName @int = vt + "int";

        /// <summary>
        /// Represents the vt:lpstr XML element.
        /// </summary>
        public static readonly XName lpstr = vt + "lpstr";

        /// <summary>
        /// Represents the vt:lpwstr XML element.
        /// </summary>
        public static readonly XName lpwstr = vt + "lpwstr";

        /// <summary>
        /// Represents the vt:null XML element.
        /// </summary>
        public static readonly XName @null = vt + "null";

        /// <summary>
        /// Represents the vt:oblob XML element.
        /// </summary>
        public static readonly XName oblob = vt + "oblob";

        /// <summary>
        /// Represents the vt:ostorage XML element.
        /// </summary>
        public static readonly XName ostorage = vt + "ostorage";

        /// <summary>
        /// Represents the vt:ostream XML element.
        /// </summary>
        public static readonly XName ostream = vt + "ostream";

        /// <summary>
        /// Represents the vt:r4 XML element.
        /// </summary>
        public static readonly XName r4 = vt + "r4";

        /// <summary>
        /// Represents the vt:r8 XML element.
        /// </summary>
        public static readonly XName r8 = vt + "r8";

        /// <summary>
        /// Represents the vt:storage XML element.
        /// </summary>
        public static readonly XName storage = vt + "storage";

        /// <summary>
        /// Represents the vt:stream XML element.
        /// </summary>
        public static readonly XName stream = vt + "stream";

        /// <summary>
        /// Represents the vt:ui1 XML element.
        /// </summary>
        public static readonly XName ui1 = vt + "ui1";

        /// <summary>
        /// Represents the vt:ui2 XML element.
        /// </summary>
        public static readonly XName ui2 = vt + "ui2";

        /// <summary>
        /// Represents the vt:ui4 XML element.
        /// </summary>
        public static readonly XName ui4 = vt + "ui4";

        /// <summary>
        /// Represents the vt:ui8 XML element.
        /// </summary>
        public static readonly XName ui8 = vt + "ui8";

        /// <summary>
        /// Represents the vt:uint XML element.
        /// </summary>
        public static readonly XName @uint = vt + "uint";

        /// <summary>
        /// Represents the vt:variant XML element.
        /// </summary>
        public static readonly XName variant = vt + "variant";

        /// <summary>
        /// Represents the vt:vector XML element.
        /// </summary>
        public static readonly XName vector = vt + "vector";

        /// <summary>
        /// Represents the vt:vstream XML element.
        /// </summary>
        public static readonly XName vstream = vt + "vstream";
    }
}
