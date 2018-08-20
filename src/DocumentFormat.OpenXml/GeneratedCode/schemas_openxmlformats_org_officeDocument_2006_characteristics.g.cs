// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.AdditionalCharacteristics
{
/// <summary>
/// <para>Set of Additional Characteristics.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ac:additionalCharacteristics.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Characteristic &lt;ac:characteristic></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Characteristic))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AdditionalCharacteristicsInfo : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10822;
    /// <inheritdoc/>
    public override string LocalName => "additionalCharacteristics";
    
    internal override byte NamespaceId => 8;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AdditionalCharacteristicsInfo class.
    /// </summary>
    public AdditionalCharacteristicsInfo():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AdditionalCharacteristicsInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AdditionalCharacteristicsInfo(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AdditionalCharacteristicsInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AdditionalCharacteristicsInfo(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AdditionalCharacteristicsInfo class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AdditionalCharacteristicsInfo(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 8 == namespaceId && "characteristic" == name)
    return new Characteristic();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AdditionalCharacteristicsInfo>(deep);

}
/// <summary>
/// <para>Single Characteristic.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ac:characteristic.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Characteristic : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10823;
    /// <inheritdoc/>
    public override string LocalName => "characteristic";
    
    internal override byte NamespaceId => 8;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues>>(0, "relation"),
		AttributeTag.Create<StringValue>(0, "val"),
		AttributeTag.Create<StringValue>(0, "vocabulary")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Name of Characteristic.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Relationship of Value to Name.</para>
    /// <para>Represents the following attribute in the schema: relation </para>
    /// </summary>
    [SchemaAttr(0, "relation")]
    public EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues> Relation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Characteristic Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Characteristic Grammar.</para>
    /// <para>Represents the following attribute in the schema: vocabulary </para>
    /// </summary>
    [SchemaAttr(0, "vocabulary")]
    public StringValue Vocabulary
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Characteristic class.
    /// </summary>
    public Characteristic():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Characteristic>(deep);

}
/// <summary>
/// Characteristic Relationship Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RelationValues
{  
	///<summary>
///Greater Than or Equal to.
///<para>When the item is serialized out as xml, its value is "ge".</para>
///</summary>
[EnumString("ge")]
GreaterThanOrEqualTo,
///<summary>
///Less Than or Equal To.
///<para>When the item is serialized out as xml, its value is "le".</para>
///</summary>
[EnumString("le")]
LessThanOrEqualTo,
///<summary>
///Greater Than.
///<para>When the item is serialized out as xml, its value is "gt".</para>
///</summary>
[EnumString("gt")]
GreaterThan,
///<summary>
///Less Than.
///<para>When the item is serialized out as xml, its value is "lt".</para>
///</summary>
[EnumString("lt")]
LessThan,
///<summary>
///Equal To.
///<para>When the item is serialized out as xml, its value is "eq".</para>
///</summary>
[EnumString("eq")]
EqualTo,
 
}
}
 
 
