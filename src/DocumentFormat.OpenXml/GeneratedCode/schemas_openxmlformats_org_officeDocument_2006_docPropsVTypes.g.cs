// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.VariantTypes
{
/// <summary>
/// <para>Variant.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "variant")]
[Id(ElementTypeIdConst)]
public partial class Variant : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11029;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Variant.</para>
    /// <para> Represents the following element tag in the schema: vt:variant </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(0)]
    public Variant InnerVariant
	{
        get => GetElement<Variant>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Vector.</para>
    /// <para> Represents the following element tag in the schema: vt:vector </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(1)]
    public VTVector VTVector
	{
        get => GetElement<VTVector>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Array.</para>
    /// <para> Represents the following element tag in the schema: vt:array </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(2)]
    public VTArray VTArray
	{
        get => GetElement<VTArray>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> Binary Blob.</para>
    /// <para> Represents the following element tag in the schema: vt:blob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(3)]
    public VTBlob VTBlob
	{
        get => GetElement<VTBlob>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Binary Blob Object.</para>
    /// <para> Represents the following element tag in the schema: vt:oblob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(4)]
    public VTOBlob VTOBlob
	{
        get => GetElement<VTOBlob>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> Empty.</para>
    /// <para> Represents the following element tag in the schema: vt:empty </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(5)]
    public VTEmpty VTEmpty
	{
        get => GetElement<VTEmpty>(5);
        set => SetElement(5, value);
	}
    
    /// <summary>
    /// <para> Null.</para>
    /// <para> Represents the following element tag in the schema: vt:null </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(6)]
    public VTNull VTNull
	{
        get => GetElement<VTNull>(6);
        set => SetElement(6, value);
	}
    
    /// <summary>
    /// <para> 1-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(7)]
    public VTByte VTByte
	{
        get => GetElement<VTByte>(7);
        set => SetElement(7, value);
	}
    
    /// <summary>
    /// <para> 2-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(8)]
    public VTShort VTShort
	{
        get => GetElement<VTShort>(8);
        set => SetElement(8, value);
	}
    
    /// <summary>
    /// <para> 4-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(9)]
    public VTInt32 VTInt32
	{
        get => GetElement<VTInt32>(9);
        set => SetElement(9, value);
	}
    
    /// <summary>
    /// <para> 8-Byte Signed Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:i8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(10)]
    public VTInt64 VTInt64
	{
        get => GetElement<VTInt64>(10);
        set => SetElement(10, value);
	}
    
    /// <summary>
    /// <para> Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:int </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(11)]
    public VTInteger VTInteger
	{
        get => GetElement<VTInteger>(11);
        set => SetElement(11, value);
	}
    
    /// <summary>
    /// <para> 1-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(12)]
    public VTUnsignedByte VTUnsignedByte
	{
        get => GetElement<VTUnsignedByte>(12);
        set => SetElement(12, value);
	}
    
    /// <summary>
    /// <para> 2-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(13)]
    public VTUnsignedShort VTUnsignedShort
	{
        get => GetElement<VTUnsignedShort>(13);
        set => SetElement(13, value);
	}
    
    /// <summary>
    /// <para> 4-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(14)]
    public VTUnsignedInt32 VTUnsignedInt32
	{
        get => GetElement<VTUnsignedInt32>(14);
        set => SetElement(14, value);
	}
    
    /// <summary>
    /// <para> 8-Byte Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:ui8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(15)]
    public VTUnsignedInt64 VTUnsignedInt64
	{
        get => GetElement<VTUnsignedInt64>(15);
        set => SetElement(15, value);
	}
    
    /// <summary>
    /// <para> Unsigned Integer.</para>
    /// <para> Represents the following element tag in the schema: vt:uint </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(16)]
    public VTUnsignedInteger VTUnsignedInteger
	{
        get => GetElement<VTUnsignedInteger>(16);
        set => SetElement(16, value);
	}
    
    /// <summary>
    /// <para> 4-Byte Real Number.</para>
    /// <para> Represents the following element tag in the schema: vt:r4 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(17)]
    public VTFloat VTFloat
	{
        get => GetElement<VTFloat>(17);
        set => SetElement(17, value);
	}
    
    /// <summary>
    /// <para> 8-Byte Real Number.</para>
    /// <para> Represents the following element tag in the schema: vt:r8 </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(18)]
    public VTDouble VTDouble
	{
        get => GetElement<VTDouble>(18);
        set => SetElement(18, value);
	}
    
    /// <summary>
    /// <para> Decimal.</para>
    /// <para> Represents the following element tag in the schema: vt:decimal </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(19)]
    public VTDecimal VTDecimal
	{
        get => GetElement<VTDecimal>(19);
        set => SetElement(19, value);
	}
    
    /// <summary>
    /// <para> LPSTR.</para>
    /// <para> Represents the following element tag in the schema: vt:lpstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(20)]
    public VTLPSTR VTLPSTR
	{
        get => GetElement<VTLPSTR>(20);
        set => SetElement(20, value);
	}
    
    /// <summary>
    /// <para> LPWSTR.</para>
    /// <para> Represents the following element tag in the schema: vt:lpwstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(21)]
    public VTLPWSTR VTLPWSTR
	{
        get => GetElement<VTLPWSTR>(21);
        set => SetElement(21, value);
	}
    
    /// <summary>
    /// <para> Basic String.</para>
    /// <para> Represents the following element tag in the schema: vt:bstr </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(22)]
    public VTBString VTBString
	{
        get => GetElement<VTBString>(22);
        set => SetElement(22, value);
	}
    
    /// <summary>
    /// <para> Date and Time.</para>
    /// <para> Represents the following element tag in the schema: vt:date </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(23)]
    public VTDate VTDate
	{
        get => GetElement<VTDate>(23);
        set => SetElement(23, value);
	}
    
    /// <summary>
    /// <para> File Time.</para>
    /// <para> Represents the following element tag in the schema: vt:filetime </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(24)]
    public VTFileTime VTFileTime
	{
        get => GetElement<VTFileTime>(24);
        set => SetElement(24, value);
	}
    
    /// <summary>
    /// <para> Boolean.</para>
    /// <para> Represents the following element tag in the schema: vt:bool </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(25)]
    public VTBool VTBool
	{
        get => GetElement<VTBool>(25);
        set => SetElement(25, value);
	}
    
    /// <summary>
    /// <para> Currency.</para>
    /// <para> Represents the following element tag in the schema: vt:cy </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(26)]
    public VTCurrency VTCurrency
	{
        get => GetElement<VTCurrency>(26);
        set => SetElement(26, value);
	}
    
    /// <summary>
    /// <para> Error Status Code.</para>
    /// <para> Represents the following element tag in the schema: vt:error </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(27)]
    public VTError VTError
	{
        get => GetElement<VTError>(27);
        set => SetElement(27, value);
	}
    
    /// <summary>
    /// <para> Binary Stream.</para>
    /// <para> Represents the following element tag in the schema: vt:stream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(28)]
    public VTStreamData VTStreamData
	{
        get => GetElement<VTStreamData>(28);
        set => SetElement(28, value);
	}
    
    /// <summary>
    /// <para> Binary Stream Object.</para>
    /// <para> Represents the following element tag in the schema: vt:ostream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(29)]
    public VTOStreamData VTOStreamData
	{
        get => GetElement<VTOStreamData>(29);
        set => SetElement(29, value);
	}
    
    /// <summary>
    /// <para> Binary Storage.</para>
    /// <para> Represents the following element tag in the schema: vt:storage </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(30)]
    public VTStorage VTStorage
	{
        get => GetElement<VTStorage>(30);
        set => SetElement(30, value);
	}
    
    /// <summary>
    /// <para> Binary Storage Object.</para>
    /// <para> Represents the following element tag in the schema: vt:ostorage </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(31)]
    public VTOStorage VTOStorage
	{
        get => GetElement<VTOStorage>(31);
        set => SetElement(31, value);
	}
    
    /// <summary>
    /// <para> Binary Versioned Stream.</para>
    /// <para> Represents the following element tag in the schema: vt:vstream </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(32)]
    public VTVStreamData VTVStreamData
	{
        get => GetElement<VTVStreamData>(32);
        set => SetElement(32, value);
	}
    
    /// <summary>
    /// <para> Class ID.</para>
    /// <para> Represents the following element tag in the schema: vt:clsid </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(33)]
    public VTClassId VTClassId
	{
        get => GetElement<VTClassId>(33);
        set => SetElement(33, value);
	}
    
    /// <summary>
    /// <para> Clipboard Data.</para>
    /// <para> Represents the following element tag in the schema: vt:cf </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(34)]
    public VTClipboardData VTClipboardData
	{
        get => GetElement<VTClipboardData>(34);
        set => SetElement(34, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Variant>(deep);

}
/// <summary>
/// <para>Vector.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "vector")]
[Id(ElementTypeIdConst)]
public partial class VTVector : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11030;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Vector Base Type.</para>
    /// <para>Represents the following attribute in the schema: baseType </para>
    /// </summary>
    [SchemaAttr(0, "baseType")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.VariantTypes.VectorBaseValues> BaseType { get; set; }
	
    /// <summary>
    /// <para> Vector Size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    [Index(1)]
    public UInt32Value Size { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTVector>(deep);

}
/// <summary>
/// <para>Array.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "array")]
[Id(ElementTypeIdConst)]
public partial class VTArray : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11031;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Array Lower Bounds Attribute.</para>
    /// <para>Represents the following attribute in the schema: lBound </para>
    /// </summary>
    [SchemaAttr(0, "lBound")]
    [Index(0)]
    public Int32Value LowerBounds { get; set; }
	
    /// <summary>
    /// <para> Array Upper Bounds Attribute.</para>
    /// <para>Represents the following attribute in the schema: uBound </para>
    /// </summary>
    [SchemaAttr(0, "uBound")]
    [Index(1)]
    public Int32Value UpperBounds { get; set; }
	
    /// <summary>
    /// <para> Array Base Type.</para>
    /// <para>Represents the following attribute in the schema: baseType </para>
    /// </summary>
    [SchemaAttr(0, "baseType")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.VariantTypes.ArrayBaseValues> BaseType { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTArray>(deep);

}
/// <summary>
/// <para>Binary Blob.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:blob.</para>
/// </summary>

[SchemaAttr(5, "blob")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTBlob : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11032;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTBlob>(deep);

}
/// <summary>
/// <para>Binary Blob Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:oblob.</para>
/// </summary>

[SchemaAttr(5, "oblob")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTOBlob : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11033;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTOBlob>(deep);

}
/// <summary>
/// <para>Binary Stream.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:stream.</para>
/// </summary>

[SchemaAttr(5, "stream")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTStreamData : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11057;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTStreamData>(deep);

}
/// <summary>
/// <para>Binary Stream Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ostream.</para>
/// </summary>

[SchemaAttr(5, "ostream")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTOStreamData : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11058;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTOStreamData>(deep);

}
/// <summary>
/// <para>Binary Storage.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:storage.</para>
/// </summary>

[SchemaAttr(5, "storage")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTStorage : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11059;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTStorage>(deep);

}
/// <summary>
/// <para>Binary Storage Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ostorage.</para>
/// </summary>

[SchemaAttr(5, "ostorage")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTOStorage : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11060;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTOStorage>(deep);

}
/// <summary>
/// <para>Empty.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:empty.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "empty")]
[Id(ElementTypeIdConst)]
public partial class VTEmpty : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11034;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTEmpty class.
    /// </summary>
    public VTEmpty():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTEmpty>(deep);

}
/// <summary>
/// <para>Null.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:null.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "null")]
[Id(ElementTypeIdConst)]
public partial class VTNull : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11035;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the VTNull class.
    /// </summary>
    public VTNull():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTNull>(deep);

}
/// <summary>
/// <para>1-Byte Signed Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i1.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "i1")]
[Id(ElementTypeIdConst)]
public partial class VTByte : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11036;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTByte>(deep);

}
/// <summary>
/// <para>2-Byte Signed Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i2.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "i2")]
[Id(ElementTypeIdConst)]
public partial class VTShort : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11037;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTShort>(deep);

}
/// <summary>
/// <para>4-Byte Signed Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i4.</para>
/// </summary>

[SchemaAttr(5, "i4")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTInt32 : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11038;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTInt32>(deep);

}
/// <summary>
/// <para>Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:int.</para>
/// </summary>

[SchemaAttr(5, "int")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTInteger : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11040;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTInteger>(deep);

}
/// <summary>
/// <para>8-Byte Signed Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:i8.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "i8")]
[Id(ElementTypeIdConst)]
public partial class VTInt64 : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11039;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTInt64>(deep);

}
/// <summary>
/// <para>1-Byte Unsigned Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui1.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "ui1")]
[Id(ElementTypeIdConst)]
public partial class VTUnsignedByte : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11041;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedByte>(deep);

}
/// <summary>
/// <para>2-Byte Unsigned Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui2.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "ui2")]
[Id(ElementTypeIdConst)]
public partial class VTUnsignedShort : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11042;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedShort>(deep);

}
/// <summary>
/// <para>4-Byte Unsigned Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui4.</para>
/// </summary>

[SchemaAttr(5, "ui4")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTUnsignedInt32 : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11043;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedInt32>(deep);

}
/// <summary>
/// <para>Unsigned Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:uint.</para>
/// </summary>

[SchemaAttr(5, "uint")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTUnsignedInteger : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11045;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedInteger>(deep);

}
/// <summary>
/// <para>8-Byte Unsigned Integer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:ui8.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "ui8")]
[Id(ElementTypeIdConst)]
public partial class VTUnsignedInt64 : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11044;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedInt64>(deep);

}
/// <summary>
/// <para>4-Byte Real Number.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:r4.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "r4")]
[Id(ElementTypeIdConst)]
public partial class VTFloat : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11046;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTFloat>(deep);

}
/// <summary>
/// <para>8-Byte Real Number.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:r8.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "r8")]
[Id(ElementTypeIdConst)]
public partial class VTDouble : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11047;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTDouble>(deep);

}
/// <summary>
/// <para>Decimal.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:decimal.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "decimal")]
[Id(ElementTypeIdConst)]
public partial class VTDecimal : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11048;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTDecimal>(deep);

}
/// <summary>
/// <para>LPSTR.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:lpstr.</para>
/// </summary>

[SchemaAttr(5, "lpstr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTLPSTR : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11049;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTLPSTR>(deep);

}
/// <summary>
/// <para>LPWSTR.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:lpwstr.</para>
/// </summary>

[SchemaAttr(5, "lpwstr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTLPWSTR : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11050;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTLPWSTR>(deep);

}
/// <summary>
/// <para>Basic String.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:bstr.</para>
/// </summary>

[SchemaAttr(5, "bstr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTBString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11051;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTBString>(deep);

}
/// <summary>
/// <para>Date and Time.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:date.</para>
/// </summary>

[SchemaAttr(5, "date")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTDate : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11052;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTDate>(deep);

}
/// <summary>
/// <para>File Time.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:filetime.</para>
/// </summary>

[SchemaAttr(5, "filetime")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VTFileTime : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11053;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTFileTime>(deep);

}
/// <summary>
/// <para>Boolean.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:bool.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "bool")]
[Id(ElementTypeIdConst)]
public partial class VTBool : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11054;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTBool>(deep);

}
/// <summary>
/// <para>Currency.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:cy.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "cy")]
[Id(ElementTypeIdConst)]
public partial class VTCurrency : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11055;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTCurrency>(deep);

}
/// <summary>
/// <para>Error Status Code.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:error.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "error")]
[Id(ElementTypeIdConst)]
public partial class VTError : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11056;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTError>(deep);

}
/// <summary>
/// <para>Binary Versioned Stream.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:vstream.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "vstream")]
[Id(ElementTypeIdConst)]
public partial class VTVStreamData : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11061;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> VSTREAM Version Attribute.</para>
    /// <para>Represents the following attribute in the schema: version </para>
    /// </summary>
    [SchemaAttr(0, "version")]
    [Index(0)]
    public StringValue Version { get; set; }
	

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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTVStreamData>(deep);

}
/// <summary>
/// <para>Class ID.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:clsid.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "clsid")]
[Id(ElementTypeIdConst)]
public partial class VTClassId : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11062;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTClassId>(deep);

}
/// <summary>
/// <para>Clipboard Data.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is vt:cf.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(5, "cf")]
[Id(ElementTypeIdConst)]
public partial class VTClipboardData : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11063;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Format Attribute.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    [Index(0)]
    public Int32Value Format { get; set; }
	
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    [Index(1)]
    public UInt32Value Size { get; set; }
	

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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTClipboardData>(deep);

}
/// <summary>
/// Vector Base Type Simple Type 
/// </summary> 
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
 
}
}
 
 
