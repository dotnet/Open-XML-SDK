// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.VariantTypes;

namespace DocumentFormat.OpenXml.CustomProperties
{
/// <summary>
/// <para>Custom File Properties. The root element of CustomFilePropertiesPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is op:Properties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CustomDocumentProperty &lt;op:property></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(CustomDocumentProperty))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Properties : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10903;
    /// <inheritdoc/>
    public override string LocalName => "Properties";
    
    internal override byte NamespaceId => 4;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal Properties(CustomFilePropertiesPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the CustomFilePropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(CustomFilePropertiesPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the CustomFilePropertiesPart associated with this element.
    /// </summary>
    public CustomFilePropertiesPart CustomFilePropertiesPart
    {
		get => OpenXmlPart as CustomFilePropertiesPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the Properties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Properties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Properties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Properties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Properties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Properties(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the Properties class.
    /// </summary>
    public Properties():base(){}
    
    /// <summary>
    /// Saves the DOM into the CustomFilePropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(CustomFilePropertiesPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 4 == namespaceId && "property" == name)
    return new CustomDocumentProperty();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties>(deep);

}
/// <summary>
/// <para>Custom File Property.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is op:property.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTArray &lt;vt:array></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTBlob &lt;vt:blob></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTOBlob &lt;vt:oblob></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTEmpty &lt;vt:empty></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTNull &lt;vt:null></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTByte &lt;vt:i1></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTShort &lt;vt:i2></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTInt32 &lt;vt:i4></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTInt64 &lt;vt:i8></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTInteger &lt;vt:int></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte &lt;vt:ui1></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort &lt;vt:ui2></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32 &lt;vt:ui4></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64 &lt;vt:ui8></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger &lt;vt:uint></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTFloat &lt;vt:r4></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTDouble &lt;vt:r8></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTDecimal &lt;vt:decimal></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTLPSTR &lt;vt:lpstr></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTLPWSTR &lt;vt:lpwstr></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTBString &lt;vt:bstr></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTDate &lt;vt:date></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTFileTime &lt;vt:filetime></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTBool &lt;vt:bool></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTCurrency &lt;vt:cy></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTError &lt;vt:error></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTStreamData &lt;vt:stream></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTOStreamData &lt;vt:ostream></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTStorage &lt;vt:storage></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTOStorage &lt;vt:ostorage></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTVStreamData &lt;vt:vstream></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTClassId &lt;vt:clsid></description></item>
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTClipboardData &lt;vt:cf></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTArray))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTBlob))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTOBlob))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTEmpty))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTNull))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTByte))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTShort))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt32))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt64))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTInteger))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTFloat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTDouble))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTDecimal))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPSTR))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPWSTR))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTBString))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTDate))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTFileTime))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTBool))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTCurrency))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTError))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTStreamData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTOStreamData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTStorage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTOStorage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTVStreamData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTClassId))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTClipboardData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CustomDocumentProperty : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10904;
    /// <inheritdoc/>
    public override string LocalName => "property";
    
    internal override byte NamespaceId => 4;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "fmtid"),
		AttributeTag.Create<Int32Value>(0, "pid"),
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<StringValue>(0, "linkTarget")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Format ID.</para>
    /// <para>Represents the following attribute in the schema: fmtid </para>
    /// </summary>
    [SchemaAttr(0, "fmtid")]
    public StringValue FormatId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Property ID.</para>
    /// <para>Represents the following attribute in the schema: pid </para>
    /// </summary>
    [SchemaAttr(0, "pid")]
    public Int32Value PropertyId
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Custom File Property Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Bookmark Link Target.</para>
    /// <para>Represents the following attribute in the schema: linkTarget </para>
    /// </summary>
    [SchemaAttr(0, "linkTarget")]
    public StringValue LinkTarget
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CustomDocumentProperty class.
    /// </summary>
    public CustomDocumentProperty():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CustomDocumentProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomDocumentProperty(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomDocumentProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomDocumentProperty(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomDocumentProperty class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomDocumentProperty(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 5 == namespaceId && "vector" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTVector();
    
if( 5 == namespaceId && "array" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTArray();
    
if( 5 == namespaceId && "blob" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTBlob();
    
if( 5 == namespaceId && "oblob" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTOBlob();
    
if( 5 == namespaceId && "empty" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTEmpty();
    
if( 5 == namespaceId && "null" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTNull();
    
if( 5 == namespaceId && "i1" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTByte();
    
if( 5 == namespaceId && "i2" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTShort();
    
if( 5 == namespaceId && "i4" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTInt32();
    
if( 5 == namespaceId && "i8" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTInt64();
    
if( 5 == namespaceId && "int" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTInteger();
    
if( 5 == namespaceId && "ui1" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte();
    
if( 5 == namespaceId && "ui2" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort();
    
if( 5 == namespaceId && "ui4" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32();
    
if( 5 == namespaceId && "ui8" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64();
    
if( 5 == namespaceId && "uint" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger();
    
if( 5 == namespaceId && "r4" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTFloat();
    
if( 5 == namespaceId && "r8" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTDouble();
    
if( 5 == namespaceId && "decimal" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTDecimal();
    
if( 5 == namespaceId && "lpstr" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTLPSTR();
    
if( 5 == namespaceId && "lpwstr" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTLPWSTR();
    
if( 5 == namespaceId && "bstr" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTBString();
    
if( 5 == namespaceId && "date" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTDate();
    
if( 5 == namespaceId && "filetime" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTFileTime();
    
if( 5 == namespaceId && "bool" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTBool();
    
if( 5 == namespaceId && "cy" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTCurrency();
    
if( 5 == namespaceId && "error" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTError();
    
if( 5 == namespaceId && "stream" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTStreamData();
    
if( 5 == namespaceId && "ostream" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTOStreamData();
    
if( 5 == namespaceId && "storage" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTStorage();
    
if( 5 == namespaceId && "ostorage" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTOStorage();
    
if( 5 == namespaceId && "vstream" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTVStreamData();
    
if( 5 == namespaceId && "clsid" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTClassId();
    
if( 5 == namespaceId && "cf" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTClipboardData();
    

    return null;
}

        private static readonly string[] eleTagNames = { "vector","array","blob","oblob","empty","null","i1","i2","i4","i8","int","ui1","ui2","ui4","ui8","uint","r4","r8","decimal","lpstr","lpwstr","bstr","date","filetime","bool","cy","error","stream","ostream","storage","ostorage","vstream","clsid","cf" };
    private static readonly byte[] eleNamespaceIds = { 5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Vector.</para>
    /// <para> Represents the following element tag in the schema: vt:vector </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTVector VTVector
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Array.</para>
    /// <para> Represents the following element tag in the schema: vt:array </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTArray VTArray
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTArray>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Binary Blob.</para>
    /// <para> Represents the following element tag in the schema: vt:blob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTBlob VTBlob
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBlob>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Binary Blob Object.</para>
    /// <para> Represents the following element tag in the schema: vt:oblob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTOBlob VTOBlob
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTOBlob>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Empty.</para>
    /// <para> Represents the following element tag in the schema: vt:empty </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTEmpty VTEmpty
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTEmpty>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Null.</para>
    /// <para> Represents the following element tag in the schema: vt:null </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTNull VTNull
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTNull>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> 1-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTByte VTByte
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTByte>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> 2-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTShort VTShort
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTShort>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> 4-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTInt32 VTInt32
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTInt32>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> 8-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTInt64 VTInt64
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTInt64>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:int </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTInteger VTInteger
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTInteger>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> 1-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte VTUnsignedByte
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> 2-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort VTUnsignedShort
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> 4-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32 VTUnsignedInt32
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32>(13);
        set => SetElement(13, value);
    }
    /// <summary>
    /// <para> 8-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64 VTUnsignedInt64
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64>(14);
        set => SetElement(14, value);
    }
    /// <summary>
    /// <para> Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:uint </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger VTUnsignedInteger
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger>(15);
        set => SetElement(15, value);
    }
    /// <summary>
    /// <para> 4-Byte Real Number.</para>
    /// <para> Represents the following element tag in the schema: vt:r4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTFloat VTFloat
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTFloat>(16);
        set => SetElement(16, value);
    }
    /// <summary>
    /// <para> 8-Byte Real Number.</para>
    /// <para> Represents the following element tag in the schema: vt:r8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTDouble VTDouble
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTDouble>(17);
        set => SetElement(17, value);
    }
    /// <summary>
    /// <para> Decimal.</para>
    /// <para> Represents the following element tag in the schema: vt:decimal </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTDecimal VTDecimal
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTDecimal>(18);
        set => SetElement(18, value);
    }
    /// <summary>
    /// <para> LPSTR.</para>
    /// <para> Represents the following element tag in the schema: vt:lpstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTLPSTR VTLPSTR
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTLPSTR>(19);
        set => SetElement(19, value);
    }
    /// <summary>
    /// <para> LPWSTR.</para>
    /// <para> Represents the following element tag in the schema: vt:lpwstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTLPWSTR VTLPWSTR
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTLPWSTR>(20);
        set => SetElement(20, value);
    }
    /// <summary>
    /// <para> Basic String.</para>
    /// <para> Represents the following element tag in the schema: vt:bstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTBString VTBString
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBString>(21);
        set => SetElement(21, value);
    }
    /// <summary>
    /// <para> Date and Time.</para>
    /// <para> Represents the following element tag in the schema: vt:date </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTDate VTDate
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTDate>(22);
        set => SetElement(22, value);
    }
    /// <summary>
    /// <para> File Time.</para>
    /// <para> Represents the following element tag in the schema: vt:filetime </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTFileTime VTFileTime
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTFileTime>(23);
        set => SetElement(23, value);
    }
    /// <summary>
    /// <para> Boolean.</para>
    /// <para> Represents the following element tag in the schema: vt:bool </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTBool VTBool
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBool>(24);
        set => SetElement(24, value);
    }
    /// <summary>
    /// <para> Currency.</para>
    /// <para> Represents the following element tag in the schema: vt:cy </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTCurrency VTCurrency
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTCurrency>(25);
        set => SetElement(25, value);
    }
    /// <summary>
    /// <para> Error Status Code.</para>
    /// <para> Represents the following element tag in the schema: vt:error </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTError VTError
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTError>(26);
        set => SetElement(26, value);
    }
    /// <summary>
    /// <para> Binary Stream.</para>
    /// <para> Represents the following element tag in the schema: vt:stream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTStreamData VTStreamData
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTStreamData>(27);
        set => SetElement(27, value);
    }
    /// <summary>
    /// <para> Binary Stream Object.</para>
    /// <para> Represents the following element tag in the schema: vt:ostream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTOStreamData VTOStreamData
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTOStreamData>(28);
        set => SetElement(28, value);
    }
    /// <summary>
    /// <para> Binary Storage.</para>
    /// <para> Represents the following element tag in the schema: vt:storage </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTStorage VTStorage
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTStorage>(29);
        set => SetElement(29, value);
    }
    /// <summary>
    /// <para> Binary Storage Object.</para>
    /// <para> Represents the following element tag in the schema: vt:ostorage </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTOStorage VTOStorage
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTOStorage>(30);
        set => SetElement(30, value);
    }
    /// <summary>
    /// <para> Binary Versioned Stream.</para>
    /// <para> Represents the following element tag in the schema: vt:vstream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTVStreamData VTVStreamData
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVStreamData>(31);
        set => SetElement(31, value);
    }
    /// <summary>
    /// <para> Class ID.</para>
    /// <para> Represents the following element tag in the schema: vt:clsid </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTClassId VTClassId
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTClassId>(32);
        set => SetElement(32, value);
    }
    /// <summary>
    /// <para> Clipboard Data.</para>
    /// <para> Represents the following element tag in the schema: vt:cf </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTClipboardData VTClipboardData
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTClipboardData>(33);
        set => SetElement(33, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomDocumentProperty>(deep);

}
}
 
 
