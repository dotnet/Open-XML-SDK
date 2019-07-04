// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel
{
/// <summary>
/// <para>Defines the CustomPropertyEditors Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:customPropertyEditors.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShowOnOpen &lt;cdip:showOnOpen></description></item>
///<item><description>DefaultPropertyEditorNamespace &lt;cdip:defaultPropertyEditorNamespace></description></item>
///<item><description>CustomPropertyEditor &lt;cdip:customPropertyEditor></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShowOnOpen))]
    [ChildElementInfo(typeof(DefaultPropertyEditorNamespace))]
    [ChildElementInfo(typeof(CustomPropertyEditor))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(37, "customPropertyEditors")]
public partial class CustomPropertyEditors : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the CustomPropertyEditors class.
    /// </summary>
    public CustomPropertyEditors():base(){}
        /// <summary>
    ///Initializes a new instance of the CustomPropertyEditors class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomPropertyEditors(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public CustomPropertyEditors(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.ShowOnOpen), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.DefaultPropertyEditorNamespace), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.CustomPropertyEditor), 1, 0)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> ShowOnOpen.</para>
    /// <para> Represents the following element tag in the schema: cdip:showOnOpen </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
	[Index(0)]
    public ShowOnOpen ShowOnOpen
	{
        get => GetElement<ShowOnOpen>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> DefaultPropertyEditorNamespace.</para>
    /// <para> Represents the following element tag in the schema: cdip:defaultPropertyEditorNamespace </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
	[Index(1)]
    public DefaultPropertyEditorNamespace DefaultPropertyEditorNamespace
	{
        get => GetElement<DefaultPropertyEditorNamespace>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomPropertyEditors>(deep);

}
/// <summary>
/// <para>Defines the PropertyEditorNamespace Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:XMLNamespace.</para>
/// </summary>

[StringValidator(IsUri = true)]
[SchemaAttr(37, "XMLNamespace")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PropertyEditorNamespace : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the PropertyEditorNamespace class.
    /// </summary>
    public PropertyEditorNamespace():base(){}
    
        /// <summary>
    /// Initializes a new instance of the PropertyEditorNamespace class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PropertyEditorNamespace(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PropertyEditorNamespace>(deep);


}
/// <summary>
/// <para>Defines the DefaultPropertyEditorNamespace Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:defaultPropertyEditorNamespace.</para>
/// </summary>

[StringValidator(IsUri = true)]
[SchemaAttr(37, "defaultPropertyEditorNamespace")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DefaultPropertyEditorNamespace : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the DefaultPropertyEditorNamespace class.
    /// </summary>
    public DefaultPropertyEditorNamespace():base(){}
    
        /// <summary>
    /// Initializes a new instance of the DefaultPropertyEditorNamespace class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DefaultPropertyEditorNamespace(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultPropertyEditorNamespace>(deep);


}
/// <summary>
/// <para>Defines the XsnFileLocation Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:XSNLocation.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(37, "XSNLocation")]
public partial class XsnFileLocation : OpenXmlLeafTextElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the XsnFileLocation class.
    /// </summary>
    public XsnFileLocation():base(){}
    
        /// <summary>
    /// Initializes a new instance of the XsnFileLocation class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public XsnFileLocation(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsnFileLocation>(deep);

}
/// <summary>
/// <para>Defines the ShowOnOpen Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:showOnOpen.</para>
/// </summary>

[NumberValidator(SimpleType = typeof(BooleanValue))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(37, "showOnOpen")]
public partial class ShowOnOpen : OpenXmlLeafTextElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the ShowOnOpen class.
    /// </summary>
    public ShowOnOpen():base(){}
    
        /// <summary>
    /// Initializes a new instance of the ShowOnOpen class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ShowOnOpen(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new BooleanValue(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowOnOpen>(deep);

}
/// <summary>
/// <para>Defines the CustomPropertyEditor Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:customPropertyEditor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PropertyEditorNamespace &lt;cdip:XMLNamespace></description></item>
///<item><description>XsnFileLocation &lt;cdip:XSNLocation></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PropertyEditorNamespace))]
    [ChildElementInfo(typeof(XsnFileLocation))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(37, "customPropertyEditor")]
public partial class CustomPropertyEditor : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the CustomPropertyEditor class.
    /// </summary>
    public CustomPropertyEditor():base(){}
        /// <summary>
    ///Initializes a new instance of the CustomPropertyEditor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomPropertyEditor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public CustomPropertyEditor(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.PropertyEditorNamespace), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.XsnFileLocation), 1, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> PropertyEditorNamespace.</para>
    /// <para> Represents the following element tag in the schema: cdip:XMLNamespace </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
	[Index(0)]
    public PropertyEditorNamespace PropertyEditorNamespace
	{
        get => GetElement<PropertyEditorNamespace>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> XsnFileLocation.</para>
    /// <para> Represents the following element tag in the schema: cdip:XSNLocation </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
	[Index(1)]
    public XsnFileLocation XsnFileLocation
	{
        get => GetElement<XsnFileLocation>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomPropertyEditor>(deep);

}
}
