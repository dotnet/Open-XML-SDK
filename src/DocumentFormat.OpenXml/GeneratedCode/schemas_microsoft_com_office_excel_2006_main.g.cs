// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.Excel
{
    /// <summary>
    /// <para>Defines the Macrosheet Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:macrosheet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SheetProperties &lt;x:sheetPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SheetDimension &lt;x:dimension></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SheetViews &lt;x:sheetViews></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties &lt;x:sheetFormatPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Columns &lt;x:cols></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SheetData &lt;x:sheetData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SheetProtection &lt;x:sheetProtection></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.AutoFilter &lt;x:autoFilter></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SortState &lt;x:sortState></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.DataConsolidate &lt;x:dataConsolidate></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews &lt;x:customSheetViews></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties &lt;x:phoneticPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting &lt;x:conditionalFormatting></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PrintOptions &lt;x:printOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PageMargins &lt;x:pageMargins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PageSetup &lt;x:pageSetup></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.HeaderFooter &lt;x:headerFooter></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.RowBreaks &lt;x:rowBreaks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks &lt;x:colBreaks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.CustomProperties &lt;x:customProperties></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Drawing &lt;x:drawing></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing &lt;x:legacyDrawing></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter &lt;x:legacyDrawingHF></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Picture &lt;x:picture></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.OleObjects &lt;x:oleObjects></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter &lt;x:drawingHF></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetDimension))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetViews))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Columns))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProtection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.AutoFilter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DataConsolidate))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PrintOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PageMargins))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PageSetup))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.HeaderFooter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.RowBreaks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Drawing))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.OleObjects))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
    [SchemaAttr(32, "macrosheet")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Macrosheet : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Macrosheet class.
        /// </summary>
        public Macrosheet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Macrosheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Macrosheet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Macrosheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Macrosheet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Macrosheet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Macrosheet(string outerXml) : base(outerXml)
        {
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<Macrosheet>();

        /// <summary>
        /// <para>Sheet Properties.</para>
        /// <para>Represents the following element tag in the schema: x:sheetPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetProperties SheetProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Macro Sheet Dimensions.</para>
        /// <para>Represents the following element tag in the schema: x:dimension.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetDimension SheetDimension
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetDimension>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Macro Sheet Views.</para>
        /// <para>Represents the following element tag in the schema: x:sheetViews.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetViews SheetViews
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetViews>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Sheet Format Properties.</para>
        /// <para>Represents the following element tag in the schema: x:sheetFormatPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties SheetFormatProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties>();
            set => SetElement(value);
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetDimension), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetViews), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Columns), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetData), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProtection), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.AutoFilter), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DataConsolidate), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PrintOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PageMargins), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PageSetup), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.HeaderFooter), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowBreaks), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Drawing), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Picture), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.OleObjects), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Macrosheet>(deep);

        internal Macrosheet(MacroSheetPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the MacroSheetPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(MacroSheetPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the MacroSheetPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(MacroSheetPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the MacroSheetPart associated with this element.
        /// </summary>
        public MacroSheetPart MacroSheetPart
        {
            get => OpenXmlPart as MacroSheetPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Worksheet Sort Map.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:worksheetSortMap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RowSortMap &lt;xne:rowSortMap></description></item>
    ///   <item><description>ColumnSortMap &lt;xne:colSortMap></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RowSortMap))]
    [ChildElementInfo(typeof(ColumnSortMap))]
    [SchemaAttr(32, "worksheetSortMap")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class WorksheetSortMap : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class.
        /// </summary>
        public WorksheetSortMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetSortMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetSortMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WorksheetSortMap(string outerXml) : base(outerXml)
        {
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<WorksheetSortMap>();

        /// <summary>
        /// <para>Row Sort Map.</para>
        /// <para>Represents the following element tag in the schema: xne:rowSortMap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public RowSortMap RowSortMap
        {
            get => GetElement<RowSortMap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Column Sort Map.</para>
        /// <para>Represents the following element tag in the schema: xne:colSortMap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public ColumnSortMap ColumnSortMap
        {
            get => GetElement<ColumnSortMap>();
            set => SetElement(value);
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.RowSortMap), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ColumnSortMap), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorksheetSortMap>(deep);

        internal WorksheetSortMap(WorksheetSortMapPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WorksheetSortMapPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WorksheetSortMapPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WorksheetSortMapPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WorksheetSortMapPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WorksheetSortMapPart associated with this element.
        /// </summary>
        public WorksheetSortMapPart WorksheetSortMapPart
        {
            get => OpenXmlPart as WorksheetSortMapPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ReferenceSequence Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:sqref.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(ListValue<StringValue>))]
    [SchemaAttr(32, "sqref")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ReferenceSequence : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ReferenceSequence class.
        /// </summary>
        public ReferenceSequence() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ReferenceSequence class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ReferenceSequence(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new ListValue<StringValue> { InnerText = text };
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<ReferenceSequence>();

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ReferenceSequence>(deep);
    }

    /// <summary>
    /// <para>Defines the Formula Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:f.</para>
    /// </summary>
    [SchemaAttr(32, "f")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Formula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Formula class.
        /// </summary>
        public Formula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Formula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<Formula>();

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// <para>Row Sort Map.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:rowSortMap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RowSortMapItem &lt;xne:row></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RowSortMapItem))]
    [SchemaAttr(32, "rowSortMap")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RowSortMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RowSortMap class.
        /// </summary>
        public RowSortMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RowSortMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RowSortMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowSortMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RowSortMap(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Ref { get => GetAttribute<StringValue>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        public UInt32Value Count { get => GetAttribute<UInt32Value>(); set => SetAttribute(value); }
        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<RowSortMap>();

        internal override void ConfigureMetadata(ElementMetadataBuilder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<RowSortMap>()
                           .AddAttribute(0, "ref", a => a.Ref, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           })
                           .AddAttribute(0, "count", a => a.Count, aBuilder =>
                           {
                               aBuilder.AddValidator(new NumberValidatorAttribute() { MaxInclusive = (536870910L) });
                           });
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.RowSortMapItem), 1, 536870910)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSortMap>(deep);
    }

    /// <summary>
    /// <para>Column Sort Map.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:colSortMap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColumnSortMapItem &lt;xne:col></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ColumnSortMapItem))]
    [SchemaAttr(32, "colSortMap")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ColumnSortMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class.
        /// </summary>
        public ColumnSortMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColumnSortMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColumnSortMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColumnSortMap(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Ref { get => GetAttribute<StringValue>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        public UInt32Value Count { get => GetAttribute<UInt32Value>(); set => SetAttribute(value); }
        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<ColumnSortMap>();

        internal override void ConfigureMetadata(ElementMetadataBuilder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<ColumnSortMap>()
                           .AddAttribute(0, "ref", a => a.Ref, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           })
                           .AddAttribute(0, "count", a => a.Count, aBuilder =>
                           {
                               aBuilder.AddValidator(new NumberValidatorAttribute() { MaxInclusive = (536870910L) });
                           });
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ColumnSortMapItem), 1, 536870910)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSortMap>(deep);
    }

    /// <summary>
    /// <para>Row.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:row.</para>
    /// </summary>
    [SchemaAttr(32, "row")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RowSortMapItem : SortMapItemType
    {
        /// <summary>
        /// Initializes a new instance of the RowSortMapItem class.
        /// </summary>
        public RowSortMapItem() : base()
        {
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<RowSortMapItem>();

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSortMapItem>(deep);
    }

    /// <summary>
    /// <para>Column.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:col.</para>
    /// </summary>
    [SchemaAttr(32, "col")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ColumnSortMapItem : SortMapItemType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnSortMapItem class.
        /// </summary>
        public ColumnSortMapItem() : base()
        {
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<ColumnSortMapItem>();

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSortMapItem>(deep);
    }

    /// <summary>
    /// <para>Defines the SortMapItemType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class SortMapItemType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SortMapItemType class.
        /// </summary>
        protected SortMapItemType() : base()
        {
        }

        /// <summary>
        /// <para>New Value</para>
        /// <para>Represents the following attribute in the schema: newVal</para>
        /// </summary>
        public UInt32Value NewVal { get => GetAttribute<UInt32Value>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>Old Value</para>
        /// <para>Represents the following attribute in the schema: oldVal</para>
        /// </summary>
        public UInt32Value OldVal { get => GetAttribute<UInt32Value>(); set => SetAttribute(value); }

        internal override void ConfigureMetadata(ElementMetadataBuilder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<SortMapItemType>()
                           .AddAttribute(0, "newVal", a => a.NewVal, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           })
                           .AddAttribute(0, "oldVal", a => a.OldVal, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           });
        }
    }
}