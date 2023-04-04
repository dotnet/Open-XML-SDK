// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:aif="http://schemas.microsoft.com/office/drawing/2022/imageformula" namespace.
    /// </summary>
    public static class AIF
    {
        /// <summary>
        /// Defines the XML namespace associated with the aif prefix.
        /// </summary>
        public static readonly XNamespace aif = "http://schemas.microsoft.com/office/drawing/2022/imageformula";

        /// <summary>
        /// Represents the aif:imageFormula XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formula" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ImageFormula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName imageFormula = aif + "imageFormula";
    }
}
