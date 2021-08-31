// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:ac="http://schemas.openxmlformats.org/officeDocument/2006/characteristics" namespace.
    /// </summary>
    public static class AC
    {
        /// <summary>
        /// Defines the XML namespace associated with the ac prefix.
        /// </summary>
        public static readonly XNamespace ac = "http://schemas.openxmlformats.org/officeDocument/2006/characteristics";

        /// <summary>
        /// Represents the ac:additionalCharacteristics XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="characteristic" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AdditionalCharacteristicsInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName additionalCharacteristics = ac + "additionalCharacteristics";

        /// <summary>
        /// Represents the ac:characteristic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="additionalCharacteristics" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.relation" />, <see cref="NoNamespace.val" />, <see cref="NoNamespace.vocabulary" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Characteristic.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName characteristic = ac + "characteristic";
    }
}
