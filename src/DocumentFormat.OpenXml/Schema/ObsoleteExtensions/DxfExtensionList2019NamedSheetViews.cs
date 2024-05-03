// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews
{
    /// <summary>
    /// <para>Future Extensibility.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.DxfExtension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
    public partial class DxfExtensionList : Spreadsheet.ExtensionList
    {
        /// <summary>
        /// Initializes a new instance of the DxfExtensionList class.
        /// </summary>
        public DxfExtensionList()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DxfExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DxfExtensionList(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DxfExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DxfExtensionList(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DxfExtensionList class from the specified ExtensionList object.
        /// </summary>
        /// <param name="sourceExtensionList">Specifies the source ExtensionList object</param>
        public DxfExtensionList(ExtensionList sourceExtensionList)
            : base(sourceExtensionList is null ? throw new ArgumentNullException(paramName: nameof(sourceExtensionList)) : sourceExtensionList.OuterXml)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DxfExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DxfExtensionList(string outerXml)
            : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            builder.SetSchema("xnsv:extLst");
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DxfExtension>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DxfExtension), 0, 0),
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DxfExtensionList>(deep);
    }
}
