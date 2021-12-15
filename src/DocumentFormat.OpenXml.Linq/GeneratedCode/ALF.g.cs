// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:alf="http://schemas.microsoft.com/office/drawing/2021/livefeed" namespace.
    /// </summary>
    public static class ALF
    {
        /// <summary>
        /// Defines the XML namespace associated with the alf prefix.
        /// </summary>
        public static readonly XNamespace alf = "http://schemas.microsoft.com/office/drawing/2021/livefeed";

        /// <summary>
        /// Represents the alf:backgroundProps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="liveFeedProps" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Blur" />, <see cref="Custom" />, <see cref="extLst" />, <see cref="Normal" />, <see cref="Removed" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LiveFeedBackgroundProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName backgroundProps = alf + "backgroundProps";

        /// <summary>
        /// Represents the alf:Blur XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backgroundProps" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundBlurProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Blur = alf + "Blur";

        /// <summary>
        /// Represents the alf:Custom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backgroundProps" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundCustomProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Custom = alf + "Custom";

        /// <summary>
        /// Represents the alf:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backgroundProps" />, <see cref="Blur" />, <see cref="Custom" />, <see cref="liveFeedProps" />, <see cref="Normal" />, <see cref="Removed" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = alf + "extLst";

        /// <summary>
        /// Represents the alf:liveFeedProps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="backgroundProps" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LiveFeedProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName liveFeedProps = alf + "liveFeedProps";

        /// <summary>
        /// Represents the alf:Normal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backgroundProps" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundNormalProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Normal = alf + "Normal";

        /// <summary>
        /// Represents the alf:Removed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backgroundProps" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundRemovedProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Removed = alf + "Removed";
    }
}
