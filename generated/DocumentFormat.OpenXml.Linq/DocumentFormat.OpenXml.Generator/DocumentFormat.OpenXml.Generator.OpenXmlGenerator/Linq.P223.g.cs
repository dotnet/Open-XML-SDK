// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p223="http://schemas.microsoft.com/office/powerpoint/2022/03/main" namespace.
    /// </summary>
    public static partial class P223
    {
        /// <summary>
        /// Defines the XML namespace associated with the p223 prefix.
        /// </summary>
        public static readonly XNamespace p223 = "http://schemas.microsoft.com/office/powerpoint/2022/03/main";

        /// <summary>
        /// Represents the p223:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="instance" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = p223 + "extLst";

        /// <summary>
        /// Represents the p223:instance XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rxn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.authorId" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ReactionInstance.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName instance = p223 + "instance";

        /// <summary>
        /// Represents the p223:reactions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rxn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Reactions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reactions = p223 + "reactions";

        /// <summary>
        /// Represents the p223:rxn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="reactions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="instance" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Reaction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rxn = p223 + "rxn";
    }
}
