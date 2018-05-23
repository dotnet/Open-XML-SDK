// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CustomPropertyEditors : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12699;
    /// <inheritdoc/>
    public override string LocalName => "customPropertyEditors";
    
    internal override byte NamespaceId => 37;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 37 == namespaceId && "showOnOpen" == name)
    return new ShowOnOpen();
    
if( 37 == namespaceId && "defaultPropertyEditorNamespace" == name)
    return new DefaultPropertyEditorNamespace();
    
if( 37 == namespaceId && "customPropertyEditor" == name)
    return new CustomPropertyEditor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "showOnOpen","defaultPropertyEditorNamespace","customPropertyEditor" };
    private static readonly byte[] eleNamespaceIds = { 37,37,37 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ShowOnOpen.</para>
    /// <para> Represents the following element tag in the schema: cdip:showOnOpen </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PropertyEditorNamespace : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12700;
    /// <inheritdoc/>
    public override string LocalName => "XMLNamespace";
    
    internal override byte NamespaceId => 37;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DefaultPropertyEditorNamespace : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12703;
    /// <inheritdoc/>
    public override string LocalName => "defaultPropertyEditorNamespace";
    
    internal override byte NamespaceId => 37;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class XsnFileLocation : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12701;
    /// <inheritdoc/>
    public override string LocalName => "XSNLocation";
    
    internal override byte NamespaceId => 37;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowOnOpen : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12702;
    /// <inheritdoc/>
    public override string LocalName => "showOnOpen";
    
    internal override byte NamespaceId => 37;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CustomPropertyEditor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12704;
    /// <inheritdoc/>
    public override string LocalName => "customPropertyEditor";
    
    internal override byte NamespaceId => 37;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 37 == namespaceId && "XMLNamespace" == name)
    return new PropertyEditorNamespace();
    
if( 37 == namespaceId && "XSNLocation" == name)
    return new XsnFileLocation();
    

    return null;
}

        private static readonly string[] eleTagNames = { "XMLNamespace","XSNLocation" };
    private static readonly byte[] eleNamespaceIds = { 37,37 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PropertyEditorNamespace.</para>
    /// <para> Represents the following element tag in the schema: cdip:XMLNamespace </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
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
    public XsnFileLocation XsnFileLocation
    {
        get => GetElement<XsnFileLocation>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomPropertyEditor>(deep);

}
}
 
 
