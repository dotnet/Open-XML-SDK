// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
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
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "control");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ControlCloneRegular>()
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlCloneRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the ButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
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
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ButtonRegular>()
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.AddConstraint(new AttributeMutualExclusive(18, 20, 19, 21) /*:insertAfterMso, :insertAfterQ, :insertBeforeMso, :insertBeforeQ*/ { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
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
        public StringValue GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "checkBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CheckBox>()
.AddAttribute(0, "getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        public BooleanValue InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columns, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        public IntegerValue Columns
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rows, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        public IntegerValue Rows
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        public IntegerValue ItemWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        public IntegerValue ItemHeight
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        public StringValue GetItemWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        public StringValue GetItemHeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        public BooleanValue ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showInRibbon, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showInRibbon</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        public BooleanValue ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        public StringValue GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        public StringValue GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        public StringValue GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        public StringValue GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        public StringValue GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        public StringValue GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        public StringValue GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        public StringValue GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "gallery");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Item>();
            builder.AddChild<ButtonRegular>();
            builder.AddElement<GalleryRegular>()
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute(0, "columns", a => a.Columns, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute(0, "rows", a => a.Rows, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute(0, "itemWidth", a => a.ItemWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute(0, "itemHeight", a => a.ItemHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute(0, "getItemWidth", a => a.GetItemWidth, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemHeight", a => a.GetItemHeight, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showItemLabel", a => a.ShowItemLabel)
.AddAttribute(0, "showInRibbon", a => a.ShowInRibbon)
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showItemImage", a => a.ShowItemImage)
.AddAttribute(0, "getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemID", a => a.GetSelectedItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GalleryRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the ToggleButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
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
        public StringValue GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ToggleButtonRegular>()
.AddAttribute(0, "getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuSeparator Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuSeparator.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        public StringValue GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menuSeparator");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<MenuSeparator>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "splitButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<VisibleButton>();
            builder.AddChild<VisibleToggleButton>();
            builder.AddChild<MenuRegular>();
            builder.AddElement<SplitButtonRegular>()
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlCloneRegular>();
            builder.AddChild<ButtonRegular>();
            builder.AddChild<CheckBox>();
            builder.AddChild<GalleryRegular>();
            builder.AddChild<ToggleButtonRegular>();
            builder.AddChild<MenuSeparator>();
            builder.AddChild<SplitButtonRegular>();
            builder.AddChild<MenuRegular>();
            builder.AddChild<DynamicMenuRegular>();
            builder.AddElement<MenuRegular>()
.AddAttribute(0, "itemSize", a => a.ItemSize)
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicMenuRegular Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dynamicMenu.</para>
    /// </summary>
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
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getContent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        public StringValue GetContent
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        public BooleanValue InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "dynamicMenu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DynamicMenuRegular>()
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getContent", a => a.GetContent, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "splitButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<VisibleButton>();
            builder.AddChild<VisibleToggleButton>();
            builder.AddChild<MenuWithTitle>();
            builder.AddElement<SplitButtonWithTitle>()
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        public StringValue GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlCloneRegular>();
            builder.AddChild<ButtonRegular>();
            builder.AddChild<CheckBox>();
            builder.AddChild<GalleryRegular>();
            builder.AddChild<ToggleButtonRegular>();
            builder.AddChild<MenuSeparator>();
            builder.AddChild<SplitButtonWithTitle>();
            builder.AddChild<MenuWithTitle>();
            builder.AddChild<DynamicMenuRegular>();
            builder.AddElement<MenuWithTitle>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "itemSize", a => a.ItemSize)
.AddAttribute(0, "title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuWithTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuSeparatorNoTitle Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuSeparator.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menuSeparator");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<MenuSeparatorNoTitle>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparatorNoTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlClone Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "control");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ControlClone>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.AddConstraint(new AttributeMutualExclusive(0, 1) /*:size, :getSize*/ { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the LabelControl Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:labelControl.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "labelControl");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<LabelControl>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelControl>(deep);
    }

    /// <summary>
    /// <para>Defines the Button Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Button>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.AddConstraint(new AttributeMutualExclusive(0, 1) /*:size, :getSize*/ { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Button>(deep);
    }

    /// <summary>
    /// <para>Defines the ToggleButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        public StringValue GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ToggleButton>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the EditBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
    /// </summary>
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
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        public IntegerValue MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        public StringValue GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        public StringValue OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "editBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<EditBox>()
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "maxLength", a => a.MaxLength, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute(0, "getText", a => a.GetText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onChange", a => a.OnChange, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public BooleanValue ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        public StringValue GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        public StringValue GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        public StringValue GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        public StringValue GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        public StringValue GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        public StringValue GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        public BooleanValue InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        public IntegerValue MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        public StringValue GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        public StringValue OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "comboBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Item>();
            builder.AddElement<ComboBox>()
.AddAttribute(0, "showItemImage", a => a.ShowItemImage)
.AddAttribute(0, "getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "maxLength", a => a.MaxLength, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute(0, "getText", a => a.GetText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onChange", a => a.OnChange, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010)
                }
            };
        }

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
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        public BooleanValue ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        public StringValue GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        public StringValue GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        public StringValue GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        public StringValue GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        public StringValue GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        public StringValue GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        public StringValue GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        public StringValue GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        public BooleanValue ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "dropDown");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Item>();
            builder.AddChild<ButtonRegular>();
            builder.AddElement<DropDownRegular>()
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showItemImage", a => a.ShowItemImage)
.AddAttribute(0, "getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemID", a => a.GetSelectedItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showItemLabel", a => a.ShowItemLabel)
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
                }
            };
        }

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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        public BooleanValue InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columns, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        public IntegerValue Columns
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rows, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        public IntegerValue Rows
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        public IntegerValue ItemWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        public IntegerValue ItemHeight
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        public StringValue GetItemWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        public StringValue GetItemHeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        public BooleanValue ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showInRibbon, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showInRibbon</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        public BooleanValue ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        public StringValue GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        public StringValue GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        public StringValue GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        public StringValue GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        public StringValue GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        public StringValue GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        public StringValue GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        public StringValue GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "gallery");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Item>();
            builder.AddChild<ButtonRegular>();
            builder.AddElement<Gallery>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute(0, "columns", a => a.Columns, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute(0, "rows", a => a.Rows, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute(0, "itemWidth", a => a.ItemWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute(0, "itemHeight", a => a.ItemHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute(0, "getItemWidth", a => a.GetItemWidth, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemHeight", a => a.GetItemHeight, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showItemLabel", a => a.ShowItemLabel)
.AddAttribute(0, "showInRibbon", a => a.ShowInRibbon)
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showItemImage", a => a.ShowItemImage)
.AddAttribute(0, "getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemID", a => a.GetSelectedItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlCloneRegular>();
            builder.AddChild<ButtonRegular>();
            builder.AddChild<CheckBox>();
            builder.AddChild<GalleryRegular>();
            builder.AddChild<ToggleButtonRegular>();
            builder.AddChild<MenuSeparator>();
            builder.AddChild<SplitButtonRegular>();
            builder.AddChild<MenuRegular>();
            builder.AddChild<DynamicMenuRegular>();
            builder.AddElement<Menu>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "itemSize", a => a.ItemSize)
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Menu>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicMenu Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dynamicMenu.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getContent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        public StringValue GetContent
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        public BooleanValue InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "dynamicMenu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DynamicMenu>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getContent", a => a.GetContent, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "splitButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<VisibleButton>();
            builder.AddChild<VisibleToggleButton>();
            builder.AddChild<MenuRegular>();
            builder.AddElement<SplitButton>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>boxStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: boxStyle</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues> BoxStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "box");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlClone>();
            builder.AddChild<LabelControl>();
            builder.AddChild<Button>();
            builder.AddChild<ToggleButton>();
            builder.AddChild<CheckBox>();
            builder.AddChild<EditBox>();
            builder.AddChild<ComboBox>();
            builder.AddChild<DropDownRegular>();
            builder.AddChild<Gallery>();
            builder.AddChild<Menu>();
            builder.AddChild<DynamicMenu>();
            builder.AddChild<SplitButton>();
            builder.AddChild<Box>();
            builder.AddChild<ButtonGroup>();
            builder.AddElement<Box>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "boxStyle", a => a.BoxStyle);
            builder.Particle = new CompositeParticle(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
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
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "buttonGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlCloneRegular>();
            builder.AddChild<ButtonRegular>();
            builder.AddChild<ToggleButtonRegular>();
            builder.AddChild<GalleryRegular>();
            builder.AddChild<MenuRegular>();
            builder.AddChild<DynamicMenuRegular>();
            builder.AddChild<SplitButtonRegular>();
            builder.AddChild<Separator>();
            builder.AddElement<ButtonGroup>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
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
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        public BooleanValue IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageMenuButton>()
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "isDefinitive", a => a.IsDefinitive)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuCheckBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
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
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        public StringValue GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "checkBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageMenuCheckBox>()
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageMenuGroup>();
            builder.AddElement<BackstageSubMenu>()
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 0, 1000)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageSubMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuToggleButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
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
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        public StringValue GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageMenuToggleButton>()
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageGroupButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values> Style
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        public BooleanValue IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageGroupButton>()
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "isDefinitive", a => a.IsDefinitive)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroupButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageCheckBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        public StringValue GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "checkBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageCheckBox>()
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageCheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageEditBox Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        public StringValue GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        public StringValue OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        public IntegerValue MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "editBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageEditBox>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "alignLabel", a => a.AlignLabel)
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getText", a => a.GetText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onChange", a => a.OnChange, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "maxLength", a => a.MaxLength, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        public StringValue GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        public StringValue GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        public StringValue GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        public StringValue GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "dropDown");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ItemBackstageItem>();
            builder.AddElement<BackstageDropDown>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "alignLabel", a => a.AlignLabel)
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        public StringValue GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        public StringValue GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        public StringValue GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        public StringValue GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "radioGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<RadioButtonBackstageItem>();
            builder.AddElement<RadioGroup>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "alignLabel", a => a.AlignLabel)
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        public StringValue GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        public StringValue OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        public StringValue SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        public StringValue GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        public StringValue GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        public StringValue GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "comboBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ItemBackstageItem>();
            builder.AddElement<BackstageComboBox>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "alignLabel", a => a.AlignLabel)
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getText", a => a.GetText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onChange", a => a.OnChange, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageComboBox>(deep);
    }

    /// <summary>
    /// <para>Defines the Hyperlink Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:hyperlink.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>target, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTarget, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTarget</para>
        /// </summary>
        public StringValue GetTarget
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "hyperlink");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Hyperlink>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "alignLabel", a => a.AlignLabel)
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "target", a => a.Target, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getTarget", a => a.GetTarget, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Hyperlink>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageLabelControl Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:labelControl.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noWrap, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: noWrap</para>
        /// </summary>
        public BooleanValue NoWrap
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "labelControl");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageLabelControl>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "alignLabel", a => a.AlignLabel)
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "noWrap", a => a.NoWrap);
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "groupBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageGroupButton>();
            builder.AddChild<BackstageCheckBox>();
            builder.AddChild<BackstageEditBox>();
            builder.AddChild<BackstageDropDown>();
            builder.AddChild<RadioGroup>();
            builder.AddChild<BackstageComboBox>();
            builder.AddChild<Hyperlink>();
            builder.AddChild<BackstageLabelControl>();
            builder.AddChild<GroupBox>();
            builder.AddChild<LayoutContainer>();
            builder.AddChild<ImageControl>();
            builder.AddElement<GroupBox>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>align, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: align</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Align
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>layoutChildren, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: layoutChildren</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues> LayoutChildren
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "layoutContainer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageGroupButton>();
            builder.AddChild<BackstageCheckBox>();
            builder.AddChild<BackstageEditBox>();
            builder.AddChild<BackstageDropDown>();
            builder.AddChild<RadioGroup>();
            builder.AddChild<BackstageComboBox>();
            builder.AddChild<Hyperlink>();
            builder.AddChild<BackstageLabelControl>();
            builder.AddChild<GroupBox>();
            builder.AddChild<LayoutContainer>();
            builder.AddChild<ImageControl>();
            builder.AddElement<LayoutContainer>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "align", a => a.Align)
.AddAttribute(0, "expand", a => a.Expand)
.AddAttribute(0, "layoutChildren", a => a.LayoutChildren);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutContainer>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageControl Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:imageControl.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>altText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altText</para>
        /// </summary>
        public StringValue AltText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getAltText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getAltText</para>
        /// </summary>
        public StringValue GetAltText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "imageControl");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ImageControl>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "altText", a => a.AltText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getAltText", a => a.GetAltText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues> Style
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getStyle</para>
        /// </summary>
        public StringValue GetStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        public StringValue HelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        public StringValue GetHelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "group");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PrimaryItem>();
            builder.AddChild<TopItemsGroupControls>();
            builder.AddChild<BottomItemsGroupControls>();
            builder.AddElement<BackstageGroup>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "getStyle", a => a.GetStyle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "helperText", a => a.HelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getHelperText", a => a.GetHelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem), 0, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        public StringValue HelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        public StringValue GetHelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowedTaskSizes, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowedTaskSizes</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "taskGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TaskGroupCategory>();
            builder.AddElement<TaskGroup>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "helperText", a => a.HelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getHelperText", a => a.GetHelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "allowedTaskSizes", a => a.AllowedTaskSizes);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory), 0, 100, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        public StringValue GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlCloneRegular>();
            builder.AddChild<ButtonRegular>();
            builder.AddChild<CheckBox>();
            builder.AddChild<GalleryRegular>();
            builder.AddChild<ToggleButtonRegular>();
            builder.AddChild<MenuSeparator>();
            builder.AddChild<SplitButtonRegular>();
            builder.AddChild<MenuRegular>();
            builder.AddChild<DynamicMenuRegular>();
            builder.AddElement<MenuRoot>()
.AddAttribute(0, "title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "itemSize", a => a.ItemSize);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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
        public StringValue OnLoad
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>loadImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: loadImage</para>
        /// </summary>
        public StringValue LoadImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "customUI");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Commands>();
            builder.AddChild<Ribbon>();
            builder.AddChild<Backstage>();
            builder.AddChild<ContextMenus>();
            builder.AddElement<CustomUI>()
.AddAttribute(0, "onLoad", a => a.OnLoad, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "loadImage", a => a.LoadImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Commands), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "item");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Item>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Item>(deep);
    }

    /// <summary>
    /// <para>Defines the VisibleButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
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
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<VisibleButton>()
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the VisibleToggleButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
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
        public StringValue GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<VisibleToggleButton>()
.AddAttribute(0, "getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the Separator Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:separator.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "separator");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Separator>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "dialogBoxLauncher");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ButtonRegular>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010)
            };
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>autoScale, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: autoScale</para>
        /// </summary>
        public BooleanValue AutoScale
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>centerVertically, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: centerVertically</para>
        /// </summary>
        public BooleanValue CenterVertically
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "group");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlClone>();
            builder.AddChild<LabelControl>();
            builder.AddChild<Button>();
            builder.AddChild<ToggleButton>();
            builder.AddChild<CheckBox>();
            builder.AddChild<EditBox>();
            builder.AddChild<ComboBox>();
            builder.AddChild<DropDownRegular>();
            builder.AddChild<Gallery>();
            builder.AddChild<Menu>();
            builder.AddChild<DynamicMenu>();
            builder.AddChild<SplitButton>();
            builder.AddChild<Box>();
            builder.AddChild<ButtonGroup>();
            builder.AddChild<Separator>();
            builder.AddChild<DialogBoxLauncher>();
            builder.AddElement<Group>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "autoScale", a => a.AutoScale)
.AddAttribute(0, "centerVertically", a => a.CenterVertically);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlCloneQat Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        public StringValue GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        public BooleanValue ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        public StringValue GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "control");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ControlCloneQat>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showImage", a => a.ShowImage)
.AddAttribute(0, "getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.AddConstraint(new AttributeMutualExclusive(5, 6) /*:size, :getSize*/ { Version = FileFormatVersions.Office2010 });
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "sharedControls");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "documentControls");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ControlCloneQat>();
            builder.AddChild<ButtonRegular>();
            builder.AddChild<Separator>();
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "tab");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Group>();
            builder.AddElement<Tab>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 100)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Group), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

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
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "tabSet");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Tab>();
            builder.AddElement<TabSet>()
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tab), 0, 50, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabSet>(deep);
    }

    /// <summary>
    /// <para>Defines the Command Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:command.</para>
    /// </summary>
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
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "command");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Command>()
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
});
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "qat");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SharedControlsQatItems>();
            builder.AddChild<DocumentControlsQatItems>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems), 0, 1, version: FileFormatVersions.Office2010)
            };
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "tabs");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Tab>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tab), 1, 100, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "contextualTabs");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TabSet>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet), 1, 100, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "contextMenu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ControlCloneRegular>();
            builder.AddChild<ButtonRegular>();
            builder.AddChild<CheckBox>();
            builder.AddChild<GalleryRegular>();
            builder.AddChild<ToggleButtonRegular>();
            builder.AddChild<SplitButtonRegular>();
            builder.AddChild<MenuRegular>();
            builder.AddChild<DynamicMenuRegular>();
            builder.AddChild<MenuSeparatorNoTitle>();
            builder.AddElement<ContextMenu>()
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the ItemBackstageItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:item.</para>
    /// </summary>
    public partial class ItemBackstageItem : BackstageItemType
    {
        /// <summary>
        /// Initializes a new instance of the ItemBackstageItem class.
        /// </summary>
        public ItemBackstageItem() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "item");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ItemBackstageItem>(deep);
    }

    /// <summary>
    /// <para>Defines the RadioButtonBackstageItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:radioButton.</para>
    /// </summary>
    public partial class RadioButtonBackstageItem : BackstageItemType
    {
        /// <summary>
        /// Initializes a new instance of the RadioButtonBackstageItem class.
        /// </summary>
        public RadioButtonBackstageItem() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "radioButton");
            builder.Availability = FileFormatVersions.Office2010;
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<BackstageItemType>()
                           .AddAttribute(0, "id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
                           })
                           .AddAttribute(0, "label", a => a.Label, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
                           })
                           .AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the BackstageRegularButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
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
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        public BooleanValue IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageRegularButton>()
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "isDefinitive", a => a.IsDefinitive)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public StringValue Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        public StringValue GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        public StringValue Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        public StringValue GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageMenuGroup>();
            builder.AddElement<BackstagePrimaryMenu>()
.AddAttribute(0, "screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 0, 1000)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "menuGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageMenuButton>();
            builder.AddChild<BackstageMenuCheckBox>();
            builder.AddChild<BackstageSubMenu>();
            builder.AddChild<BackstageMenuToggleButton>();
            builder.AddElement<BackstageMenuGroup>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "itemSize", a => a.ItemSize);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "primaryItem");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageRegularButton>();
            builder.AddChild<BackstagePrimaryMenu>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu), 0, 1, version: FileFormatVersions.Office2010)
            };
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "topItems");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 1000)
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
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "bottomItems");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 1000)
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
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<BackstageGroupButton>();
            builder.AddChild<BackstageCheckBox>();
            builder.AddChild<BackstageEditBox>();
            builder.AddChild<BackstageDropDown>();
            builder.AddChild<RadioGroup>();
            builder.AddChild<BackstageComboBox>();
            builder.AddChild<Hyperlink>();
            builder.AddChild<BackstageLabelControl>();
            builder.AddChild<GroupBox>();
            builder.AddChild<LayoutContainer>();
            builder.AddChild<ImageControl>();
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "category");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TaskGroupTask>();
            builder.AddElement<TaskGroupCategory>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroupCategory>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskGroupTask Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:task.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        public BooleanValue IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "task");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<TaskGroupTask>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "isDefinitive", a => a.IsDefinitive)
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "category");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TaskFormGroupTask>();
            builder.AddElement<TaskFormGroupCategory>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        public StringValue GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "task");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageGroup>();
            builder.AddElement<TaskFormGroupTask>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        public StringValue HelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        public StringValue GetHelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        public BooleanValue ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        public StringValue GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowedTaskSizes, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowedTaskSizes</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "taskFormGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TaskFormGroupCategory>();
            builder.AddElement<TaskFormGroup>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "helperText", a => a.HelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute(0, "getHelperText", a => a.GetHelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "showLabel", a => a.ShowLabel)
.AddAttribute(0, "getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "allowedTaskSizes", a => a.AllowedTaskSizes);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory), 0, 100, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "firstColumn");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TaskFormGroup>();
            builder.AddChild<BackstageGroup>();
            builder.AddChild<TaskGroup>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
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
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "secondColumn");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageGroup>();
            builder.AddChild<TaskGroup>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        public StringValue GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnWidthPercent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columnWidthPercent</para>
        /// </summary>
        public IntegerValue ColumnWidthPercent
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstColumnMinWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: firstColumnMinWidth</para>
        /// </summary>
        public IntegerValue FirstColumnMinWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstColumnMaxWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: firstColumnMaxWidth</para>
        /// </summary>
        public IntegerValue FirstColumnMaxWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>secondColumnMinWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: secondColumnMinWidth</para>
        /// </summary>
        public IntegerValue SecondColumnMinWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>secondColumnMaxWidth, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: secondColumnMaxWidth</para>
        /// </summary>
        public IntegerValue SecondColumnMaxWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "tab");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageGroups>();
            builder.AddChild<SimpleGroups>();
            builder.AddElement<BackstageTab>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "columnWidthPercent", a => a.ColumnWidthPercent, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (99L), IsPositive = (true) });
})
.AddAttribute(0, "firstColumnMinWidth", a => a.FirstColumnMinWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
})
.AddAttribute(0, "firstColumnMaxWidth", a => a.FirstColumnMaxWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
})
.AddAttribute(0, "secondColumnMinWidth", a => a.SecondColumnMinWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
})
.AddAttribute(0, "secondColumnMaxWidth", a => a.SecondColumnMaxWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageTab>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageFastCommandButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
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
        public StringValue IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        public StringValue InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        public StringValue InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        public StringValue InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        public StringValue InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        public StringValue QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        public StringValue OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        public BooleanValue IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        public BooleanValue Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        public StringValue GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        public StringValue Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        public StringValue GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        public StringValue GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        public StringValue Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        public StringValue GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        public StringValue Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        public StringValue ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        public StringValue GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageFastCommandButton>()
.AddAttribute(0, "idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "isDefinitive", a => a.IsDefinitive)
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "visible", a => a.Visible)
.AddAttribute(0, "getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute(0, "getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "commands");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Command>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Command), 1, 5000, version: FileFormatVersions.Office2010)
            };
        }

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
        public BooleanValue StartFromScratch
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "ribbon");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<QuickAccessToolbar>();
            builder.AddChild<Tabs>();
            builder.AddChild<ContextualTabs>();
            builder.AddElement<Ribbon>()
.AddAttribute(0, "startFromScratch", a => a.StartFromScratch);
            builder.Particle = new CompositeParticle(ParticleType.All, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue OnShow
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onHide, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: onHide</para>
        /// </summary>
        public StringValue OnHide
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "backstage");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackstageTab>();
            builder.AddChild<BackstageFastCommandButton>();
            builder.AddElement<Backstage>()
.AddAttribute(0, "onShow", a => a.OnShow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute(0, "onHide", a => a.OnHide, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 0, 255)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(57, "contextMenus");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ContextMenu>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu), 1, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenus>(deep);
    }

    /// <summary>
    /// Defines the GalleryShowInRibbonValues enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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