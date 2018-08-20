// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.LongProperties
{
/// <summary>
/// <para>Defines the LongProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is lp:LongProperties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LongProperty &lt;lp:LongProp></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LongProperty))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LongProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12711;
    /// <inheritdoc/>
    public override string LocalName => "LongProperties";
    
    internal override byte NamespaceId => 40;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LongProperties class.
    /// </summary>
    public LongProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LongProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LongProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LongProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LongProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LongProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LongProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 40 == namespaceId && "LongProp" == name)
    return new LongProperty();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LongProperties>(deep);

}
/// <summary>
/// <para>Defines the LongProperty Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is lp:LongProp.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LongProperty : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12712;
    /// <inheritdoc/>
    public override string LocalName => "LongProp";
    
    internal override byte NamespaceId => 40;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LongProperty class.
    /// </summary>
    public LongProperty():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the LongProperty class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LongProperty(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LongProperty>(deep);

}
}
 
 
