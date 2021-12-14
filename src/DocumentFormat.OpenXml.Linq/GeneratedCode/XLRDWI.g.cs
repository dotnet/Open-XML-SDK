// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xlrdwi="http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage" namespace.
    /// </summary>
    public static class XLRDWI
    {
        /// <summary>
        /// Defines the XML namespace associated with the xlrdwi prefix.
        /// </summary>
        public static readonly XNamespace xlrdwi = "http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage";

        /// <summary>
        /// Represents the xlrdwi:address XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webImageSrd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AddressWebImageSupportingRichDataRelationship.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName address = xlrdwi + "address";

        /// <summary>
        /// Represents the xlrdwi:blip XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webImageSrd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BlipWebImageSupportingRichDataRelationship.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blip = xlrdwi + "blip";

        /// <summary>
        /// Represents the xlrdwi:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webImagesSrd" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xlrdwi + "extLst";

        /// <summary>
        /// Represents the xlrdwi:moreImagesAddress XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webImageSrd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoreImagesAddressWebImageSupportingRichDataRelationship.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName moreImagesAddress = xlrdwi + "moreImagesAddress";

        /// <summary>
        /// Represents the xlrdwi:webImageSrd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webImagesSrd" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="address" />, <see cref="blip" />, <see cref="moreImagesAddress" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebImageSupportingRichData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webImageSrd = xlrdwi + "webImageSrd";

        /// <summary>
        /// Represents the xlrdwi:webImagesSrd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="webImageSrd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebImagesSupportingRichData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webImagesSrd = xlrdwi + "webImagesSrd";
    }
}
