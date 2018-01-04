// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
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
            this.InnerValue = XmlConvert.ToSByte(this.TextValue);
        }

        /// <inheritdoc/>
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

        private protected override OpenXmlSimpleType CloneImpl() => new SByteValue(this);
    }
}
