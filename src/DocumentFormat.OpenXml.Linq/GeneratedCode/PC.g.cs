// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pc="http://schemas.microsoft.com/office/powerpoint/2013/main/command" namespace.
    /// </summary>
    public static class PC
    {
        /// <summary>
        /// Defines the XML namespace associated with the pc prefix.
        /// </summary>
        public static readonly XNamespace pc = "http://schemas.microsoft.com/office/powerpoint/2013/main/command";

        /// <summary>
        /// Represents the pc:sldLayoutMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideLayoutMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldLayoutMkLst = pc + "sldLayoutMkLst";

        /// <summary>
        /// Represents the pc:sldMasterMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MainMasterMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMasterMkLst = pc + "sldMasterMkLst";

        /// <summary>
        /// Represents the pc:sldMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMkLst = pc + "sldMkLst";
    }
}
