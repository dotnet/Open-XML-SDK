﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel
{
    /// <summary>
    /// <para>Defines the CustomPropertyEditors Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdip:customPropertyEditors.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShowOnOpen &lt;cdip:showOnOpen></description></item>
    ///   <item><description>DefaultPropertyEditorNamespace &lt;cdip:defaultPropertyEditorNamespace></description></item>
    ///   <item><description>CustomPropertyEditor &lt;cdip:customPropertyEditor></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ShowOnOpen))]
    [ChildElementInfo(typeof(DefaultPropertyEditorNamespace))]
    [ChildElementInfo(typeof(CustomPropertyEditor))]
    [SchemaAttr(37, "customPropertyEditors")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomPropertyEditors : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditors class.
        /// </summary>
        public CustomPropertyEditors() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditors class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomPropertyEditors(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditors class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomPropertyEditors(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditors class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomPropertyEditors(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ShowOnOpen.</para>
        /// <para>Represents the following element tag in the schema: cdip:showOnOpen.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
        /// </remark>
        public ShowOnOpen ShowOnOpen
        {
            get => GetElement<ShowOnOpen>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DefaultPropertyEditorNamespace.</para>
        /// <para>Represents the following element tag in the schema: cdip:defaultPropertyEditorNamespace.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
        /// </remark>
        public DefaultPropertyEditorNamespace DefaultPropertyEditorNamespace
        {
            get => GetElement<DefaultPropertyEditorNamespace>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.ShowOnOpen), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.DefaultPropertyEditorNamespace), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.CustomPropertyEditor), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomPropertyEditors>(deep);
    }

    /// <summary>
    /// <para>Defines the PropertyEditorNamespace Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdip:XMLNamespace.</para>
    /// </summary>
    [StringValidator(IsUri = true)]
    [SchemaAttr(37, "XMLNamespace")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PropertyEditorNamespace : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PropertyEditorNamespace class.
        /// </summary>
        public PropertyEditorNamespace() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyEditorNamespace class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PropertyEditorNamespace(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PropertyEditorNamespace>(deep);
    }

    /// <summary>
    /// <para>Defines the DefaultPropertyEditorNamespace Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdip:defaultPropertyEditorNamespace.</para>
    /// </summary>
    [StringValidator(IsUri = true)]
    [SchemaAttr(37, "defaultPropertyEditorNamespace")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DefaultPropertyEditorNamespace : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DefaultPropertyEditorNamespace class.
        /// </summary>
        public DefaultPropertyEditorNamespace() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefaultPropertyEditorNamespace class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DefaultPropertyEditorNamespace(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultPropertyEditorNamespace>(deep);
    }

    /// <summary>
    /// <para>Defines the XsnFileLocation Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdip:XSNLocation.</para>
    /// </summary>
    [SchemaAttr(37, "XSNLocation")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class XsnFileLocation : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the XsnFileLocation class.
        /// </summary>
        public XsnFileLocation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the XsnFileLocation class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public XsnFileLocation(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsnFileLocation>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowOnOpen Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdip:showOnOpen.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(BooleanValue))]
    [SchemaAttr(37, "showOnOpen")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShowOnOpen : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowOnOpen class.
        /// </summary>
        public ShowOnOpen() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowOnOpen class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ShowOnOpen(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowOnOpen>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomPropertyEditor Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdip:customPropertyEditor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PropertyEditorNamespace &lt;cdip:XMLNamespace></description></item>
    ///   <item><description>XsnFileLocation &lt;cdip:XSNLocation></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PropertyEditorNamespace))]
    [ChildElementInfo(typeof(XsnFileLocation))]
    [SchemaAttr(37, "customPropertyEditor")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomPropertyEditor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditor class.
        /// </summary>
        public CustomPropertyEditor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomPropertyEditor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomPropertyEditor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomPropertyEditor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomPropertyEditor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>PropertyEditorNamespace.</para>
        /// <para>Represents the following element tag in the schema: cdip:XMLNamespace.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
        /// </remark>
        public PropertyEditorNamespace PropertyEditorNamespace
        {
            get => GetElement<PropertyEditorNamespace>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>XsnFileLocation.</para>
        /// <para>Represents the following element tag in the schema: cdip:XSNLocation.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
        /// </remark>
        public XsnFileLocation XsnFileLocation
        {
            get => GetElement<XsnFileLocation>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.PropertyEditorNamespace), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.XsnFileLocation), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomPropertyEditor>(deep);
    }
}