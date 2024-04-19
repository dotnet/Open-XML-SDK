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
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.TableColumnExtensionList" /> <c>&lt;x:extLst></c></description></item>
    /// </list>
    /// </remark>
    public partial class TableColumn : OpenXmlCompositeElement
    {
        /// <summary>
        /// <para>Gets or sets the legacy ExtensionList property.</para>
        /// <para>Future Extensibility.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        [ObsoleteAttribute("This property is obsolete and will be removed in a future version. Use the TableColumnExtension property instead.", false)]
        public ExtensionList? ExtensionList
        {
            get => TableColumnExtensionList;
            set => TableColumnExtensionList = (TableColumnExtensionList?)value;
        }

        /// <summary>Gets or sets the table column extension list.</summary>
        /// <value>The table column extension list.</value>
        public TableColumnExtensionList? TableColumnExtensionList
        {
            get => GetElement<TableColumnExtensionList>();
            set => SetElement((TableColumnExtensionList?)value);
        }
    }

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
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.TableColumnExtension), 0, 0),
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableColumnExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableColumnExtension Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.Question" /> <c>&lt;xlmsforms:question></c></description></item>
    /// </list>
    /// </remark>
    public partial class TableColumnExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableColumnExtension class.
        /// </summary>
        public TableColumnExtension()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnExtension(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnExtension(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableColumnExtension(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x:ext");
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.Question>();
            builder.AddElement<TableColumnExtension>()
                .AddAttribute("uri", a => a.Uri, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.Question), 1, 1, version: FileFormatVersions.Microsoft365),
                new AnyParticle(0, 1),
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableColumnExtension>(deep);
    }
}
