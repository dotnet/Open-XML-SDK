// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Theme
{
    /// <summary>
    /// <para>Defines the ThemeFamily Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is thm15:themeFamily.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfficeArtExtensionList &lt;thm15:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
    [SchemaAttr(73, "themeFamily")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ThemeFamily : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThemeFamily class.
        /// </summary>
        public ThemeFamily() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeFamily class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThemeFamily(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeFamily class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThemeFamily(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeFamily class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThemeFamily(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name { get => GetAttribute<StringValue>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id { get => GetAttribute<StringValue>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>vid, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: vid</para>
        /// </summary>
        public StringValue Vid { get => GetAttribute<StringValue>(); set => SetAttribute(value); }
        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<ThemeFamily>();

        internal override void ConfigureMetadata(ElementMetadataBuilder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<ThemeFamily>()
                           .AddAttribute(0, "name", a => a.Name, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           })
                           .AddAttribute(0, "id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                               aBuilder.AddValidator(new StringValidatorAttribute() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                           })
                           .AddAttribute(0, "vid", a => a.Vid, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                               aBuilder.AddValidator(new StringValidatorAttribute() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                           });
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: thm15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:thm15 = http://schemas.microsoft.com/office/thememl/2012/main
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        private static readonly ISemanticConstraint[] _semanticConstraint = new ISemanticConstraint[] {
            new AttributeValueLengthConstraint(1 /*:id*/, 1, 100) { Application = ApplicationType.Excel | ApplicationType.PowerPoint, Version = FileFormatVersions.Office2013 }
        };

        internal override ISemanticConstraint[] SemanticConstraints => _semanticConstraint;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThemeFamily>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is thm15:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
    [SchemaAttr(73, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<OfficeArtExtensionList>();

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ThemeVariant Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is thm15:themeVariant.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfficeArtExtensionList &lt;thm15:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
    [SchemaAttr(73, "themeVariant")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ThemeVariant : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThemeVariant class.
        /// </summary>
        public ThemeVariant() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeVariant class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThemeVariant(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeVariant class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThemeVariant(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeVariant class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThemeVariant(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name { get => GetAttribute<StringValue>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>vid, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: vid</para>
        /// </summary>
        public StringValue Vid { get => GetAttribute<StringValue>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>cx, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        public Int64Value X { get => GetAttribute<Int64Value>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>cy, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        public Int64Value Y { get => GetAttribute<Int64Value>(); set => SetAttribute(value); }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id { get => GetAttribute<StringValue>(); set => SetAttribute(value); }
        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<ThemeVariant>();

        internal override void ConfigureMetadata(ElementMetadataBuilder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<ThemeVariant>()
                           .AddAttribute(0, "name", a => a.Name, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           })
                           .AddAttribute(0, "vid", a => a.Vid, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                               aBuilder.AddValidator(new StringValidatorAttribute() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                           })
                           .AddAttribute(0, "cx", a => a.X, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                               aBuilder.AddValidator(new NumberValidatorAttribute() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           })
                           .AddAttribute(0, "cy", a => a.Y, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                               aBuilder.AddValidator(new NumberValidatorAttribute() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           })
                           .AddAttribute(19, "id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           });
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: thm15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:thm15 = http://schemas.microsoft.com/office/thememl/2012/main
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThemeVariant>(deep);
    }

    /// <summary>
    /// <para>Defines the ThemeVariantList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is thm15:themeVariantLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ThemeVariant &lt;thm15:themeVariant></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ThemeVariant), FileFormatVersions.Office2013)]
    [SchemaAttr(73, "themeVariantLst")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ThemeVariantList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThemeVariantList class.
        /// </summary>
        public ThemeVariantList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeVariantList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThemeVariantList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeVariantList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThemeVariantList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThemeVariantList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThemeVariantList(string outerXml) : base(outerXml)
        {
        }

        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<ThemeVariantList>();

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Theme.ThemeVariant), 1, 0, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThemeVariantList>(deep);
    }
}