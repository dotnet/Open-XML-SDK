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

namespace DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming
{
    /// <summary>
    /// <para>Defines the Key Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pRoam:key.</para>
    /// </summary>
    public partial class Key : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Key class.
        /// </summary>
        public Key() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Key class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Key(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(76, "key");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Key>(deep);
    }

    /// <summary>
    /// <para>Defines the Value Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pRoam:value.</para>
    /// </summary>
    public partial class Value : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Value class.
        /// </summary>
        public Value() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Value(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(76, "value");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Value>(deep);
    }

    /// <summary>
    /// <para>Defines the RoamingProperty Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pRoam:props.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Key &lt;pRoam:key></description></item>
    ///   <item><description>Value &lt;pRoam:value></description></item>
    /// </list>
    /// </remark>
    public partial class RoamingProperty : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RoamingProperty class.
        /// </summary>
        public RoamingProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoamingProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoamingProperty(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoamingProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoamingProperty(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoamingProperty class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RoamingProperty(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(76, "props");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<Key>();
            builder.AddChild<Value>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Key), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Value), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>Key.</para>
        /// <para>Represents the following element tag in the schema: pRoam:key.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pRoam = http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings
        /// </remark>
        public Key Key
        {
            get => GetElement<Key>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Value.</para>
        /// <para>Represents the following element tag in the schema: pRoam:value.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pRoam = http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings
        /// </remark>
        public Value Value
        {
            get => GetElement<Value>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoamingProperty>(deep);
    }
}