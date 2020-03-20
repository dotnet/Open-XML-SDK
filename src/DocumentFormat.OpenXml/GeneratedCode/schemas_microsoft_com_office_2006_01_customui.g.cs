﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
    /// <summary>
    /// <para>Defines the UnsizedControlClone Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:control.</para>
    /// </summary>
    [SchemaAttr(34, "control")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class UnsizedControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedControlClone class.
        /// </summary>
        public UnsizedControlClone() : base()
        {
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(0)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(1)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(3)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(4)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(5)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(6)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(7)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(8)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(9)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(10)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(11)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(12)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(13)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(14)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(15)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(16)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(17)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(18)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(19)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(20)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(21)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(22)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(23)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(24)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(25)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedButton Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:button.</para>
    /// </summary>
    [SchemaAttr(34, "button")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class UnsizedButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedButton class.
        /// </summary>
        public UnsizedButton() : base()
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(5)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(6)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(7)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(8)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(9)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(10)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(11)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(29)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedButton>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckBox Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:checkBox.</para>
    /// </summary>
    [SchemaAttr(34, "checkBox")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CheckBox class.
        /// </summary>
        public CheckBox() : base()
        {
        }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(0)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(1)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(6)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(7)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(8)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(9)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(14)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(15)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(16)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(17)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(18)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(19)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(20)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(21)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(22)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(23)]
        public StringValue GetKeytip { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedGallery Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso:item></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [SchemaAttr(34, "gallery")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class UnsizedGallery : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class.
        /// </summary>
        public UnsizedGallery() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedGallery(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedGallery(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UnsizedGallery(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(0)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(1)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(2)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>columns</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "columns")]
        [Index(3)]
        public IntegerValue Columns { get; set; }

        /// <summary>
        /// <para>rows</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "rows")]
        [Index(4)]
        public IntegerValue Rows { get; set; }

        /// <summary>
        /// <para>itemWidth</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemWidth")]
        [Index(5)]
        public IntegerValue ItemWidth { get; set; }

        /// <summary>
        /// <para>itemHeight</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemHeight")]
        [Index(6)]
        public IntegerValue ItemHeight { get; set; }

        /// <summary>
        /// <para>getItemWidth</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemWidth")]
        [Index(7)]
        public StringValue GetItemWidth { get; set; }

        /// <summary>
        /// <para>getItemHeight</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemHeight")]
        [Index(8)]
        public StringValue GetItemHeight { get; set; }

        /// <summary>
        /// <para>showItemLabel</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr(0, "showItemLabel")]
        [Index(9)]
        public BooleanValue ShowItemLabel { get; set; }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(10)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(11)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(12)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(13)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(14)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(15)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(16)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(17)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(18)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(19)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(20)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(21)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(22)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(23)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getSelectedItemID</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemID")]
        [Index(24)]
        public StringValue GetSelectedItemID { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(25)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(26)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(27)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(28)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(29)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(30)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(31)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(32)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(33)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(34)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(35)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(36)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(37)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(38)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(39)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(40)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(41)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(42)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(43)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(44)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(45)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(46)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(47)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 0, 16)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedGallery>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedToggleButton Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:toggleButton.</para>
    /// </summary>
    [SchemaAttr(34, "toggleButton")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class UnsizedToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedToggleButton class.
        /// </summary>
        public UnsizedToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(0)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(1)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(9)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(10)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(11)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(12)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(23)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(24)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(25)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(26)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(27)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(28)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(29)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(30)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuSeparator Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menuSeparator.</para>
    /// </summary>
    [SchemaAttr(34, "menuSeparator")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class MenuSeparator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuSeparator class.
        /// </summary>
        public MenuSeparator() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(2)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(3)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(4)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(5)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "title")]
        [Index(6)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>getTitle</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTitle")]
        [Index(7)]
        public StringValue GetTitle { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparator>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedSplitButton Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VisibleButton &lt;mso:button></description></item>
    ///   <item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>UnsizedMenu &lt;mso:menu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [SchemaAttr(34, "splitButton")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class UnsizedSplitButton : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class.
        /// </summary>
        public UnsizedSplitButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedSplitButton(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedSplitButton(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UnsizedSplitButton(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(0)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(1)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(4)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(5)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(6)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(7)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(8)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(9)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(12)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(13)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(14)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(15)]
        public StringValue GetShowLabel { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedSplitButton>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedMenu Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsizedControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>CheckBox &lt;mso:checkBox></description></item>
    ///   <item><description>UnsizedGallery &lt;mso:gallery></description></item>
    ///   <item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
    ///   <item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
    ///   <item><description>UnsizedMenu &lt;mso:menu></description></item>
    ///   <item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [SchemaAttr(34, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class UnsizedMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class.
        /// </summary>
        public UnsizedMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UnsizedMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(1)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(2)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(3)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(4)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(5)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(6)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(14)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(15)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(29)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                        }
                    },
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                        }
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedDynamicMenu Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr(34, "dynamicMenu")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class UnsizedDynamicMenu : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedDynamicMenu class.
        /// </summary>
        public UnsizedDynamicMenu() : base()
        {
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(0)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(1)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(4)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(5)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>getContent</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getContent")]
        [Index(6)]
        public StringValue GetContent { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(7)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(8)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(9)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(10)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(11)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(12)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(13)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(14)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(15)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(16)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(23)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(24)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(25)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(26)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(27)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(28)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(29)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(30)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedDynamicMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the SplitButtonWithTitle Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VisibleButton &lt;mso:button></description></item>
    ///   <item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>MenuWithTitle &lt;mso:menu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(MenuWithTitle))]
    [SchemaAttr(34, "splitButton")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SplitButtonWithTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class.
        /// </summary>
        public SplitButtonWithTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonWithTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonWithTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SplitButtonWithTitle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(0)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(1)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(4)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(5)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(6)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(7)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(8)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(9)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(12)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(13)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(14)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(15)]
        public StringValue GetShowLabel { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonWithTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuWithTitle Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsizedControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>CheckBox &lt;mso:checkBox></description></item>
    ///   <item><description>UnsizedGallery &lt;mso:gallery></description></item>
    ///   <item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
    ///   <item><description>SplitButtonWithTitle &lt;mso:splitButton></description></item>
    ///   <item><description>MenuWithTitle &lt;mso:menu></description></item>
    ///   <item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(SplitButtonWithTitle))]
    [ChildElementInfo(typeof(MenuWithTitle))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [SchemaAttr(34, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class MenuWithTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class.
        /// </summary>
        public MenuWithTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuWithTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuWithTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MenuWithTitle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(2)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(3)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "title")]
        [Index(5)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>getTitle</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTitle")]
        [Index(6)]
        public StringValue GetTitle { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(14)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(15)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(29)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                        }
                    },
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                        }
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuWithTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlClone Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:control.</para>
    /// </summary>
    [SchemaAttr(34, "control")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlClone class.
        /// </summary>
        public ControlClone() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(9)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(10)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(11)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(29)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the TextLabel Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:labelControl.</para>
    /// </summary>
    [SchemaAttr(34, "labelControl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TextLabel : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextLabel class.
        /// </summary>
        public TextLabel() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(2)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(3)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(4)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(5)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(6)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(7)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(8)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(9)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(10)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(11)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(12)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(13)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(14)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(15)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(16)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(17)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(18)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(19)]
        public StringValue GetShowLabel { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the Button Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:button.</para>
    /// </summary>
    [SchemaAttr(34, "button")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Button : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Button class.
        /// </summary>
        public Button() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(2)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(3)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(4)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(5)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(6)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(10)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(11)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(12)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(13)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(14)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(15)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(16)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(17)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(18)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(19)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(20)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(21)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(22)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(23)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(24)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(25)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(26)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(27)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(28)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(29)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(30)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(31)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Button>(deep);
    }

    /// <summary>
    /// <para>Defines the ToggleButton Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:toggleButton.</para>
    /// </summary>
    [SchemaAttr(34, "toggleButton")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToggleButton class.
        /// </summary>
        public ToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(2)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(3)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(4)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(5)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(6)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(7)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(8)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(9)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(10)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(11)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(12)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(13)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(14)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(15)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(16)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(17)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(18)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(19)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(20)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(21)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(22)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(23)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(24)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(25)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(26)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(27)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(28)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(29)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(30)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(31)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(32)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the EditBox Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:editBox.</para>
    /// </summary>
    [SchemaAttr(34, "editBox")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class EditBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EditBox class.
        /// </summary>
        public EditBox() : base()
        {
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(0)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(1)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(2)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(3)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(4)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>maxLength</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "maxLength")]
        [Index(5)]
        public IntegerValue MaxLength { get; set; }

        /// <summary>
        /// <para>getText</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getText")]
        [Index(6)]
        public StringValue GetText { get; set; }

        /// <summary>
        /// <para>onChange</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onChange")]
        [Index(7)]
        public StringValue OnChange { get; set; }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(8)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(9)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(10)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(11)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(12)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(23)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(24)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(25)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(26)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(27)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(28)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(29)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(30)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EditBox>(deep);
    }

    /// <summary>
    /// <para>Defines the ComboBox Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:comboBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso:item></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item))]
    [SchemaAttr(34, "comboBox")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ComboBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ComboBox class.
        /// </summary>
        public ComboBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ComboBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ComboBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComboBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ComboBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(0)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(1)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(2)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(3)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(4)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(5)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(6)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(7)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(8)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(9)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(10)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(11)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(12)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(13)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>maxLength</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "maxLength")]
        [Index(14)]
        public IntegerValue MaxLength { get; set; }

        /// <summary>
        /// <para>getText</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getText")]
        [Index(15)]
        public StringValue GetText { get; set; }

        /// <summary>
        /// <para>onChange</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onChange")]
        [Index(16)]
        public StringValue OnChange { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(17)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(18)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(19)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(20)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(21)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(22)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(23)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(24)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(25)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(26)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(27)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(28)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(29)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(30)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(31)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(32)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(33)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(34)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(35)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(36)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(37)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(38)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ComboBox>(deep);
    }

    /// <summary>
    /// <para>Defines the DropDown Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dropDown.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso:item></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [SchemaAttr(34, "dropDown")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DropDown : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DropDown class.
        /// </summary>
        public DropDown() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDown(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDown(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDown class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DropDown(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(3)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(4)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(5)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(6)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(7)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(8)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(9)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(10)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(11)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(12)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(13)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getSelectedItemID</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemID")]
        [Index(14)]
        public StringValue GetSelectedItemID { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(15)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>showItemLabel</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr(0, "showItemLabel")]
        [Index(16)]
        public BooleanValue ShowItemLabel { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(17)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(18)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(19)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(20)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(21)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(22)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(23)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(24)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(25)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(26)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(27)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(28)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(29)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(30)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(31)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(32)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(33)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(34)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(35)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(36)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(37)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(38)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 0, 16)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropDown>(deep);
    }

    /// <summary>
    /// <para>Defines the Gallery Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso:item></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [SchemaAttr(34, "gallery")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Gallery : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Gallery class.
        /// </summary>
        public Gallery() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Gallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Gallery(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Gallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Gallery(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Gallery class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Gallery(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(2)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(3)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(4)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>columns</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "columns")]
        [Index(5)]
        public IntegerValue Columns { get; set; }

        /// <summary>
        /// <para>rows</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "rows")]
        [Index(6)]
        public IntegerValue Rows { get; set; }

        /// <summary>
        /// <para>itemWidth</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemWidth")]
        [Index(7)]
        public IntegerValue ItemWidth { get; set; }

        /// <summary>
        /// <para>itemHeight</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemHeight")]
        [Index(8)]
        public IntegerValue ItemHeight { get; set; }

        /// <summary>
        /// <para>getItemWidth</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemWidth")]
        [Index(9)]
        public StringValue GetItemWidth { get; set; }

        /// <summary>
        /// <para>getItemHeight</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemHeight")]
        [Index(10)]
        public StringValue GetItemHeight { get; set; }

        /// <summary>
        /// <para>showItemLabel</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr(0, "showItemLabel")]
        [Index(11)]
        public BooleanValue ShowItemLabel { get; set; }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(12)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(13)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(14)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(15)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(16)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(17)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(18)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(19)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(20)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(21)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(22)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(23)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(24)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(25)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getSelectedItemID</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemID")]
        [Index(26)]
        public StringValue GetSelectedItemID { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(27)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(28)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(29)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(30)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(31)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(32)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(33)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(34)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(35)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(36)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(37)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(38)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(39)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(40)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(41)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(42)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(43)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(44)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(45)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(46)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(47)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(48)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(49)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 0, 16)
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Gallery>(deep);
    }

    /// <summary>
    /// <para>Defines the Menu Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsizedControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>CheckBox &lt;mso:checkBox></description></item>
    ///   <item><description>UnsizedGallery &lt;mso:gallery></description></item>
    ///   <item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
    ///   <item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
    ///   <item><description>UnsizedMenu &lt;mso:menu></description></item>
    ///   <item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [SchemaAttr(34, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Menu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Menu class.
        /// </summary>
        public Menu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Menu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Menu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Menu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Menu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Menu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Menu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(5)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(6)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(7)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(8)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(9)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(10)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(11)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(16)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(17)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(18)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(19)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(20)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(21)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(22)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(23)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(24)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(25)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(26)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(27)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(28)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(29)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(30)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(31)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 0, 1000)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                            }
                        }
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Menu>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicMenu Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr(34, "dynamicMenu")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DynamicMenu : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicMenu class.
        /// </summary>
        public DynamicMenu() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(2)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(3)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(4)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(5)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(6)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(7)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>getContent</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getContent")]
        [Index(8)]
        public StringValue GetContent { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(9)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(10)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(11)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(12)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(17)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(18)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(19)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(20)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(21)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(22)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(23)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(24)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(25)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(26)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(27)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(28)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(29)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(30)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(31)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(32)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the SplitButton Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VisibleButton &lt;mso:button></description></item>
    ///   <item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>UnsizedMenu &lt;mso:menu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [SchemaAttr(34, "splitButton")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SplitButton : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitButton class.
        /// </summary>
        public SplitButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButton(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButton(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButton class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SplitButton(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(4)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(5)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(6)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(7)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(8)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(9)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(10)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(11)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(12)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(13)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(14)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(15)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(16)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(17)]
        public StringValue GetShowLabel { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 0, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton), 1, 1)
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButton>(deep);
    }

    /// <summary>
    /// <para>Defines the Box Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:box.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlClone &lt;mso:control></description></item>
    ///   <item><description>TextLabel &lt;mso:labelControl></description></item>
    ///   <item><description>Button &lt;mso:button></description></item>
    ///   <item><description>ToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>CheckBox &lt;mso:checkBox></description></item>
    ///   <item><description>EditBox &lt;mso:editBox></description></item>
    ///   <item><description>ComboBox &lt;mso:comboBox></description></item>
    ///   <item><description>DropDown &lt;mso:dropDown></description></item>
    ///   <item><description>Gallery &lt;mso:gallery></description></item>
    ///   <item><description>Menu &lt;mso:menu></description></item>
    ///   <item><description>DynamicMenu &lt;mso:dynamicMenu></description></item>
    ///   <item><description>SplitButton &lt;mso:splitButton></description></item>
    ///   <item><description>Box &lt;mso:box></description></item>
    ///   <item><description>ButtonGroup &lt;mso:buttonGroup></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlClone))]
    [ChildElementInfo(typeof(TextLabel))]
    [ChildElementInfo(typeof(Button))]
    [ChildElementInfo(typeof(ToggleButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(EditBox))]
    [ChildElementInfo(typeof(ComboBox))]
    [ChildElementInfo(typeof(DropDown))]
    [ChildElementInfo(typeof(Gallery))]
    [ChildElementInfo(typeof(Menu))]
    [ChildElementInfo(typeof(DynamicMenu))]
    [ChildElementInfo(typeof(SplitButton))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(ButtonGroup))]
    [SchemaAttr(34, "box")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Box : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Box class.
        /// </summary>
        public Box() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Box(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(2)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(3)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>boxStyle</para>
        /// <para>Represents the following attribute in the schema: boxStyle</para>
        /// </summary>
        [SchemaAttr(0, "boxStyle")]
        [Index(8)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues> BoxStyle { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Group, 0, 1000)
        {
            new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ControlClone), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.TextLabel), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Button), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ToggleButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.EditBox), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ComboBox), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DropDown), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Gallery), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Menu), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Box), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);
    }

    /// <summary>
    /// <para>Defines the ButtonGroup Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:buttonGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsizedControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>UnsizedGallery &lt;mso:gallery></description></item>
    ///   <item><description>UnsizedMenu &lt;mso:menu></description></item>
    ///   <item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
    ///   <item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [SchemaAttr(34, "buttonGroup")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ButtonGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ButtonGroup class.
        /// </summary>
        public ButtonGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ButtonGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ButtonGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ButtonGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ButtonGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ButtonGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ButtonGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(2)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(3)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQ { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuRoot Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsizedControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>CheckBox &lt;mso:checkBox></description></item>
    ///   <item><description>UnsizedGallery &lt;mso:gallery></description></item>
    ///   <item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
    ///   <item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
    ///   <item><description>UnsizedMenu &lt;mso:menu></description></item>
    ///   <item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [SchemaAttr(34, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class MenuRoot : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuRoot class.
        /// </summary>
        public MenuRoot() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRoot(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRoot(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRoot class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MenuRoot(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "title")]
        [Index(0)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>getTitle</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTitle")]
        [Index(1)]
        public StringValue GetTitle { get; set; }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                    }
                },
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRoot>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomUI Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:customUI.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RepurposedCommands &lt;mso:commands></description></item>
    ///   <item><description>Ribbon &lt;mso:ribbon></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RepurposedCommands))]
    [ChildElementInfo(typeof(Ribbon))]
    [SchemaAttr(34, "customUI")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomUI : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomUI class.
        /// </summary>
        public CustomUI() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomUI class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomUI(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomUI class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomUI(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomUI class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomUI(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onLoad</para>
        /// <para>Represents the following attribute in the schema: onLoad</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onLoad")]
        [Index(0)]
        public StringValue OnLoad { get; set; }

        /// <summary>
        /// <para>loadImage</para>
        /// <para>Represents the following attribute in the schema: loadImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "loadImage")]
        [Index(1)]
        public StringValue LoadImage { get; set; }

        /// <summary>
        /// <para>RepurposedCommands.</para>
        /// <para>Represents the following element tag in the schema: mso:commands.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public RepurposedCommands RepurposedCommands
        {
            get => GetElement<RepurposedCommands>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ribbon.</para>
        /// <para>Represents the following element tag in the schema: mso:ribbon.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public Ribbon Ribbon
        {
            get => GetElement<Ribbon>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Ribbon), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomUI>(deep);
    }

    /// <summary>
    /// <para>Defines the Item Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:item.</para>
    /// </summary>
    [SchemaAttr(34, "item")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Item : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(1)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(2)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(3)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(4)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(5)]
        public StringValue Supertip { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Item>(deep);
    }

    /// <summary>
    /// <para>Defines the VisibleButton Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:button.</para>
    /// </summary>
    [SchemaAttr(34, "button")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VisibleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleButton class.
        /// </summary>
        public VisibleButton() : base()
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(5)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(6)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(7)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(8)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(9)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(10)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(11)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(22)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(23)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(24)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(25)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(26)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(27)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the VisibleToggleButton Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:toggleButton.</para>
    /// </summary>
    [SchemaAttr(34, "toggleButton")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VisibleToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleToggleButton class.
        /// </summary>
        public VisibleToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(0)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(1)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(9)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(10)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(11)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(12)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(23)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(24)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(25)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(26)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(27)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(28)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the VerticalSeparator Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:separator.</para>
    /// </summary>
    [SchemaAttr(34, "separator")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VerticalSeparator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VerticalSeparator class.
        /// </summary>
        public VerticalSeparator() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(2)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(3)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQ { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalSeparator>(deep);
    }

    /// <summary>
    /// <para>Defines the DialogBoxLauncher Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dialogBoxLauncher.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(UnsizedButton))]
    [SchemaAttr(34, "dialogBoxLauncher")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DialogBoxLauncher : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class.
        /// </summary>
        public DialogBoxLauncher() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DialogBoxLauncher(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DialogBoxLauncher(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DialogBoxLauncher(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>UnsizedButton.</para>
        /// <para>Represents the following element tag in the schema: mso:button.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public UnsizedButton UnsizedButton
        {
            get => GetElement<UnsizedButton>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DialogBoxLauncher>(deep);
    }

    /// <summary>
    /// <para>Defines the Group Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlClone &lt;mso:control></description></item>
    ///   <item><description>TextLabel &lt;mso:labelControl></description></item>
    ///   <item><description>Button &lt;mso:button></description></item>
    ///   <item><description>ToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>CheckBox &lt;mso:checkBox></description></item>
    ///   <item><description>EditBox &lt;mso:editBox></description></item>
    ///   <item><description>ComboBox &lt;mso:comboBox></description></item>
    ///   <item><description>DropDown &lt;mso:dropDown></description></item>
    ///   <item><description>Gallery &lt;mso:gallery></description></item>
    ///   <item><description>Menu &lt;mso:menu></description></item>
    ///   <item><description>DynamicMenu &lt;mso:dynamicMenu></description></item>
    ///   <item><description>SplitButton &lt;mso:splitButton></description></item>
    ///   <item><description>Box &lt;mso:box></description></item>
    ///   <item><description>ButtonGroup &lt;mso:buttonGroup></description></item>
    ///   <item><description>VerticalSeparator &lt;mso:separator></description></item>
    ///   <item><description>DialogBoxLauncher &lt;mso:dialogBoxLauncher></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlClone))]
    [ChildElementInfo(typeof(TextLabel))]
    [ChildElementInfo(typeof(Button))]
    [ChildElementInfo(typeof(ToggleButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(EditBox))]
    [ChildElementInfo(typeof(ComboBox))]
    [ChildElementInfo(typeof(DropDown))]
    [ChildElementInfo(typeof(Gallery))]
    [ChildElementInfo(typeof(Menu))]
    [ChildElementInfo(typeof(DynamicMenu))]
    [ChildElementInfo(typeof(SplitButton))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(ButtonGroup))]
    [ChildElementInfo(typeof(VerticalSeparator))]
    [ChildElementInfo(typeof(DialogBoxLauncher))]
    [SchemaAttr(34, "group")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Group : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Group(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(2)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(3)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(4)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(5)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(9)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(10)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(11)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(12)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(17)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(18)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(19)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(20)]
        public StringValue GetKeytip { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ControlClone), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.TextLabel), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Button), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ToggleButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.EditBox), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ComboBox), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DropDown), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Gallery), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Menu), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Box), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup), 1, 1)
                        }
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Defines the QuickAccessToolbarControlClone Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:control.</para>
    /// </summary>
    [SchemaAttr(34, "control")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class QuickAccessToolbarControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbarControlClone class.
        /// </summary>
        public QuickAccessToolbarControlClone() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(2)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(6)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(14)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(15)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(29)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbarControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedQatControls Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:sharedControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>VerticalSeparator &lt;mso:separator></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(34, "sharedControls")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SharedQatControls : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the SharedQatControls class.
        /// </summary>
        public SharedQatControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedQatControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedQatControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedQatControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedQatControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedQatControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SharedQatControls(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedQatControls>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentSpecificQuickAccessToolbarControls Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:documentControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>VerticalSeparator &lt;mso:separator></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(34, "documentControls")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DocumentSpecificQuickAccessToolbarControls : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class.
        /// </summary>
        public DocumentSpecificQuickAccessToolbarControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentSpecificQuickAccessToolbarControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentSpecificQuickAccessToolbarControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocumentSpecificQuickAccessToolbarControls(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentSpecificQuickAccessToolbarControls>(deep);
    }

    /// <summary>
    /// <para>Defines the QatItemsType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>VerticalSeparator &lt;mso:separator></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(QuickAccessToolbarControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(VerticalSeparator))]
    public abstract partial class QatItemsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the QatItemsType class.
        /// </summary>
        protected QatItemsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QatItemsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected QatItemsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QatItemsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected QatItemsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QatItemsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected QatItemsType(string outerXml) : base(outerXml)
        {
        }
    }

    /// <summary>
    /// <para>Defines the Tab Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:tab.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Group &lt;mso:group></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Group))]
    [SchemaAttr(34, "tab")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Tab : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Tab class.
        /// </summary>
        public Tab() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tab(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tab(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tab class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Tab(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(2)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(3)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(4)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(5)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(6)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(7)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(8)]
        public StringValue InsertAfterQ { get; set; }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(9)]
        public StringValue InsertBeforeQ { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(12)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(13)]
        public StringValue GetKeytip { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 100)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Group), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tab>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextualTabSet Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:tabSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Tab &lt;mso:tab></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Tab))]
    [SchemaAttr(34, "tabSet")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ContextualTabSet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class.
        /// </summary>
        public ContextualTabSet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextualTabSet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(0)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(1)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(2)]
        public StringValue GetVisible { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Tab), 0, 50)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabSet>(deep);
    }

    /// <summary>
    /// <para>Defines the RepurposedCommand Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:command.</para>
    /// </summary>
    [SchemaAttr(34, "command")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RepurposedCommand : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RepurposedCommand class.
        /// </summary>
        public RepurposedCommand() : base()
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RepurposedCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMenu Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:officeMenu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsizedControlClone &lt;mso:control></description></item>
    ///   <item><description>UnsizedButton &lt;mso:button></description></item>
    ///   <item><description>CheckBox &lt;mso:checkBox></description></item>
    ///   <item><description>UnsizedGallery &lt;mso:gallery></description></item>
    ///   <item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
    ///   <item><description>SplitButtonWithTitle &lt;mso:splitButton></description></item>
    ///   <item><description>MenuWithTitle &lt;mso:menu></description></item>
    ///   <item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(SplitButtonWithTitle))]
    [ChildElementInfo(typeof(MenuWithTitle))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [SchemaAttr(34, "officeMenu")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OfficeMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMenu class.
        /// </summary>
        public OfficeMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeMenu(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                    }
                },
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the QuickAccessToolbar Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:qat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SharedQatControls &lt;mso:sharedControls></description></item>
    ///   <item><description>DocumentSpecificQuickAccessToolbarControls &lt;mso:documentControls></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SharedQatControls))]
    [ChildElementInfo(typeof(DocumentSpecificQuickAccessToolbarControls))]
    [SchemaAttr(34, "qat")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class QuickAccessToolbar : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class.
        /// </summary>
        public QuickAccessToolbar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuickAccessToolbar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuickAccessToolbar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public QuickAccessToolbar(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>SharedQatControls.</para>
        /// <para>Represents the following element tag in the schema: mso:sharedControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public SharedQatControls SharedQatControls
        {
            get => GetElement<SharedQatControls>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DocumentSpecificQuickAccessToolbarControls.</para>
        /// <para>Represents the following element tag in the schema: mso:documentControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentSpecificQuickAccessToolbarControls DocumentSpecificQuickAccessToolbarControls
        {
            get => GetElement<DocumentSpecificQuickAccessToolbarControls>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbar>(deep);
    }

    /// <summary>
    /// <para>Defines the Tabs Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:tabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Tab &lt;mso:tab></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Tab))]
    [SchemaAttr(34, "tabs")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Tabs : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Tabs class.
        /// </summary>
        public Tabs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tabs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tabs(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tabs class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Tabs(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Tab), 1, 100)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tabs>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextualTabSets Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:contextualTabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ContextualTabSet &lt;mso:tabSet></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ContextualTabSet))]
    [SchemaAttr(34, "contextualTabs")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ContextualTabSets : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class.
        /// </summary>
        public ContextualTabSets() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSets(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSets(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextualTabSets(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet), 1, 100)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabSets>(deep);
    }

    /// <summary>
    /// <para>Defines the RepurposedCommands Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:commands.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RepurposedCommand &lt;mso:command></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RepurposedCommand))]
    [SchemaAttr(34, "commands")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RepurposedCommands : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class.
        /// </summary>
        public RepurposedCommands() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RepurposedCommands(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RepurposedCommands(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RepurposedCommands(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand), 1, 5000)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RepurposedCommands>(deep);
    }

    /// <summary>
    /// <para>Defines the Ribbon Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:ribbon.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfficeMenu &lt;mso:officeMenu></description></item>
    ///   <item><description>QuickAccessToolbar &lt;mso:qat></description></item>
    ///   <item><description>Tabs &lt;mso:tabs></description></item>
    ///   <item><description>ContextualTabSets &lt;mso:contextualTabs></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OfficeMenu))]
    [ChildElementInfo(typeof(QuickAccessToolbar))]
    [ChildElementInfo(typeof(Tabs))]
    [ChildElementInfo(typeof(ContextualTabSets))]
    [SchemaAttr(34, "ribbon")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Ribbon : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Ribbon class.
        /// </summary>
        public Ribbon() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ribbon class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ribbon(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ribbon class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ribbon(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ribbon class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Ribbon(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>startFromScratch</para>
        /// <para>Represents the following attribute in the schema: startFromScratch</para>
        /// </summary>
        [SchemaAttr(0, "startFromScratch")]
        [Index(0)]
        public BooleanValue StartFromScratch { get; set; }

        /// <summary>
        /// <para>OfficeMenu.</para>
        /// <para>Represents the following element tag in the schema: mso:officeMenu.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public OfficeMenu OfficeMenu
        {
            get => GetElement<OfficeMenu>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>QuickAccessToolbar.</para>
        /// <para>Represents the following element tag in the schema: mso:qat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public QuickAccessToolbar QuickAccessToolbar
        {
            get => GetElement<QuickAccessToolbar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tabs.</para>
        /// <para>Represents the following element tag in the schema: mso:tabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public Tabs Tabs
        {
            get => GetElement<Tabs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ContextualTabSets.</para>
        /// <para>Represents the following element tag in the schema: mso:contextualTabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public ContextualTabSets ContextualTabSets
        {
            get => GetElement<ContextualTabSets>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.All, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Tabs), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ribbon>(deep);
    }

    /// <summary>
    /// Defines the SizeValues enumeration.
    /// </summary>
    public enum SizeValues
    {
        ///<summary>
        ///normal.
        ///<para>When the item is serialized out as xml, its value is "normal".</para>
        ///</summary>
        [EnumString("normal")]
        Normal,
        ///<summary>
        ///large.
        ///<para>When the item is serialized out as xml, its value is "large".</para>
        ///</summary>
        [EnumString("large")]
        Large,
    }

    /// <summary>
    /// Defines the ItemSizeValues enumeration.
    /// </summary>
    public enum ItemSizeValues
    {
        ///<summary>
        ///normal.
        ///<para>When the item is serialized out as xml, its value is "normal".</para>
        ///</summary>
        [EnumString("normal")]
        Normal,
        ///<summary>
        ///large.
        ///<para>When the item is serialized out as xml, its value is "large".</para>
        ///</summary>
        [EnumString("large")]
        Large,
    }

    /// <summary>
    /// Defines the BoxStyleValues enumeration.
    /// </summary>
    public enum BoxStyleValues
    {
        ///<summary>
        ///horizontal.
        ///<para>When the item is serialized out as xml, its value is "horizontal".</para>
        ///</summary>
        [EnumString("horizontal")]
        Horizontal,
        ///<summary>
        ///vertical.
        ///<para>When the item is serialized out as xml, its value is "vertical".</para>
        ///</summary>
        [EnumString("vertical")]
        Vertical,
    }
}