﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Vml.Presentation
{
    /// <summary>
    /// <para>Ink Annotation Flag.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pvml:iscomment.</para>
    /// </summary>
    [SchemaAttr(30, "iscomment")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class InkAnnotationFlag : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the InkAnnotationFlag class.
        /// </summary>
        public InkAnnotationFlag() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkAnnotationFlag>(deep);
    }

    /// <summary>
    /// <para>VML Diagram Text.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pvml:textdata.</para>
    /// </summary>
    [SchemaAttr(30, "textdata")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextData>(deep);
    }
}