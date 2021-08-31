// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:we="http://schemas.microsoft.com/office/webextensions/webextension/2010/11" namespace.
    /// </summary>
    public static class WE
    {
        /// <summary>
        /// Defines the XML namespace associated with the we prefix.
        /// </summary>
        public static readonly XNamespace we = "http://schemas.microsoft.com/office/webextensions/webextension/2010/11";

        /// <summary>
        /// Represents the we:alternateReferences XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webextension" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="reference" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionReferenceList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alternateReferences = we + "alternateReferences";

        /// <summary>
        /// Represents the we:binding XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bindings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.appref" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionBinding.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName binding = we + "binding";

        /// <summary>
        /// Represents the we:bindings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webextension" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="binding" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionBindingList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bindings = we + "bindings";

        /// <summary>
        /// Represents the we:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="binding" />, <see cref="reference" />, <see cref="webextension" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = we + "extLst";

        /// <summary>
        /// Represents the we:properties XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webextension" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="property" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionPropertyBag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName properties = we + "properties";

        /// <summary>
        /// Represents the we:property XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="properties" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName property = we + "property";

        /// <summary>
        /// Represents the we:reference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="alternateReferences" />, <see cref="webextension" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.store" />, <see cref="NoNamespace.storeType" />, <see cref="NoNamespace.version" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionStoreReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reference = we + "reference";

        /// <summary>
        /// Represents the we:snapshot XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webextension" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.alphaBiLevel" />, <see cref="A.alphaCeiling" />, <see cref="A.alphaFloor" />, <see cref="A.alphaInv" />, <see cref="A.alphaMod" />, <see cref="A.alphaModFix" />, <see cref="A.alphaRepl" />, <see cref="A.biLevel" />, <see cref="A.blur" />, <see cref="A.clrChange" />, <see cref="A.clrRepl" />, <see cref="A.duotone" />, <see cref="A.extLst" />, <see cref="A.fillOverlay" />, <see cref="A.grayscl" />, <see cref="A.hsl" />, <see cref="A.lum" />, <see cref="A.tint" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cstate" />, <see cref="R.embed" />, <see cref="R.link" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Snapshot.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName snapshot = we + "snapshot";

        /// <summary>
        /// Represents the we:webextension XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alternateReferences" />, <see cref="bindings" />, <see cref="extLst" />, <see cref="properties" />, <see cref="reference" />, <see cref="snapshot" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.frozen" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webextension = we + "webextension";

        /// <summary>
        /// Represents the we:webextensionref XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webextensionref = we + "webextensionref";
    }
}
