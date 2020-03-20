﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Office2013.WebExtension;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.WebExtentionPane
{
    /// <summary>
    /// <para>Defines the Taskpanes Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:taskpanes.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>WebExtensionTaskpane &lt;wetp:taskpane></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(WebExtensionTaskpane), FileFormatVersions.Office2013)]
    [SchemaAttr(70, "taskpanes")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Taskpanes : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Taskpanes class.
        /// </summary>
        public Taskpanes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Taskpanes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Taskpanes(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Taskpanes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Taskpanes(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Taskpanes class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Taskpanes(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane), 0, 0, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Taskpanes>(deep);

        internal Taskpanes(WebExTaskpanesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WebExTaskpanesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WebExTaskpanesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WebExTaskpanesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WebExTaskpanesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart associated with this element.
        /// </summary>
        public WebExTaskpanesPart WebExTaskpanesPart
        {
            get => OpenXmlPart as WebExTaskpanesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the WebExtensionPartReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:webextensionref.</para>
    /// </summary>
    [SchemaAttr(70, "webextensionref")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class WebExtensionPartReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionPartReference class.
        /// </summary>
        public WebExtensionPartReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionPartReference>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
    [SchemaAttr(70, "extLst")]
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
    /// <para>Defines the WebExtensionTaskpane Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:taskpane.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>WebExtensionPartReference &lt;wetp:webextensionref></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;wetp:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(WebExtensionPartReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
    [SchemaAttr(70, "taskpane")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class WebExtensionTaskpane : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class.
        /// </summary>
        public WebExtensionTaskpane() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionTaskpane(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionTaskpane(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensionTaskpane(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>dockstate, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dockstate</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "dockstate")]
        [Index(0)]
        public StringValue DockState { get; set; }

        /// <summary>
        /// <para>visibility, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visibility</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "visibility")]
        [Index(1)]
        public BooleanValue Visibility { get; set; }

        /// <summary>
        /// <para>width, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: width</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "width")]
        [Index(2)]
        public DoubleValue Width { get; set; }

        /// <summary>
        /// <para>row, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: row</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "row")]
        [Index(3)]
        public UInt32Value Row { get; set; }

        /// <summary>
        /// <para>locked, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: locked</para>
        /// </summary>
        [SchemaAttr(0, "locked")]
        [Index(4)]
        public BooleanValue Locked { get; set; }

        /// <summary>
        /// <para>WebExtensionPartReference.</para>
        /// <para>Represents the following element tag in the schema: wetp:webextensionref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wetp = http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11
        /// </remark>
        public WebExtensionPartReference WebExtensionPartReference
        {
            get => GetElement<WebExtensionPartReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: wetp:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wetp = http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionTaskpane>(deep);
    }
}