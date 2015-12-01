// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// All simple types built in to xml schema.
    /// </summary>
    internal enum XsdType : byte
    {
        AnySimpleType, // xsd:anySimpleType
        String,
        NormalizedString,
        Token,
        Base64Binary,
        HexBinary,
        Integer,
        PositiveInteger,
        NegativeInteger,
        NonNegativeInteger,
        NonPositiveInteger,
        Long,
        UnsignedLong,
        Int,
        UnsignedInt,
        Short,
        UnsignedShort,
        Byte,
        UnsignedByte,
        Decimal,
        Float,
        Double,
        Boolean,
        Duration,
        DateTime,
        Date,
        Time,
        GYear,
        GYearMonth,
        GMonth,
        GMonthDay,
        GDay,
        Name,
        QName,
        NCName,
        AnyURI,
        Language,
        ID,
        IDREF,
        IDREFS,
        ENTITY,
        ENTITIES,
        NOTATION,
        NMTOKEN,
        NMTOKENS,

        // below items are not in schema
        Enum,
        List,
        Union,
        Redirected,

        // special for TrueFalseValue, TrueFalseBlankValue, OnOffValue
        SpecialBoolean,
    }

    internal static class XsdTypeExtension
    {
        /// <summary>
        /// Returns the XML Schema datatype name of the specified type.
        /// </summary>
        /// <param name="xsdType">The XsdType type.</param>
        /// <returns>Returns the XML Schema datatype name of the specified type.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public static string GetXsdDataTypeName(this XsdType xsdType)
        {
            switch (xsdType)
            {
                case XsdType.String:
                    return "string";

                case XsdType.NormalizedString:
                    return "normalizedString";

                case XsdType.Token:
                    return "token";

                case XsdType.Base64Binary:
                    return "base64Binary";

                case XsdType.HexBinary:
                    return "hexBinary";

                case XsdType.Integer:
                    return "integer";

                case XsdType.PositiveInteger:
                    return "positiveInteger";

                case XsdType.NegativeInteger:
                    return "negativeInteger";

                case XsdType.NonNegativeInteger:
                    return "nonNegativeInteger";

                case XsdType.NonPositiveInteger:
                    return "nonPositiveInteger";

                case XsdType.Long:
                    return "long";

                case XsdType.UnsignedLong:
                    return "unsignedLong";

                case XsdType.Int:
                    return "int";

                case XsdType.UnsignedInt:
                    return "unsignedInt";

                case XsdType.Short:
                    return "short";

                case XsdType.UnsignedShort:
                    return "unsignedShort";

                case XsdType.Byte:
                    return "byte";

                case XsdType.UnsignedByte:
                    return "unsignedByte";

                case XsdType.Decimal:
                    return "decimal";

                case XsdType.Float:
                    return "float";

                case XsdType.Double:
                    return "double";

                case XsdType.Boolean:
                    return "boolean";

                case XsdType.Duration:
                    return "duration";

                case XsdType.DateTime:
                    return "dateTime";

                case XsdType.Date:
                    return "date";

                case XsdType.Time:
                    return "time";

                case XsdType.GYear:
                    return "gYear";

                case XsdType.GYearMonth:
                    return "gYearMonth";

                case XsdType.GMonth:
                    return "gMonth";

                case XsdType.GMonthDay:
                    return "gMonthDay";

                case XsdType.GDay:
                    return "gDay";

                case XsdType.Name:
                    return "Name";

                case XsdType.QName:
                    return "QName";

                case XsdType.NCName:
                    return "NCName";

                case XsdType.AnyURI:
                    return "anyURI";

                case XsdType.Language:
                    return "language";

                case XsdType.ID:
                    return "ID";

                case XsdType.IDREF:
                    return "IDREF";

                case XsdType.IDREFS:
                    return "IDREFS";

                case XsdType.ENTITY:
                    return "ENTITY";

                case XsdType.ENTITIES:
                    return "ENTITIES";

                case XsdType.NOTATION:
                    return "NOTATION";

                case XsdType.NMTOKEN:
                    return "NMTOKEN";

                case XsdType.NMTOKENS:
                    return "NMTOKENS";

                case XsdType.AnySimpleType:
                    return "anySimpleType";
                // return "http://www.w3.org/2001/XMLSchema:anySimpleType":

                // special case for TrueFalseValue, TrueFalseBlankValue, OnOffValue
                case XsdType.SpecialBoolean:
                //return "TrueFalseValue":
                //return "TrueFalseBlankValue":
                //return "OnOffValue":

                default:
                    throw new ArgumentOutOfRangeException("xsdType");
            }

            throw new ArgumentOutOfRangeException("xsdType");;
        }
    }

    /// <summary>
    /// Schema simple type restrictin facets.
    /// </summary>
    [Flags]
    internal enum RestrictionField : byte
    {
        None = 0x0,
        
        Length = 0x1,
        MinLength = 0x2,
        MaxLength = 0x4,
      
        MinInclusive = 0x8,
        MaxInclusive = 0x10,

        MinExclusive = 0x20,
        MaxExclusive = 0x40,

        Pattern = 0x80,

        /// <summary>
        /// MinInclusive | MaxInclusive
        /// </summary>
        MinMaxInclusive = MinInclusive | MaxInclusive,

        /// <summary>
        /// MinExclusive | MaxExclusive
        /// </summary>
        MinMaxExclusive = MinExclusive | MaxExclusive,

        /// <summary>
        /// MinInclusive | MaxInclusive | MinExclusive | MaxExclusive
        /// </summary>
        MinMaxRestriction = MinMaxInclusive | MinMaxExclusive,

        /// <summary>
        /// Length | MinLength | MaxLength
        /// </summary>
        LengthRestriction = Length | MinLength | MaxLength,
    }

    /// <summary>
    /// Holds all simple type constraints in array.
    /// </summary>
    [Serializable()]
    internal class SimpleTypeRestrictions
    {
        public int SimpleTypeCount { get; set; }
        public SimpleTypeRestriction[] SimpleTypes { get; set; }

        internal void Serialize(Stream stream)
        {
            // simpletypes
            // use BinaryFormatter to serialize 
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Full;
            binaryFormatter.Serialize(stream, this);
        }

        /// <summary>
        /// Deserialize the binary data into memory object.
        /// </summary>
        /// <param name="stream">The data stream.</param>
        /// <param name="fileFormat">The target file format version.</param>
        /// <returns></returns>
        internal static SimpleTypeRestrictions Deserialize(Stream stream, FileFormatVersions fileFormat)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Full;
            var simpleTypeRestrictions = (SimpleTypeRestrictions)(binaryFormatter.Deserialize(stream));
            foreach (var simpleType in simpleTypeRestrictions.SimpleTypes)
            {
                simpleType.FileFormat = fileFormat;
            }
            return simpleTypeRestrictions;
        }

        /// <summary>
        /// Indexer to retriver a specified data in the SimpleTypes.
        /// </summary>
        /// <param name="index">The index of the data in the SimpleTypes array.</param>
        /// <returns>The simple type constraint data.</returns>
        public SimpleTypeRestriction this[int index]
        {
            get
            {
                return this.SimpleTypes[index];
            }
        }
    }

    /// <summary>
    /// Base class for simple type constraint.
    /// </summary>
    [Serializable()]
    [DebuggerDisplay("RestrictionField={RestrictionField}")]
    internal abstract class SimpleTypeRestriction
    {
        [NonSerialized()]
        private FileFormatVersions _fileFormat;

        /// <summary>
        /// The FileFormat version of this restriction.
        /// </summary>
        internal FileFormatVersions FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        public SimpleTypeRestriction()
        {
            this.RestrictionField = RestrictionField.None;
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public abstract XsdType XsdType
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public abstract string ClrTypeName
        {
            get;
        }

        /// <summary>
        /// Is this an enumeration simple type?
        /// </summary>
        public virtual bool IsEnum
        {
            get { return false; }
        }

        /// <summary>
        /// Is this simple type a list?
        /// </summary>
        public virtual bool IsList
        {
            get { return false; }
        }

        public string Pattern
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the maxLength facets.
        /// </summary>
        public virtual int MaxLength
        {
            get { throw new InvalidOperationException(); }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets the minLength facets.
        /// </summary>
        public virtual int MinLength
        {
            get { throw new InvalidOperationException(); }
            set { throw new InvalidOperationException(); }
        }
        
        /// <summary>
        /// Gets the length facets.
        /// </summary>
        public virtual int Length
        {
            get { throw new InvalidOperationException(); }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets the restriction value in string in CultureInfo.CurrentUICulture.
        /// </summary>
        /// <param name="restrictionField">The facet to be retrived.</param>
        /// <returns>The value in string.</returns>
        public virtual string GetRestrictionValue(RestrictionField restrictionField)
        {
            switch (restrictionField)
            {
                case RestrictionField.Pattern:
                    return this.Pattern;

                case RestrictionField.Length:
                    return this.Length.ToString(CultureInfo.CurrentUICulture);

                case RestrictionField.MinLength:
                    return this.MinLength.ToString(CultureInfo.CurrentUICulture);

                case RestrictionField.MaxLength:
                    return this.MaxLength.ToString(CultureInfo.CurrentUICulture);

                default:
                    Debug.Assert(false);
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the effective constraint facets used in this instance.
        /// </summary>
        public RestrictionField RestrictionField
        {
            get;
            set;
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public virtual bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validate the value to all the constraints.
        /// </summary>
        /// <param name="attributeValue">The value to be validated.</param>
        /// <returns>An bit flag, a bit is set on if the corresponding constraint is failed.</returns>
        public RestrictionField Validate(OpenXmlSimpleType attributeValue)
        {
            RestrictionField resultFlag = RestrictionField.None;

            if ((this.RestrictionField & RestrictionField.Pattern) == RestrictionField.Pattern)
            {
                if (!this.IsPatternValid(attributeValue))
                {
                    resultFlag |= RestrictionField.Pattern;
                }
            }

            if ((this.RestrictionField & RestrictionField.Length) == RestrictionField.Length)
            {
                if (!this.IsLengthValid(attributeValue))
                {
                    resultFlag |= RestrictionField.Length;
                }
            }

            if ((this.RestrictionField & RestrictionField.MinLength) == RestrictionField.MinLength)
            {
                if (!this.IsMinLengthValid(attributeValue))
                {
                    resultFlag |= RestrictionField.MinLength;
                }
            }

            if ((this.RestrictionField & RestrictionField.MaxLength) == RestrictionField.MaxLength)
            {
                if (!this.IsMaxLengthValid(attributeValue))
                {
                    resultFlag |= RestrictionField.MaxLength;
                }
            }

            if ((this.RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
            {
                if (!this.IsMinInclusiveValid(attributeValue))
                {
                    resultFlag |= RestrictionField.MinInclusive;
                }
            }

            if ((this.RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
            {
                if (!this.IsMinExclusiveValid(attributeValue))
                {
                    resultFlag |= RestrictionField.MinExclusive;
                }
            }

            if ((this.RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
            {
                if (!this.IsMaxInclusiveValid(attributeValue))
                {
                    resultFlag |= RestrictionField.MaxInclusive;
                }
            }

            if ((this.RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
            {
                if (!this.IsMaxExclusiveValid(attributeValue))
                {
                    resultFlag |= RestrictionField.MaxExclusive;
                }
            }

            return resultFlag;
        }

        /// <summary>
        /// Test whether the attribute value is valid according the patten constraint.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public virtual bool IsPatternValid(OpenXmlSimpleType attributeValue)
        {
            return true;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 1 if the {variety} is ·atomic· then 
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value}; 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid. 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public virtual bool IsLengthValid(OpenXmlSimpleType attributeValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 1 if the {variety} is ·atomic· then 
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value}; 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid. 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public virtual bool IsMinLengthValid(OpenXmlSimpleType attributeValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 1 if the {variety} is ·atomic· then 
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value}; 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid. 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public virtual bool IsMaxLengthValid(OpenXmlSimpleType attributeValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validate whether the "minInclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public virtual bool IsMinInclusiveValid(OpenXmlSimpleType attributeValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validate whether the "minExclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public virtual bool IsMinExclusiveValid(OpenXmlSimpleType attributeValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validate whether the "maxInclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public virtual bool IsMaxInclusiveValid(OpenXmlSimpleType attributeValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validate whether the "maxExclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public virtual bool IsMaxExclusiveValid(OpenXmlSimpleType attributeValue)
        {
            throw new NotImplementedException();
        }

#if DEBUG
        public virtual void Verify()
        {
            return;
        }
#endif 
    }
     
    /// <summary>
    /// Class for attributes that have different simple type in Office2007 and Office2010.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [Serializable()]
    internal class RedirectedRestriction : SimpleTypeRestriction
    {
        public SimpleTypeRestriction TargetRestriction
        {
            get;
            set;
        }

        /// <summary>
        /// An ID for this type. 
        /// </summary>
        internal int AttributeId
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the ValidationErrorInfo.
        /// </summary>
        public RedirectedRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Redirected; }
            set { Debug.Assert(value == XsdType.AnySimpleType); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return this.TargetRestriction.ClrTypeName;
            }
        }

        public OpenXmlSimpleType ConvertValue(OpenXmlSimpleType value)
        {
            var targetValue = UnionHelper.CreateTargetValueObject(this, this.FileFormat);

            targetValue.InnerText = value.InnerText;

            return targetValue;
        }

        ///// <summary>
        ///// Validating the specified value is valid according the XsdType.
        ///// </summary>
        ///// <param name="attributeValue"></param>
        ///// <returns>False if the specified value is not valid.</returns>
        //public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        //{
        //    var targetValue = UnionHelper.CreateTargetValueObject(this, this.FileFormat);

        //    targetValue.InnerText = attributeValue.InnerText;
            
        //    return TargetRestriction.ValidateValueType(targetValue);
        //}

        ///// <summary>
        ///// Validate the value to all the constraints.
        ///// </summary>
        ///// <param name="attributeValue">The value to be validated.</param>
        ///// <returns>An bit flag, a bit is set on if the corresponding constraint is failed.</returns>
        //public override RestrictionField Validate(OpenXmlSimpleType attributeValue)
        //{
        //    var targetValue = UnionHelper.CreateTargetValueObject(this, this.FileFormat);
        //    return TargetRestriction.Validate(targetValue);
        //}

    }

    /// <summary>
    /// Class for all union simple types.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [Serializable()]
    internal class UnionValueRestriction : SimpleTypeRestriction
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleTypeRestriction[] unionField;

        public SimpleTypeRestriction[] UnionTypes
        {
            get
            {
                return this.unionField;
            }
            set
            {
                this.unionField = value;
            }
        }

        /// <summary>
        /// An ID for union. 
        /// </summary>
        internal int UnionId
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the ValidationErrorInfo.
        /// </summary>
        public UnionValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Union; }
            set { Debug.Assert(value == XsdType.AnySimpleType); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                Debug.Assert(false); // should never be called.
                return string.Empty;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            // 
            StringValue stringValue = attributeValue.InnerText;

            var memberValues = UnionHelper.CreatePossibleMembers(this, this.FileFormat);

            int count = memberValues.Length;
            Debug.Assert(count == this.UnionTypes.Length);

            OpenXmlSimpleType simpleValue;
            SimpleTypeRestriction memberRestriction;

            for (int i = 0; i < count ; i ++)
            {
                simpleValue = memberValues[i];
                simpleValue.InnerText = stringValue;
                memberRestriction = this.UnionTypes[i];

                if (memberRestriction.ValidateValueType(simpleValue))
                {
                    if (memberRestriction.Validate(simpleValue) == RestrictionField.None)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

#if DEBUG
        public override void Verify()
        {
            return;
        }
#endif
    }

    /// <summary>
    /// Class for all string enum based simple types.
    /// </summary>
    /// <remarks>
    /// We do not save the enums in the database. Instead we reuse the generated enum class in the generated code.
    /// For attributes, the type of the enum is known through the code-gen'ed data.
    /// </remarks>
    [Serializable()]
    internal class EnumValueRestriction : SimpleTypeRestriction
    {
        public EnumValueRestriction()
            : base()
        {
        }
        
        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Enum; }
            set { Debug.Assert(value == XsdType.String || value == XsdType.Token); }
        }
        
        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                Debug.Assert(false); // should never be called.
                return string.Empty;
            }
        }
        
        /// <summary>
        /// Is this an enumeration simple type?
        /// </summary>
        public override bool IsEnum
        {
            get { return true; }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                // Items in the enum are merged from both Office2007 and Office2010.
                // So, we should report error when the item is not defined in the specified version.

                return attributeValue.IsInVersion(this.FileFormat);
            }
            return false;
        }

#if DEBUG
        public override void Verify()
        {
            return;
        }
#endif 
    }

    /// <summary>
    /// Class for all list simple types.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [Serializable()]
    internal class ListValueRestriction : SimpleTypeRestriction
    {
        public ListValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.List; }
            set { Debug.Assert(value == XsdType.AnySimpleType); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return this.ListItemType.ClrTypeName;
            }
        }
        
        /// <summary>
        /// Is this simple type a list?
        /// </summary>
        public override bool IsList
        {
            get { return true; }
        }

        public SimpleTypeRestriction ListItemType
        {
            get;
            set;
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                foreach (var itemValue in attributeValue.GetListItems())
                {
                    if (!this.ListItemType.ValidateValueType(itemValue) ||
                        this.ListItemType.Validate(itemValue) != RestrictionField.None)
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        // ************* No lenght, maxLength, minLength, pattern constraint on list type in current Ecma376.

#if false
        /// <summary>
        /// Gets the maxLength facets.
        /// </summary>
        public int MaxLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the minLength facets.
        /// </summary>
        public int MinLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the length facets.
        /// </summary>
        public int Length
        {
            get;
            set;
        }

        /// <summary>
        /// Get the lenght of the attribute value according to the xsd type.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        internal int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return 0;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public bool IsLengthValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return true;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public bool IsMinLengthValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return true;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public bool IsMaxLengthValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(false);
            return true;
        }
#endif

#if DEBUG
        public override void Verify()
        {
            return;
        }
#endif
    }
     
    /// <summary>
    /// Boolean (xsd:boolean) based simple type constraint.
    /// </summary>
    [Serializable()]
    internal class BooleanValueRestriction : SimpleTypeRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = typeof(Boolean).Name;

        private XsdType _xsdType = XsdType.Boolean;

        public BooleanValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return this._xsdType; }
            set
            {
                Debug.Assert(value == XsdType.Boolean || value == XsdType.SpecialBoolean);
                this._xsdType = value;
            }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.Boolean || this.XsdType == XsdType.SpecialBoolean);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);

            return;
        }
#endif 
    }

    /// <summary>
    /// Base class for digit value based simple type constraint.
    /// </summary>
    /// <typeparam name="T">A basic number type.</typeparam>
    /// <typeparam name="ST">A type of OpenXmlSimpleType.</typeparam>
    [Serializable()]
    internal abstract class SimpleValueRestriction<T, ST> : SimpleTypeRestriction
        where T : struct, IComparable<T>
        where ST : OpenXmlSimpleValue<T>, new()
    {
        protected abstract T MinValue
        {
            get;
        }

        protected abstract T MaxValue
        {
            get;
        }
        
        public SimpleValueRestriction()
            : base()
        {
            this.MinInclusive = this.MinValue;
            this.MaxInclusive = this.MaxValue;
        }

        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = typeof(T).Name;

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Gets the minInclusive facets.
        /// </summary>
        public T MinInclusive
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the maxInclusive facets.
        /// </summary>
        public T MaxInclusive
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the minExclusive facets.
        /// </summary>
        public T MinExclusive
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the maxExclusive facets.
        /// </summary>
        public T MaxExclusive
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the restriction value in string in CultureInfo.CurrentUICulture.
        /// </summary>
        /// <param name="restrictionField">The facet to be retrived.</param>
        /// <returns>The value in string.</returns>
        public override string GetRestrictionValue(RestrictionField restrictionField)
        {
            switch (restrictionField)
            {
                case RestrictionField.MinExclusive:
                    return this.MinExclusive.ToString();

                case RestrictionField.MaxExclusive:
                    return this.MaxExclusive.ToString();

                case RestrictionField.MinInclusive:
                    return this.MinInclusive.ToString();

                case RestrictionField.MaxInclusive:
                    return this.MaxInclusive.ToString();

                default:
                    return base.GetRestrictionValue(restrictionField);
            }
        }

        /// <summary>
        /// Convert the text "valueText" to value in OpenXmlSimpleValue.
        /// </summary>
        /// <param name="valueText"></param>
        /// <returns></returns>
        public virtual OpenXmlSimpleValue<T> StringToSimpleValue(string valueText)
        {
            if (String.IsNullOrEmpty(valueText))
            {
                return null;
            }

            ST simpleValue = new ST();
            simpleValue.InnerText = valueText;
            return simpleValue;
        }

        /// <summary>
        /// Validate whether the "minInclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public override bool IsMinInclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
            {
                // true if this.MinInclusive <= simpleValue.Value
                if (this.MinInclusive.CompareTo(simpleValue.Value) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate whether the "minExclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public override bool IsMinExclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
            {
                // true if this.MinExclusive < simpleValue.Value
                if (this.MinExclusive.CompareTo(simpleValue.Value) >= 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate whether the "maxInclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public override bool IsMaxInclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
            {
                // true if this.MaxInclusive >= simpleValue.Value
                if (this.MaxInclusive.CompareTo(simpleValue.Value) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate whether the "maxExclusive" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public override bool IsMaxExclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
            {
                // true if this.MaxExclusive > simpleValue.Value
                if (this.MaxExclusive.CompareTo(simpleValue.Value) <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {

            if (attributeValue.HasValue)
            {
                ST stValue = (ST)attributeValue;

                if (stValue.Value.CompareTo(this.MinValue) < 0 ||
                    stValue.Value.CompareTo(this.MaxValue) > 0)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);

            this.VerifyMinMax();

            return;
        }

        public void VerifyMinMax()
        {
            if ((this.RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
            {
                Debug.Assert(this.MinExclusive.CompareTo(this.MinValue) >= 0);
            }
            if ((this.RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
            {
                Debug.Assert(this.MaxExclusive.CompareTo(this.MaxValue) <= 0);
            }
            if ((this.RestrictionField & RestrictionField.MinMaxExclusive) == RestrictionField.MinMaxExclusive)
            {
                Debug.Assert(this.MinExclusive.CompareTo(this.MaxExclusive) < 0);
            }

            if ((this.RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
            {
                Debug.Assert(this.MinInclusive.CompareTo(this.MinValue) >= 0);
            }
            if ((this.RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
            {
                Debug.Assert(this.MaxInclusive.CompareTo(this.MaxValue) <= 0);
            }
            if ((this.RestrictionField & RestrictionField.MinMaxInclusive) == RestrictionField.MinMaxInclusive)
            {
                Debug.Assert(this.MinInclusive.CompareTo(this.MaxInclusive) <= 0);
            }
        }
#endif
    }

    /// <summary>
    /// Byte ( xsd:unsignedByte ) based value restriction.
    /// </summary>
    [Serializable()]
    internal class ByteValueRestriction : SimpleValueRestriction<Byte, ByteValue>
    {
        public ByteValueRestriction()
            : base()
        {
        }

        protected override Byte MinValue
        {
            get { return Byte.MinValue; }
        }

        protected override Byte MaxValue
        {
            get { return Byte.MaxValue; }
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.UnsignedByte; }
            set { Debug.Assert(value == XsdType.UnsignedByte); }
        }
    }

    /// <summary>
    /// SByte (xsd:bye) based value restriction. 
    /// </summary>
    [Serializable()]
    internal class SByteValueRestriction : SimpleValueRestriction<SByte, SByteValue>
    {
        public SByteValueRestriction()
            : base()
        {
        }

        protected override SByte MinValue
        {
            get { return SByte.MinValue; }
        }

        protected override SByte MaxValue
        {
            get { return SByte.MaxValue; }
        }


        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Byte; }
            set { Debug.Assert(value == XsdType.Byte); }
        }
    }

    /// <summary>
    /// Int16 ( xsd:short ) based value restriction.
    /// </summary>
    [Serializable()]
    internal class Int16ValueRestriction : SimpleValueRestriction<Int16, Int16Value>
    {
        public Int16ValueRestriction()
            : base()
        {
        }

        protected override Int16 MinValue
        {
            get { return Int16.MinValue; }
        }

        protected override Int16 MaxValue
        {
            get { return Int16.MaxValue; }
        }


        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Short; }
            set { Debug.Assert(value == XsdType.Short); }
        }
    }

    /// <summary>
    /// Int32 (xsd:int) based value restriction.
    /// </summary>
    [Serializable()]
    internal class Int32ValueRestriction : SimpleValueRestriction<Int32, Int32Value>
    {
        public Int32ValueRestriction()
            : base()
        {
        }

        protected override Int32 MinValue
        {
            get { return Int32.MinValue; }
        }

        protected override Int32 MaxValue
        {
            get { return Int32.MaxValue; }
        }


        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Int; }
            set { Debug.Assert(value == XsdType.Int); }
        }
    }

    /// <summary>
    /// Int64 (xsd:long) based value restriction.
    /// </summary>
    [Serializable()]
    internal class Int64ValueRestriction : SimpleValueRestriction<Int64, Int64Value>
    {
        public Int64ValueRestriction()
            : base()
        {
        }

        protected override Int64 MinValue
        {
            get { return Int64.MinValue; }
        }

        protected override Int64 MaxValue
        {
            get { return Int64.MaxValue; }
        }


        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Long; }
            set { Debug.Assert(value == XsdType.Long); }
        }
    }

    /// <summary>
    /// UInt16 ( xsd:unsignedShort ) based value restriction.
    /// </summary>
    [Serializable()]
    internal class UInt16ValueRestriction : SimpleValueRestriction<UInt16, UInt16Value>
    {
        public UInt16ValueRestriction()
            : base()
        {
        }

        protected override UInt16 MinValue
        {
            get { return UInt16.MinValue; }
        }

        protected override UInt16 MaxValue
        {
            get { return UInt16.MaxValue; }
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.UnsignedShort; }
            set { Debug.Assert(value == XsdType.UnsignedShort); }
        }
    }

    /// <summary>
    /// UInt32 (xsd:unsignedInt) based value restriction.
    /// </summary>
    [Serializable()]
    internal class UInt32ValueRestriction : SimpleValueRestriction<UInt32, UInt32Value>
    {
        public UInt32ValueRestriction()
            : base()
        {
        }

        protected override UInt32 MinValue
        {
            get { return UInt32.MinValue; }
        }

        protected override UInt32 MaxValue
        {
            get { return UInt32.MaxValue; }
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.UnsignedInt; }
            set { Debug.Assert(value == XsdType.UnsignedInt); }
        }
    }

    /// <summary>
    /// UInt64 (xsd:unsignedLong) based value restriction.
    /// </summary>
    [Serializable]
    internal class UInt64ValueRestriction : SimpleValueRestriction<UInt64, UInt64Value>
    {
        public UInt64ValueRestriction()
            : base()
        {
        }

        protected override UInt64 MinValue
        {
            get { return UInt64.MinValue; }
        }

        protected override UInt64 MaxValue
        {
            get { return UInt64.MaxValue; }
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.UnsignedLong; }
            set { Debug.Assert(value == XsdType.UnsignedLong); }
        }
    }

    /// <summary>
    /// Single (xsd:float) based value restriction.
    /// </summary>
    [Serializable()]
    internal class SingleValueRestriction : SimpleValueRestriction<Single, SingleValue>
    {
        public SingleValueRestriction()
            : base()
        {
        }

        protected override Single MinValue
        {
            get { return Single.MinValue; }
        }

        protected override Single MaxValue
        {
            get { return Single.MaxValue; }
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Float; }
            set { Debug.Assert(value == XsdType.Float); }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                return true;

                // TODO: is NaN valid?
                //Single value = ((SingleValue)attributeValue).Value;
                //return !Single.IsNaN(value);
            }
            return false;
        }
    }

    /// <summary>
    /// Double (xsd:double) based value restriction.
    /// </summary>
    [Serializable()]
    internal class DoubleValueRestriction : SimpleValueRestriction<Double, DoubleValue>
    {
        public DoubleValueRestriction()
            : base()
        {
        }

        protected override Double MinValue
        {
            get { return Double.MinValue; }
        }

        protected override Double MaxValue
        {
            get { return Double.MaxValue; }
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Double; }
            set { Debug.Assert(value == XsdType.Double); }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                return true;

                // TODO: is NaN valid?
                //double value = ((DoubleValue)attributeValue).Value;
                //return !double.IsNaN(value);
            }
            return false;
        }
    }

    /// <summary>
    /// Decimal (xsd:decimal) based value restriction.
    /// </summary>
    /// <remarks>
    /// decimal represents a subset of the real numbers, which can be represented by decimal numerals. 
    /// The ·value space· of decimal is the set of numbers that can be obtained by multiplying an integer by a non-positive power of ten, 
    /// i.e., expressible as i × 10^-n where i and n are integers and n >= 0. 
    /// Precision is not reflected in this value space; the number 2.0 is not distinct from the number 2.00. 
    /// The ·order-relation· on decimal is the order relation on real numbers, restricted to this subset. 
    /// </remarks>
    [Serializable()]
    internal class DecimalValueRestriction : SimpleValueRestriction<Decimal, DecimalValue>
    {
        public DecimalValueRestriction()
            : base()
        {
        }

        protected override Decimal MinValue
        {
            get { return Decimal.MinValue; }
        }

        protected override Decimal MaxValue
        {
            get { return Decimal.MaxValue; }
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Decimal; }
            set { Debug.Assert(value == XsdType.Decimal); }
        }
    }

    /// <summary>
    /// Integer (xsd:integer) based value restriction.
    /// </summary>
    /// <remarks>
    ///  integer is ·derived· from decimal by fixing the value of ·fractionDigits· to be 0 and disallowing the trailing decimal point. 
    ///  This results in the standard mathematical concept of the integer numbers. 
    ///  The ·value space· of integer is the infinite set {...,-2,-1,0,1,2,...}. The ·base type· of integer is decimal. 
    ///  
    /// !******************** TODO: at current, the CodeGen generate int for xsd:integer
    /// </remarks>
    [Serializable()]
    internal class IntegerValueRestriction : SimpleValueRestriction<Int64, IntegerValue>
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_Integer;

        protected override Int64 MinValue
        {
            get { return Int64.MinValue; }
        }

        protected override Int64 MaxValue
        {
            get { return Int64.MaxValue; }
        }

        public IntegerValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Integer; }
            set { Debug.Assert(value == XsdType.Integer); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }
    }

    /// <summary>
    /// NonNegativeInteger (xsd:nonNegativeInteger, ) based value restriction.
    /// </summary>
    /// <remarks>
    /// nonNegativeInteger is ·derived· from integer by setting the value of ·minInclusive· to be 0. 
    /// This results in the standard mathematical concept of the non-negative integers. 
    /// The ·value space· of nonNegativeInteger is the infinite set {0,1,2,...}. 
    /// The ·base type· of nonNegativeInteger is integer. 
    ///
    /// !******************** TODO: at current, the CodeGen generate int for xsd:integer
    /// </remarks>
    [Serializable()]
    internal class NonNegativeIntegerValueRestriction : IntegerValueRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_nonNegativeInteger;

        protected override Int64 MinValue
        {
            get { return 0; }
        }

        public NonNegativeIntegerValueRestriction()
            : base()
        {
            this.RestrictionField = RestrictionField.MinInclusive;
            this.MinInclusive = 0;
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.NonNegativeInteger; }
            set { Debug.Assert(value == XsdType.NonNegativeInteger); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }
    }

    /// <summary>
    /// PositiveInteger (xsd:positiveInteger, ) based value restriction.
    /// </summary>
    /// <remarks>
    /// positiveInteger is ·derived· from nonNegativeInteger by setting the value of ·minInclusive· to be 1. 
    /// This results in the standard mathematical concept of the positive integer numbers. 
    /// The ·value space· of positiveInteger is the infinite set {1,2,...}. 
    /// The ·base type· of positiveInteger is nonNegativeInteger.
    ///
    /// !******************** TODO: at current, the CodeGen generate int for xsd:integer
    /// </remarks>
    [Serializable()]
    internal class PositiveIntegerValueRestriction : IntegerValueRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_positiveInteger;
        
        // TODO: change to decimal, and the minValue should be decimal.

        protected override Int64 MinValue
        {
            get { return 1; }
        }

        public PositiveIntegerValueRestriction()
            : base()
        {
            this.RestrictionField = RestrictionField.MinInclusive;
            this.MinInclusive = 1;
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.PositiveInteger; }
            set { Debug.Assert(value == XsdType.PositiveInteger); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }
    }

    /// <summary>
    /// DateTime (xsd:dateTime) based value restriction.
    /// </summary>
    [Serializable()]
    internal class DateTimeValueRestriction : SimpleValueRestriction<DateTime, DateTimeValue>
    {
        protected override DateTime MinValue
        {
            get { return DateTime.MinValue; }
        }

        protected override DateTime MaxValue
        {
            get { return DateTime.MaxValue; }
        }

        public DateTimeValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.DateTime; }
            set { Debug.Assert(value == XsdType.DateTime); }
        }
    }

    /// <summary>
    /// DateTime (xsd:date) based value restriction.
    /// </summary>
    [Serializable()]
    internal class DateValueRestriction : SimpleValueRestriction<DateTime, DateTimeValue>
    {
        protected override DateTime MinValue
        {
            get { return DateTime.MinValue; }
        }

        protected override DateTime MaxValue
        {
            get { return DateTime.MaxValue; }
        }

        public DateValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Date; }
            set { Debug.Assert(value == XsdType.Date); }
        }

        // TODO: validate date.
    }

    /// <summary>
    /// Base class for string (xsd:string) based simple type constraints.
    /// </summary>
    [Serializable()]
    internal class StringRestriction : SimpleTypeRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = typeof(string).Name;

        // private XsdType _xsdType;
        public StringRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the maxLength facets.
        /// </summary>
        public override int MaxLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the minLength facets.
        /// </summary>
        public override int MinLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the length facets.
        /// </summary>
        public override int Length
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.String; }
            set { Debug.Assert(value == XsdType.String); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Test whether the attribute value is valid according the patten constraint.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public override bool IsPatternValid(OpenXmlSimpleType attributeValue)
        {
            if ((this.RestrictionField & RestrictionField.Pattern) == RestrictionField.Pattern)
            {
                string pattern = @"\A(" + this.Pattern + @")\z";
                return Regex.IsMatch(attributeValue.InnerText, pattern, RegexOptions.CultureInvariant);
            }
            return true;
        }

       
        /// <summary>
        /// Get the lenght of the attribute value according to the xsd type.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 1 if the {variety} is ·atomic· then 
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value}; 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid. 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        internal virtual int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            return attributeValue.InnerText.Length;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 1 if the {variety} is ·atomic· then 
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value}; 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid. 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public override bool IsLengthValid(OpenXmlSimpleType attributeValue)
        {
            if ((this.RestrictionField & RestrictionField.Length) == RestrictionField.Length)
            {
                if (GetValueLength(attributeValue) != this.Length)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 1 if the {variety} is ·atomic· then 
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value}; 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid. 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public override bool IsMinLengthValid(OpenXmlSimpleType attributeValue)
        {
            if ((this.RestrictionField & RestrictionField.MinLength) == RestrictionField.MinLength)
            {
                if (GetValueLength(attributeValue) < this.MinLength)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate whether the "length" constraint is ok.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>True if the length of the value is same as defined.</returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        /// 1 if the {variety} is ·atomic· then 
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value}; 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid. 
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value} 
        /// </remarks>
        public override bool IsMaxLengthValid(OpenXmlSimpleType attributeValue)
        {
            if ((this.RestrictionField & RestrictionField.MaxLength) == RestrictionField.MaxLength)
            {
                if (GetValueLength(attributeValue) > this.MaxLength)
                {
                    return false;
                }
            }
            return true;
        }
    }

    /// <summary>
    /// Token (xsd:token) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// token represents tokenized strings. 
    /// The ·value space· of token is the set of strings that do not contain the carriage return (#xD), 
    /// line feed (#xA) nor tab (#x9) characters, that have no leading or trailing spaces (#x20) and 
    /// that have no internal sequences of two or more spaces. 
    /// The ·lexical space· of token is the set of strings that do not contain the carriage return (#xD), 
    /// line feed (#xA) nor tab (#x9) characters, that have no leading or trailing spaces (#x20) and 
    /// that have no internal sequences of two or more spaces. The ·base type· of token is normalizedString
    /// 
    /// In Ecma376, most token are enumerations.
    /// </remarks>
    [Serializable()]
    internal class TokenRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_token;

        public TokenRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Token; }
            set { Debug.Assert(value == XsdType.Token); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            try
            {
                XmlConvert.VerifyTOKEN(attributeValue.InnerText);
            }
            catch (XmlException)
            {
                return false;
            }

            return true;
        }
    }

    /// <summary>
    /// QName (xsd:QName) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// QName represents XML qualified names. 
    /// The ·value space· of QName is the set of tuples {namespace name, local part}, where namespace name is an anyURI and local part is an NCName. 
    /// The ·lexical space· of QName is the set of strings that ·match· the QName production of [Namespaces in XML]. 
    /// </remarks>
    [Serializable()]
    internal class QnameRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_QName;

        public QnameRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.QName; }
            set { Debug.Assert(value == XsdType.QName); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }
        
        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            //Qualified Name 
            //[6]  QName ::=  (Prefix ':')? LocalPart 
            //[7]  Prefix ::=  NCName 
            //[8]  LocalPart ::=  NCName 
             
            string qname = attributeValue.InnerText;

            if (string.IsNullOrEmpty(qname))
            {
                return false;
            }

            int colonIndex = qname.IndexOf(":", StringComparison.Ordinal);

            if (colonIndex == 0 || colonIndex == qname.Length - 1)
            {
                // ":" at begin or end is invalid.
                return false;
            }

            if (colonIndex > 0)
            {
                // prefix must be NCName
                try
                {
                    XmlConvert.VerifyNCName(qname.Substring(0, colonIndex));
                }
                catch (XmlException)
                {
                    return false;
                }

                // TODO: verify the prefix is defined in the context.
            }

            // local name must be NCName
            try
            {
                XmlConvert.VerifyNCName(qname.Substring(colonIndex + 1));
            }
            catch (XmlException)
            {
                return false;
            }

            return true;
        }
    }

#if false
    //****************************************
    // No xsd:normalizedString in Ecma376
    //****************************************

    /// <summary>
    /// Normalized string (xsd:normalizedString) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// normalizedString represents white space normalized strings. 
    /// The ·value space· of normalizedString is the set of strings that do not contain the carriage return (#xD), line feed (#xA) nor tab (#x9) characters. 
    /// The ·lexical space· of normalizedString is the set of strings that do not contain the carriage return (#xD), line feed (#xA) nor tab (#x9) characters. 
    /// The ·base type· of normalizedString is string. 
    /// </remarks>
    [Serializable()]
    internal class NormalizedStringRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static char[] crt = new char[] { '\n', '\r', '\t' };

        public NormalizedStringRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.NormalizedString; }
            set { Debug.Assert(value == XsdType.NormalizedString); }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (String.IsNullOrEmpty(attributeValue.InnerText))
            {
                return true;
            }
            if (attributeValue.InnerText.IndexOfAny(crt) != -1)
            {
                return false;
            }
            return true;
        }

    }

    //****************************************
    // No xsd:name in Ecma376
    //****************************************

    /// <summary>
    /// Name (xsd:Name) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// Name represents XML Names. The ·value space· of Name is the set of all strings which ·match· the Name production of [XML 1.0 (Second Edition)]. 
    /// The ·lexical space· of Name is the set of all strings which ·match· the Name production of [XML 1.0 (Second Edition)]. 
    /// The ·base type· of Name is token. 
    /// </remarks>
    [Serializable()]
    internal class NameRestriction : StringRestriction
    {
        public NameRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Name; }
            set { Debug.Assert(value == XsdType.Name); }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            try
            {
                XmlConvert.VerifyName(attributeValue.InnerText);
            }
            catch (XmlException)
            {
                return false;
            }

            return true;
        }
    }
#endif
    //****************************************
    // the xml:space is NcName
    // No other explicit use of xsd:NCName in Ecma376
    //****************************************

    /// <summary>
    /// NCName (xsd:NCName) based simple type constraint.
    /// </summary>
    /// <remarks>
    ///  NCName represents XML "non-colonized" Names. 
    ///  The ·value space· of NCName is the set of all strings which ·match· the NCName production of [Namespaces in XML]. 
    ///  The ·lexical space· of NCName is the set of all strings which ·match· the NCName production of [Namespaces in XML]. 
    ///  The ·base type· of NCName is Name. 
    ///  
    ///  Also Use NcName for IDREF.
    ///  IDREF represents the IDREF attribute type from [XML 1.0 (Second Edition)]. 
    ///  The ·value space· of IDREF is the set of all strings that ·match· the NCName production in [Namespaces in XML]. 
    ///  The ·lexical space· of IDREF is the set of strings that ·match· the NCName production in [Namespaces in XML]. 
    ///  The ·base type· of IDREF is NCName. 
    /// </remarks>
    [Serializable()]
    internal class NcNameRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_NCName;
        
        public NcNameRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.NCName; }
            set { Debug.Assert(value == XsdType.NCName || value == XsdType.IDREF);  }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return false;
            }
            try
            {
                XmlConvert.VerifyNCName(attributeValue.InnerText);
            }
            catch (XmlException)
            {
                return false;
            }

            return true;
        }
    }

    /// <summary>
    /// ID (xsd:ID) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// ID represents the ID attribute type from [XML 1.0 (Second Edition)]. 
    /// The ·value space· of ID is the set of all strings that ·match· the NCName production in [Namespaces in XML]. 
    /// The ·lexical space· of ID is the set of all strings that ·match· the NCName production in [Namespaces in XML]. 
    /// The ·base type· of ID is NCName. 
    /// </remarks>
    [Serializable()]
    internal class IdStringRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_ID;

        public IdStringRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.ID; }
            set { Debug.Assert(value == XsdType.ID); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return false;
            }

            try
            {
                XmlConvert.VerifyNCName(attributeValue.InnerText);
            }
            catch (XmlException)
            {
                return false;
            }

            return true;
        }
    }

    /// <summary>
    /// AnyURI (xsd:anyURI) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// anyURI represents a Uniform Resource Identifier Reference (URI). 
    /// An anyURI value can be absolute or relative, and may have an optional fragment identifier (i.e., it may be a URI Reference). 
    /// This type should be used to specify the intention that the value fulfills the role of a URI as defined by [RFC 2396], as amended by [RFC 2732]. 
    /// </remarks>
    [Serializable()]
    internal class AnyUriRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = typeof(Uri).Name;

        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static char[] WhitespaceChars = new char[] { ' ', '\t', '\n', '\r' };

        public AnyUriRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.AnyURI; }
            set { Debug.Assert(value == XsdType.AnyURI); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            Uri result = null;
            Debug.Assert(attributeValue != null);
            string uriString = attributeValue.InnerText;

            // code copied from XmlConvert.TryToUri()

            if ((uriString != null) && (uriString.Length > 0))
            {
                uriString = uriString.Trim(WhitespaceChars);
                if ((uriString.Length == 0) || (uriString.IndexOf("##", StringComparison.Ordinal) != -1))
                {
                    return false;
                }
            }
            if (!Uri.TryCreate(uriString, UriKind.RelativeOrAbsolute, out result))
            {
                return false;
            }

            return true;
        }
    }

    /// <summary>
    /// Hex binary (xsd:hexBinary) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// hexBinary has a lexical representation where each binary octet is encoded as a character tuple, 
    /// consisting of two hexadecimal digits ([0-9a-fA-F]) representing the octet code. 
    /// For example, "0FB7" is a hex encoding for the 16-bit integer 4023 (whose binary representation is 111110110111). 
    /// </remarks>
    [Serializable()]
    internal class HexBinaryRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_hexBinary;

        public HexBinaryRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.HexBinary; }
            set { Debug.Assert(value == XsdType.HexBinary); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.InnerText == null)
            {
                return false;
            }
            else if (attributeValue.InnerText.Length == 0)
            {
                return true;
            }

            string pattern = @"\A([0-9a-fA-F][0-9a-fA-F])+\z";

            return Regex.IsMatch(attributeValue.InnerText, pattern, RegexOptions.CultureInvariant);
        }

        /// <summary>
        /// Get the lenght of the attribute value according to the xsd type.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        /// </remarks>
        internal override int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            // so, the data length is the number of octets
            // then the data lenght is string lenght / 2
            var stringLength = attributeValue.InnerText.Length;
            //Debug.Assert(stringLength % 2 == 0);
            return (stringLength + 1) / 2;
        }
    }

    /// <summary>
    /// Base64 binary (xsd:base64Binary) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// The lexical forms of base64Binary values are limited to the 65 characters of the Base64 Alphabet defined in [RFC 2045], i.e., a-z, A-Z, 0-9, the plus sign (+), the forward slash (/) and the equal sign (=), together with the characters defined in [XML 1.0 (Second Edition)] as white space. No other characters are allowed. 
    /// </remarks>
    [Serializable()]
    internal class Base64BinaryRestriction : StringRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_base64Binary;

        public Base64BinaryRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Base64Binary; }
            set { Debug.Assert(value == XsdType.Base64Binary); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.InnerText == null)
            {
                return false;
            }
            else if (attributeValue.InnerText.Length == 0)
            {
                return true;
            }

            try
            {
                Convert.FromBase64String(attributeValue.InnerText);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }
     

        /// <summary>
        /// Get the lenght of the attribute value according to the xsd type.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows: 
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value}; 
        /// </remarks>
        internal override int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            // decoded the data
            var binaryData = Convert.FromBase64String(attributeValue.InnerText);
            return binaryData.Length;
        }
    }

    /// <summary>
    /// language (xsd:language) based simple type constraint.
    /// </summary>
    /// <remarks>
    ///  language represents natural language identifiers as defined by by [RFC 3066] . 
    ///  The ·value space· of language is the set of all strings that are valid language identifiers as defined [RFC 3066] . 
    ///  The ·lexical space· of language is the set of all strings that conform to the pattern [a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})* . 
    ///  The ·base type· of language is token. 
    /// </remarks>
    [Serializable()]
    internal class LanguageRestriction : TokenRestriction
    {
        [NonSerialized()]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string clrTypeName = ValidationResources.TypeName_language;

        [NonSerialized()]
        private static string LanguageLexicalPattern = @"\A[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*\z";

        public LanguageRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.Language; }
            set { Debug.Assert(value == XsdType.Language); }
        }

        /// <summary>
        /// Returns the corresponding CLR type name. The name will be used to report error.
        /// </summary>
        public override string ClrTypeName
        {
            get
            {
                return clrTypeName;
            }
        }

        /// <summary>
        /// Validating the specified value is valid according the XsdType.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns>False if the specified value is not valid.</returns>
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            try
            {
                XmlConvert.VerifyTOKEN(attributeValue.InnerText);
            }
            catch (XmlException)
            {
                return false;
            }


            return Regex.IsMatch(attributeValue.InnerText, LanguageLexicalPattern, RegexOptions.CultureInvariant);
        }
    }

    #region TrueFalse / OnOff 
#if false
    /// <summary>
    /// TrueFalseValue (ST_TrueFalse) based simple type constraint.
    /// </summary>
    [Serializable()]
    internal class TrueFalseValueRestriction : SimpleTypeRestriction
    {
        public TrueFalseValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.TrueFalseValue; }
            set { Debug.Assert(value == XsdType.TrueFalseValue); }
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.TrueFalseValue);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);

            return;
        }
#endif
    }

    /// <summary>
    /// TrueFalseBlankValue (ST_TrueFalseBlank) based simple type constraint.
    /// </summary>
    [Serializable()]
    internal class TrueFalseBlankValueRestriction : SimpleTypeRestriction
    {
        public TrueFalseBlankValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.TrueFalseBlankValue; }
            set { Debug.Assert(value == XsdType.TrueFalseBlankValue); }
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.TrueFalseBlankValue);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);

            return;
        }
#endif
    }

    /// <summary>
    /// OnOffValue (ST_OnOff) based simple type constraint.
    /// </summary>
    [Serializable()]
    internal class OnOffValueRestriction : SimpleTypeRestriction
    {
        public OnOffValueRestriction()
            : base()
        {
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.OnOffValue; }
            set { Debug.Assert(value == XsdType.OnOffValue); }
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.OnOffValue);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);

            return;
        }
#endif
    }

#endif
    #endregion

#if false
    /// <summary>
    /// Other simple type.
    /// </summary>
    /// <remarks>
    /// TODO: this type should be removed when finished all the simple types.
    /// </remarks>
    [Serializable()]
    internal class OtherSimpleTypeRestriction : SimpleTypeRestriction
    {
        private XsdType _xsdType;

        public OtherSimpleTypeRestriction()
            : base()
        {
            Debug.Assert(false);
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return this._xsdType; }
            set { this._xsdType = value; }
        }
        
        public string MinInclusive
        {
            get;
            set;
        }

        public string MaxInclusive
        {
            get;
            set;
        }

        public string MinExclusive
        {
            get;
            set;
        }

        public string MaxExclusive
        {
            get;
            set;
        }

#if DEBUG
        public override void Verify()
        {
            return;
        }
#endif
    }
#endif

}
