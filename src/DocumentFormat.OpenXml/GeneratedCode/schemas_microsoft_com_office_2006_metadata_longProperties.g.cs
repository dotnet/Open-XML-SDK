// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.LongProperties
{
    /// <summary>
    /// <para>Defines the LongProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is lp:LongProperties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LongProperty &lt;lp:LongProp></description></item>
    /// </list>
    /// </remark>
    public partial class LongProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LongProperties class.
        /// </summary>
        public LongProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LongProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LongProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LongProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LongProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LongProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LongProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(40, "LongProperties");
            builder.AddChild<LongProperty>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.LongProperties.LongProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LongProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LongProperty Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is lp:LongProp.</para>
    /// </summary>
    public partial class LongProperty : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LongProperty class.
        /// </summary>
        public LongProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LongProperty class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LongProperty(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(40, "LongProp");
            builder.AddElement<LongProperty>()
.AddAttribute(0, "name", a => a.Name);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LongProperty>(deep);
    }
}