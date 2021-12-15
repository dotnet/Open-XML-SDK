// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:aclsh="http://schemas.microsoft.com/office/drawing/2020/classificationShape" namespace.
    /// </summary>
    public static class ACLSH
    {
        /// <summary>
        /// Defines the XML namespace associated with the aclsh prefix.
        /// </summary>
        public static readonly XNamespace aclsh = "http://schemas.microsoft.com/office/drawing/2020/classificationShape";

        /// <summary>
        /// Represents the aclsh:classification XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.classificationOutcomeType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClassificationOutcome.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName classification = aclsh + "classification";
    }
}
