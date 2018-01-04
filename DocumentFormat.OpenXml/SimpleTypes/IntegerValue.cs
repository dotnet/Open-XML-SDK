// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
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
                throw new ArgumentNullException(nameof(source));
            }
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToInt64(this.TextValue);
        }

        /// <inheritdoc/>
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

        private protected override OpenXmlSimpleType CloneImpl() => new IntegerValue(this);
    }
}
