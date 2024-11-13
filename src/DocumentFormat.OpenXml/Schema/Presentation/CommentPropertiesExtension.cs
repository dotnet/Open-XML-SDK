// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2021.PowerPoint.Comment
{
    /// <summary>
    /// <para>Data for the Windows platform..</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.PowerPoint.Y2022.M03.Main.Reactions" /> <c>&lt;p223:reactions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.PowerPoint.Y2022.M08.Main.TaskDetails" /> <c>&lt;p228:taskDetails></c></description></item>
    /// </list>
    /// </remarks>
    [Obsolete("Unused type, prefer DocumentFormat.OpenXml.Presentation.CommentPropertiesExtension", true)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class CommentPropertiesExtension : DocumentFormat.OpenXml.Presentation.CommentPropertiesExtension
    {
        /// <summary>
        /// Initializes a new instance of the CommentPropertiesExtension class.
        /// </summary>
        public CommentPropertiesExtension()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentPropertiesExtension(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentPropertiesExtension(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentPropertiesExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentPropertiesExtension(string outerXml)
            : base(outerXml)
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentPropertiesExtension>(deep);
    }
}
