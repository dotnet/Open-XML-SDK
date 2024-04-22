// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
    /// <summary>
    /// <para>Future Extensibility.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.TableColumnExtension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
    public partial class TableColumnExtensionList : ExtensionList
    {
        /// <summary>
        /// Initializes a new instance of the TableColumnExtensionList class.
        /// </summary>
        public TableColumnExtensionList()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnExtensionList(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnExtensionList(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableColumnExtensionList(string outerXml)
            : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            // base.ConfigureMetadata(builder);
            builder.SetSchema("x:extLst");
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.TableColumnExtension>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.TableColumnExtension), 0, 0),
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableColumnExtensionList>(deep);
    }
}
