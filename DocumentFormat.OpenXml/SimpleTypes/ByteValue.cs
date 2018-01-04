// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
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

        private protected override OpenXmlSimpleType CloneImpl() => new ByteValue(this);
    }
}
