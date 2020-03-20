﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
    /// <summary>
    /// <para>Defines the ControlCloneRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
    [SchemaAttr(57, "control")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ControlCloneRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlCloneRegular class.
        /// </summary>
        public ControlCloneRegular() : base()
        {
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(0)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(1)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(2)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(3)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(4)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(5)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(6)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(7)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(8)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(9)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(10)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(11)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(12)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(13)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(14)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(15)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(16)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(17)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(18)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(19)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(20)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(21)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(22)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(23)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(24)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(25)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlCloneRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the ButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr(57, "button")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ButtonRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ButtonRegular class.
        /// </summary>
        public ButtonRegular() : base()
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(5)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(6)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(7)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(8)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(9)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(10)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(11)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(29)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
    [SchemaAttr(57, "checkBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CheckBox class.
        /// </summary>
        public CheckBox() : base()
        {
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(0)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(1)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(6)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(7)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(8)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(9)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(14)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(15)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(16)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(17)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(18)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(19)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(20)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(21)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(22)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>Defines the GalleryRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso14:item></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "gallery")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class GalleryRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GalleryRegular class.
        /// </summary>
        public GalleryRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GalleryRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GalleryRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GalleryRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GalleryRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GalleryRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GalleryRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(0)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(1)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(2)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>columns, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "columns")]
        [Index(3)]
        public IntegerValue Columns { get; set; }

        /// <summary>
        /// <para>rows, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "rows")]
        [Index(4)]
        public IntegerValue Rows { get; set; }

        /// <summary>
        /// <para>itemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemWidth")]
        [Index(5)]
        public IntegerValue ItemWidth { get; set; }

        /// <summary>
        /// <para>itemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemHeight")]
        [Index(6)]
        public IntegerValue ItemHeight { get; set; }

        /// <summary>
        /// <para>getItemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemWidth")]
        [Index(7)]
        public StringValue GetItemWidth { get; set; }

        /// <summary>
        /// <para>getItemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemHeight")]
        [Index(8)]
        public StringValue GetItemHeight { get; set; }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr(0, "showItemLabel")]
        [Index(9)]
        public BooleanValue ShowItemLabel { get; set; }

        /// <summary>
        /// <para>showInRibbon, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showInRibbon</para>
        /// </summary>
        [SchemaAttr(0, "showInRibbon")]
        [Index(10)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(11)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(12)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(13)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(14)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(15)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(16)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(17)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(18)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(19)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(20)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(21)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(22)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(23)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(24)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemID")]
        [Index(25)]
        public StringValue GetSelectedItemID { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(26)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(27)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(28)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(29)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(30)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(31)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(32)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(33)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(34)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(35)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(36)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(37)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(38)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(39)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(40)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(41)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(42)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(43)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(44)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(45)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(46)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(47)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(48)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GalleryRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the ToggleButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr(57, "toggleButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ToggleButtonRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToggleButtonRegular class.
        /// </summary>
        public ToggleButtonRegular() : base()
        {
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(0)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(1)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(9)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(10)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(11)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(12)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(23)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(24)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(25)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(26)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(27)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(28)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(29)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(30)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuSeparator Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuSeparator.</para>
    /// </summary>
    [SchemaAttr(57, "menuSeparator")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class MenuSeparator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuSeparator class.
        /// </summary>
        public MenuSeparator() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(3)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(4)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(5)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(6)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>title, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "title")]
        [Index(7)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTitle")]
        [Index(8)]
        public StringValue GetTitle { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparator>(deep);
    }

    /// <summary>
    /// <para>Defines the SplitButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VisibleButton &lt;mso14:button></description></item>
    ///   <item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
    ///   <item><description>MenuRegular &lt;mso14:menu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(VisibleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(VisibleToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "splitButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SplitButtonRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class.
        /// </summary>
        public SplitButtonRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SplitButtonRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(0)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(1)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(4)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(5)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(6)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(7)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(8)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(9)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(12)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(13)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(14)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
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
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneRegular &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>CheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>GalleryRegular &lt;mso14:gallery></description></item>
    ///   <item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
    ///   <item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
    ///   <item><description>MenuRegular &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class MenuRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuRegular class.
        /// </summary>
        public MenuRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MenuRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(1)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(2)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(3)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(4)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(5)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(6)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(14)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(15)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
                    new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    },
                    new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicMenuRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr(57, "dynamicMenu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DynamicMenuRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicMenuRegular class.
        /// </summary>
        public DynamicMenuRegular() : base()
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(0)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(1)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(4)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(5)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>getContent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getContent")]
        [Index(6)]
        public StringValue GetContent { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(7)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(8)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(9)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(10)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(11)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(12)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(13)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(14)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(15)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(16)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(23)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(24)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(25)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(26)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(27)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(28)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(29)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(30)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicMenuRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the SplitButtonWithTitle Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VisibleButton &lt;mso14:button></description></item>
    ///   <item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
    ///   <item><description>MenuWithTitle &lt;mso14:menu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(VisibleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(VisibleToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuWithTitle), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "splitButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(0)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(1)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(4)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(5)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(6)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(7)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(8)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(9)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(12)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(13)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(14)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
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
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonWithTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuWithTitle Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneRegular &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>CheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>GalleryRegular &lt;mso14:gallery></description></item>
    ///   <item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
    ///   <item><description>SplitButtonWithTitle &lt;mso14:splitButton></description></item>
    ///   <item><description>MenuWithTitle &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonWithTitle), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuWithTitle), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize { get; set; }

        /// <summary>
        /// <para>title, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "title")]
        [Index(5)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTitle")]
        [Index(6)]
        public StringValue GetTitle { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(14)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(15)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
                    new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    },
                    new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonWithTitle), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
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
    /// <para>Defines the MenuSeparatorNoTitle Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuSeparator.</para>
    /// </summary>
    [SchemaAttr(57, "menuSeparator")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class MenuSeparatorNoTitle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuSeparatorNoTitle class.
        /// </summary>
        public MenuSeparatorNoTitle() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(3)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(4)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(5)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(6)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparatorNoTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlClone Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
    [SchemaAttr(57, "control")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlClone class.
        /// </summary>
        public ControlClone() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(9)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(10)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(11)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>Defines the LabelControl Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:labelControl.</para>
    /// </summary>
    [SchemaAttr(57, "labelControl")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class LabelControl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LabelControl class.
        /// </summary>
        public LabelControl() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(4)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(5)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(6)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(7)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(8)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(9)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(10)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(11)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(12)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(13)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(14)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(15)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(16)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(17)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(18)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(19)]
        public StringValue GetShowLabel { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelControl>(deep);
    }

    /// <summary>
    /// <para>Defines the Button Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr(57, "button")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Button : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Button class.
        /// </summary>
        public Button() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(2)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(3)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(4)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(5)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(6)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(10)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(11)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(12)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(13)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(14)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(15)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(16)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(17)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(18)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(19)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(20)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(21)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(22)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(23)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(24)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(25)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(26)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(27)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(28)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(29)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(30)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr(57, "toggleButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToggleButton class.
        /// </summary>
        public ToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(2)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(3)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(4)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(5)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(6)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(7)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(8)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(9)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(10)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(11)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(12)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(13)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(14)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(15)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(16)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(17)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(18)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(19)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(20)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(21)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(22)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(23)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(24)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(25)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(26)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(27)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(28)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(29)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(30)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(31)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
    /// </summary>
    [SchemaAttr(57, "editBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class EditBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EditBox class.
        /// </summary>
        public EditBox() : base()
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(0)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(1)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(2)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(3)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(4)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "maxLength")]
        [Index(5)]
        public IntegerValue MaxLength { get; set; }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getText")]
        [Index(6)]
        public StringValue GetText { get; set; }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onChange")]
        [Index(7)]
        public StringValue OnChange { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(8)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(9)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(10)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(11)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(12)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(23)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(24)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(25)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(26)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(27)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(28)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(29)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:comboBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso14:item></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "comboBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>showItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(0)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(1)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(2)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(3)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(4)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(5)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(6)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(7)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(8)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(9)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(10)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(11)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(12)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(13)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "maxLength")]
        [Index(14)]
        public IntegerValue MaxLength { get; set; }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getText")]
        [Index(15)]
        public StringValue GetText { get; set; }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onChange")]
        [Index(16)]
        public StringValue OnChange { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(17)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(18)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(19)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(20)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(21)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(22)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(23)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(24)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(25)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(26)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(27)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(28)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(29)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(30)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(31)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(32)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(33)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(34)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(35)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(36)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(37)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ComboBox>(deep);
    }

    /// <summary>
    /// <para>Defines the DropDownRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dropDown.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso14:item></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "dropDown")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DropDownRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DropDownRegular class.
        /// </summary>
        public DropDownRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDownRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDownRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDownRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDownRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDownRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DropDownRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(3)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(4)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(5)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(6)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(7)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(8)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(9)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(10)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(11)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(12)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(13)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemID")]
        [Index(14)]
        public StringValue GetSelectedItemID { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(15)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr(0, "showItemLabel")]
        [Index(16)]
        public BooleanValue ShowItemLabel { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(17)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(18)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(19)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(20)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(21)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(22)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(23)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(24)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(25)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(26)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(27)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(28)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(29)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(30)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(31)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(32)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(33)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(34)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(35)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(36)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(37)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropDownRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the Gallery Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Item &lt;mso14:item></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "gallery")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(2)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(3)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(4)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>columns, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "columns")]
        [Index(5)]
        public IntegerValue Columns { get; set; }

        /// <summary>
        /// <para>rows, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "rows")]
        [Index(6)]
        public IntegerValue Rows { get; set; }

        /// <summary>
        /// <para>itemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemWidth")]
        [Index(7)]
        public IntegerValue ItemWidth { get; set; }

        /// <summary>
        /// <para>itemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 4096L, IsPositive = true)]
        [SchemaAttr(0, "itemHeight")]
        [Index(8)]
        public IntegerValue ItemHeight { get; set; }

        /// <summary>
        /// <para>getItemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemWidth")]
        [Index(9)]
        public StringValue GetItemWidth { get; set; }

        /// <summary>
        /// <para>getItemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemHeight")]
        [Index(10)]
        public StringValue GetItemHeight { get; set; }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr(0, "showItemLabel")]
        [Index(11)]
        public BooleanValue ShowItemLabel { get; set; }

        /// <summary>
        /// <para>showInRibbon, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showInRibbon</para>
        /// </summary>
        [SchemaAttr(0, "showInRibbon")]
        [Index(12)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(13)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(14)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(15)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(16)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(17)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(18)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr(0, "showItemImage")]
        [Index(19)]
        public BooleanValue ShowItemImage { get; set; }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(20)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(21)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemScreentip")]
        [Index(22)]
        public StringValue GetItemScreentip { get; set; }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemSupertip")]
        [Index(23)]
        public StringValue GetItemSupertip { get; set; }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemImage")]
        [Index(24)]
        public StringValue GetItemImage { get; set; }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(25)]
        public StringValue GetItemID { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(26)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemID")]
        [Index(27)]
        public StringValue GetSelectedItemID { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(28)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(29)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(30)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(31)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(32)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(33)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(34)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(35)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(36)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(37)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(38)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(39)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(40)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(41)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(42)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(43)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(44)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(45)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(46)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(47)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(48)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(49)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(50)]
        public StringValue GetShowImage { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneRegular &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>CheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>GalleryRegular &lt;mso14:gallery></description></item>
    ///   <item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
    ///   <item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
    ///   <item><description>MenuRegular &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(5)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(6)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(7)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(8)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(9)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(10)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(11)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(16)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(17)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(18)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(19)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(20)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(21)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(22)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(23)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(24)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(25)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(26)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(27)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(28)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(29)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(30)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
                        new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr(57, "dynamicMenu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DynamicMenu : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicMenu class.
        /// </summary>
        public DynamicMenu() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(2)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(3)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(4)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(5)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(6)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(7)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>getContent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getContent")]
        [Index(8)]
        public StringValue GetContent { get; set; }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr(0, "invalidateContentOnDrop")]
        [Index(9)]
        public BooleanValue InvalidateContentOnDrop { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(10)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(11)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(12)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(17)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(18)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(19)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(20)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(21)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(22)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(23)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(24)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(25)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(26)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(27)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(28)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(29)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(30)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(31)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VisibleButton &lt;mso14:button></description></item>
    ///   <item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
    ///   <item><description>MenuRegular &lt;mso14:menu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(VisibleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(VisibleToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "splitButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(1)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(4)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(5)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(6)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(7)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(8)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(9)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(10)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(11)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(12)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(13)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(14)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(15)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(16)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
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
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButton>(deep);
    }

    /// <summary>
    /// <para>Defines the Box Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:box.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlClone &lt;mso14:control></description></item>
    ///   <item><description>LabelControl &lt;mso14:labelControl></description></item>
    ///   <item><description>Button &lt;mso14:button></description></item>
    ///   <item><description>ToggleButton &lt;mso14:toggleButton></description></item>
    ///   <item><description>CheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>EditBox &lt;mso14:editBox></description></item>
    ///   <item><description>ComboBox &lt;mso14:comboBox></description></item>
    ///   <item><description>DropDownRegular &lt;mso14:dropDown></description></item>
    ///   <item><description>Gallery &lt;mso14:gallery></description></item>
    ///   <item><description>Menu &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenu &lt;mso14:dynamicMenu></description></item>
    ///   <item><description>SplitButton &lt;mso14:splitButton></description></item>
    ///   <item><description>Box &lt;mso14:box></description></item>
    ///   <item><description>ButtonGroup &lt;mso14:buttonGroup></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlClone), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Button), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(EditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropDownRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Gallery), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Menu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Box), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonGroup), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "box")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(3)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(4)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(5)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(6)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(7)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(8)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>boxStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: boxStyle</para>
        /// </summary>
        [SchemaAttr(0, "boxStyle")]
        [Index(9)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues> BoxStyle { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
        {
            new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Button), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.EditBox), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Gallery), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Menu), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Box), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);
    }

    /// <summary>
    /// <para>Defines the ButtonGroup Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:buttonGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneRegular &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
    ///   <item><description>GalleryRegular &lt;mso14:gallery></description></item>
    ///   <item><description>MenuRegular &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
    ///   <item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
    ///   <item><description>Separator &lt;mso14:separator></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Separator), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "buttonGroup")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(3)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(4)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(5)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(6)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(7)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(8)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr(57, "button")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageMenuButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuButton class.
        /// </summary>
        public BackstageMenuButton() : base()
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(0)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(1)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(4)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(5)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr(0, "isDefinitive")]
        [Index(6)]
        public BooleanValue IsDefinitive { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(7)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(8)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(9)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(10)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(11)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(12)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(13)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(14)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(15)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(16)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(17)]
        public StringValue GetImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuCheckBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
    [SchemaAttr(57, "checkBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageMenuCheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuCheckBox class.
        /// </summary>
        public BackstageMenuCheckBox() : base()
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(0)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(1)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(4)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(5)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(6)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(7)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(8)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(9)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(10)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(11)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(12)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(13)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(14)]
        public StringValue GetKeytip { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuCheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageSubMenu Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageMenuGroup &lt;mso14:menuGroup></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageMenuGroup), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageSubMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class.
        /// </summary>
        public BackstageSubMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageSubMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageSubMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageSubMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(0)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(1)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(3)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(4)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(5)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(6)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(7)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(8)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(9)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(10)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(11)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(12)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(13)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(14)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(15)]
        public StringValue GetKeytip { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageSubMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuToggleButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr(57, "toggleButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageMenuToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuToggleButton class.
        /// </summary>
        public BackstageMenuToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(0)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(1)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(2)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(5)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(6)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(7)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(8)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(9)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(10)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(11)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(12)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(13)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(14)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(15)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(16)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(17)]
        public StringValue GetKeytip { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageGroupButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr(57, "button")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageGroupButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageGroupButton class.
        /// </summary>
        public BackstageGroupButton() : base()
        {
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>style, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        [SchemaAttr(0, "style")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values> Style { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(2)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(3)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(4)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(5)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(6)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(7)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(8)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(9)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr(0, "isDefinitive")]
        [Index(10)]
        public BooleanValue IsDefinitive { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(11)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(12)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(13)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(14)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(15)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(16)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(17)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(18)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(19)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(20)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(21)]
        public StringValue GetImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroupButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageCheckBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
    [SchemaAttr(57, "checkBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageCheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageCheckBox class.
        /// </summary>
        public BackstageCheckBox() : base()
        {
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(1)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(2)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(3)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(4)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(5)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(6)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(7)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(8)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(9)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(10)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(11)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(12)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(13)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(14)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(15)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(16)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(17)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(18)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(19)]
        public StringValue GetKeytip { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageCheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageEditBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
    /// </summary>
    [SchemaAttr(57, "editBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageEditBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageEditBox class.
        /// </summary>
        public BackstageEditBox() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr(0, "alignLabel")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(5)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(6)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(7)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(8)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(9)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(10)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(11)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(12)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getText")]
        [Index(13)]
        public StringValue GetText { get; set; }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onChange")]
        [Index(14)]
        public StringValue OnChange { get; set; }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 1024L, IsPositive = true)]
        [SchemaAttr(0, "maxLength")]
        [Index(15)]
        public IntegerValue MaxLength { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(16)]
        public StringValue SizeString { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageEditBox>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageDropDown Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dropDown.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ItemBackstageItem &lt;mso14:item></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ItemBackstageItem), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "dropDown")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageDropDown : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class.
        /// </summary>
        public BackstageDropDown() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageDropDown(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageDropDown(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageDropDown(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr(0, "alignLabel")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(5)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(6)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(7)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(8)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(9)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(10)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(11)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(16)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(17)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(18)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(19)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(20)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(21)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(22)]
        public StringValue GetItemID { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageDropDown>(deep);
    }

    /// <summary>
    /// <para>Defines the RadioGroup Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:radioGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RadioButtonBackstageItem &lt;mso14:radioButton></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RadioButtonBackstageItem), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "radioGroup")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class RadioGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadioGroup class.
        /// </summary>
        public RadioGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadioGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadioGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadioGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadioGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadioGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadioGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr(0, "alignLabel")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(5)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(6)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(7)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(8)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(9)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(10)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(11)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(12)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(13)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSelectedItemIndex")]
        [Index(14)]
        public StringValue GetSelectedItemIndex { get; set; }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(15)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(16)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(17)]
        public StringValue GetItemID { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadioGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageComboBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:comboBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ItemBackstageItem &lt;mso14:item></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ItemBackstageItem), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "comboBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageComboBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class.
        /// </summary>
        public BackstageComboBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageComboBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageComboBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageComboBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr(0, "alignLabel")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(5)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(6)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(7)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(8)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(9)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(10)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(11)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(12)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getText")]
        [Index(13)]
        public StringValue GetText { get; set; }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onChange")]
        [Index(14)]
        public StringValue OnChange { get; set; }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "sizeString")]
        [Index(15)]
        public StringValue SizeString { get; set; }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemCount")]
        [Index(16)]
        public StringValue GetItemCount { get; set; }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemLabel")]
        [Index(17)]
        public StringValue GetItemLabel { get; set; }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getItemID")]
        [Index(18)]
        public StringValue GetItemID { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageComboBox>(deep);
    }

    /// <summary>
    /// <para>Defines the Hyperlink Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:hyperlink.</para>
    /// </summary>
    [SchemaAttr(57, "hyperlink")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Hyperlink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Hyperlink class.
        /// </summary>
        public Hyperlink() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr(0, "alignLabel")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(5)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(6)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(7)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(8)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(9)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(10)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(11)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(12)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(13)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(14)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(15)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(16)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(17)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(18)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(19)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(20)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>target, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "target")]
        [Index(21)]
        public StringValue Target { get; set; }

        /// <summary>
        /// <para>getTarget, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTarget</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTarget")]
        [Index(22)]
        public StringValue GetTarget { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Hyperlink>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageLabelControl Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:labelControl.</para>
    /// </summary>
    [SchemaAttr(57, "labelControl")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageLabelControl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageLabelControl class.
        /// </summary>
        public BackstageLabelControl() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr(0, "alignLabel")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(5)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(6)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(7)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(8)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(9)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(10)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>noWrap, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: noWrap</para>
        /// </summary>
        [SchemaAttr(0, "noWrap")]
        [Index(11)]
        public BooleanValue NoWrap { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageLabelControl>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:groupBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroupButton &lt;mso14:button></description></item>
    ///   <item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>BackstageEditBox &lt;mso14:editBox></description></item>
    ///   <item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
    ///   <item><description>RadioGroup &lt;mso14:radioGroup></description></item>
    ///   <item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
    ///   <item><description>Hyperlink &lt;mso14:hyperlink></description></item>
    ///   <item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
    ///   <item><description>GroupBox &lt;mso14:groupBox></description></item>
    ///   <item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
    ///   <item><description>ImageControl &lt;mso14:imageControl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageGroupButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageEditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageDropDown), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RadioGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Hyperlink), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageLabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GroupBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LayoutContainer), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ImageControl), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "groupBox")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class GroupBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupBox class.
        /// </summary>
        public GroupBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(4)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(5)]
        public StringValue GetLabel { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupBox>(deep);
    }

    /// <summary>
    /// <para>Defines the LayoutContainer Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:layoutContainer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroupButton &lt;mso14:button></description></item>
    ///   <item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>BackstageEditBox &lt;mso14:editBox></description></item>
    ///   <item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
    ///   <item><description>RadioGroup &lt;mso14:radioGroup></description></item>
    ///   <item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
    ///   <item><description>Hyperlink &lt;mso14:hyperlink></description></item>
    ///   <item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
    ///   <item><description>GroupBox &lt;mso14:groupBox></description></item>
    ///   <item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
    ///   <item><description>ImageControl &lt;mso14:imageControl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageGroupButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageEditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageDropDown), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RadioGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Hyperlink), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageLabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GroupBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LayoutContainer), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ImageControl), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "layoutContainer")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class LayoutContainer : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutContainer class.
        /// </summary>
        public LayoutContainer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutContainer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutContainer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutContainer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutContainer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutContainer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutContainer(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>align, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: align</para>
        /// </summary>
        [SchemaAttr(0, "align")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Align { get; set; }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr(0, "expand")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand { get; set; }

        /// <summary>
        /// <para>layoutChildren, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: layoutChildren</para>
        /// </summary>
        [SchemaAttr(0, "layoutChildren")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues> LayoutChildren { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutContainer>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageControl Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:imageControl.</para>
    /// </summary>
    [SchemaAttr(57, "imageControl")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ImageControl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageControl class.
        /// </summary>
        public ImageControl() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(3)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(4)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(5)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(6)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>altText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "altText")]
        [Index(10)]
        public StringValue AltText { get; set; }

        /// <summary>
        /// <para>getAltText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getAltText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getAltText")]
        [Index(11)]
        public StringValue GetAltText { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageControl>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageGroup Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PrimaryItem &lt;mso14:primaryItem></description></item>
    ///   <item><description>TopItemsGroupControls &lt;mso14:topItems></description></item>
    ///   <item><description>BottomItemsGroupControls &lt;mso14:bottomItems></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PrimaryItem), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TopItemsGroupControls), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BottomItemsGroupControls), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "group")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageGroup class.
        /// </summary>
        public BackstageGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(8)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(9)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>style, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        [SchemaAttr(0, "style")]
        [Index(12)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues> Style { get; set; }

        /// <summary>
        /// <para>getStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getStyle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getStyle")]
        [Index(13)]
        public StringValue GetStyle { get; set; }

        /// <summary>
        /// <para>helperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "helperText")]
        [Index(14)]
        public StringValue HelperText { get; set; }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getHelperText")]
        [Index(15)]
        public StringValue GetHelperText { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(16)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(17)]
        public StringValue GetShowLabel { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem), 0, 1, version: FileFormatVersions.Office2010)
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskGroup Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:taskGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TaskGroupCategory &lt;mso14:category></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TaskGroupCategory), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "taskGroup")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TaskGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskGroup class.
        /// </summary>
        public TaskGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(8)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(9)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>helperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "helperText")]
        [Index(12)]
        public StringValue HelperText { get; set; }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getHelperText")]
        [Index(13)]
        public StringValue GetHelperText { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(14)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(15)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>allowedTaskSizes, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowedTaskSizes</para>
        /// </summary>
        [SchemaAttr(0, "allowedTaskSizes")]
        [Index(16)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory), 0, 100, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuRoot Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneRegular &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>CheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>GalleryRegular &lt;mso14:gallery></description></item>
    ///   <item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
    ///   <item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
    ///   <item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
    ///   <item><description>MenuRegular &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>title, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "title")]
        [Index(0)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTitle")]
        [Index(1)]
        public StringValue GetTitle { get; set; }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                    }
                },
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:customUI.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Commands &lt;mso14:commands></description></item>
    ///   <item><description>Ribbon &lt;mso14:ribbon></description></item>
    ///   <item><description>Backstage &lt;mso14:backstage></description></item>
    ///   <item><description>ContextMenus &lt;mso14:contextMenus></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Commands), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Ribbon), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Backstage), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ContextMenus), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "customUI")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>onLoad, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onLoad</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onLoad")]
        [Index(0)]
        public StringValue OnLoad { get; set; }

        /// <summary>
        /// <para>loadImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: loadImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "loadImage")]
        [Index(1)]
        public StringValue LoadImage { get; set; }

        /// <summary>
        /// <para>Commands.</para>
        /// <para>Represents the following element tag in the schema: mso14:commands.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public Commands Commands
        {
            get => GetElement<Commands>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ribbon.</para>
        /// <para>Represents the following element tag in the schema: mso14:ribbon.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public Ribbon Ribbon
        {
            get => GetElement<Ribbon>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Backstage.</para>
        /// <para>Represents the following element tag in the schema: mso14:backstage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public Backstage Backstage
        {
            get => GetElement<Backstage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ContextMenus.</para>
        /// <para>Represents the following element tag in the schema: mso14:contextMenus.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public ContextMenus ContextMenus
        {
            get => GetElement<ContextMenus>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Commands), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomUI>(deep);

        internal CustomUI(RibbonAndBackstageCustomizationsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RibbonAndBackstageCustomizationsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RibbonAndBackstageCustomizationsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RibbonAndBackstageCustomizationsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RibbonAndBackstageCustomizationsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart associated with this element.
        /// </summary>
        public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
        {
            get => OpenXmlPart as RibbonAndBackstageCustomizationsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the Item Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:item.</para>
    /// </summary>
    [SchemaAttr(57, "item")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Item : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(1)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(2)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(3)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(4)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr(57, "button")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class VisibleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleButton class.
        /// </summary>
        public VisibleButton() : base()
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(5)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(6)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(7)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(8)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(9)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(10)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(11)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(12)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(13)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(14)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(15)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(22)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(23)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(24)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(25)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(26)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr(57, "toggleButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class VisibleToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleToggleButton class.
        /// </summary>
        public VisibleToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getPressed")]
        [Index(0)]
        public StringValue GetPressed { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(1)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(2)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(3)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(4)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(5)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(9)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(10)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(11)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(12)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(17)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(18)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(19)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(20)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(21)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(22)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(23)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(24)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(25)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(26)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(27)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
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
    /// <para>Defines the Separator Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:separator.</para>
    /// </summary>
    [SchemaAttr(57, "separator")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Separator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Separator class.
        /// </summary>
        public Separator() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(3)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(4)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(5)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(6)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(7)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(8)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Separator>(deep);
    }

    /// <summary>
    /// <para>Defines the DialogBoxLauncher Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dialogBoxLauncher.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "dialogBoxLauncher")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>ButtonRegular.</para>
        /// <para>Represents the following element tag in the schema: mso14:button.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public ButtonRegular ButtonRegular
        {
            get => GetElement<ButtonRegular>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DialogBoxLauncher>(deep);
    }

    /// <summary>
    /// <para>Defines the Group Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlClone &lt;mso14:control></description></item>
    ///   <item><description>LabelControl &lt;mso14:labelControl></description></item>
    ///   <item><description>Button &lt;mso14:button></description></item>
    ///   <item><description>ToggleButton &lt;mso14:toggleButton></description></item>
    ///   <item><description>CheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>EditBox &lt;mso14:editBox></description></item>
    ///   <item><description>ComboBox &lt;mso14:comboBox></description></item>
    ///   <item><description>DropDownRegular &lt;mso14:dropDown></description></item>
    ///   <item><description>Gallery &lt;mso14:gallery></description></item>
    ///   <item><description>Menu &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenu &lt;mso14:dynamicMenu></description></item>
    ///   <item><description>SplitButton &lt;mso14:splitButton></description></item>
    ///   <item><description>Box &lt;mso14:box></description></item>
    ///   <item><description>ButtonGroup &lt;mso14:buttonGroup></description></item>
    ///   <item><description>Separator &lt;mso14:separator></description></item>
    ///   <item><description>DialogBoxLauncher &lt;mso14:dialogBoxLauncher></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlClone), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Button), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(EditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropDownRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Gallery), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Menu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Box), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Separator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DialogBoxLauncher), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "group")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(4)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(5)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(6)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(7)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(8)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(9)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(10)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(11)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(12)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(13)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(14)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(15)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(16)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(17)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(18)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(19)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(20)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>autoScale, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: autoScale</para>
        /// </summary>
        [SchemaAttr(0, "autoScale")]
        [Index(21)]
        public BooleanValue AutoScale { get; set; }

        /// <summary>
        /// <para>centerVertically, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: centerVertically</para>
        /// </summary>
        [SchemaAttr(0, "centerVertically")]
        [Index(22)]
        public BooleanValue CenterVertically { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Button), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.EditBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Gallery), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Menu), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Box), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlCloneQat Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
    [SchemaAttr(57, "control")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ControlCloneQat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlCloneQat class.
        /// </summary>
        public ControlCloneQat() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue IdQ { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(2)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(3)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(4)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr(0, "size")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size { get; set; }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSize")]
        [Index(6)]
        public StringValue GetSize { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(7)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(8)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(9)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(10)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(11)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(12)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(13)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(14)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(15)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(16)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(17)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(18)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(19)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(20)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(21)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(22)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(23)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(24)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(25)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(26)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(27)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr(0, "showImage")]
        [Index(28)]
        public BooleanValue ShowImage { get; set; }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowImage")]
        [Index(29)]
        public StringValue GetShowImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlCloneQat>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedControlsQatItems Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:sharedControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneQat &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>Separator &lt;mso14:separator></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(57, "sharedControls")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SharedControlsQatItems : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class.
        /// </summary>
        public SharedControlsQatItems() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedControlsQatItems(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SharedControlsQatItems(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedControlsQatItems>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentControlsQatItems Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:documentControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneQat &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>Separator &lt;mso14:separator></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(57, "documentControls")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DocumentControlsQatItems : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class.
        /// </summary>
        public DocumentControlsQatItems() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentControlsQatItems(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocumentControlsQatItems(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentControlsQatItems>(deep);
    }

    /// <summary>
    /// <para>Defines the QatItemsType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneQat &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>Separator &lt;mso14:separator></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlCloneQat), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Separator), FileFormatVersions.Office2010)]
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
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tab.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Group &lt;mso14:group></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Group), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "tab")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(4)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(5)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(6)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(7)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(8)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(9)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(10)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(11)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(12)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Group), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tab>(deep);
    }

    /// <summary>
    /// <para>Defines the TabSet Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tabSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Tab &lt;mso14:tab></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Tab), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "tabSet")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TabSet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TabSet class.
        /// </summary>
        public TabSet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabSet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabSet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabSet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TabSet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(0)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(1)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(2)]
        public StringValue GetVisible { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tab), 0, 50, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabSet>(deep);
    }

    /// <summary>
    /// <para>Defines the Command Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:command.</para>
    /// </summary>
    [SchemaAttr(57, "command")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Command : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Command class.
        /// </summary>
        public Command() : base()
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(0)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(1)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(2)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Command>(deep);
    }

    /// <summary>
    /// <para>Defines the QuickAccessToolbar Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:qat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SharedControlsQatItems &lt;mso14:sharedControls></description></item>
    ///   <item><description>DocumentControlsQatItems &lt;mso14:documentControls></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SharedControlsQatItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentControlsQatItems), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "qat")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>SharedControlsQatItems.</para>
        /// <para>Represents the following element tag in the schema: mso14:sharedControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public SharedControlsQatItems SharedControlsQatItems
        {
            get => GetElement<SharedControlsQatItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DocumentControlsQatItems.</para>
        /// <para>Represents the following element tag in the schema: mso14:documentControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentControlsQatItems DocumentControlsQatItems
        {
            get => GetElement<DocumentControlsQatItems>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbar>(deep);
    }

    /// <summary>
    /// <para>Defines the Tabs Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Tab &lt;mso14:tab></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Tab), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "tabs")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tab), 1, 100, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tabs>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextualTabs Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:contextualTabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TabSet &lt;mso14:tabSet></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TabSet), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "contextualTabs")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ContextualTabs : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextualTabs class.
        /// </summary>
        public ContextualTabs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabs(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabs class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextualTabs(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet), 1, 100, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabs>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextMenu Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:contextMenu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlCloneRegular &lt;mso14:control></description></item>
    ///   <item><description>ButtonRegular &lt;mso14:button></description></item>
    ///   <item><description>CheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>GalleryRegular &lt;mso14:gallery></description></item>
    ///   <item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
    ///   <item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
    ///   <item><description>MenuRegular &lt;mso14:menu></description></item>
    ///   <item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
    ///   <item><description>MenuSeparatorNoTitle &lt;mso14:menuSeparator></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparatorNoTitle), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "contextMenu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ContextMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextMenu class.
        /// </summary>
        public ContextMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(0)]
        public StringValue IdMso { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the ItemBackstageItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:item.</para>
    /// </summary>
    [SchemaAttr(57, "item")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ItemBackstageItem : BackstageItemType
    {
        /// <summary>
        /// Initializes a new instance of the ItemBackstageItem class.
        /// </summary>
        public ItemBackstageItem() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ItemBackstageItem>(deep);
    }

    /// <summary>
    /// <para>Defines the RadioButtonBackstageItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:radioButton.</para>
    /// </summary>
    [SchemaAttr(57, "radioButton")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class RadioButtonBackstageItem : BackstageItemType
    {
        /// <summary>
        /// Initializes a new instance of the RadioButtonBackstageItem class.
        /// </summary>
        public RadioButtonBackstageItem() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadioButtonBackstageItem>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageItemType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BackstageItemType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageItemType class.
        /// </summary>
        protected BackstageItemType() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(1)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(2)]
        public StringValue GetLabel { get; set; }
    }

    /// <summary>
    /// <para>Defines the BackstageRegularButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr(57, "button")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageRegularButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageRegularButton class.
        /// </summary>
        public BackstageRegularButton() : base()
        {
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(0)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(1)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(2)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(3)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(4)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(5)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(6)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(7)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr(0, "isDefinitive")]
        [Index(8)]
        public BooleanValue IsDefinitive { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(9)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(10)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(11)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(12)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(13)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(14)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(15)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(16)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(17)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(18)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(19)]
        public StringValue GetImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageRegularButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstagePrimaryMenu Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageMenuGroup &lt;mso14:menuGroup></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageMenuGroup), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "menu")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstagePrimaryMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class.
        /// </summary>
        public BackstagePrimaryMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstagePrimaryMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstagePrimaryMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstagePrimaryMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "screentip")]
        [Index(0)]
        public StringValue Screentip { get; set; }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getScreentip")]
        [Index(1)]
        public StringValue GetScreentip { get; set; }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "supertip")]
        [Index(2)]
        public StringValue Supertip { get; set; }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getSupertip")]
        [Index(3)]
        public StringValue GetSupertip { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(4)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(5)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(6)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(7)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(8)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(9)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(10)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(11)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(12)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(13)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(14)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(15)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(16)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(17)]
        public StringValue GetKeytip { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstagePrimaryMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuGroup Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageMenuButton &lt;mso14:button></description></item>
    ///   <item><description>BackstageMenuCheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>BackstageSubMenu &lt;mso14:menu></description></item>
    ///   <item><description>BackstageMenuToggleButton &lt;mso14:toggleButton></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageMenuButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageMenuCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageSubMenu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageMenuToggleButton), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "menuGroup")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageMenuGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class.
        /// </summary>
        public BackstageMenuGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageMenuGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageMenuGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageMenuGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(3)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(4)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr(0, "itemSize")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the PrimaryItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:primaryItem.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageRegularButton &lt;mso14:button></description></item>
    ///   <item><description>BackstagePrimaryMenu &lt;mso14:menu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageRegularButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstagePrimaryMenu), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "primaryItem")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PrimaryItem : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PrimaryItem class.
        /// </summary>
        public PrimaryItem() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrimaryItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrimaryItem(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrimaryItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrimaryItem(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrimaryItem class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PrimaryItem(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>BackstageRegularButton.</para>
        /// <para>Represents the following element tag in the schema: mso14:button.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public BackstageRegularButton BackstageRegularButton
        {
            get => GetElement<BackstageRegularButton>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BackstagePrimaryMenu.</para>
        /// <para>Represents the following element tag in the schema: mso14:menu.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public BackstagePrimaryMenu BackstagePrimaryMenu
        {
            get => GetElement<BackstagePrimaryMenu>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrimaryItem>(deep);
    }

    /// <summary>
    /// <para>Defines the TopItemsGroupControls Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:topItems.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroupButton &lt;mso14:button></description></item>
    ///   <item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>BackstageEditBox &lt;mso14:editBox></description></item>
    ///   <item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
    ///   <item><description>RadioGroup &lt;mso14:radioGroup></description></item>
    ///   <item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
    ///   <item><description>Hyperlink &lt;mso14:hyperlink></description></item>
    ///   <item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
    ///   <item><description>GroupBox &lt;mso14:groupBox></description></item>
    ///   <item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
    ///   <item><description>ImageControl &lt;mso14:imageControl></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(57, "topItems")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TopItemsGroupControls : GroupControlsType
    {
        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class.
        /// </summary>
        public TopItemsGroupControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TopItemsGroupControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TopItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TopItemsGroupControls(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1000)
        {
            new CompositeParticle(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopItemsGroupControls>(deep);
    }

    /// <summary>
    /// <para>Defines the BottomItemsGroupControls Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:bottomItems.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroupButton &lt;mso14:button></description></item>
    ///   <item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>BackstageEditBox &lt;mso14:editBox></description></item>
    ///   <item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
    ///   <item><description>RadioGroup &lt;mso14:radioGroup></description></item>
    ///   <item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
    ///   <item><description>Hyperlink &lt;mso14:hyperlink></description></item>
    ///   <item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
    ///   <item><description>GroupBox &lt;mso14:groupBox></description></item>
    ///   <item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
    ///   <item><description>ImageControl &lt;mso14:imageControl></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(57, "bottomItems")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BottomItemsGroupControls : GroupControlsType
    {
        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class.
        /// </summary>
        public BottomItemsGroupControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BottomItemsGroupControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BottomItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BottomItemsGroupControls(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1000)
        {
            new CompositeParticle(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BottomItemsGroupControls>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupControlsType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroupButton &lt;mso14:button></description></item>
    ///   <item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
    ///   <item><description>BackstageEditBox &lt;mso14:editBox></description></item>
    ///   <item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
    ///   <item><description>RadioGroup &lt;mso14:radioGroup></description></item>
    ///   <item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
    ///   <item><description>Hyperlink &lt;mso14:hyperlink></description></item>
    ///   <item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
    ///   <item><description>GroupBox &lt;mso14:groupBox></description></item>
    ///   <item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
    ///   <item><description>ImageControl &lt;mso14:imageControl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageGroupButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageEditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageDropDown), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RadioGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Hyperlink), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageLabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GroupBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LayoutContainer), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ImageControl), FileFormatVersions.Office2010)]
    public abstract partial class GroupControlsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupControlsType class.
        /// </summary>
        protected GroupControlsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupControlsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupControlsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupControlsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupControlsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupControlsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected GroupControlsType(string outerXml) : base(outerXml)
        {
        }
    }

    /// <summary>
    /// <para>Defines the TaskGroupCategory Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:category.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TaskGroupTask &lt;mso14:task></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TaskGroupTask), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "category")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TaskGroupCategory : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class.
        /// </summary>
        public TaskGroupCategory() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroupCategory(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskGroupCategory(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(8)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(9)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(10)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(11)]
        public StringValue GetLabel { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask), 0, 1000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroupCategory>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskGroupTask Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:task.</para>
    /// </summary>
    [SchemaAttr(57, "task")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TaskGroupTask : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskGroupTask class.
        /// </summary>
        public TaskGroupTask() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(8)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr(0, "isDefinitive")]
        [Index(9)]
        public BooleanValue IsDefinitive { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(10)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(11)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(12)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(13)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(14)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(15)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(16)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(17)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(18)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(19)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(20)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(21)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(22)]
        public StringValue GetKeytip { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroupTask>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskFormGroupCategory Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:category.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TaskFormGroupTask &lt;mso14:task></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TaskFormGroupTask), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "category")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TaskFormGroupCategory : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class.
        /// </summary>
        public TaskFormGroupCategory() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupCategory(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskFormGroupCategory(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(8)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(9)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(10)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(11)]
        public StringValue GetLabel { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask), 0, 1000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroupCategory>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskFormGroupTask Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:task.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroup &lt;mso14:group></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageGroup), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "task")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TaskFormGroupTask : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class.
        /// </summary>
        public TaskFormGroupTask() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupTask(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupTask(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskFormGroupTask(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(8)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(9)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(10)]
        public StringValue GetImage { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(11)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(12)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(13)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(14)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(15)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(16)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "description")]
        [Index(17)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getDescription")]
        [Index(18)]
        public StringValue GetDescription { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(19)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(20)]
        public StringValue GetKeytip { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 0, 1000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroupTask>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskFormGroup Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:taskFormGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TaskFormGroupCategory &lt;mso14:category></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TaskFormGroupCategory), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "taskFormGroup")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TaskFormGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class.
        /// </summary>
        public TaskFormGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskFormGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(4)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(5)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(6)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(7)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>helperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 4096L)]
        [SchemaAttr(0, "helperText")]
        [Index(8)]
        public StringValue HelperText { get; set; }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getHelperText")]
        [Index(9)]
        public StringValue GetHelperText { get; set; }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr(0, "showLabel")]
        [Index(10)]
        public BooleanValue ShowLabel { get; set; }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getShowLabel")]
        [Index(11)]
        public StringValue GetShowLabel { get; set; }

        /// <summary>
        /// <para>allowedTaskSizes, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowedTaskSizes</para>
        /// </summary>
        [SchemaAttr(0, "allowedTaskSizes")]
        [Index(12)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory), 0, 100, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageGroups Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:firstColumn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TaskFormGroup &lt;mso14:taskFormGroup></description></item>
    ///   <item><description>BackstageGroup &lt;mso14:group></description></item>
    ///   <item><description>TaskGroup &lt;mso14:taskGroup></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TaskFormGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TaskGroup), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "firstColumn")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageGroups : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageGroups class.
        /// </summary>
        public BackstageGroups() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroups(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroups(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroups class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageGroups(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup), 1, 1, version: FileFormatVersions.Office2010)
            },
            new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroups>(deep);
    }

    /// <summary>
    /// <para>Defines the SimpleGroups Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:secondColumn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroup &lt;mso14:group></description></item>
    ///   <item><description>TaskGroup &lt;mso14:taskGroup></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TaskGroup), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "secondColumn")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SimpleGroups : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SimpleGroups class.
        /// </summary>
        public SimpleGroups() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SimpleGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SimpleGroups(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SimpleGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SimpleGroups(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SimpleGroups class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SimpleGroups(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1000)
        {
            new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup), 1, 1, version: FileFormatVersions.Office2010)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SimpleGroups>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageTab Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tab.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageGroups &lt;mso14:firstColumn></description></item>
    ///   <item><description>SimpleGroups &lt;mso14:secondColumn></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageGroups), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SimpleGroups), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "tab")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageTab : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageTab class.
        /// </summary>
        public BackstageTab() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageTab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageTab(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageTab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageTab(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageTab class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageTab(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(1)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(2)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(3)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(4)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(5)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(6)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(7)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(8)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(9)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(10)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(11)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(12)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(13)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(14)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(15)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>title, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "title")]
        [Index(16)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getTitle")]
        [Index(17)]
        public StringValue GetTitle { get; set; }

        /// <summary>
        /// <para>columnWidthPercent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columnWidthPercent</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 99L, IsPositive = true)]
        [SchemaAttr(0, "columnWidthPercent")]
        [Index(18)]
        public IntegerValue ColumnWidthPercent { get; set; }

        /// <summary>
        /// <para>firstColumnMinWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: firstColumnMinWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 10000L, IsPositive = true)]
        [SchemaAttr(0, "firstColumnMinWidth")]
        [Index(19)]
        public IntegerValue FirstColumnMinWidth { get; set; }

        /// <summary>
        /// <para>firstColumnMaxWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: firstColumnMaxWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 10000L, IsPositive = true)]
        [SchemaAttr(0, "firstColumnMaxWidth")]
        [Index(20)]
        public IntegerValue FirstColumnMaxWidth { get; set; }

        /// <summary>
        /// <para>secondColumnMinWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: secondColumnMinWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 10000L, IsPositive = true)]
        [SchemaAttr(0, "secondColumnMinWidth")]
        [Index(21)]
        public IntegerValue SecondColumnMinWidth { get; set; }

        /// <summary>
        /// <para>secondColumnMaxWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: secondColumnMaxWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 10000L, IsPositive = true)]
        [SchemaAttr(0, "secondColumnMaxWidth")]
        [Index(22)]
        public IntegerValue SecondColumnMaxWidth { get; set; }

        /// <summary>
        /// <para>BackstageGroups.</para>
        /// <para>Represents the following element tag in the schema: mso14:firstColumn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public BackstageGroups BackstageGroups
        {
            get => GetElement<BackstageGroups>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SimpleGroups.</para>
        /// <para>Represents the following element tag in the schema: mso14:secondColumn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public SimpleGroups SimpleGroups
        {
            get => GetElement<SimpleGroups>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageTab>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageFastCommandButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr(57, "button")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackstageFastCommandButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageFastCommandButton class.
        /// </summary>
        public BackstageFastCommandButton() : base()
        {
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idMso")]
        [Index(0)]
        public StringValue IdMso { get; set; }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterMso")]
        [Index(1)]
        public StringValue InsertAfterMso { get; set; }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeMso")]
        [Index(2)]
        public StringValue InsertBeforeMso { get; set; }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertAfterQ")]
        [Index(3)]
        public StringValue InsertAfterQulifiedId { get; set; }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "insertBeforeQ")]
        [Index(4)]
        public StringValue InsertBeforeQulifiedId { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsId = true, IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "id")]
        [Index(5)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [StringValidator(IsQName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "idQ")]
        [Index(6)]
        public StringValue QualifiedId { get; set; }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "tag")]
        [Index(7)]
        public StringValue Tag { get; set; }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onAction")]
        [Index(8)]
        public StringValue OnAction { get; set; }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr(0, "isDefinitive")]
        [Index(9)]
        public BooleanValue IsDefinitive { get; set; }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr(0, "enabled")]
        [Index(10)]
        public BooleanValue Enabled { get; set; }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getEnabled")]
        [Index(11)]
        public StringValue GetEnabled { get; set; }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "label")]
        [Index(12)]
        public StringValue Label { get; set; }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getLabel")]
        [Index(13)]
        public StringValue GetLabel { get; set; }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(14)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getVisible")]
        [Index(15)]
        public StringValue GetVisible { get; set; }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [StringValidator(IsToken = true, MinLength = 1L, MaxLength = 3L)]
        [SchemaAttr(0, "keytip")]
        [Index(16)]
        public StringValue Keytip { get; set; }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getKeytip")]
        [Index(17)]
        public StringValue GetKeytip { get; set; }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "image")]
        [Index(18)]
        public StringValue Image { get; set; }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [StringValidator(IsToken = true, IsNcName = true, MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "imageMso")]
        [Index(19)]
        public StringValue ImageMso { get; set; }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "getImage")]
        [Index(20)]
        public StringValue GetImage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageFastCommandButton>(deep);
    }

    /// <summary>
    /// <para>Defines the Commands Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:commands.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Command &lt;mso14:command></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Command), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "commands")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Commands : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Commands class.
        /// </summary>
        public Commands() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Commands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Commands(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Commands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Commands(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Commands class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Commands(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Command), 1, 5000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Commands>(deep);
    }

    /// <summary>
    /// <para>Defines the Ribbon Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:ribbon.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>QuickAccessToolbar &lt;mso14:qat></description></item>
    ///   <item><description>Tabs &lt;mso14:tabs></description></item>
    ///   <item><description>ContextualTabs &lt;mso14:contextualTabs></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(QuickAccessToolbar), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Tabs), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ContextualTabs), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "ribbon")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
        /// <para>startFromScratch, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: startFromScratch</para>
        /// </summary>
        [SchemaAttr(0, "startFromScratch")]
        [Index(0)]
        public BooleanValue StartFromScratch { get; set; }

        /// <summary>
        /// <para>QuickAccessToolbar.</para>
        /// <para>Represents the following element tag in the schema: mso14:qat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public QuickAccessToolbar QuickAccessToolbar
        {
            get => GetElement<QuickAccessToolbar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tabs.</para>
        /// <para>Represents the following element tag in the schema: mso14:tabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public Tabs Tabs
        {
            get => GetElement<Tabs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ContextualTabs.</para>
        /// <para>Represents the following element tag in the schema: mso14:contextualTabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public ContextualTabs ContextualTabs
        {
            get => GetElement<ContextualTabs>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.All, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ribbon>(deep);
    }

    /// <summary>
    /// <para>Defines the Backstage Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:backstage.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackstageTab &lt;mso14:tab></description></item>
    ///   <item><description>BackstageFastCommandButton &lt;mso14:button></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackstageTab), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageFastCommandButton), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "backstage")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Backstage : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Backstage class.
        /// </summary>
        public Backstage() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Backstage class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Backstage(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Backstage class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Backstage(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Backstage class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Backstage(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onShow, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onShow</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onShow")]
        [Index(0)]
        public StringValue OnShow { get; set; }

        /// <summary>
        /// <para>onHide, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onHide</para>
        /// </summary>
        [StringValidator(MinLength = 1L, MaxLength = 1024L)]
        [SchemaAttr(0, "onHide")]
        [Index(1)]
        public StringValue OnHide { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 255)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton), 1, 1, version: FileFormatVersions.Office2010)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Backstage>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextMenus Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:contextMenus.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ContextMenu &lt;mso14:contextMenu></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ContextMenu), FileFormatVersions.Office2010)]
    [SchemaAttr(57, "contextMenus")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ContextMenus : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextMenus class.
        /// </summary>
        public ContextMenus() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenus(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenus(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenus class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextMenus(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu), 1, 1000, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenus>(deep);
    }

    /// <summary>
    /// Defines the GalleryShowInRibbonValues enumeration.
    /// </summary>
    public enum GalleryShowInRibbonValues
    {
        ///<summary>
        ///false.
        ///<para>When the item is serialized out as xml, its value is "false".</para>
        ///</summary>
        [EnumString("false")]
        False,
        ///<summary>
        ///0.
        ///<para>When the item is serialized out as xml, its value is "0".</para>
        ///</summary>
        [EnumString("0")]
        Zero,
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

    /// <summary>
    /// Defines the TaskSizesValues enumeration.
    /// </summary>
    public enum TaskSizesValues
    {
        ///<summary>
        ///largeMediumSmall.
        ///<para>When the item is serialized out as xml, its value is "largeMediumSmall".</para>
        ///</summary>
        [EnumString("largeMediumSmall")]
        LargeMediumSmall,
        ///<summary>
        ///largeMedium.
        ///<para>When the item is serialized out as xml, its value is "largeMedium".</para>
        ///</summary>
        [EnumString("largeMedium")]
        LargeMedium,
        ///<summary>
        ///large.
        ///<para>When the item is serialized out as xml, its value is "large".</para>
        ///</summary>
        [EnumString("large")]
        Large,
        ///<summary>
        ///mediumSmall.
        ///<para>When the item is serialized out as xml, its value is "mediumSmall".</para>
        ///</summary>
        [EnumString("mediumSmall")]
        MediumSmall,
        ///<summary>
        ///medium.
        ///<para>When the item is serialized out as xml, its value is "medium".</para>
        ///</summary>
        [EnumString("medium")]
        Medium,
        ///<summary>
        ///small.
        ///<para>When the item is serialized out as xml, its value is "small".</para>
        ///</summary>
        [EnumString("small")]
        Small,
    }

    /// <summary>
    /// Defines the ExpandValues enumeration.
    /// </summary>
    public enum ExpandValues
    {
        ///<summary>
        ///topLeft.
        ///<para>When the item is serialized out as xml, its value is "topLeft".</para>
        ///</summary>
        [EnumString("topLeft")]
        TopLeft,
        ///<summary>
        ///top.
        ///<para>When the item is serialized out as xml, its value is "top".</para>
        ///</summary>
        [EnumString("top")]
        Top,
        ///<summary>
        ///topRight.
        ///<para>When the item is serialized out as xml, its value is "topRight".</para>
        ///</summary>
        [EnumString("topRight")]
        TopRight,
        ///<summary>
        ///left.
        ///<para>When the item is serialized out as xml, its value is "left".</para>
        ///</summary>
        [EnumString("left")]
        Left,
        ///<summary>
        ///center.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///right.
        ///<para>When the item is serialized out as xml, its value is "right".</para>
        ///</summary>
        [EnumString("right")]
        Right,
        ///<summary>
        ///bottomLeft.
        ///<para>When the item is serialized out as xml, its value is "bottomLeft".</para>
        ///</summary>
        [EnumString("bottomLeft")]
        BottomLeft,
        ///<summary>
        ///bottom.
        ///<para>When the item is serialized out as xml, its value is "bottom".</para>
        ///</summary>
        [EnumString("bottom")]
        Bottom,
        ///<summary>
        ///bottomRight.
        ///<para>When the item is serialized out as xml, its value is "bottomRight".</para>
        ///</summary>
        [EnumString("bottomRight")]
        BottomRight,
    }

    /// <summary>
    /// Defines the StyleValues enumeration.
    /// </summary>
    public enum StyleValues
    {
        ///<summary>
        ///normal.
        ///<para>When the item is serialized out as xml, its value is "normal".</para>
        ///</summary>
        [EnumString("normal")]
        Normal,
        ///<summary>
        ///warning.
        ///<para>When the item is serialized out as xml, its value is "warning".</para>
        ///</summary>
        [EnumString("warning")]
        Warning,
        ///<summary>
        ///error.
        ///<para>When the item is serialized out as xml, its value is "error".</para>
        ///</summary>
        [EnumString("error")]
        Error,
    }

    /// <summary>
    /// Defines the Style2Values enumeration.
    /// </summary>
    public enum Style2Values
    {
        ///<summary>
        ///normal.
        ///<para>When the item is serialized out as xml, its value is "normal".</para>
        ///</summary>
        [EnumString("normal")]
        Normal,
        ///<summary>
        ///borderless.
        ///<para>When the item is serialized out as xml, its value is "borderless".</para>
        ///</summary>
        [EnumString("borderless")]
        Borderless,
        ///<summary>
        ///large.
        ///<para>When the item is serialized out as xml, its value is "large".</para>
        ///</summary>
        [EnumString("large")]
        Large,
    }

    /// <summary>
    /// Defines the LayoutChildrenValues enumeration.
    /// </summary>
    public enum LayoutChildrenValues
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