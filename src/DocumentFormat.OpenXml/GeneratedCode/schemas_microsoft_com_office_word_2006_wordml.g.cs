﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
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
    [ChildElementInfo(typeof(KeyMapCustomizations))]
    [ChildElementInfo(typeof(MismatchedKeyMapCustomization))]
    [ChildElementInfo(typeof(Toolbars))]
    [ChildElementInfo(typeof(AllocatedCommands))]
    [SchemaAttr(33, "tcg")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Toolbars), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommands), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

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
    [ChildElementInfo(typeof(Mcd))]
    [SchemaAttr(33, "mcds")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Mcd), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

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
    [ChildElementInfo(typeof(DocEvents))]
    [ChildElementInfo(typeof(Mcds))]
    [SchemaAttr(33, "vbaSuppData")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.DocEvents), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Mcds), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

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
    [ChildElementInfo(typeof(SingleDataSourceRecord))]
    [SchemaAttr(33, "recipients")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MailMergeRecipients>(deep);
    }

    /// <summary>
    /// <para>Defines the FixedCommandKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:fci.</para>
    /// </summary>
    [SchemaAttr(33, "fci")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [SchemaAttr(33, "fciName")]
        [Index(0)]
        public StringValue CommandName { get; set; }

        /// <summary>
        /// <para>fciIndex</para>
        /// <para>Represents the following attribute in the schema: wne:fciIndex</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 2L)]
        [SchemaAttr(33, "fciIndex")]
        [Index(1)]
        public HexBinaryValue CommandIndex { get; set; }

        /// <summary>
        /// <para>swArg</para>
        /// <para>Represents the following attribute in the schema: wne:swArg</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 2L)]
        [SchemaAttr(33, "swArg")]
        [Index(2)]
        public HexBinaryValue Argument { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FixedCommandKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the MacroKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:macro.</para>
    /// </summary>
    [SchemaAttr(33, "macro")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class MacroKeyboardCustomization : MacroWllType
    {
        /// <summary>
        /// Initializes a new instance of the MacroKeyboardCustomization class.
        /// </summary>
        public MacroKeyboardCustomization() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MacroKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the WllMacroKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:wll.</para>
    /// </summary>
    [SchemaAttr(33, "wll")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class WllMacroKeyboardCustomization : MacroWllType
    {
        /// <summary>
        /// Initializes a new instance of the WllMacroKeyboardCustomization class.
        /// </summary>
        public WllMacroKeyboardCustomization() : base()
        {
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
        [SchemaAttr(33, "macroName")]
        [Index(0)]
        public StringValue MacroName { get; set; }
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acd.</para>
    /// </summary>
    [SchemaAttr(33, "acd")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AllocatedCommandKeyboardCustomization : AcceleratorKeymapType
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandKeyboardCustomization class.
        /// </summary>
        public AllocatedCommandKeyboardCustomization() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandManifestEntry Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acdEntry.</para>
    /// </summary>
    [SchemaAttr(33, "acdEntry")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AllocatedCommandManifestEntry : AcceleratorKeymapType
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifestEntry class.
        /// </summary>
        public AllocatedCommandManifestEntry() : base()
        {
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
        [SchemaAttr(33, "acdName")]
        [Index(0)]
        public StringValue AcceleratorName { get; set; }
    }

    /// <summary>
    /// <para>Defines the CharacterInsertion Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:wch.</para>
    /// </summary>
    [SchemaAttr(33, "wch")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [RequiredValidator()]
        [StringValidator(Length = 4L)]
        [SchemaAttr(33, "val")]
        [Index(0)]
        public HexBinaryValue Val { get; set; }

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
    [ChildElementInfo(typeof(FixedCommandKeyboardCustomization))]
    [ChildElementInfo(typeof(MacroKeyboardCustomization))]
    [ChildElementInfo(typeof(AllocatedCommandKeyboardCustomization))]
    [ChildElementInfo(typeof(WllMacroKeyboardCustomization))]
    [ChildElementInfo(typeof(CharacterInsertion))]
    [SchemaAttr(33, "keymap")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [StringValidator(Length = 2L)]
        [SchemaAttr(33, "chmPrimary")]
        [Index(0)]
        public HexBinaryValue CharacterMapPrimary { get; set; }

        /// <summary>
        /// <para>chmSecondary</para>
        /// <para>Represents the following attribute in the schema: wne:chmSecondary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 2L)]
        [SchemaAttr(33, "chmSecondary")]
        [Index(1)]
        public HexBinaryValue CharacterMapSecondary { get; set; }

        /// <summary>
        /// <para>kcmPrimary</para>
        /// <para>Represents the following attribute in the schema: wne:kcmPrimary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 2L)]
        [SchemaAttr(33, "kcmPrimary")]
        [Index(2)]
        public HexBinaryValue KeyCodePrimary { get; set; }

        /// <summary>
        /// <para>kcmSecondary</para>
        /// <para>Represents the following attribute in the schema: wne:kcmSecondary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 2L)]
        [SchemaAttr(33, "kcmSecondary")]
        [Index(3)]
        public HexBinaryValue KeyCodeSecondary { get; set; }

        /// <summary>
        /// <para>mask</para>
        /// <para>Represents the following attribute in the schema: wne:mask</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr(33, "mask")]
        [Index(4)]
        public OnOffValue Mask { get; set; }

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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.CharacterInsertion), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<KeyMapEntry>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommand Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acd.</para>
    /// </summary>
    [SchemaAttr(33, "acd")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [SchemaAttr(33, "argValue")]
        [Index(0)]
        public StringValue ArgumentValue { get; set; }

        /// <summary>
        /// <para>fciBasedOn</para>
        /// <para>Represents the following attribute in the schema: wne:fciBasedOn</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr(33, "fciBasedOn")]
        [Index(1)]
        public StringValue CommandBasedOn { get; set; }

        /// <summary>
        /// <para>fciIndexBasedOn</para>
        /// <para>Represents the following attribute in the schema: wne:fciIndexBasedOn</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 2L)]
        [SchemaAttr(33, "fciIndexBasedOn")]
        [Index(2)]
        public HexBinaryValue CommandIndexBasedOn { get; set; }

        /// <summary>
        /// <para>acdName</para>
        /// <para>Represents the following attribute in the schema: wne:acdName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr(33, "acdName")]
        [Index(3)]
        public StringValue AcceleratorName { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the Mcd Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:mcd.</para>
    /// </summary>
    [SchemaAttr(33, "mcd")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [SchemaAttr(33, "macroName")]
        [Index(0)]
        public StringValue MacroName { get; set; }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: wne:name</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr(33, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>menuHelp</para>
        /// <para>Represents the following attribute in the schema: wne:menuHelp</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr(33, "menuHelp")]
        [Index(2)]
        public StringValue MenuHelp { get; set; }

        /// <summary>
        /// <para>bEncrypt</para>
        /// <para>Represents the following attribute in the schema: wne:bEncrypt</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 1L)]
        [SchemaAttr(33, "bEncrypt")]
        [Index(3)]
        public HexBinaryValue BEncrypt { get; set; }

        /// <summary>
        /// <para>cmg</para>
        /// <para>Represents the following attribute in the schema: wne:cmg</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [StringValidator(Length = 1L)]
        [SchemaAttr(33, "cmg")]
        [Index(4)]
        public HexBinaryValue Cmg { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mcd>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocNewXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocNew.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocNew")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocNewXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocOpenXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocOpen.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocOpen")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocOpenXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocCloseXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocClose.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocClose")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocCloseXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocSyncXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocSync.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocSync")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocSyncXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocXmlAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocXmlAfterInsert.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocXmlAfterInsert")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocXmlBeforeDeleteXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocXmlBeforeDelete.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocXmlBeforeDelete")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlBeforeDeleteXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlAfterInsert.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocContentControlAfterInsert")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlBeforeDeleteXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlBeforeDelete.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocContentControlBeforeDelete")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlBeforeDeleteXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlOnExistXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlOnExit.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocContentControlOnExit")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnExistXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlOnEnterXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlOnEnter.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocContentControlOnEnter")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnEnterXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocStoreUpdateXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocStoreUpdate.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocStoreUpdate")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocStoreUpdateXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlUpdateXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlContentUpdate.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocContentControlContentUpdate")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlUpdateXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocBuildingBlockAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocBuildingBlockAfterInsert.</para>
    /// </summary>
    [SchemaAttr(33, "eventDocBuildingBlockAfterInsert")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
    [ChildElementInfo(typeof(EventDocNewXsdString))]
    [ChildElementInfo(typeof(EventDocOpenXsdString))]
    [ChildElementInfo(typeof(EventDocCloseXsdString))]
    [ChildElementInfo(typeof(EventDocSyncXsdString))]
    [ChildElementInfo(typeof(EventDocXmlAfterInsertXsdString))]
    [ChildElementInfo(typeof(EventDocXmlBeforeDeleteXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlAfterInsertXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlBeforeDeleteXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlOnExistXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlOnEnterXsdString))]
    [ChildElementInfo(typeof(EventDocStoreUpdateXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlUpdateXsdString))]
    [ChildElementInfo(typeof(EventDocBuildingBlockAfterInsertXsdString))]
    [SchemaAttr(33, "docEvents")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

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
    [ChildElementInfo(typeof(AllocatedCommandManifestEntry))]
    [SchemaAttr(33, "acdManifest")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandManifest>(deep);
    }

    /// <summary>
    /// <para>Defines the ToolbarData Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:toolbarData.</para>
    /// </summary>
    [SchemaAttr(33, "toolbarData")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

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
    [SchemaAttr(33, "keymaps")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapEntry), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

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
    [SchemaAttr(33, "keymapsBad")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapEntry), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

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
    [ChildElementInfo(typeof(KeyMapEntry))]
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
    [ChildElementInfo(typeof(AllocatedCommandManifest))]
    [ChildElementInfo(typeof(ToolbarData))]
    [SchemaAttr(33, "toolbars")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.ToolbarData), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

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
    [ChildElementInfo(typeof(AllocatedCommand))]
    [SchemaAttr(33, "acds")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommand), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommands>(deep);
    }

    /// <summary>
    /// <para>Defines the RecordIncluded Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:active.</para>
    /// </summary>
    [SchemaAttr(33, "active")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [SchemaAttr(33, "val")]
        [Index(0)]
        public OnOffValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordIncluded>(deep);
    }

    /// <summary>
    /// <para>Defines the RecordHashCode Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:hash.</para>
    /// </summary>
    [SchemaAttr(33, "hash")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [RequiredValidator()]
        [SchemaAttr(33, "val")]
        [Index(0)]
        public IntegerValue Val { get; set; }

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
    [ChildElementInfo(typeof(RecordIncluded))]
    [ChildElementInfo(typeof(RecordHashCode))]
    [SchemaAttr(33, "recipientData")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.RecordIncluded), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.RecordHashCode), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SingleDataSourceRecord>(deep);
    }
}