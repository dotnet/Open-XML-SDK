// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
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

        /// <inheritdoc/>
        internal override void Parse()
        {
            this.InnerValue = XmlConvert.ToUInt16(this.TextValue);
        }

        /// <inheritdoc/>
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

        private protected override OpenXmlSimpleType CloneImpl() => new UInt16Value(this);
    }
}
