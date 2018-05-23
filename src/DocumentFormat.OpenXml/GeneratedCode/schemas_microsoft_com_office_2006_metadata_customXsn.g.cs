// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.CustomXsn
{
/// <summary>
/// <para>Defines the CustomXsn Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:customXsn.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>XsnLocation &lt;ntns:xsnLocation></description></item>
///<item><description>CachedView &lt;ntns:cached></description></item>
///<item><description>OpenByDefault &lt;ntns:openByDefault></description></item>
///<item><description>Scope &lt;ntns:xsnScope></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(XsnLocation))]
    [ChildElementInfo(typeof(CachedView))]
    [ChildElementInfo(typeof(OpenByDefault))]
    [ChildElementInfo(typeof(Scope))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CustomXsn : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12706;
    /// <inheritdoc/>
    public override string LocalName => "customXsn";
    
    internal override byte NamespaceId => 39;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CustomXsn class.
    /// </summary>
    public CustomXsn():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CustomXsn class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomXsn(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public CustomXsn(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 39 == namespaceId && "xsnLocation" == name)
    return new XsnLocation();
    
if( 39 == namespaceId && "cached" == name)
    return new CachedView();
    
if( 39 == namespaceId && "openByDefault" == name)
    return new OpenByDefault();
    
if( 39 == namespaceId && "xsnScope" == name)
    return new Scope();
    

    return null;
}

        private static readonly string[] eleTagNames = { "xsnLocation","cached","openByDefault","xsnScope" };
    private static readonly byte[] eleNamespaceIds = { 39,39,39,39 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> XsnLocation.</para>
    /// <para> Represents the following element tag in the schema: ntns:xsnLocation </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public XsnLocation XsnLocation
    {
        get => GetElement<XsnLocation>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> CachedView.</para>
    /// <para> Represents the following element tag in the schema: ntns:cached </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public CachedView CachedView
    {
        get => GetElement<CachedView>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> OpenByDefault.</para>
    /// <para> Represents the following element tag in the schema: ntns:openByDefault </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public OpenByDefault OpenByDefault
    {
        get => GetElement<OpenByDefault>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Scope.</para>
    /// <para> Represents the following element tag in the schema: ntns:xsnScope </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public Scope Scope
    {
        get => GetElement<Scope>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXsn>(deep);

}
/// <summary>
/// <para>Defines the XsnLocation Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:xsnLocation.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class XsnLocation : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12707;
    /// <inheritdoc/>
    public override string LocalName => "xsnLocation";
    
    internal override byte NamespaceId => 39;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the XsnLocation class.
    /// </summary>
    public XsnLocation():base(){}
    
        /// <summary>
    /// Initializes a new instance of the XsnLocation class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public XsnLocation(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsnLocation>(deep);

}
/// <summary>
/// <para>Defines the CachedView Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:cached.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CachedView : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12708;
    /// <inheritdoc/>
    public override string LocalName => "cached";
    
    internal override byte NamespaceId => 39;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the CachedView class.
    /// </summary>
    public CachedView():base(){}
    
        /// <summary>
    /// Initializes a new instance of the CachedView class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CachedView(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedView>(deep);

}
/// <summary>
/// <para>Defines the OpenByDefault Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:openByDefault.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OpenByDefault : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12709;
    /// <inheritdoc/>
    public override string LocalName => "openByDefault";
    
    internal override byte NamespaceId => 39;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the OpenByDefault class.
    /// </summary>
    public OpenByDefault():base(){}
    
        /// <summary>
    /// Initializes a new instance of the OpenByDefault class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OpenByDefault(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OpenByDefault>(deep);

}
/// <summary>
/// <para>Defines the Scope Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:xsnScope.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Scope : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12710;
    /// <inheritdoc/>
    public override string LocalName => "xsnScope";
    
    internal override byte NamespaceId => 39;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Scope class.
    /// </summary>
    public Scope():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Scope class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Scope(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scope>(deep);

}
}
 
 
