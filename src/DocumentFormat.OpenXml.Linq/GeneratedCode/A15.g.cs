// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:a15="http://schemas.microsoft.com/office/drawing/2012/main" namespace.
    /// </summary>
    public static class A15
    {
        /// <summary>
        /// Defines the XML namespace associated with the a15 prefix.
        /// </summary>
        public static readonly XNamespace a15 = "http://schemas.microsoft.com/office/drawing/2012/main";

        /// <summary>
        /// Represents the a15:backgroundPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />, <see cref="NoNamespace.bwNormal" />, <see cref="NoNamespace.bwPure" />, <see cref="NoNamespace.targetScreenSize" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName backgroundPr = a15 + "backgroundPr";

        /// <summary>
        /// Represents the a15:nonVisualGroupProps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isLegacyGroup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nonVisualGroupProps = a15 + "nonVisualGroupProps";

        /// <summary>
        /// Represents the a15:objectPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isActiveX" />, <see cref="NoNamespace.linkType" />, <see cref="NoNamespace.objectId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ObjectProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName objectPr = a15 + "objectPr";

        /// <summary>
        /// Represents the a15:signatureLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.addlXml_" />, <see cref="NoNamespace.allowComments_" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.isSignatureLine_" />, <see cref="NoNamespace.provId_" />, <see cref="NoNamespace.showSignDate_" />, <see cref="NoNamespace.signingInstructions_" />, <see cref="NoNamespace.signingInstructionsSet_" />, <see cref="NoNamespace.sigProvUrl_" />, <see cref="NoNamespace.suggestedSigner" />, <see cref="NoNamespace.suggestedSigner2" />, <see cref="NoNamespace.suggestedSignerEmail" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SignatureLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName signatureLine = a15 + "signatureLine";
    }
}
