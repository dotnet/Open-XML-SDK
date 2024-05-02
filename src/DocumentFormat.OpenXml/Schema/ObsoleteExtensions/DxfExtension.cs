// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
    /// <summary>
    /// <para>Defines the DxfExtension Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.Question" /> <c>&lt;xlmsforms:question></c></description></item>
    /// </list>
    /// </remark>
    public partial class DxfExtension : Extension
    {
        /// <summary>
        /// Initializes a new instance of the DxfExtension class.
        /// </summary>
        public DxfExtension()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DxfExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DxfExtension(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DxfExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DxfExtension(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DxfExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DxfExtension(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Gets or sets URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public new StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x:ext");
            builder.AddChild<DocumentFormat.OpenXml.Office.Y2022.FeaturePropertyBag.DXFComplement>();
            builder.AddElement<DxfExtension>()
                .AddAttribute("uri", a => a.Uri, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = true });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Y2022.FeaturePropertyBag.DXFComplement), 1, 1, version: FileFormatVersions.Microsoft365),
                new AnyParticle(0, 1),
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DxfExtension>(deep);
    }
}
