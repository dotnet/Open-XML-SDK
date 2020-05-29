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

namespace DocumentFormat.OpenXml.Office.CustomXsn
{
    /// <summary>
    /// <para>Defines the CustomXsn Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ntns:customXsn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>XsnLocation &lt;ntns:xsnLocation></description></item>
    ///   <item><description>CachedView &lt;ntns:cached></description></item>
    ///   <item><description>OpenByDefault &lt;ntns:openByDefault></description></item>
    ///   <item><description>Scope &lt;ntns:xsnScope></description></item>
    /// </list>
    /// </remark>
    public partial class CustomXsn : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomXsn class.
        /// </summary>
        public CustomXsn() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXsn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomXsn(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXsn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomXsn(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXsn class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomXsn(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(39, "customXsn");
            builder.AddChild<XsnLocation>();
            builder.AddChild<CachedView>();
            builder.AddChild<OpenByDefault>();
            builder.AddChild<Scope>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomXsn.XsnLocation), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomXsn.CachedView), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomXsn.OpenByDefault), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomXsn.Scope), 1, 1)
            };
        }

        /// <summary>
        /// <para>XsnLocation.</para>
        /// <para>Represents the following element tag in the schema: ntns:xsnLocation.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
        /// </remark>
        public XsnLocation XsnLocation
        {
            get => GetElement<XsnLocation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CachedView.</para>
        /// <para>Represents the following element tag in the schema: ntns:cached.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
        /// </remark>
        public CachedView CachedView
        {
            get => GetElement<CachedView>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OpenByDefault.</para>
        /// <para>Represents the following element tag in the schema: ntns:openByDefault.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
        /// </remark>
        public OpenByDefault OpenByDefault
        {
            get => GetElement<OpenByDefault>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scope.</para>
        /// <para>Represents the following element tag in the schema: ntns:xsnScope.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
        /// </remark>
        public Scope Scope
        {
            get => GetElement<Scope>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXsn>(deep);
    }

    /// <summary>
    /// <para>Defines the XsnLocation Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ntns:xsnLocation.</para>
    /// </summary>
    public partial class XsnLocation : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the XsnLocation class.
        /// </summary>
        public XsnLocation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the XsnLocation class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public XsnLocation(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(39, "xsnLocation");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsnLocation>(deep);
    }

    /// <summary>
    /// <para>Defines the CachedView Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ntns:cached.</para>
    /// </summary>
    public partial class CachedView : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CachedView class.
        /// </summary>
        public CachedView() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CachedView class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CachedView(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(39, "cached");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedView>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenByDefault Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ntns:openByDefault.</para>
    /// </summary>
    public partial class OpenByDefault : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenByDefault class.
        /// </summary>
        public OpenByDefault() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenByDefault class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public OpenByDefault(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(39, "openByDefault");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OpenByDefault>(deep);
    }

    /// <summary>
    /// <para>Defines the Scope Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ntns:xsnScope.</para>
    /// </summary>
    public partial class Scope : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Scope class.
        /// </summary>
        public Scope() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scope class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Scope(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(39, "xsnScope");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scope>(deep);
    }
}