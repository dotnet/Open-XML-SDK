// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Vml.Presentation
{
    /// <summary>
    /// <para>Ink Annotation Flag.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pvml:iscomment.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(30, "iscomment")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InkAnnotationFlag : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the InkAnnotationFlag class.
        /// </summary>
        public InkAnnotationFlag() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(30, "iscomment");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkAnnotationFlag>(deep);
    }

    /// <summary>
    /// <para>VML Diagram Text.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pvml:textdata.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(30, "textdata")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextData class.
        /// </summary>
        public TextData() : base()
        {
        }

        /// <summary>
        /// <para>Text Reference</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(30, "textdata");
            builder.AddElement<TextData>()
.AddAttribute(0, "id", a => a.Id);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextData>(deep);
    }
}