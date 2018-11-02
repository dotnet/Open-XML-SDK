// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming
{
/// <summary>
/// <para>Defines the Key Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pRoam:key.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Key : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13436;
    /// <inheritdoc/>
    public override string LocalName => "key";
    
    internal override byte NamespaceId => 76;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the Key class.
    /// </summary>
    public Key():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Key class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Key(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Key>(deep);

}
/// <summary>
/// <para>Defines the Value Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pRoam:value.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Value : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13437;
    /// <inheritdoc/>
    public override string LocalName => "value";
    
    internal override byte NamespaceId => 76;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the Value class.
    /// </summary>
    public Value():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Value class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Value(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Value>(deep);

}
/// <summary>
/// <para>Defines the RoamingProperty Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pRoam:props.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Key &lt;pRoam:key></description></item>
///<item><description>Value &lt;pRoam:value></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Key), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Value), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class RoamingProperty : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13438;
    /// <inheritdoc/>
    public override string LocalName => "props";
    
    internal override byte NamespaceId => 76;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RoamingProperty class.
    /// </summary>
    public RoamingProperty():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RoamingProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RoamingProperty(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RoamingProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RoamingProperty(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RoamingProperty class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RoamingProperty(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 76 == namespaceId && "key" == name)
    return new Key();
    
if( 76 == namespaceId && "value" == name)
    return new Value();
    

    return null;
}

        private static readonly string[] eleTagNames = { "key","value" };
    private static readonly byte[] eleNamespaceIds = { 76,76 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Key.</para>
    /// <para> Represents the following element tag in the schema: pRoam:key </para>
    /// </summary>
    /// <remark>
    /// xmlns:pRoam = http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings
    /// </remark>
    public Key Key
    {
        get => GetElement<Key>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Value.</para>
    /// <para> Represents the following element tag in the schema: pRoam:value </para>
    /// </summary>
    /// <remark>
    /// xmlns:pRoam = http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings
    /// </remark>
    public Value Value
    {
        get => GetElement<Value>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoamingProperty>(deep);

}
}
 
 
