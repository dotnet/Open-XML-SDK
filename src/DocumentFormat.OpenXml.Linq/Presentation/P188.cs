// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    public static partial class P188
    {
        /// <summary>
        /// Represents the p188:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P223.reactions" />, <see cref="P228.taskDetails" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentPropertiesExtension.</description></item>
        /// </list>
        /// </remarks>
        [Obsolete("Unused property, prefer DocumentFormat.OpenXml.Linq.P.ext", true)]
        public static readonly XName ext = p188 + "ext";
    }
}
