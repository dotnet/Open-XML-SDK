﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.VariantTypes
{
    /// <summary>
    /// <para>Variant.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:variant.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Variant &lt;vt:variant></description></item>
    ///   <item><description>VTVector &lt;vt:vector></description></item>
    ///   <item><description>VTArray &lt;vt:array></description></item>
    ///   <item><description>VTBlob &lt;vt:blob></description></item>
    ///   <item><description>VTOBlob &lt;vt:oblob></description></item>
    ///   <item><description>VTEmpty &lt;vt:empty></description></item>
    ///   <item><description>VTNull &lt;vt:null></description></item>
    ///   <item><description>VTByte &lt;vt:i1></description></item>
    ///   <item><description>VTShort &lt;vt:i2></description></item>
    ///   <item><description>VTInt32 &lt;vt:i4></description></item>
    ///   <item><description>VTInt64 &lt;vt:i8></description></item>
    ///   <item><description>VTInteger &lt;vt:int></description></item>
    ///   <item><description>VTUnsignedByte &lt;vt:ui1></description></item>
    ///   <item><description>VTUnsignedShort &lt;vt:ui2></description></item>
    ///   <item><description>VTUnsignedInt32 &lt;vt:ui4></description></item>
    ///   <item><description>VTUnsignedInt64 &lt;vt:ui8></description></item>
    ///   <item><description>VTUnsignedInteger &lt;vt:uint></description></item>
    ///   <item><description>VTFloat &lt;vt:r4></description></item>
    ///   <item><description>VTDouble &lt;vt:r8></description></item>
    ///   <item><description>VTDecimal &lt;vt:decimal></description></item>
    ///   <item><description>VTLPSTR &lt;vt:lpstr></description></item>
    ///   <item><description>VTLPWSTR &lt;vt:lpwstr></description></item>
    ///   <item><description>VTBString &lt;vt:bstr></description></item>
    ///   <item><description>VTDate &lt;vt:date></description></item>
    ///   <item><description>VTFileTime &lt;vt:filetime></description></item>
    ///   <item><description>VTBool &lt;vt:bool></description></item>
    ///   <item><description>VTCurrency &lt;vt:cy></description></item>
    ///   <item><description>VTError &lt;vt:error></description></item>
    ///   <item><description>VTStreamData &lt;vt:stream></description></item>
    ///   <item><description>VTOStreamData &lt;vt:ostream></description></item>
    ///   <item><description>VTStorage &lt;vt:storage></description></item>
    ///   <item><description>VTOStorage &lt;vt:ostorage></description></item>
    ///   <item><description>VTVStreamData &lt;vt:vstream></description></item>
    ///   <item><description>VTClassId &lt;vt:clsid></description></item>
    ///   <item><description>VTClipboardData &lt;vt:cf></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(5, "variant")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Variant : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Variant class.
        /// </summary>
        public Variant() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Variant class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Variant(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Variant(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Variant.</para>
        /// <para>Represents the following element tag in the schema: vt:variant.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public Variant InnerVariant
        {
            get => GetElement<Variant>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Vector.</para>
        /// <para>Represents the following element tag in the schema: vt:vector.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTVector VTVector
        {
            get => GetElement<VTVector>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Array.</para>
        /// <para>Represents the following element tag in the schema: vt:array.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTArray VTArray
        {
            get => GetElement<VTArray>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Blob.</para>
        /// <para>Represents the following element tag in the schema: vt:blob.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTBlob VTBlob
        {
            get => GetElement<VTBlob>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Blob Object.</para>
        /// <para>Represents the following element tag in the schema: vt:oblob.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTOBlob VTOBlob
        {
            get => GetElement<VTOBlob>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Empty.</para>
        /// <para>Represents the following element tag in the schema: vt:empty.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTEmpty VTEmpty
        {
            get => GetElement<VTEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Null.</para>
        /// <para>Represents the following element tag in the schema: vt:null.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTNull VTNull
        {
            get => GetElement<VTNull>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>1-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i1.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTByte VTByte
        {
            get => GetElement<VTByte>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>2-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i2.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTShort VTShort
        {
            get => GetElement<VTShort>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>4-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i4.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTInt32 VTInt32
        {
            get => GetElement<VTInt32>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>8-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i8.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTInt64 VTInt64
        {
            get => GetElement<VTInt64>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:int.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTInteger VTInteger
        {
            get => GetElement<VTInteger>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>1-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui1.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTUnsignedByte VTUnsignedByte
        {
            get => GetElement<VTUnsignedByte>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>2-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui2.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTUnsignedShort VTUnsignedShort
        {
            get => GetElement<VTUnsignedShort>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>4-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui4.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTUnsignedInt32 VTUnsignedInt32
        {
            get => GetElement<VTUnsignedInt32>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>8-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui8.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTUnsignedInt64 VTUnsignedInt64
        {
            get => GetElement<VTUnsignedInt64>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:uint.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTUnsignedInteger VTUnsignedInteger
        {
            get => GetElement<VTUnsignedInteger>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>4-Byte Real Number.</para>
        /// <para>Represents the following element tag in the schema: vt:r4.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTFloat VTFloat
        {
            get => GetElement<VTFloat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>8-Byte Real Number.</para>
        /// <para>Represents the following element tag in the schema: vt:r8.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTDouble VTDouble
        {
            get => GetElement<VTDouble>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Decimal.</para>
        /// <para>Represents the following element tag in the schema: vt:decimal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTDecimal VTDecimal
        {
            get => GetElement<VTDecimal>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LPSTR.</para>
        /// <para>Represents the following element tag in the schema: vt:lpstr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTLPSTR VTLPSTR
        {
            get => GetElement<VTLPSTR>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LPWSTR.</para>
        /// <para>Represents the following element tag in the schema: vt:lpwstr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTLPWSTR VTLPWSTR
        {
            get => GetElement<VTLPWSTR>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Basic String.</para>
        /// <para>Represents the following element tag in the schema: vt:bstr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTBString VTBString
        {
            get => GetElement<VTBString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Date and Time.</para>
        /// <para>Represents the following element tag in the schema: vt:date.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTDate VTDate
        {
            get => GetElement<VTDate>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>File Time.</para>
        /// <para>Represents the following element tag in the schema: vt:filetime.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTFileTime VTFileTime
        {
            get => GetElement<VTFileTime>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Boolean.</para>
        /// <para>Represents the following element tag in the schema: vt:bool.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTBool VTBool
        {
            get => GetElement<VTBool>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Currency.</para>
        /// <para>Represents the following element tag in the schema: vt:cy.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTCurrency VTCurrency
        {
            get => GetElement<VTCurrency>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Error Status Code.</para>
        /// <para>Represents the following element tag in the schema: vt:error.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTError VTError
        {
            get => GetElement<VTError>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Stream.</para>
        /// <para>Represents the following element tag in the schema: vt:stream.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTStreamData VTStreamData
        {
            get => GetElement<VTStreamData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Stream Object.</para>
        /// <para>Represents the following element tag in the schema: vt:ostream.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTOStreamData VTOStreamData
        {
            get => GetElement<VTOStreamData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Storage.</para>
        /// <para>Represents the following element tag in the schema: vt:storage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTStorage VTStorage
        {
            get => GetElement<VTStorage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Storage Object.</para>
        /// <para>Represents the following element tag in the schema: vt:ostorage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTOStorage VTOStorage
        {
            get => GetElement<VTOStorage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Versioned Stream.</para>
        /// <para>Represents the following element tag in the schema: vt:vstream.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTVStreamData VTVStreamData
        {
            get => GetElement<VTVStreamData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Class ID.</para>
        /// <para>Represents the following element tag in the schema: vt:clsid.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTClassId VTClassId
        {
            get => GetElement<VTClassId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Clipboard Data.</para>
        /// <para>Represents the following element tag in the schema: vt:cf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public VTClipboardData VTClipboardData
        {
            get => GetElement<VTClipboardData>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.Variant), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTArray), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBlob), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTOBlob), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTEmpty), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTNull), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTByte), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTShort), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt32), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt64), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInteger), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTFloat), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDouble), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDecimal), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPSTR), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPWSTR), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBString), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDate), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTFileTime), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBool), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTCurrency), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTError), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTStreamData), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTOStreamData), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTStorage), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTOStorage), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVStreamData), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTClassId), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTClipboardData), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Variant>(deep);
    }

    /// <summary>
    /// <para>Vector.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:vector.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Variant &lt;vt:variant></description></item>
    ///   <item><description>VTByte &lt;vt:i1></description></item>
    ///   <item><description>VTShort &lt;vt:i2></description></item>
    ///   <item><description>VTInt32 &lt;vt:i4></description></item>
    ///   <item><description>VTInt64 &lt;vt:i8></description></item>
    ///   <item><description>VTUnsignedByte &lt;vt:ui1></description></item>
    ///   <item><description>VTUnsignedShort &lt;vt:ui2></description></item>
    ///   <item><description>VTUnsignedInt32 &lt;vt:ui4></description></item>
    ///   <item><description>VTUnsignedInt64 &lt;vt:ui8></description></item>
    ///   <item><description>VTFloat &lt;vt:r4></description></item>
    ///   <item><description>VTDouble &lt;vt:r8></description></item>
    ///   <item><description>VTLPSTR &lt;vt:lpstr></description></item>
    ///   <item><description>VTLPWSTR &lt;vt:lpwstr></description></item>
    ///   <item><description>VTBString &lt;vt:bstr></description></item>
    ///   <item><description>VTDate &lt;vt:date></description></item>
    ///   <item><description>VTFileTime &lt;vt:filetime></description></item>
    ///   <item><description>VTBool &lt;vt:bool></description></item>
    ///   <item><description>VTCurrency &lt;vt:cy></description></item>
    ///   <item><description>VTError &lt;vt:error></description></item>
    ///   <item><description>VTClassId &lt;vt:clsid></description></item>
    ///   <item><description>VTClipboardData &lt;vt:cf></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(5, "vector")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTVector : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the VTVector class.
        /// </summary>
        public VTVector() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTVector class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VTVector(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public VTVector(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Vector Base Type</para>
        /// <para>Represents the following attribute in the schema: baseType</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "baseType")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.VariantTypes.VectorBaseValues> BaseType { get; set; }

        /// <summary>
        /// <para>Vector Size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "size")]
        [Index(1)]
        public UInt32Value Size { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.Variant), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTByte), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTShort), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt32), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt64), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTFloat), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDouble), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPSTR), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPWSTR), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBString), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDate), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTFileTime), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBool), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTCurrency), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTError), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTClassId), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTClipboardData), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTVector>(deep);
    }

    /// <summary>
    /// <para>Array.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:array.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Variant &lt;vt:variant></description></item>
    ///   <item><description>VTByte &lt;vt:i1></description></item>
    ///   <item><description>VTShort &lt;vt:i2></description></item>
    ///   <item><description>VTInt32 &lt;vt:i4></description></item>
    ///   <item><description>VTInteger &lt;vt:int></description></item>
    ///   <item><description>VTUnsignedByte &lt;vt:ui1></description></item>
    ///   <item><description>VTUnsignedShort &lt;vt:ui2></description></item>
    ///   <item><description>VTUnsignedInt32 &lt;vt:ui4></description></item>
    ///   <item><description>VTUnsignedInteger &lt;vt:uint></description></item>
    ///   <item><description>VTFloat &lt;vt:r4></description></item>
    ///   <item><description>VTDouble &lt;vt:r8></description></item>
    ///   <item><description>VTDecimal &lt;vt:decimal></description></item>
    ///   <item><description>VTBString &lt;vt:bstr></description></item>
    ///   <item><description>VTDate &lt;vt:date></description></item>
    ///   <item><description>VTBool &lt;vt:bool></description></item>
    ///   <item><description>VTError &lt;vt:error></description></item>
    ///   <item><description>VTCurrency &lt;vt:cy></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(5, "array")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTArray : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the VTArray class.
        /// </summary>
        public VTArray() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VTArray(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public VTArray(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Array Lower Bounds Attribute</para>
        /// <para>Represents the following attribute in the schema: lBound</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "lBound")]
        [Index(0)]
        public Int32Value LowerBounds { get; set; }

        /// <summary>
        /// <para>Array Upper Bounds Attribute</para>
        /// <para>Represents the following attribute in the schema: uBound</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "uBound")]
        [Index(1)]
        public Int32Value UpperBounds { get; set; }

        /// <summary>
        /// <para>Array Base Type</para>
        /// <para>Represents the following attribute in the schema: baseType</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "baseType")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.VariantTypes.ArrayBaseValues> BaseType { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.Variant), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTByte), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTShort), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt32), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInteger), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTFloat), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDouble), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDecimal), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBString), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDate), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBool), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTError), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTCurrency), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTArray>(deep);
    }

    /// <summary>
    /// <para>Binary Blob.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:blob.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Base64BinaryValue))]
    [SchemaAttr(5, "blob")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTBlob : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTBlob class.
        /// </summary>
        public VTBlob() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTBlob class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTBlob(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTBlob>(deep);
    }

    /// <summary>
    /// <para>Binary Blob Object.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:oblob.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Base64BinaryValue))]
    [SchemaAttr(5, "oblob")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTOBlob : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTOBlob class.
        /// </summary>
        public VTOBlob() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTOBlob class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTOBlob(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTOBlob>(deep);
    }

    /// <summary>
    /// <para>Binary Stream.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:stream.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Base64BinaryValue))]
    [SchemaAttr(5, "stream")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTStreamData : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTStreamData class.
        /// </summary>
        public VTStreamData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTStreamData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTStreamData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTStreamData>(deep);
    }

    /// <summary>
    /// <para>Binary Stream Object.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:ostream.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Base64BinaryValue))]
    [SchemaAttr(5, "ostream")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTOStreamData : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTOStreamData class.
        /// </summary>
        public VTOStreamData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTOStreamData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTOStreamData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTOStreamData>(deep);
    }

    /// <summary>
    /// <para>Binary Storage.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:storage.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Base64BinaryValue))]
    [SchemaAttr(5, "storage")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTStorage : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTStorage class.
        /// </summary>
        public VTStorage() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTStorage class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTStorage(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTStorage>(deep);
    }

    /// <summary>
    /// <para>Binary Storage Object.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:ostorage.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Base64BinaryValue))]
    [SchemaAttr(5, "ostorage")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTOStorage : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTOStorage class.
        /// </summary>
        public VTOStorage() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTOStorage class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTOStorage(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTOStorage>(deep);
    }

    /// <summary>
    /// <para>Empty.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:empty.</para>
    /// </summary>
    [SchemaAttr(5, "empty")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTEmpty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VTEmpty class.
        /// </summary>
        public VTEmpty() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTEmpty>(deep);
    }

    /// <summary>
    /// <para>Null.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:null.</para>
    /// </summary>
    [SchemaAttr(5, "null")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTNull : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VTNull class.
        /// </summary>
        public VTNull() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTNull>(deep);
    }

    /// <summary>
    /// <para>1-Byte Signed Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:i1.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(SByteValue))]
    [SchemaAttr(5, "i1")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTByte : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTByte class.
        /// </summary>
        public VTByte() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTByte class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTByte(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new SByteValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTByte>(deep);
    }

    /// <summary>
    /// <para>2-Byte Signed Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:i2.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Int16Value))]
    [SchemaAttr(5, "i2")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTShort : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTShort class.
        /// </summary>
        public VTShort() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTShort class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTShort(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int16Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTShort>(deep);
    }

    /// <summary>
    /// <para>4-Byte Signed Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:i4.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Int32Value))]
    [SchemaAttr(5, "i4")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTInt32 : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTInt32 class.
        /// </summary>
        public VTInt32() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTInt32 class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTInt32(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTInt32>(deep);
    }

    /// <summary>
    /// <para>Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:int.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Int32Value))]
    [SchemaAttr(5, "int")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTInteger : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTInteger class.
        /// </summary>
        public VTInteger() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTInteger class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTInteger(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTInteger>(deep);
    }

    /// <summary>
    /// <para>8-Byte Signed Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:i8.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(Int64Value))]
    [SchemaAttr(5, "i8")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTInt64 : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTInt64 class.
        /// </summary>
        public VTInt64() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTInt64 class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTInt64(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int64Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTInt64>(deep);
    }

    /// <summary>
    /// <para>1-Byte Unsigned Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:ui1.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(ByteValue))]
    [SchemaAttr(5, "ui1")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTUnsignedByte : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTUnsignedByte class.
        /// </summary>
        public VTUnsignedByte() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTUnsignedByte class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTUnsignedByte(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new ByteValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedByte>(deep);
    }

    /// <summary>
    /// <para>2-Byte Unsigned Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:ui2.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(UInt16Value))]
    [SchemaAttr(5, "ui2")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTUnsignedShort : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTUnsignedShort class.
        /// </summary>
        public VTUnsignedShort() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTUnsignedShort class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTUnsignedShort(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt16Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedShort>(deep);
    }

    /// <summary>
    /// <para>4-Byte Unsigned Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:ui4.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(UInt32Value))]
    [SchemaAttr(5, "ui4")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTUnsignedInt32 : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTUnsignedInt32 class.
        /// </summary>
        public VTUnsignedInt32() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTUnsignedInt32 class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTUnsignedInt32(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedInt32>(deep);
    }

    /// <summary>
    /// <para>Unsigned Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:uint.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(UInt32Value))]
    [SchemaAttr(5, "uint")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTUnsignedInteger : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTUnsignedInteger class.
        /// </summary>
        public VTUnsignedInteger() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTUnsignedInteger class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTUnsignedInteger(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedInteger>(deep);
    }

    /// <summary>
    /// <para>8-Byte Unsigned Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:ui8.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(UInt64Value))]
    [SchemaAttr(5, "ui8")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTUnsignedInt64 : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTUnsignedInt64 class.
        /// </summary>
        public VTUnsignedInt64() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTUnsignedInt64 class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTUnsignedInt64(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt64Value { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTUnsignedInt64>(deep);
    }

    /// <summary>
    /// <para>4-Byte Real Number.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:r4.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(SingleValue))]
    [SchemaAttr(5, "r4")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTFloat : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTFloat class.
        /// </summary>
        public VTFloat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTFloat class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTFloat(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new SingleValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTFloat>(deep);
    }

    /// <summary>
    /// <para>8-Byte Real Number.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:r8.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(DoubleValue))]
    [SchemaAttr(5, "r8")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTDouble : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTDouble class.
        /// </summary>
        public VTDouble() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTDouble class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTDouble(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DoubleValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTDouble>(deep);
    }

    /// <summary>
    /// <para>Decimal.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:decimal.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(DecimalValue))]
    [SchemaAttr(5, "decimal")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTDecimal : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTDecimal class.
        /// </summary>
        public VTDecimal() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTDecimal class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTDecimal(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DecimalValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTDecimal>(deep);
    }

    /// <summary>
    /// <para>LPSTR.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:lpstr.</para>
    /// </summary>
    [SchemaAttr(5, "lpstr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTLPSTR : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTLPSTR class.
        /// </summary>
        public VTLPSTR() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTLPSTR class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTLPSTR(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTLPSTR>(deep);
    }

    /// <summary>
    /// <para>LPWSTR.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:lpwstr.</para>
    /// </summary>
    [SchemaAttr(5, "lpwstr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTLPWSTR : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTLPWSTR class.
        /// </summary>
        public VTLPWSTR() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTLPWSTR class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTLPWSTR(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTLPWSTR>(deep);
    }

    /// <summary>
    /// <para>Basic String.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:bstr.</para>
    /// </summary>
    [SchemaAttr(5, "bstr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTBString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTBString class.
        /// </summary>
        public VTBString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTBString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTBString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTBString>(deep);
    }

    /// <summary>
    /// <para>Date and Time.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:date.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(DateTimeValue))]
    [SchemaAttr(5, "date")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTDate : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTDate class.
        /// </summary>
        public VTDate() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTDate class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTDate(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DateTimeValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTDate>(deep);
    }

    /// <summary>
    /// <para>File Time.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:filetime.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(DateTimeValue))]
    [SchemaAttr(5, "filetime")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTFileTime : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTFileTime class.
        /// </summary>
        public VTFileTime() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTFileTime class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTFileTime(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DateTimeValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTFileTime>(deep);
    }

    /// <summary>
    /// <para>Boolean.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:bool.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(BooleanValue))]
    [SchemaAttr(5, "bool")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTBool : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTBool class.
        /// </summary>
        public VTBool() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTBool class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTBool(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTBool>(deep);
    }

    /// <summary>
    /// <para>Currency.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:cy.</para>
    /// </summary>
    [StringValidator(Pattern = "\\s*[0-9]*\\.[0-9]{4}\\s*")]
    [SchemaAttr(5, "cy")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTCurrency : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTCurrency class.
        /// </summary>
        public VTCurrency() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTCurrency class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTCurrency(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTCurrency>(deep);
    }

    /// <summary>
    /// <para>Error Status Code.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:error.</para>
    /// </summary>
    [StringValidator(Pattern = "0x[0-9A-Fa-f]{8}")]
    [SchemaAttr(5, "error")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTError : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTError class.
        /// </summary>
        public VTError() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTError class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTError(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTError>(deep);
    }

    /// <summary>
    /// <para>Binary Versioned Stream.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:vstream.</para>
    /// </summary>
    [SchemaAttr(5, "vstream")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTVStreamData : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTVStreamData class.
        /// </summary>
        public VTVStreamData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTVStreamData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTVStreamData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <summary>
        /// <para>VSTREAM Version Attribute</para>
        /// <para>Represents the following attribute in the schema: version</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(Pattern = "\\s*\\{[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}\\}\\s*")]
        [SchemaAttr(0, "version")]
        [Index(0)]
        public StringValue Version { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTVStreamData>(deep);
    }

    /// <summary>
    /// <para>Class ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:clsid.</para>
    /// </summary>
    [StringValidator(Pattern = "\\s*\\{[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}\\}\\s*")]
    [SchemaAttr(5, "clsid")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTClassId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTClassId class.
        /// </summary>
        public VTClassId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTClassId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTClassId(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VTClassId>(deep);
    }

    /// <summary>
    /// <para>Clipboard Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is vt:cf.</para>
    /// </summary>
    [SchemaAttr(5, "cf")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VTClipboardData : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VTClipboardData class.
        /// </summary>
        public VTClipboardData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VTClipboardData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VTClipboardData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        /// <summary>
        /// <para>Format Attribute</para>
        /// <para>Represents the following attribute in the schema: format</para>
        /// </summary>
        [NumberValidator(MinInclusive = -3L)]
        [SchemaAttr(0, "format")]
        [Index(0)]
        public Int32Value Format { get; set; }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "size")]
        [Index(1)]
        public UInt32Value Size { get; set; }

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