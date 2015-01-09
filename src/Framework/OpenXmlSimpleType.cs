// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.Globalization;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the abstract base class for all simple types that are used in attributes.
    /// </summary>
    public abstract class OpenXmlSimpleType : ICloneable
    {
        private string _textValue;

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleType class.
        /// </summary>
        protected OpenXmlSimpleType()
            : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleType class.
        /// </summary>
        /// <param name="source">The source OpenXmlSimpleType.</param>
        protected OpenXmlSimpleType(OpenXmlSimpleType source)
            : base()
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            this.TextValue = source.TextValue;
        }

        /// <summary>
        /// DON'T use this property. Only for OpenXmlSimpleType.cs internal use.
        /// The internal raw text value.
        /// </summary>
        protected string TextValue
        {
            get 
            {
                return _textValue; 
            }
            set 
            {
                _textValue = value; 
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal virtual void Parse()
        {
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal virtual bool TryParse()
        {
            return true;
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is a valid value.
        /// </summary>
        public virtual bool HasValue
        {
            get
            {
                return this._textValue != null;
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public virtual string InnerText
        {
            get
            {
                return _textValue;
            }
            set
            {
                _textValue = value;
            }
        }



        /// <summary>
        /// Returns a String that represents the current value. 
        /// </summary>
        /// <returns>A String that represents the current value. </returns>
        public override string ToString()
        {
            return InnerText;
        }

        #region ICloneable Members

        /// <summary>
        /// Creates a duplicate of the current value.
        /// </summary>
        /// <remarks>
        /// This method is a deep copy clone.
        /// </remarks>
        /// <returns>The cloned value.</returns>
        public object Clone()
        {
            return CloneImp();
        }

        internal abstract OpenXmlSimpleType CloneImp();

        #endregion

        /// <summary>
        /// Implicitly converts a specified attribute value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The OpenXmlSimpleType instance.</param>
        /// <returns>The converted string value.</returns>
        public static implicit operator String(OpenXmlSimpleType xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                return null;
            }

            return xmlAttribute.InnerText;
        }


        #region internal methods to be used by validation

        /// <summary>
        /// When overridden in the derived ListValue class, this method returns items in the list.
        /// </summary>
        /// <returns>Returns items in the list.</returns>
        internal virtual IEnumerable<OpenXmlSimpleType> GetListItems()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Test whether the value is allowed in the specified file format version. Only for EnumValue.
        /// </summary>
        /// <param name="fileFormat">The file format version.</param>
        /// <returns>True if the value is defined in the specified file format version.</returns>
        /// <remarks>
        /// Method to support enum validation in schema validation.
        /// </remarks>
        internal virtual bool IsInVersion(FileFormatVersions fileFormat)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    /// <summary>
    /// Represents a generic value for simple value types (Int32, UInt32, Byte, struct, etc).
    /// </summary>    
    /// <typeparam name="T">The type of the value.</typeparam>
    [DebuggerDisplay("{InnerText}")]
    public abstract class OpenXmlSimpleValue<T> 
        : OpenXmlSimpleType
        where T : struct
    {
        //can not use System.Nullable<T> _value;
        private T? _value;
        internal T? InnerValue
        {
            get { return this._value; }
            set { this._value = value; }
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class.
        /// </summary>
        protected OpenXmlSimpleValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class.
        /// </summary>
        /// <param name="value">The value in type T.</param>
        protected OpenXmlSimpleValue(T value)
            : base()
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSimpleValue class by deep copying the supplied OpenXmlSimpleValue class.
        /// </summary>
        /// <param name="source">The source OpenXmlSimleValue class.</param>
        protected OpenXmlSimpleValue(OpenXmlSimpleValue<T> source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            this.InnerText = source.InnerText;
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is a valid value.
        /// </summary>
        public override bool HasValue
        {
            get
            {
                if (!this._value.HasValue)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        TryParse();
                    }
                }

                return this._value.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value of the simple value.
        /// </summary>
        public T Value
        {
            get
            {
                if (!this._value.HasValue)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        Parse();
                    }
                }
                else
                {
                    // TODO: check that the .TextValue is same as .InnerValue in debug verion.
                }
                return  this._value.Value;
            }
            set
            {
                this._value = value;
                this.TextValue = null;
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                // do not check whether format is ok.

                this.TextValue = value;
                this._value = null;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to T.
        /// </summary>
        /// <param name="xmlAttribute">The OpenXmlSimpleValue instance.</param>
        /// <returns>The internal value in the OpenXmlSimpleValue class.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator T(OpenXmlSimpleValue<T> xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }
    }

    /// <summary>
    /// Represents the Boolean value for attributes.
    /// </summary> 
    [DebuggerDisplay("{InnerText}")]
    public class BooleanValue : OpenXmlSimpleValue<Boolean>
    {
        /// <summary>
        /// Initializes a new instance of the BooleanValue class.
        /// </summary>
        public BooleanValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The Boolean value.</param>
        public BooleanValue(Boolean value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class by deep copying
        /// the supplied BooleanValue class.
        /// </summary>
        /// <param name="source">
        /// The source BooleanValue class.
        /// </param>
        public BooleanValue(BooleanValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // Word use "1", "0"
                    this.TextValue = this.InnerValue.Value ? "1" : "0";
                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToBoolean(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Boolean value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToBoolean(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to a Boolean value.
        /// </summary>
        /// <param name="xmlAttribute">The BooleanValue to convert.</param>
        /// <returns>The converted Boolean value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Boolean(BooleanValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class by implicitly
        /// converting the supplied Boolean value.
        /// </summary>
        /// <param name="value">The Boolean value.</param>
        /// <returns>A new BooleanValue instance with the value.</returns>
        public static implicit operator BooleanValue(Boolean value)
        {

            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new BooleanValue object that was created by using the supplied Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value to use to create a new BooleanValue object.</param>
        /// <returns>A BooleanValue that corresponds to the value parameter.</returns>
        public static BooleanValue FromBoolean(Boolean value)
        {
            return new BooleanValue(value);
        }

        /// <summary>
        /// Returns the Boolean representation of a BooleanValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A BooleanValue object to retrieve a Boolean representation.
        /// </param>
        /// <returns>A Boolean value that represents a BooleanValue object.</returns>		
        public static Boolean ToBoolean(BooleanValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new BooleanValue(this);
        }
    }
    
    /// <summary>
    /// Represents the byte value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class ByteValue : OpenXmlSimpleValue<Byte>
    {
        /// <summary>
        /// Initializes a new instance of the ByteValue class.
        /// </summary>
        public ByteValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ByteValue class using the supplied
        /// Byte value.
        /// </summary>
        /// <param name="value">The Byte value.</param>
        public ByteValue(Byte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ByteValue class by deep copying
        /// the supplied ByteValue class.
        /// </summary>
        /// <param name="source">
        /// The source ByteValue class.
        /// </param>
        public ByteValue(ByteValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }
         
        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString());
                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToByte(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Byte value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToByte(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to a Byte value.
        /// </summary>
        /// <param name="xmlAttribute">
        /// The ByteValue to convert.
        /// </param>
        /// <returns>
        /// The converted Byte value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>		
        public static implicit operator Byte(ByteValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToByte(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the ByteValue class by implicitly converting
        /// the supplied Byte value.
        /// </summary>
        /// <param name="value">
        /// The Byte value.
        /// </param>
        /// <returns>A new ByteValue instance with the value.</returns>		
        public static implicit operator ByteValue(Byte value)
        {
            return FromByte(value);
        }

        /// <summary>
        /// Returns a new ByteValue object created from a Byte value.
        /// </summary>
        /// <param name="value">A Byte value to create a new ByteValue object from.</param>
        /// <returns>A ByteValue that corresponds to the value parameter.</returns>
        public static ByteValue FromByte(Byte value)
        {
            return new ByteValue(value);
        }

        /// <summary>
        /// Returns the Byte value representation of a ByteValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A ByteValue object to retrieve a Byte value representation.
        /// </param>
        /// <returns>A Byte value that represents a ByteValue object.</returns>
        public static Byte ToByte(ByteValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new ByteValue(this);
        }
    }

    /// <summary>
    /// Represents the SByte value for attributes.
    /// </summary>
    [System.CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class SByteValue : OpenXmlSimpleValue<SByte>
    {
        /// <summary>
        /// Initializes a new instance of the SByteValue class.
        /// </summary>
        public SByteValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SByteValue class using the supplied SByte value.
        /// </summary>
        /// <param name="value">The SByte value.</param>
        public SByteValue(SByte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SByteValue by deep copying the supplied SByteValue class.
        /// </summary>
        /// <param name="source">The source SByteValue class.</param>
        public SByteValue(SByteValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString());

                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToSByte(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            SByte value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToSByte(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified SByteValue to an SByte value.
        /// </summary>
        /// <param name="xmlAttribute">The SByteValue to convert.</param>
        /// <returns>The converted SByte value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator SByte(SByteValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToSByte(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified SByte value to an SByteValue instance.
        /// </summary>
        /// <param name="value">The specified SByte value.</param>
        /// <returns>A new SByteValue instance with the value.</returns>
        public static implicit operator SByteValue(SByte value)
        {
            return FromSByte(value);
        }

        /// <summary>
        /// Returns a new SByteValue object created from a Byte value.
        /// </summary>
        /// <param name="value">An SByte value to use to create a new SByteValue object.</param>
        /// <returns>An SByteValue that corresponds to the value parameter.</returns>
        public static SByteValue FromSByte(SByte value)
        {
            return new SByteValue(value);
        }

        /// <summary>
        /// Returns the SByte representation of an SByteValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An SByteValue object to retrieve an SByte representation.
        /// </param>
        /// <returns>An SByte value that represents an SByteValue object.</returns>		
        public static SByte ToSByte(SByteValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new SByteValue(this);
        }
    }

    /// <summary>
    /// Represents the Int16 value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int16Value : OpenXmlSimpleValue<Int16>
    {
        /// <summary>
        /// Initializes a new instance of the Int16Value class.
        /// </summary>
        public Int16Value()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int16Value class using the supplied Int16 value.
        /// </summary>
        /// <param name="value">The Int16 value.</param>
        public Int16Value(Int16 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int16Value by deep copying the supplied IntValue class.
        /// </summary>
        /// <param name="source">The source Int16Value class.</param>
        public Int16Value(Int16Value source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString());

                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToInt16(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Int16 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToInt16(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to an Int16 value.
        /// </summary>
        /// <param name="xmlAttribute">The Int16Value to convert.</param>
        /// <returns>The converted Int16 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Int16(Int16Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToInt16(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts an Int16 value to a Int16Value instance.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new Int16Value instance with the value.</returns>
        public static implicit operator Int16Value(Int16 value)
        {
            return FromInt16(value);
        }

        /// <summary>
        /// Returns a new Int16Value object that was created from an Int16 value.
        /// </summary>
        /// <param name="value">An Int16 value to use to create a new Int16Value object.</param>
        /// <returns>An Int16Value that corresponds to the value parameter.</returns>
        public static Int16Value FromInt16(Int16 value)
        {
            return new Int16Value(value);
        }

        /// <summary>
        /// Returns an Int16 representation of an Int16Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An Int16Value object to retrieve an Int16 representation.
        /// </param>
        /// <returns>An Int16 value that represents an Int16Value object.</returns>		
        public static Int16 ToInt16(Int16Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new Int16Value(this);
        }
    }

    /// <summary>
    /// Represents the Int32 value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int32Value : OpenXmlSimpleValue<Int32>
    {
        /// <summary>
        /// Initializes a new instance of the Int32Value class.
        /// </summary>
        public Int32Value()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int32Value class using the supplied Int32 value.
        /// </summary>
        /// <param name="value">The Int32 value.</param>
        public Int32Value(Int32 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int32Value by deep copying the supplied Int32Value class.
        /// </summary>
        /// <param name="source">The source Int32Value class.</param>
        public Int32Value(Int32Value source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString());

                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToInt32(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Int32 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToInt32(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to an Int32 value.
        /// </summary>
        /// <param name="xmlAttribute">The Int32Value to convert.</param>
        /// <returns>
        /// The converted Int32 value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Int32(Int32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToInt32(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts an Int32 value to a specified Int32Value instance.
        /// </summary>
        /// <param name="value">The specified Int32 value.</param>
        /// <returns>A new Int32Value instance with the value.</returns>
        public static implicit operator Int32Value(Int32 value)
        {
            return FromInt32(value);
        }

        /// <summary>
        /// Returns a new Int32Value object that was created from an Int32 value.
        /// </summary>
        /// <param name="value">An Int32 value to use to create a new Int32Value object.</param>
        /// <returns>An Int32Value that corresponds to the value parameter.</returns>
        public static Int32Value FromInt32(Int32 value)
        {
            return new Int32Value(value);
        }

        /// <summary>
        /// Returns the Int32 representation of an Int32Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An Int32Value object to use to retrieve an Int32 representation.
        /// </param>
        /// <returns>An Int32 value that represents an Int32Value object.</returns>		
        public static Int32 ToInt32(Int32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new Int32Value(this);
        }
    }

    /// <summary>
    /// Represents the Int64 value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int64Value : OpenXmlSimpleValue<Int64>
    {
        /// <summary>
        /// Initializes a new instance of the Int64Value class.
        /// </summary>
        public Int64Value()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int64Value class using the supplied Int64 value.
        /// </summary>
        /// <param name="value">The Int64 value.</param>
        public Int64Value(Int64 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Int64Value by deep copying the supplied Int64Value class.
        /// </summary>
        /// <param name="source">The source Int64Value class.</param>
        public Int64Value(Int64Value source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString());

                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToInt64(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Int64 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToInt64(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified Int64Value to an Int64 value.
        /// </summary>
        /// <param name="xmlAttribute">The Int64Value to convert.</param>
        /// <returns>The converted Int64 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Int64(Int64Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToInt64(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts an Int64 value to an Int64Value value.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new Int64Value instance with the value.</returns>
        public static implicit operator Int64Value(Int64 value)
        {
            return FromInt64(value);
        }

        /// <summary>
        /// Returns a new Int64Value object that was created from an Int64 value.
        /// </summary>
        /// <param name="value">An Int64 value to use to create a new Int64Value object.</param>
        /// <returns>An Int64Value that corresponds to the value parameter.</returns>
        public static Int64Value FromInt64(Int64 value)
        {
            return new Int64Value(value);
        }

        /// <summary>
        /// Returns the Int64 representation of an Int64Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An Int64Value object used to retrieve an Int64 representation.
        /// </param>
        /// <returns>An Int64 value that represents an Int64Value object.</returns>		
        public static Int64 ToInt64(Int64Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new Int64Value(this);
        }

    }

    /// <summary>
    /// Represents the xsd:integer value for attributes.
    /// </summary>
    /// <remarks>
    /// Integer is derived from decimal by fixing the value of fractionDigits to be 0 and disallowing the trailing decimal point. 
    /// The value space of integer is the infinite set {...,-2,-1,0,1,2,...}. The base type of integer is decimal. 
    /// 
    /// Use Int64 as the internal type for now. 
    /// TODO: Should decimal be used as the internal type?
    /// </remarks>
    [DebuggerDisplay("{InnerText}")]
    public class IntegerValue : OpenXmlSimpleValue<Int64>
    {
        /// <summary>
        /// Initializes a new instance of the IntegerValue class.
        /// </summary>
        public IntegerValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntegerValue class using the supplied Int64 value.
        /// </summary>
        /// <param name="value">The Int64 value.</param>
        public IntegerValue(Int64 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntegerValue class by deep copying the supplied IntegerValue class.
        /// </summary>
        /// <param name="source">The source IntegerValue class.</param>
        public IntegerValue(IntegerValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString());

                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToInt64(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Int64 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToInt64(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified IntegerValue to an Int64 value.
        /// </summary>
        /// <param name="xmlAttribute">The IntegerValue to convert.</param>
        /// <returns>
        /// The converted Int64 value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Int64(IntegerValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToInt64(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified Int64 value to an IntegerValue class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new IntegerValue instance with the value.</returns>
        public static implicit operator IntegerValue(Int64 value)
        {
            return FromInt64(value);
        }

        /// <summary>
        /// Returns a new IntegerValue object created from an Int64 value.
        /// </summary>
        /// <param name="value">An Int64 value to use to create a new IntegerValue object.</param>
        /// <returns>An IntegerValue that corresponds to the value parameter.</returns>
        public static IntegerValue FromInt64(Int64 value)
        {
            return new IntegerValue(value);
        }

        /// <summary>
        /// Returns the Int64 representation of an IntegerValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// An IntegerValue object used to retrieve an Int64 representation.
        /// </param>
        /// <returns>An Int64 value that represents an IntegerValue object.</returns>		
        public static Int64 ToInt64(IntegerValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new IntegerValue(this);
        }

    }

    /// <summary>
    /// Represents the UInt16 value for attributes.
    /// </summary>
    [System.CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt16Value : OpenXmlSimpleValue<UInt16>
    {
        /// <summary>
        /// Initializes a new instance of the UInt16Value class.
        /// </summary>
        public UInt16Value()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt16Value class using the supplied UInt16 value.
        /// </summary>
        /// <param name="value">The UInt16 value.</param>
        public UInt16Value(UInt16 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt16Value class by deep copying the supplied UInt16Value class.
        /// </summary>
        /// <param name="source">The source UInt16Value class.</param>
        public UInt16Value(UInt16Value source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString());

                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToUInt16(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            UInt16 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToUInt16(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified UInt16Value object to a UInt16 value.
        /// </summary>
        /// <param name="xmlAttribute">The UInt16Value to convert.</param>
        /// <returns>The converted UInt16 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator UInt16(UInt16Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToUInt16(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a UInt16 value to a UInt16Value class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new UInt16Value instance with the value.</returns>
        public static implicit operator UInt16Value(UInt16 value)
        {
            return FromUInt16(value);
        }


        /// <summary>
        /// Returns a new UInt16Value object created from a UInt16 value.
        /// </summary>
        /// <param name="value">A UInt16 value to use to create a new UInt16Value object.</param>
        /// <returns>A UInt16Value that corresponds to the value parameter.</returns>
        public static UInt16Value FromUInt16(UInt16 value)
        {
            return new UInt16Value(value);
        }

        /// <summary>
        /// Returns the UInt16 representation of a UInt16Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A UInt16Value object to retrieve a UInt16 representation.
        /// </param>
        /// <returns>A UInt16 value that represents a UInt16Value object.</returns>
        public static UInt16 ToUInt16(UInt16Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new UInt16Value(this);
        }
    }

    /// <summary>
    /// Represents the UInt32 value for attributes.
    /// </summary>
    [System.CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt32Value : OpenXmlSimpleValue<UInt32>
    {
        /// <summary>
        /// Initializes a new instance of the UInt32Value class.
        /// </summary>
        public UInt32Value()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt32Value class using the supplied UInt32 value.
        /// </summary>
        /// <param name="value">The UInt32 value.</param>
        public UInt32Value(UInt32 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt32Value class by deep copying the supplied UInt32Value class.
        /// </summary>
        /// <param name="source">The source UInt32Value class.</param>
        public UInt32Value(UInt32Value source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString());
                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToUInt32(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            UInt32 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToUInt32(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified UInt32Value class to a UInt32 value.
        /// </summary>
        /// <param name="xmlAttribute">The UInt32Value class to convert.</param>
        /// <returns>The converted UInt32 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator UInt32(UInt32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToUInt32(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a specified UInt32 value to a UInt32Value class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new UInt32Value instance with the value.</returns>
        public static implicit operator UInt32Value(UInt32 value)
        {
            return FromUInt32(value);
        }

        /// <summary>
        /// Returns a new UInt32Value object created from a UInt32 value.
        /// </summary>
        /// <param name="value">A UInt32 value to use to create a new UInt32Value object.</param>
        /// <returns>A UInt32Value class that corresponds to the value parameter.</returns>
        public static UInt32Value FromUInt32(UInt32 value)
        {
            return new UInt32Value(value);
        }

        /// <summary>
        /// Returns the UInt32 value representation of a UInt32Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A UInt32Value object used to retrieve a UInt32 value representation.
        /// </param>
        /// <returns>A UInt32 value that represents a UInt32Value object.</returns>		
        public static UInt32 ToUInt32(UInt32Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new UInt32Value(this);
        }
    }

    /// <summary>
    /// Represents the UInt64 value for attributes.
    /// </summary>
    [System.CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt64Value : OpenXmlSimpleValue<UInt64>
    {
        /// <summary>
        /// Initializes a new instance of the UInt64Value class.
        /// </summary>
        public UInt64Value()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt64Value class using the supplied UInt64 value.
        /// </summary>
        /// <param name="value">The UInt64 value.</param>
        public UInt64Value(UInt64 value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UInt64Value class by deep copying the UInt64Value class.
        /// </summary>
        /// <param name="source">The source UInt64Value class.</param>
        public UInt64Value(UInt64Value source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString());
                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToUInt64(this.TextValue); 
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            UInt64 value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToUInt64(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified UInt64Value object to a UInt64 value.
        /// </summary>
        /// <param name="xmlAttribute">The UInt64Value object to convert.</param>
        /// <returns>The converted UInt64 value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator UInt64(UInt64Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToUInt64(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a specified UInt64 value to a UInt64Value class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new UInt64Value instance with the value.</returns>
        public static implicit operator UInt64Value(UInt64 value)
        {
            return FromUInt64(value);
        }

        /// <summary>
        /// Returns a new UInt64Value object created from a UInt64 value.
        /// </summary>
        /// <param name="value">A UInt64 value to use to create a new UInt64Value object.</param>
        /// <returns>A UInt64Value that corresponds to the value parameter.</returns>
        public static UInt64Value FromUInt64(UInt64 value)
        {
            return new UInt64Value(value);
        }

        /// <summary>
        /// Returns the UInt64 value representation of a UInt64Value object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A UInt64Value object used to retrieve a UInt64 representation.
        /// </param>
        /// <returns>A UInt64 value that represents a UInt64Value object.</returns>
        public static UInt64 ToUInt64(UInt64Value xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new UInt64Value(this);
        }
    }
    
    /// <summary>
    /// Represents the decimal value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DecimalValue : OpenXmlSimpleValue<Decimal>
    {
        /// <summary>
        /// Initializes a new instance of the DecimalValue class.
        /// </summary>
        public DecimalValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DecimalValue class using the supplied
        /// Decimal value.
        /// </summary>
        /// <param name="value">The Decimal value.</param>
        public DecimalValue(Decimal value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DecimalValue class by deep copying
        /// the supplied DecimalValue class.
        /// </summary>
        /// <param name="source">
        /// The source DecimalValue class.
        /// </param>
        public DecimalValue(DecimalValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// The inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.TextValue == this.InnerValue.ToString() ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + this.InnerValue.ToString());

                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToDecimal(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Decimal value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToDecimal(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to a Decimal value.
        /// </summary>
        /// <param name="xmlAttribute">
        /// The DecimalValue to convert.
        /// </param>
        /// <returns>
        /// The converted Decimal value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Decimal(DecimalValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToDecimal(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the DecimalValue class by implicitly
        /// converting the supplied Decimal value.
        /// </summary>
        /// <param name="value">
        /// The Decimal value.
        /// </param>
        /// <returns>A new DecimalValue instance with the value.</returns>
        public static implicit operator DecimalValue(Decimal value)
        {
            return FromDecimal(value);
        }

        /// <summary>
        /// Returns a new DecimalValue object that was created from a Decimal value.
        /// </summary>
        /// <param name="value">A Decimal value to use to create a new DecimalValue object.</param>
        /// <returns>A DecimalValue object that corresponds to the value parameter.</returns>
        public static DecimalValue FromDecimal(Decimal value)
        {
            return new DecimalValue(value);
        }

        /// <summary>
        /// Returns the Decimal representation of a DecimalValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A DecimalValue object to use to retrieve a Decimal representation.
        /// </param>
        /// <returns>A Decimal value that represents a DecimalValue object.</returns>
        public static Decimal ToDecimal(DecimalValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new DecimalValue(this);
        }
    }

    /// <summary>
    /// Represents the Single value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class SingleValue : OpenXmlSimpleValue<Single>
    {
        /// <summary>
        /// Initializes a new instance of the SingleValue class.
        /// </summary>
        public SingleValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleValue class using the supplied Single value.
        /// </summary>
        /// <param name="value">The Single value.</param>
        public SingleValue(Single value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleValue class by deep copying the supplied SingleValue class.
        /// </summary>
        /// <param name="source">The source SingleValue class.</param>
        public SingleValue(SingleValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
#if DEBUG
                    if (this.InnerValue.HasValue && this.TextValue != null)
                    {
                        if (Single.IsPositiveInfinity(this.InnerValue.Value))
                        {
                            Debug.Assert(this.TextValue == "INF" || this.TextValue == "Infinity");
                        }
                        else if (Single.IsNegativeInfinity(this.InnerValue.Value))
                        {
                            Debug.Assert(this.TextValue == "-INF" || this.TextValue == "-Infinity");
                        }
                        else
                        {
                            Debug.Assert(this.TextValue == XmlConvert.ToString(this.InnerValue.Value) ||
                                // special case: signed number like text is "+5", value is 5
                                 this.TextValue != null && this.TextValue == "+" + XmlConvert.ToString(this.InnerValue.Value));
                        }
                    }
                    else
                    {
                        Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                     this.TextValue != null && !this.InnerValue.HasValue);
                    }
#endif
                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            float value = XmlConvert.ToSingle(this.TextValue);
            this.InnerValue = value;
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            this.InnerValue = null;

            try
            {
                Parse();
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified SingleValue object to a Single value.
        /// </summary>
        /// <param name="xmlAttribute">The SingleValue to convert.</param>
        /// <returns>
        /// The converted Single value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Single(SingleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToSingle(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified Single value to a SingleValue object.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new SingleValue instance with the value.</returns>
        public static implicit operator SingleValue(Single value)
        {
            return FromSingle(value);
        }

        /// <summary>
        /// Returns a new SingleValue object that was created from a Single value.
        /// </summary>
        /// <param name="value">A Single value to use to create a new SingleValue object.</param>
        /// <returns>A SingleValue object that corresponds to the value parameter.</returns>
        public static SingleValue FromSingle(Single value)
        {
            return new SingleValue(value);
        }

        /// <summary>
        /// Returns the Single value representation of a SingleValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A SingleValue object used to retrieve a Single value representation.
        /// </param>
        /// <returns>A Single value that represents a SingleValue object.</returns>
        public static Single ToSingle(SingleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new SingleValue(this);
        }
    }

    /// <summary>
    /// Represents the double value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DoubleValue : OpenXmlSimpleValue<Double>
    {
        /// <summary>
        /// Initializes a new instance of the DoubleValue class.
        /// </summary>
        public DoubleValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DoubleValue class using the supplied
        /// Double value.
        /// </summary>
        /// <param name="value">The Double value.</param>
        public DoubleValue(Double value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DoubleValue by deep copying the
        /// supplied DoubleValue value.
        /// </summary>
        /// <param name="source">
        /// The source DoubleValue class.
        /// </param>
        public DoubleValue(DoubleValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.InnerValue.Value.Equals(XmlConvert.ToDouble(this.TextValue))); // Use Double.Equals() to handle NaN.
                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToDouble(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            Double value;
            this.InnerValue = null;

            try
            {
                value = XmlConvert.ToDouble(this.TextValue);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to a Double value.
        /// </summary>
        /// <param name="xmlAttribute">
        /// The DoubleValue object to convert.
        /// </param>
        /// <returns>
        /// The converted Double value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator Double(DoubleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToDouble(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the DoubleValue class by implicitly
        /// converting the supplied Double value.
        /// </summary>
        /// <param name="value">
        /// The Double value.
        /// </param>
        /// <returns>A new DoubleValue instance with the value.</returns>
        public static implicit operator DoubleValue(Double value)
        {
            return FromDouble(value);
        }

        /// <summary>
        /// Returns a new DoubleValue object created from a Double value.
        /// </summary>
        /// <param name="value">A Double value to use to create a new DoubleValue object.</param>
        /// <returns>A DoubleValue object that corresponds to the value parameter.</returns>
        public static DoubleValue FromDouble(Double value)
        {
            return new DoubleValue(value);
        }

        /// <summary>
        /// Returns the Double value representation of a DoubleValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A DoubleValue object used to retrieve a Double value representation.
        /// </param>
        /// <returns>A Double value that represents a DoubleValue object.</returns>
        public static Double ToDouble(DoubleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new DoubleValue(this);
        }
    }

    /// <summary>
    /// Represents the DateTime value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DateTimeValue : OpenXmlSimpleValue<DateTime>
    {
        //the following format string is copied from System.IO.Packaging.PartBasedPackageProperties()
        //We use the XmlConvert.ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption)

        //private static string[] _dateTimeFormats;

        //private string[] DateTimeFormats
        //{
        //    get {
        //        if (_dateTimeFormats == null)
        //        {
        //            // copied from WindowsBase System.IO.Packaging.PartBasedPackageProperties()
        //            _dateTimeFormats = new string[] { 
        //                "yyyy-MM-ddTHH:mm:ss", "yyyy-MM-ddTHH:mm:ssZ", "yyyy-MM-ddTHH:mm:sszzz", @"\-yyyy-MM-ddTHH:mm:ss", @"\-yyyy-MM-ddTHH:mm:ssZ", @"\-yyyy-MM-ddTHH:mm:sszzz", "yyyy-MM-ddTHH:mm:ss.ff", "yyyy-MM-ddTHH:mm:ss.fZ", "yyyy-MM-ddTHH:mm:ss.fzzz", @"\-yyyy-MM-ddTHH:mm:ss.f", @"\-yyyy-MM-ddTHH:mm:ss.fZ", @"\-yyyy-MM-ddTHH:mm:ss.fzzz", "yyyy-MM-ddTHH:mm:ss.ff", "yyyy-MM-ddTHH:mm:ss.ffZ", "yyyy-MM-ddTHH:mm:ss.ffzzz", @"\-yyyy-MM-ddTHH:mm:ss.ff", 
        //                @"\-yyyy-MM-ddTHH:mm:ss.ffZ", @"\-yyyy-MM-ddTHH:mm:ss.ffzzz", "yyyy-MM-ddTHH:mm:ss.fff", "yyyy-MM-ddTHH:mm:ss.fffZ", "yyyy-MM-ddTHH:mm:ss.fffzzz", @"\-yyyy-MM-ddTHH:mm:ss.fff", @"\-yyyy-MM-ddTHH:mm:ss.fffZ", @"\-yyyy-MM-ddTHH:mm:ss.fffzzz", "yyyy-MM-ddTHH:mm:ss.ffff", "yyyy-MM-ddTHH:mm:ss.ffffZ", "yyyy-MM-ddTHH:mm:ss.ffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.ffff", @"\-yyyy-MM-ddTHH:mm:ss.ffffZ", @"\-yyyy-MM-ddTHH:mm:ss.ffffzzz", "yyyy-MM-ddTHH:mm:ss.fffff", "yyyy-MM-ddTHH:mm:ss.fffffZ", 
        //                "yyyy-MM-ddTHH:mm:ss.fffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.fffff", @"\-yyyy-MM-ddTHH:mm:ss.fffffZ", @"\-yyyy-MM-ddTHH:mm:ss.fffffzzz", "yyyy-MM-ddTHH:mm:ss.ffffff", "yyyy-MM-ddTHH:mm:ss.ffffffZ", "yyyy-MM-ddTHH:mm:ss.ffffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.ffffff", @"\-yyyy-MM-ddTHH:mm:ss.ffffffZ", @"\-yyyy-MM-ddTHH:mm:ss.ffffffzzz", "yyyy-MM-ddTHH:mm:ss.fffffff", "yyyy-MM-ddTHH:mm:ss.fffffffZ", "yyyy-MM-ddTHH:mm:ss.fffffffzzz", @"\-yyyy-MM-ddTHH:mm:ss.fffffff", @"\-yyyy-MM-ddTHH:mm:ss.fffffffZ", @"\-yyyy-MM-ddTHH:mm:ss.fffffffzzz"
        //                };
        //        }
        //        return _dateTimeFormats;
        //    }
        //}

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class.
        /// </summary>
        public DateTimeValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class using the supplied
        /// DateTime value.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        public DateTimeValue(DateTime value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class by deep copying the
        /// supplied DateTimeValue class.
        /// </summary>
        /// <param name="source">
        /// The source DateTimeValue class.
        /// </param>
        public DateTimeValue(DateTimeValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this.InnerValue.HasValue)
                {
                    // this.TextValue = this._value.ToString();
                    this.TextValue = XmlConvert.ToString(this.InnerValue.Value, XmlDateTimeSerializationMode.RoundtripKind);
                }
                else
                {
                    Debug.Assert(this.TextValue == null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && !this.InnerValue.HasValue ||
                                 this.TextValue != null && this.InnerValue == XmlConvert.ToDateTime( this.TextValue, System.Xml.XmlDateTimeSerializationMode.Utc));
                }
                return this.TextValue;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            // in System.IO.Packaging.PartBasedPackageProperties.GetDateData()
            // the code is: System.Xml.XmlConvert.ToDateTime(this.TextValue, this.DateTimeFormats);
            this.InnerValue = System.Xml.XmlConvert.ToDateTime( this.TextValue, System.Xml.XmlDateTimeSerializationMode.Utc);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            DateTime value;
            this.InnerValue = null;

            try
            {
                // in System.IO.Packaging.PartBasedPackageProperties.GetDateData()
                // the code is: System.Xml.XmlConvert.ToDateTime(this.TextValue, this.DateTimeFormats);
                value = System.Xml.XmlConvert.ToDateTime(this.TextValue, System.Xml.XmlDateTimeSerializationMode.Utc);
                this.InnerValue = value;
                return true;
            }
            catch (FormatException)
            {
                // can not convert 
                return false;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to a DateTime value.
        /// </summary>
        /// <param name="xmlAttribute">
        /// The DateTimeValue object to convert.
        /// </param>
        /// <returns>
        /// The converted DateTime value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator DateTime(DateTimeValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToDateTime(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class by implicitly
        /// converting the supplied DateTime value.
        /// </summary>
        /// <param name="value">
        /// The DateTime value.
        /// </param>
        /// <returns>A new DateTimeValue instance with the value.</returns>
        public static implicit operator DateTimeValue(DateTime value)
        {
            return FromDateTime(value);
        }

        /// <summary>
        /// Returns a new DateTimeValue object that was created from a DateTime value.
        /// </summary>
        /// <param name="value">A DateTime value to use to create a new DateTimeValue object.</param>
        /// <returns>A DateTimeValue object that corresponds to the value parameter.</returns>
        public static DateTimeValue FromDateTime(DateTime value)
        {
            return new DateTimeValue(value);
        }

        /// <summary>
        /// Returns the DateTime value representation of a DateTimeValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A DateTimeValue object used to retrieve a DateTime value representation.
        /// </param>
        /// <returns>A DateTime value that represents a DateTimeValue object.</returns>
        public static DateTime ToDateTime(DateTimeValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new DateTimeValue(this);
        }
    }

    /// <summary>
    /// Represents the string value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class StringValue : OpenXmlSimpleType
    {
        /// <summary>
        /// Initializes a new instance of the StringValue class.
        /// </summary>
        public StringValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringValue class using the supplied string.
        /// </summary>
        /// <param name="value">The string value.</param>
        public StringValue(string value)
            : base()
        {
            this.TextValue = value;
        }

        /// <summary>
        /// Initializes a new instance of the StringValue class by deep copying the supplied StringValue class.
        /// </summary>
        /// <param name="source">The source StringValue class.</param>
        public StringValue(StringValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets the string value.
        /// </summary>
        public string Value
        {
            get { return this.TextValue; }
            set { this.TextValue = value; }
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The StringValue to convert.</param>
        /// <returns>
        /// The converted String value. Returns null when xmlAttribute is null.
        /// </returns>
        public static implicit operator String(StringValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                return null;
            }

            return ToString(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified String value to a StringValue object.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new StringValue instance with the value.</returns>
        public static implicit operator StringValue(String value)
        {
            return FromString(value);
        }


        /// <summary>
        /// Returns a new StringValue object that was created from a String value.
        /// </summary>
        /// <param name="value">A String value to use to create a new StringValue object.</param>
        /// <returns>A StringValue that corresponds to the value parameter.</returns>
        public static StringValue FromString(String value)
        {
            return new StringValue(value);
        }

        /// <summary>
        /// Returns the String value representation of a StringValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A StringValue object used to retrieve a String value representation.
        /// </param>
        /// <returns>A String value that represents a StringValue object.</returns>
        public static String ToString(StringValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new StringValue(this);
        }
    }

    /// <summary>
    /// Represent the xsd:hexBinary value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class HexBinaryValue : OpenXmlSimpleType
    {
        /// <summary>
        /// Initializes a new instance of the HexBinaryValue class.
        /// </summary>
        public HexBinaryValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HexBinaryValue class using the supplied string.
        /// </summary>
        /// <param name="hexBinary">The string value.</param>
        public HexBinaryValue(string hexBinary)
            : base()
        {
            this.TextValue = hexBinary;
        }

        /// <summary>
        /// Initializes a new instance of the HexBinaryValue class by deep copying the supplied HexBinaryValue class.
        /// </summary>
        /// <param name="source">The source HexBinaryValue class.</param>
        public HexBinaryValue(HexBinaryValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets the hexBinary string value.
        /// </summary>
        public string Value
        {
            get { return this.TextValue; }
            set { this.TextValue = value; }
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The HexBinaryValue object to convert.</param>
        /// <returns>The converted HexBinary string. Returns null when xmlAttribute is null.</returns>
        public static implicit operator String(HexBinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                return null;
            }

            return ToString(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified String value to a HexBinaryValue object.
        /// </summary>
        /// <param name="value">The specified hexBinary value.</param>
        /// <returns>A new HexBinaryValue instance with the value.</returns>
        public static implicit operator HexBinaryValue(String value)
        {
            return FromString(value);
        }

        /// <summary>
        /// Returns a new HexBinaryValue object that was created from a String value.
        /// </summary>
        /// <param name="value">A String value to use to create a new HexBinaryValue object.</param>
        /// <returns>A HexBinaryValue object that corresponds to the value parameter.</returns>
        public static HexBinaryValue FromString(String value)
        {
            return new HexBinaryValue(value);
        }

        /// <summary>
        /// Returns the String value representation of a HexBinaryValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A HexBinaryValue object used to retrieve a String value representation.
        /// </param>
        /// <returns>A String value that represents a HexBinaryValue object.</returns>
        public static String ToString(HexBinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new HexBinaryValue(this);
        }
    }

    /// <summary>
    /// Represents the xsd:base64Binary value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Base64BinaryValue : OpenXmlSimpleType
    {
        /// <summary>
        /// Initializes a new instance of the Base64BinaryValue class.
        /// </summary>
        public Base64BinaryValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base64BinaryValue class by deep copying
        /// the supplied String value.
        /// </summary>
        /// <param name="base64Binary">
        /// The String value.
        /// </param>
        public Base64BinaryValue(string base64Binary)
            : base()
        {
            this.TextValue = base64Binary;
        }

        /// <summary>
        /// Initializes a new instance of the Base64BinaryValue class by deep copying
        /// the supplied Base64BinaryValue class.
        /// </summary>
        /// <param name="source">
        /// The source Base64BinaryValue class.
        /// </param>
        public Base64BinaryValue(Base64BinaryValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets the base64Binary string value.
        /// </summary>
        public string Value
        {
            get { return this.TextValue; }
            set { this.TextValue = value; }
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The Base64BinaryValue object to convert.</param>
        /// <returns>The base64Binary string. Returns null when xmlAttribute is null.</returns>
        public static implicit operator String(Base64BinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                return null;
            }

            return ToString(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of a Base64BinaryValue class using the
        /// supplied string.
        /// </summary>
        /// <param name="value">The specified base64Binary value.</param>
        /// <returns>A new Base64BinaryValue instance with the value.</returns>
        public static implicit operator Base64BinaryValue(String value)
        {
            return FromString(value);
        }

        /// <summary>
        /// Returns a new Base64BinaryValue object that was created from a String value.
        /// </summary>
        /// <param name="value">A String value to use to create a new Base64BinaryValue object.</param>
        /// <returns>A Base64BinaryValue that corresponds to the value parameter.</returns>
        public static Base64BinaryValue FromString(String value)
        {
            return new Base64BinaryValue(value);
        }

        /// <summary>
        /// Returns the String value representation of a Base64BinaryValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A Base64BinaryValue object used to retrieve a String value representation.
        /// </param>
        /// <returns>A String value that represents a Base64BinaryValue object.</returns>		
        public static String ToString(Base64BinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new Base64BinaryValue(this);
        }
    }

    /// <summary>
    /// Represents the list value attributes (xsd:list).
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class ListValue<T> : OpenXmlSimpleType
        where T : OpenXmlSimpleType, new()
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string _listSeparator = " ";

        private ObservableCollection<T> _list;

        /// <summary>
        /// Initializes a new instance of the ListValue class.
        /// </summary>
        public ListValue()
            : base( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the ListValue class using the supplied list of values.
        /// </summary>
        /// <param name="list">The list of the values.</param>
        public ListValue(IEnumerable<T> list)
            : base()
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }

            this._list =  new ObservableCollection<T>();
            this._list.CollectionChanged += this.CollectionChanged;

            foreach (T item in list)
            {
                this._list.Add(item.Clone() as T);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ListValue class by deep copying the supplied ListValue class.
        /// </summary>
        /// <param name="source">The source ListValue class.</param>
        public ListValue(ListValue<T> source)
            : this(source.Items)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is
        /// a valid value.
        /// </summary>
        public override bool HasValue
        {
            get
            {
                if (this._list == null)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        TryParse();
                    }
                }

                if (this._list == null)
                {
                    return false;
                }
                else
                {
                    return this._list.Count > 0;
                }
            }
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        public ICollection<T> Items 
        {
            get
            {
                if ( this._list == null )
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        Parse();
                    }
                    else
                    {
                        this._list = new ObservableCollection<T>();
                        this._list.CollectionChanged += this.CollectionChanged;
                    }
                }

                Debug.Assert(this._list != null);
                return  this._list;
            }
            //set
            //{
            //    this._list = value;
            //    this.TextValue = null;
            //}
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this._list = new ObservableCollection<T>();
            this._list.CollectionChanged += this.CollectionChanged;

            if (!String.IsNullOrEmpty(this.TextValue))
            {
                // split the string by white-space characters as the delimiters. 
                string[] items = this.TextValue.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in items)
                {
                    T itemValue = new T();
                    itemValue.InnerText = item;
                    this._list.Add(itemValue);
                }
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            if ( ! String.IsNullOrEmpty( this.TextValue ) )
            {
                // split the string by white-space characters as the delimiters. 
                string[] items = this.TextValue.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                var list = new ObservableCollection<T>();

                foreach (string item in items)
                {
                    T itemValue = new T();
                    itemValue.InnerText = item;
                    list.Add(itemValue);
                }

                this._list = list;
                this._list.CollectionChanged += this.CollectionChanged;
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this._list != null)
                {
                    StringBuilder textString = new StringBuilder();
                    string separator = String.Empty;

                    foreach (T value in this._list)
                    {
                        if (value != null)
                        {
                            textString.Append(separator);
                            textString.Append(value.ToString());
                            separator = _listSeparator;
                        }
                    }
                    this.TextValue = textString.ToString();
                } 
                return this.TextValue;
            }
            set
            {
                this.TextValue = value;
                this._list = null;
            }
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new ListValue<T>(this);
        }

        private void CollectionChanged(Object sender, NotifyCollectionChangedEventArgs e)
        {
            // clear the TextValue when the collection is changed.
            this.TextValue = null;
        }

        #region internal methods to be used by validation

        /// <summary>
        /// Only the ListValue will overrid this method.
        /// </summary>
        /// <returns>Returns items in list.</returns>
        internal override IEnumerable<OpenXmlSimpleType> GetListItems()
        {
            foreach (var item in this.Items)
            {
                yield return item;
            }
        }

        #endregion
    }

    /// <summary>
    /// Represents the enum value for attributes.
    /// </summary>
    /// <typeparam name="T">Every enum value must be an enum with the EnumStringValueAttribute object.</typeparam>
    [DebuggerDisplay("{InnerText}")]
    public class EnumValue<T> : OpenXmlSimpleType 
        where T : struct
    {
        private T? _enumValue;

        //********************************************************************************************
        // Performance profile for OpenXmlValidator shows that parsing string into Enum tooks 50% overall time.
        // The reason is that each time we use reflection to get all the strings for the enum.
        // So the performance is bad, especially for enums with many items like BorderValues.
        // 
        // Build a look up dictionary on fly if the enum is parsed for more than Threshold times.
        // This look up table will hooked on the type as static data.
        //********************************************************************************************

        // TODO: how do we know what the threashold should be???
        private const int Threshold = 11;
        private static int parseCount;
        private static Dictionary<string, T> stringToValueLookupTable;
        private static Dictionary<T, FileFormatVersions> fileFormatInformations;
        private static bool fileFormatInformationLoaded;
        private static object lockroot = new object();

        /// <summary>
        /// Initializes a new instance of the EnumValue class.
        /// </summary>
        public EnumValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EnumValue class using the supplied
        /// value of type T.
        /// </summary>
        /// <param name="value">
        /// The value of type T.
        /// </param>
        public EnumValue(T value)
            : base()
        {
            // bug O14 #253976
            if (!Enum.IsDefined(typeof(T), value))
            {
                throw new ArgumentOutOfRangeException("value", ExceptionMessages.InvalidEnumValue);
            }
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the EnumValue by deep copying the supplied
        /// EnumValue class.
        /// </summary>
        /// <param name="source">
        /// The source EnumValue class.
        /// </param>
        public EnumValue(EnumValue<T> source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            this._enumValue = source._enumValue;
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is a valid value.
        /// </summary>
        public override bool HasValue
        {
            get
            {
                if (!this._enumValue.HasValue)
                {
                    if (this.TextValue != null)
                    {
                        TryParse();
                    }
                }

                return this._enumValue.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value of the enum.
        /// </summary>
        public T Value
        {
            get
            {
                if (!this._enumValue.HasValue)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        Parse();
                    }
                }
                else
                {
                    Debug.Assert( this.TextValue == null || 
                                  this.TextValue == ToString(this._enumValue.Value));
                }
                return this._enumValue.Value;
            }
            set
            {
                // bug O14 #253976
                if (! Enum.IsDefined(typeof(T), value))
                {
                    throw new ArgumentOutOfRangeException("value", ExceptionMessages.InvalidEnumValue);
                }
                this._enumValue = value;
                this.TextValue = null;
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this._enumValue.HasValue)
                {
                    this.TextValue = ToString(this._enumValue.Value);
                }
                return this.TextValue;
            }
            set
            {
                this.TextValue = value;
                this._enumValue = null;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to an enum.
        /// </summary>
        /// <param name="xmlAttribute">The EnumValue to convert.</param>
        /// <returns>
        /// The converted enum value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator T(EnumValue<T> xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return xmlAttribute.Value;
        }

        /// <summary>
        /// Initializes a new EnumValue class by converting the supplied enum
        /// value.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new EnumValue instance corresponding to the value.</returns>		
        public static implicit operator EnumValue<T>(T value)
        {
            return new EnumValue<T>(value);
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted string.</returns>
        public static implicit operator String(EnumValue<T> value)
        {
            if (value == null)
                return null;
            
            return value.InnerText;
        }


        internal override OpenXmlSimpleType CloneImp()
        {
            return new EnumValue<T>(this); 
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this._enumValue = GetEnumValue(this.TextValue);
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            T value;
            this._enumValue = null;
            if ( TryGetEnumValue(this.TextValue, out value))
            {
                this._enumValue = value;
                return true;
            }
            return false;
        }

        internal static string ToString(T enumVal)
        {
            FieldInfo fi = enumVal.GetType().GetField(enumVal.ToString());
            EnumStringAttribute stringAttr = Attribute.GetCustomAttribute(fi, typeof(EnumStringAttribute)) as EnumStringAttribute;
            if (stringAttr != null)
            {
                return stringAttr.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        internal static bool TryGetEnumValue(string stringVal, out T result)
        {
            if (parseCount > Threshold)
            {
                if (stringToValueLookupTable == null)
                {
                    // build a look up table to improve performance.
                    Dictionary<string, T> lookupTable = new Dictionary<string, T>();

                    Array values = Enum.GetValues(typeof(T));
                    foreach (T enumVal in values)
                    {
                        FieldInfo fi = enumVal.GetType().GetField(enumVal.ToString());
                        EnumStringAttribute stringAttr = Attribute.GetCustomAttribute(fi, typeof(EnumStringAttribute)) as EnumStringAttribute;
                        lookupTable.Add(stringAttr.Value, enumVal);
                    }

                    stringToValueLookupTable = lookupTable;
                }

                Debug.Assert(stringToValueLookupTable != null && stringToValueLookupTable.Count > 0);
                return stringToValueLookupTable.TryGetValue( stringVal,out result);
            }
            else
            {
                parseCount++;


                Array values = Enum.GetValues(typeof(T));

                foreach (T enumVal in values)
                {
                    FieldInfo fi = enumVal.GetType().GetField(enumVal.ToString());
                    EnumStringAttribute stringAttr = Attribute.GetCustomAttribute(fi, typeof(EnumStringAttribute)) as EnumStringAttribute;
                    if (stringAttr != null && stringAttr.Value == stringVal)
                    {
                        result = enumVal;
                        return true;
                    }
                }

                result = new T();
                return false;
            }
        }

        internal static T GetEnumValue(string stringVal)
        {
            T result;

            if (TryGetEnumValue(stringVal, out result))
            {
                return result;
            }

            throw new FormatException(ExceptionMessages.TextIsInvalidEnumValue);
        }


        /// <summary>
        /// Test whether the value is allowed in the specified file format version.
        /// </summary>
        /// <param name="fileFormat">The file format version.</param>
        /// <returns>True if the value is defined in the specified file format version.</returns>
        /// <remarks>
        /// Method to support enum validation in schema validation.
        /// </remarks>
        internal override bool IsInVersion(FileFormatVersions fileFormat)
        {
            Debug.Assert( this.HasValue);

            if (!fileFormatInformationLoaded && fileFormatInformations == null)
            {
                Dictionary<T, FileFormatVersions> lookupTable = null;

                Array values = Enum.GetValues(typeof(T));

                foreach (T enumVal in values)
                {
                    FieldInfo fi = this.Value.GetType().GetField(enumVal.ToString());
                    OfficeAvailabilityAttribute versionAttr = Attribute.GetCustomAttribute(fi, typeof(OfficeAvailabilityAttribute)) as OfficeAvailabilityAttribute;
                    if (versionAttr != null)
                    {
                        if (lookupTable == null)
                        {
                            lookupTable = new Dictionary<T, FileFormatVersions>();
                        }
                        lookupTable.Add(enumVal, versionAttr.OfficeVersion);
                    }
                }

                lock (lockroot)
                {
                    fileFormatInformations = lookupTable;
                    fileFormatInformationLoaded = true;
                }
            }

            Debug.Assert(fileFormatInformationLoaded);
            if (fileFormatInformations != null)
            {
                FileFormatVersions supportedVersion;

                if (fileFormatInformations.TryGetValue(this.Value, out supportedVersion))
                {
                    return supportedVersion.Includes(fileFormat);
                }
                else
                {
                    // If the OfficeAvailabilityAttribute is not set, then it means the value item exist in both versions.            
                    return true;
                }
            }
            else
            {
                // all items are allowed in both Office2007 and Office2010.
                return true;
            }
        }
    }

    /// <summary>
    /// Represents the custom attribute for fields in a generated enum.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited=false, AllowMultiple=false)]
    public sealed class EnumStringAttribute : System.Attribute
    {
        /// <summary>
        /// Initializes a new instance of the EnumStringAttribute class using
        /// the supplied text string.
        /// </summary>
        /// <param name="value">The text string.</param>		
        public EnumStringAttribute(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the text string in the custom attribute.
        /// </summary>
        public string Value
        {
            get;
            private set;
        }
    }

    #region ST_OnOff related types
    /// <summary>
    /// Defines the base class implementing the common logic of
    /// <see cref="TrueFalseValue"/>, <see cref="TrueFalseBlankValue"/> and <see cref="OnOffValue"/>
    /// </summary>
    internal class TrueFalseValueImpl : OpenXmlSimpleType
    {
        // The method to convert text value to boolean value.
        private Func<string, Boolean> _getBooleanValueMethod;

        // The method to convert boolean value to default text value.
        private Func<Boolean, string> _getDefaultTextValueMethod;

        // The inner boolean value.
        private bool? _innerValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseValueImpl"/> class using the supplied callbacks.
        /// </summary>
        /// <param name="getBooleanValueMethod">The method to convert text value to boolean value.</param>
        /// <param name="getDefaultTextMethod">The method to convert boolean value to default text value.</param>
        public TrueFalseValueImpl(Func<string, Boolean> getBooleanValueMethod, Func<Boolean, string> getDefaultTextMethod)
            : base()
        {
            Debug.Assert(getBooleanValueMethod != null);
            Debug.Assert(getDefaultTextMethod != null);

            this._getBooleanValueMethod = getBooleanValueMethod;
            this._getDefaultTextValueMethod = getDefaultTextMethod;
        }

        /// <summary>
        /// Gets and sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                // it returns the real inner text such as "t", "f", "on", "off", etc,
                // rather than the Boolean.ToString() which is "True"/"False"
                if (this.TextValue == null && this._innerValue.HasValue)
                {
                    this.TextValue = _getDefaultTextValueMethod(this._innerValue.Value);
                }
                return this.TextValue;
            }
            set
            {
                this.TextValue = value;
                this._innerValue = null;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is a valid value.
        /// </summary>
        public override bool HasValue
        {
            get
            {
                if (!this._innerValue.HasValue)
                {
                    // Because it means when the text value is empty,
                    // so use this.TextValue != null rather than
                    // if (!String.IsNullOrEmpty(this.TextValue))
                    if (this.TextValue != null)
                    {
                        TryParse();
                    }
                }

                return this._innerValue.HasValue;
            }
        }

        /// <summary>
        /// Gets and sets the boolean value of the <see cref="TrueFalseValueImpl"/> type.
        /// </summary>
        public bool Value
        {
            get
            {
                if (!this._innerValue.HasValue)
                {
                    // Because TrueFalseBlankValue allows text value to emtpy string,
                    // here it has to user TextValue != null rather than
                    // if (!String.IsNullOrEmpty(this.TextValue))
                    if (this.TextValue != null)
                    {
                        Parse();
                    }
                }
                else
                {
                    Debug.Assert(this.TextValue == null ||
                                 _getBooleanValueMethod(this.TextValue) == this._innerValue.Value);
                }
                return this._innerValue.Value;
            }
            set
            {
                this._innerValue = value;
                this.TextValue = null;
            }
        }

        internal override void Parse()
        {
            this._innerValue = _getBooleanValueMethod(this.TextValue);
        }

        internal override bool TryParse()
        {
            Boolean value;
            this._innerValue = null;

            try
            {
                value = _getBooleanValueMethod(this.TextValue);
                this._innerValue = value;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Not implemented by <see cref="TrueFalseValueImpl"/>.
        /// </summary>
        /// <returns></returns>
        internal override OpenXmlSimpleType CloneImp()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Represents the data type for attributes that have enum values that are Boolean values that represent 't' or 'f', or 'true' or 'false'.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class TrueFalseValue : OpenXmlSimpleType
    {
        private TrueFalseValueImpl _impl;

        /// <summary>
        /// Initializes a new instance of <see cref="TrueFalseValue"/> class.
        /// </summary>
        public TrueFalseValue()
            : base()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TrueFalseValue"/> class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> value.</param>
        public TrueFalseValue(Boolean value)
        {
            Initialize();
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseValue"/> class using the supplied TrueFalseValue class.
        /// </summary>
        /// <param name="source">The source <see cref="TrueFalseValue"/> class.</param>
        public TrueFalseValue(TrueFalseValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            Initialize();
            _impl.InnerText = source.InnerText;
        }

        private void Initialize()
        {
            _impl = new TrueFalseValueImpl(
                GetBooleanValue,
                GetDefaultTextValue);
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is a valid value.
        /// </summary>
        public override bool HasValue
        {
            get
            {
                return _impl.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public Boolean Value
        {
            get
            {
                return _impl.Value;
            }
            set
            {
                _impl.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                return _impl.InnerText;
            }
            set
            {
                _impl.InnerText = value;
            }
        }

        /// <summary>
        /// Implicitly converts a TrueFalseValue class to a <see cref="Boolean"/> value.
        /// </summary>
        /// <param name="xmlAttribute">The <see cref="TrueFalseValue"/> to convert.</param>
        /// <returns>The converted <see cref="Boolean"/> value.</returns>
        public static implicit operator Boolean(TrueFalseValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Boolean"/> value to a TrueFalseValue instance.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> value to convert.</param>
        /// <returns>The converted <see cref="TrueFalseValue"/> value.</returns>
        public static implicit operator TrueFalseValue(Boolean value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new TrueFalseValue object that was created from a Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value to use to create a new TrueFalseValue object.</param>
        /// <returns>A TrueFalseValue that corresponds to the value parameter.</returns>
        public static TrueFalseValue FromBoolean(Boolean value)
        {
            return new TrueFalseValue(value);
        }

        /// <summary>
        /// Returns the internal Boolean representation of a TrueFalseValue object.
        /// </summary>
        /// <param name="xmlAttribute">A TrueFalseValue object to retrieve an internal Boolean representation.</param>
        /// <returns>A Boolean value that represents a TrueFalseValue object.</returns>
        public static Boolean ToBoolean(TrueFalseValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new TrueFalseValue(this);
        }

        /// <summary>
        /// Gets the real boolean value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 't', 'f', 'true', 'false'.</param>
        /// <returns>Ture on text value is 't', 'true'; False on text value is 'f', 'false'.</returns>
        private bool GetBooleanValue(string textValue)
        {
            if (textValue != null)
            {
                if ("true".Equals(textValue))
                {
                    return true;
                }
                else if ("false".Equals(textValue))
                {
                    return false;
                }
                else if ("t".Equals(textValue))
                {
                    return true;
                }
                else if ("f".Equals(textValue))
                {
                    return false;
                }
                else
                {
                    throw new FormatException(ExceptionMessages.TextIsInvalidTrueFalseValue);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the defaul text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"t" false true, "f" for false.</returns>
        private  string GetDefaultTextValue(bool boolValue)
        {
            // TODO : Needs to decide what are the defalut text values.
            return boolValue ? "true" : "false";
        }
    }

    /// <summary>
    /// Represents the datatype for attributes that have enum values that are Boolean values that represent 't' or 'f', or 'true' or 'false'.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class TrueFalseBlankValue : OpenXmlSimpleType
    {
        private TrueFalseValueImpl _impl;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class.
        /// </summary>
        public TrueFalseBlankValue()
            : base()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> value.</param>
        public TrueFalseBlankValue(Boolean value)
        {
            Initialize();
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseBlankValue"/> class using the supplied TrueFalseBlankValue class.
        /// </summary>
        /// <param name="source">The source <see cref="TrueFalseBlankValue"/> class.</param>
        public TrueFalseBlankValue(TrueFalseBlankValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            Initialize();
            _impl.InnerText = source.InnerText;
        }

        private void Initialize()
        {
            _impl = new TrueFalseValueImpl(
                GetBooleanValue,
                GetDefaultTextValue);
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is valid value.
        /// </summary>
        public override bool HasValue
        {
            get
            {
                return _impl.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public bool Value
        {
            get
            {
                return _impl.Value;
            }
            set
            {
                _impl.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                return _impl.InnerText;
            }
            set
            {
                _impl.InnerText = value;
            }
        }
        
        /// <summary>
        /// Implicitly converts a TrueFalseBlankValue object to a <see cref="Boolean"/> value.
        /// </summary>
        /// <param name="xmlAttribute">The source <see cref="TrueFalseBlankValue"/> to convert.</param>
        /// <returns>The converted <see cref="Boolean"/> value.</returns>
        public static implicit operator Boolean(TrueFalseBlankValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }
            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Boolean"/> value to a TrueFalsBlankValue value.
        /// </summary>
        /// <param name="value">The source <see cref="Boolean"/> value to convert.</param>
        /// <returns>The converted <see cref="TrueFalseBlankValue"/> value.</returns>
        public static implicit operator TrueFalseBlankValue(Boolean value)
        {
            return FromBoolean(value);
        }

        /// <summary>
        /// Returns a new TrueFalseBlankValue object created from a Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value to create a new TrueFalseBlankValue object from.</param>
        /// <returns>A TrueFalseBlankValue that corresponds to the value parameter.</returns>
        public static TrueFalseBlankValue FromBoolean(Boolean value)
        {
            return new TrueFalseBlankValue(value);
        }

        /// <summary>
        /// Returns the internal Boolean representation of a TrueFalseBlankValue object.
        /// </summary>
        /// <param name="xmlAttribute">A TrueFalseBlankValue object to retrieve an internal Boolean representation.</param>
        /// <returns>A Boolean value that represents a TrueFalseBlankValue object.</returns>
        public static Boolean ToBoolean(TrueFalseBlankValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new TrueFalseBlankValue(this);
        }

        /// <summary>
        /// Gets the real boolean value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 't', 'f', 'true', 'false', ''.</param>
        /// <returns>True on text value is 't', 'true'; False on text value is 'f', 'false', '' </returns>
        private bool GetBooleanValue(string textValue)
        {
            if (textValue != null)
            {
                if ("true".Equals(textValue))
                {
                    return true;
                }
                else if ("false".Equals(textValue))
                {
                    return false;
                }
                else if ("t".Equals(textValue))
                {
                    return true;
                }
                else if ("f".Equals(textValue))
                {
                    return false;
                }
                else if (textValue.Length == 0)
                {
                    // blank
                    return false;
                }
                else
                {
                    throw new FormatException(ExceptionMessages.TextIsInvalidTrueFalseBlankValue);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"t" for True, "f" for false.</returns>
        private string GetDefaultTextValue(bool boolValue)
        {
            // TODO : Define the defaul text value.
            return boolValue ? "true" : "false";
        }
    }

    /// <summary>
    /// Defines an OnOffValue datatype for attributes that have enum values that are Boolean values that represent: 'true' or 'false', 'on' or 'off', or '0' or '1'.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class OnOffValue : OpenXmlSimpleType
    {
        private TrueFalseValueImpl _impl;

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class.
        /// </summary>
        public OnOffValue()
            : base()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied Boolean value.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> value.</param>
        public OnOffValue(Boolean value)
            : base()
        {
            Initialize();
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="OnOffValue"/> class using the supplied OnOffValue class.
        /// </summary>
        /// <param name="source">The source <see cref="OnOffValue"/> class.</param>
        public OnOffValue(OnOffValue source)
            : base(source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            Initialize();
            _impl.InnerText = source.InnerText;
        }

        private void Initialize()
        {
            _impl = new TrueFalseValueImpl(
                GetBooleanValue,
                GetDefaultTextValue);
        }

        /// <summary>
        /// Gets a value that indicates whether the underneath text value is a valid value.
        /// </summary>
        public override bool HasValue
        {
            get
            {
                return _impl.HasValue;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public bool Value
        {
            get
            {
                return _impl.Value;
            }
            set
            {
                _impl.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                return _impl.InnerText;
            }
            set
            {
                _impl.InnerText = value;
            }
        }

        /// <summary>
        /// Gets the real text value of the text value.
        /// </summary>
        /// <param name="textValue">The text value which could be 'true', 'false', 'on', 'off', '0', or '1'.</param>
        /// <returns>True for 'true', 'on', '0', or '1'.</returns>
        private bool GetBooleanValue(string textValue)
        {
            if (textValue != null)
            {
                if ("true".Equals(textValue))
                {
                    return true;
                }
                else if ("false".Equals(textValue))
                {
                    return false;
                }
                else if ("on".Equals(textValue))
                {
                    return true;
                }
                else if ("off".Equals(textValue))
                {
                    return false;
                }
                else if ("1".Equals(textValue))
                {
                    return true;
                }
                else if ("0".Equals(textValue))
                {
                    return false;
                }
                else
                {
                    throw new FormatException(ExceptionMessages.TextIsInvalidOnOffValue);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the default text value.
        /// </summary>
        /// <param name="boolValue">The boolean value.</param>
        /// <returns>"1" for True, "0" for False.</returns>
        private string GetDefaultTextValue(Boolean boolValue)
        {
            // TODO : Defines the default text values.
            return boolValue ? "true" : "false";
        }

        internal override OpenXmlSimpleType CloneImp()
        {
            return new OnOffValue(this);
        }

        /// <summary>
        /// Implicitly converts the specified OnOffValue object to a <see cref="Boolean"/> value.
        /// </summary>
        /// <param name="xmlAttribute">The <see cref="OnOffValue"/> object to convert.</param>
        /// <returns>The converted <see cref="Boolean"/> value.</returns>
        public static implicit operator Boolean(OnOffValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new ArgumentNullException("xmlAttribute");
            }

            return ToBoolean(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Boolean"/> value to an <see cref="OnOffValue"/> value.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> value to convert.</param>
        /// <returns>The converted <see cref="OnOffValue"/>.</returns>
        public static implicit operator OnOffValue(Boolean value)
        {
            return FromBoolean(value);
        }


        /// <summary>
        /// Returns a new OnOffValue object created from a Boolean value.
        /// </summary>
        /// <param name="value">A Boolean value that is used to create a new OnOffValue object.</param>
        /// <returns>A OnOffValue that corresponds to the value parameter.</returns>
        public static OnOffValue FromBoolean(Boolean value)
        {
            return new OnOffValue(value);
        }

        /// <summary>
        /// Returns the internal Boolean representation of a OnOffValue object.
        /// </summary>
        /// <param name="xmlAttribute">A OnOffValue object to retrieve an internal Boolean representation.</param>
        /// <returns>A Boolean value that represents a OnOffValue object.</returns>
        public static Boolean ToBoolean(OnOffValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }
    }
    #endregion
}
