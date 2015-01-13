// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.VariantTypes
{
/// <summary>
/// <para>Variant.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:variant.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Variant &lt;vt:variant></description></item>
///<item><description>VTVector &lt;vt:vector></description></item>
///<item><description>VTArray &lt;vt:array></description></item>
///<item><description>VTBlob &lt;vt:blob></description></item>
///<item><description>VTOBlob &lt;vt:oblob></description></item>
///<item><description>VTEmpty &lt;vt:empty></description></item>
///<item><description>VTNull &lt;vt:null></description></item>
///<item><description>VTByte &lt;vt:i1></description></item>
///<item><description>VTShort &lt;vt:i2></description></item>
///<item><description>VTInt32 &lt;vt:i4></description></item>
///<item><description>VTInt64 &lt;vt:i8></description></item>
///<item><description>VTInteger &lt;vt:int></description></item>
///<item><description>VTUnsignedByte &lt;vt:ui1></description></item>
///<item><description>VTUnsignedShort &lt;vt:ui2></description></item>
///<item><description>VTUnsignedInt32 &lt;vt:ui4></description></item>
///<item><description>VTUnsignedInt64 &lt;vt:ui8></description></item>
///<item><description>VTUnsignedInteger &lt;vt:uint></description></item>
///<item><description>VTFloat &lt;vt:r4></description></item>
///<item><description>VTDouble &lt;vt:r8></description></item>
///<item><description>VTDecimal &lt;vt:decimal></description></item>
///<item><description>VTLPSTR &lt;vt:lpstr></description></item>
///<item><description>VTLPWSTR &lt;vt:lpwstr></description></item>
///<item><description>VTBString &lt;vt:bstr></description></item>
///<item><description>VTDate &lt;vt:date></description></item>
///<item><description>VTFileTime &lt;vt:filetime></description></item>
///<item><description>VTBool &lt;vt:bool></description></item>
///<item><description>VTCurrency &lt;vt:cy></description></item>
///<item><description>VTError &lt;vt:error></description></item>
///<item><description>VTStreamData &lt;vt:stream></description></item>
///<item><description>VTOStreamData &lt;vt:ostream></description></item>
///<item><description>VTStorage &lt;vt:storage></description></item>
///<item><description>VTOStorage &lt;vt:ostorage></description></item>
///<item><description>VTVStreamData &lt;vt:vstream></description></item>
///<item><description>VTClassId &lt;vt:clsid></description></item>
///<item><description>VTClipboardData &lt;vt:cf></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Variant))]
    [ChildElementInfo(typeof(VTVector))]
    [ChildElementInfo(typeof(VTArray))]
    [ChildElementInfo(typeof(VTBlob))]
    [ChildElementInfo(typeof(VTOBlob))]
    [ChildElementInfo(typeof(VTEmpty))]
    [ChildElementInfo(typeof(VTNull))]
    [ChildElementInfo(typeof(VTByte))]
    [ChildElementInfo(typeof(VTShort))]
    [ChildElementInfo(typeof(VTInt32))]
    [ChildElementInfo(typeof(VTInt64))]
    [ChildElementInfo(typeof(VTInteger))]
    [ChildElementInfo(typeof(VTUnsignedByte))]
    [ChildElementInfo(typeof(VTUnsignedShort))]
    [ChildElementInfo(typeof(VTUnsignedInt32))]
    [ChildElementInfo(typeof(VTUnsignedInt64))]
    [ChildElementInfo(typeof(VTUnsignedInteger))]
    [ChildElementInfo(typeof(VTFloat))]
    [ChildElementInfo(typeof(VTDouble))]
    [ChildElementInfo(typeof(VTDecimal))]
    [ChildElementInfo(typeof(VTLPSTR))]
    [ChildElementInfo(typeof(VTLPWSTR))]
    [ChildElementInfo(typeof(VTBString))]
    [ChildElementInfo(typeof(VTDate))]
    [ChildElementInfo(typeof(VTFileTime))]
    [ChildElementInfo(typeof(VTBool))]
    [ChildElementInfo(typeof(VTCurrency))]
    [ChildElementInfo(typeof(VTError))]
    [ChildElementInfo(typeof(VTStreamData))]
    [ChildElementInfo(typeof(VTOStreamData))]
    [ChildElementInfo(typeof(VTStorage))]
    [ChildElementInfo(typeof(VTOStorage))]
    [ChildElementInfo(typeof(VTVStreamData))]
    [ChildElementInfo(typeof(VTClassId))]
    [ChildElementInfo(typeof(VTClipboardData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Variant : OpenXmlCompositeElement
{
    private const string tagName = "variant";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11029;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Variant class.
    /// </summary>
    public Variant():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Variant class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Variant(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Variant class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Variant(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Variant class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Variant(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 5 == namespaceId && "variant" == name)
    return new Variant();
    
if( 5 == namespaceId && "vector" == name)
    return new VTVector();
    
if( 5 == namespaceId && "array" == name)
    return new VTArray();
    
if( 5 == namespaceId && "blob" == name)
    return new VTBlob();
    
if( 5 == namespaceId && "oblob" == name)
    return new VTOBlob();
    
if( 5 == namespaceId && "empty" == name)
    return new VTEmpty();
    
if( 5 == namespaceId && "null" == name)
    return new VTNull();
    
if( 5 == namespaceId && "i1" == name)
    return new VTByte();
    
if( 5 == namespaceId && "i2" == name)
    return new VTShort();
    
if( 5 == namespaceId && "i4" == name)
    return new VTInt32();
    
if( 5 == namespaceId && "i8" == name)
    return new VTInt64();
    
if( 5 == namespaceId && "int" == name)
    return new VTInteger();
    
if( 5 == namespaceId && "ui1" == name)
    return new VTUnsignedByte();
    
if( 5 == namespaceId && "ui2" == name)
    return new VTUnsignedShort();
    
if( 5 == namespaceId && "ui4" == name)
    return new VTUnsignedInt32();
    
if( 5 == namespaceId && "ui8" == name)
    return new VTUnsignedInt64();
    
if( 5 == namespaceId && "uint" == name)
    return new VTUnsignedInteger();
    
if( 5 == namespaceId && "r4" == name)
    return new VTFloat();
    
if( 5 == namespaceId && "r8" == name)
    return new VTDouble();
    
if( 5 == namespaceId && "decimal" == name)
    return new VTDecimal();
    
if( 5 == namespaceId && "lpstr" == name)
    return new VTLPSTR();
    
if( 5 == namespaceId && "lpwstr" == name)
    return new VTLPWSTR();
    
if( 5 == namespaceId && "bstr" == name)
    return new VTBString();
    
if( 5 == namespaceId && "date" == name)
    return new VTDate();
    
if( 5 == namespaceId && "filetime" == name)
    return new VTFileTime();
    
if( 5 == namespaceId && "bool" == name)
    return new VTBool();
    
if( 5 == namespaceId && "cy" == name)
    return new VTCurrency();
    
if( 5 == namespaceId && "error" == name)
    return new VTError();
    
if( 5 == namespaceId && "stream" == name)
    return new VTStreamData();
    
if( 5 == namespaceId && "ostream" == name)
    return new VTOStreamData();
    
if( 5 == namespaceId && "storage" == name)
    return new VTStorage();
    
if( 5 == namespaceId && "ostorage" == name)
    return new VTOStorage();
    
if( 5 == namespaceId && "vstream" == name)
    return new VTVStreamData();
    
if( 5 == namespaceId && "clsid" == name)
    return new VTClassId();
    
if( 5 == namespaceId && "cf" == name)
    return new VTClipboardData();
    

    return null;
}

        private static readonly string[] eleTagNames = { "variant","vector","array","blob","oblob","empty","null","i1","i2","i4","i8","int","ui1","ui2","ui4","ui8","uint","r4","r8","decimal","lpstr","lpwstr","bstr","date","filetime","bool","cy","error","stream","ostream","storage","ostorage","vstream","clsid","cf" };
    private static readonly byte[] eleNamespaceIds = { 5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5 };
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneChoice;}
    }
    
        /// <summary>
    /// <para> Variant.</para>
    /// <para> Represents the following element tag in the schema: vt:variant </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public Variant InnerVariant
    {
        get 
        {
            return GetElement<Variant>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Vector.</para>
    /// <para> Represents the following element tag in the schema: vt:vector </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTVector VTVector
    {
        get 
        {
            return GetElement<VTVector>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Array.</para>
    /// <para> Represents the following element tag in the schema: vt:array </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTArray VTArray
    {
        get 
        {
            return GetElement<VTArray>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Binary Blob.</para>
    /// <para> Represents the following element tag in the schema: vt:blob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTBlob VTBlob
    {
        get 
        {
            return GetElement<VTBlob>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Binary Blob Object.</para>
    /// <para> Represents the following element tag in the schema: vt:oblob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTOBlob VTOBlob
    {
        get 
        {
            return GetElement<VTOBlob>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Empty.</para>
    /// <para> Represents the following element tag in the schema: vt:empty </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTEmpty VTEmpty
    {
        get 
        {
            return GetElement<VTEmpty>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> Null.</para>
    /// <para> Represents the following element tag in the schema: vt:null </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTNull VTNull
    {
        get 
        {
            return GetElement<VTNull>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }
    /// <summary>
    /// <para> 1-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTByte VTByte
    {
        get 
        {
            return GetElement<VTByte>(7);
        }
        set
        {
            SetElement(7, value);
        }
    }
    /// <summary>
    /// <para> 2-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTShort VTShort
    {
        get 
        {
            return GetElement<VTShort>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }
    /// <summary>
    /// <para> 4-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTInt32 VTInt32
    {
        get 
        {
            return GetElement<VTInt32>(9);
        }
        set
        {
            SetElement(9, value);
        }
    }
    /// <summary>
    /// <para> 8-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTInt64 VTInt64
    {
        get 
        {
            return GetElement<VTInt64>(10);
        }
        set
        {
            SetElement(10, value);
        }
    }
    /// <summary>
    /// <para> Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:int </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTInteger VTInteger
    {
        get 
        {
            return GetElement<VTInteger>(11);
        }
        set
        {
            SetElement(11, value);
        }
    }
    /// <summary>
    /// <para> 1-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTUnsignedByte VTUnsignedByte
    {
        get 
        {
            return GetElement<VTUnsignedByte>(12);
        }
        set
        {
            SetElement(12, value);
        }
    }
    /// <summary>
    /// <para> 2-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTUnsignedShort VTUnsignedShort
    {
        get 
        {
            return GetElement<VTUnsignedShort>(13);
        }
        set
        {
            SetElement(13, value);
        }
    }
    /// <summary>
    /// <para> 4-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTUnsignedInt32 VTUnsignedInt32
    {
        get 
        {
            return GetElement<VTUnsignedInt32>(14);
        }
        set
        {
            SetElement(14, value);
        }
    }
    /// <summary>
    /// <para> 8-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTUnsignedInt64 VTUnsignedInt64
    {
        get 
        {
            return GetElement<VTUnsignedInt64>(15);
        }
        set
        {
            SetElement(15, value);
        }
    }
    /// <summary>
    /// <para> Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:uint </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTUnsignedInteger VTUnsignedInteger
    {
        get 
        {
            return GetElement<VTUnsignedInteger>(16);
        }
        set
        {
            SetElement(16, value);
        }
    }
    /// <summary>
    /// <para> 4-Byte Real Number.</para>
    /// <para> Represents the following element tag in the schema: vt:r4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTFloat VTFloat
    {
        get 
        {
            return GetElement<VTFloat>(17);
        }
        set
        {
            SetElement(17, value);
        }
    }
    /// <summary>
    /// <para> 8-Byte Real Number.</para>
    /// <para> Represents the following element tag in the schema: vt:r8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTDouble VTDouble
    {
        get 
        {
            return GetElement<VTDouble>(18);
        }
        set
        {
            SetElement(18, value);
        }
    }
    /// <summary>
    /// <para> Decimal.</para>
    /// <para> Represents the following element tag in the schema: vt:decimal </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTDecimal VTDecimal
    {
        get 
        {
            return GetElement<VTDecimal>(19);
        }
        set
        {
            SetElement(19, value);
        }
    }
    /// <summary>
    /// <para> LPSTR.</para>
    /// <para> Represents the following element tag in the schema: vt:lpstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTLPSTR VTLPSTR
    {
        get 
        {
            return GetElement<VTLPSTR>(20);
        }
        set
        {
            SetElement(20, value);
        }
    }
    /// <summary>
    /// <para> LPWSTR.</para>
    /// <para> Represents the following element tag in the schema: vt:lpwstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTLPWSTR VTLPWSTR
    {
        get 
        {
            return GetElement<VTLPWSTR>(21);
        }
        set
        {
            SetElement(21, value);
        }
    }
    /// <summary>
    /// <para> Basic String.</para>
    /// <para> Represents the following element tag in the schema: vt:bstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTBString VTBString
    {
        get 
        {
            return GetElement<VTBString>(22);
        }
        set
        {
            SetElement(22, value);
        }
    }
    /// <summary>
    /// <para> Date and Time.</para>
    /// <para> Represents the following element tag in the schema: vt:date </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTDate VTDate
    {
        get 
        {
            return GetElement<VTDate>(23);
        }
        set
        {
            SetElement(23, value);
        }
    }
    /// <summary>
    /// <para> File Time.</para>
    /// <para> Represents the following element tag in the schema: vt:filetime </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTFileTime VTFileTime
    {
        get 
        {
            return GetElement<VTFileTime>(24);
        }
        set
        {
            SetElement(24, value);
        }
    }
    /// <summary>
    /// <para> Boolean.</para>
    /// <para> Represents the following element tag in the schema: vt:bool </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTBool VTBool
    {
        get 
        {
            return GetElement<VTBool>(25);
        }
        set
        {
            SetElement(25, value);
        }
    }
    /// <summary>
    /// <para> Currency.</para>
    /// <para> Represents the following element tag in the schema: vt:cy </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTCurrency VTCurrency
    {
        get 
        {
            return GetElement<VTCurrency>(26);
        }
        set
        {
            SetElement(26, value);
        }
    }
    /// <summary>
    /// <para> Error Status Code.</para>
    /// <para> Represents the following element tag in the schema: vt:error </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTError VTError
    {
        get 
        {
            return GetElement<VTError>(27);
        }
        set
        {
            SetElement(27, value);
        }
    }
    /// <summary>
    /// <para> Binary Stream.</para>
    /// <para> Represents the following element tag in the schema: vt:stream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTStreamData VTStreamData
    {
        get 
        {
            return GetElement<VTStreamData>(28);
        }
        set
        {
            SetElement(28, value);
        }
    }
    /// <summary>
    /// <para> Binary Stream Object.</para>
    /// <para> Represents the following element tag in the schema: vt:ostream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTOStreamData VTOStreamData
    {
        get 
        {
            return GetElement<VTOStreamData>(29);
        }
        set
        {
            SetElement(29, value);
        }
    }
    /// <summary>
    /// <para> Binary Storage.</para>
    /// <para> Represents the following element tag in the schema: vt:storage </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTStorage VTStorage
    {
        get 
        {
            return GetElement<VTStorage>(30);
        }
        set
        {
            SetElement(30, value);
        }
    }
    /// <summary>
    /// <para> Binary Storage Object.</para>
    /// <para> Represents the following element tag in the schema: vt:ostorage </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTOStorage VTOStorage
    {
        get 
        {
            return GetElement<VTOStorage>(31);
        }
        set
        {
            SetElement(31, value);
        }
    }
    /// <summary>
    /// <para> Binary Versioned Stream.</para>
    /// <para> Represents the following element tag in the schema: vt:vstream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTVStreamData VTVStreamData
    {
        get 
        {
            return GetElement<VTVStreamData>(32);
        }
        set
        {
            SetElement(32, value);
        }
    }
    /// <summary>
    /// <para> Class ID.</para>
    /// <para> Represents the following element tag in the schema: vt:clsid </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTClassId VTClassId
    {
        get 
        {
            return GetElement<VTClassId>(33);
        }
        set
        {
            SetElement(33, value);
        }
    }
    /// <summary>
    /// <para> Clipboard Data.</para>
    /// <para> Represents the following element tag in the schema: vt:cf </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public VTClipboardData VTClipboardData
    {
        get 
        {
            return GetElement<VTClipboardData>(34);
        }
        set
        {
            SetElement(34, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Variant>(deep);
    }

   
}
/// <summary>
/// <para>Vector.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:vector.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Variant &lt;vt:variant></description></item>
///<item><description>VTByte &lt;vt:i1></description></item>
///<item><description>VTShort &lt;vt:i2></description></item>
///<item><description>VTInt32 &lt;vt:i4></description></item>
///<item><description>VTInt64 &lt;vt:i8></description></item>
///<item><description>VTUnsignedByte &lt;vt:ui1></description></item>
///<item><description>VTUnsignedShort &lt;vt:ui2></description></item>
///<item><description>VTUnsignedInt32 &lt;vt:ui4></description></item>
///<item><description>VTUnsignedInt64 &lt;vt:ui8></description></item>
///<item><description>VTFloat &lt;vt:r4></description></item>
///<item><description>VTDouble &lt;vt:r8></description></item>
///<item><description>VTLPSTR &lt;vt:lpstr></description></item>
///<item><description>VTLPWSTR &lt;vt:lpwstr></description></item>
///<item><description>VTBString &lt;vt:bstr></description></item>
///<item><description>VTDate &lt;vt:date></description></item>
///<item><description>VTFileTime &lt;vt:filetime></description></item>
///<item><description>VTBool &lt;vt:bool></description></item>
///<item><description>VTCurrency &lt;vt:cy></description></item>
///<item><description>VTError &lt;vt:error></description></item>
///<item><description>VTClassId &lt;vt:clsid></description></item>
///<item><description>VTClipboardData &lt;vt:cf></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Variant))]
    [ChildElementInfo(typeof(VTByte))]
    [ChildElementInfo(typeof(VTShort))]
    [ChildElementInfo(typeof(VTInt32))]
    [ChildElementInfo(typeof(VTInt64))]
    [ChildElementInfo(typeof(VTUnsignedByte))]
    [ChildElementInfo(typeof(VTUnsignedShort))]
    [ChildElementInfo(typeof(VTUnsignedInt32))]
    [ChildElementInfo(typeof(VTUnsignedInt64))]
    [ChildElementInfo(typeof(VTFloat))]
    [ChildElementInfo(typeof(VTDouble))]
    [ChildElementInfo(typeof(VTLPSTR))]
    [ChildElementInfo(typeof(VTLPWSTR))]
    [ChildElementInfo(typeof(VTBString))]
    [ChildElementInfo(typeof(VTDate))]
    [ChildElementInfo(typeof(VTFileTime))]
    [ChildElementInfo(typeof(VTBool))]
    [ChildElementInfo(typeof(VTCurrency))]
    [ChildElementInfo(typeof(VTError))]
    [ChildElementInfo(typeof(VTClassId))]
    [ChildElementInfo(typeof(VTClipboardData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTVector : OpenXmlCompositeElement
{
    private const string tagName = "vector";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11030;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "baseType","size" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Vector Base Type.</para>
    /// <para>Represents the following attribute in the schema: baseType </para>
    /// </summary>
    [SchemaAttr(0, "baseType")]
    public EnumValue<DocumentFormat.OpenXml.VariantTypes.VectorBaseValues> BaseType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.VariantTypes.VectorBaseValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Vector Size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public UInt32Value Size
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the VTVector class.
    /// </summary>
    public VTVector():base(){}
    
            /// <summary>
    ///Initializes a new instance of the VTVector class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VTVector(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the VTVector class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VTVector(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the VTVector class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public VTVector(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 5 == namespaceId && "variant" == name)
    return new Variant();
    
if( 5 == namespaceId && "i1" == name)
    return new VTByte();
    
if( 5 == namespaceId && "i2" == name)
    return new VTShort();
    
if( 5 == namespaceId && "i4" == name)
    return new VTInt32();
    
if( 5 == namespaceId && "i8" == name)
    return new VTInt64();
    
if( 5 == namespaceId && "ui1" == name)
    return new VTUnsignedByte();
    
if( 5 == namespaceId && "ui2" == name)
    return new VTUnsignedShort();
    
if( 5 == namespaceId && "ui4" == name)
    return new VTUnsignedInt32();
    
if( 5 == namespaceId && "ui8" == name)
    return new VTUnsignedInt64();
    
if( 5 == namespaceId && "r4" == name)
    return new VTFloat();
    
if( 5 == namespaceId && "r8" == name)
    return new VTDouble();
    
if( 5 == namespaceId && "lpstr" == name)
    return new VTLPSTR();
    
if( 5 == namespaceId && "lpwstr" == name)
    return new VTLPWSTR();
    
if( 5 == namespaceId && "bstr" == name)
    return new VTBString();
    
if( 5 == namespaceId && "date" == name)
    return new VTDate();
    
if( 5 == namespaceId && "filetime" == name)
    return new VTFileTime();
    
if( 5 == namespaceId && "bool" == name)
    return new VTBool();
    
if( 5 == namespaceId && "cy" == name)
    return new VTCurrency();
    
if( 5 == namespaceId && "error" == name)
    return new VTError();
    
if( 5 == namespaceId && "clsid" == name)
    return new VTClassId();
    
if( 5 == namespaceId && "cf" == name)
    return new VTClipboardData();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "baseType" == name)
    return new EnumValue<DocumentFormat.OpenXml.VariantTypes.VectorBaseValues>();
    
if( 0 == namespaceId && "size" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTVector>(deep);
    }

   
}
/// <summary>
/// <para>Array.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:array.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Variant &lt;vt:variant></description></item>
///<item><description>VTByte &lt;vt:i1></description></item>
///<item><description>VTShort &lt;vt:i2></description></item>
///<item><description>VTInt32 &lt;vt:i4></description></item>
///<item><description>VTInteger &lt;vt:int></description></item>
///<item><description>VTUnsignedByte &lt;vt:ui1></description></item>
///<item><description>VTUnsignedShort &lt;vt:ui2></description></item>
///<item><description>VTUnsignedInt32 &lt;vt:ui4></description></item>
///<item><description>VTUnsignedInteger &lt;vt:uint></description></item>
///<item><description>VTFloat &lt;vt:r4></description></item>
///<item><description>VTDouble &lt;vt:r8></description></item>
///<item><description>VTDecimal &lt;vt:decimal></description></item>
///<item><description>VTBString &lt;vt:bstr></description></item>
///<item><description>VTDate &lt;vt:date></description></item>
///<item><description>VTBool &lt;vt:bool></description></item>
///<item><description>VTError &lt;vt:error></description></item>
///<item><description>VTCurrency &lt;vt:cy></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Variant))]
    [ChildElementInfo(typeof(VTByte))]
    [ChildElementInfo(typeof(VTShort))]
    [ChildElementInfo(typeof(VTInt32))]
    [ChildElementInfo(typeof(VTInteger))]
    [ChildElementInfo(typeof(VTUnsignedByte))]
    [ChildElementInfo(typeof(VTUnsignedShort))]
    [ChildElementInfo(typeof(VTUnsignedInt32))]
    [ChildElementInfo(typeof(VTUnsignedInteger))]
    [ChildElementInfo(typeof(VTFloat))]
    [ChildElementInfo(typeof(VTDouble))]
    [ChildElementInfo(typeof(VTDecimal))]
    [ChildElementInfo(typeof(VTBString))]
    [ChildElementInfo(typeof(VTDate))]
    [ChildElementInfo(typeof(VTBool))]
    [ChildElementInfo(typeof(VTError))]
    [ChildElementInfo(typeof(VTCurrency))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTArray : OpenXmlCompositeElement
{
    private const string tagName = "array";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11031;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "lBound","uBound","baseType" };
    private static byte[] attributeNamespaceIds = { 0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Array Lower Bounds Attribute.</para>
    /// <para>Represents the following attribute in the schema: lBound </para>
    /// </summary>
    [SchemaAttr(0, "lBound")]
    public Int32Value LowerBounds
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Array Upper Bounds Attribute.</para>
    /// <para>Represents the following attribute in the schema: uBound </para>
    /// </summary>
    [SchemaAttr(0, "uBound")]
    public Int32Value UpperBounds
    {
        get { return (Int32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Array Base Type.</para>
    /// <para>Represents the following attribute in the schema: baseType </para>
    /// </summary>
    [SchemaAttr(0, "baseType")]
    public EnumValue<DocumentFormat.OpenXml.VariantTypes.ArrayBaseValues> BaseType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.VariantTypes.ArrayBaseValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the VTArray class.
    /// </summary>
    public VTArray():base(){}
    
            /// <summary>
    ///Initializes a new instance of the VTArray class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VTArray(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the VTArray class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VTArray(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the VTArray class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public VTArray(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 5 == namespaceId && "variant" == name)
    return new Variant();
    
if( 5 == namespaceId && "i1" == name)
    return new VTByte();
    
if( 5 == namespaceId && "i2" == name)
    return new VTShort();
    
if( 5 == namespaceId && "i4" == name)
    return new VTInt32();
    
if( 5 == namespaceId && "int" == name)
    return new VTInteger();
    
if( 5 == namespaceId && "ui1" == name)
    return new VTUnsignedByte();
    
if( 5 == namespaceId && "ui2" == name)
    return new VTUnsignedShort();
    
if( 5 == namespaceId && "ui4" == name)
    return new VTUnsignedInt32();
    
if( 5 == namespaceId && "uint" == name)
    return new VTUnsignedInteger();
    
if( 5 == namespaceId && "r4" == name)
    return new VTFloat();
    
if( 5 == namespaceId && "r8" == name)
    return new VTDouble();
    
if( 5 == namespaceId && "decimal" == name)
    return new VTDecimal();
    
if( 5 == namespaceId && "bstr" == name)
    return new VTBString();
    
if( 5 == namespaceId && "date" == name)
    return new VTDate();
    
if( 5 == namespaceId && "bool" == name)
    return new VTBool();
    
if( 5 == namespaceId && "error" == name)
    return new VTError();
    
if( 5 == namespaceId && "cy" == name)
    return new VTCurrency();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "lBound" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "uBound" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "baseType" == name)
    return new EnumValue<DocumentFormat.OpenXml.VariantTypes.ArrayBaseValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTArray>(deep);
    }

   
}
/// <summary>
/// <para>Binary Blob.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:blob.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTBlob : OpenXmlLeafTextElement
{
    private const string tagName = "blob";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11032;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTBlob class.
    /// </summary>
    public VTBlob():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTBlob class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTBlob(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTBlob>(deep);
    }

}
/// <summary>
/// <para>Binary Blob Object.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:oblob.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTOBlob : OpenXmlLeafTextElement
{
    private const string tagName = "oblob";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11033;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTOBlob class.
    /// </summary>
    public VTOBlob():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTOBlob class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTOBlob(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTOBlob>(deep);
    }

}
/// <summary>
/// <para>Binary Stream.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:stream.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTStreamData : OpenXmlLeafTextElement
{
    private const string tagName = "stream";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11057;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTStreamData class.
    /// </summary>
    public VTStreamData():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTStreamData class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTStreamData(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTStreamData>(deep);
    }

}
/// <summary>
/// <para>Binary Stream Object.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ostream.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTOStreamData : OpenXmlLeafTextElement
{
    private const string tagName = "ostream";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11058;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTOStreamData class.
    /// </summary>
    public VTOStreamData():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTOStreamData class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTOStreamData(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTOStreamData>(deep);
    }

}
/// <summary>
/// <para>Binary Storage.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:storage.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTStorage : OpenXmlLeafTextElement
{
    private const string tagName = "storage";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11059;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTStorage class.
    /// </summary>
    public VTStorage():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTStorage class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTStorage(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTStorage>(deep);
    }

}
/// <summary>
/// <para>Binary Storage Object.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ostorage.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTOStorage : OpenXmlLeafTextElement
{
    private const string tagName = "ostorage";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11060;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTOStorage class.
    /// </summary>
    public VTOStorage():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTOStorage class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTOStorage(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTOStorage>(deep);
    }

}
/// <summary>
/// <para>Empty.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:empty.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTEmpty : OpenXmlLeafElement
{
    private const string tagName = "empty";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11034;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTEmpty class.
    /// </summary>
    public VTEmpty():base(){}
    
      
     
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTEmpty>(deep);
    }

   
}
/// <summary>
/// <para>Null.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:null.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTNull : OpenXmlLeafElement
{
    private const string tagName = "null";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11035;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTNull class.
    /// </summary>
    public VTNull():base(){}
    
      
     
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTNull>(deep);
    }

   
}
/// <summary>
/// <para>1-Byte Signed Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i1.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTByte : OpenXmlLeafTextElement
{
    private const string tagName = "i1";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11036;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTByte class.
    /// </summary>
    public VTByte():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTByte class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTByte(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new SByteValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTByte>(deep);
    }

   
}
/// <summary>
/// <para>2-Byte Signed Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i2.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTShort : OpenXmlLeafTextElement
{
    private const string tagName = "i2";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11037;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTShort class.
    /// </summary>
    public VTShort():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTShort class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTShort(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int16Value(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTShort>(deep);
    }

   
}
/// <summary>
/// <para>4-Byte Signed Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i4.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTInt32 : OpenXmlLeafTextElement
{
    private const string tagName = "i4";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11038;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTInt32 class.
    /// </summary>
    public VTInt32():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTInt32 class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTInt32(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTInt32>(deep);
    }

}
/// <summary>
/// <para>Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:int.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTInteger : OpenXmlLeafTextElement
{
    private const string tagName = "int";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11040;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTInteger class.
    /// </summary>
    public VTInteger():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTInteger class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTInteger(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTInteger>(deep);
    }

}
/// <summary>
/// <para>8-Byte Signed Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i8.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTInt64 : OpenXmlLeafTextElement
{
    private const string tagName = "i8";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11039;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTInt64 class.
    /// </summary>
    public VTInt64():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTInt64 class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTInt64(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int64Value(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTInt64>(deep);
    }

   
}
/// <summary>
/// <para>1-Byte Unsigned Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui1.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTUnsignedByte : OpenXmlLeafTextElement
{
    private const string tagName = "ui1";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11041;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTUnsignedByte class.
    /// </summary>
    public VTUnsignedByte():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTUnsignedByte class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTUnsignedByte(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new ByteValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTUnsignedByte>(deep);
    }

   
}
/// <summary>
/// <para>2-Byte Unsigned Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui2.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTUnsignedShort : OpenXmlLeafTextElement
{
    private const string tagName = "ui2";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11042;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTUnsignedShort class.
    /// </summary>
    public VTUnsignedShort():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTUnsignedShort class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTUnsignedShort(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new UInt16Value(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTUnsignedShort>(deep);
    }

   
}
/// <summary>
/// <para>4-Byte Unsigned Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui4.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTUnsignedInt32 : OpenXmlLeafTextElement
{
    private const string tagName = "ui4";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11043;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTUnsignedInt32 class.
    /// </summary>
    public VTUnsignedInt32():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTUnsignedInt32 class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTUnsignedInt32(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new UInt32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTUnsignedInt32>(deep);
    }

}
/// <summary>
/// <para>Unsigned Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:uint.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTUnsignedInteger : OpenXmlLeafTextElement
{
    private const string tagName = "uint";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11045;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTUnsignedInteger class.
    /// </summary>
    public VTUnsignedInteger():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTUnsignedInteger class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTUnsignedInteger(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new UInt32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTUnsignedInteger>(deep);
    }

}
/// <summary>
/// <para>8-Byte Unsigned Integer.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui8.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTUnsignedInt64 : OpenXmlLeafTextElement
{
    private const string tagName = "ui8";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11044;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTUnsignedInt64 class.
    /// </summary>
    public VTUnsignedInt64():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTUnsignedInt64 class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTUnsignedInt64(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new UInt64Value(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTUnsignedInt64>(deep);
    }

   
}
/// <summary>
/// <para>4-Byte Real Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:r4.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTFloat : OpenXmlLeafTextElement
{
    private const string tagName = "r4";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11046;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTFloat class.
    /// </summary>
    public VTFloat():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTFloat class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTFloat(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new SingleValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTFloat>(deep);
    }

   
}
/// <summary>
/// <para>8-Byte Real Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:r8.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTDouble : OpenXmlLeafTextElement
{
    private const string tagName = "r8";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11047;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTDouble class.
    /// </summary>
    public VTDouble():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTDouble class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTDouble(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new DoubleValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTDouble>(deep);
    }

   
}
/// <summary>
/// <para>Decimal.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:decimal.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTDecimal : OpenXmlLeafTextElement
{
    private const string tagName = "decimal";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11048;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTDecimal class.
    /// </summary>
    public VTDecimal():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTDecimal class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTDecimal(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new DecimalValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTDecimal>(deep);
    }

   
}
/// <summary>
/// <para>LPSTR.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:lpstr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTLPSTR : OpenXmlLeafTextElement
{
    private const string tagName = "lpstr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11049;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTLPSTR class.
    /// </summary>
    public VTLPSTR():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTLPSTR class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTLPSTR(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTLPSTR>(deep);
    }

}
/// <summary>
/// <para>LPWSTR.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:lpwstr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTLPWSTR : OpenXmlLeafTextElement
{
    private const string tagName = "lpwstr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11050;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTLPWSTR class.
    /// </summary>
    public VTLPWSTR():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTLPWSTR class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTLPWSTR(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTLPWSTR>(deep);
    }

}
/// <summary>
/// <para>Basic String.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:bstr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTBString : OpenXmlLeafTextElement
{
    private const string tagName = "bstr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11051;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTBString class.
    /// </summary>
    public VTBString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTBString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTBString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTBString>(deep);
    }

}
/// <summary>
/// <para>Date and Time.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:date.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTDate : OpenXmlLeafTextElement
{
    private const string tagName = "date";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11052;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTDate class.
    /// </summary>
    public VTDate():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTDate class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTDate(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new DateTimeValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTDate>(deep);
    }

}
/// <summary>
/// <para>File Time.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:filetime.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTFileTime : OpenXmlLeafTextElement
{
    private const string tagName = "filetime";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11053;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VTFileTime class.
    /// </summary>
    public VTFileTime():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VTFileTime class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTFileTime(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new DateTimeValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTFileTime>(deep);
    }

}
/// <summary>
/// <para>Boolean.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:bool.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTBool : OpenXmlLeafTextElement
{
    private const string tagName = "bool";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11054;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTBool class.
    /// </summary>
    public VTBool():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTBool class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTBool(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new BooleanValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTBool>(deep);
    }

   
}
/// <summary>
/// <para>Currency.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:cy.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTCurrency : OpenXmlLeafTextElement
{
    private const string tagName = "cy";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11055;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTCurrency class.
    /// </summary>
    public VTCurrency():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTCurrency class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTCurrency(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTCurrency>(deep);
    }

   
}
/// <summary>
/// <para>Error Status Code.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:error.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTError : OpenXmlLeafTextElement
{
    private const string tagName = "error";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11056;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTError class.
    /// </summary>
    public VTError():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTError class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTError(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTError>(deep);
    }

   
}
/// <summary>
/// <para>Binary Versioned Stream.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:vstream.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTVStreamData : OpenXmlLeafTextElement
{
    private const string tagName = "vstream";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11061;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "version" };
    private static byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> VSTREAM Version Attribute.</para>
    /// <para>Represents the following attribute in the schema: version </para>
    /// </summary>
    [SchemaAttr(0, "version")]
    public StringValue Version
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the VTVStreamData class.
    /// </summary>
    public VTVStreamData():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTVStreamData class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTVStreamData(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "version" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTVStreamData>(deep);
    }

   
}
/// <summary>
/// <para>Class ID.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:clsid.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTClassId : OpenXmlLeafTextElement
{
    private const string tagName = "clsid";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11062;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTClassId class.
    /// </summary>
    public VTClassId():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTClassId class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTClassId(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTClassId>(deep);
    }

   
}
/// <summary>
/// <para>Clipboard Data.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:cf.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VTClipboardData : OpenXmlLeafTextElement
{
    private const string tagName = "cf";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 5;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11063;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "format","size" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Format Attribute.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    public Int32Value Format
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public UInt32Value Size
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the VTClipboardData class.
    /// </summary>
    public VTClipboardData():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the VTClipboardData class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VTClipboardData(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Base64BinaryValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "format" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "size" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VTClipboardData>(deep);
    }

   
}
/// <summary>
/// Vector Base Type Simple Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum VectorBaseValues
{  
	///<summary>
///Variant Base Type.
///<para>When the item is serialized out as xml, its value is "variant".</para>
///</summary>
[EnumString("variant")]
Variant,
///<summary>
///Vector Base Type Enumeration Value.
///<para>When the item is serialized out as xml, its value is "i1".</para>
///</summary>
[EnumString("i1")]
OneByteSignedInteger,
///<summary>
///2-Byte Signed Integer Base Type.
///<para>When the item is serialized out as xml, its value is "i2".</para>
///</summary>
[EnumString("i2")]
TwoBytesSignedInteger,
///<summary>
///4-Byte Signed Integer Base Type.
///<para>When the item is serialized out as xml, its value is "i4".</para>
///</summary>
[EnumString("i4")]
FourBytesSignedInteger,
///<summary>
///8-Byte Signed Integer Base Type.
///<para>When the item is serialized out as xml, its value is "i8".</para>
///</summary>
[EnumString("i8")]
EightBytesSignedInteger,
///<summary>
///1-Byte Unsigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "ui1".</para>
///</summary>
[EnumString("ui1")]
OneByteUnsignedInteger,
///<summary>
///2-Byte Unisigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "ui2".</para>
///</summary>
[EnumString("ui2")]
TwoBytesUnsignedInteger,
///<summary>
///4-Byte Unsigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "ui4".</para>
///</summary>
[EnumString("ui4")]
FourBytesUnsignedInteger,
///<summary>
///8-Byte Unsigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "ui8".</para>
///</summary>
[EnumString("ui8")]
EightBytesUnsignedInteger,
///<summary>
///4-Byte Real Number Base Type.
///<para>When the item is serialized out as xml, its value is "r4".</para>
///</summary>
[EnumString("r4")]
FourBytesReal,
///<summary>
///8-Byte Real Number Base Type.
///<para>When the item is serialized out as xml, its value is "r8".</para>
///</summary>
[EnumString("r8")]
EightBytesReal,
///<summary>
///LPSTR Base Type.
///<para>When the item is serialized out as xml, its value is "lpstr".</para>
///</summary>
[EnumString("lpstr")]
Lpstr,
///<summary>
///LPWSTR Base Type.
///<para>When the item is serialized out as xml, its value is "lpwstr".</para>
///</summary>
[EnumString("lpwstr")]
Lpwstr,
///<summary>
///Basic String Base Type.
///<para>When the item is serialized out as xml, its value is "bstr".</para>
///</summary>
[EnumString("bstr")]
Bstr,
///<summary>
///Date and Time Base Type.
///<para>When the item is serialized out as xml, its value is "date".</para>
///</summary>
[EnumString("date")]
Date,
///<summary>
///File Time Base Type.
///<para>When the item is serialized out as xml, its value is "filetime".</para>
///</summary>
[EnumString("filetime")]
Filetime,
///<summary>
///Boolean Base Type.
///<para>When the item is serialized out as xml, its value is "bool".</para>
///</summary>
[EnumString("bool")]
Bool,
///<summary>
///Currency Base Type.
///<para>When the item is serialized out as xml, its value is "cy".</para>
///</summary>
[EnumString("cy")]
Currency,
///<summary>
///Error Status Code Base Type.
///<para>When the item is serialized out as xml, its value is "error".</para>
///</summary>
[EnumString("error")]
Error,
///<summary>
///Class ID Base Type.
///<para>When the item is serialized out as xml, its value is "clsid".</para>
///</summary>
[EnumString("clsid")]
ClassId,
///<summary>
///Clipboard Data Base Type.
///<para>When the item is serialized out as xml, its value is "cf".</para>
///</summary>
[EnumString("cf")]
ClipboardData,
 
}
/// <summary>
/// Array Base Type Simple Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ArrayBaseValues
{  
	///<summary>
///Variant Base Type.
///<para>When the item is serialized out as xml, its value is "variant".</para>
///</summary>
[EnumString("variant")]
Variant,
///<summary>
///1-Byte Signed Integer Base Type.
///<para>When the item is serialized out as xml, its value is "i1".</para>
///</summary>
[EnumString("i1")]
OneByteSignedInteger,
///<summary>
///2-Byte Signed Integer Base Type.
///<para>When the item is serialized out as xml, its value is "i2".</para>
///</summary>
[EnumString("i2")]
TwoBytesSignedInteger,
///<summary>
///4-Byte Signed Integer Base Type.
///<para>When the item is serialized out as xml, its value is "i4".</para>
///</summary>
[EnumString("i4")]
FourBytesSignedInteger,
///<summary>
///Integer Base Type.
///<para>When the item is serialized out as xml, its value is "int".</para>
///</summary>
[EnumString("int")]
Integer,
///<summary>
///1-Byte Unsigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "ui1".</para>
///</summary>
[EnumString("ui1")]
OneByteUnsignedInteger,
///<summary>
///2-Byte Unsigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "ui2".</para>
///</summary>
[EnumString("ui2")]
TwoBytesUnsignedInteger,
///<summary>
///4-Byte Unsigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "ui4".</para>
///</summary>
[EnumString("ui4")]
FourBytesUnsignedInteger,
///<summary>
///Unsigned Integer Base Type.
///<para>When the item is serialized out as xml, its value is "uint".</para>
///</summary>
[EnumString("uint")]
UnsignedInteger,
///<summary>
///4-Byte Real Number Base Type.
///<para>When the item is serialized out as xml, its value is "r4".</para>
///</summary>
[EnumString("r4")]
FourBytesReal,
///<summary>
///8-Byte Real Number Base Type.
///<para>When the item is serialized out as xml, its value is "r8".</para>
///</summary>
[EnumString("r8")]
EightBytesReal,
///<summary>
///Decimal Base Type.
///<para>When the item is serialized out as xml, its value is "decimal".</para>
///</summary>
[EnumString("decimal")]
Decimal,
///<summary>
///Basic String Base Type.
///<para>When the item is serialized out as xml, its value is "bstr".</para>
///</summary>
[EnumString("bstr")]
Bstr,
///<summary>
///Date and Time Base Type.
///<para>When the item is serialized out as xml, its value is "date".</para>
///</summary>
[EnumString("date")]
Date,
///<summary>
///Boolean Base Type.
///<para>When the item is serialized out as xml, its value is "bool".</para>
///</summary>
[EnumString("bool")]
Bool,
///<summary>
///Curency Base Type.
///<para>When the item is serialized out as xml, its value is "cy".</para>
///</summary>
[EnumString("cy")]
Currency,
///<summary>
///Error Status Code Base Type.
///<para>When the item is serialized out as xml, its value is "error".</para>
///</summary>
[EnumString("error")]
Error,
 
}
}
 
 
