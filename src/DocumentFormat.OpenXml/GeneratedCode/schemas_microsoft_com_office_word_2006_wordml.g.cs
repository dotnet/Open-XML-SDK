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

namespace DocumentFormat.OpenXml.Office.Word
{
    /// <summary>
    /// <para>Defines the TemplateCommandGroup Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:tcg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>KeyMapCustomizations &lt;wne:keymaps></description></item>
    ///   <item><description>MismatchedKeyMapCustomization &lt;wne:keymapsBad></description></item>
    ///   <item><description>Toolbars &lt;wne:toolbars></description></item>
    ///   <item><description>AllocatedCommands &lt;wne:acds></description></item>
    /// </list>
    /// </remark>
    public partial class TemplateCommandGroup : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class.
        /// </summary>
        public TemplateCommandGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TemplateCommandGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TemplateCommandGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TemplateCommandGroup(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "tcg");
            builder.AddChild<KeyMapCustomizations>();
            builder.AddChild<MismatchedKeyMapCustomization>();
            builder.AddChild<Toolbars>();
            builder.AddChild<AllocatedCommands>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Toolbars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommands), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TemplateCommandGroup>(deep);

        internal TemplateCommandGroup(CustomizationPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the CustomizationPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(CustomizationPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the CustomizationPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(CustomizationPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CustomizationPart associated with this element.
        /// </summary>
        public CustomizationPart CustomizationPart
        {
            get => OpenXmlPart as CustomizationPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the Mcds Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:mcds.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Mcd &lt;wne:mcd></description></item>
    /// </list>
    /// </remark>
    public partial class Mcds : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Mcds class.
        /// </summary>
        public Mcds() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mcds class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mcds(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mcds class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mcds(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mcds class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Mcds(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "mcds");
            builder.AddChild<Mcd>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Mcd), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mcds>(deep);
    }

    /// <summary>
    /// <para>Defines the VbaSuppData Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:vbaSuppData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocEvents &lt;wne:docEvents></description></item>
    ///   <item><description>Mcds &lt;wne:mcds></description></item>
    /// </list>
    /// </remark>
    public partial class VbaSuppData : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the VbaSuppData class.
        /// </summary>
        public VbaSuppData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VbaSuppData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VbaSuppData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VbaSuppData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VbaSuppData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VbaSuppData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public VbaSuppData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "vbaSuppData");
            builder.AddChild<DocEvents>();
            builder.AddChild<Mcds>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.DocEvents), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Mcds), 0, 1)
            };
        }

        /// <summary>
        /// <para>DocEvents.</para>
        /// <para>Represents the following element tag in the schema: wne:docEvents.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocEvents DocEvents
        {
            get => GetElement<DocEvents>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Mcds.</para>
        /// <para>Represents the following element tag in the schema: wne:mcds.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public Mcds Mcds
        {
            get => GetElement<Mcds>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VbaSuppData>(deep);

        internal VbaSuppData(VbaDataPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the VbaDataPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(VbaDataPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the VbaDataPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(VbaDataPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the VbaDataPart associated with this element.
        /// </summary>
        public VbaDataPart VbaDataPart
        {
            get => OpenXmlPart as VbaDataPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the MailMergeRecipients Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:recipients.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SingleDataSourceRecord &lt;wne:recipientData></description></item>
    /// </list>
    /// </remark>
    public partial class MailMergeRecipients : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class.
        /// </summary>
        public MailMergeRecipients() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MailMergeRecipients(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MailMergeRecipients(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MailMergeRecipients(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "recipients");
            builder.AddChild<SingleDataSourceRecord>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MailMergeRecipients>(deep);
    }

    /// <summary>
    /// <para>Defines the FixedCommandKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:fci.</para>
    /// </summary>
    public partial class FixedCommandKeyboardCustomization : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FixedCommandKeyboardCustomization class.
        /// </summary>
        public FixedCommandKeyboardCustomization() : base()
        {
        }

        /// <summary>
        /// <para>fciName</para>
        /// <para>Represents the following attribute in the schema: wne:fciName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue CommandName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fciIndex</para>
        /// <para>Represents the following attribute in the schema: wne:fciIndex</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue CommandIndex
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>swArg</para>
        /// <para>Represents the following attribute in the schema: wne:swArg</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue Argument
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "fci");
            builder.AddElement<FixedCommandKeyboardCustomization>()
.AddAttribute(33, "fciName", a => a.CommandName)
.AddAttribute(33, "fciIndex", a => a.CommandIndex, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute(33, "swArg", a => a.Argument, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { Length = (2L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FixedCommandKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the MacroKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:macro.</para>
    /// </summary>
    public partial class MacroKeyboardCustomization : MacroWllType
    {
        /// <summary>
        /// Initializes a new instance of the MacroKeyboardCustomization class.
        /// </summary>
        public MacroKeyboardCustomization() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "macro");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MacroKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the WllMacroKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:wll.</para>
    /// </summary>
    public partial class WllMacroKeyboardCustomization : MacroWllType
    {
        /// <summary>
        /// Initializes a new instance of the WllMacroKeyboardCustomization class.
        /// </summary>
        public WllMacroKeyboardCustomization() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "wll");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WllMacroKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the MacroWllType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class MacroWllType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MacroWllType class.
        /// </summary>
        protected MacroWllType() : base()
        {
        }

        /// <summary>
        /// <para>macroName</para>
        /// <para>Represents the following attribute in the schema: wne:macroName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue MacroName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<MacroWllType>()
                           .AddAttribute(33, "macroName", a => a.MacroName);
        }
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acd.</para>
    /// </summary>
    public partial class AllocatedCommandKeyboardCustomization : AcceleratorKeymapType
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandKeyboardCustomization class.
        /// </summary>
        public AllocatedCommandKeyboardCustomization() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "acd");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandManifestEntry Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acdEntry.</para>
    /// </summary>
    public partial class AllocatedCommandManifestEntry : AcceleratorKeymapType
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifestEntry class.
        /// </summary>
        public AllocatedCommandManifestEntry() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "acdEntry");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandManifestEntry>(deep);
    }

    /// <summary>
    /// <para>Defines the AcceleratorKeymapType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class AcceleratorKeymapType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AcceleratorKeymapType class.
        /// </summary>
        protected AcceleratorKeymapType() : base()
        {
        }

        /// <summary>
        /// <para>acdName</para>
        /// <para>Represents the following attribute in the schema: wne:acdName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue AcceleratorName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<AcceleratorKeymapType>()
                           .AddAttribute(33, "acdName", a => a.AcceleratorName);
        }
    }

    /// <summary>
    /// <para>Defines the CharacterInsertion Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:wch.</para>
    /// </summary>
    public partial class CharacterInsertion : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CharacterInsertion class.
        /// </summary>
        public CharacterInsertion() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: wne:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue Val
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "wch");
            builder.AddElement<CharacterInsertion>()
.AddAttribute(33, "val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new StringValidator() { Length = (4L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CharacterInsertion>(deep);
    }

    /// <summary>
    /// <para>Defines the KeyMapEntry Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:keymap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FixedCommandKeyboardCustomization &lt;wne:fci></description></item>
    ///   <item><description>MacroKeyboardCustomization &lt;wne:macro></description></item>
    ///   <item><description>AllocatedCommandKeyboardCustomization &lt;wne:acd></description></item>
    ///   <item><description>WllMacroKeyboardCustomization &lt;wne:wll></description></item>
    ///   <item><description>CharacterInsertion &lt;wne:wch></description></item>
    /// </list>
    /// </remark>
    public partial class KeyMapEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class.
        /// </summary>
        public KeyMapEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapEntry(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public KeyMapEntry(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>chmPrimary</para>
        /// <para>Represents the following attribute in the schema: wne:chmPrimary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue CharacterMapPrimary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>chmSecondary</para>
        /// <para>Represents the following attribute in the schema: wne:chmSecondary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue CharacterMapSecondary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>kcmPrimary</para>
        /// <para>Represents the following attribute in the schema: wne:kcmPrimary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue KeyCodePrimary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>kcmSecondary</para>
        /// <para>Represents the following attribute in the schema: wne:kcmSecondary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue KeyCodeSecondary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mask</para>
        /// <para>Represents the following attribute in the schema: wne:mask</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public OnOffValue Mask
        {
            get => GetAttribute<OnOffValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "keymap");
            builder.AddChild<FixedCommandKeyboardCustomization>();
            builder.AddChild<MacroKeyboardCustomization>();
            builder.AddChild<AllocatedCommandKeyboardCustomization>();
            builder.AddChild<WllMacroKeyboardCustomization>();
            builder.AddChild<CharacterInsertion>();
            builder.AddElement<KeyMapEntry>()
.AddAttribute(33, "chmPrimary", a => a.CharacterMapPrimary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute(33, "chmSecondary", a => a.CharacterMapSecondary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute(33, "kcmPrimary", a => a.KeyCodePrimary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute(33, "kcmSecondary", a => a.KeyCodeSecondary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute(33, "mask", a => a.Mask);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.CharacterInsertion), 1, 1)
            };
        }

        /// <summary>
        /// <para>FixedCommandKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:fci.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public FixedCommandKeyboardCustomization FixedCommandKeyboardCustomization
        {
            get => GetElement<FixedCommandKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MacroKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:macro.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public MacroKeyboardCustomization MacroKeyboardCustomization
        {
            get => GetElement<MacroKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>AllocatedCommandKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:acd.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public AllocatedCommandKeyboardCustomization AllocatedCommandKeyboardCustomization
        {
            get => GetElement<AllocatedCommandKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>WllMacroKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:wll.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public WllMacroKeyboardCustomization WllMacroKeyboardCustomization
        {
            get => GetElement<WllMacroKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CharacterInsertion.</para>
        /// <para>Represents the following element tag in the schema: wne:wch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public CharacterInsertion CharacterInsertion
        {
            get => GetElement<CharacterInsertion>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<KeyMapEntry>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommand Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acd.</para>
    /// </summary>
    public partial class AllocatedCommand : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommand class.
        /// </summary>
        public AllocatedCommand() : base()
        {
        }

        /// <summary>
        /// <para>argValue</para>
        /// <para>Represents the following attribute in the schema: wne:argValue</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue ArgumentValue
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fciBasedOn</para>
        /// <para>Represents the following attribute in the schema: wne:fciBasedOn</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue CommandBasedOn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fciIndexBasedOn</para>
        /// <para>Represents the following attribute in the schema: wne:fciIndexBasedOn</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue CommandIndexBasedOn
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>acdName</para>
        /// <para>Represents the following attribute in the schema: wne:acdName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue AcceleratorName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "acd");
            builder.AddElement<AllocatedCommand>()
.AddAttribute(33, "argValue", a => a.ArgumentValue)
.AddAttribute(33, "fciBasedOn", a => a.CommandBasedOn)
.AddAttribute(33, "fciIndexBasedOn", a => a.CommandIndexBasedOn, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute(33, "acdName", a => a.AcceleratorName);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the Mcd Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:mcd.</para>
    /// </summary>
    public partial class Mcd : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Mcd class.
        /// </summary>
        public Mcd() : base()
        {
        }

        /// <summary>
        /// <para>macroName</para>
        /// <para>Represents the following attribute in the schema: wne:macroName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue MacroName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: wne:name</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>menuHelp</para>
        /// <para>Represents the following attribute in the schema: wne:menuHelp</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public StringValue MenuHelp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bEncrypt</para>
        /// <para>Represents the following attribute in the schema: wne:bEncrypt</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue BEncrypt
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cmg</para>
        /// <para>Represents the following attribute in the schema: wne:cmg</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public HexBinaryValue Cmg
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "mcd");
            builder.AddElement<Mcd>()
.AddAttribute(33, "macroName", a => a.MacroName)
.AddAttribute(33, "name", a => a.Name)
.AddAttribute(33, "menuHelp", a => a.MenuHelp)
.AddAttribute(33, "bEncrypt", a => a.BEncrypt, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { Length = (1L) });
})
.AddAttribute(33, "cmg", a => a.Cmg, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { Length = (1L) });
});
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*wne:name*/, 0, 255) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueSetConstraint(3 /*wne:bEncrypt*/, true, new string[] { "0" }) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueSetConstraint(4 /*wne:cmg*/, true, new string[] { "56" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mcd>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocNewXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocNew.</para>
    /// </summary>
    public partial class EventDocNewXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocNewXsdString class.
        /// </summary>
        public EventDocNewXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocNewXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocNewXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocNew");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocNewXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocOpenXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocOpen.</para>
    /// </summary>
    public partial class EventDocOpenXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocOpenXsdString class.
        /// </summary>
        public EventDocOpenXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocOpenXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocOpenXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocOpen");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocOpenXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocCloseXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocClose.</para>
    /// </summary>
    public partial class EventDocCloseXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocCloseXsdString class.
        /// </summary>
        public EventDocCloseXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocCloseXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocCloseXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocClose");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocCloseXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocSyncXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocSync.</para>
    /// </summary>
    public partial class EventDocSyncXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocSyncXsdString class.
        /// </summary>
        public EventDocSyncXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocSyncXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocSyncXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocSync");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocSyncXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocXmlAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocXmlAfterInsert.</para>
    /// </summary>
    public partial class EventDocXmlAfterInsertXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocXmlAfterInsertXsdString class.
        /// </summary>
        public EventDocXmlAfterInsertXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocXmlAfterInsertXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocXmlAfterInsertXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocXmlAfterInsert");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocXmlBeforeDeleteXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocXmlBeforeDelete.</para>
    /// </summary>
    public partial class EventDocXmlBeforeDeleteXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocXmlBeforeDeleteXsdString class.
        /// </summary>
        public EventDocXmlBeforeDeleteXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocXmlBeforeDeleteXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocXmlBeforeDeleteXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocXmlBeforeDelete");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlBeforeDeleteXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlAfterInsert.</para>
    /// </summary>
    public partial class EventDocContentControlAfterInsertXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlAfterInsertXsdString class.
        /// </summary>
        public EventDocContentControlAfterInsertXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlAfterInsertXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlAfterInsertXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocContentControlAfterInsert");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlBeforeDeleteXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlBeforeDelete.</para>
    /// </summary>
    public partial class EventDocContentControlBeforeDeleteXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlBeforeDeleteXsdString class.
        /// </summary>
        public EventDocContentControlBeforeDeleteXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlBeforeDeleteXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlBeforeDeleteXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocContentControlBeforeDelete");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlBeforeDeleteXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlOnExistXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlOnExit.</para>
    /// </summary>
    public partial class EventDocContentControlOnExistXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnExistXsdString class.
        /// </summary>
        public EventDocContentControlOnExistXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnExistXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlOnExistXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocContentControlOnExit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnExistXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlOnEnterXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlOnEnter.</para>
    /// </summary>
    public partial class EventDocContentControlOnEnterXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnEnterXsdString class.
        /// </summary>
        public EventDocContentControlOnEnterXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnEnterXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlOnEnterXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocContentControlOnEnter");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnEnterXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocStoreUpdateXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocStoreUpdate.</para>
    /// </summary>
    public partial class EventDocStoreUpdateXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocStoreUpdateXsdString class.
        /// </summary>
        public EventDocStoreUpdateXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocStoreUpdateXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocStoreUpdateXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocStoreUpdate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocStoreUpdateXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlUpdateXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlContentUpdate.</para>
    /// </summary>
    public partial class EventDocContentControlUpdateXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlUpdateXsdString class.
        /// </summary>
        public EventDocContentControlUpdateXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlUpdateXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlUpdateXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocContentControlContentUpdate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlUpdateXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocBuildingBlockAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocBuildingBlockAfterInsert.</para>
    /// </summary>
    public partial class EventDocBuildingBlockAfterInsertXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocBuildingBlockAfterInsertXsdString class.
        /// </summary>
        public EventDocBuildingBlockAfterInsertXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocBuildingBlockAfterInsertXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocBuildingBlockAfterInsertXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "eventDocBuildingBlockAfterInsert");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocBuildingBlockAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the DocEvents Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:docEvents.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>EventDocNewXsdString &lt;wne:eventDocNew></description></item>
    ///   <item><description>EventDocOpenXsdString &lt;wne:eventDocOpen></description></item>
    ///   <item><description>EventDocCloseXsdString &lt;wne:eventDocClose></description></item>
    ///   <item><description>EventDocSyncXsdString &lt;wne:eventDocSync></description></item>
    ///   <item><description>EventDocXmlAfterInsertXsdString &lt;wne:eventDocXmlAfterInsert></description></item>
    ///   <item><description>EventDocXmlBeforeDeleteXsdString &lt;wne:eventDocXmlBeforeDelete></description></item>
    ///   <item><description>EventDocContentControlAfterInsertXsdString &lt;wne:eventDocContentControlAfterInsert></description></item>
    ///   <item><description>EventDocContentControlBeforeDeleteXsdString &lt;wne:eventDocContentControlBeforeDelete></description></item>
    ///   <item><description>EventDocContentControlOnExistXsdString &lt;wne:eventDocContentControlOnExit></description></item>
    ///   <item><description>EventDocContentControlOnEnterXsdString &lt;wne:eventDocContentControlOnEnter></description></item>
    ///   <item><description>EventDocStoreUpdateXsdString &lt;wne:eventDocStoreUpdate></description></item>
    ///   <item><description>EventDocContentControlUpdateXsdString &lt;wne:eventDocContentControlContentUpdate></description></item>
    ///   <item><description>EventDocBuildingBlockAfterInsertXsdString &lt;wne:eventDocBuildingBlockAfterInsert></description></item>
    /// </list>
    /// </remark>
    public partial class DocEvents : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DocEvents class.
        /// </summary>
        public DocEvents() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocEvents class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocEvents(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocEvents class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocEvents(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocEvents class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocEvents(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "docEvents");
            builder.AddChild<EventDocNewXsdString>();
            builder.AddChild<EventDocOpenXsdString>();
            builder.AddChild<EventDocCloseXsdString>();
            builder.AddChild<EventDocSyncXsdString>();
            builder.AddChild<EventDocXmlAfterInsertXsdString>();
            builder.AddChild<EventDocXmlBeforeDeleteXsdString>();
            builder.AddChild<EventDocContentControlAfterInsertXsdString>();
            builder.AddChild<EventDocContentControlBeforeDeleteXsdString>();
            builder.AddChild<EventDocContentControlOnExistXsdString>();
            builder.AddChild<EventDocContentControlOnEnterXsdString>();
            builder.AddChild<EventDocStoreUpdateXsdString>();
            builder.AddChild<EventDocContentControlUpdateXsdString>();
            builder.AddChild<EventDocBuildingBlockAfterInsertXsdString>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString), 0, 1)
            };
        }

        /// <summary>
        /// <para>EventDocNewXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocNew.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocNewXsdString EventDocNewXsdString
        {
            get => GetElement<EventDocNewXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocOpenXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocOpen.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocOpenXsdString EventDocOpenXsdString
        {
            get => GetElement<EventDocOpenXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocCloseXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocClose.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocCloseXsdString EventDocCloseXsdString
        {
            get => GetElement<EventDocCloseXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocSyncXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocSync.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocSyncXsdString EventDocSyncXsdString
        {
            get => GetElement<EventDocSyncXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocXmlAfterInsertXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocXmlAfterInsert.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocXmlAfterInsertXsdString EventDocXmlAfterInsertXsdString
        {
            get => GetElement<EventDocXmlAfterInsertXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocXmlBeforeDeleteXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocXmlBeforeDelete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocXmlBeforeDeleteXsdString EventDocXmlBeforeDeleteXsdString
        {
            get => GetElement<EventDocXmlBeforeDeleteXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlAfterInsertXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlAfterInsert.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocContentControlAfterInsertXsdString EventDocContentControlAfterInsertXsdString
        {
            get => GetElement<EventDocContentControlAfterInsertXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlBeforeDeleteXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlBeforeDelete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocContentControlBeforeDeleteXsdString EventDocContentControlBeforeDeleteXsdString
        {
            get => GetElement<EventDocContentControlBeforeDeleteXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlOnExistXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlOnExit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocContentControlOnExistXsdString EventDocContentControlOnExistXsdString
        {
            get => GetElement<EventDocContentControlOnExistXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlOnEnterXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlOnEnter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocContentControlOnEnterXsdString EventDocContentControlOnEnterXsdString
        {
            get => GetElement<EventDocContentControlOnEnterXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocStoreUpdateXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocStoreUpdate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocStoreUpdateXsdString EventDocStoreUpdateXsdString
        {
            get => GetElement<EventDocStoreUpdateXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlUpdateXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlContentUpdate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocContentControlUpdateXsdString EventDocContentControlUpdateXsdString
        {
            get => GetElement<EventDocContentControlUpdateXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocBuildingBlockAfterInsertXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocBuildingBlockAfterInsert.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public EventDocBuildingBlockAfterInsertXsdString EventDocBuildingBlockAfterInsertXsdString
        {
            get => GetElement<EventDocBuildingBlockAfterInsertXsdString>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocEvents>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandManifest Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acdManifest.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AllocatedCommandManifestEntry &lt;wne:acdEntry></description></item>
    /// </list>
    /// </remark>
    public partial class AllocatedCommandManifest : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class.
        /// </summary>
        public AllocatedCommandManifest() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommandManifest(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommandManifest(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AllocatedCommandManifest(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "acdManifest");
            builder.AddChild<AllocatedCommandManifestEntry>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandManifest>(deep);
    }

    /// <summary>
    /// <para>Defines the ToolbarData Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:toolbarData.</para>
    /// </summary>
    public partial class ToolbarData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToolbarData class.
        /// </summary>
        public ToolbarData() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "toolbarData");
            builder.AddElement<ToolbarData>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToolbarData>(deep);
    }

    /// <summary>
    /// <para>Defines the KeyMapCustomizations Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:keymaps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>KeyMapEntry &lt;wne:keymap></description></item>
    /// </list>
    /// </remark>
    public partial class KeyMapCustomizations : KeymapsType
    {
        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class.
        /// </summary>
        public KeyMapCustomizations() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapCustomizations(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapCustomizations(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public KeyMapCustomizations(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "keymaps");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapEntry), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<KeyMapCustomizations>(deep);
    }

    /// <summary>
    /// <para>Defines the MismatchedKeyMapCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:keymapsBad.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>KeyMapEntry &lt;wne:keymap></description></item>
    /// </list>
    /// </remark>
    public partial class MismatchedKeyMapCustomization : KeymapsType
    {
        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class.
        /// </summary>
        public MismatchedKeyMapCustomization() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MismatchedKeyMapCustomization(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MismatchedKeyMapCustomization(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MismatchedKeyMapCustomization(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "keymapsBad");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapEntry), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MismatchedKeyMapCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the KeymapsType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>KeyMapEntry &lt;wne:keymap></description></item>
    /// </list>
    /// </remark>
    public abstract partial class KeymapsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the KeymapsType class.
        /// </summary>
        protected KeymapsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeymapsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected KeymapsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeymapsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected KeymapsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeymapsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected KeymapsType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<KeyMapEntry>();
        }
    }

    /// <summary>
    /// <para>Defines the Toolbars Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:toolbars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AllocatedCommandManifest &lt;wne:acdManifest></description></item>
    ///   <item><description>ToolbarData &lt;wne:toolbarData></description></item>
    /// </list>
    /// </remark>
    public partial class Toolbars : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Toolbars class.
        /// </summary>
        public Toolbars() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Toolbars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Toolbars(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Toolbars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Toolbars(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Toolbars class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Toolbars(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "toolbars");
            builder.AddChild<AllocatedCommandManifest>();
            builder.AddChild<ToolbarData>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.ToolbarData), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Toolbars>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommands Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acds.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AllocatedCommand &lt;wne:acd></description></item>
    /// </list>
    /// </remark>
    public partial class AllocatedCommands : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class.
        /// </summary>
        public AllocatedCommands() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommands(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommands(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AllocatedCommands(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "acds");
            builder.AddChild<AllocatedCommand>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommand), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommands>(deep);
    }

    /// <summary>
    /// <para>Defines the RecordIncluded Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:active.</para>
    /// </summary>
    public partial class RecordIncluded : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RecordIncluded class.
        /// </summary>
        public RecordIncluded() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: wne:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public OnOffValue Val
        {
            get => GetAttribute<OnOffValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "active");
            builder.AddElement<RecordIncluded>()
.AddAttribute(33, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordIncluded>(deep);
    }

    /// <summary>
    /// <para>Defines the RecordHashCode Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:hash.</para>
    /// </summary>
    public partial class RecordHashCode : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RecordHashCode class.
        /// </summary>
        public RecordHashCode() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: wne:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public IntegerValue Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "hash");
            builder.AddElement<RecordHashCode>()
.AddAttribute(33, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordHashCode>(deep);
    }

    /// <summary>
    /// <para>Defines the SingleDataSourceRecord Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:recipientData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RecordIncluded &lt;wne:active></description></item>
    ///   <item><description>RecordHashCode &lt;wne:hash></description></item>
    /// </list>
    /// </remark>
    public partial class SingleDataSourceRecord : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class.
        /// </summary>
        public SingleDataSourceRecord() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SingleDataSourceRecord(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SingleDataSourceRecord(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SingleDataSourceRecord(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(33, "recipientData");
            builder.AddChild<RecordIncluded>();
            builder.AddChild<RecordHashCode>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.RecordIncluded), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.RecordHashCode), 1, 1)
            };
        }

        /// <summary>
        /// <para>RecordIncluded.</para>
        /// <para>Represents the following element tag in the schema: wne:active.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public RecordIncluded RecordIncluded
        {
            get => GetElement<RecordIncluded>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RecordHashCode.</para>
        /// <para>Represents the following element tag in the schema: wne:hash.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public RecordHashCode RecordHashCode
        {
            get => GetElement<RecordHashCode>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SingleDataSourceRecord>(deep);
    }
}