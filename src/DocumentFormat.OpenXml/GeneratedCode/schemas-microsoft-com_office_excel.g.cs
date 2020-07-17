// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Vml.Spreadsheet
{
    /// <summary>
    /// <para>Attached Object Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ClientData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MoveWithCells &lt;xvml:MoveWithCells></description></item>
    ///   <item><description>ResizeWithCells &lt;xvml:SizeWithCells></description></item>
    ///   <item><description>Anchor &lt;xvml:Anchor></description></item>
    ///   <item><description>Locked &lt;xvml:Locked></description></item>
    ///   <item><description>DefaultSize &lt;xvml:DefaultSize></description></item>
    ///   <item><description>PrintObject &lt;xvml:PrintObject></description></item>
    ///   <item><description>Disabled &lt;xvml:Disabled></description></item>
    ///   <item><description>AutoFill &lt;xvml:AutoFill></description></item>
    ///   <item><description>AutoLine &lt;xvml:AutoLine></description></item>
    ///   <item><description>AutoSizePicture &lt;xvml:AutoPict></description></item>
    ///   <item><description>FormulaMacro &lt;xvml:FmlaMacro></description></item>
    ///   <item><description>HorizontalTextAlignment &lt;xvml:TextHAlign></description></item>
    ///   <item><description>VerticalTextAlignment &lt;xvml:TextVAlign></description></item>
    ///   <item><description>LockText &lt;xvml:LockText></description></item>
    ///   <item><description>JustifyLastLine &lt;xvml:JustLastX></description></item>
    ///   <item><description>SecretEdit &lt;xvml:SecretEdit></description></item>
    ///   <item><description>DefaultButton &lt;xvml:Default></description></item>
    ///   <item><description>HelpButton &lt;xvml:Help></description></item>
    ///   <item><description>CancelButton &lt;xvml:Cancel></description></item>
    ///   <item><description>DismissButton &lt;xvml:Dismiss></description></item>
    ///   <item><description>AcceleratorPrimary &lt;xvml:Accel></description></item>
    ///   <item><description>AcceleratorSecondary &lt;xvml:Accel2></description></item>
    ///   <item><description>CommentRowTarget &lt;xvml:Row></description></item>
    ///   <item><description>CommentColumnTarget &lt;xvml:Column></description></item>
    ///   <item><description>Visible &lt;xvml:Visible></description></item>
    ///   <item><description>RowHidden &lt;xvml:RowHidden></description></item>
    ///   <item><description>ColumnHidden &lt;xvml:ColHidden></description></item>
    ///   <item><description>InputValidationType &lt;xvml:VTEdit></description></item>
    ///   <item><description>MultiLine &lt;xvml:MultiLine></description></item>
    ///   <item><description>VerticalScrollBar &lt;xvml:VScroll></description></item>
    ///   <item><description>ValidIds &lt;xvml:ValidIds></description></item>
    ///   <item><description>FormulaRange &lt;xvml:FmlaRange></description></item>
    ///   <item><description>MinDropDownWidth &lt;xvml:WidthMin></description></item>
    ///   <item><description>SelectionEntry &lt;xvml:Sel></description></item>
    ///   <item><description>Disable3DForListBoxAndDropDown &lt;xvml:NoThreeD2></description></item>
    ///   <item><description>SelectionType &lt;xvml:SelType></description></item>
    ///   <item><description>MultiSelections &lt;xvml:MultiSel></description></item>
    ///   <item><description>ListBoxCallbackType &lt;xvml:LCT></description></item>
    ///   <item><description>ListItem &lt;xvml:ListItem></description></item>
    ///   <item><description>DropStyle &lt;xvml:DropStyle></description></item>
    ///   <item><description>Colored &lt;xvml:Colored></description></item>
    ///   <item><description>DropLines &lt;xvml:DropLines></description></item>
    ///   <item><description>Checked &lt;xvml:Checked></description></item>
    ///   <item><description>FormulaLink &lt;xvml:FmlaLink></description></item>
    ///   <item><description>FormulaPicture &lt;xvml:FmlaPict></description></item>
    ///   <item><description>Disable3D &lt;xvml:NoThreeD></description></item>
    ///   <item><description>FirstButton &lt;xvml:FirstButton></description></item>
    ///   <item><description>FormulaGroup &lt;xvml:FmlaGroup></description></item>
    ///   <item><description>ScrollBarPosition &lt;xvml:Val></description></item>
    ///   <item><description>ScrollBarMin &lt;xvml:Min></description></item>
    ///   <item><description>ScrollBarMax &lt;xvml:Max></description></item>
    ///   <item><description>ScrollBarIncrement &lt;xvml:Inc></description></item>
    ///   <item><description>ScrollBarPageIncrement &lt;xvml:Page></description></item>
    ///   <item><description>HorizontalScrollBar &lt;xvml:Horiz></description></item>
    ///   <item><description>ScrollBarWidth &lt;xvml:Dx></description></item>
    ///   <item><description>MapOcxControl &lt;xvml:MapOCX></description></item>
    ///   <item><description>ClipboardFormat &lt;xvml:CF></description></item>
    ///   <item><description>CameraObject &lt;xvml:Camera></description></item>
    ///   <item><description>RecalculateAlways &lt;xvml:RecalcAlways></description></item>
    ///   <item><description>AutoScaleFont &lt;xvml:AutoScale></description></item>
    ///   <item><description>DdeObject &lt;xvml:DDE></description></item>
    ///   <item><description>UIObject &lt;xvml:UIObj></description></item>
    ///   <item><description>ScriptText &lt;xvml:ScriptText></description></item>
    ///   <item><description>ScriptExtended &lt;xvml:ScriptExtended></description></item>
    ///   <item><description>ScriptLanguage &lt;xvml:ScriptLanguage></description></item>
    ///   <item><description>ScriptLocation &lt;xvml:ScriptLocation></description></item>
    ///   <item><description>FormulaTextBox &lt;xvml:FmlaTxbx></description></item>
    /// </list>
    /// </remark>
    public partial class ClientData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ClientData class.
        /// </summary>
        public ClientData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClientData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClientData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClientData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClientData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClientData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ClientData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Object type</para>
        /// <para>Represents the following attribute in the schema: ObjectType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ObjectValues> ObjectType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ObjectValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "ClientData");
            builder.AddChild<MoveWithCells>();
            builder.AddChild<ResizeWithCells>();
            builder.AddChild<Anchor>();
            builder.AddChild<Locked>();
            builder.AddChild<DefaultSize>();
            builder.AddChild<PrintObject>();
            builder.AddChild<Disabled>();
            builder.AddChild<AutoFill>();
            builder.AddChild<AutoLine>();
            builder.AddChild<AutoSizePicture>();
            builder.AddChild<FormulaMacro>();
            builder.AddChild<HorizontalTextAlignment>();
            builder.AddChild<VerticalTextAlignment>();
            builder.AddChild<LockText>();
            builder.AddChild<JustifyLastLine>();
            builder.AddChild<SecretEdit>();
            builder.AddChild<DefaultButton>();
            builder.AddChild<HelpButton>();
            builder.AddChild<CancelButton>();
            builder.AddChild<DismissButton>();
            builder.AddChild<AcceleratorPrimary>();
            builder.AddChild<AcceleratorSecondary>();
            builder.AddChild<CommentRowTarget>();
            builder.AddChild<CommentColumnTarget>();
            builder.AddChild<Visible>();
            builder.AddChild<RowHidden>();
            builder.AddChild<ColumnHidden>();
            builder.AddChild<InputValidationType>();
            builder.AddChild<MultiLine>();
            builder.AddChild<VerticalScrollBar>();
            builder.AddChild<ValidIds>();
            builder.AddChild<FormulaRange>();
            builder.AddChild<MinDropDownWidth>();
            builder.AddChild<SelectionEntry>();
            builder.AddChild<Disable3DForListBoxAndDropDown>();
            builder.AddChild<SelectionType>();
            builder.AddChild<MultiSelections>();
            builder.AddChild<ListBoxCallbackType>();
            builder.AddChild<ListItem>();
            builder.AddChild<DropStyle>();
            builder.AddChild<Colored>();
            builder.AddChild<DropLines>();
            builder.AddChild<Checked>();
            builder.AddChild<FormulaLink>();
            builder.AddChild<FormulaPicture>();
            builder.AddChild<Disable3D>();
            builder.AddChild<FirstButton>();
            builder.AddChild<FormulaGroup>();
            builder.AddChild<ScrollBarPosition>();
            builder.AddChild<ScrollBarMin>();
            builder.AddChild<ScrollBarMax>();
            builder.AddChild<ScrollBarIncrement>();
            builder.AddChild<ScrollBarPageIncrement>();
            builder.AddChild<HorizontalScrollBar>();
            builder.AddChild<ScrollBarWidth>();
            builder.AddChild<MapOcxControl>();
            builder.AddChild<ClipboardFormat>();
            builder.AddChild<CameraObject>();
            builder.AddChild<RecalculateAlways>();
            builder.AddChild<AutoScaleFont>();
            builder.AddChild<DdeObject>();
            builder.AddChild<UIObject>();
            builder.AddChild<ScriptText>();
            builder.AddChild<ScriptExtended>();
            builder.AddChild<ScriptLanguage>();
            builder.AddChild<ScriptLocation>();
            builder.AddChild<FormulaTextBox>();
            builder.AddElement<ClientData>()
.AddAttribute(0, "ObjectType", a => a.ObjectType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.MoveWithCells), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ResizeWithCells), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Anchor), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Locked), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.DefaultSize), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.PrintObject), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Disabled), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.AutoFill), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.AutoLine), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.AutoSizePicture), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaMacro), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.HorizontalTextAlignment), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.VerticalTextAlignment), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.LockText), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.JustifyLastLine), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.SecretEdit), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.DefaultButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.HelpButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.CancelButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.DismissButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.AcceleratorPrimary), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.AcceleratorSecondary), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.CommentRowTarget), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.CommentColumnTarget), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Visible), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.RowHidden), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ColumnHidden), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.InputValidationType), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.MultiLine), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.VerticalScrollBar), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ValidIds), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaRange), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.MinDropDownWidth), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.SelectionEntry), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Disable3DForListBoxAndDropDown), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.SelectionType), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.MultiSelections), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ListBoxCallbackType), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ListItem), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.DropStyle), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Colored), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.DropLines), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Checked), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaLink), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaPicture), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.Disable3D), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.FirstButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaGroup), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarPosition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarMin), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarMax), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarIncrement), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarPageIncrement), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.HorizontalScrollBar), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarWidth), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.MapOcxControl), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClipboardFormat), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.CameraObject), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.RecalculateAlways), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.AutoScaleFont), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.DdeObject), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.UIObject), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptText), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptExtended), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptLanguage), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptLocation), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaTextBox), 1, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:ObjectType*/, false, new string[] { "Movie" }) { Application = ApplicationType.Excel });
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:ObjectType*/, false, new string[] { "LineA", "RectA" }) { Application = ApplicationType.Excel });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClientData>(deep);
    }

    /// <summary>
    /// <para>Move with Cells.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MoveWithCells.</para>
    /// </summary>
    public partial class MoveWithCells : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MoveWithCells class.
        /// </summary>
        public MoveWithCells() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MoveWithCells class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MoveWithCells(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "MoveWithCells");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MoveWithCells>(deep);
    }

    /// <summary>
    /// <para>Resize with Cells.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:SizeWithCells.</para>
    /// </summary>
    public partial class ResizeWithCells : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ResizeWithCells class.
        /// </summary>
        public ResizeWithCells() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResizeWithCells class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ResizeWithCells(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "SizeWithCells");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResizeWithCells>(deep);
    }

    /// <summary>
    /// <para>Lock Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Locked.</para>
    /// </summary>
    public partial class Locked : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Locked class.
        /// </summary>
        public Locked() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Locked class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Locked(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Locked");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Locked>(deep);
    }

    /// <summary>
    /// <para>Default Size Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DefaultSize.</para>
    /// </summary>
    public partial class DefaultSize : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DefaultSize class.
        /// </summary>
        public DefaultSize() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefaultSize class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DefaultSize(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "DefaultSize");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultSize>(deep);
    }

    /// <summary>
    /// <para>Print Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:PrintObject.</para>
    /// </summary>
    public partial class PrintObject : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PrintObject class.
        /// </summary>
        public PrintObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintObject class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PrintObject(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "PrintObject");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintObject>(deep);
    }

    /// <summary>
    /// <para>Macro Disable Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Disabled.</para>
    /// </summary>
    public partial class Disabled : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Disabled class.
        /// </summary>
        public Disabled() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Disabled class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Disabled(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Disabled");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Disabled>(deep);
    }

    /// <summary>
    /// <para>AutoFill.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoFill.</para>
    /// </summary>
    public partial class AutoFill : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AutoFill class.
        /// </summary>
        public AutoFill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoFill class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AutoFill(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "AutoFill");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoFill>(deep);
    }

    /// <summary>
    /// <para>AutoLine.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoLine.</para>
    /// </summary>
    public partial class AutoLine : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AutoLine class.
        /// </summary>
        public AutoLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoLine class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AutoLine(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "AutoLine");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoLine>(deep);
    }

    /// <summary>
    /// <para>Automatically Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoPict.</para>
    /// </summary>
    public partial class AutoSizePicture : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AutoSizePicture class.
        /// </summary>
        public AutoSizePicture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoSizePicture class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AutoSizePicture(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "AutoPict");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoSizePicture>(deep);
    }

    /// <summary>
    /// <para>Text Lock.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:LockText.</para>
    /// </summary>
    public partial class LockText : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LockText class.
        /// </summary>
        public LockText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LockText class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LockText(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "LockText");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LockText>(deep);
    }

    /// <summary>
    /// <para>East Asia Alignment Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:JustLastX.</para>
    /// </summary>
    public partial class JustifyLastLine : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the JustifyLastLine class.
        /// </summary>
        public JustifyLastLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the JustifyLastLine class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public JustifyLastLine(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "JustLastX");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<JustifyLastLine>(deep);
    }

    /// <summary>
    /// <para>Password Edit.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:SecretEdit.</para>
    /// </summary>
    public partial class SecretEdit : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SecretEdit class.
        /// </summary>
        public SecretEdit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SecretEdit class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SecretEdit(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "SecretEdit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SecretEdit>(deep);
    }

    /// <summary>
    /// <para>Default Button.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Default.</para>
    /// </summary>
    public partial class DefaultButton : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DefaultButton class.
        /// </summary>
        public DefaultButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefaultButton class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DefaultButton(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Default");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultButton>(deep);
    }

    /// <summary>
    /// <para>Help Button.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Help.</para>
    /// </summary>
    public partial class HelpButton : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HelpButton class.
        /// </summary>
        public HelpButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HelpButton class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HelpButton(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Help");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HelpButton>(deep);
    }

    /// <summary>
    /// <para>Cancel Button.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Cancel.</para>
    /// </summary>
    public partial class CancelButton : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CancelButton class.
        /// </summary>
        public CancelButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CancelButton class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CancelButton(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Cancel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CancelButton>(deep);
    }

    /// <summary>
    /// <para>Dismiss Button.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Dismiss.</para>
    /// </summary>
    public partial class DismissButton : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DismissButton class.
        /// </summary>
        public DismissButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DismissButton class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DismissButton(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Dismiss");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DismissButton>(deep);
    }

    /// <summary>
    /// <para>Comment Visibility Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Visible.</para>
    /// </summary>
    public partial class Visible : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Visible class.
        /// </summary>
        public Visible() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Visible class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Visible(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Visible");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Visible>(deep);
    }

    /// <summary>
    /// <para>Comment's Row is Hidden.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:RowHidden.</para>
    /// </summary>
    public partial class RowHidden : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RowHidden class.
        /// </summary>
        public RowHidden() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowHidden class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RowHidden(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "RowHidden");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowHidden>(deep);
    }

    /// <summary>
    /// <para>Comment's Column is Hidden.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ColHidden.</para>
    /// </summary>
    public partial class ColumnHidden : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnHidden class.
        /// </summary>
        public ColumnHidden() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnHidden class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ColumnHidden(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "ColHidden");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnHidden>(deep);
    }

    /// <summary>
    /// <para>Multi-line.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MultiLine.</para>
    /// </summary>
    public partial class MultiLine : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiLine class.
        /// </summary>
        public MultiLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLine class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MultiLine(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "MultiLine");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLine>(deep);
    }

    /// <summary>
    /// <para>Vertical Scroll.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:VScroll.</para>
    /// </summary>
    public partial class VerticalScrollBar : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VerticalScrollBar class.
        /// </summary>
        public VerticalScrollBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VerticalScrollBar class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VerticalScrollBar(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "VScroll");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalScrollBar>(deep);
    }

    /// <summary>
    /// <para>Valid ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ValidIds.</para>
    /// </summary>
    public partial class ValidIds : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ValidIds class.
        /// </summary>
        public ValidIds() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValidIds class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ValidIds(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "ValidIds");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValidIds>(deep);
    }

    /// <summary>
    /// <para>Disable 3D.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:NoThreeD2.</para>
    /// </summary>
    public partial class Disable3DForListBoxAndDropDown : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Disable3DForListBoxAndDropDown class.
        /// </summary>
        public Disable3DForListBoxAndDropDown() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Disable3DForListBoxAndDropDown class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Disable3DForListBoxAndDropDown(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "NoThreeD2");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Disable3DForListBoxAndDropDown>(deep);
    }

    /// <summary>
    /// <para>Dropdown Color Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Colored.</para>
    /// </summary>
    public partial class Colored : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Colored class.
        /// </summary>
        public Colored() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Colored class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Colored(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Colored");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Colored>(deep);
    }

    /// <summary>
    /// <para>Disable 3D.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:NoThreeD.</para>
    /// </summary>
    public partial class Disable3D : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Disable3D class.
        /// </summary>
        public Disable3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Disable3D class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Disable3D(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "NoThreeD");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Disable3D>(deep);
    }

    /// <summary>
    /// <para>First Radio Button.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FirstButton.</para>
    /// </summary>
    public partial class FirstButton : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FirstButton class.
        /// </summary>
        public FirstButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FirstButton class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FirstButton(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "FirstButton");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstButton>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Orientation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Horiz.</para>
    /// </summary>
    public partial class HorizontalScrollBar : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HorizontalScrollBar class.
        /// </summary>
        public HorizontalScrollBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HorizontalScrollBar class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HorizontalScrollBar(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Horiz");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalScrollBar>(deep);
    }

    /// <summary>
    /// <para>ActiveX Control.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MapOCX.</para>
    /// </summary>
    public partial class MapOcxControl : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MapOcxControl class.
        /// </summary>
        public MapOcxControl() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MapOcxControl class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MapOcxControl(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "MapOCX");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MapOcxControl>(deep);
    }

    /// <summary>
    /// <para>Camera Tool.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Camera.</para>
    /// </summary>
    public partial class CameraObject : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CameraObject class.
        /// </summary>
        public CameraObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CameraObject class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CameraObject(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "Camera");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CameraObject>(deep);
    }

    /// <summary>
    /// <para>Recalculation Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:RecalcAlways.</para>
    /// </summary>
    public partial class RecalculateAlways : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RecalculateAlways class.
        /// </summary>
        public RecalculateAlways() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RecalculateAlways class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RecalculateAlways(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "RecalcAlways");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecalculateAlways>(deep);
    }

    /// <summary>
    /// <para>Font AutoScale.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoScale.</para>
    /// </summary>
    public partial class AutoScaleFont : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaleFont class.
        /// </summary>
        public AutoScaleFont() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoScaleFont class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AutoScaleFont(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "AutoScale");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoScaleFont>(deep);
    }

    /// <summary>
    /// <para>Dynamic Data Exchange.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DDE.</para>
    /// </summary>
    public partial class DdeObject : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DdeObject class.
        /// </summary>
        public DdeObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DdeObject class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DdeObject(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "DDE");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DdeObject>(deep);
    }

    /// <summary>
    /// <para>UI Object Toggle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:UIObj.</para>
    /// </summary>
    public partial class UIObject : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the UIObject class.
        /// </summary>
        public UIObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UIObject class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public UIObject(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "UIObj");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UIObject>(deep);
    }

    /// <summary>
    /// <para>Anchor.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Anchor.</para>
    /// </summary>
    public partial class Anchor : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Anchor class.
        /// </summary>
        public Anchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Anchor class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Anchor(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "Anchor");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Anchor>(deep);
    }

    /// <summary>
    /// <para>Horizontal Text Alignment.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:TextHAlign.</para>
    /// </summary>
    public partial class HorizontalTextAlignment : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HorizontalTextAlignment class.
        /// </summary>
        public HorizontalTextAlignment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HorizontalTextAlignment class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HorizontalTextAlignment(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "TextHAlign");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalTextAlignment>(deep);
    }

    /// <summary>
    /// <para>Vertical Text Alignment.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:TextVAlign.</para>
    /// </summary>
    public partial class VerticalTextAlignment : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VerticalTextAlignment class.
        /// </summary>
        public VerticalTextAlignment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VerticalTextAlignment class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VerticalTextAlignment(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "TextVAlign");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalTextAlignment>(deep);
    }

    /// <summary>
    /// <para>List Items Source Range.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaRange.</para>
    /// </summary>
    public partial class FormulaRange : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaRange class.
        /// </summary>
        public FormulaRange() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaRange class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaRange(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "FmlaRange");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaRange>(deep);
    }

    /// <summary>
    /// <para>Selection Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:SelType.</para>
    /// </summary>
    public partial class SelectionType : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SelectionType class.
        /// </summary>
        public SelectionType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SelectionType class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SelectionType(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "SelType");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SelectionType>(deep);
    }

    /// <summary>
    /// <para>Multiple Selections.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MultiSel.</para>
    /// </summary>
    public partial class MultiSelections : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiSelections class.
        /// </summary>
        public MultiSelections() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiSelections class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MultiSelections(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "MultiSel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiSelections>(deep);
    }

    /// <summary>
    /// <para>Callback Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:LCT.</para>
    /// </summary>
    public partial class ListBoxCallbackType : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ListBoxCallbackType class.
        /// </summary>
        public ListBoxCallbackType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ListBoxCallbackType class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ListBoxCallbackType(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "LCT");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListBoxCallbackType>(deep);
    }

    /// <summary>
    /// <para>Non-linked List Item.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ListItem.</para>
    /// </summary>
    public partial class ListItem : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ListItem class.
        /// </summary>
        public ListItem() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ListItem class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ListItem(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "ListItem");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListItem>(deep);
    }

    /// <summary>
    /// <para>Dropdown Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DropStyle.</para>
    /// </summary>
    public partial class DropStyle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DropStyle class.
        /// </summary>
        public DropStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropStyle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DropStyle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "DropStyle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropStyle>(deep);
    }

    /// <summary>
    /// <para>Linked Formula.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaLink.</para>
    /// </summary>
    public partial class FormulaLink : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaLink class.
        /// </summary>
        public FormulaLink() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaLink class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaLink(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "FmlaLink");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaLink>(deep);
    }

    /// <summary>
    /// <para>Camera Source Range.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaPict.</para>
    /// </summary>
    public partial class FormulaPicture : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaPicture class.
        /// </summary>
        public FormulaPicture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaPicture class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaPicture(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "FmlaPict");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaPicture>(deep);
    }

    /// <summary>
    /// <para>Linked Formula - Group Box.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaGroup.</para>
    /// </summary>
    public partial class FormulaGroup : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaGroup class.
        /// </summary>
        public FormulaGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaGroup class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaGroup(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "FmlaGroup");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaGroup>(deep);
    }

    /// <summary>
    /// <para>HTML Script Text.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptText.</para>
    /// </summary>
    public partial class ScriptText : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScriptText class.
        /// </summary>
        public ScriptText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScriptText class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScriptText(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "ScriptText");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptText>(deep);
    }

    /// <summary>
    /// <para>HTML Script Attributes.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptExtended.</para>
    /// </summary>
    public partial class ScriptExtended : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScriptExtended class.
        /// </summary>
        public ScriptExtended() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScriptExtended class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScriptExtended(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "ScriptExtended");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptExtended>(deep);
    }

    /// <summary>
    /// <para>Text Formula.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaTxbx.</para>
    /// </summary>
    public partial class FormulaTextBox : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaTextBox class.
        /// </summary>
        public FormulaTextBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaTextBox class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaTextBox(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(29, "FmlaTxbx");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaTextBox>(deep);
    }

    /// <summary>
    /// <para>Reference to Custom Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaMacro.</para>
    /// </summary>
    public partial class FormulaMacro : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaMacro class.
        /// </summary>
        public FormulaMacro() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaMacro class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaMacro(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (256L) });
            builder.SetSchema(29, "FmlaMacro");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaMacro>(deep);
    }

    /// <summary>
    /// <para>Primary Keyboard Accelerator.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Accel.</para>
    /// </summary>
    public partial class AcceleratorPrimary : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AcceleratorPrimary class.
        /// </summary>
        public AcceleratorPrimary() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AcceleratorPrimary class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AcceleratorPrimary(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new ByteValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<ByteValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Accel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AcceleratorPrimary>(deep);
    }

    /// <summary>
    /// <para>Secondary Keyboard Accelerator.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Accel2.</para>
    /// </summary>
    public partial class AcceleratorSecondary : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AcceleratorSecondary class.
        /// </summary>
        public AcceleratorSecondary() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AcceleratorSecondary class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AcceleratorSecondary(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new ByteValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<ByteValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Accel2");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AcceleratorSecondary>(deep);
    }

    /// <summary>
    /// <para>Comment Row Target.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Row.</para>
    /// </summary>
    public partial class CommentRowTarget : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentRowTarget class.
        /// </summary>
        public CommentRowTarget() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentRowTarget class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CommentRowTarget(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Row");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentRowTarget>(deep);
    }

    /// <summary>
    /// <para>Comment Column Target.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Column.</para>
    /// </summary>
    public partial class CommentColumnTarget : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentColumnTarget class.
        /// </summary>
        public CommentColumnTarget() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentColumnTarget class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CommentColumnTarget(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Column");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentColumnTarget>(deep);
    }

    /// <summary>
    /// <para>Validation Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:VTEdit.</para>
    /// </summary>
    public partial class InputValidationType : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the InputValidationType class.
        /// </summary>
        public InputValidationType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InputValidationType class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public InputValidationType(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "VTEdit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InputValidationType>(deep);
    }

    /// <summary>
    /// <para>Minimum Width.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:WidthMin.</para>
    /// </summary>
    public partial class MinDropDownWidth : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MinDropDownWidth class.
        /// </summary>
        public MinDropDownWidth() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinDropDownWidth class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MinDropDownWidth(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "WidthMin");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinDropDownWidth>(deep);
    }

    /// <summary>
    /// <para>Selected Entry.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Sel.</para>
    /// </summary>
    public partial class SelectionEntry : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SelectionEntry class.
        /// </summary>
        public SelectionEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SelectionEntry class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SelectionEntry(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Sel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SelectionEntry>(deep);
    }

    /// <summary>
    /// <para>Dropdown Maximum Lines.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DropLines.</para>
    /// </summary>
    public partial class DropLines : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DropLines class.
        /// </summary>
        public DropLines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLines class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DropLines(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "DropLines");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropLines>(deep);
    }

    /// <summary>
    /// <para>Checked.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Checked.</para>
    /// </summary>
    public partial class Checked : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Checked class.
        /// </summary>
        public Checked() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Checked class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Checked(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Checked");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Checked>(deep);
    }

    /// <summary>
    /// <para>Scroll bar position.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Val.</para>
    /// </summary>
    public partial class ScrollBarPosition : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScrollBarPosition class.
        /// </summary>
        public ScrollBarPosition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScrollBarPosition class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScrollBarPosition(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Val");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarPosition>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Minimum.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Min.</para>
    /// </summary>
    public partial class ScrollBarMin : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScrollBarMin class.
        /// </summary>
        public ScrollBarMin() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScrollBarMin class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScrollBarMin(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Min");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarMin>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Maximum.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Max.</para>
    /// </summary>
    public partial class ScrollBarMax : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScrollBarMax class.
        /// </summary>
        public ScrollBarMax() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScrollBarMax class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScrollBarMax(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Max");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarMax>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Increment.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Inc.</para>
    /// </summary>
    public partial class ScrollBarIncrement : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScrollBarIncrement class.
        /// </summary>
        public ScrollBarIncrement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScrollBarIncrement class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScrollBarIncrement(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Inc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarIncrement>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Page Increment.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Page.</para>
    /// </summary>
    public partial class ScrollBarPageIncrement : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScrollBarPageIncrement class.
        /// </summary>
        public ScrollBarPageIncrement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScrollBarPageIncrement class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScrollBarPageIncrement(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Page");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarPageIncrement>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Width.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Dx.</para>
    /// </summary>
    public partial class ScrollBarWidth : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScrollBarWidth class.
        /// </summary>
        public ScrollBarWidth() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScrollBarWidth class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScrollBarWidth(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(NumberValidator.Instance);
            builder.SetSchema(29, "Dx");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarWidth>(deep);
    }

    /// <summary>
    /// <para>Clipboard Format.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:CF.</para>
    /// </summary>
    public partial class ClipboardFormat : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ClipboardFormat class.
        /// </summary>
        public ClipboardFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClipboardFormat class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ClipboardFormat(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ClipboardFormatValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ClipboardFormatValues>>(EnumValidator.Instance);
            builder.SetSchema(29, "CF");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClipboardFormat>(deep);
    }

    /// <summary>
    /// <para>HTML Script Language.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptLanguage.</para>
    /// </summary>
    public partial class ScriptLanguage : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScriptLanguage class.
        /// </summary>
        public ScriptLanguage() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScriptLanguage class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScriptLanguage(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(new NumberValidator() { IsNonNegative = (true) });
            builder.SetSchema(29, "ScriptLanguage");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptLanguage>(deep);
    }

    /// <summary>
    /// <para>HTML Script Location.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptLocation.</para>
    /// </summary>
    public partial class ScriptLocation : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScriptLocation class.
        /// </summary>
        public ScriptLocation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScriptLocation class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScriptLocation(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new IntegerValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<IntegerValue>(new NumberValidator() { IsNonNegative = (true) });
            builder.SetSchema(29, "ScriptLocation");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptLocation>(deep);
    }

    /// <summary>
    /// Clipboard Format Type
    /// </summary>
    public enum ClipboardFormatValues
    {
        ///<summary>
        ///WMF.
        ///<para>When the item is serialized out as xml, its value is "PictOld".</para>
        ///</summary>
        [EnumString("PictOld")]
        PictureOld,
        ///<summary>
        ///EMF.
        ///<para>When the item is serialized out as xml, its value is "Pict".</para>
        ///</summary>
        [EnumString("Pict")]
        Picture,
        ///<summary>
        ///Bitmap.
        ///<para>When the item is serialized out as xml, its value is "Bitmap".</para>
        ///</summary>
        [EnumString("Bitmap")]
        Bitmap,
        ///<summary>
        ///Printer Picture.
        ///<para>When the item is serialized out as xml, its value is "PictPrint".</para>
        ///</summary>
        [EnumString("PictPrint")]
        PicturePrint,
        ///<summary>
        ///Screen Picture EMF.
        ///<para>When the item is serialized out as xml, its value is "PictScreen".</para>
        ///</summary>
        [EnumString("PictScreen")]
        PictureScreen,
    }

    /// <summary>
    /// Object Type
    /// </summary>
    public enum ObjectValues
    {
        ///<summary>
        ///Pushbutton.
        ///<para>When the item is serialized out as xml, its value is "Button".</para>
        ///</summary>
        [EnumString("Button")]
        Button,
        ///<summary>
        ///Checkbox.
        ///<para>When the item is serialized out as xml, its value is "Checkbox".</para>
        ///</summary>
        [EnumString("Checkbox")]
        Checkbox,
        ///<summary>
        ///Dialog.
        ///<para>When the item is serialized out as xml, its value is "Dialog".</para>
        ///</summary>
        [EnumString("Dialog")]
        Dialog,
        ///<summary>
        ///Dropdown Box.
        ///<para>When the item is serialized out as xml, its value is "Drop".</para>
        ///</summary>
        [EnumString("Drop")]
        Drop,
        ///<summary>
        ///Editable Text Field.
        ///<para>When the item is serialized out as xml, its value is "Edit".</para>
        ///</summary>
        [EnumString("Edit")]
        Edit,
        ///<summary>
        ///Group Box.
        ///<para>When the item is serialized out as xml, its value is "GBox".</para>
        ///</summary>
        [EnumString("GBox")]
        GroupBox,
        ///<summary>
        ///Label.
        ///<para>When the item is serialized out as xml, its value is "Label".</para>
        ///</summary>
        [EnumString("Label")]
        Label,
        ///<summary>
        ///Auditing Line.
        ///<para>When the item is serialized out as xml, its value is "LineA".</para>
        ///</summary>
        [EnumString("LineA")]
        AuditingLine,
        ///<summary>
        ///List Box.
        ///<para>When the item is serialized out as xml, its value is "List".</para>
        ///</summary>
        [EnumString("List")]
        List,
        ///<summary>
        ///Movie.
        ///<para>When the item is serialized out as xml, its value is "Movie".</para>
        ///</summary>
        [EnumString("Movie")]
        Movie,
        ///<summary>
        ///Comment.
        ///<para>When the item is serialized out as xml, its value is "Note".</para>
        ///</summary>
        [EnumString("Note")]
        Note,
        ///<summary>
        ///Image.
        ///<para>When the item is serialized out as xml, its value is "Pict".</para>
        ///</summary>
        [EnumString("Pict")]
        Picture,
        ///<summary>
        ///Radio Button.
        ///<para>When the item is serialized out as xml, its value is "Radio".</para>
        ///</summary>
        [EnumString("Radio")]
        Radio,
        ///<summary>
        ///Auditing Rectangle.
        ///<para>When the item is serialized out as xml, its value is "RectA".</para>
        ///</summary>
        [EnumString("RectA")]
        AuditingRectangle,
        ///<summary>
        ///Scroll Bar.
        ///<para>When the item is serialized out as xml, its value is "Scroll".</para>
        ///</summary>
        [EnumString("Scroll")]
        Scroll,
        ///<summary>
        ///Spin Button.
        ///<para>When the item is serialized out as xml, its value is "Spin".</para>
        ///</summary>
        [EnumString("Spin")]
        Spin,
        ///<summary>
        ///Plain Shape.
        ///<para>When the item is serialized out as xml, its value is "Shape".</para>
        ///</summary>
        [EnumString("Shape")]
        Shape,
        ///<summary>
        ///Group.
        ///<para>When the item is serialized out as xml, its value is "Group".</para>
        ///</summary>
        [EnumString("Group")]
        Group,
        ///<summary>
        ///Plain Rectangle.
        ///<para>When the item is serialized out as xml, its value is "Rect".</para>
        ///</summary>
        [EnumString("Rect")]
        Rectangle,
    }

    /// <summary>
    /// Boolean Value with Blank State
    /// </summary>
    public enum BooleanEntryWithBlankValues
    {
        ///<summary>
        ///Logical True.
        ///<para>When the item is serialized out as xml, its value is "True".</para>
        ///</summary>
        [EnumString("True")]
        True,
        ///<summary>
        ///Logical True.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        T,
        ///<summary>
        ///Logical False.
        ///<para>When the item is serialized out as xml, its value is "False".</para>
        ///</summary>
        [EnumString("False")]
        False,
        ///<summary>
        ///Logical False.
        ///<para>When the item is serialized out as xml, its value is "f".</para>
        ///</summary>
        [EnumString("f")]
        F,
        ///<summary>
        ///Blank - Default Value.
        ///<para>When the item is serialized out as xml, its value is "".</para>
        ///</summary>
        [EnumString("")]
        Empty,
    }
}