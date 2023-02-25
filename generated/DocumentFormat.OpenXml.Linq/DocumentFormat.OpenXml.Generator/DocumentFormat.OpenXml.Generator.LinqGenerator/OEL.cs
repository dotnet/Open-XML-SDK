// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

#pragma warning disable SA1307
#pragma warning disable SA1308
#pragma warning disable SA1310
#pragma warning disable SA1311
#pragma warning disable SA1505
#pragma warning disable CA1707
#pragma warning disable CA1711
#pragma warning disable CA1720
#pragma warning disable CA1724

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:oel="http://schemas.microsoft.com/office/2019/extlst" namespace.
    /// </summary>
    public static class OEL
    {
        /// <summary>
        /// Defines the XML namespace associated with the oel prefix.
        /// </summary>
        public static readonly XNamespace oel = "http://schemas.microsoft.com/office/2019/extlst";

        /// <summary>
        /// Represents the oel:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="T.extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = oel + "ext";
    }
}
