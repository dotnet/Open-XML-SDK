// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(40, "LongProperties")]
[Id(ElementTypeIdConst)]
public partial class LongProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12711;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LongProperties>(deep);

}
/// <summary>
/// <para>Defines the LongProperty Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is lp:LongProp.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(40, "LongProp")]
[Id(ElementTypeIdConst)]
public partial class LongProperty : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12712;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	

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
 
 
