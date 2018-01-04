// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
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

        private protected override OpenXmlSimpleType CloneImpl() => new DecimalValue(this);
    }
}
