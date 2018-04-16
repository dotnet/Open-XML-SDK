// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal static class XsdTypeExtension
    {
        /// <summary>
        /// Returns the XML Schema data type name of the specified type.
        /// </summary>
        /// <param name="xsdType">The XsdType type.</param>
        /// <returns>Returns the XML Schema data type name of the specified type.</returns>
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
                    throw new ArgumentOutOfRangeException(nameof(xsdType));
            }

            throw new ArgumentOutOfRangeException(nameof(xsdType));
        }
    }

#region TrueFalse / OnOff
#if false
    /// <summary>
    /// TrueFalseValue (ST_TrueFalse) based simple type constraint.
    /// </summary>
    [DataContract]
    internal class TrueFalseValueRestriction : SimpleTypeRestriction
    {
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
        }
#endif
    }

    /// <summary>
    /// TrueFalseBlankValue (ST_TrueFalseBlank) based simple type constraint.
    /// </summary>
    [DataContract]
    internal class TrueFalseBlankValueRestriction : SimpleTypeRestriction
    {
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
        }
#endif
    }

    /// <summary>
    /// OnOffValue (ST_OnOff) based simple type constraint.
    /// </summary>
    [DataContract]
    internal class OnOffValueRestriction : SimpleTypeRestriction
    {
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
    [DataContract]
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

        [DataMember]
        public string MinInclusive { get; set; }

        [DataMember]
        public string MaxInclusive { get; set; }

        [DataMember]
        public string MinExclusive { get; set; }

        [DataMember]
        public string MaxExclusive { get; set; }
    }
#endif

}
