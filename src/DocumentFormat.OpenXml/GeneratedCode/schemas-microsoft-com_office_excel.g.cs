// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

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
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ClientData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.CommentRowTarget" /> <c>&lt;xvml:Row></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.CommentColumnTarget" /> <c>&lt;xvml:Column></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.InputValidationType" /> <c>&lt;xvml:VTEdit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.MinDropDownWidth" /> <c>&lt;xvml:WidthMin></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.SelectionEntry" /> <c>&lt;xvml:Sel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.DropLines" /> <c>&lt;xvml:DropLines></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Checked" /> <c>&lt;xvml:Checked></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarPosition" /> <c>&lt;xvml:Val></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarMin" /> <c>&lt;xvml:Min></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarMax" /> <c>&lt;xvml:Max></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarIncrement" /> <c>&lt;xvml:Inc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarPageIncrement" /> <c>&lt;xvml:Page></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarWidth" /> <c>&lt;xvml:Dx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptLanguage" /> <c>&lt;xvml:ScriptLanguage></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptLocation" /> <c>&lt;xvml:ScriptLocation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Anchor" /> <c>&lt;xvml:Anchor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.HorizontalTextAlignment" /> <c>&lt;xvml:TextHAlign></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.VerticalTextAlignment" /> <c>&lt;xvml:TextVAlign></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaRange" /> <c>&lt;xvml:FmlaRange></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.SelectionType" /> <c>&lt;xvml:SelType></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.MultiSelections" /> <c>&lt;xvml:MultiSel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ListBoxCallbackType" /> <c>&lt;xvml:LCT></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ListItem" /> <c>&lt;xvml:ListItem></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.DropStyle" /> <c>&lt;xvml:DropStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaLink" /> <c>&lt;xvml:FmlaLink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaPicture" /> <c>&lt;xvml:FmlaPict></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaGroup" /> <c>&lt;xvml:FmlaGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptText" /> <c>&lt;xvml:ScriptText></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptExtended" /> <c>&lt;xvml:ScriptExtended></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaTextBox" /> <c>&lt;xvml:FmlaTxbx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.AcceleratorPrimary" /> <c>&lt;xvml:Accel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.AcceleratorSecondary" /> <c>&lt;xvml:Accel2></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClipboardFormat" /> <c>&lt;xvml:CF></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaMacro" /> <c>&lt;xvml:FmlaMacro></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.MoveWithCells" /> <c>&lt;xvml:MoveWithCells></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ResizeWithCells" /> <c>&lt;xvml:SizeWithCells></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Locked" /> <c>&lt;xvml:Locked></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.DefaultSize" /> <c>&lt;xvml:DefaultSize></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.PrintObject" /> <c>&lt;xvml:PrintObject></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Disabled" /> <c>&lt;xvml:Disabled></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.AutoFill" /> <c>&lt;xvml:AutoFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.AutoLine" /> <c>&lt;xvml:AutoLine></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.AutoSizePicture" /> <c>&lt;xvml:AutoPict></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.LockText" /> <c>&lt;xvml:LockText></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.JustifyLastLine" /> <c>&lt;xvml:JustLastX></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.SecretEdit" /> <c>&lt;xvml:SecretEdit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.DefaultButton" /> <c>&lt;xvml:Default></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.HelpButton" /> <c>&lt;xvml:Help></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.CancelButton" /> <c>&lt;xvml:Cancel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.DismissButton" /> <c>&lt;xvml:Dismiss></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Visible" /> <c>&lt;xvml:Visible></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.RowHidden" /> <c>&lt;xvml:RowHidden></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ColumnHidden" /> <c>&lt;xvml:ColHidden></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.MultiLine" /> <c>&lt;xvml:MultiLine></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.VerticalScrollBar" /> <c>&lt;xvml:VScroll></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ValidIds" /> <c>&lt;xvml:ValidIds></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Disable3DForListBoxAndDropDown" /> <c>&lt;xvml:NoThreeD2></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Colored" /> <c>&lt;xvml:Colored></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.Disable3D" /> <c>&lt;xvml:NoThreeD></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.FirstButton" /> <c>&lt;xvml:FirstButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.HorizontalScrollBar" /> <c>&lt;xvml:Horiz></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.MapOcxControl" /> <c>&lt;xvml:MapOCX></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.CameraObject" /> <c>&lt;xvml:Camera></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.RecalculateAlways" /> <c>&lt;xvml:RecalcAlways></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.AutoScaleFont" /> <c>&lt;xvml:AutoScale></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.DdeObject" /> <c>&lt;xvml:DDE></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.UIObject" /> <c>&lt;xvml:UIObj></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ClientData")]
#pragma warning restore CS0618 // Type or member is obsolete
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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("ObjectType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ObjectValues>? ObjectType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ObjectValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xvml:ClientData");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.CommentRowTarget>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.CommentColumnTarget>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.InputValidationType>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.MinDropDownWidth>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.SelectionEntry>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.DropLines>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Checked>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarPosition>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarMin>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarMax>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarIncrement>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarPageIncrement>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScrollBarWidth>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptLanguage>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptLocation>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Anchor>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.HorizontalTextAlignment>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.VerticalTextAlignment>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaRange>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.SelectionType>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.MultiSelections>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ListBoxCallbackType>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ListItem>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.DropStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaLink>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaPicture>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptText>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptExtended>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaTextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.AcceleratorPrimary>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.AcceleratorSecondary>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClipboardFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.FormulaMacro>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.MoveWithCells>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ResizeWithCells>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Locked>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.DefaultSize>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.PrintObject>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Disabled>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.AutoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.AutoLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.AutoSizePicture>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.LockText>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.JustifyLastLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.SecretEdit>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.DefaultButton>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.HelpButton>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.CancelButton>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.DismissButton>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Visible>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.RowHidden>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ColumnHidden>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.MultiLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.VerticalScrollBar>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ValidIds>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Disable3DForListBoxAndDropDown>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Colored>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.Disable3D>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.FirstButton>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.HorizontalScrollBar>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.MapOcxControl>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.CameraObject>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.RecalculateAlways>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.AutoScaleFont>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.DdeObject>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.UIObject>();
            builder.AddElement<ClientData>()
.AddAttribute("ObjectType", a => a.ObjectType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
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
            builder.AddConstraint(new AttributeValueSetConstraint(":ObjectType", false, new string[] { "Movie" }) { Application = ApplicationType.Excel });
            builder.AddConstraint(new AttributeValueSetConstraint(":ObjectType", false, new string[] { "LineA", "RectA" }) { Application = ApplicationType.Excel });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClientData>(deep);
    }

    /// <summary>
    /// <para>Move with Cells.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MoveWithCells.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:MoveWithCells")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:MoveWithCells");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MoveWithCells>(deep);
    }

    /// <summary>
    /// <para>Resize with Cells.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:SizeWithCells.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:SizeWithCells")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:SizeWithCells");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResizeWithCells>(deep);
    }

    /// <summary>
    /// <para>Lock Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Locked.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Locked")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Locked");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Locked>(deep);
    }

    /// <summary>
    /// <para>Default Size Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DefaultSize.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:DefaultSize")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:DefaultSize");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultSize>(deep);
    }

    /// <summary>
    /// <para>Print Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:PrintObject.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:PrintObject")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:PrintObject");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintObject>(deep);
    }

    /// <summary>
    /// <para>Macro Disable Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Disabled.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Disabled")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Disabled");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Disabled>(deep);
    }

    /// <summary>
    /// <para>AutoFill.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoFill.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:AutoFill")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:AutoFill");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoFill>(deep);
    }

    /// <summary>
    /// <para>AutoLine.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoLine.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:AutoLine")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:AutoLine");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoLine>(deep);
    }

    /// <summary>
    /// <para>Automatically Size.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoPict.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:AutoPict")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:AutoPict");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoSizePicture>(deep);
    }

    /// <summary>
    /// <para>Text Lock.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:LockText.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:LockText")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:LockText");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LockText>(deep);
    }

    /// <summary>
    /// <para>East Asia Alignment Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:JustLastX.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:JustLastX")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:JustLastX");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<JustifyLastLine>(deep);
    }

    /// <summary>
    /// <para>Password Edit.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:SecretEdit.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:SecretEdit")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:SecretEdit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SecretEdit>(deep);
    }

    /// <summary>
    /// <para>Default Button.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Default.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Default")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Default");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultButton>(deep);
    }

    /// <summary>
    /// <para>Help Button.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Help.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Help")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Help");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HelpButton>(deep);
    }

    /// <summary>
    /// <para>Cancel Button.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Cancel.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Cancel")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Cancel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CancelButton>(deep);
    }

    /// <summary>
    /// <para>Dismiss Button.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Dismiss.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Dismiss")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Dismiss");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DismissButton>(deep);
    }

    /// <summary>
    /// <para>Comment Visibility Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Visible.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Visible")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Visible");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Visible>(deep);
    }

    /// <summary>
    /// <para>Comment's Row is Hidden.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:RowHidden.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:RowHidden")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:RowHidden");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowHidden>(deep);
    }

    /// <summary>
    /// <para>Comment's Column is Hidden.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ColHidden.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ColHidden")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:ColHidden");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnHidden>(deep);
    }

    /// <summary>
    /// <para>Multi-line.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MultiLine.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:MultiLine")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:MultiLine");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLine>(deep);
    }

    /// <summary>
    /// <para>Vertical Scroll.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:VScroll.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:VScroll")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:VScroll");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalScrollBar>(deep);
    }

    /// <summary>
    /// <para>Valid ID.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ValidIds.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ValidIds")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:ValidIds");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValidIds>(deep);
    }

    /// <summary>
    /// <para>Disable 3D.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:NoThreeD2.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:NoThreeD2")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:NoThreeD2");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Disable3DForListBoxAndDropDown>(deep);
    }

    /// <summary>
    /// <para>Dropdown Color Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Colored.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Colored")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Colored");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Colored>(deep);
    }

    /// <summary>
    /// <para>Disable 3D.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:NoThreeD.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:NoThreeD")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:NoThreeD");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Disable3D>(deep);
    }

    /// <summary>
    /// <para>First Radio Button.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FirstButton.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:FirstButton")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:FirstButton");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstButton>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Orientation.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Horiz.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Horiz")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Horiz");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalScrollBar>(deep);
    }

    /// <summary>
    /// <para>ActiveX Control.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MapOCX.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:MapOCX")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:MapOCX");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MapOcxControl>(deep);
    }

    /// <summary>
    /// <para>Camera Tool.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Camera.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Camera")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Camera");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CameraObject>(deep);
    }

    /// <summary>
    /// <para>Recalculation Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:RecalcAlways.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:RecalcAlways")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:RecalcAlways");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecalculateAlways>(deep);
    }

    /// <summary>
    /// <para>Font AutoScale.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:AutoScale.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:AutoScale")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:AutoScale");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoScaleFont>(deep);
    }

    /// <summary>
    /// <para>Dynamic Data Exchange.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DDE.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:DDE")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:DDE");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DdeObject>(deep);
    }

    /// <summary>
    /// <para>UI Object Toggle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:UIObj.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:UIObj")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:UIObj");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UIObject>(deep);
    }

    /// <summary>
    /// <para>Anchor.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Anchor.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Anchor")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Anchor");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Anchor>(deep);
    }

    /// <summary>
    /// <para>Horizontal Text Alignment.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:TextHAlign.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:TextHAlign")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:TextHAlign");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalTextAlignment>(deep);
    }

    /// <summary>
    /// <para>Vertical Text Alignment.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:TextVAlign.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:TextVAlign")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:TextVAlign");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalTextAlignment>(deep);
    }

    /// <summary>
    /// <para>List Items Source Range.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaRange.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:FmlaRange")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:FmlaRange");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaRange>(deep);
    }

    /// <summary>
    /// <para>Selection Type.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:SelType.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:SelType")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:SelType");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SelectionType>(deep);
    }

    /// <summary>
    /// <para>Multiple Selections.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:MultiSel.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:MultiSel")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:MultiSel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiSelections>(deep);
    }

    /// <summary>
    /// <para>Callback Type.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:LCT.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:LCT")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:LCT");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListBoxCallbackType>(deep);
    }

    /// <summary>
    /// <para>Non-linked List Item.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ListItem.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ListItem")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:ListItem");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListItem>(deep);
    }

    /// <summary>
    /// <para>Dropdown Style.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DropStyle.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:DropStyle")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:DropStyle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropStyle>(deep);
    }

    /// <summary>
    /// <para>Linked Formula.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaLink.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:FmlaLink")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:FmlaLink");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaLink>(deep);
    }

    /// <summary>
    /// <para>Camera Source Range.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaPict.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:FmlaPict")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:FmlaPict");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaPicture>(deep);
    }

    /// <summary>
    /// <para>Linked Formula - Group Box.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaGroup.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:FmlaGroup")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:FmlaGroup");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaGroup>(deep);
    }

    /// <summary>
    /// <para>HTML Script Text.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptText.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ScriptText")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:ScriptText");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptText>(deep);
    }

    /// <summary>
    /// <para>HTML Script Attributes.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptExtended.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ScriptExtended")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:ScriptExtended");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptExtended>(deep);
    }

    /// <summary>
    /// <para>Text Formula.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaTxbx.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:FmlaTxbx")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:FmlaTxbx");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaTextBox>(deep);
    }

    /// <summary>
    /// <para>Reference to Custom Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:FmlaMacro.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:FmlaMacro")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:FmlaMacro");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaMacro>(deep);
    }

    /// <summary>
    /// <para>Primary Keyboard Accelerator.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Accel.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Accel")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Accel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AcceleratorPrimary>(deep);
    }

    /// <summary>
    /// <para>Secondary Keyboard Accelerator.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Accel2.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Accel2")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Accel2");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AcceleratorSecondary>(deep);
    }

    /// <summary>
    /// <para>Comment Row Target.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Row.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Row")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Row");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentRowTarget>(deep);
    }

    /// <summary>
    /// <para>Comment Column Target.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Column.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Column")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Column");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentColumnTarget>(deep);
    }

    /// <summary>
    /// <para>Validation Type.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:VTEdit.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:VTEdit")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:VTEdit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InputValidationType>(deep);
    }

    /// <summary>
    /// <para>Minimum Width.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:WidthMin.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:WidthMin")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:WidthMin");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinDropDownWidth>(deep);
    }

    /// <summary>
    /// <para>Selected Entry.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Sel.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Sel")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Sel");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SelectionEntry>(deep);
    }

    /// <summary>
    /// <para>Dropdown Maximum Lines.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:DropLines.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:DropLines")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:DropLines");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropLines>(deep);
    }

    /// <summary>
    /// <para>Checked.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Checked.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Checked")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Checked");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Checked>(deep);
    }

    /// <summary>
    /// <para>Scroll bar position.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Val.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Val")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Val");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarPosition>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Minimum.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Min.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Min")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Min");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarMin>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Maximum.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Max.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Max")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Max");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarMax>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Increment.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Inc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Inc")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Inc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarIncrement>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Page Increment.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Page.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Page")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Page");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarPageIncrement>(deep);
    }

    /// <summary>
    /// <para>Scroll Bar Width.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:Dx.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:Dx")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:Dx");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScrollBarWidth>(deep);
    }

    /// <summary>
    /// <para>Clipboard Format.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:CF.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:CF")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:CF");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClipboardFormat>(deep);
    }

    /// <summary>
    /// <para>HTML Script Language.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptLanguage.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ScriptLanguage")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:ScriptLanguage");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptLanguage>(deep);
    }

    /// <summary>
    /// <para>HTML Script Location.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xvml:ScriptLocation.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("xvml:ScriptLocation")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("xvml:ScriptLocation");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScriptLocation>(deep);
    }

    /// <summary>
    /// Clipboard Format Type
    /// </summary>
    public enum ClipboardFormatValues
    {
        /// <summary>
        /// WMF.
        /// <para>When the item is serialized out as xml, its value is "PictOld".</para>
        /// </summary>
        [EnumString("PictOld")]
        PictureOld,
        /// <summary>
        /// EMF.
        /// <para>When the item is serialized out as xml, its value is "Pict".</para>
        /// </summary>
        [EnumString("Pict")]
        Picture,
        /// <summary>
        /// Bitmap.
        /// <para>When the item is serialized out as xml, its value is "Bitmap".</para>
        /// </summary>
        [EnumString("Bitmap")]
        Bitmap,
        /// <summary>
        /// Printer Picture.
        /// <para>When the item is serialized out as xml, its value is "PictPrint".</para>
        /// </summary>
        [EnumString("PictPrint")]
        PicturePrint,
        /// <summary>
        /// Screen Picture EMF.
        /// <para>When the item is serialized out as xml, its value is "PictScreen".</para>
        /// </summary>
        [EnumString("PictScreen")]
        PictureScreen
    }

    /// <summary>
    /// Object Type
    /// </summary>
    public enum ObjectValues
    {
        /// <summary>
        /// Pushbutton.
        /// <para>When the item is serialized out as xml, its value is "Button".</para>
        /// </summary>
        [EnumString("Button")]
        Button,
        /// <summary>
        /// Checkbox.
        /// <para>When the item is serialized out as xml, its value is "Checkbox".</para>
        /// </summary>
        [EnumString("Checkbox")]
        Checkbox,
        /// <summary>
        /// Dialog.
        /// <para>When the item is serialized out as xml, its value is "Dialog".</para>
        /// </summary>
        [EnumString("Dialog")]
        Dialog,
        /// <summary>
        /// Dropdown Box.
        /// <para>When the item is serialized out as xml, its value is "Drop".</para>
        /// </summary>
        [EnumString("Drop")]
        Drop,
        /// <summary>
        /// Editable Text Field.
        /// <para>When the item is serialized out as xml, its value is "Edit".</para>
        /// </summary>
        [EnumString("Edit")]
        Edit,
        /// <summary>
        /// Group Box.
        /// <para>When the item is serialized out as xml, its value is "GBox".</para>
        /// </summary>
        [EnumString("GBox")]
        GroupBox,
        /// <summary>
        /// Label.
        /// <para>When the item is serialized out as xml, its value is "Label".</para>
        /// </summary>
        [EnumString("Label")]
        Label,
        /// <summary>
        /// Auditing Line.
        /// <para>When the item is serialized out as xml, its value is "LineA".</para>
        /// </summary>
        [EnumString("LineA")]
        AuditingLine,
        /// <summary>
        /// List Box.
        /// <para>When the item is serialized out as xml, its value is "List".</para>
        /// </summary>
        [EnumString("List")]
        List,
        /// <summary>
        /// Movie.
        /// <para>When the item is serialized out as xml, its value is "Movie".</para>
        /// </summary>
        [EnumString("Movie")]
        Movie,
        /// <summary>
        /// Comment.
        /// <para>When the item is serialized out as xml, its value is "Note".</para>
        /// </summary>
        [EnumString("Note")]
        Note,
        /// <summary>
        /// Image.
        /// <para>When the item is serialized out as xml, its value is "Pict".</para>
        /// </summary>
        [EnumString("Pict")]
        Picture,
        /// <summary>
        /// Radio Button.
        /// <para>When the item is serialized out as xml, its value is "Radio".</para>
        /// </summary>
        [EnumString("Radio")]
        Radio,
        /// <summary>
        /// Auditing Rectangle.
        /// <para>When the item is serialized out as xml, its value is "RectA".</para>
        /// </summary>
        [EnumString("RectA")]
        AuditingRectangle,
        /// <summary>
        /// Scroll Bar.
        /// <para>When the item is serialized out as xml, its value is "Scroll".</para>
        /// </summary>
        [EnumString("Scroll")]
        Scroll,
        /// <summary>
        /// Spin Button.
        /// <para>When the item is serialized out as xml, its value is "Spin".</para>
        /// </summary>
        [EnumString("Spin")]
        Spin,
        /// <summary>
        /// Plain Shape.
        /// <para>When the item is serialized out as xml, its value is "Shape".</para>
        /// </summary>
        [EnumString("Shape")]
        Shape,
        /// <summary>
        /// Group.
        /// <para>When the item is serialized out as xml, its value is "Group".</para>
        /// </summary>
        [EnumString("Group")]
        Group,
        /// <summary>
        /// Plain Rectangle.
        /// <para>When the item is serialized out as xml, its value is "Rect".</para>
        /// </summary>
        [EnumString("Rect")]
        Rectangle
    }

    /// <summary>
    /// Boolean Value with Blank State
    /// </summary>
    public enum BooleanEntryWithBlankValues
    {
        /// <summary>
        /// Logical True.
        /// <para>When the item is serialized out as xml, its value is "True".</para>
        /// </summary>
        [EnumString("True")]
        True,
        /// <summary>
        /// Logical True.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        T,
        /// <summary>
        /// Logical False.
        /// <para>When the item is serialized out as xml, its value is "False".</para>
        /// </summary>
        [EnumString("False")]
        False,
        /// <summary>
        /// Logical False.
        /// <para>When the item is serialized out as xml, its value is "f".</para>
        /// </summary>
        [EnumString("f")]
        F,
        /// <summary>
        /// Blank - Default Value.
        /// <para>When the item is serialized out as xml, its value is "".</para>
        /// </summary>
        [EnumString("")]
        Empty
    }
}