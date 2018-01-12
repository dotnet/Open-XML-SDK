// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
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

        private protected override OpenXmlSimpleType CloneImpl() => new DoubleValue(this);
    }
}
